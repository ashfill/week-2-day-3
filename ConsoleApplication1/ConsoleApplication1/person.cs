using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class person
    {
        string firstname,lastname;
        DateTime dateofbirth;
        string socialsecuritynumber;

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        public DateTime Dateofbirth
        {
            get
            {
                return dateofbirth;
            }

            set
            {
                dateofbirth = value;
            }
        }

        public string Socialsecuritynumber
        {
            get
            {
                return socialsecuritynumber;
            }

            set
            {
                socialsecuritynumber = value;
            }
        }

        public virtual void ChangeName(string fName,string lName)
        {
            firstname = fName;
            lastname = lName;

        }
    }
}
