﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    internal class Clg
    {
        private string collegename, address;
      private int pin;
        public Clg(string collegename, string address, int pin)
        {
            this.Collegename = collegename;
            this.Address = address;
            this.Pin = pin;
        }

        public string Collegename { get => collegename; set => collegename = value; }
        public string Address { get => address; set => address = value; }
        public int Pin { get => pin; set => pin = value; }
    }
   


}
