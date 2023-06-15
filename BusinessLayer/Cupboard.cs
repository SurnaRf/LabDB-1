using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Cupboard
    {
        #region Properties

        [Key]
        public int Id { get; set; }

        [Required]
        public string Room { get; set; }

        [Required]
        public string Scientist { get; set; }

        [Required]
        public string LightType { get; set; }

        #endregion

        #region Navigation

        public List<PetriDish> PetriDishes { get; set; }

        #endregion

        private Cupboard()
        {
            PetriDishes = new();
        }

        public Cupboard(
            string room,
            string scientist,
            string lightType)
            : this()
        {
            Room = room;
            Scientist = scientist;
            LightType = lightType;
        }

		public override string ToString()
		{
			return $"<{Id}>-{Room}-{Scientist}-{LightType}";
		}
	}
}
