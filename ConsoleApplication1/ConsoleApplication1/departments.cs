using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class departments
    {
        string managersname;
        string location;
        string department;

        public string Managersname
        {
            get
            {
                return managersname;
            }

            set
            {
                managersname = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public string Department
        {
            get
            {
                return department;
            }

            set
            {
                department = value;
            }
        }

        public virtual void NewName(string name)
        {
            department = name;
        }

    }
    }  

