
namespace EjerciciosG.Forms
{
    partial class FormaOpiniones
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.regresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Si tiene algun error que reportar u opiniones sobre el proyecto pueden dejar su c" +
    "omentario Aquí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ERROS U OPINIONES";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(431, 20);
            this.textBox1.TabIndex = 2;
            // 
            // regresar
            // 
            this.regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regresar.ForeColor = System.Drawing.Color.Black;
            this.regresar.Location = new System.Drawing.Point(12, 233);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(91, 27);
            this.regresar.TabIndex = 8;
            this.regresar.Text = "Regresar";
            this.regresar.UseVisualStyleBackColor = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // FormaOpiniones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(573, 272);
            this.Controls.Add(this.regresar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaOpiniones";
            this.Text = "FormaOpiniones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button regresar;
    }
}