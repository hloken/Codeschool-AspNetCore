using System.Collections.Generic;

namespace CharacterSheetApp.Models
{
	public class Character
	{
		public string Name { get; set; }
        public bool IsActive { get; set; }

		public static void Create(string characterName)
		{
			var character = new Character {Name = characterName};

			GlobalVariables.Characters.Add(character);
		}

		public static List<Character> GetAll()
		{
			return GlobalVariables.Characters;
		}
	}
}
