using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_program
{
    public class Spending
    {

        private string _desc;
        private string _purpose;
        private float _amount;
        private DateTime _date;

        public Spending()
        {
            _desc = "";
            _purpose = "";
            _amount = 0;
        }


        public string Desc
        {
            get { return _desc; }
        }

        public string Purpose
        {
            get { return _purpose; }
        }


        public float Amount
        {
            get { return _amount; }
        }

        public DateTime Date
        {
            get { return _date; }
        }

        
    }
}
