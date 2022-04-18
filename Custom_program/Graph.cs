using System;
using System.Collections.Generic;
using System.Text;
using SkiaSharp;
using Microcharts;

namespace Custom_program
{
    public abstract class Graph
    {

        List<ChartEntry> _entries = new List<ChartEntry>();
        public Graph()
        {

        }


        public List<ChartEntry> Entries
        {
            get { return _entries; }

        }

        public void EnterValue(Account account)
        {
            foreach (ChartEntry entry in _entries)
            {

            }

        }



    }
}