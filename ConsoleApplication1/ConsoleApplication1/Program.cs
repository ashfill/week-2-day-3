﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            departments d1 = new departments();
            departments d2 = new departments();
            Employee e1 = new Employee();
            e1.Firstname = "dave";
            e1.Lastname = "hive";
            e1.ChangeName("john", "jones");
            e1.Dateofbirth = new DateTime(1970, 10, 05);
            e1.Socialsecuritynumber = "132-45-3476";
            e1.Hiredate = new DateTime(2015, 10, 06);
            e1.Payrate = 15;
            e1.Paygrade = 1;
            e1.Hoursworked = 40;

            Employee e2 = new Employee();
            e2.Firstname = "greg";
            e2.Lastname = "jenkins";
            e2.ChangeName("james", "gordon");
            e2.Dateofbirth = new DateTime(1968, 01, 01);
            e2.Socialsecuritynumber = "421-34-0987";
            e2.Hiredate = new DateTime(2015, 07, 11);
            e2.Terminationdate = new DateTime(2016, 07, 11);
            e2.Payrate = 25;
            e2.Paygrade = 2;
            e2.Hoursworked = 40;

            Employee e3 = new Employee();
            e3.Firstname = "nathan";
            e3.Lastname = "daniels";
            e3.ChangeName("jose", "gonzolas");
            e3.Dateofbirth = new DateTime(1967, 10, 02);
            e3.Socialsecuritynumber = "321-21-5467";
            e3.Hiredate = new DateTime(2015, 02, 06);
            e3.Terminationdate = new DateTime(2016, 07, 16);
            e3.Payrate = 30;
            e3.Paygrade = 3;
            e3.Hoursworked = 50;

            Employee e4 = new Employee();
            e4.Firstname = "Chris";
            e4.Lastname = "Turk";
            e4.ChangeName("john", "Dorian");
            e4.Dateofbirth = new DateTime(1958, 10, 03);
            e4.Socialsecuritynumber = "876-09-4902";
            e4.Hiredate = new DateTime(2015, 11, 02);
            e4.Payrate = 40;
            e4.Paygrade = 4;
            e4.Hoursworked = 35;

            Employee e5 = new Employee();
            e5.Firstname = "audrey";
            e5.Lastname = "karen";
            e5.ChangeName("jessica", "cass");
            e5.Dateofbirth = new DateTime(1990, 10, 03);
            e5.Socialsecuritynumber = "555-67-8912";
            e5.Hiredate = new DateTime(2015, 04, 23);
            e5.Payrate = 50;
            e5.Paygrade = 5;
            e5.Hoursworked = 60;

            d1.Department = "H.R.";
            d1.Managersname = ("henry wilkins");
            d1.Location = "First floor";

            d2.Department = "accounting";
            d2.Managersname = "kalen hubert";
            d2.Location = "third floor";

            Employee[] = new Employee[5];

            Employee[0] = e1;
            Employee[1] = e2;
            Employee[2] = e3;
            Employee[3] = e4;
            Employee[4] = e5;
        }
    }
}