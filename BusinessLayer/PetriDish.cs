using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BusinessLayer
{
    public class PetriDish
    {
        #region Properties

        [Key]
        public int Id { get; set; }

        [Required]
        public string Solvant { get; set; }

        public float Diameter { get; set; }

        public DateTime LastCheckDate { get; set; }

        #endregion

        #region Navigation

        [ForeignKey("Cupboard")]
        public int CupboardId { get; set; }
        public Cupboard Cupboard { get; set; }

        public List<Colony> Colonies { get; set; }

        #endregion
        
        private PetriDish()
        {
            Colonies = new();
        }

        public PetriDish(
            string solvant,
            float diameter,
            DateTime lastCheckDate,
            Cupboard cupboard)
            : this()
        {
            Solvant = solvant;
            Diameter = diameter;
            LastCheckDate = lastCheckDate;
        }
    }
}
