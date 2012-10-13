using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pr2
{
    public partial class Form2 : Form
    {
       private ModelContainer database;
        public Form2()
        {
            InitializeComponent();
            database = new ModelContainer();
            var workers = from w in database.workerSet
                          select
                              new
                              {
                                  id = w.Id,
                                  name = w.lname
                              };
            cbox_tabl_name.DataSource = workers.ToArray();//workersToolStripMenuItem
            cbox_tabl_name.DisplayMember = "name";
            cbox_tabl_name.ValueMember = "id";

            var departments = from d in database.departmentSet
                          select
                              new
                              {
                                  id = d.Id,
                                  name = d.dep_name
                              };
            cbox_tabl_name.DataSource = departments.ToArray();
            cbox_tabl_name.DisplayMember = "dept_name";
            cbox_tabl_name.ValueMember = "id";
        }

        private void vnnbToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hjgjhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cbox_tabl_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text )
            { case "сотрудники" :
                    dataGridView1.DataSource = (from w in database.workerSet select new
                        {
                                  номер = w.Id,
                                  фамилия = w.lname
                              }).ToArray();
                    break;
                case "отделы" :
                    dataGridView1.DataSource = (from d in database.departmentSet
                                                select new
                                                {
                                                    номер = d.,
                                                    фамилия = d.lname
                                                }).ToArray();



                default:
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
