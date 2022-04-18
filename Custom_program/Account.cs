using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_program
{
    public class Account
    {

        private float _balance;
        private List<Spending> _spendings = new List<Spending>();
        private List<Income> _incomes = new List<Income>(); 
        
        public Account()
        {
            _balance = 0;
        }


        public float Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public List<Spending> Spendings
        {
            get { return _spendings; }
        }

        public List <Income> Incomes
        {
            get { return _incomes; }
        }


        
        public void Add_spending(Spending spending)
        {
           _spendings.Add(spending);
        }


        public void Add_income(Income income)
        {
            _incomes.Add(income);
        }
        public float Calculate_total_spending()
        {
            float total_spending=0;
            foreach (Spending spending in _spendings)
            {
                total_spending += spending.Amount;
            }

            return total_spending;
        }


        public float Calculate_total_income()
        {
            float total_income =0;
            foreach (Income income in _incomes)
            {
                total_income += income.Amount;
            }


            return total_income;

        }


        public float Calculate_total_balance()
        {
            _balance = Calculate_total_income()+Calculate_total_spending();
            return _balance;
        }
    }
}
