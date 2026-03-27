namespace Evaluator.UI.Windows
{
    partial class Form1
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
            txtDisplay = new TextBox();
            b7 = new Button();
            b8 = new Button();
            b9 = new Button();
            bparentesisabrir = new Button();
            bparentesiscerrar = new Button();
            bdelete = new Button();
            bclear = new Button();
            bslash = new Button();
            basterisco = new Button();
            b6 = new Button();
            b5 = new Button();
            b4 = new Button();
            bcomilla = new Button();
            bmenos = new Button();
            bmas = new Button();
            b3 = new Button();
            b2 = new Button();
            b1 = new Button();
            b0 = new Button();
            bpunto = new Button();
            bigual = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.AccessibleName = "";
            txtDisplay.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(29, 26);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(344, 51);
            txtDisplay.TabIndex = 0;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TextChanged += textBox1_TextChanged;
            // 
            // b7
            // 
            b7.BackColor = SystemColors.GradientInactiveCaption;
            b7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b7.Location = new Point(31, 98);
            b7.Name = "b7";
            b7.Size = new Size(40, 64);
            b7.TabIndex = 1;
            b7.Text = "7";
            b7.UseVisualStyleBackColor = false;
            b7.Click += b7_Click;
            // 
            // b8
            // 
            b8.BackColor = SystemColors.GradientInactiveCaption;
            b8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b8.Location = new Point(77, 98);
            b8.Name = "b8";
            b8.Size = new Size(40, 64);
            b8.TabIndex = 7;
            b8.Text = "8";
            b8.UseVisualStyleBackColor = false;
            b8.Click += b8_Click;
            // 
            // b9
            // 
            b9.BackColor = SystemColors.GradientInactiveCaption;
            b9.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b9.Location = new Point(123, 98);
            b9.Name = "b9";
            b9.Size = new Size(40, 64);
            b9.TabIndex = 8;
            b9.Text = "9";
            b9.UseVisualStyleBackColor = false;
            b9.Click += b9_Click;
            // 
            // bparentesisabrir
            // 
            bparentesisabrir.BackColor = SystemColors.ActiveCaption;
            bparentesisabrir.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bparentesisabrir.Location = new Point(169, 98);
            bparentesisabrir.Name = "bparentesisabrir";
            bparentesisabrir.Size = new Size(40, 64);
            bparentesisabrir.TabIndex = 9;
            bparentesisabrir.Text = "(";
            bparentesisabrir.UseVisualStyleBackColor = false;
            bparentesisabrir.Click += bparentesisabrir_Click;
            // 
            // bparentesiscerrar
            // 
            bparentesiscerrar.BackColor = SystemColors.ActiveCaption;
            bparentesiscerrar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bparentesiscerrar.Location = new Point(215, 98);
            bparentesiscerrar.Name = "bparentesiscerrar";
            bparentesiscerrar.Size = new Size(40, 64);
            bparentesiscerrar.TabIndex = 10;
            bparentesiscerrar.Text = ")";
            bparentesiscerrar.UseVisualStyleBackColor = false;
            bparentesiscerrar.Click += bparentesiscerrar_Click;
            // 
            // bdelete
            // 
            bdelete.BackColor = SystemColors.ActiveCaption;
            bdelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bdelete.Location = new Point(261, 98);
            bdelete.Name = "bdelete";
            bdelete.Size = new Size(112, 64);
            bdelete.TabIndex = 11;
            bdelete.Text = "DELETE";
            bdelete.UseVisualStyleBackColor = false;
            bdelete.Click += bdelete_Click;
            // 
            // bclear
            // 
            bclear.BackColor = SystemColors.ActiveCaption;
            bclear.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bclear.Location = new Point(261, 168);
            bclear.Name = "bclear";
            bclear.Size = new Size(112, 64);
            bclear.TabIndex = 17;
            bclear.Text = "CLEAR";
            bclear.UseVisualStyleBackColor = false;
            bclear.Click += bclear_Click;
            // 
            // bslash
            // 
            bslash.BackColor = SystemColors.ActiveCaption;
            bslash.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bslash.Location = new Point(215, 168);
            bslash.Name = "bslash";
            bslash.Size = new Size(40, 64);
            bslash.TabIndex = 16;
            bslash.Text = "/";
            bslash.UseVisualStyleBackColor = false;
            bslash.Click += bslash_Click;
            // 
            // basterisco
            // 
            basterisco.BackColor = SystemColors.ActiveCaption;
            basterisco.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            basterisco.Location = new Point(169, 168);
            basterisco.Name = "basterisco";
            basterisco.Size = new Size(40, 64);
            basterisco.TabIndex = 15;
            basterisco.Text = "*";
            basterisco.UseVisualStyleBackColor = false;
            basterisco.Click += basterisco_Click;
            // 
            // b6
            // 
            b6.BackColor = SystemColors.GradientInactiveCaption;
            b6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b6.Location = new Point(123, 168);
            b6.Name = "b6";
            b6.Size = new Size(40, 64);
            b6.TabIndex = 14;
            b6.Text = "6";
            b6.UseVisualStyleBackColor = false;
            b6.Click += b6_Click;
            // 
            // b5
            // 
            b5.BackColor = SystemColors.GradientInactiveCaption;
            b5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b5.Location = new Point(77, 168);
            b5.Name = "b5";
            b5.Size = new Size(40, 64);
            b5.TabIndex = 13;
            b5.Text = "5";
            b5.UseVisualStyleBackColor = false;
            b5.Click += b5_Click;
            // 
            // b4
            // 
            b4.BackColor = SystemColors.GradientInactiveCaption;
            b4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b4.Location = new Point(31, 168);
            b4.Name = "b4";
            b4.Size = new Size(40, 64);
            b4.TabIndex = 12;
            b4.Text = "4";
            b4.UseVisualStyleBackColor = false;
            b4.Click += b4_Click;
            // 
            // bcomilla
            // 
            bcomilla.BackColor = SystemColors.ActiveCaption;
            bcomilla.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bcomilla.Location = new Point(261, 238);
            bcomilla.Name = "bcomilla";
            bcomilla.Size = new Size(112, 64);
            bcomilla.TabIndex = 23;
            bcomilla.Text = "^";
            bcomilla.UseVisualStyleBackColor = false;
            bcomilla.Click += bcomilla_Click;
            // 
            // bmenos
            // 
            bmenos.BackColor = SystemColors.ActiveCaption;
            bmenos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bmenos.Location = new Point(215, 238);
            bmenos.Name = "bmenos";
            bmenos.Size = new Size(40, 64);
            bmenos.TabIndex = 22;
            bmenos.Text = "-";
            bmenos.UseVisualStyleBackColor = false;
            bmenos.Click += bmenos_Click;
            // 
            // bmas
            // 
            bmas.BackColor = SystemColors.ActiveCaption;
            bmas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bmas.Location = new Point(169, 238);
            bmas.Name = "bmas";
            bmas.Size = new Size(40, 64);
            bmas.TabIndex = 21;
            bmas.Text = "+";
            bmas.UseVisualStyleBackColor = false;
            bmas.Click += bmas_Click;
            // 
            // b3
            // 
            b3.BackColor = SystemColors.GradientInactiveCaption;
            b3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b3.Location = new Point(123, 238);
            b3.Name = "b3";
            b3.Size = new Size(40, 64);
            b3.TabIndex = 20;
            b3.Text = "3";
            b3.UseVisualStyleBackColor = false;
            b3.Click += b3_Click;
            // 
            // b2
            // 
            b2.BackColor = SystemColors.GradientInactiveCaption;
            b2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b2.Location = new Point(77, 238);
            b2.Name = "b2";
            b2.Size = new Size(40, 64);
            b2.TabIndex = 19;
            b2.Text = "2";
            b2.UseVisualStyleBackColor = false;
            b2.Click += b2_Click;
            // 
            // b1
            // 
            b1.BackColor = SystemColors.GradientInactiveCaption;
            b1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b1.Location = new Point(31, 238);
            b1.Name = "b1";
            b1.Size = new Size(40, 64);
            b1.TabIndex = 18;
            b1.Text = "1";
            b1.UseVisualStyleBackColor = false;
            b1.Click += b1_Click;
            // 
            // b0
            // 
            b0.BackColor = SystemColors.ActiveCaption;
            b0.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            b0.Location = new Point(31, 308);
            b0.Name = "b0";
            b0.Size = new Size(86, 64);
            b0.TabIndex = 24;
            b0.Text = "0";
            b0.UseVisualStyleBackColor = false;
            b0.Click += b0_Click;
            // 
            // bpunto
            // 
            bpunto.BackColor = SystemColors.GradientInactiveCaption;
            bpunto.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bpunto.Location = new Point(123, 308);
            bpunto.Name = "bpunto";
            bpunto.Size = new Size(40, 64);
            bpunto.TabIndex = 25;
            bpunto.Text = ".";
            bpunto.UseVisualStyleBackColor = false;
            bpunto.Click += bpunto_Click;
            // 
            // bigual
            // 
            bigual.BackColor = SystemColors.GradientInactiveCaption;
            bigual.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigual.Location = new Point(169, 308);
            bigual.Name = "bigual";
            bigual.Size = new Size(204, 64);
            bigual.TabIndex = 26;
            bigual.Text = "=";
            bigual.UseVisualStyleBackColor = false;
            bigual.Click += bigual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(389, 384);
            Controls.Add(bigual);
            Controls.Add(bpunto);
            Controls.Add(b0);
            Controls.Add(bcomilla);
            Controls.Add(bmenos);
            Controls.Add(bmas);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(bclear);
            Controls.Add(bslash);
            Controls.Add(basterisco);
            Controls.Add(b6);
            Controls.Add(b5);
            Controls.Add(b4);
            Controls.Add(bdelete);
            Controls.Add(bparentesiscerrar);
            Controls.Add(bparentesisabrir);
            Controls.Add(b9);
            Controls.Add(b8);
            Controls.Add(b7);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button b7;
        private Button b8;
        private Button b9;
        private Button bparentesisabrir;
        private Button bparentesiscerrar;
        private Button bdelete;
        private Button bclear;
        private Button bslash;
        private Button basterisco;
        private Button b6;
        private Button b5;
        private Button b4;
        private Button bcomilla;
        private Button bmenos;
        private Button bmas;
        private Button b3;
        private Button b2;
        private Button b1;
        private Button b0;
        private Button bpunto;
        private Button bigual;
    }
}
