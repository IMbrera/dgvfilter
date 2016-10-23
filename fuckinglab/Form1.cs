using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace fuckinglab
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region
        public class Student
        {
            //свойства - есть строки таблицы
            public string group { get; set; }
            public string name { get; set; }
            public int value1 { get; set; }
            public int subject1 { get; set; }
            public int subject2 { get; set; }
            public int subject3 { get; set; }

            public Student(string gr, string nm, int v, int s1, int s2, int s3)
            {
                group = gr;
                name = nm;
                value1 = v;
                subject1 = s1;
                subject2 = s2;
                subject3 = s3;
            }
        }
        public List<Student> liststudent = new List<Student>();

        #endregion
        private void button1_Click(object sender, EventArgs e)
        {



           
            #region
            if (textBox1.Text.ToString() != "")
            {
                int i = Int32.Parse(textBox1.Text.ToString());
                dataGridView1.Rows.Clear();

                foreach (Student s in liststudent)
                {
                    if ((s.subject1 == i) && (s.subject2 == i) && (s.subject3 == i))
                    {
                        dataGridView1.Rows.Add(s.group.ToString(), s.name.ToString(), s.value1.ToString(), s.subject1.ToString(), s.subject2.ToString(), s.subject3.ToString());
                    }
                }
                #endregion
                #region
                // for (int i = 0; i < dataGridView1.RowCount; i ++)
                //{ richTextBox1.Text = ", " + Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) + "\r\n" + richTextBox1.Text;
                //}
                /*  foreach (DataGridViewCell item in this.dataGridView1.CurrentRow.Cells)
                  {
                      if (item.ColumnIndex == 4)
                          this.richTextBox1.Text += item.Value.ToString();
                      if (item.ColumnIndex == 5)
                          this.richTextBox1.Text += item.Value.ToString();
                      if (item.ColumnIndex == 6)
                          this.richTextBox1.Text += item.Value.ToString();
                  }*/
                // if ((dataGridView1.Rows[1].Cells[3] = 5 && (dataGridView1.Rows[1].Cells[4] = 5) && (dataGridView1.Rows[1].Cells[5] = 5)))

                //    }
                #endregion
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region


            DataGridViewRow row1 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row1.Cells[0].Value = "11 ПКС";
            row1.Cells[1].Value = "Ильин М.С.";
            row1.Cells[2].Value = "1";
            row1.Cells[3].Value = "5";
            row1.Cells[4].Value = "5";
            row1.Cells[5].Value = "5";
            dataGridView1.Rows.Add(row1);

            DataGridViewRow row2 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row2.Cells[0].Value = "11ПКС";
            row2.Cells[1].Value = "Крамской И.К.";
            row2.Cells[2].Value = "1";
            row2.Cells[3].Value = "5";
            row2.Cells[4].Value = "5";
            row2.Cells[5].Value = "5";
            dataGridView1.Rows.Add(row2);

            DataGridViewRow row3 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row3.Cells[0].Value = "11 ПКС";
            row3.Cells[1].Value = "Кожушная В.В.";
            row3.Cells[2].Value = "1";
            row3.Cells[3].Value = "4";
            row3.Cells[4].Value = "4";
            row3.Cells[5].Value = "4";
            dataGridView1.Rows.Add(row3);

            DataGridViewRow row4 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row4.Cells[0].Value = "11 ПКС";
            row4.Cells[1].Value = "Королев М.Г.";
            row4.Cells[2].Value = "1";
            row4.Cells[3].Value = "5";
            row4.Cells[4].Value = "4";
            row4.Cells[5].Value = "3";
            dataGridView1.Rows.Add(row4);

            DataGridViewRow row5 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row5.Cells[0].Value = "11 ПКС";
            row5.Cells[1].Value = "Меньшиков Х.З.";
            row5.Cells[2].Value = "1";
            row5.Cells[3].Value = "3";
            row5.Cells[4].Value = "3";
            row5.Cells[5].Value = "3";

            dataGridView1.Rows.Add(row5);

            DataGridViewRow row6 = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row6.Cells[0].Value = "11 ПКС";
            row6.Cells[1].Value = "Прахов В.В.";
            row6.Cells[2].Value = "1";
            row6.Cells[3].Value = "5";
            row6.Cells[4].Value = "5";
            row6.Cells[5].Value = "5";

            dataGridView1.Rows.Add(row6);
#endregion

            /*   #region
          for (int i = 0; i <= dataGridView1.Rows.Count; i++)
            {
                liststudent.Add(new Student(dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[1].Value.ToString(), Int32.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString()), Int32.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString()), Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()), Int32.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString())));

                #endregion
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            #region
            Process webpage = new Process();
            AboutBox1 aboutpro = new AboutBox1();
            aboutpro.Show();
            #endregion
            #region




         //   Process.Start(@"E:\трпо\15-16\fuckinglab\fuckinglab\HTMLPage1.htm");



            #endregion
            Help.ShowHelp(this, "filehelp.chm");


        }

        private void справкаToolStripButton_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"filehelp.chm");
        }
    }
}
   