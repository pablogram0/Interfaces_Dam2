namespace Ejercicio10Primitiva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevaApuesta = new System.Windows.Forms.Button();
            this.btnJugar = new System.Windows.Forms.Button();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblTuApuesta = new System.Windows.Forms.Label();
            this.txtTuApuesta1 = new System.Windows.Forms.TextBox();
            this.txtTuApuesta2 = new System.Windows.Forms.TextBox();
            this.txtTuApuesta3 = new System.Windows.Forms.TextBox();
            this.txtTuApuesta4 = new System.Windows.Forms.TextBox();
            this.txtTuApuesta5 = new System.Windows.Forms.TextBox();
            this.txtTuApuesta6 = new System.Windows.Forms.TextBox();
            this.txtResult1 = new System.Windows.Forms.TextBox();
            this.txtResult2 = new System.Windows.Forms.TextBox();
            this.txtResult6 = new System.Windows.Forms.TextBox();
            this.txtResult5 = new System.Windows.Forms.TextBox();
            this.txtResult4 = new System.Windows.Forms.TextBox();
            this.txtResult3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(349, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 96);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(349, 242);
            this.checkedListBox1.MultiColumn = true;
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(496, 289);
            this.checkedListBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(42, 347);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(256, 48);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "Selecciona los seis numeros \r\n con lo que quieres jugar";
            this.lblInfo.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(209, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(477, 84);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "LOTERIAS Y APUESTAS \r\n          DEL ESTADO";
            this.lblTitulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnNuevaApuesta
            // 
            this.btnNuevaApuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaApuesta.Location = new System.Drawing.Point(433, 673);
            this.btnNuevaApuesta.Name = "btnNuevaApuesta";
            this.btnNuevaApuesta.Size = new System.Drawing.Size(134, 42);
            this.btnNuevaApuesta.TabIndex = 5;
            this.btnNuevaApuesta.Text = "NUEVA APUESTA";
            this.btnNuevaApuesta.UseVisualStyleBackColor = true;
            this.btnNuevaApuesta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJugar
            // 
            this.btnJugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJugar.Location = new System.Drawing.Point(668, 673);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(134, 42);
            this.btnJugar.TabIndex = 6;
            this.btnJugar.Text = "JUGAR";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Location = new System.Drawing.Point(70, 623);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(35, 13);
            this.lblResultados.TabIndex = 7;
            this.lblResultados.Text = "label4";
            // 
            // lblTuApuesta
            // 
            this.lblTuApuesta.AutoSize = true;
            this.lblTuApuesta.Location = new System.Drawing.Point(70, 557);
            this.lblTuApuesta.Name = "lblTuApuesta";
            this.lblTuApuesta.Size = new System.Drawing.Size(35, 13);
            this.lblTuApuesta.TabIndex = 8;
            this.lblTuApuesta.Text = "label5";
            // 
            // txtTuApuesta1
            // 
            this.txtTuApuesta1.Location = new System.Drawing.Point(73, 578);
            this.txtTuApuesta1.Name = "txtTuApuesta1";
            this.txtTuApuesta1.Size = new System.Drawing.Size(100, 20);
            this.txtTuApuesta1.TabIndex = 9;
            this.txtTuApuesta1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTuApuesta2
            // 
            this.txtTuApuesta2.Location = new System.Drawing.Point(235, 579);
            this.txtTuApuesta2.Name = "txtTuApuesta2";
            this.txtTuApuesta2.Size = new System.Drawing.Size(100, 20);
            this.txtTuApuesta2.TabIndex = 10;
            // 
            // txtTuApuesta3
            // 
            this.txtTuApuesta3.Location = new System.Drawing.Point(389, 578);
            this.txtTuApuesta3.Name = "txtTuApuesta3";
            this.txtTuApuesta3.Size = new System.Drawing.Size(100, 20);
            this.txtTuApuesta3.TabIndex = 11;
            // 
            // txtTuApuesta4
            // 
            this.txtTuApuesta4.Location = new System.Drawing.Point(527, 578);
            this.txtTuApuesta4.Name = "txtTuApuesta4";
            this.txtTuApuesta4.Size = new System.Drawing.Size(100, 20);
            this.txtTuApuesta4.TabIndex = 12;
            // 
            // txtTuApuesta5
            // 
            this.txtTuApuesta5.Location = new System.Drawing.Point(702, 579);
            this.txtTuApuesta5.Name = "txtTuApuesta5";
            this.txtTuApuesta5.Size = new System.Drawing.Size(100, 20);
            this.txtTuApuesta5.TabIndex = 13;
            // 
            // txtTuApuesta6
            // 
            this.txtTuApuesta6.Location = new System.Drawing.Point(837, 579);
            this.txtTuApuesta6.Name = "txtTuApuesta6";
            this.txtTuApuesta6.Size = new System.Drawing.Size(100, 20);
            this.txtTuApuesta6.TabIndex = 14;
            // 
            // txtResult1
            // 
            this.txtResult1.Location = new System.Drawing.Point(73, 652);
            this.txtResult1.Name = "txtResult1";
            this.txtResult1.Size = new System.Drawing.Size(100, 20);
            this.txtResult1.TabIndex = 15;
            // 
            // txtResult2
            // 
            this.txtResult2.Location = new System.Drawing.Point(235, 641);
            this.txtResult2.Name = "txtResult2";
            this.txtResult2.Size = new System.Drawing.Size(100, 20);
            this.txtResult2.TabIndex = 16;
            // 
            // txtResult6
            // 
            this.txtResult6.Location = new System.Drawing.Point(827, 641);
            this.txtResult6.Name = "txtResult6";
            this.txtResult6.Size = new System.Drawing.Size(100, 20);
            this.txtResult6.TabIndex = 20;
            // 
            // txtResult5
            // 
            this.txtResult5.Location = new System.Drawing.Point(692, 641);
            this.txtResult5.Name = "txtResult5";
            this.txtResult5.Size = new System.Drawing.Size(100, 20);
            this.txtResult5.TabIndex = 19;
            // 
            // txtResult4
            // 
            this.txtResult4.Location = new System.Drawing.Point(517, 640);
            this.txtResult4.Name = "txtResult4";
            this.txtResult4.Size = new System.Drawing.Size(100, 20);
            this.txtResult4.TabIndex = 18;
            // 
            // txtResult3
            // 
            this.txtResult3.Location = new System.Drawing.Point(379, 640);
            this.txtResult3.Name = "txtResult3";
            this.txtResult3.Size = new System.Drawing.Size(100, 20);
            this.txtResult3.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(972, 745);
            this.Controls.Add(this.txtResult6);
            this.Controls.Add(this.txtResult5);
            this.Controls.Add(this.txtResult4);
            this.Controls.Add(this.txtResult3);
            this.Controls.Add(this.txtResult2);
            this.Controls.Add(this.txtResult1);
            this.Controls.Add(this.txtTuApuesta6);
            this.Controls.Add(this.txtTuApuesta5);
            this.Controls.Add(this.txtTuApuesta4);
            this.Controls.Add(this.txtTuApuesta3);
            this.Controls.Add(this.txtTuApuesta2);
            this.Controls.Add(this.txtTuApuesta1);
            this.Controls.Add(this.lblTuApuesta);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.btnNuevaApuesta);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNuevaApuesta;
        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblTuApuesta;
        private System.Windows.Forms.TextBox txtTuApuesta1;
        private System.Windows.Forms.TextBox txtTuApuesta2;
        private System.Windows.Forms.TextBox txtTuApuesta3;
        private System.Windows.Forms.TextBox txtTuApuesta4;
        private System.Windows.Forms.TextBox txtTuApuesta5;
        private System.Windows.Forms.TextBox txtTuApuesta6;
        private System.Windows.Forms.TextBox txtResult1;
        private System.Windows.Forms.TextBox txtResult2;
        private System.Windows.Forms.TextBox txtResult6;
        private System.Windows.Forms.TextBox txtResult5;
        private System.Windows.Forms.TextBox txtResult4;
        private System.Windows.Forms.TextBox txtResult3;
    }
}

