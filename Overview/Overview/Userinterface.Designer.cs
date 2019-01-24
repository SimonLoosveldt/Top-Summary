namespace Overview
{
    partial class Userinterface
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Categorie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leiderField = new System.Windows.Forms.Label();
            this.leiderInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorLeider = new System.Windows.Forms.Label();
            this.labelNr1 = new System.Windows.Forms.Label();
            this.inputNr1 = new System.Windows.Forms.TextBox();
            this.inputNr2 = new System.Windows.Forms.TextBox();
            this.labelNr2 = new System.Windows.Forms.Label();
            this.inputNr3 = new System.Windows.Forms.TextBox();
            this.labelNr3 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.errorTop = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Anaal",
            "Relatie",
            "Gangbangslet",
            "One night stand",
            "Pijpslet"});
            this.comboBox1.Location = new System.Drawing.Point(104, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(215, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Categorie
            // 
            this.Categorie.AutoSize = true;
            this.Categorie.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Categorie.Location = new System.Drawing.Point(14, 94);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(84, 19);
            this.Categorie.TabIndex = 1;
            this.Categorie.Text = "Categorie:";
            this.Categorie.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(35, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Top van:";
            // 
            // leiderField
            // 
            this.leiderField.AutoSize = true;
            this.leiderField.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leiderField.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.leiderField.Location = new System.Drawing.Point(101, 19);
            this.leiderField.Name = "leiderField";
            this.leiderField.Size = new System.Drawing.Size(0, 18);
            this.leiderField.TabIndex = 3;
            // 
            // leiderInput
            // 
            this.leiderInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.leiderInput.Location = new System.Drawing.Point(104, 42);
            this.leiderInput.Name = "leiderInput";
            this.leiderInput.Size = new System.Drawing.Size(149, 20);
            this.leiderInput.TabIndex = 4;
            this.leiderInput.TextChanged += new System.EventHandler(this.LeiderInput_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set person";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // errorLeider
            // 
            this.errorLeider.AutoSize = true;
            this.errorLeider.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLeider.ForeColor = System.Drawing.Color.Red;
            this.errorLeider.Location = new System.Drawing.Point(26, 66);
            this.errorLeider.Name = "errorLeider";
            this.errorLeider.Size = new System.Drawing.Size(212, 14);
            this.errorLeider.TabIndex = 6;
            this.errorLeider.Text = "Gelieve een naam op te geven...";
            // 
            // labelNr1
            // 
            this.labelNr1.AutoSize = true;
            this.labelNr1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNr1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNr1.Location = new System.Drawing.Point(26, 170);
            this.labelNr1.Name = "labelNr1";
            this.labelNr1.Size = new System.Drawing.Size(50, 18);
            this.labelNr1.TabIndex = 7;
            this.labelNr1.Text = "Nr. 1:";
            this.labelNr1.Click += new System.EventHandler(this.Label2_Click);
            // 
            // inputNr1
            // 
            this.inputNr1.Location = new System.Drawing.Point(104, 171);
            this.inputNr1.Name = "inputNr1";
            this.inputNr1.Size = new System.Drawing.Size(215, 20);
            this.inputNr1.TabIndex = 8;
            // 
            // inputNr2
            // 
            this.inputNr2.Location = new System.Drawing.Point(104, 208);
            this.inputNr2.Name = "inputNr2";
            this.inputNr2.Size = new System.Drawing.Size(215, 20);
            this.inputNr2.TabIndex = 10;
            // 
            // labelNr2
            // 
            this.labelNr2.AutoSize = true;
            this.labelNr2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNr2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNr2.Location = new System.Drawing.Point(26, 210);
            this.labelNr2.Name = "labelNr2";
            this.labelNr2.Size = new System.Drawing.Size(50, 18);
            this.labelNr2.TabIndex = 9;
            this.labelNr2.Text = "Nr. 2:";
            // 
            // inputNr3
            // 
            this.inputNr3.Location = new System.Drawing.Point(104, 245);
            this.inputNr3.Name = "inputNr3";
            this.inputNr3.Size = new System.Drawing.Size(215, 20);
            this.inputNr3.TabIndex = 12;
            // 
            // labelNr3
            // 
            this.labelNr3.AutoSize = true;
            this.labelNr3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNr3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNr3.Location = new System.Drawing.Point(26, 247);
            this.labelNr3.Name = "labelNr3";
            this.labelNr3.Size = new System.Drawing.Size(50, 18);
            this.labelNr3.TabIndex = 11;
            this.labelNr3.Text = "Nr. 3:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(215, 300);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(104, 23);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Opslaan";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // errorTop
            // 
            this.errorTop.AutoSize = true;
            this.errorTop.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTop.ForeColor = System.Drawing.Color.Red;
            this.errorTop.Location = new System.Drawing.Point(38, 281);
            this.errorTop.Name = "errorTop";
            this.errorTop.Size = new System.Drawing.Size(0, 14);
            this.errorTop.TabIndex = 14;
            // 
            // Userinterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(348, 362);
            this.Controls.Add(this.errorTop);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.inputNr3);
            this.Controls.Add(this.labelNr3);
            this.Controls.Add(this.inputNr2);
            this.Controls.Add(this.labelNr2);
            this.Controls.Add(this.inputNr1);
            this.Controls.Add(this.labelNr1);
            this.Controls.Add(this.errorLeider);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.leiderInput);
            this.Controls.Add(this.leiderField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Categorie);
            this.Controls.Add(this.comboBox1);
            this.Name = "Userinterface";
            this.Text = "Userinterface";
            this.Load += new System.EventHandler(this.Userinterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leiderField;
        private System.Windows.Forms.TextBox leiderInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label errorLeider;
        private System.Windows.Forms.Label labelNr1;
        private System.Windows.Forms.TextBox inputNr1;
        private System.Windows.Forms.TextBox inputNr2;
        private System.Windows.Forms.Label labelNr2;
        private System.Windows.Forms.TextBox inputNr3;
        private System.Windows.Forms.Label labelNr3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label errorTop;
    }
}