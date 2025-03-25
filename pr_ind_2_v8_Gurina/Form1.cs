using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace pr_ind_2_v8_Gurina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string file = "spisok.txt"; //spisok.txt

            try
            {
                Queue<string> youngPeople = new Queue<string>();
                Queue<string> oldPeople = new Queue<string>();

                var lines = File.ReadAllLines(file);

                foreach (var line in lines)
                {
                    var parts = line.Split(';');

                    if (parts.Length != 6) continue;

                    // фио
                    string lastName = parts[0]; 
                    string firstName = parts[1];
                    string patronymic = parts[2];
                    string gender = parts[3]; // пол
                    int age = int.Parse(parts[4]); // возраст
                    int sum = int.Parse(parts[5]); // зарплата

                    if (age < 30)
                    {
                        youngPeople.Enqueue(line);
                    }
                    else
                    {
                        oldPeople.Enqueue(line);
                    }

                    while (youngPeople.Count > 0)
                    {
                        listBox1.Items.Add(youngPeople.Dequeue());
                    }
                    while (oldPeople.Count > 0)
                    {
                        listBox1.Items.Add(oldPeople.Dequeue());
                    }

                    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка при считывание из файла!");
            }
        }
    }
}
