using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Velyka1.Models
{
    class Person
    {

        private DateTime _birthday;

        public Person(DateTime birthday)
        {
            Birthday = birthday;
        }

        public DateTime Birthday
        {
            get => _birthday;
            set
            {
                
                _birthday = value;
            }
        }


        public int Age()
        {

            if (DateTime.Now.Month < Birthday.Month
                || DateTime.Now.Month == Birthday.Month && DateTime.Now.Day < Birthday.Day)
            {
                return DateTime.Now.Year - Birthday.Year - 1;
            }

            return DateTime.Now.Year - Birthday.Year;
        }

        public string sunSign()
        {
            int day = Birthday.Day;
            int month = Birthday.Month;
            string sign = "some error";

            if (month == 12)
            {

                if (day < 22)
                    sign = "Sagittarius";
                else
                    sign = "capricorn";
            }

            else if (month == 1)
            {
                if (day < 20)
                    sign = "Capricorn";
                else
                    sign = "aquarius";
            }

            else if (month == 2)
            {
                if (day < 19)
                    sign = "Aquarius";
                else
                    sign = "pisces";
            }

            else if (month == 3)
            {
                if (day < 21)
                    sign = "Pisces";
                else
                    sign = "aries";
            }
            else if (month == 4)
            {
                if (day < 20)
                    sign = "Aries";
                else
                    sign = "taurus";
            }

            else if (month == 5)
            {
                if (day < 21)
                    sign = "Taurus";
                else
                    sign = "gemini";
            }

            else if (month == 6)
            {
                if (day < 21)
                    sign = "Gemini";
                else
                    sign = "cancer";
            }

            else if (month == 7)
            {
                if (day < 23)
                    sign = "Cancer";
                else
                    sign = "leo";
            }

            else if (month == 8)
            {
                if (day < 23)
                    sign = "Leo";
                else
                    sign = "virgo";
            }

            else if (month == 9)
            {
                if (day < 23)
                    sign = "Virgo";
                else
                    sign = "libra";
            }

            else if (month == 10)
            {
                if (day < 23)
                    sign = "Libra";
                else
                    sign = "scorpio";
            }

            else if (month == 11)
            {
                if (day < 22)
                    sign = "scorpio";
                else
                    sign = "sagittarius";
            }

            return sign;
        }
        public bool isBirthday()
        {
            return DateTime.Now.Year == Birthday.Year && DateTime.Now.Month == Birthday.Month &&
                   DateTime.Now.Day == Birthday.Day;
        }
        public String chineseSign()
        {


            int sign = Birthday.Year % 12;

            switch (sign)
            {
                case 0:
                    return "Monkey year";
                case 1:
                    return "Cock year";
                case 2:
                    return "Dog year";
                case 3:
                    return "Pig year";
                case 4:
                    return "Rat year";
                case 5:
                    return "Bull year";
                case 6:
                    return "Tiger year";
                case 7:
                    return "Rabbit year";
                case 8:
                    return "Dragon year";
                case 9:
                    return "Snake year";
                case 10:
                    return "Horse year";
                case 11:
                    return "Goat year";

            }
            return "some error";


        }

    }
}
