using System;
using System.Text;

namespace hc
{
    public static class Str
    {
        public static int RepeatCounter(string mainString, string subString)
        {
            int result = 0;
            int length = mainString.Length;
            int start = 0;
            int subLength = subString.Length;
            bool running = true;
            while (running)
            {
                string check = "";
                for (int i = start; i <= start + subLength; i++)
                {
                    if (start + subLength > length)
                    {
                        running = false;
                        break;
                    }
                    if (i == start + subLength)
                    {
                        if (subString == check)
                        {
                            start += subLength;
                            result += 1;
                            break;
                        }
                        else
                        {
                            start += 1;
                            break;
                        }
                    }
                    else
                    {
                        check += mainString[i];
                    }

                }


            }
            return result;
        }

        public static string Halve(this string target)
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder(target);
            int targetLength = sb.Length / 2;
            int length = sb.Length;

            while (targetLength < length)
            {
                int index = rnd.Next(0, length);
                sb.Remove(index, 1);
                length--;
            }
            target = "";
            for (int i = 0; i < sb.Length; i++)
            {
                target += sb[i];
            }
            return target;
        }

        public static bool PalindromeOrNot(int number)
        {
            while (true)
            {
                string target = number.ToString();
                if (target == Revert(target))
                {
                    return true;
                }
                else
                {
                    if (target.Length == 2)
                    {
                        return false;
                    }
                    else
                    {
                        number = Reduce(target);
                    }
                }
            }
        }

        private static string Revert(string obj)
        {
            char[] charArray = obj.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private static int Reduce(string obj)
        {
            int length = obj.Length;
            char[] elements = obj.ToCharArray();
            int i = 0;
            string unparsedResult = "";
            while (i < length)
            {
                int firstVal = int.Parse(elements[i].ToString());
                int secondVal = int.Parse(elements[i + 1].ToString());
                int character = firstVal + secondVal;
                unparsedResult += character.ToString();
                i += 2;
            }
            int result = int.Parse(unparsedResult);
            return result;
        }

        public static string ReverseCase(string value)
        {
            string result = "";
            char[] charArray = value.ToCharArray();
            foreach (char element in charArray)
            {
                if (char.IsUpper(element))
                {
                    result += char.ToLower(element);
                }
                else
                {
                    result += char.ToUpper(element);
                }
            }
            return result;
        }
    }
}
