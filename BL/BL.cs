using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAONamespace;
using AnimeNamespace;
using INTERFACES;
using static INTERFACES.Interfaces;

namespace BLNamespace
{
	public class BL : IBL
	{
		private DAO dao = new DAO();
		public List<IAnime> getDataBase()
		{
			return dao.getList();
		}
	}
}
