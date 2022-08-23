namespace TaskExercicio
{
    partial class frmCalculoValores
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
            this.ltbValor = new System.Windows.Forms.ListBox();
            this.lblValores = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblAguardar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ltbValor
            // 
            this.ltbValor.FormattingEnabled = true;
            this.ltbValor.ItemHeight = 15;
            this.ltbValor.Location = new System.Drawing.Point(156, 22);
            this.ltbValor.Name = "ltbValor";
            this.ltbValor.Size = new System.Drawing.Size(119, 64);
            this.ltbValor.TabIndex = 0;
            this.ltbValor.SelectedIndexChanged += new System.EventHandler(this.ltbValor_SelectedIndexChanged);
            // 
            // lblValores
            // 
            this.lblValores.AutoSize = true;
            this.lblValores.Location = new System.Drawing.Point(26, 22);
            this.lblValores.Name = "lblValores";
            this.lblValores.Size = new System.Drawing.Size(119, 60);
            this.lblValores.TabIndex = 1;
            this.lblValores.Text = "Folha de pagamento:\r\nImpostos:\r\nReceitas:\r\nDespesas:";
            this.lblValores.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(92, 92);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(128, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular valores";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblAguardar
            // 
            this.lblAguardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblAguardar.Location = new System.Drawing.Point(75, 118);
            this.lblAguardar.Name = "lblAguardar";
            this.lblAguardar.Size = new System.Drawing.Size(167, 47);
            this.lblAguardar.TabIndex = 3;
            this.lblAguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCalculoValores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 174);
            this.Controls.Add(this.lblAguardar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValores);
            this.Controls.Add(this.ltbValor);
            this.Name = "frmCalculoValores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Valores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox ltbValor;
        private Label lblValores;
        private Button btnCalcular;
        private Label lblAguardar;
    }
}