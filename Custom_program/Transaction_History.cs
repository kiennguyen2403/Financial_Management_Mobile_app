using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Custom_program
{
    public class Transaction_History
    {
        private List<Spending> _spending_history= new List<Spending>();
        private List<Income> _income_history= new List<Income>();
       

        public Transaction_History()
        {

        }


        public List<Spending> SortedbyTime()
        {
            List<Spending> sortspending = _spending_history.OrderByDescending(itm => itm.Date).ToList();
            return sortspending;
        }


        public List<Spending> SortedbyAmount()
        {
            List<Spending> sortspending = _spending_history.OrderByDescending(itm=> itm.Amount).ToList();

            return sortspending;
        }


      
        
    }
}
