using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Result
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int Sno;
        public int Total;
        public int ObtainedTotal;
        public Double Percent;
        private void btnAdd_Click(object sender, EventArgs e)
        {

            int TotalMark = Convert.ToInt32(txtTotalMark.Text);
            int ObtainedMark = Convert.ToInt32(txtObtainedMark.Text);
            int PassMark = Convert.ToInt32(txtPassMark.Text);
            String SubjectName = txtSubjectName.Text;
            Sno = Sno + 1;
            dgvResultDetails.Rows.Add(Sno, SubjectName, TotalMark, PassMark, ObtainedMark);
            Total = Total + TotalMark;
            ObtainedTotal = ObtainedTotal + ObtainedMark;
            lblTotalMark.Text = Total.ToString();
            lblObtainedTotal.Text = ObtainedTotal.ToString();
          
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            Double t = Convert.ToDouble(lblTotalMark.Text);
            Double ot = Convert.ToDouble(lblObtainedTotal.Text);
            Percent = ot / t * 100;
            lblPercent.Text = Percent.ToString();
           
        }
    }
}
