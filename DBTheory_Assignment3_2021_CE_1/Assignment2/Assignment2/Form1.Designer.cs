namespace Assignment2
{
    partial class Form1
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
        private void InitializeComponent()
        {
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxCompany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateDb = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.RichTextBox();
            this.buttonCountRecords = new System.Windows.Forms.Button();
            this.buttonViewDb = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customersRadioButton = new System.Windows.Forms.RadioButton();
            this.ordersRadioButton = new System.Windows.Forms.RadioButton();
            this.employeesRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(168, 33);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(127, 26);
            this.textBoxId.TabIndex = 0;
            // 
            // textBoxCompany
            // 
            this.textBoxCompany.Location = new System.Drawing.Point(168, 85);
            this.textBoxCompany.Name = "textBoxCompany";
            this.textBoxCompany.Size = new System.Drawing.Size(127, 26);
            this.textBoxCompany.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company Name:";
            // 
            // buttonUpdateDb
            // 
            this.buttonUpdateDb.Location = new System.Drawing.Point(110, 136);
            this.buttonUpdateDb.Name = "buttonUpdateDb";
            this.buttonUpdateDb.Size = new System.Drawing.Size(146, 38);
            this.buttonUpdateDb.TabIndex = 4;
            this.buttonUpdateDb.Text = "Update Database";
            this.buttonUpdateDb.UseVisualStyleBackColor = true;
            this.buttonUpdateDb.Click += new System.EventHandler(this.buttonUpdateDb_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Enabled = false;
            this.textBoxDisplay.Location = new System.Drawing.Point(383, 33);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(364, 78);
            this.textBoxDisplay.TabIndex = 5;
            this.textBoxDisplay.Text = "";
            // 
            // buttonCountRecords
            // 
            this.buttonCountRecords.Location = new System.Drawing.Point(489, 136);
            this.buttonCountRecords.Name = "buttonCountRecords";
            this.buttonCountRecords.Size = new System.Drawing.Size(146, 38);
            this.buttonCountRecords.TabIndex = 6;
            this.buttonCountRecords.Text = "Count Records";
            this.buttonCountRecords.UseVisualStyleBackColor = true;
            this.buttonCountRecords.Click += new System.EventHandler(this.buttonCountRecords_Click);
            // 
            // buttonViewDb
            // 
            this.buttonViewDb.Location = new System.Drawing.Point(315, 387);
            this.buttonViewDb.Name = "buttonViewDb";
            this.buttonViewDb.Size = new System.Drawing.Size(146, 37);
            this.buttonViewDb.TabIndex = 8;
            this.buttonViewDb.Text = "View Database";
            this.buttonViewDb.UseVisualStyleBackColor = true;
            this.buttonViewDb.Click += new System.EventHandler(this.buttonViewDb_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(722, 135);
            this.dataGridView1.TabIndex = 9;
            // 
            // customersRadioButton
            // 
            this.customersRadioButton.AutoSize = true;
            this.customersRadioButton.Location = new System.Drawing.Point(296, 150);
            this.customersRadioButton.Name = "customersRadioButton";
            this.customersRadioButton.Size = new System.Drawing.Size(154, 24);
            this.customersRadioButton.TabIndex = 10;
            this.customersRadioButton.TabStop = true;
            this.customersRadioButton.Text = "Customers Table";
            this.customersRadioButton.UseVisualStyleBackColor = true;
            // 
            // ordersRadioButton
            // 
            this.ordersRadioButton.AutoSize = true;
            this.ordersRadioButton.Location = new System.Drawing.Point(296, 180);
            this.ordersRadioButton.Name = "ordersRadioButton";
            this.ordersRadioButton.Size = new System.Drawing.Size(125, 24);
            this.ordersRadioButton.TabIndex = 11;
            this.ordersRadioButton.TabStop = true;
            this.ordersRadioButton.Text = "Orders Table";
            this.ordersRadioButton.UseVisualStyleBackColor = true;
            // 
            // employeesRadioButton
            // 
            this.employeesRadioButton.AutoSize = true;
            this.employeesRadioButton.Location = new System.Drawing.Point(296, 210);
            this.employeesRadioButton.Name = "employeesRadioButton";
            this.employeesRadioButton.Size = new System.Drawing.Size(155, 24);
            this.employeesRadioButton.TabIndex = 12;
            this.employeesRadioButton.TabStop = true;
            this.employeesRadioButton.Text = "Employees Table";
            this.employeesRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeesRadioButton);
            this.Controls.Add(this.ordersRadioButton);
            this.Controls.Add(this.customersRadioButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonViewDb);
            this.Controls.Add(this.buttonCountRecords);
            this.Controls.Add(this.textBoxDisplay);
            this.Controls.Add(this.buttonUpdateDb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCompany);
            this.Controls.Add(this.textBoxId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxCompany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateDb;
        private System.Windows.Forms.RichTextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonCountRecords;
        private System.Windows.Forms.Button buttonViewDb;
        private System.Windows.Forms.DataGridView dataGridView1;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>

        #endregion

        private System.Windows.Forms.RadioButton customersRadioButton;
        private System.Windows.Forms.RadioButton ordersRadioButton;
        private System.Windows.Forms.RadioButton employeesRadioButton;
    }
}

