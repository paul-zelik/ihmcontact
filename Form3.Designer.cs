namespace WindowsFormsApp1
{
    partial class Form3
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
            this.buttonAfficherSelection = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.checkedListBoxContacts = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label1.Location = new System.Drawing.Point(159, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 51);
            this.label1.TabIndex = 10;
            this.label1.Text = "Modification d\'un contact";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonAfficherSelection
            // 
            this.buttonAfficherSelection.Enabled = false;
            this.buttonAfficherSelection.Location = new System.Drawing.Point(577, 370);
            this.buttonAfficherSelection.Name = "buttonAfficherSelection";
            this.buttonAfficherSelection.Size = new System.Drawing.Size(187, 68);
            this.buttonAfficherSelection.TabIndex = 11;
            this.buttonAfficherSelection.Text = "Afficher le contact";
            this.buttonAfficherSelection.UseVisualStyleBackColor = true;
            this.buttonAfficherSelection.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 68);
            this.button1.TabIndex = 12;
            this.button1.Text = "Retour";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.13F);
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Listes de vos contacts :";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(755, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(33, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkedListBoxContacts
            // 
            this.checkedListBoxContacts.FormattingEnabled = true;
            this.checkedListBoxContacts.Location = new System.Drawing.Point(26, 176);
            this.checkedListBoxContacts.Name = "checkedListBoxContacts";
            this.checkedListBoxContacts.Size = new System.Drawing.Size(120, 89);
            this.checkedListBoxContacts.TabIndex = 15;
            this.checkedListBoxContacts.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxContacts);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAfficherSelection);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAfficherSelection;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox checkedListBoxContacts;
    }
}