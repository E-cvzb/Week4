using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    public class Baby
    {
        string _name;
        string _surName;
        DateTime _birthDay;

       public string name
        {
            get { return _name; }
            set {
                _name = value;
                   }
        }
        public string surName
        {
            get { return _surName; }
            set { _surName = value; }
        }
        public DateTime BirthDay
        {
        
        
            get { return _birthDay; }
            set { _birthDay = value; }
        }
        public Baby() 
        { 
        }

        public Baby(String name , String surName )
        {
            _name = name;
            _surName = surName;
            _birthDay = DateTime.Now;
            Print();
        }
        public void Print()
        {
            Console.WriteLine("ıngaaa ");
            Console.WriteLine($"Çocuğunuznun isimi {name} soyisimi {surName} ");
            Console.WriteLine("Çocuğunun doğum tarihi "+ BirthDay);
        }
     }
}
