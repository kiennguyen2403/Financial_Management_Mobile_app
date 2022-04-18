using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_program
{
    public class Income
    {

        private string _purpose;
        private float _amount;
        private string _desc;
        private DateTime _time= DateTime.Now;

        public Income()
        {
            _desc = "";
            _purpose = "";
            _amount = 0;
            _time = DateTime.Now;
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


        public void Adding_income(float amount, string purpose, DateTime time = default(DateTime) , string desc="")
        {
            if (string.IsNullOrEmpty(purpose))
            {
                throw new ArgumentException($"'{nameof(purpose)}' cannot be null or empty.", nameof(purpose));
            }

            if (string.IsNullOrEmpty(desc))
            {
                throw new ArgumentException($"'{nameof(desc)}' cannot be null or empty.", nameof(desc));
            }

            _amount = amount;
            _purpose = purpose;
            _desc = desc;
            if (time == default(DateTime))
            {
                _time= DateTime.Now;
            }
      
        }

    }
}
