using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAONamespace;
using AnimeNamespace;
using INTERFACES;
using static INTERFACES.Interfaces;
using System.Reflection;
using System.Configuration;
using BL.Properties;

namespace BLNamespace
{
	public class BL : IBL
	{
		private IDAO dao;
		private Assembly DAODummy = Assembly.UnsafeLoadFrom(Settings.Default.filePath);

		public List<IAnime> getDataBase()
		{
			var types = DAODummy.GetTypes();
			Type lateBindingType = null;

			foreach (var t in DAODummy.GetTypes())
			{
				if (typeof(IDAO).IsAssignableFrom(t))
				{
					lateBindingType = t;
					break;
				}
			}

			if (lateBindingType != null)
			{
				var lateBind = Activator.CreateInstance(lateBindingType);
				dao = (IDAO)lateBind;
				return dao.getList();
			}
			else
			{
				return null;
			}
		}
	}
}
