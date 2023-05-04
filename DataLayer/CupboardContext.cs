using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
	public class CupboardContext : IDb<Cupboard, int>
	{
		private readonly LabDbContext dbContext;

		public CupboardContext(LabDbContext dbContext)
		{
			this.dbContext = dbContext;
		}

		public void Create(Cupboard item)
		{
			try
			{
				// TODO (MilenSh): Add check for PetriDishes property
				// (w/ the foreach and new List like in the Update method).

				dbContext.Cupboards.Add(item);
				dbContext.SaveChanges();
			}
			catch (Exception) { throw; }
		}

		public Cupboard Read(int key, bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<Cupboard> query = dbContext.Cupboards;

				if (useNavigationalProperties)
				{
					query = query.Include(c => c.PetriDishes);
				}

				return query.FirstOrDefault(c => c.Id == key);
			}
			catch (Exception) { throw; }
		}

		public IEnumerable<Cupboard> ReadAll(bool useNavigationalProperties = false)
		{
			try
			{
				IQueryable<Cupboard> query = dbContext.Cupboards;

				if (useNavigationalProperties)
				{
					query = query.Include(c => c.PetriDishes);
				}

				return query.ToList();
			}
			catch (Exception) { throw; }
		}

		public void Update(Cupboard item, bool useNavigationalProperties = false)
		{
			try
			{
				Cupboard cupboard = Read(item.Id, useNavigationalProperties);

				if (cupboard == null)
				{
					Create(item);
					return;
				}

				cupboard.Scientist = item.Scientist;
				cupboard.LightType = item.LightType;
				cupboard.Room = item.Room;

				if (useNavigationalProperties)
				{
					List<PetriDish> petriDishes = new();

					foreach (PetriDish pd in item.PetriDishes)
					{
						PetriDish petriDish = dbContext.PetriDishes.Find(pd.Id);

						if (petriDish != null)
						{
							petriDishes.Add(petriDish);
						}
						else
						{
							petriDishes.Add(pd);
						}
					}

					cupboard.PetriDishes = petriDishes;
				}

				dbContext.SaveChanges();
			}
			catch (Exception) { throw; }
		}

		public void Delete(int key)
		{
			try
			{
				Cupboard cupboard = Read(key);

				if (cupboard != null)
				{
					dbContext.Cupboards.Remove(cupboard);
					dbContext.SaveChanges();
				}
				else
				{
					throw new InvalidOperationException("A cupboard with that key does not exist!");
				}
			}
			catch (Exception) { throw; }
		}
	}
}
