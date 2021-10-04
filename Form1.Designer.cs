
namespace PROVA01
{
    partial class FrmCalc
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblOpe = new System.Windows.Forms.Label();
            this.lblTot = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.RadioButton();
            this.btnSubtrai = new System.Windows.Forms.RadioButton();
            this.btnMultiplica = new System.Windows.Forms.RadioButton();
            this.btnDividi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Location = new System.Drawing.Point(95, 134);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(63, 15);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Número 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Location = new System.Drawing.Point(95, 187);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(63, 15);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Número 2:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(164, 131);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(111, 23);
            this.txtNum1.TabIndex = 2;
            this.txtNum1.Enter += new System.EventHandler(this.ZerarNum1);
            this.txtNum1.Validating += new System.ComponentModel.CancelEventHandler(this.valida_numeros);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(164, 178);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(111, 23);
            this.txtNum2.TabIndex = 3;
            this.txtNum2.Enter += new System.EventHandler(this.ZerarNum2);
            this.txtNum2.Validating += new System.ComponentModel.CancelEventHandler(this.valida_numeros);
            // 
            // lblOpe
            // 
            this.lblOpe.AutoSize = true;
            this.lblOpe.Location = new System.Drawing.Point(95, 232);
            this.lblOpe.Name = "lblOpe";
            this.lblOpe.Size = new System.Drawing.Size(160, 15);
            this.lblOpe.TabIndex = 4;
            this.lblOpe.Text = "Escolha a operação desejada:";
            // 
            // lblTot
            // 
            this.lblTot.AutoSize = true;
            this.lblTot.Location = new System.Drawing.Point(95, 354);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(62, 15);
            this.lblTot.TabIndex = 5;
            this.lblTot.Text = "Resultado:";
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(164, 351);
            this.txtTot.Name = "txtTot";
            this.txtTot.Size = new System.Drawing.Size(259, 23);
            this.txtTot.TabIndex = 6;
            // 
            // btnSoma
            // 
            this.btnSoma.AutoSize = true;
            this.btnSoma.Location = new System.Drawing.Point(293, 232);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(62, 19);
            this.btnSoma.TabIndex = 7;
            this.btnSoma.TabStop = true;
            this.btnSoma.Text = "Adição";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.Somar);
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.AutoSize = true;
            this.btnSubtrai.Location = new System.Drawing.Point(293, 257);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(78, 19);
            this.btnSubtrai.TabIndex = 8;
            this.btnSubtrai.TabStop = true;
            this.btnSubtrai.Text = "Subtração";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            this.btnSubtrai.Click += new System.EventHandler(this.Subtrair);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.AutoSize = true;
            this.btnMultiplica.Location = new System.Drawing.Point(293, 282);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(97, 19);
            this.btnMultiplica.TabIndex = 9;
            this.btnMultiplica.TabStop = true;
            this.btnMultiplica.Text = "Multiplicação";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.Multiplicar);
            // 
            // btnDividi
            // 
            this.btnDividi.AutoSize = true;
            this.btnDividi.Location = new System.Drawing.Point(293, 307);
            this.btnDividi.Name = "btnDividi";
            this.btnDividi.Size = new System.Drawing.Size(63, 19);
            this.btnDividi.TabIndex = 10;
            this.btnDividi.TabStop = true;
            this.btnDividi.Text = "Divisão";
            this.btnDividi.UseVisualStyleBackColor = true;
            this.btnDividi.Click += new System.EventHandler(this.Dividir);
            // 
            // FrmCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDividi);
            this.Controls.Add(this.btnMultiplica);
            this.Controls.Add(this.btnSubtrai);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.lblTot);
            this.Controls.Add(this.lblOpe);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "FrmCalc";
            this.Text = "Prova 01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblOpe;
        private System.Windows.Forms.Label lblTot;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.RadioButton btnSoma;
        private System.Windows.Forms.RadioButton btnSubtrai;
        private System.Windows.Forms.RadioButton btnMultiplica;
        private System.Windows.Forms.RadioButton btnDividi;
    }
}

