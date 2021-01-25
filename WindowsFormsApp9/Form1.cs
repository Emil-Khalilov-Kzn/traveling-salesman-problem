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
    public partial class Form1 : Form
    {
        public static double Alpha, Betta, Q, p, Ant,Temp, Temp_min, Coef;
        protected static int CityNumb;
        public static List<double> leng2 = new List<double>();
        public static int[] Le;
        public static int[] CityNum;
        public static double[,] Len;
        public static int[] X, Y, X_1, Y_1;
        public static Random rnd = new Random();       
        public int  a, error = 0, luck = 0, Cit = 0;        
        private int[] hight1 = new int[100];
        private int[] wight1 = new int[100];
        public int x_MouseDown_1, y_MouseDown_1;        
        Pen p_r = new Pen(Color.Red, 3);
        Pen p_y = new Pen(Color.Yellow, 1);
        int EE = 0, ER = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                b_All_Checkend.Visible = true;
                b_Enter.Visible = false;
                b_Search.Visible = false;
                t_B_CityAnt.Visible = true;
                label10.Visible = true;
                t_B_Alpha.Visible = true;
                t_B_Betta.Visible = true;
                t_B_p.Visible = true;
                t_B_Q.Visible = true;
                label11.Visible = true;
                label12.Visible = true;
                label13.Visible = true;
                label14.Visible = true;
                label18.Visible = true;
                t_B_LengWay.Visible = true;
            }
            else
            {
                if (checkBox1.Checked == true)
                {
                    t_B_CityAnt.Visible = true;
                    label10.Visible = true;
                    t_B_Alpha.Visible = true;
                    t_B_Betta.Visible = true;
                    t_B_p.Visible = true;
                    t_B_Q.Visible = true;
                    label11.Visible = true;
                    label12.Visible = true;
                    label13.Visible = true;
                    label14.Visible = true;
                    b_Enter.Visible = true;
                    label18.Visible = true;
                    label19.Visible = false;
                    t_B_LengWay.Visible = true;
                    b_Enter.Location = new Point(657, 265);
                    if (checkBox2.Checked == false)
                    {
                        t_B_LengWay.Location = new Point(1017, 218);
                        label18.Location = new Point(873, 221);
                    }
                    else
                    {
                        t_B_LengWay.Location = new Point(1017, 192);
                        label18.Location = new Point(873, 195);
                    }
                    
                }
                else
                {
                    if (checkBox2.Checked == false)
                    {
                        t_B_CityAnt.Visible = false;
                        label10.Visible = false;
                        t_B_Alpha.Visible = false;
                        t_B_Betta.Visible = false;
                        t_B_p.Visible = false;
                        t_B_Q.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        b_Enter.Visible = false;
                        label18.Visible = false;
                        t_B_LengWay.Visible = false;
                        if (checkBox3.Checked == false)
                            label19.Visible = true;
                    }
                    else
                    {
                        t_B_CityAnt.Visible = false;
                        label10.Visible = false;
                        t_B_Alpha.Visible = false;
                        t_B_Betta.Visible = false;
                        t_B_p.Visible = false;
                        t_B_Q.Visible = false;
                        t_B_LengWay.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label18.Visible = false;
                        b_Enter.Location = new Point(780, 237);
                       
                    }
                    if (checkBox2.Checked == true && checkBox3.Checked == true)
                    {
                        b_Enter.Visible = true;
                        b_All_Checkend.Visible = false;
                    }
                }
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                b_All_Checkend.Visible = true;
                b_Enter.Visible = false;
                b_Search.Visible = false;
                t_B_Temp.Visible = true;
                t_B_Temp_N.Visible = true;
                t_B_CoefTemp.Visible = true;
                t_B_LengWay_Ann.Visible = true;
                label15.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label17.Visible = true;
                t_B_LengWay.Location = new Point(1017, 192);
                label18.Location = new Point(873, 195);
            }
            else
            {
                if (checkBox2.Checked == true)
                {                    
                t_B_Temp.Visible = true;
                t_B_Temp_N.Visible = true;
                t_B_CoefTemp.Visible = true;
                t_B_LengWay_Ann.Visible = true;                
                label15.Visible = true;
                label9.Visible = true;
                label8.Visible = true;
                label17.Visible = true;
                label19.Visible = false;
                if (checkBox1.Checked == false)
                b_Enter.Location = new Point(780, 237);
                else
                    b_Enter.Location = new Point(657, 265);
                if (checkBox1.Checked == true)
                {
                    t_B_LengWay.Location = new Point(1017, 192);
                    label18.Location = new Point(873, 195);
                }
                    if (checkBox1.Checked == true && checkBox3.Checked == true)
                        b_Enter.Visible = false;
                    else
                        b_Enter.Visible = true;
                }
            else
            {
                if (checkBox1.Checked == false)
                {
                    
                    t_B_Temp.Visible = false;
                    t_B_Temp_N.Visible = false;
                    t_B_CoefTemp.Visible = false;
                    t_B_LengWay_Ann.Visible = false;
                    b_Enter.Visible = false;
                    label15.Visible = false;
                    label9.Visible = false;
                    label8.Visible = false;
                    label17.Visible = false;
                    b_Search.Location = new Point(1037, 270);
                    if (checkBox3.Checked == false)
                        label19.Visible = true;
                }
                else
                {
                    t_B_Temp.Visible = false;
                    t_B_Temp_N.Visible = false;
                    t_B_CoefTemp.Visible = false;
                    t_B_LengWay_Ann.Visible = false;
                    label15.Visible = false;
                    label9.Visible = false;
                    label8.Visible = false;
                    label17.Visible = false;
                    b_Enter.Location = new Point(657, 265);
                    if (checkBox1.Checked == true)
                    {
                        t_B_LengWay.Location = new Point(1017, 218);
                        label18.Location = new Point(873, 221);
                    }
                    if (checkBox3.Checked == true)
                        b_Search.Location = new Point(742, 265);
                }
                    if (checkBox1.Checked == true && checkBox3.Checked == true)
                    {
                        b_Enter.Visible = true;
                        b_Search.Visible = true;
                        b_All_Checkend.Visible = false;
                    }
            }
            
            }
            if (checkBox1.Checked == true && checkBox2.Checked == true)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
            }
            else
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                b_All_Checkend.Visible = true;
                b_Enter.Visible = false;
                b_Search.Visible = false;
                label4.Visible = true;
                t_B_MinWay.Visible = true;
            }
            else
            {
                if (checkBox3.Checked == true)
                {
                
                label4.Visible = true;
                t_B_MinWay.Visible = true;
                label19.Visible = false;
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                    b_Search.Location = new Point(1037, 270);
                    b_Search.Visible = true;
                    if (checkBox1.Checked == true || checkBox2.Checked == true)
                    b_Search.Location = new Point(742, 265);
                    b_Search.Visible = true;
                }
                else
                {
                b_All_Checkend.Visible = false;
                b_Search.Visible = false;
                label4.Visible = false;
                t_B_MinWay.Visible = false;
                b_Search.Location = new Point(742, 265);
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                    label19.Visible = true;
                    if (checkBox1.Checked == true && checkBox2.Checked == true)
                    {
                        b_Enter.Visible = true;
                    }
                }            
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CreatGraff();
        }

        

        public void CreatGraff()//постройка карты
        {
            int k = -1, s = 0, x = 0, y = 0;
            if (c_B_Hand.Checked == false)
            {
                try
                {
                    CityNumb = Convert.ToInt32(t_B_CityNumb.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Введен неверный формат данных!", "Ошибка");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Введено отрицательное число!", "Ошибка");
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Введено нулевое значение!", "Ошибка");
                }
                a++;
            }
            else
            {
                
                CityNumb = a;
            }
            Len = new double[CityNumb, CityNumb];
            Graphics g = pic_B_AllWay.CreateGraphics();           
            g.Clear(Color.LightSteelBlue);
            int h = pic_B_AllWay.Size.Height;//считывание высоты панели 1
            int w = pic_B_AllWay.Size.Width;//считывание ширины панели 1
            X = new int[CityNumb];
            Y = new int[CityNumb];
            X_1 = new int[CityNumb];
            Y_1 = new int[CityNumb];
            if(c_B_Hand.Checked == false)
            {
                for (int i = 0; i < CityNumb; i++)//рандомное расставление точек по 1ой панели
                {
                    x = rnd.Next(10, w - 10);
                    y = rnd.Next(10, h - 10);
                    X[i] = x;
                    Y[i] = y;
                    X_1[i] = X[i];
                    Y_1[i] = Y[i];
                    g.DrawEllipse(p_r, x, y, 3, 3);
                }
            }
            else
            {
                for (int i = 0; i < a; i++)//считывания точек с руччного ввода
                {
                    X[i] = hight1[i];
                    Y[i] = wight1[i];
                }
                for (int i = 0; i < CityNumb; i++)
                {
                    g.DrawEllipse(p_r, X[i], Y[i], 3, 3);
                }
            }
            for (int j = 0; j < CityNumb - 1; j++)//рассчитывания расстояния между точками
            {
                k++;
                s = j + 1;
                for (int i = 0; i < CityNumb - 1; i++)
                {
                    if (s == CityNumb)
                        break;
                    g.DrawLine(p_y, X[k], Y[k], X[s], Y[s]);//проведение линий между точками
                    Len[i, s] = Math.Sqrt(Math.Abs(Math.Pow(X[s] - X[k], 2) + Math.Pow(Y[s] - Y[k], 2)));//считывание и вычиления 
                    Len[s, i] = Len[i, s];                                                                //расстояниями между точками
                    s++;
                }
                g.DrawLine(p_y, X[CityNumb - 1], Y[CityNumb - 1], X[0], Y[0]);//проведении линии между последними
            }
            d_G_V_Leng.RowCount = CityNumb;//Размерность для кол-во строк
            d_G_V_Leng.ColumnCount = CityNumb;//Размерность для кол-во столбцов
            for (int i = 0; i < d_G_V_Leng.Rows.Count; i++)//индексы для строк
            {
                d_G_V_Leng.Rows[i].HeaderCell.Value = i.ToString();
            }
            for (int i = 0; i < d_G_V_Leng.Rows.Count; i++)////индексы для столбцов
            {
                d_G_V_Leng.Columns[i].HeaderCell.Value = i.ToString();
            }
            for (int i = 0; i < Len.GetLength(0); i++)//выведение расстояний в матрицу
            {
                for (int j = 0; j < Len.GetLength(1); j++)
                {
                    d_G_V_Leng.Rows[i].Cells[j].Value = Len[i, j];
                }
            }
        }
        private void b_City_Click(object sender, EventArgs e)//метод обрабатывающий кнопку "построить"
        {
            pic_B_AllWay.Invalidate();
            pic_B_AllWay.Update();
            CreatGraff();
            Cit++;
        }      
        private void b_Search_Click(object sender, EventArgs e)
        {
            b_Enter_Click(sender, e);
        }        
        public void Clear()//метод реализущий очистку полей
        {
            Graphics g = pic_B_AllWay.CreateGraphics();
            Graphics g_1 = pic_B_OptiWay.CreateGraphics();
            g.Clear(Color.LightSteelBlue);          //
            g_1.Clear(Color.LightSteelBlue);        //
            t_B_Alpha.Clear();                      //
            t_B_Betta.Clear();                      //Очистка всех окон
            t_B_CityAnt.Clear();                    //
            t_B_CityNumb.Clear();                   //
            t_B_CoefTemp.Clear();                   //
            t_B_LengWay.Clear();                    //
            t_B_LengWay_Ann.Clear();                //
            t_B_List.Clear();                       //
            t_B_p.Clear();                          //
            t_B_Q.Clear();                          //
            t_B_Temp.Clear();                       //
            t_B_Temp_N.Clear();                     //
            d_G_V_Leng.Rows.Clear();                //
            d_G_V_Leng.Columns.Clear();             //
            a = 0;                                  //
            c_B_Hand.Checked = false;               //
        }
        public void New_road(int CityNumb, int[] CityNum, Graphics g_1)//метод выводящий граф конечного пути
        {
            for (int i = 0; i < CityNumb - 1; i++)
            {
                g_1.DrawLine(p_y, X[CityNum[i]], Y[CityNum[i]], X[CityNum[i + 1]], Y[CityNum[i + 1]]);
            }
            g_1.DrawLine(p_y, X[CityNum[CityNumb - 1]], Y[CityNum[CityNumb - 1]], X[CityNum[0]], Y[CityNum[0]]);
            for (int i = 0; i < CityNumb; i++)
            {
                g_1.DrawEllipse(p_r, X[CityNum[i]], Y[CityNum[i]], 3, 3);
            }            
            g_1.DrawString("1-ый", new Font("Times New Roman", 10, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(X[CityNum[0]], Y[CityNum[0]]));
            g_1.DrawString("2-ой", new Font("Times New Roman", 10, FontStyle.Regular), new SolidBrush(Color.Black), new PointF(X[CityNum[1]], Y[CityNum[1]]));
        }        
        private void b_Count_Null_Click(object sender, EventArgs e)//очистка счётчика
        {
            luck = 0;
            error = 0;
            t_B_Count.Text = Convert.ToString(error);
            t_B_Luck.Text = Convert.ToString(luck);
        }
        private void pic_B_AllWay_MouseUp(object sender, MouseEventArgs e)//метод считывающий точки с панели
        {
            if (c_B_Hand.Checked == true)
            {
                Graphics g = Graphics.FromHwnd(pic_B_AllWay.Handle);
                g.DrawEllipse(p_r, x_MouseDown_1, y_MouseDown_1, 3, 3);
                hight1[a] = x_MouseDown_1;
                wight1[a] = y_MouseDown_1;
                a++;
                t_B_CityNumb.Text = Convert.ToString(a);
            }
        }
        private void c_B_Hand_CheckedChanged(object sender, EventArgs e)//метод обрабатывающий блок для введения городов
        {
            if (c_B_Hand.Checked == true)
            {
                if (a == 0)
                {
                    MessageBox.Show("Количество городов вводится автоматически", "Внимание!");
                    t_B_CityNumb.ReadOnly = true;
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Вы желаете добавить точки?", "Ручной ввод", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        a = 0;
                        for (int i = 0; i < CityNumb; i++)
                        {
                            hight1[i] = X_1[i];
                            wight1[i] = Y_1[i];
                        }
                        a = a + CityNumb;
                        hight1[a] = x_MouseDown_1;
                        wight1[a] = y_MouseDown_1;
                        t_B_CityNumb.ReadOnly = true;
                    }
                    if (dialogResult == DialogResult.No)
                    {
                        Clear();
                        c_B_Hand.Checked = true;
                        t_B_CityNumb.ReadOnly = true;
                    }
                }
            }
            else
            {
                t_B_CityNumb.ReadOnly = false;
            }
        }
        private void pic_B_AllWay_MouseDown(object sender, MouseEventArgs e)//метод считывающий положение курсора
        {
            x_MouseDown_1 = e.X;
            y_MouseDown_1 = e.Y;
        }
        private void b_Clear_Click(object sender, EventArgs e)//метод обрабатывающий кнопку "очистка"
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно желаете очистить?", "Очистить", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
        public void Count()//метод обрабатываюзий счётчик
        {
            try
            {
                double Way_Ann = Convert.ToDouble(t_B_LengWay_Ann.Text);
                double Way_Ant = Convert.ToDouble(t_B_LengWay.Text);
                double Way_min = Convert.ToDouble(t_B_MinWay.Text);


                if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    if (Way_Ant != Way_min)
                        ER++;
                    else EE++;
                    if (Way_Ann != Way_min)
                        ER++;
                    else EE++;
                    error = ER;
                    luck = EE;

                }
                else
                {
                    if (checkBox1.Checked == true)
                    {
                        if (checkBox2.Checked == true)
                        {
                            if (Way_Ant != Way_Ann)

                            {
                                error++;
                            }
                            else
                            {
                                luck++;
                            }
                        }
                        if (checkBox3.Checked == true)
                        {
                            if (Way_Ant != Way_min)

                            {
                                error++;
                            }
                            else
                            {
                                luck++;
                            }
                        }
                    }
                    if (checkBox2.Checked == true)
                    {
                        if (checkBox3.Checked == true)
                        {
                            if (Way_Ann != Way_min)

                            {
                                error++;
                            }
                            else
                            {
                                luck++;
                            }
                        }
                    }
                }

                t_B_Count.Text = Convert.ToString(error);
                t_B_Luck.Text = Convert.ToString(luck);
            }
            catch (FormatException) { MessageBox.Show("Не все расчёты выполнены.", "Ошибка"); }
        }
        public void b_Enter_Click(object sender, EventArgs e)//метод обрабатывающий кнопку "выполнить"
        {
            M_Ant c1 = new M_Ant();
            M_Ann c2 = new M_Ann();
            M_Enumeration c3 = new M_Enumeration();
            try
            {
                if (checkBox1.Checked)
                {
                    Ant = Convert.ToDouble(t_B_CityAnt.Text);
                    Alpha = Convert.ToDouble(t_B_Alpha.Text);
                    Betta = Convert.ToDouble(t_B_Betta.Text);
                    Q = Convert.ToDouble(t_B_Q.Text);
                    p = Convert.ToDouble(t_B_p.Text);
                    c1.Antt();
                    t_B_LengWay.Text = Convert.ToString(c1.Leng);
                    radioButton1.Checked = true;
                    radioButton1_CheckedChanged(sender, e);
                }
                if (checkBox2.Checked)
                {

                    Temp = Convert.ToDouble(t_B_Temp.Text);
                    Temp_min = Convert.ToDouble(t_B_Temp_N.Text);
                    Coef = Convert.ToDouble(t_B_CoefTemp.Text);
                    c2.Annealing();
                    t_B_LengWay_Ann.Text = Convert.ToString(c2.S);
                    radioButton2.Checked = true;
                    radioButton2_CheckedChanged(sender, e);
                }
                if (checkBox3.Checked == true)
                {
                if (CityNumb <= 6)
                {
                    leng2.Clear();
                    t_B_List.Clear();
                    c3.Bust(t_B_List);                        
                        t_B_MinWay.Text = Convert.ToString(c3.Leng_3);
                }
                else
                    MessageBox.Show("При таком количестве городов программа может зависнуть.\nПожалуйста уменьшите кол-во городов или выберите другой метод.", "Внимание");

                }
                if ((checkBox2.Checked == true && checkBox1.Checked == true) || (checkBox1.Checked == true && checkBox3.Checked == true) ||
                    (checkBox2.Checked == true && checkBox3.Checked == true)|| (checkBox1.Checked==true&& checkBox2.Checked == true && checkBox3.Checked == true))
                Count();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введен неверный формат данных!", "Ошибка");
                Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("Введено отрицательное число!", "Ошибка");
                Clear();
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Введено нулевое значение!", "Ошибка");
                Clear();
            }
        }
        private void b_All_Checkend_Click(object sender, EventArgs e)
        {
            b_Enter_Click(sender, e);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                Graphics g_1 = pic_B_OptiWay.CreateGraphics();
                g_1.Clear(Color.LightSteelBlue);
                New_road(CityNumb, Le, g_1);
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Graphics g_1 = pic_B_OptiWay.CreateGraphics();
                g_1.Clear(Color.LightSteelBlue);
                New_road(CityNumb, CityNum, g_1);
            }
        }      
    }
    
}
        


