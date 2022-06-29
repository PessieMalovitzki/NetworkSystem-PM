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
    public partial class NetworkMetrices : Form
    {
        static int dagreeSum = 0;
        static int fullDagreeSum = 0;
        static int nodesCount;
        public NetworkMetrices()
        {
            InitializeComponent();
            SetMetrictsValues();
        }

        private void SetMetrictsValues()
        {
            nodesCount = Graph._NodesList.Count;
            textBox1.Text = nodesCount.ToString();
            textBox2.Text = CalculateWeightedEdgestCount(true).ToString();
            textBox3.Text = CalculateAvgDagree().ToString();
            textBox4.Text = Math.Round(((double)dagreeSum / (double)nodesCount), 2).ToString();
            textBox5.Text = CalculateDensity().ToString();
        }

        private double CalculateDensity()
        {
            return Math.Round(dagreeSum/(double)(nodesCount*nodesCount),2);
        }

        private double CalculateAvgDagree()
        {
            return Math.Round(((double)fullDagreeSum / (double)Graph._NodesList.Count),2);
        }

        private int CalculateWeightedEdgestCount(bool isWeighted)
        {
            foreach (var node in Graph._NodesList.ToList())
            {
                node.OutEdgest.ToList().ForEach(x => { dagreeSum++; fullDagreeSum += x.Value; });
            }
            if(isWeighted)
            return dagreeSum;
            return fullDagreeSum;
        }


    }
}
