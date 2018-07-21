using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using BLNamespace;
using AnimeNamespace;

namespace Nykaza.BazaDanych.DAO
{
    public class UI
    {
		private static BL bl = new BL();
        public static void Main(string[] args)
        {
            bl.getDataBase().ForEach(delegate (Anime elem) { Console.WriteLine(elem.ToString()); });
            Console.ReadLine();
        }
    }




}
