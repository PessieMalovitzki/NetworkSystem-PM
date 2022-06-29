using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkSystem
{
    public partial class SearchNode : Form
    {
        Dictionary<string, int> lablesList = new Dictionary<string, int>();
        public SearchNode()
        {
            InitializeComponent();
            SetLabelsView();
        }

        private void SetLabelsView()
        {
            //Fill labels list from the node list
            Graph._NodesList.ToList().ForEach(x =>
            {
                if (!lablesList.ContainsKey(x.NodeLabel)) lablesList.Add(x.NodeLabel, 0);
            });
            dataGridView1.Columns.Add("Node Name", "Labels");
            DataGridViewColumn column = dataGridView1.Columns[0];
            column.Width = dataGridView1.Width;
            fillData();
        }

        public void fillData()
        {
            try
            {
                lablesList.ToList().ForEach(x => dataGridView1.Rows.Add(x.Key));
            }
           catch(Exception ex)
            {
                MessageBox.Show(string.Format("Failed to load labels list", ex.Message));
            }
        }

        //When double click on a label from the list - find the node and open the node metrics form.
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            string label = row.Cells[0].Value.ToString();
            NodeMetrics nd = new NodeMetrics(Graph.findNodeByLabel(label));
            nd.Show();

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int maxSimilar = 0;
            string input = textBox1.Text;
            if (input.Length > 0)
            {
                foreach (var item in lablesList.ToList())
                {
                    int i = FindLongestCommonSubstring(input, item.Key);
                    lablesList[item.Key] = i;
                    maxSimilar = i > maxSimilar ? i : maxSimilar;
                }
                dataGridView1.Rows.Clear();
                if (maxSimilar > 0)
                    foreach (var label in lablesList.ToList())
                    {
                        if (label.Value == maxSimilar)
                            dataGridView1.Rows.Add(label.Key);
                    }
            }
            else
                fillData();
        }

        //Function that search the longest sun string and returns the length.
        public int FindLongestCommonSubstring(string s1, string s2)
        {
            int[,] a = new int[s1.Length + 1, s2.Length + 1];
            int row = 0;    // s1 index
            int col = 0;    // s2 index

            for (var i = 0; i < s1.Length; i++)
                for (var j = 0; j < s2.Length; j++)
                    if (s1[i] == s2[j])
                    {
                        int len = a[i + 1, j + 1] = a[i, j] + 1;
                        if (len > a[row, col])
                        {
                            row = i + 1;
                            col = j + 1;
                        }
                    }

            return s1.Substring(row - a[row, col], a[row, col]).Length;
        }
    }
}
