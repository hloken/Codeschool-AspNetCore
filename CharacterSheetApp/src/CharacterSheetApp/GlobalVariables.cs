using System.Collections.Generic;
using CharacterSheetApp.Models;

namespace CharacterSheetApp
{
	public static class GlobalVariables
	{
		private static List<Models.Character> _charactersInstance;
		public static List<Models.Character> Characters
		{
			get
			{
				if (_charactersInstance == null)
					_charactersInstance = new List<Character>();

				return _charactersInstance;
			}
		}
	}
}