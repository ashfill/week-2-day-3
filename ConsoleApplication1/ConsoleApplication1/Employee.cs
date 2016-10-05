using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee:person
    {
        DateTime hiredate;
        DateTime terminationdate;
        double payrate;
        double paygrade;
        int hoursworked;
        string department;

        public DateTime Hiredate
        {
            get
            {
                return hiredate;
            }

            set
            {
                hiredate = value;
            }
        }

        public DateTime Terminationdate
        {
            get
            {
                return terminationdate;
            }

            set
            {
                terminationdate = value;
            }
        }

        public double Payrate
        {
            get
            {
                return payrate;
            }

            set
            {
                payrate = value;
            }
        }

        public double Paygrade
        {
            get
            {
                return paygrade;
            }

            set
            {
                paygrade = value;
            }
        }

        public int Hoursworked
        {
            get
            {
                return hoursworked;
            }

            set
            {
                hoursworked = value;
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
        public virtual void hire(DateTime nope)
        {
            nope = DateTime.Now.AddYears(-1);
        }
        public virtual void termination(DateTime yup)
        {
           yup =  DateTime.Now;
        }
         public void promote()
        {
            payrate = payrate * 1.04;
            paygrade = paygrade + 1;
        }
        
    }
    
    
}

