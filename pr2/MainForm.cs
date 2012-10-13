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
    public partial class MainForm : Form
    {
        ModelContainer database;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                database = new ModelContainer();
                MessageBox.Show(database.workerSet.Count().ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int newid = database.workerSet.Count() > 0 ? database.workerSet.Max(w => w.Id) + 1 : 1;
            database.AddToworkerSet(worker.Createworker(0, this.tb_f_name,this.dtp_birth_date,this.tb_adress,this.tb_passport,this.cb_proff.SelectedValue,this.dtp_entry,this.tb_last_name,this.cb_dept));
            //this.tb_f_name, this.tb_last_name, this.tb_adress, this.tb_passport, this.tb_fio,
            database.SaveChanges();
        }

    }
}
