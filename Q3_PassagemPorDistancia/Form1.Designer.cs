namespace Q3_PassagemPorDistancia
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
            txtkm = new TextBox();
            Calcule = new Button();
            txtvalor = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 133);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "“Distância (km):";
            // 
            // txtkm
            // 
            txtkm.Location = new Point(251, 125);
            txtkm.Name = "txtkm";
            txtkm.Size = new Size(100, 23);
            txtkm.TabIndex = 1;
            // 
            // Calcule
            // 
            Calcule.Location = new Point(251, 261);
            Calcule.Name = "Calcule";
            Calcule.Size = new Size(75, 23);
            Calcule.TabIndex = 2;
            Calcule.Text = "Calcule ";
            Calcule.UseVisualStyleBackColor = true;
            Calcule.Click += Calcule_Click;
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(251, 186);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(100, 23);
            txtvalor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(185, 194);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 4;
            label2.Text = "Valor R$:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtvalor);
            Controls.Add(Calcule);
            Controls.Add(txtkm);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtkm;
        private Button Calcule;
        private TextBox txtvalor;
        private Label label2;
    }
}
