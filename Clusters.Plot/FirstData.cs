using ClusterAnalysis;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClustersPlot
{
    public partial class FirstData : Form
    {
        List<PointC> firstD;
        string facOne;
        string facTwo;
        public FirstData(List<PointC> dats, string facOne, string facTwo)
        {
            firstD = new List<PointC>(dats);
            this.facOne = facOne;
            this.facTwo = facTwo;
            InitializeComponent();
        }

        private void FirstData_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 92;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowHeadersVisible = false;

            for (int i = 0; i < firstD.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
                dataGridView1.Rows[i].Cells[1].Value = firstD[i].province;
                dataGridView1.Rows[i].Cells[2].Value = firstD[i].X;
                dataGridView1.Rows[i].Cells[3].Value = firstD[i].Y;
            }

            dataGridView1.Columns[2].HeaderText = facOne;
            dataGridView1.Columns[3].HeaderText = facTwo;
        }
    }
}
