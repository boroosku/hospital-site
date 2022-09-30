using System;
using System.Collections.Generic;
using System.Text;

namespace domain
{
    class doctor
    {
        private int id;
        private string last_name, first_name, middle_name;
        private specialization spec;

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
        public string Last_name
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }

        public string First_name
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }
        public string Middle_name
        {
            get
            {
                return middle_name;
            }
            set
            {
                middle_name = value;
            }
        }
        public specialization Specialization
        {
            get
            {
                return spec;
            }
            set
            {
                spec = value;
            }
        }
    }
}
