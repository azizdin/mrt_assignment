﻿using MRT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MRT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult BuyTicket()
        {
            return View();
        }


        [HttpPost]
        public ViewResult thanks()
        {
           
                return View("thanks");
        }


        [HttpPost]
        public ViewResult BuyTicket(Route routeRate)
        {
            if (ModelState.IsValid)
            {
                double[,] rate =
                {{ 0.80, 1.20, 1.80, 2.00, 2.60, 2.70, 3.10, 3.30, 3.20, 3.50, 3.30, 3.40, 3.10, 3.20, 3.30, 3.40, 3.50, 3.60, 3.70, 3.90, 4.00, 4.10, 4.30, 4.50, 4.60, 4.80, 4.80, 5.00, 5.30, 5.40, 5.50 },
             { 1.20, 0.80, 1.50, 1.80, 2.30, 2.70, 2.80, 3.10, 3.40, 3.30, 3.70, 3.30, 3.70, 3.80, 3.20, 3.30, 3.40, 3.50, 3.60, 3.80, 3.90, 4.00, 4.20, 4.40, 4.50, 4.60, 4.70, 4.90, 5.20, 5.20, 5.40 },
             { 1.80, 1.50, 0.80, 1.10, 1.80, 2.10, 2.60, 2.60, 3.00, 3.20, 3.30, 3.50, 3.40, 3.50, 3.60, 3.70, 3.20, 3.30, 3.40, 3.50, 3.60, 3.80, 3.90, 4.20, 4.30, 4.40, 4.50, 4.60, 4.90, 5.00, 5.10 },
             { 2.00, 1.80, 1.10, 0.80, 1.60, 1.90, 2.30, 2.60, 2.80, 3.00, 3.10, 3.30, 3.80, 3.40, 3.40, 3.60, 3.80, 3.20, 3.30, 3.40, 3.50, 3.70, 3.80, 4.00, 4.10, 4.30, 4.40, 4.50, 4.80, 4.00, 5.00 },
             { 2.60, 2.30, 1.80, 1.60, 0.80, 1.30, 1.80, 2.00, 2.40, 2.80, 3.00, 3.20, 3.30, 3.50, 3.60, 3.20, 3.40, 3.60, 3.70, 3.20, 3.20, 3.40, 3.50, 3.70, 3.90, 4.00, 4.10, 4.30, 4.60, 4.60, 4.80 },
             { 2.70, 2.70, 2.10, 1.90, 1.30, 0.80, 1.30, 1.70, 2.00, 2.40, 2.70, 2.90, 3.10, 3.30, 3.40, 3.60, 3.80, 3.40, 3.50, 3.70, 3.80, 3.20, 3.40, 3.60, 3.70, 3.90, 4.00, 4.10, 4.40, 4.50, 4.60 },
             { 3.10, 2.80, 2.60, 2.30, 1.80, 1.30, 0.80, 1.30, 1.70, 2.00, 2.60, 2.80, 3.20, 3.40, 3.10, 3.30, 3.50, 3.70, 3.20, 3.50, 3.60, 3.80, 3.20, 3.40, 3.60, 3.70, 3.80, 3.90, 4.20, 4.30, 4.40 },
             { 3.30, 3.10, 2.60, 2.60, 2.00, 1.70, 1.30, 0.80, 1.30, 1.70, 2.20, 2.50, 2.90, 3.10, 3.20, 3.40, 3.20, 3.40, 3.60, 3.80, 3.30, 3.40, 3.60, 3.80, 3.30, 3.40, 3.60, 3.80, 4.10, 4.20, 4.30 },
             { 3.20, 3.40, 3.00, 2.80, 2.40, 2.00, 1.70, 1.30, 0.80, 1.20, 1.80, 2.10, 2.80, 2.80, 2.90, 3.10, 3.40, 3.10, 3.30, 3.60, 3.70, 3.40, 3.60, 3.80, 3.20, 3.40, 3.50, 3.60, 3.90, 4.00, 4.10 },
             { 3.50, 3.30, 3.20, 3.00, 2.80, 2.40, 2.00, 1.70, 1.20, 0.80, 1.60, 1.80, 2.50, 2.70, 2.60, 2.80, 3.10, 3.30, 3.10, 3.30, 3.50, 3.70, 3.40, 3.60, 3.80, 3.20, 3.30, 3.50, 3.80, 3.90, 4.00 },
             { 3.30, 3.70, 3.30, 3.10, 3.00, 2.70, 2.60, 2.20, 1.80, 1.60, 0.80, 1.10, 1.80, 2.10, 2.20, 2.50, 2.80, 2.80, 3.00, 3.30, 3.50, 3.30, 3.50, 3.30, 3.50, 3.70, 3.80, 3.20, 3.50, 3.60, 3.70 },
             { 3.40, 3.30, 3.50, 3.30, 3.20, 2.90, 2.80, 2.50, 2.10, 1.80, 1.10, 0.80, 1.70, 1.90, 2.00, 2.30, 2.60, 2.60, 2.80, 3.10, 3.30, 3.10, 3.40, 3.70, 3.30, 3.50, 3.60, 3.10, 3.40, 3.50, 3.60 },
             { 3.10, 3.70, 3.40, 3.80, 3.30, 3.10, 3.20, 2.90, 2.80, 2.50, 1.80, 1.70, 0.80, 1.20, 1.30, 1.60, 1.90, 2.10, 2.30, 2.70, 2.70, 3.00, 3.30, 3.20, 3.40, 3.70, 3.20, 3.50, 3.10, 3.20, 3.30 },
             { 3.20, 3.80, 3.50, 3.40, 3.50, 3.30, 3.40, 3.10, 2.80, 2.70, 2.10, 1.90, 1.20, 0.80, 1.00, 1.30, 1.70, 1.80, 2.10, 2.50, 2.70, 2.80, 3.00, 3.50, 3.30, 3.50, 3.60, 3.30, 3.70, 3.80, 3.20 },
             { 3.30, 3.20, 3.60, 3.40, 3.60, 3.40, 3.10, 3.20, 2.90, 2.60, 2.20, 2.00, 1.30, 1.00, 0.80, 1.10, 1.50, 1.80, 1.90, 2.30, 2.50, 2.60, 2.90, 3.30, 3.20, 3.40, 3.50, 3.80, 3.60, 3.70, 3.20 },
             { 3.40, 3.30, 3.70, 3.60, 3.20, 3.60, 3.30, 3.40, 3.10, 2.80, 2.50, 2.30, 1.60, 1.30, 1.10, 0.80, 1.20, 1.50, 1.80, 2.10, 2.30, 2.60, 2.70, 3.10, 3.10, 3.40, 3.20, 3.30, 3.60, 3.50, 3.60 },
             { 3.50, 3.40, 3.20, 3.80, 3.40, 3.80, 3.50, 3.20, 3.40, 3.10, 2.80, 2.60, 1.90, 1.70, 1.50, 1.20, 0.80, 1.10, 1.40, 1.80, 1.90, 2.30, 2.70, 2.90, 3.10, 3.40, 3.10, 3.40, 3.30, 3.40, 3.60 },
             { 3.60, 3.50, 3.30, 3.20, 3.60, 3.40, 3.70, 3.40, 3.10, 3.30, 2.80, 2.60, 2.10, 1.80, 1.80, 1.50, 1.10, 0.80, 1.10, 1.50, 1.80, 2.10, 2.40, 2.60, 2.90, 3.20, 3.30, 3.20, 3.70, 3.30, 3.40 },
             { 3.70, 3.60, 3.40, 3.30, 3.70, 3.50, 3.20, 3.60, 3.30, 3.10, 3.00, 2.80, 2.30, 2.10, 1.90, 1.80, 1.40, 1.10, 0.80, 1.30, 1.50, 1.80, 2.20, 2.70, 2.70, 3.00, 3.20, 3.10, 3.60, 3.70, 3.30 },
             { 3.90, 3.80, 3.50, 3.40, 3.20, 3.70, 3.50, 3.30, 3.60, 3.30, 3.30, 3.10, 2.70, 2.50, 2.30, 2.10, 1.80, 1.50, 1.30, 0.80, 1.10, 1.50, 1.80, 2.30, 2.60, 2.70, 2.80, 3.20, 3.30, 3.20, 3.60 },
             { 4.00, 3.90, 3.60, 3.50, 3.20, 3.80, 3.60, 3.40, 3.70, 3.50, 3.50, 3.30, 2.70, 2.70, 2.50, 2.30, 1.90, 1.80, 1.50, 1.10, 0.80, 1.30, 1.70, 2.10, 2.40, 2.80, 2.70, 3.00, 3.10, 3.30, 3.50 },
             { 4.10, 4.00, 3.80, 3.70, 3.40, 3.20, 3.80, 3.60, 3.40, 3.70, 3.30, 3.10, 3.00, 2.80, 2.60, 2.60, 2.30, 2.10, 1.80, 1.50, 1.30, 0.80, 1.20, 1.80, 2.00, 2.40, 2.60, 2.70, 3.30, 3.40, 3.20 },
             { 4.30, 4.20, 3.90, 3.80, 3.50, 3.40, 3.20, 3.80, 3.60, 3.40, 3.50, 3.40, 3.30, 3.00, 2.90, 2.70, 2.70, 2.40, 2.20, 1.80, 1.70, 1.20, 0.80, 1.40, 1.80, 2.00, 2.20, 2.60, 3.00, 3.10, 3.40 },
             { 4.50, 4.40, 4.10, 4.00, 3.70, 3.60, 3.40, 3.30, 3.80, 3.60, 3.30, 3.70, 3.20, 3.50, 3.30, 3.10, 2.90, 2.60, 2.70, 2.30, 2.10, 1.80, 1.40, 0.80, 1.20, 1.60, 1.80, 2.10, 2.60, 2.70, 3.00 },
             { 4.60, 4.50, 4.30, 4.10, 3.90, 3.70, 3.60, 3.40, 3.20, 3.80, 3.50, 3.30, 3.40, 3.30, 3.20, 3.40, 3.10, 2.90, 2.70, 2.60, 2.40, 2.00, 1.80, 1.20, 0.80, 1.30, 1.50, 1.80, 2.50, 2.70, 2.70 },
             { 4.80, 4.60, 4.40, 4.40, 4.00, 3.90, 3.70, 3.60, 3.40, 3.20, 3.70, 3.50, 3.70, 3.50, 3.40, 3.20, 3.40, 3.20, 3.00, 2.70, 2.80, 2.40, 2.00, 1.60, 1.30, 0.80, 1.10, 1.50, 2.20, 2.30, 2.70 },
             { 4.80, 4.70, 4.50, 4.40, 4.10, 4.00, 3.80, 3.60, 3.50, 3.30, 3.80, 3.60, 3.20, 3.60, 3.50, 3.30, 3.10, 3.30, 3.20, 2.80, 2.70, 2.60, 2.20, 1.80, 1.50, 1.10, 0.80, 1.30, 2.00, 2.20, 2.50 },
             { 5.00, 4.90, 4.60, 4.50, 4.30, 4.10, 3.90, 3.80, 3.60, 3.50, 3.20, 3.10, 3.50, 3.30, 3.80, 3.60, 3.40, 3.20, 3.10, 3.20, 3.00, 2.70, 2.60, 2.10, 1.80, 1.50, 1.30, 0.80, 1.70, 1.80, 2.10 },
             { 5.30, 5.20, 4.90, 4.80, 4.60, 4.40, 4.20, 4.10, 3.90, 3.80, 3.50, 3.40, 3.10, 3.70, 3.60, 3.50, 3.30, 3.70, 3.60, 3.30, 3.10, 3.30, 3.00, 2.60, 2.50, 2.20, 2.00, 1.70, 0.80, 1.10, 1.40 },
             { 5.40, 5.20, 5.00, 4.90, 4.60, 4.50, 4.30, 4.20, 4.00, 3.90, 3.60, 3.50, 3.20, 3.80, 3.70, 3.60, 3.40, 3.30, 3.70, 3.40, 3.30, 3.40, 3.10, 2.70, 2.70, 2.30, 2.20, 1.80, 1.10, 0.80, 1.20 },
             { 5.50, 5.40, 5.10, 5.00, 4.80, 4.60, 4.40, 4.30, 4.10, 4.00, 3.70, 3.60, 3.30, 3.20, 3.20, 3.80, 3.60, 3.40, 3.30, 3.60, 3.50, 3.20, 3.40, 3.00, 2.70, 2.70, 2.50, 2.10, 1.40, 1.20, 0.80 }
            };

                IDictionary<int, string> dictStationFrom = new Dictionary<int, string>()
            {
            {0, "Sungai Buloh" },
            {1, "Kampung Selamat" },
            {2, "Kwasa Damansara" },
            {3, "Kwasan Sentral" },
            {4, "Kota Damansara" },
            {5, "Surian" },
            {6, "Mutiara Damansara" },
            {7, "Bandar Utama" },
            {8, "Taman Tun Dr Ismail" },
            {9, "Phileo Damansara" },
            {10, "Pusat Bandar Damansara" },
            {11, "Semantan" },
            {12, "Muzium Negara" },
            {13, "Pasar Seni" },
            {14, "Merdeka" },
            {15, "Bukit Bintang" },
            {16, "Tun Razak Exchange" },
            {17, "Cochrane" },
            {18, "Maluri" },
            {19, "Taman Pertama" },
            {20, "Taman Midah" },
            {21, "Taman Mutiara" },
            {22, "Taman Connaught" },
            {23, "Taman Suntex" },
            {24, "Sri Raya" },
            {25, "Bandar Tun Hussein Onn" },
            {26, "Batu Sebelas Cheras" },
            {27, "Bukit Dukung" },
            {28, "Sungai Jernih" },
            {29, "Stadium Kajang" },
            {30, "Kajang" }
            };

                IDictionary<int, string> dictStationTo = new Dictionary<int, string>()
            {
            {0, "Sungai Buloh" },
            {1, "Kampung Selamat" },
            {2, "Kwasa Damansara" },
            {3, "Kwasan Sentral" },
            {4, "Kota Damansara" },
            {5, "Surian" },
            {6, "Mutiara Damansara" },
            {7, "Bandar Utama" },
            {8, "Taman Tun Dr Ismail" },
            {9, "Phileo Damansara" },
            {10, "Pusat Bandar Damansara" },
            {11, "Semantan" },
            {12, "Muzium Negara" },
            {13, "Pasar Seni" },
            {14, "Merdeka" },
            {15, "Bukit Bintang" },
            {16, "Tun Razak Exchange" },
            {17, "Cochrane" },
            {18, "Maluri" },
            {19, "Taman Pertama" },
            {20, "Taman Midah" },
            {21, "Taman Mutiara" },
            {22, "Taman Connaught" },
            {23, "Taman Suntex" },
            {24, "Sri Raya" },
            {25, "Bandar Tun Hussein Onn" },
            {26, "Batu Sebelas Cheras" },
            {27, "Bukit Dukung" },
            {28, "Sungai Jernih" },
            {29, "Stadium Kajang" },
            {30, "Kajang" }
            };

                DateTime dateTime = DateTime.Now;
                ViewBag.Rate = rate;
                ViewBag.DictStationFrom = dictStationFrom;
                ViewBag.DictStationTo = dictStationTo;
                ViewBag.DateTime = dateTime;

                int from = int.Parse(routeRate.StationFrom);
                ViewBag.StationFrom = dictStationFrom[from];

                int to = int.Parse(routeRate.StationTo);
                ViewBag.StationTo = dictStationTo[to];

                int numOfTicket = int.Parse(routeRate.NumTicket);
                ViewBag.NumOfTicket = numOfTicket;

                double category = double.Parse(routeRate.LevelCategory);
                ViewBag.Category = 100 - (category * 100);

                double charge = rate[from, to];
                ViewBag.Charge = charge * category * numOfTicket;


                if (routeRate.tripType == "Round-trip")
                {
                    ViewBag.Charge = ViewBag.Charge * 2;
                }
                else if (routeRate.tripType == "One-way")

                    ViewBag.Charge = ViewBag.Charge;
                

                return View("Result", routeRate);
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public ViewResult Result()
        {
            return View();
        }

        [HttpPost]
        public ViewResult SendEmaiResultl(Route routeRate)
        {
            return View("SendEmail", routeRate);
        }

    }
}