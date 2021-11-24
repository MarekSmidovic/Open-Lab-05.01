using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            if (year%100 == 00 )
            {
                int rok = year / 100;

                if (year == 1)
                {
                    string c = String.Format("{0}st century", rok);
                    return c;
                }
                else if (year == 2)
                {
                    string c = String.Format("{0}nd century", rok);
                    return c;
                }
                else if (year == 3)
                {
                    string c = String.Format("{0}rd century", rok);
                    return c;
                }
                else
                {
                    string f = String.Format("{0}th century", rok);
                    return f;
                }



            }
            else
            {
                int rok = year / 100 + 1;

                if (year == 1)
                {
                    string c = String.Format("{0}st century", rok);
                    return c;
                }
                else if (year == 2)
                {
                    string c = String.Format("{0}nd century", rok);
                    return c;
                }
                else if (year == 3)
                {
                    string c = String.Format("{0}rd century", rok);
                    return c;
                }
                else
                {
                    string b = String.Format("{0}th century", rok);
                    return b;
                }
                
            }
                
        }
    }
}
                           