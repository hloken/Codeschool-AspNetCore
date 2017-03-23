using System.Collections.Generic;
using CharacterSheetApp.Models;

namespace CharacterSheetApp
{
	public static class GlobalVariables
	{
		public static List<Models.Character> Characters { get; set; }
			= new List<Character>();
	}
}