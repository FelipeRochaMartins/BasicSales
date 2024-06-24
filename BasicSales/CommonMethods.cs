using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BasicSales
{
    public static class CommonMethods
    {
        public static void AlternateWindow(Form f, Form referent)
        {
            Thread t = new Thread(() => Application.Run(f));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            referent.Close();
            referent.Dispose();
            GC.Collect();
        }

        public static void NumbersValidation(KeyPressEventArgs e, string str, bool isMoney)
        {
            if (isMoney)
            {
                if (str.Contains((char)44) && e.KeyChar != (char)8)
                {
                    string afterComma = str.Substring(str.IndexOf(',') + 1);

                    if (afterComma.Length >= 2)
                        e.Handled = true;
                    
                }

                if ((!char.IsDigit(e.KeyChar) &&
                        e.KeyChar != (char)8 &&
                        e.KeyChar != (char)44) ||
                        (str.Contains((char)44)) &&
                        e.KeyChar == (char)44)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 ))
                {
                    e.Handled = true;
                }
            }
        }
        
        public static string StringNullValidation(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return str;
            }

            return null;
        }

        public static double DoubleNullValidation(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return double.Parse(str);
            }

            return 0;
        }

        public static int IntNullValidation(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                return int.Parse(str);
            }

            return 0;
        }
    }
}
