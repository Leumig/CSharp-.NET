namespace PrimerFormulario
{
    partial class FormularioPersona
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Legajo = new System.Windows.Forms.Label();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.txb_Legajo = new System.Windows.Forms.TextBox();
            this.btn_Cargar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.cmb_Materia = new System.Windows.Forms.ComboBox();
            this.lbl_Materia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Nombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Nombre.Location = new System.Drawing.Point(29, 19);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Legajo
            // 
            this.lbl_Legajo.AutoSize = true;
            this.lbl_Legajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Legajo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Legajo.Location = new System.Drawing.Point(29, 79);
            this.lbl_Legajo.Name = "lbl_Legajo";
            this.lbl_Legajo.Size = new System.Drawing.Size(42, 15);
            this.lbl_Legajo.TabIndex = 1;
            this.lbl_Legajo.Text = "Legajo";
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(29, 37);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(147, 23);
            this.txb_Nombre.TabIndex = 2;
            // 
            // txb_Legajo
            // 
            this.txb_Legajo.Location = new System.Drawing.Point(29, 97);
            this.txb_Legajo.Name = "txb_Legajo";
            this.txb_Legajo.Size = new System.Drawing.Size(147, 23);
            this.txb_Legajo.TabIndex = 3;
            // 
            // btn_Cargar
            // 
            this.btn_Cargar.BackColor = System.Drawing.Color.Green;
            this.btn_Cargar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cargar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cargar.Location = new System.Drawing.Point(29, 192);
            this.btn_Cargar.Name = "btn_Cargar";
            this.btn_Cargar.Size = new System.Drawing.Size(96, 49);
            this.btn_Cargar.TabIndex = 4;
            this.btn_Cargar.Text = "Cargar";
            this.btn_Cargar.UseVisualStyleBackColor = false;
            this.btn_Cargar.Click += new System.EventHandler(this.btn_Cargar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Cancelar.Location = new System.Drawing.Point(131, 192);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(91, 49);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // cmb_Materia
            // 
            this.cmb_Materia.AutoCompleteCustomSource.AddRange(new string[] {
            "Laboratorio"});
            this.cmb_Materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Materia.FormattingEnabled = true;
            this.cmb_Materia.Items.AddRange(new object[] {
            "Programación",
            "Laboratorio",
            "Matemática",
            "SPD",
            "Estadística",
            "Inglés",
            "Investigación"});
            this.cmb_Materia.Location = new System.Drawing.Point(29, 150);
            this.cmb_Materia.Name = "cmb_Materia";
            this.cmb_Materia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmb_Materia.Size = new System.Drawing.Size(147, 23);
            this.cmb_Materia.TabIndex = 6;
            // 
            // lbl_Materia
            // 
            this.lbl_Materia.AutoSize = true;
            this.lbl_Materia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Materia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Materia.Location = new System.Drawing.Point(29, 132);
            this.lbl_Materia.Name = "lbl_Materia";
            this.lbl_Materia.Size = new System.Drawing.Size(47, 15);
            this.lbl_Materia.TabIndex = 7;
            this.lbl_Materia.Text = "Materia";
            // 
            // FormularioPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(43)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(251, 262);
            this.Controls.Add(this.lbl_Materia);
            this.Controls.Add(this.cmb_Materia);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Cargar);
            this.Controls.Add(this.txb_Legajo);
            this.Controls.Add(this.txb_Nombre);
            this.Controls.Add(this.lbl_Legajo);
            this.Controls.Add(this.lbl_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar datos";
            this.Load += new System.EventHandler(this.FormularioPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Nombre;
        private Label lbl_Legajo;
        private TextBox txb_Nombre;
        private TextBox txb_Legajo;
        private Button btn_Cargar;
        private Button btn_Cancelar;
        private ComboBox cmb_Materia;
        private Label lbl_Materia;
    }
}