using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static INTERFACES.Interfaces;

namespace AnimeNamespace
{
	public class Anime : IAnime
	{
		public int Day { get; set; }
		public String Name { get; set; }
		public int Length { get; set; }
		public Anime(int day, String name, int length)
		{
			Day = day;
			Name = name;
			Length = length;
		}
		public Anime(){}

		public override string ToString()
		{
			return "Name :" + Name.ToString() + "  ; Length :" + Length.ToString() + "  ; Broadcsting day :" + Day.ToString();
		}

	}
}
