using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class ContextGenerator
    {
        private static LabDbContext dbContext;
        private static ColonyContext colonyContext;
        private static CupboardContext cupboardContext;
        private static PetriDishContext petriDishContext;

        public static LabDbContext GetDbContext() 
        {
            if (dbContext == null)
            {
                SetDbContext();
            }
            return dbContext;
        }

        public static void SetDbContext()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
            dbContext = new LabDbContext();
        }

        public static ColonyContext GetColonyContext()
        {
            if (colonyContext == null)
            {
                SetColonyContext();
            }
            return colonyContext;
        }

        private static void SetColonyContext()
        {
            colonyContext = new ColonyContext(GetDbContext());
        }
        public static CupboardContext GetCupboardContext()
        {
            if (cupboardContext == null)
            {
                SetCupboardContext();
            }
            return cupboardContext;
        }

        private static void SetCupboardContext()
        {
            cupboardContext = new CupboardContext(GetDbContext());
        }
        public static PetriDishContext GetPetriDishContext()
        {
            if (petriDishContext == null)
            {
                SetPetriDishContext();
            }
            return petriDishContext;
        }

        private static void SetPetriDishContext()
        {
            petriDishContext = new PetriDishContext(GetDbContext());
        }

    }
}
