namespace Compi_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CodigoFuente_Txb = new System.Windows.Forms.TextBox();
            this.Btn_Ejecutar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.varia_dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varia_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigoFuente_Txb
            // 
            this.CodigoFuente_Txb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoFuente_Txb.Location = new System.Drawing.Point(12, 12);
            this.CodigoFuente_Txb.Multiline = true;
            this.CodigoFuente_Txb.Name = "CodigoFuente_Txb";
            this.CodigoFuente_Txb.Size = new System.Drawing.Size(352, 361);
            this.CodigoFuente_Txb.TabIndex = 0;
            // 
            // Btn_Ejecutar
            // 
            this.Btn_Ejecutar.Location = new System.Drawing.Point(12, 390);
            this.Btn_Ejecutar.Name = "Btn_Ejecutar";
            this.Btn_Ejecutar.Size = new System.Drawing.Size(135, 60);
            this.Btn_Ejecutar.TabIndex = 1;
            this.Btn_Ejecutar.Text = "Ejecutar";
            this.Btn_Ejecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Btn_Ejecutar.UseVisualStyleBackColor = true;
            this.Btn_Ejecutar.Click += new System.EventHandler(this.Btn_Ejecutar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 390);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 60);
            this.button3.TabIndex = 2;
            this.button3.Text = "Limpiar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(405, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(586, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "LEXICO :)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(405, 259);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(586, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(400, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Errores :)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // varia_dgv
            // 
            this.varia_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varia_dgv.Location = new System.Drawing.Point(1020, 37);
            this.varia_dgv.Name = "varia_dgv";
            this.varia_dgv.Size = new System.Drawing.Size(343, 150);
            this.varia_dgv.TabIndex = 7;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1401, 559);
            this.Controls.Add(this.varia_dgv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btn_Ejecutar);
            this.Controls.Add(this.CodigoFuente_Txb);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varia_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DVG_LISTATOKEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DVG_ERRORES;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_LEXICO;
        private System.Windows.Forms.Button button1;
        private FastColoredTextBoxNS.FastColoredTextBox txb_codigofuente;
        private System.Windows.Forms.TextBox CodigoFuente_Txb;
        private System.Windows.Forms.Button Btn_Ejecutar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView varia_dgv;
    }
}

