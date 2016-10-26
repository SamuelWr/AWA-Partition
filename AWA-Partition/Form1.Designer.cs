namespace AWA_Partition
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumPeople = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.checkedListBoxStudents = new System.Windows.Forms.CheckedListBox();
            this.buttonToggleCheckbox = new System.Windows.Forms.Button();
            this.buttonCheckUncheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antal personer per grupp";
            // 
            // textBoxNumPeople
            // 
            this.textBoxNumPeople.Location = new System.Drawing.Point(103, 34);
            this.textBoxNumPeople.Name = "textBoxNumPeople";
            this.textBoxNumPeople.Size = new System.Drawing.Size(77, 22);
            this.textBoxNumPeople.TabIndex = 1;
            this.textBoxNumPeople.Text = "2";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(188, 34);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(132, 23);
            this.buttonGenerate.TabIndex = 2;
            this.buttonGenerate.Text = "Skapa Grupper";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.ItemHeight = 16;
            this.listBoxGroups.Location = new System.Drawing.Point(16, 71);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(386, 484);
            this.listBoxGroups.TabIndex = 3;
            // 
            // checkedListBoxStudents
            // 
            this.checkedListBoxStudents.CheckOnClick = true;
            this.checkedListBoxStudents.FormattingEnabled = true;
            this.checkedListBoxStudents.Location = new System.Drawing.Point(408, 71);
            this.checkedListBoxStudents.Name = "checkedListBoxStudents";
            this.checkedListBoxStudents.Size = new System.Drawing.Size(240, 480);
            this.checkedListBoxStudents.TabIndex = 4;
            // 
            // buttonToggleCheckbox
            // 
            this.buttonToggleCheckbox.Location = new System.Drawing.Point(408, 33);
            this.buttonToggleCheckbox.Name = "buttonToggleCheckbox";
            this.buttonToggleCheckbox.Size = new System.Drawing.Size(108, 23);
            this.buttonToggleCheckbox.TabIndex = 5;
            this.buttonToggleCheckbox.Text = "Toggle All";
            this.buttonToggleCheckbox.UseVisualStyleBackColor = true;
            this.buttonToggleCheckbox.Click += new System.EventHandler(this.buttonToggleCheckbox_Click);
            // 
            // buttonCheckUncheck
            // 
            this.buttonCheckUncheck.Location = new System.Drawing.Point(523, 33);
            this.buttonCheckUncheck.Name = "buttonCheckUncheck";
            this.buttonCheckUncheck.Size = new System.Drawing.Size(125, 23);
            this.buttonCheckUncheck.TabIndex = 6;
            this.buttonCheckUncheck.Text = "button1";
            this.buttonCheckUncheck.UseVisualStyleBackColor = true;
            this.buttonCheckUncheck.Click += new System.EventHandler(this.buttonCheckUncheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 608);
            this.Controls.Add(this.buttonCheckUncheck);
            this.Controls.Add(this.buttonToggleCheckbox);
            this.Controls.Add(this.checkedListBoxStudents);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textBoxNumPeople);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumPeople;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.CheckedListBox checkedListBoxStudents;
        private System.Windows.Forms.Button buttonToggleCheckbox;
        private System.Windows.Forms.Button buttonCheckUncheck;
    }
}

