namespace Arreglos
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnTirar = new System.Windows.Forms.Button();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 116);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnTirar
            // 
            this.btnTirar.BackColor = System.Drawing.Color.Transparent;
            this.btnTirar.FlatAppearance.BorderSize = 0;
            this.btnTirar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTirar.Image = global::Arreglos.Properties.Resources.dice__1_;
            this.btnTirar.Location = new System.Drawing.Point(361, 119);
            this.btnTirar.Name = "btnTirar";
            this.btnTirar.Size = new System.Drawing.Size(233, 119);
            this.btnTirar.TabIndex = 1;
            this.btnTirar.UseVisualStyleBackColor = false;
            this.btnTirar.Click += new System.EventHandler(this.btnTirar_Click);
            // 
            // lbResultados
            // 
            this.lbResultados.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.ItemHeight = 22;
            this.lbResultados.Location = new System.Drawing.Point(35, 61);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(232, 242);
            this.lbResultados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 53);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tire los dados";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(606, 387);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbResultados);
            this.Controls.Add(this.btnTirar);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Casino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTirar;
        private System.Windows.Forms.ListBox lbResultados;
        private System.Windows.Forms.Label label1;
    }
}

