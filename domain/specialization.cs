using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    class specialization
    {
        private int id;
        private string spec_name;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string Spec_name
        {
            get
            {
                return spec_name;
            }
            set
            {
                spec_name = value;
            }
        }
    }
}
