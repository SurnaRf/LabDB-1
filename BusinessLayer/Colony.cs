using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class Colony
    {
        #region Properties

        [Key]
        public int Id { get; set; }

        [Required]
        public string BacteriaType { get; set; }

        public int Count { get; set; }

        public int Days { get; set; }

        #endregion

        #region Navigation

        [ForeignKey("PetriDish")]
        public int PetriDishId { get; set; }
        public PetriDish PetriDish { get; set; }

        #endregion

        private Colony()
        {

        }

        public Colony(
            string bacteriaType,
            int count,
            int days,
            PetriDish petriDish)
        {
            BacteriaType = bacteriaType;
            Count = count;
            Days = days;
            PetriDish = petriDish;
        }
    }
}
