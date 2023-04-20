namespace I03._A_contar_palabras
{
    partial class Vista
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
            this.rtb_Mensaje = new System.Windows.Forms.RichTextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Enunciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_Mensaje
            // 
            this.rtb_Mensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtb_Mensaje.Location = new System.Drawing.Point(12, 12);
            this.rtb_Mensaje.Name = "rtb_Mensaje";
            this.rtb_Mensaje.Size = new System.Drawing.Size(333, 269);
            this.rtb_Mensaje.TabIndex = 0;
            this.rtb_Mensaje.Text = "";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Calcular.Location = new System.Drawing.Point(241, 306);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(104, 37);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Enunciar
            // 
            this.btn_Enunciar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Enunciar.Location = new System.Drawing.Point(12, 306);
            this.btn_Enunciar.Name = "btn_Enunciar";
            this.btn_Enunciar.Size = new System.Drawing.Size(127, 37);
            this.btn_Enunciar.TabIndex = 2;
            this.btn_Enunciar.Text = "Enunciar palabras";
            this.btn_Enunciar.UseVisualStyleBackColor = true;
            this.btn_Enunciar.Click += new System.EventHandler(this.btn_Enunciar_Click);
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 355);
            this.Controls.Add(this.btn_Enunciar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rtb_Mensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contador de palabras";
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox rtb_Mensaje;
        private Button btn_Calcular;
        private Button btn_Enunciar;
    }
}