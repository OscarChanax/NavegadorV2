using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavegadorV2
{
    internal class URL
    {
        private string resource;
        private int timesVisited;
        private DateTime date;
        public string Resource
        {
            get { return resource; } set { resource = value; }
        }
        public int TimesVisited
        {
            get { return timesVisited; } set { timesVisited = value; }
        }
        public DateTime Date
        {
            get { return date; } set { date = value; }
        }
        public string[] getUrlData()
        {
            string[] data = { this.resource, this.timesVisited.ToString(), this.Date.ToString() };
            return data;
        }
    }
}
