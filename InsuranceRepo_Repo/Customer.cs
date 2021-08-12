using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRepo_Repo
{
    public class Customer
    {
        // static means there's only one for ALL customers
        private static int _count = 1;
        public int Id { get; }
        public string Name { get; set; }

        public Customer()
        {
            Id = _count;
            // add one
            _count++;
        }

        public string Message
        {
            get
            {
                // returns the right message based on their years with the company
                return "message";
            }
        }
        public string GetMessage()
        {
            return "message";
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
