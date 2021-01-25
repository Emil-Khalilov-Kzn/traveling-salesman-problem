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
    public class M_Enumeration : Form1
    {
        public double Leng_3;
        public static IEnumerable<List<int>> allcombinations(List<int> arg, List<int> awithout)
        {
            int i = 1;

            if (arg.Count == 1)
            {
                var result = new List<List<int>>();
                result.Add(new List<int>());
                result[0].Add(arg[0]);
                result[0].Insert(0, 0);
                result[0].Add(0);
                return result;
            }
            else
            {
                var result = new List<List<int>>();
                foreach (var first in arg)
                {
                    var others0 = new List<int>(arg.Except(new int[] { first }));
                    awithout.Add(first);
                    var others = new List<int>(others0.Except(awithout));
                    var combinations = allcombinations(others, awithout);
                    awithout.Remove(first);
                    foreach (var tail in combinations)
                    {
                        tail.Insert(0, first);
                        result.Add(tail);
                        tail.Insert(0, 0);
                        tail.RemoveAt(2);
                    }
                }
                return result;
            }
        }
        public void output(List<int> arg, TextBox t_B_List)//перебор комбинаций
        {
            Form1 f = new Form1();
            double Leng;
            for (int i = 0; i < CityNumb + 1; i++)
            {
               t_B_List.Text += Convert.ToString(arg[i] + " ");
            }
            Leng = 0;
            for (int i = 0; i < CityNumb; i++)//выведение длины пути
            {
                Leng = Leng + Len[arg[i], arg[i + 1]];
            }
            leng2.Add(Leng);
            t_B_List.Text += "\r\n";
            t_B_List.Text += Convert.ToString(Leng);
            t_B_List.Text += "\r\n";
            t_B_List.Text += "\r\n";
            Leng_3 = leng2.Min();
            Leng_3 = Math.Round(Leng_3, 7);  
        }
        public void Bust(TextBox t_B_List)//перебор всех комбинаций
        {
            int j = 1;
            int CityNumb_1 = CityNumb - 1;
            int[] totalarray = new int[CityNumb_1];
            for (int i = 0; i < CityNumb_1; i++)
            {
                totalarray[i] = j;
                j++;
            }
            var totallist = new List<int>(totalarray);
            var allcombi = allcombinations(totallist, new List<int>());
            foreach (var lst in allcombi)
                output(lst,t_B_List);
        }
    }
}
