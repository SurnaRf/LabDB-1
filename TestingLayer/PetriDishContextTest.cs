using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
using NUnit.Framework;

namespace TestingLayer
{
	[TestFixture]
	class PetriDishContextTest
	{
		private PetriDishContext context = new(SetupFixture.dbContext);
		private PetriDish petriDish;
		private Colony colony1, colony2;
		private Cupboard cupboard;

		[SetUp]
		public void CreatePetriDish()
		{
			cupboard = new("A15", "Niet Snie", "infrared");
			petriDish = new("water", 5, DateTime.Now, cupboard);

			colony1 = new("some1", 12, 4, petriDish);
			colony2 = new("some2", 15, 5, petriDish);

			petriDish.Colonies.Add(colony1);
			petriDish.Colonies.Add(colony2);

			context.Create(petriDish);
		}

		[TearDown]
		public void DropPetriDish()
		{
			foreach (PetriDish item in SetupFixture.dbContext.PetriDishes.ToList())
			{
				SetupFixture.dbContext.PetriDishes.Remove(item);
			}

			SetupFixture.dbContext.SaveChanges();
		}

		[Test]
		public void Create()
		{
			// Arrange
			PetriDish newDish = new("acid", 3.5f, DateTime.Now, cupboard);

			// Act
			int dishesBefore = SetupFixture.dbContext.PetriDishes.Count();
			context.Create(newDish);

			// Assert
			int dishesAfter = SetupFixture.dbContext.PetriDishes.Count();
			Assert.IsTrue(dishesBefore + 1 == dishesAfter, "Create() does not work!");
		}

		[Test]
		public void Read()
		{
			PetriDish readDish = context.Read(petriDish.Id);

			Assert.AreEqual(petriDish, readDish, "Read does not return the same object!");
		}

		[Test]
		public void ReadWithNavigationalProperties()
		{
			PetriDish readDish = context.Read(petriDish.Id, true);

			Assert.That(
				readDish.Colonies.Contains(colony1)
				&& readDish.Colonies.Contains(colony2)
				&& readDish.Cupboard == cupboard, "Colony1 and Coloby2 are not in the Colonies list!");
		}

		[Test]
		public void ReadAll()
		{
			List<PetriDish> dishes = (List<PetriDish>)context.ReadAll();

			Assert.That(dishes.Count != 0, "ReadAll() does not return dishes!");
		}

		[Test]
		public void Update()
		{
			PetriDish changedDish = context.Read(petriDish.Id);

			changedDish.Diameter -= 1;
			changedDish.Solvent = "glucose";

			context.Update(changedDish);

			Assert.AreEqual(changedDish, petriDish, "Update() does not work!");
		}

		[Test]
		public void Delete()
		{
			int dishesBefore = SetupFixture.dbContext.PetriDishes.Count();

			context.Delete(petriDish.Id);
			int dishesAfter = SetupFixture.dbContext.PetriDishes.Count();

			Assert.IsTrue(dishesBefore - 1 == dishesAfter, "Delete() does not work!");
		}
	}
}
