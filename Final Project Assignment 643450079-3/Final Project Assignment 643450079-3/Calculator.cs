using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Assignment_643450079_3
{
    internal class Calculator
    {
        private int sum12 = 0;
        private int sum34 = 0;

        public void addCalculator(string INput1, string OUTput2)
        {
            int input1 = int.Parse(INput1);
            int input2 = int.Parse(OUTput2);

            this.sum12 = input1 - input2;
        }
        public int getCalculator()
        {
            return sum12;
        }

        public void addCalculatorUpdate(string INput3, string OUTput4)
        {
            int input3 = int.Parse(INput3);
            int input4 = int.Parse(OUTput4);

            this.sum34 = input3 - input4;
        }
        public int getCalculatorUpdate()
        {
            return sum34;
        }
    }
}
