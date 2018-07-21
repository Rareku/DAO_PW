using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimeNamespace;
using static INTERFACES.Interfaces;

namespace DAONamespace
{
	public class DAO : IDAO
	{
		private enum Day { Monday = 0, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
		private List<IAnime> listy = new List<IAnime>() { new Anime((int)Day.Monday, "Bleach", 24), new Anime((int)Day.Wednesday, "Osuma Game", 12), new Anime((int)Day.Sunday, "One Piece", 12) };
		public List<IAnime> getList()
		{
			return listy;
		}

	}
}
