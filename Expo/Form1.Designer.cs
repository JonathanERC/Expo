namespace Expo
{
    partial class Expo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expo));
            this.btnnullables = new System.Windows.Forms.Button();
            this.btntiposgenericos = new System.Windows.Forms.Button();
            this.btncoleccionesgenericas = new System.Windows.Forms.Button();
            this.btnmanejodeexcepciones = new System.Windows.Forms.Button();
            this.btnlinq = new System.Windows.Forms.Button();
            this.btnxml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnnullables
            // 
            this.btnnullables.Location = new System.Drawing.Point(12, 12);
            this.btnnullables.Name = "btnnullables";
            this.btnnullables.Size = new System.Drawing.Size(79, 60);
            this.btnnullables.TabIndex = 0;
            this.btnnullables.Text = "Tipos Nullables";
            this.btnnullables.UseVisualStyleBackColor = true;
            this.btnnullables.Click += new System.EventHandler(this.button1_Click);
            // 
            // btntiposgenericos
            // 
            this.btntiposgenericos.Location = new System.Drawing.Point(97, 12);
            this.btntiposgenericos.Name = "btntiposgenericos";
            this.btntiposgenericos.Size = new System.Drawing.Size(79, 60);
            this.btntiposgenericos.TabIndex = 1;
            this.btntiposgenericos.Text = "Tipos Genericos";
            this.btntiposgenericos.UseVisualStyleBackColor = true;
            this.btntiposgenericos.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btncoleccionesgenericas
            // 
            this.btncoleccionesgenericas.Location = new System.Drawing.Point(12, 78);
            this.btncoleccionesgenericas.Name = "btncoleccionesgenericas";
            this.btncoleccionesgenericas.Size = new System.Drawing.Size(79, 60);
            this.btncoleccionesgenericas.TabIndex = 1;
            this.btncoleccionesgenericas.Text = "Colecciones Genericos";
            this.btncoleccionesgenericas.UseVisualStyleBackColor = true;
            this.btncoleccionesgenericas.Click += new System.EventHandler(this.btncoleccionesgenericas_Click);
            // 
            // btnmanejodeexcepciones
            // 
            this.btnmanejodeexcepciones.Location = new System.Drawing.Point(97, 78);
            this.btnmanejodeexcepciones.Name = "btnmanejodeexcepciones";
            this.btnmanejodeexcepciones.Size = new System.Drawing.Size(79, 60);
            this.btnmanejodeexcepciones.TabIndex = 1;
            this.btnmanejodeexcepciones.Text = "Manejo de Excepciones";
            this.btnmanejodeexcepciones.UseVisualStyleBackColor = true;
            this.btnmanejodeexcepciones.Click += new System.EventHandler(this.btnmanejodeexcepciones_Click);
            // 
            // btnlinq
            // 
            this.btnlinq.Location = new System.Drawing.Point(182, 12);
            this.btnlinq.Name = "btnlinq";
            this.btnlinq.Size = new System.Drawing.Size(79, 60);
            this.btnlinq.TabIndex = 2;
            this.btnlinq.Text = "Linq";
            this.btnlinq.UseVisualStyleBackColor = true;
            this.btnlinq.Click += new System.EventHandler(this.btnlinq_Click);
            // 
            // btnxml
            // 
            this.btnxml.Location = new System.Drawing.Point(182, 78);
            this.btnxml.Name = "btnxml";
            this.btnxml.Size = new System.Drawing.Size(79, 60);
            this.btnxml.TabIndex = 3;
            this.btnxml.Text = "XML";
            this.btnxml.UseVisualStyleBackColor = true;
            this.btnxml.Click += new System.EventHandler(this.btnxml_Click);
            // 
            // Expo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 148);
            this.Controls.Add(this.btnxml);
            this.Controls.Add(this.btnlinq);
            this.Controls.Add(this.btnmanejodeexcepciones);
            this.Controls.Add(this.btncoleccionesgenericas);
            this.Controls.Add(this.btntiposgenericos);
            this.Controls.Add(this.btnnullables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Expo";
            this.Text = "Expo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnnullables;
        private System.Windows.Forms.Button btntiposgenericos;
        private System.Windows.Forms.Button btncoleccionesgenericas;
        private System.Windows.Forms.Button btnmanejodeexcepciones;
        private System.Windows.Forms.Button btnlinq;
        private System.Windows.Forms.Button btnxml;
    }
}

