using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using BLNamespace;
using AnimeNamespace;
using static INTERFACES.Interfaces;

namespace Nykaza.BazaDanych.DAO
{
    public class UI
    {
		private static BLNamespace.BL bl = new BLNamespace.BL();
        public static void Main(string[] args)
        {
			List<IAnime> a = bl.getDataBase();
			foreach (Anime b in a)
			{
				Console.WriteLine(b.ToString());
			}
            Console.ReadLine();
        }
    }




}
