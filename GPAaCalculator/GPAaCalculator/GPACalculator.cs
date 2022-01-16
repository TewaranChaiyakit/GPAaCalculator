﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPAaCalculator
{
    internal class GPACalculator
    {
        private double sum = 0;
        private int n = 0;
        private double max = 0;
        private string name = string.Empty; // "  "
        private string alldata = string.Empty;
        private double min = 0;

        /// <summary>
        /// Add new GPA to class
        /// </summary>
        /// <param name="gpa">gpa score</param>
        public void addGPA(double gpa, string name)
        {
            this.sum += gpa;
            this .n++;
            this.alldata += name + " " + gpa;

            if(this.max < gpa)
            {
                this.max = gpa;
                this.name = name;
            }
                
        }
        /// <summary>
        /// Return GPAX of class
        /// </summary>
        /// <returns>GPAX</returns>
        public double getGPAX()
        {
            double result = this.sum / this.n;
            return result;
        }
        public double getMax() 
        {
            return this.max;
            
        }
        public string getMaxName() 
        {
            return name;
            
        }
        public string getAlldata()
        {
            return alldata;
        }
        public double getMin()
        {
            return min;
        }
        public string getMinName()
        {
            return name;
        }






    }

}
