using IronXL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetworkSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                loadinglbl.Visible = true;
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    string fileExt = Path.GetExtension(file.FileName);
                    if (fileExt.CompareTo(".xls") == 0 || fileExt.CompareTo(".xlsx") == 0)
                    {
                        //Load the excel file into sheets
                        WorkBook workbook = WorkBook.Load(file.FileName);
                        WorkSheet nodesSheet = workbook.GetWorkSheet("Nodes");
                        WorkSheet edgesSheet = workbook.GetWorkSheet("Edges");
                        LoadNodes(nodesSheet);
                        LoadEdgests(edgesSheet);

                    }
                    else MessageBox.Show("Wrong format :(");
                }
                loadinglbl.Visible = false;
                srcBtn.Visible = true;
                button1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("File failed to load. Error:{0}", ex.Message));
            }

        }

        //Load the edgests
        private void LoadEdgests(WorkSheet edgesSheet)
        {
            int edgestCount = edgesSheet.RowCount;
            var sourcesList = edgesSheet.Columns[0].ToArray();
            var targetList = edgesSheet.Columns[1].ToArray();
            for (int i = 1; i < edgestCount; i++)
            {
                try
                {
                    //Find the source nodes objects for both source and target nodes.
                    Node source = Graph.findNodeByKey(Int32.Parse(sourcesList[i].ToString()));
                    Node target = Graph.findNodeByKey(Int32.Parse(targetList[i].ToString()));
                    if(source!=null && target!=null)
                    Graph.AddEdgest(source, target);
                }
                catch
                {
                    //Do nothing - continue to the next node
                }
            }
        }

        //Load nodes
        private void LoadNodes(WorkSheet nodesSheet)
        {

            int nodesCount = nodesSheet.RowCount;
            var keyList = nodesSheet.Columns[0].ToArray();
            var labelList = nodesSheet.Columns[1].ToArray();

            for (int i = 1; i < nodesCount; i++)
            {
                try
                {
                    var Node = new Node(Int32.Parse(keyList[i].Value.ToString()), labelList[i].Value.ToString());
                    Graph.AddNode(Node.NodeKey, Node.NodeLabel);
                }
                catch
                {
                    //Do nothing - continue to the next node
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            NetworkMetrices nt = new NetworkMetrices();
            nt.Show();
        }

        private void srcBtn_Click(object sender, EventArgs e)
        {
            SearchNode sn = new SearchNode();
            sn.Show();
        }
    }
}
