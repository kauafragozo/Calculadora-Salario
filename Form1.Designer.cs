namespace CalculadoraSalário
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
            label1 = new Label();
            SalarioHoraLabel = new Label();
            HELabel = new Label();
            label4 = new Label();
            DescontosLabel = new Label();
            CalcularButton = new Button();
            SalarioMTextBox = new MaskedTextBox();
            DescontosMTextBox = new MaskedTextBox();
            HorasExtrasMTextBox = new MaskedTextBox();
            HorasTrabMTextBox = new MaskedTextBox();
            label2 = new Label();
            ResultadoTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Impact", 16F);
            label1.Location = new Point(-1, 9);
            label1.Name = "label1";
            label1.Size = new Size(546, 54);
            label1.TabIndex = 0;
            label1.Text = "Calculadora Salário";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // SalarioHoraLabel
            // 
            SalarioHoraLabel.AutoSize = true;
            SalarioHoraLabel.Location = new Point(12, 72);
            SalarioHoraLabel.Name = "SalarioHoraLabel";
            SalarioHoraLabel.Size = new Size(74, 15);
            SalarioHoraLabel.TabIndex = 1;
            SalarioHoraLabel.Text = "Salário Hora:";
            // 
            // HELabel
            // 
            HELabel.AutoSize = true;
            HELabel.Location = new Point(12, 125);
            HELabel.Name = "HELabel";
            HELabel.Size = new Size(75, 15);
            HELabel.TabIndex = 2;
            HELabel.Text = "Horas Extras:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 3;
            label4.Text = "Horas Trabalhadas:";
            // 
            // DescontosLabel
            // 
            DescontosLabel.AutoSize = true;
            DescontosLabel.Location = new Point(12, 219);
            DescontosLabel.Name = "DescontosLabel";
            DescontosLabel.Size = new Size(104, 15);
            DescontosLabel.TabIndex = 4;
            DescontosLabel.Text = "Outros Descontos:";
            // 
            // CalcularButton
            // 
            CalcularButton.Location = new Point(125, 269);
            CalcularButton.Name = "CalcularButton";
            CalcularButton.Size = new Size(75, 23);
            CalcularButton.TabIndex = 9;
            CalcularButton.Text = "Calcular";
            CalcularButton.UseVisualStyleBackColor = true;
            CalcularButton.Click += CalcularButton_Click;
            // 
            // SalarioMTextBox
            // 
            SalarioMTextBox.Location = new Point(125, 69);
            SalarioMTextBox.Mask = "99,99";
            SalarioMTextBox.Name = "SalarioMTextBox";
            SalarioMTextBox.Size = new Size(180, 23);
            SalarioMTextBox.TabIndex = 10;
            // 
            // DescontosMTextBox
            // 
            DescontosMTextBox.Location = new Point(125, 216);
            DescontosMTextBox.Mask = "999,99";
            DescontosMTextBox.Name = "DescontosMTextBox";
            DescontosMTextBox.Size = new Size(180, 23);
            DescontosMTextBox.TabIndex = 11;
            // 
            // HorasExtrasMTextBox
            // 
            HorasExtrasMTextBox.Location = new Point(125, 117);
            HorasExtrasMTextBox.Mask = "000";
            HorasExtrasMTextBox.Name = "HorasExtrasMTextBox";
            HorasExtrasMTextBox.Size = new Size(180, 23);
            HorasExtrasMTextBox.TabIndex = 12;
            // 
            // HorasTrabMTextBox
            // 
            HorasTrabMTextBox.Location = new Point(125, 170);
            HorasTrabMTextBox.Mask = "999";
            HorasTrabMTextBox.Name = "HorasTrabMTextBox";
            HorasTrabMTextBox.Size = new Size(180, 23);
            HorasTrabMTextBox.TabIndex = 13;
            // 
            // label2
            // 
            label2.Location = new Point(12, 346);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 14;
            label2.Text = "Resultado:";
            // 
            // ResultadoTextBox
            // 
            ResultadoTextBox.Location = new Point(105, 343);
            ResultadoTextBox.Name = "ResultadoTextBox";
            ResultadoTextBox.ReadOnly = true;
            ResultadoTextBox.Size = new Size(242, 23);
            ResultadoTextBox.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 511);
            Controls.Add(ResultadoTextBox);
            Controls.Add(label2);
            Controls.Add(HorasTrabMTextBox);
            Controls.Add(HorasExtrasMTextBox);
            Controls.Add(DescontosMTextBox);
            Controls.Add(SalarioMTextBox);
            Controls.Add(CalcularButton);
            Controls.Add(DescontosLabel);
            Controls.Add(label4);
            Controls.Add(HELabel);
            Controls.Add(SalarioHoraLabel);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora Salário";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label SalarioHoraLabel;
        private Label HELabel;
        private Label label4;
        private Label DescontosLabel;
        private TextBox SalarioTextBox;
        private TextBox DescontosTextBox;
        private Button CalcularButton;
        private MaskedTextBox SalarioMTextBox;
        private MaskedTextBox DescontosMTextBox;
        private MaskedTextBox HorasExtrasMTextBox;
        private MaskedTextBox HorasTrabMTextBox;
        private Label label2;
        private TextBox ResultadoTextBox;
    }
}
