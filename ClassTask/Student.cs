using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool IsGraduate;

        public Student(string _Name, string _Surname, string _Group, byte _Point, bool _isGraduate):this(_Point,_isGraduate)
        {

            Name = _Name;
            Surname = _Surname;
            Group = _Group;
            
        }

        public Student(byte _Point, bool _isGraduate)
        {
            Point= _Point;
            IsGraduate = _isGraduate;
        }

        public string Info1(string name,string surname)
        {
            return name+ " " + surname;
        }


        //public string Info2(string name, string surname,string group,byte point,bool isgraduate)
        //{
        //    string result=name+" "+surname+" "+group+" "+point+" ";
        //    if(isgraduate)
        //    {
        //        result += "mezun olub";
        //    }
        //    else
        //    {
        //        result += "mezun olmayib";
        //    }
        //    return result;
        //}

        public void  Info2()
        {
            string result = Name + " " + Surname + " " + Group + " " + Point + " ";
            if (IsGraduate)
            {
                result += "mezun olub";
            }
            else
            {
                result += "mezun olmayib";
            }
            Console.WriteLine(result); 
        }
        public void Check(string name,byte point)
        {
            if (point >= 80)
            {
                Console.WriteLine($"{name} adli  telebe balini artirmaq ucun 2ci imtahana gire biler ");
            }
            else
            {
                Console.WriteLine($"{name} adli  telebe balini artirmaq ucun 2ci imtahana gire bilmez.Cunki {point} 80 nin altinda bir neticedir ");
            }
        }






    }
}
