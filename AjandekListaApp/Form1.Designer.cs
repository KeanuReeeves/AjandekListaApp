namespace AjandekListaApp
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
            this.ajandeklist = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nevFelvesz = new System.Windows.Forms.TextBox();
            this.uzletFelvesz = new System.Windows.Forms.TextBox();
            this.Nev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.reszletesAdat = new System.Windows.Forms.ListBox();
            this.btntorol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UzletUpdate = new System.Windows.Forms.TextBox();
            this.nevUpdate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ajandeklist
            // 
            this.ajandeklist.FormattingEnabled = true;
            this.ajandeklist.Location = new System.Drawing.Point(233, 24);
            this.ajandeklist.Name = "ajandeklist";
            this.ajandeklist.Size = new System.Drawing.Size(180, 147);
            this.ajandeklist.TabIndex = 0;
            this.ajandeklist.SelectedIndexChanged += new System.EventHandler(this.ajandeklist_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFelvesz);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nev);
            this.groupBox1.Controls.Add(this.uzletFelvesz);
            this.groupBox1.Controls.Add(this.nevFelvesz);
            this.groupBox1.Location = new System.Drawing.Point(18, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 131);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Beviteli Mező";
            // 
            // nevFelvesz
            // 
            this.nevFelvesz.Location = new System.Drawing.Point(78, 19);
            this.nevFelvesz.Name = "nevFelvesz";
            this.nevFelvesz.Size = new System.Drawing.Size(100, 20);
            this.nevFelvesz.TabIndex = 0;
            // 
            // uzletFelvesz
            // 
            this.uzletFelvesz.Location = new System.Drawing.Point(78, 45);
            this.uzletFelvesz.Name = "uzletFelvesz";
            this.uzletFelvesz.Size = new System.Drawing.Size(100, 20);
            this.uzletFelvesz.TabIndex = 1;
            // 
            // Nev
            // 
            this.Nev.AutoSize = true;
            this.Nev.Location = new System.Drawing.Point(27, 26);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(27, 13);
            this.Nev.TabIndex = 2;
            this.Nev.Text = "Név";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üzlet";
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(54, 87);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(75, 23);
            this.btnFelvesz.TabIndex = 4;
            this.btnFelvesz.Text = "Felvesz";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            // 
            // reszletesAdat
            // 
            this.reszletesAdat.FormattingEnabled = true;
            this.reszletesAdat.Location = new System.Drawing.Point(446, 24);
            this.reszletesAdat.Name = "reszletesAdat";
            this.reszletesAdat.Size = new System.Drawing.Size(173, 43);
            this.reszletesAdat.TabIndex = 2;
            // 
            // btntorol
            // 
            this.btntorol.Location = new System.Drawing.Point(73, 162);
            this.btntorol.Name = "btntorol";
            this.btntorol.Size = new System.Drawing.Size(75, 23);
            this.btntorol.TabIndex = 3;
            this.btntorol.Text = "Törlés";
            this.btntorol.UseVisualStyleBackColor = true;
            this.btntorol.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.UzletUpdate);
            this.groupBox2.Controls.Add(this.nevUpdate);
            this.groupBox2.Location = new System.Drawing.Point(435, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 131);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            this.groupBox2.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(54, 87);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Üzlet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Név";
            // 
            // UzletUpdate
            // 
            this.UzletUpdate.Location = new System.Drawing.Point(78, 45);
            this.UzletUpdate.Name = "UzletUpdate";
            this.UzletUpdate.Size = new System.Drawing.Size(100, 20);
            this.UzletUpdate.TabIndex = 1;
            // 
            // nevUpdate
            // 
            this.nevUpdate.Location = new System.Drawing.Point(78, 19);
            this.nevUpdate.Name = "nevUpdate";
            this.nevUpdate.Size = new System.Drawing.Size(100, 20);
            this.nevUpdate.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btntorol);
            this.Controls.Add(this.reszletesAdat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ajandeklist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ajandeklist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFelvesz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nev;
        private System.Windows.Forms.TextBox uzletFelvesz;
        private System.Windows.Forms.TextBox nevFelvesz;
        private System.Windows.Forms.ListBox reszletesAdat;
        private System.Windows.Forms.Button btntorol;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UzletUpdate;
        private System.Windows.Forms.TextBox nevUpdate;
    }
}

