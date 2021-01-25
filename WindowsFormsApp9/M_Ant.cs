using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp9
{
    public class M_Ant : Form1
    {
        public double Leng = 0;        
        public void Antt()//метод реализующий метод "Муравья" 
        {             
            try
            {
                if (pic_B_AllWay.Image == null)
                    ;
            }

            catch { MessageBox.Show("Вы не построили города", "Ошибка"); }
            double[,] L = new double[CityNumb, CityNumb];
            double[,] F = new double[CityNumb, CityNumb];
            double[,] N = new double[CityNumb, CityNumb];
            double[] H = new double[CityNumb + 1];
            int[] I = new int[CityNumb];
            Le = new int[CityNumb + 1];
            int[] Le_min = new int[CityNumb + 1];
             double R, df, S = 0, z = 0;
            int o = 0, P1, t1, An = 0, n, s = 0, k = 0;
            int d = CityNumb;
            for (int j = 0; j < CityNumb - 1; j++)//рандомное расставление феромонов
            {
                s = j + 1;
                for (int i = 0; i < CityNumb - 1; i++)
                {
                    if (s == CityNumb)
                        break;
                    int V = rnd.Next(1, 100);
                    F[i, s] = V;
                    F[s, i] = F[i, s];
                    s++;
                }
            }
            for (int i = 0; i < CityNumb; i++)//вычисление величины обратной от расстояния
            {
                for (int j = 1; j < CityNumb; j++)
                {
                    N[i, j] = 1 / Len[i, j];
                }
            }
            do//начало алгоритма
            {
                n = 0;
                Leng = 0;
                for (int i = 1; i < CityNumb; i++)//воссоздание последовательности городов от 1 до N
                {
                    I[i] = i;
                }
                An++;
                Le[0] = 0;
                Le[CityNumb] = Le[0];
                t1 = 0;
                P1 = 1;
                o = 1;
                do//начало прохождение по всем городам
                {
                    S = 0;
                    P1++;
                    k = 0;
                    for (int j = 1; j < CityNumb; j++)//Вычиление знаменателя вероятности
                    {
                        if (I[j] != -1)
                            S = S + Math.Pow(N[t1, j], Alpha) * (Math.Pow(F[t1, j], Betta));       
                    }
                    for (int j = 1; j < CityNumb; j++)//Вычисление вероятности
                    {
                        if (I[j] != -1)
                            H[j] = 100 * ((Math.Pow(N[t1, j], Alpha) * (Math.Pow(F[t1, j], Betta))) / S);
                    }
                    R = rnd.Next(0, 100);
                    z = 0;
                    n = 1;
                    while (k < 1)
                    {
                        if (n > CityNumb)
                            break;
                        if (R <= H[n] + z)
                        {

                            t1 = n;
                            Le[o] = n;
                            I[n] = -1;
                            H[n] = 0;
                            k++;
                            o++;
                        }
                        else
                        {
                            z = z + H[n];
                            n++;
                        }
                    }
                } while (P1 < CityNumb);//прохождение по всем городам               
                for (int i = 0; i < CityNumb; i++)//выведение длины пути
                {
                    Leng = Leng + Len[Le[i], Le[i + 1]];
                }
                if (An < Ant)
                {
                    df = Q / Leng;                              //изменеие всех феромонов
                    for (int i = 0; i < CityNumb; i++)
                    {
                        for (int j = 0; j < CityNumb; j++)
                        {
                            if (i == j)
                            {
                                F[i, j] = 0;
                            }
                            else
                            {
                                F[i, j] = F[i, j] - 0.5;
                            }
                        }
                    }
                    for (int i = 0; i < CityNumb; i++)//изменение феромонов по пройденному пути
                    {
                        F[Le[i], Le[i + 1]] = (1 - p) * F[Le[i], Le[i + 1]] + df;
                    }
                }
            } while (An < Ant);//завершение, когда пройдут все муравьи
            Leng = Math.Round(Leng, 7);            
        }
    }
}
       