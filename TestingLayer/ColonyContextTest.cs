using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BusinessLayer;
using DataLayer;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace TestingLayer
{
    [TestFixture]
    class ColonyContextTest
    {
        private ColonyContext context = new(SetupFixture.dbContext);
        private Colony colony;
        private PetriDish petriDish;

        [SetUp]
        public void SetUp() 
        {
            colony = new("lactobacilicus", 34, 42, petriDish);
            petriDish = new("water", 5, DateTime.Now, new("A15", "Niet Snie", "infrared"));

            context.Create(colony);
        }

        [TearDown]
        public void DropColony()
        {
            foreach (Colony item in SetupFixture.dbContext.Colonies.ToList())
            {
                SetupFixture.dbContext.Colonies.Remove(item);
            }

            SetupFixture.dbContext.SaveChanges();
        }

        [Test]
        public void Create() 
        {
            Colony newColony = new("luumu", 41, 20, petriDish);
            
            int coloniesBefore = SetupFixture.dbContext.Colonies.Count();
            context.Create(newColony);

            int coloniesAfter = SetupFixture.dbContext.Colonies.Count();
            Assert.IsTrue(coloniesBefore + 1 == coloniesAfter, "Count() does not work!");
        }

        [Test]
        public void Read()
        {
            Colony readColony = context.Read(colony.Id);

            Assert.AreEqual(colony, readColony, "Read does not return the same object!");
        }

        [Test]
        public void ReadWithNavigationalProperties()
        {
            Colony readColony = context.Read(colony.Id, true);

            Assert.That(
                readColony.PetriDish.Equals(petriDish), 
                "PetriDish is not in the colony!");
        }

        [Test]
        public void ReadAll()
        {
            List<Colony> colonies = (List<Colony>)context.ReadAll();

            Assert.That(colonies.Count != 0, "ReadAll() does not return colonies!");
        }

        [Test]
        public void Update()
        {
            Colony changedColony = context.Read(colony.Id);

            changedColony.Count -= 1;
            changedColony.BacteriaType = "moomintroll";
            changedColony.Days -= 1;

            context.Update(changedColony);

            Assert.AreEqual(changedColony, colony, "Update() does not work!");
        }

        [Test]
        public void Delete()
        {
            int coloniesBefore = SetupFixture.dbContext.Colonies.Count();

            context.Delete(colony.Id);
            int coloniesAfter = SetupFixture.dbContext.Colonies.Count();

            Assert.IsTrue(coloniesBefore - 1 == coloniesAfter, "Delete() does not work!");
        }
    }
}
