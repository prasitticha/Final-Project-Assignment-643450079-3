using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Assignment_643450079_3
{
    internal class Product
    {
        private string _ProductCode;
        private string _List;
        private string _INputProduct;
        private string _OPTputProduct;

        public string ProductCode
        {
            get { return _ProductCode; }
            set { _ProductCode = value; }
        }

        public string List
        {
            get { return _List; }
            set { _List = value; }
        }

        public string INputProduct
        {
            get { return _INputProduct; }
            set { _INputProduct = value; }
        }

        public string OPTputProduct
        {
            get { return _OPTputProduct; }
            set { _OPTputProduct = value; }
        }
    }
}
