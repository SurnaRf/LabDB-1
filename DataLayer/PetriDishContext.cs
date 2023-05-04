using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
	public class PetriDishContext : IDb<PetriDish, int>
	{
		private readonly LabDbContext dbContext;

		public PetriDishContext(LabDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public void Create(PetriDish item)
		{
			try
			{
				Cupboard cupboard = dbContext.Cupboards.Find(item.CupboardId);

				if (cupboard != null)
				{
					item.Cupboard = cupboard;
				}

                List<Colony> colonies = new List<Colony>();

                foreach (Colony c in item.Colonies)
                {
                    Colony colony = dbContext.Colonies.Find(c.Id);

                    if (colony != null)
                    {
                        colonies.Add(colony);
                    }
                    else
                    {
                        colonies.Add(c);
                    }
                }
				item.Colonies = colonies;

                dbContext.PetriDishes.Add(item);
				dbContext.SaveChanges();
			}
			catch (Exception) { throw; }
		}

		public PetriDish Read(int key, bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<PetriDish> query = dbContext.PetriDishes;

				if (useNavigationalProperties)
				{
					query = query.Include(p => p.Cupboard)
								.Include(p => p.Colonies);
				}

				return query.FirstOrDefault(p => p.Id == key);
			}
            catch (Exception) { throw; }
        }

		public IEnumerable<PetriDish> ReadAll(bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<PetriDish> query = dbContext.PetriDishes;

				if (useNavigationalProperties)
				{
					query = query.Include(p => p.Cupboard)
								.Include(p => p.Colonies);
				}

				return query.ToList();
			}
            catch (Exception) { throw; }
        }

		public void Update(PetriDish item, bool useNavigationalProperties = false)
		{
			try
			{
				PetriDish petriDish = Read(item.Id, useNavigationalProperties);

				if (petriDish == null)
				{
					Create(item);
					return;
				}

				petriDish.Diameter = item.Diameter;
				petriDish.Solvent = item.Solvent;
				petriDish.LastCheckDate = item.LastCheckDate;

				if (useNavigationalProperties)
				{
					Cupboard cupboard = dbContext.Cupboards.Find(item.CupboardId);

					if (cupboard!=null)
					{
						petriDish.Cupboard = cupboard;
					}
					else
					{
						petriDish.Cupboard = item.Cupboard;
					}

					List<Colony> colonies = new List<Colony>();

					foreach (Colony c in item.Colonies)
					{
						Colony colony = dbContext.Colonies.Find(c.Id);

						if (colony != null)
						{
							colonies.Add(colony);
						}
						else
						{
							colonies.Add(c);
						}
					}
					petriDish.Colonies = colonies;
				}
				dbContext.SaveChanges();
			}
            catch (Exception) { throw; }
        }
		public void Delete(int key)
		{
			try
			{
				PetriDish petriDish = Read(key);

				if (petriDish != null)
				{
					dbContext.PetriDishes.Remove(petriDish);
					dbContext.SaveChanges();
				}
				else
				{
					throw new InvalidOperationException("A petri dish with that key does not exist");
				}
			}
            catch (Exception) { throw; }
        }
	}
}
