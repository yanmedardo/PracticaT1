using System;
using System.Collections.Generic;
using System.Text;

namespace PracticaT1
{
    public class EnteroPositivo
    {
        public int Entero_Positivo(int[] number)
        {
            return 0;

        }


    }
    public  string Convertir_Romano (int number)  {
        int l = number / 10;
        StringBuilder sb = new StringBuilder();
        for (int m = 0; m <= l; m++)
        {
            if (l == 0)
            {
                break;
            }
            if (l == 5)
            {
                sb = sb.Append(ro.L.ToString());
                break;
            }
            if (l == 4)
            {
                sb = sb.Append(ro.X.ToString()).Append(ro.L.ToString());
                break;
            }
            if (l == 9)
            {
                sb = sb.Append(ro.X.ToString()).Append(ro.C.ToString());
                break;
            }
            if (l == 10)
            {
                sb = sb.Append(ro.C.ToString());
                break;
            }

            if (l > 5 && l < 9)
            {
                sb = sb.Append(ro.L.ToString());
                l = l - 5;
                m = 0;
                // break;
                continue;
            }
            if (l > 10)
            {
                sb = sb.Append(ro.C.ToString());
                l = l - 10;
                m = 0;
                // continue;

            }
            else
            {
                sb = sb.Append(ro.X.ToString());
            }

        }
        int z = number % 10;
        for (int x = 0; x <= z; x++)
        {
            if (z == 0)
            {
                break;
            }
            if (z == 5)
            {
                sb = sb.Append(ro.V.ToString());
                break;
            }
            if (z == 4)
            {
                sb = sb.Append(ro.I.ToString()).Append(ro.V.ToString());
                break;
            }
            if (z == 9)
            {
                sb = sb.Append(ro.I.ToString()).Append(ro.X.ToString());
                break;
            }
            if (z == 10)
            {
                sb = sb.Append(ro.X.ToString());
                break;
            }
            if (z > 5 && z < 9)
            {
                sb = sb.Append(ro.V.ToString());
                z = z - 5;
                x = 0;
            }
            else
            {
                sb.Append(ro.I.ToString());
            }

        }
        return sb.ToString();
    }
}
