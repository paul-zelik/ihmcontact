namespace WindowsFormsApp1
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Retour = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.btn_EnregistrerLeContact = new System.Windows.Forms.Button();
            this.TitrePage = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.nud_enfant = new System.Windows.Forms.NumericUpDown();
            this.TxtNbEnfants = new System.Windows.Forms.Label();
            this.TxtPrénom = new System.Windows.Forms.Label();
            this.TxtNom = new System.Windows.Forms.Label();
            this.flp_enfant = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nud_enfant)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Retour
            // 
            this.btn_Retour.Location = new System.Drawing.Point(12, 370);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(187, 68);
            this.btn_Retour.TabIndex = 1;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = true;
            this.btn_Retour.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(755, 12);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(33, 23);
            this.btn_Quitter.TabIndex = 4;
            this.btn_Quitter.Text = "X";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_EnregistrerLeContact
            // 
            this.btn_EnregistrerLeContact.Location = new System.Drawing.Point(580, 370);
            this.btn_EnregistrerLeContact.Name = "btn_EnregistrerLeContact";
            this.btn_EnregistrerLeContact.Size = new System.Drawing.Size(187, 68);
            this.btn_EnregistrerLeContact.TabIndex = 4;
            this.btn_EnregistrerLeContact.Text = "Enregistrer le contact";
            this.btn_EnregistrerLeContact.UseVisualStyleBackColor = true;
            this.btn_EnregistrerLeContact.Click += new System.EventHandler(this.EnregistrerLeContact_Click);
            // 
            // TitrePage
            // 
            this.TitrePage.AutoSize = true;
            this.TitrePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.TitrePage.Location = new System.Drawing.Point(228, 30);
            this.TitrePage.Name = "TitrePage";
            this.TitrePage.Size = new System.Drawing.Size(363, 51);
            this.TitrePage.TabIndex = 8;
            this.TitrePage.Text = "Ajout d\'un contact";
            this.TitrePage.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(197, 137);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(143, 22);
            this.txt_nom.TabIndex = 9;
            this.txt_nom.TextChanged += new System.EventHandler(this.textBoxNom_TextChanged);
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(197, 198);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(143, 22);
            this.txt_prenom.TabIndex = 10;
            this.txt_prenom.TextChanged += new System.EventHandler(this.textBoxPrénom_TextChanged);
            // 
            // nud_enfant
            // 
            this.nud_enfant.Location = new System.Drawing.Point(197, 256);
            this.nud_enfant.Name = "nud_enfant";
            this.nud_enfant.Size = new System.Drawing.Size(120, 22);
            this.nud_enfant.TabIndex = 11;
            this.nud_enfant.ValueChanged += new System.EventHandler(this.nud_enfant_ValueChanged);
            // 
            // TxtNbEnfants
            // 
            this.TxtNbEnfants.AutoSize = true;
            this.TxtNbEnfants.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.TxtNbEnfants.Location = new System.Drawing.Point(24, 256);
            this.TxtNbEnfants.Name = "TxtNbEnfants";
            this.TxtNbEnfants.Size = new System.Drawing.Size(148, 20);
            this.TxtNbEnfants.TabIndex = 12;
            this.TxtNbEnfants.Text = "nombre d\'enfants :";
            this.TxtNbEnfants.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtPrénom
            // 
            this.TxtPrénom.AutoSize = true;
            this.TxtPrénom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.TxtPrénom.Location = new System.Drawing.Point(95, 200);
            this.TxtPrénom.Name = "TxtPrénom";
            this.TxtPrénom.Size = new System.Drawing.Size(77, 20);
            this.TxtPrénom.TabIndex = 13;
            this.TxtPrénom.Text = "Prénom :";
            this.TxtPrénom.Click += new System.EventHandler(this.label3_Click);
            // 
            // TxtNom
            // 
            this.TxtNom.AutoSize = true;
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.1F);
            this.TxtNom.Location = new System.Drawing.Point(118, 137);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(54, 20);
            this.TxtNom.TabIndex = 14;
            this.TxtNom.Text = "Nom :";
            this.TxtNom.Click += new System.EventHandler(this.label4_Click);
            // 
            // flp_enfant
            // 
            this.flp_enfant.AutoScroll = true;
            this.flp_enfant.Location = new System.Drawing.Point(360, 105);
            this.flp_enfant.Name = "flp_enfant";
            this.flp_enfant.Size = new System.Drawing.Size(255, 259);
            this.flp_enfant.TabIndex = 15;
            this.flp_enfant.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.flp_enfant);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.TxtPrénom);
            this.Controls.Add(this.TxtNbEnfants);
            this.Controls.Add(this.nud_enfant);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.TitrePage);
            this.Controls.Add(this.btn_EnregistrerLeContact);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Retour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_enfant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Retour;
        private System.Windows.Forms.Button btn_Quitter;
        private System.Windows.Forms.Button btn_EnregistrerLeContact;
        private System.Windows.Forms.Label TitrePage;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.NumericUpDown nud_enfant;
        private System.Windows.Forms.Label TxtNbEnfants;
        private System.Windows.Forms.Label TxtPrénom;
        private System.Windows.Forms.Label TxtNom;
        private System.Windows.Forms.FlowLayoutPanel flp_enfant;
    }
}