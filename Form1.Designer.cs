namespace calculadora_deskapp
{
    partial class calcForm
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
            this.resultadoTxt = new System.Windows.Forms.TextBox();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.numDot = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.historialOperaciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultadoTxt
            // 
            this.resultadoTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoTxt.Location = new System.Drawing.Point(12, 30);
            this.resultadoTxt.Name = "resultadoTxt";
            this.resultadoTxt.Size = new System.Drawing.Size(593, 64);
            this.resultadoTxt.TabIndex = 1;
            this.resultadoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnDividir
            // 
            this.btnDividir.AllowDrop = true;
            this.btnDividir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDividir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDividir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDividir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.Location = new System.Drawing.Point(404, 139);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(90, 90);
            this.btnDividir.TabIndex = 2;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.dividir);
            // 
            // btnMult
            // 
            this.btnMult.AllowDrop = true;
            this.btnMult.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMult.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(404, 249);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(90, 90);
            this.btnMult.TabIndex = 3;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.multiplicar);
            // 
            // btnRestar
            // 
            this.btnRestar.AllowDrop = true;
            this.btnRestar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRestar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRestar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRestar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(404, 363);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(90, 90);
            this.btnRestar.TabIndex = 4;
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = false;
            this.btnRestar.Click += new System.EventHandler(this.restar);
            // 
            // btnSumar
            // 
            this.btnSumar.AllowDrop = true;
            this.btnSumar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSumar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSumar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSumar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(404, 479);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(90, 90);
            this.btnSumar.TabIndex = 5;
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = false;
            this.btnSumar.Click += new System.EventHandler(this.sumar);
            // 
            // num1
            // 
            this.num1.AllowDrop = true;
            this.num1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(19, 139);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(90, 90);
            this.num1.TabIndex = 6;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.number_click);
            // 
            // num2
            // 
            this.num2.AllowDrop = true;
            this.num2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(150, 139);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(90, 90);
            this.num2.TabIndex = 7;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.number_click);
            // 
            // num3
            // 
            this.num3.AllowDrop = true;
            this.num3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(275, 139);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(90, 90);
            this.num3.TabIndex = 8;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.number_click);
            // 
            // num6
            // 
            this.num6.AllowDrop = true;
            this.num6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num6.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(275, 252);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(90, 90);
            this.num6.TabIndex = 11;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.number_click);
            // 
            // num5
            // 
            this.num5.AllowDrop = true;
            this.num5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num5.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(150, 252);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(90, 90);
            this.num5.TabIndex = 10;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.number_click);
            // 
            // num4
            // 
            this.num4.AllowDrop = true;
            this.num4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(19, 252);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(90, 90);
            this.num4.TabIndex = 9;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.number_click);
            // 
            // num9
            // 
            this.num9.AllowDrop = true;
            this.num9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num9.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num9.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(275, 363);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(90, 90);
            this.num9.TabIndex = 14;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.number_click);
            // 
            // num8
            // 
            this.num8.AllowDrop = true;
            this.num8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num8.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(150, 363);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(90, 90);
            this.num8.TabIndex = 13;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.number_click);
            // 
            // num7
            // 
            this.num7.AllowDrop = true;
            this.num7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num7.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(19, 363);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(90, 90);
            this.num7.TabIndex = 12;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.number_click);
            // 
            // num0
            // 
            this.num0.AllowDrop = true;
            this.num0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.num0.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.num0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num0.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(19, 479);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(221, 90);
            this.num0.TabIndex = 15;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.number_click);
            // 
            // btnResultado
            // 
            this.btnResultado.AllowDrop = true;
            this.btnResultado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResultado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnResultado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnResultado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResultado.Location = new System.Drawing.Point(515, 363);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(92, 206);
            this.btnResultado.TabIndex = 16;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.calcularResultado);
            // 
            // numDot
            // 
            this.numDot.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.numDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.numDot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDot.Location = new System.Drawing.Point(275, 479);
            this.numDot.Name = "numDot";
            this.numDot.Size = new System.Drawing.Size(90, 90);
            this.numDot.TabIndex = 17;
            this.numDot.Text = ".";
            this.numDot.UseVisualStyleBackColor = false;
            this.numDot.Click += new System.EventHandler(this.number_click);
            // 
            // btnClear
            // 
            this.btnClear.AllowDrop = true;
            this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(515, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 90);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.limpiar);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.AllowDrop = true;
            this.btnDeleteAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeleteAll.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.Location = new System.Drawing.Point(515, 139);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(90, 90);
            this.btnDeleteAll.TabIndex = 19;
            this.btnDeleteAll.Text = "CE";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.reset);
            // 
            // historialOperaciones
            // 
            this.historialOperaciones.AutoSize = true;
            this.historialOperaciones.Location = new System.Drawing.Point(16, 9);
            this.historialOperaciones.Name = "historialOperaciones";
            this.historialOperaciones.Size = new System.Drawing.Size(0, 17);
            this.historialOperaciones.TabIndex = 20;
            // 
            // calcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 597);
            this.Controls.Add(this.historialOperaciones);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numDot);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.resultadoTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "calcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox resultadoTxt;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button numDot;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Label historialOperaciones;
    }
}

