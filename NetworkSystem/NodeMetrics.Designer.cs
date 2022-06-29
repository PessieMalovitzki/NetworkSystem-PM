
namespace NetworkSystem
{
    partial class NodeMetrics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hide2Btn = new System.Windows.Forms.Button();
            this.showBtm = new System.Windows.Forms.Button();
            this.dgvInE = new System.Windows.Forms.DataGridView();
            this.hide1Btn = new System.Windows.Forms.Button();
            this.dgvOutE = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutE)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "מקרא";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Location = new System.Drawing.Point(185, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 29);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "קשתות נכנסות";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(185, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "קשתות יוצאות";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(358, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(559, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 8;
            // 
            // hide2Btn
            // 
            this.hide2Btn.Location = new System.Drawing.Point(466, 129);
            this.hide2Btn.Name = "hide2Btn";
            this.hide2Btn.Size = new System.Drawing.Size(145, 43);
            this.hide2Btn.TabIndex = 9;
            this.hide2Btn.Text = "Hide out edgests";
            this.hide2Btn.UseVisualStyleBackColor = true;
            this.hide2Btn.Click += new System.EventHandler(this.hide2Btn_Click);
            // 
            // showBtm
            // 
            this.showBtm.Location = new System.Drawing.Point(638, 129);
            this.showBtm.Name = "showBtm";
            this.showBtm.Size = new System.Drawing.Size(125, 43);
            this.showBtm.TabIndex = 10;
            this.showBtm.Text = "Show all";
            this.showBtm.UseVisualStyleBackColor = true;
            this.showBtm.Click += new System.EventHandler(this.showBtm_Click);
            // 
            // dgvInE
            // 
            this.dgvInE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInE.Location = new System.Drawing.Point(38, 215);
            this.dgvInE.Name = "dgvInE";
            this.dgvInE.RowHeadersWidth = 51;
            this.dgvInE.RowTemplate.Height = 29;
            this.dgvInE.Size = new System.Drawing.Size(356, 188);
            this.dgvInE.TabIndex = 11;
            //this.dgvInE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hide1Btn
            // 
            this.hide1Btn.Location = new System.Drawing.Point(292, 129);
            this.hide1Btn.Name = "hide1Btn";
            this.hide1Btn.Size = new System.Drawing.Size(143, 43);
            this.hide1Btn.TabIndex = 12;
            this.hide1Btn.Text = "Hide in edgests";
            this.hide1Btn.UseVisualStyleBackColor = true;
            this.hide1Btn.Click += new System.EventHandler(this.hide1Btn_Click);
            // 
            // dgvOutE
            // 
            this.dgvOutE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutE.Location = new System.Drawing.Point(421, 215);
            this.dgvOutE.Name = "dgvOutE";
            this.dgvOutE.RowHeadersWidth = 51;
            this.dgvOutE.RowTemplate.Height = 29;
            this.dgvOutE.Size = new System.Drawing.Size(356, 188);
            this.dgvOutE.TabIndex = 13;
            //this.dgvOutE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutE_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Out-edgests number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "In-edgests number";
            // 
            // NodeMetrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvOutE);
            this.Controls.Add(this.hide1Btn);
            this.Controls.Add(this.dgvInE);
            this.Controls.Add(this.showBtm);
            this.Controls.Add(this.hide2Btn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "NodeMetrics";
            this.Text = "NodeMetrics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button hide2Btn;
        private System.Windows.Forms.Button showBtm;
        private System.Windows.Forms.DataGridView dgvInE;
        private System.Windows.Forms.Button hide1Btn;
        private System.Windows.Forms.DataGridView dgvOutE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}