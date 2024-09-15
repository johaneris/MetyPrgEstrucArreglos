namespace Reservacion
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
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.rbFumar = new System.Windows.Forms.RadioButton();
            this.rbNoFuma = new System.Windows.Forms.RadioButton();
            this.btnReservar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(288, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Reserve su vuelo";
            // 
            // lbResultados
            // 
            this.lbResultados.BackColor = System.Drawing.Color.Lavender;
            this.lbResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.ItemHeight = 22;
            this.lbResultados.Location = new System.Drawing.Point(34, 118);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(687, 374);
            this.lbResultados.TabIndex = 5;
            // 
            // rbFumar
            // 
            this.rbFumar.AutoSize = true;
            this.rbFumar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFumar.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbFumar.Location = new System.Drawing.Point(360, 572);
            this.rbFumar.Name = "rbFumar";
            this.rbFumar.Size = new System.Drawing.Size(120, 30);
            this.rbFumar.TabIndex = 8;
            this.rbFumar.TabStop = true;
            this.rbFumar.Text = "Fumador";
            this.rbFumar.UseVisualStyleBackColor = true;
            // 
            // rbNoFuma
            // 
            this.rbNoFuma.AutoSize = true;
            this.rbNoFuma.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNoFuma.ForeColor = System.Drawing.Color.SteelBlue;
            this.rbNoFuma.Location = new System.Drawing.Point(360, 618);
            this.rbNoFuma.Name = "rbNoFuma";
            this.rbNoFuma.Size = new System.Drawing.Size(157, 30);
            this.rbNoFuma.TabIndex = 9;
            this.rbNoFuma.TabStop = true;
            this.rbNoFuma.Text = "No fumador";
            this.rbNoFuma.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.BackColor = System.Drawing.Color.Transparent;
            this.btnReservar.FlatAppearance.BorderSize = 0;
            this.btnReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservar.ForeColor = System.Drawing.Color.Transparent;
            this.btnReservar.Image = global::Reservacion.Properties.Resources.airplane__1_;
            this.btnReservar.Location = new System.Drawing.Point(523, 480);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(198, 135);
            this.btnReservar.TabIndex = 7;
            this.btnReservar.UseVisualStyleBackColor = false;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(547, 618);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 49);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reserve";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1030, 828);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbNoFuma);
            this.Controls.Add(this.rbFumar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResultados);
            this.ForeColor = System.Drawing.Color.Lavender;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbResultados;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.RadioButton rbFumar;
        private System.Windows.Forms.RadioButton rbNoFuma;
        private System.Windows.Forms.Label label2;
    }
}

