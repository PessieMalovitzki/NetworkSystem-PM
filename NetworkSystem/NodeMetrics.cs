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
    public partial class NodeMetrics : Form
    {
        List<int> inEdgests;
        List<int> outEdgests;
        Node SelectedNode;
        int outCount;
        int inCount;
        public NodeMetrics(Node selectedNode)
        {
            InitializeComponent();
            inCount = 0;
            outCount = 0;
            SelectedNode = selectedNode;
            // collect all the out edgests for the selected node
            outEdgests = selectedNode.OutEdgest.Select(x => x.Key.NodeKey).ToList();
            inEdgests = new List<int>();
            // collect all the in-edgests for the selected node
            SetInEdgestsList();
            if(inEdgests.Count > 0 || outEdgests.Count > 0)
            {
                SetView();
            }
            // Write the counts of the in-edgests nd out-edgests
            textBox1.Text = outCount.ToString();
            textBox2.Text = inCount.ToString();
        }


        //Set the data grid views rows -
        //We have to data view - 1 for the in-edgests and 1-for out
        public void SetView()
        {
            dgvOutE.Columns.Add("Source", "Source");
            dgvOutE.Columns.Add("Target", "Target");

            dgvInE.Columns.Add("Source", "Source");
            dgvInE.Columns.Add("Target", "Target");
            outEdgests.ForEach(x=>{
                dgvOutE.Rows.Add(SelectedNode.NodeKey, x);
                dgvOutE.Rows[outCount].DefaultCellStyle.BackColor = Color.Lime;
                
                outCount++;
            });
            inEdgests.ForEach(x => {
                dgvInE.Rows.Add(x, SelectedNode.NodeKey);
                dgvInE.Rows[inCount].DefaultCellStyle.BackColor = Color.Red;
              
                inCount++;
            });
        }

        private void SetInEdgestsList()
        {
            foreach(var node in Graph._NodesList)
            {
                if (node.OutEdgest.ContainsKey(SelectedNode))
                    inEdgests.Add(node.NodeKey);
            }    
        }

        //Hide in-edgests view
        private void hide1Btn_Click(object sender, EventArgs e)
        {
            dgvInE.Visible = false;
        }

        //Hide out-edgests view
        private void hide2Btn_Click(object sender, EventArgs e)
        {
            dgvOutE.Visible = false;
        }

        //Show both in and out edgests view
        private void showBtm_Click(object sender, EventArgs e)
        {
            dgvOutE.Visible = true;
            dgvInE.Visible = true;
        }
    }
}
