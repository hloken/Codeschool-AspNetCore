using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CharacterSheetApp.Models
{
	public class Character
	{
        [Key]
        [Required]
        [MinLength(3, ErrorMessage = "Your character name must be at least 3 characters long.")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Your level must be between 1 and 20.")]
        public int Level
        {
            get; set;
        }

        [Required]
        [Range(1, 18, ErrorMessage = "Your base strength must be between 1 and 18.")]
        public int Strength
        {
            get; set;
        }

        [Required(ErrorMessage = "The Dexterity field is required.")]
        [Range(1, 18, ErrorMessage = "Your base dexterity must be between 1 and 18.")]
        public int Dexterity
        {
            get; set;
        }

        [Required]
        [Range(1, 18, ErrorMessage = "Your base intelligence must be between 1 and 18.")]
        public int Intelligence
        {
            get; set;
        }

        //public List<Equipment> Equipment { get; set; } = new List<Equipment>();

  //      public static void Create(string characterName)
		//{
		//	var character = new Character {Name = characterName};

		//	GlobalVariables.Characters.Add(character);
		//}

		//public static List<Character> GetAll()
		//{
		//	return GlobalVariables.Characters;
		//}
	}
}
