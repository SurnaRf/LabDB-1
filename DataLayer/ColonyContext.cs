using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
	public class ColonyContext : IDb<Colony, int>
	{
		private readonly LabDbContext dbContext;

		public ColonyContext(LabDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public void Create(Colony item)
		{
			try
			{
				PetriDish petriDish = dbContext.PetriDishes.Find(item.PetriDishId);

				if (petriDish != null)
				{
					item.PetriDish = petriDish;
				}

				dbContext.Colonies.Add(item);
				dbContext.SaveChanges();
			}
            catch (Exception) { throw; }
        }

		public Colony Read(int key, bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<Colony> query = dbContext.Colonies;

				if (useNavigationalProperties)
				{
					query = query.Include(c => c.PetriDish);
				}
				return query.FirstOrDefault(c => c.Id == key);
			}
            catch (Exception) { throw; }
        }

		public IEnumerable<Colony> ReadAll(bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<Colony> query = dbContext.Colonies;

				if (useNavigationalProperties)
				{
					query = query.Include(c => c.PetriDish);
				}

				return query.ToList();
			}
            catch (Exception) { throw; }
        }

		public void Update(Colony item, bool useNavigationalProperties = false)
		{
			try
			{
				Colony colony = Read(item.Id, useNavigationalProperties);

				if (colony == null)
				{
					Create(item);
					return;
				}

				colony.BacteriaType = item.BacteriaType;
				colony.Days = item.Days;
				colony.Count = item.Count;

				if (useNavigationalProperties)
				{
					PetriDish petriDish = dbContext.PetriDishes.Find(item.PetriDishId);

					if (petriDish != null)
					{
						colony.PetriDish = petriDish;
					}
					else
					{
						colony.PetriDish = item.PetriDish;
					}
				}

				dbContext.SaveChanges();
			}
            catch (Exception) { throw; }
        }

		public void Delete(int key)
		{
			try
			{
				Colony colony = Read(key);
				if (colony != null)
				{
					dbContext.Colonies.Remove(colony);
					dbContext.SaveChanges();
				}
				else
				{
					throw new InvalidOperationException("A colony with that key does not exist!");
				}
			}
            catch (Exception) { throw; }
        }
	}
}
