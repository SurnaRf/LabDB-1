using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
	[TestFixture]
	public class CupboardContextTest
	{
		private CupboardContext context = new(SetupFixture.dbContext);
		private Cupboard cupboard;
		private PetriDish petriDish1;
		private PetriDish petriDish2;

		[SetUp]
		public void Setup()
		{
			cupboard = new("b901", "Merry", "direct sunlight");

			petriDish1 = new("water", 3.5f, DateTime.Now, cupboard);
			petriDish2 = new("water", 5.5f, DateTime.Now, cupboard);

			cupboard.PetriDishes.Add(petriDish1);
			cupboard.PetriDishes.Add(petriDish2);

			context.Create(cupboard);
		}

		[TearDown]
		public void DropCupboards()
		{
			foreach (Cupboard item in SetupFixture.dbContext.Cupboards.ToList())
			{
				SetupFixture.dbContext.Cupboards.Remove(item);
			}

			SetupFixture.dbContext.SaveChanges();
		}


		[Test]
		public void Create()
		{
			Cupboard testCupboard = new("a12", "Memi", "daylight");

			int cupboardsBefore = SetupFixture.dbContext.Cupboards.Count();

			context.Create(testCupboard);

			int cupboardsAfter = SetupFixture.dbContext.Cupboards.Count();

			Assert.That(cupboardsBefore + 1 == cupboardsAfter, "Create() does not work!");
		}

		[Test]
		public void Read()
		{
			Cupboard readCupboard = context.Read(cupboard.Id);

			Assert.AreEqual(cupboard, readCupboard, "Read does not return the same object!");
		}

		[Test]
		public void ReadWithNavigationalProperties()
		{
			Cupboard readCupboard = context.Read(cupboard.Id, true);

			Assert.That(readCupboard.PetriDishes.Contains(petriDish1)
				&& readCupboard.PetriDishes.Contains(petriDish2), 
				"PetriDish1 and petriDish2 are not in the PetriDishes list!");
		}

		[Test]
		public void ReadAll()
		{
			List<Cupboard> cupboards = (List<Cupboard>)context.ReadAll();

			Assert.That(cupboards.Count != 0, "ReadAll() does not return cupboards!");
		}

		[Test]
		public void ReadAllWithNavigationalProperties()
		{
			Cupboard readCupboard = new("c16", "Memi", "uv");
			PetriDish petriDish = new("water", 6.5f, DateTime.Now, readCupboard);
			SetupFixture.dbContext.PetriDishes.Add(petriDish);
			SetupFixture.dbContext.Cupboards.Add(readCupboard);
			context.Create(readCupboard);

			List<Cupboard> cupboards = (List<Cupboard>)context.ReadAll(true);
		
			Assert.That(cupboards.Count != 0 
				&& context.Read(readCupboard.Id, true).PetriDishes.Count == 1 ,"ReadAll() does not return cupboards!");
		}

		[Test]
		public void Update()
		{
			Cupboard changedCupboard = context.Read(cupboard.Id);

			changedCupboard.Room = "e34";
			changedCupboard.Scientist = "Memche";

			context.Update(changedCupboard);

			Assert.AreEqual(changedCupboard, cupboard, "Update() does not work!");
		}

		//[Test]
		//public void UpdateWithNavigationalProperties()
		//{
		//	//finish
		//}

		[Test]
		public void Delete()
		{
			int cupboardsBefore = SetupFixture.dbContext.Cupboards.Count();

			context.Delete(cupboard.Id);
			int cupboardsAfter = SetupFixture.dbContext.Cupboards.Count();

			Assert.IsTrue(cupboardsBefore - 1 == cupboardsAfter, "Delete() does not work!");
		}
	}
}
