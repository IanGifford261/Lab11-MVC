using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab11_MVC.Models;
using Lab11_MVC.Controllers;
using System.IO;

namespace Lab11_MVC.Models
{
    public class Wine
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public string Designation { get; set; }
        public int Points { get; set; }
        public decimal Price{ get; set; }
        public string Region_1 { get; set; }
        public string Region_2 { get; set; }
        public string Variety { get; set; }
        public string Winery { get; set; }

        public static List<Wine> GetWineList(int minimumPoints, int maximumPrice)
        {
            List<Wine> wineList = new List<Wine>();
            string filePath = "../../wine.csv";
            //var filePath = new StreamReader(File.OpenRead("../../wine.csv"));
            using (StreamReader sr = new StreamReader(filePath))
            {
                ;
            }
        }

        }
    }
}
