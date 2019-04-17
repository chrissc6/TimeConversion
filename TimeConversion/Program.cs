using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static string timeConversion(string s)
    {
        string x = s;
        string h = x.Substring(0, 2);
        string m = x.Substring(3, 2);
        string sc = x.Substring(6, 2);
        string c = x.Substring(8, 2);
        int nh;

        if(c == "AM")
        {
            if(h == "12")
            {
                h = "00";
                x = h + ":" + m + ":" + sc;
            }
            else
            {
                x = h + ":" + m + ":" + sc;
            }
        }
        else
        {
            nh = Int32.Parse(h);

            switch (nh)
            {
                case 01:
                    nh = 13;
                    break;
                case 02:
                    nh = 14;
                    break;
                case 03:
                    nh = 15;
                    break;
                case 04:
                    nh = 16;
                    break;
                case 05:
                    nh = 17;
                    break;
                case 06:
                    nh = 18;
                    break;
                case 07:
                    nh = 19;
                    break;
                case 08:
                    nh = 20;
                    break;
                case 09:
                    nh = 21;
                    break;
                case 10:
                    nh = 22;
                    break;
                case 11:
                    nh = 23;
                    break;
                default:
                    break;
            }

            h = nh.ToString();

            x = h + ":" + m + ":" + sc;
        }

        return x;

    }

    static void Main(string[] args)
    {

        string s = "07:05:45PM";

        string result = timeConversion(s);

        Console.WriteLine(result);
    }
}
