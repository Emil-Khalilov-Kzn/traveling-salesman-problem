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
    public class M_Ann :Form1
    {
        public double L = 0, S = 0, P_rnd = 0, P_point = 0;        
        int[] CityN = new int[CityNumb + 1];        
        public static int[] new_way(Random rnd, int CityNumb, int[] CityNum)//рандомное изменение двух точек
        {
            int p = 0, p1 = 0, Y;
            p = rnd.Next(0, CityNumb - 1);
            p1 = rnd.Next(0, CityNumb - 1);
            if (p == p1)
            {
                while (p == p1)
                {
                    p1 = rnd.Next(0, CityNumb - 1);
                }
            }
            Y = CityNum[p];
            CityNum[p] = CityNum[p1];
            CityNum[p1] = Y;
            CityNum[CityNumb] = CityNum[0];
            return CityNum;
        }
        public void Annealing()//метод реализующий метод "Отжига"
        {
            CityNum = new int[CityNumb + 1];
            L = 0;//последней и первой точкой
            for (int i = 0; i < CityNumb; i++)//создание первоначального массива
            {
                CityNum[i] = i;
            }
            CityNum[CityNumb] = CityNum[0];//посследнему присвается начальное значение для завершения пути             
            for (int i = 0; i < CityNumb; i++)//рассчёт начального пути
            {
                L = L + Len[CityNum[i], CityNum[i + 1]];
            }
            L = Math.Round(L, 7);
            t_B_LengWay_Ann.Text = Convert.ToString(L);//если другие пути не подойдут, то длина начального пути                 
            do// начало метода "Отжига"
            {
                S = 0;
                for (int i = 0; i <= CityNumb; i++)//сохрания текущего пути
                {
                    CityN[i] = CityNum[i];
                }
                new_way(rnd, CityNumb, CityNum);//новый путь
                for (int i = 0; i < CityNumb; i++)//вычисление длины нового пути
                {
                    S = S + Len[CityNum[i], CityNum[i + 1]];
                }
                Temp = Coef * Temp;//умножение текущей температцры на коэффициент
                if (S >= L)//сравниваем текущие расстояние с предыдущим
                {
                    P_rnd = rnd.Next(1, 100);//вычисляется рандомная вероятность
                    P_point = 100 * Math.Pow(Math.E, -1 * ((S - L) / Temp));//вычисляется вероятность данной точки
                    if (P_point <= P_rnd)//сравниваются вероятности
                    {
                        for (int i = 0; i < CityNumb; i++)//возврат к предыдущёему массиву
                        {
                            CityNum[i] = CityN[i];
                        }
                    }
                    else
                    {
                        L = S; //сохрания текущей длины пути                      
                    }
                }
                else
                {
                    S = Math.Round(S, 7);
                }
            }//скобка от do-while             
            while (Temp > Temp_min);//пока текущая температура больше минимальной
            //New_road(CityNumb, CityNum, g_1);
        }

    }
}
