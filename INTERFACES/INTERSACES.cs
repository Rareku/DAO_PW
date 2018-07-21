using System;
using System.Collections.Generic;

namespace INTERFACES
{
	public class Interfaces
	{

		public interface IDAO
		{
			List<IAnime> getList();
		}

		public interface IBL
		{
			List<IAnime> getDataBase();
		}
		public interface IAnime
		{
			int Day { get; set; }
			string Name { get; set; }
			int Length { get; set; }
		}
	}
}
