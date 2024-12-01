using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrilojenieAIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 20; i >= 0; i--)
            {
                Button btn = new Button();
                btn.Location = new Point(1, i * btn.Height + 10);
                btn.Dock = DockStyle.Top;
                btn.TabIndex = i;
                btn.Height = 35;
                btn.Name = "lesson" + (i) + "btn";
                btn.Text = "Урок : " + (i);
                btn.ForeColor = Color.White;
                btn.TextAlign = ContentAlignment.MiddleCenter;
                menuStrip.Controls.Add(btn);
                btn.Click += Menu_Click;
            }
            menuStrip.Visible = false;
            Title.FlatAppearance.MouseDownBackColor = Title.BackColor;
            Title.FlatAppearance.MouseOverBackColor = Title.BackColor;
            Lesson lesson = new Lesson();
            AddControl(lesson);
            lesson.SetImage(".\\Resources\\lesson0.jpg");


        }

        private void Menu_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Lesson lesson = new Lesson();
            AddControl(lesson);
            switch (button.Name)
            {
                case "lesson0btn":
                    lesson.SetImage(".\\Resources\\lesson0.jpg");
                    Title.Text = "Урок 0 : основы работы с программой";
                    break;
                case "lesson1btn":
                    lesson.SetImage(".\\Resources\\lesson1.jpg");
                    Title.Text = "Урок 1 : получение данных, SELECT";
                    break;
                case "lesson2btn":
                    lesson.SetImage(".\\Resources\\lesson2.jpg");
                    Title.Text = "Урок 2 : условие выборки, WHERE";
                    break;
                case "lesson3btn":
                    lesson.SetImage(".\\Resources\\lesson3.jpg");
                    Title.Text = "Урок 3 : условие выборки, HAVING";
                    break;
                case "lesson4btn":
                    lesson.SetImage(".\\Resources\\lesson4.jpg");
                    Title.Text = "Урок 4 : BETWEEN IN и NOT IN";
                    break;
                case "lesson5btn":
                    lesson.SetImage(".\\Resources\\lesson5.jpg");
                    Title.Text = "Урок 5 : группировка, GROUP BY";
                    break;
                case "lesson6btn":
                    lesson.SetImage(".\\Resources\\lesson6.jpg");
                    Title.Text = "Урок 6 : сортировка, ORDER BY";
                    break;
                case "lesson7btn":
                    lesson.SetImage(".\\Resources\\lesson7.jpg");
                    Title.Text = "Урок 7 : условие выборки, LIMIT|OFFSET";
                    break;
                case "lesson8btn":
                    lesson.SetImage(".\\Resources\\lesson8.jpg");
                    Title.Text = "Урок 8 : объединение, UNION";
                    break;
                case "lesson9btn":
                    lesson.SetImage(".\\Resources\\lesson9.jpg");
                    Title.Text = "Урок 9 : объединение, INTERSECT";
                    break;
                case "lesson10btn":
                    lesson.SetImage(".\\Resources\\lesson10.jpg");
                    Title.Text = "Урок 10 : объединение, EXCEPT";
                    break;
                case "lesson11btn":
                    lesson.SetImage(".\\Resources\\lesson11.jpg");
                    Title.Text = "Урок 11 : условие выборки, DISTINCT";
                    break;
                case "lesson12btn":
                    lesson.SetImage(".\\Resources\\lesson12.jpg");
                    Title.Text = "Урок 12 : соединение таблиц, INNER JOIN";
                    break;
                case "lesson13btn":
                    lesson.SetImage(".\\Resources\\lesson13.jpg");
                    Title.Text = "Урок 13 : соединение таблиц, LEFT JOIN";
                    break;
                case "lesson14btn":
                    lesson.SetImage(".\\Resources\\lesson14.jpg");
                    Title.Text = "Урок 14 : соединение таблиц, RIGHT JOIN";
                    break;
                case "lesson15btn":
                    lesson.SetImage(".\\Resources\\lesson15.jpg");
                    Title.Text = "Урок 15 : соединение таблиц, CROSS JOIN";
                    break;
                case "lesson16btn":
                    lesson.SetImage(".\\Resources\\lesson16.jpg");
                    Title.Text = "Урок 16 : функции, AVG()";
                    break;
                case "lesson17btn":
                    lesson.SetImage(".\\Resources\\lesson17.jpg");
                    Title.Text = "Урок 17 : функции, SUM()";
                    break;
                case "lesson18btn":
                    lesson.SetImage(".\\Resources\\lesson18.jpg");
                    Title.Text = "Урок 18 : функции, COUNT()";
                    break;
                case "lesson19btn":
                    lesson.SetImage(".\\Resources\\lesson19.jpg");
                    Title.Text = "Урок 19 : подзапросы";
                    break;
                case "lesson20btn":
                    lesson.SetImage(".\\Resources\\lesson20.jpg");
                    Title.Text = "Урок 20 : конкатенация столбцов";
                    break;
            }
        }
        private void Menu_Show(object sender, EventArgs e)
        {
            menuStrip.Visible = !menuStrip.Visible;
        }
        public void AddControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            userControlPanel.Controls.Clear();
            userControlPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void buttonSQL_Click(object sender, EventArgs e)
        {
            Querry querry = new Querry();
            AddControl(querry);
            Title.Text = "Работа с базой. Запросы";
            querry.BringToFront();

        }
    }
}
