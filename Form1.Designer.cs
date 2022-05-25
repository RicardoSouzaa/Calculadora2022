
namespace CalculadoraTeste
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.bnt9 = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnResultado = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(16, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(254, 23);
            this.txtResultado.TabIndex = 50;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.SystemColors.Window;
            this.lblOperacao.ForeColor = System.Drawing.Color.Red;
            this.lblOperacao.Location = new System.Drawing.Point(22, 9);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(0, 15);
            this.lblOperacao.TabIndex = 500;
            this.lblOperacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(16, 64);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(46, 39);
            this.btn7.TabIndex = 2;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(68, 64);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(46, 39);
            this.btn8.TabIndex = 3;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // bnt9
            // 
            this.bnt9.Location = new System.Drawing.Point(120, 64);
            this.bnt9.Name = "bnt9";
            this.bnt9.Size = new System.Drawing.Size(46, 39);
            this.bnt9.TabIndex = 4;
            this.bnt9.Text = "9";
            this.bnt9.UseVisualStyleBackColor = true;
            this.bnt9.Click += new System.EventHandler(this.bnt9_Click);
            // 
            // btnMais
            // 
            this.btnMais.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnMais.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.Location = new System.Drawing.Point(172, 64);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(46, 39);
            this.btnMais.TabIndex = 5;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.IndianRed;
            this.btnCE.Location = new System.Drawing.Point(224, 64);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(46, 39);
            this.btnCE.TabIndex = 6;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(224, 109);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(46, 39);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.btnMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.Location = new System.Drawing.Point(172, 109);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(46, 39);
            this.btnMenos.TabIndex = 10;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(120, 109);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(46, 39);
            this.btn6.TabIndex = 9;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(68, 109);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(46, 39);
            this.btn5.TabIndex = 8;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(16, 109);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(46, 39);
            this.btn4.TabIndex = 7;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnResultado
            // 
            this.btnResultado.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnResultado.Location = new System.Drawing.Point(224, 154);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(46, 83);
            this.btnResultado.TabIndex = 16;
            this.btnResultado.Text = "=";
            this.btnResultado.UseVisualStyleBackColor = false;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // btnMult
            // 
            this.btnMult.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.Location = new System.Drawing.Point(172, 154);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(46, 39);
            this.btnMult.TabIndex = 15;
            this.btnMult.Text = "*";
            this.btnMult.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(120, 154);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(46, 39);
            this.btn3.TabIndex = 14;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(68, 154);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(46, 39);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(16, 154);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(46, 39);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.Location = new System.Drawing.Point(172, 199);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(46, 39);
            this.btnDiv.TabIndex = 20;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.Location = new System.Drawing.Point(120, 199);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(46, 39);
            this.btnVirgula.TabIndex = 19;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = true;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(16, 199);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(98, 39);
            this.btn0.TabIndex = 17;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // txtResultado2
            // 
            this.txtResultado2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado2.Location = new System.Drawing.Point(16, 5);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.ReadOnly = true;
            this.txtResultado2.Size = new System.Drawing.Size(257, 23);
            this.txtResultado2.TabIndex = 1;
            this.txtResultado2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResultado2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 249);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.bnt9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txtResultado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button bnt9;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtResultado2;
    }
}

