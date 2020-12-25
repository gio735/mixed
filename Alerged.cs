using System;
using System.Collections.Generic;
using System.Text;

namespace hc
{
    public class Alerged
    {
        public static int TotalAlerged { get; private set; }
        private static List<Alerged> _alergeds = new List<Alerged>();
        public string Name { get; private set; }
        private int _pass;
        private List<Alergy> _alergies;
        private bool _active;

        public Alerged(string name, string pass)
        {
            Name = name;
            _pass = pass.GetHashCode();
            _alergies = new List<Alergy>();
            TotalAlerged++;
            _alergeds.Add(this);
        }

        public static void Global()
        {
            Console.WriteLine($"{TotalAlerged} alerged in total.\n");
        }

        public static void Profile(Alerged person)
        {
            person.Profile();
        }

        public static void AllAlergy(Alerged person)
        {
            person.AllAlergy();
        }

        public static void TopAlergedPoints()
        {
            List<int> points = new List<int>();
            foreach (Alerged alerged in _alergeds)
            {
                points.Add(alerged.Counter());
            }
            if (_alergeds.Count >= 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i + 1}. {points[i]} Points");
                }
            }
            else
            {
                for (int i = 0; i < _alergeds.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {points[i]} Points");
                }
            }
            Console.WriteLine(" ");
        }

        public void LogIn(string pass)
        {
            if (_active)
            {
                Console.WriteLine($"Alerged {Name}, you are already logged in\n");
            }
            else
            {
                if (pass.GetHashCode() == _pass)
                {
                    _active = true;
                    Console.WriteLine($"Alerged {Name}, You have logged in Successfuly\n");
                }
                else
                {
                    Console.WriteLine("Invalid password\n");
                }
            }
        }

        public void LogOut()
        {
            if (_active)
            {
                _active = false;
                Console.WriteLine("You have logged out successfuly\n");
            }
            else
            {
                Console.WriteLine("You need to login before log out...\n");
            }
        }

        public void ChangePass(string oldPass, string newPass, string newPassAgain)
        {
            if (_active)
            {
                bool capableToChange = _pass == oldPass.GetHashCode() && newPass == newPassAgain;
                if (capableToChange)
                {
                    _pass = newPass.GetHashCode();
                    Console.WriteLine("Password changed successfuly\n");
                }
                else
                {
                    Console.WriteLine("Something went wrong while trying to change password. Try again!\n");
                }
            }
        }

        public void Profile()
        {
            Console.WriteLine($"Name: {Name}.\nAlergy amount: {_alergies.Count}.\nTotal point(s): {Counter()}\n");
        }

        private int Counter()
        {
            int result = 0;
            foreach (Alergy alergy in _alergies)
            {
                result += alergy.Point;
            }
            return result;
        }

        public void AllAlergy()
        {
            Console.WriteLine($"{Name}'s alergies:");
            foreach (Alergy alergy in _alergies)
            {
                Console.WriteLine(alergy.Name + "   " + alergy.Point + " points");
            }
            Console.WriteLine(" ");
        }

        public void AddAlergy(Alergy newAlergy)
        {
            if (_active)
            {
                if (!_alergies.Contains(newAlergy))
                {
                    _alergies.Add(newAlergy);
                    Console.WriteLine($"{newAlergy.Name} alergy with {newAlergy.Point} point(s) have been added to your alergy list.\n");
                }
                else
                {
                    Console.WriteLine("That alergy is already in your list.\n");
                }

            }
            else
            {
                Console.WriteLine("You have no access on that command\n");
            }
        }
    }
}
