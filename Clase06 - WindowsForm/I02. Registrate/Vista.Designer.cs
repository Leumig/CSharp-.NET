namespace I02._Registrate
{
    partial class Vista
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
            this.gbo_Detalles = new System.Windows.Forms.GroupBox();
            this.num_Edad = new System.Windows.Forms.NumericUpDown();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.gbo_Cursos = new System.Windows.Forms.GroupBox();
            this.chk_TercerCurso = new System.Windows.Forms.CheckBox();
            this.chk_SegundoCurso = new System.Windows.Forms.CheckBox();
            this.chk_PrimerCurso = new System.Windows.Forms.CheckBox();
            this.gbo_Genero = new System.Windows.Forms.GroupBox();
            this.rad_NoBinario = new System.Windows.Forms.RadioButton();
            this.rad_Femenino = new System.Windows.Forms.RadioButton();
            this.rad_Masculino = new System.Windows.Forms.RadioButton();
            this.lbl_Pais = new System.Windows.Forms.Label();
            this.lst_Pais = new System.Windows.Forms.ListBox();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.gbo_Detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Edad)).BeginInit();
            this.gbo_Cursos.SuspendLayout();
            this.gbo_Genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbo_Detalles
            // 
            this.gbo_Detalles.Controls.Add(this.num_Edad);
            this.gbo_Detalles.Controls.Add(this.txt_Direccion);
            this.gbo_Detalles.Controls.Add(this.txt_Nombre);
            this.gbo_Detalles.Controls.Add(this.lbl_Edad);
            this.gbo_Detalles.Controls.Add(this.lbl_Direccion);
            this.gbo_Detalles.Controls.Add(this.lbl_Nombre);
            this.gbo_Detalles.Location = new System.Drawing.Point(12, 12);
            this.gbo_Detalles.Name = "gbo_Detalles";
            this.gbo_Detalles.Size = new System.Drawing.Size(261, 134);
            this.gbo_Detalles.TabIndex = 0;
            this.gbo_Detalles.TabStop = false;
            this.gbo_Detalles.Text = "Detalles del usuario";
            // 
            // num_Edad
            // 
            this.num_Edad.Location = new System.Drawing.Point(76, 95);
            this.num_Edad.Name = "num_Edad";
            this.num_Edad.Size = new System.Drawing.Size(94, 23);
            this.num_Edad.TabIndex = 5;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(76, 60);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(159, 23);
            this.txt_Direccion.TabIndex = 4;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(76, 31);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(159, 23);
            this.txt_Nombre.TabIndex = 3;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(6, 97);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_Edad.TabIndex = 2;
            this.lbl_Edad.Text = "Edad";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(6, 64);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_Direccion.TabIndex = 1;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(6, 31);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // gbo_Cursos
            // 
            this.gbo_Cursos.Controls.Add(this.chk_TercerCurso);
            this.gbo_Cursos.Controls.Add(this.chk_SegundoCurso);
            this.gbo_Cursos.Controls.Add(this.chk_PrimerCurso);
            this.gbo_Cursos.Location = new System.Drawing.Point(312, 130);
            this.gbo_Cursos.Name = "gbo_Cursos";
            this.gbo_Cursos.Size = new System.Drawing.Size(125, 101);
            this.gbo_Cursos.TabIndex = 1;
            this.gbo_Cursos.TabStop = false;
            this.gbo_Cursos.Text = "Cursos";
            // 
            // chk_TercerCurso
            // 
            this.chk_TercerCurso.AutoSize = true;
            this.chk_TercerCurso.Location = new System.Drawing.Point(6, 72);
            this.chk_TercerCurso.Name = "chk_TercerCurso";
            this.chk_TercerCurso.Size = new System.Drawing.Size(78, 19);
            this.chk_TercerCurso.TabIndex = 2;
            this.chk_TercerCurso.Text = "JavaScript";
            this.chk_TercerCurso.UseVisualStyleBackColor = true;
            // 
            // chk_SegundoCurso
            // 
            this.chk_SegundoCurso.AutoSize = true;
            this.chk_SegundoCurso.Location = new System.Drawing.Point(6, 47);
            this.chk_SegundoCurso.Name = "chk_SegundoCurso";
            this.chk_SegundoCurso.Size = new System.Drawing.Size(50, 19);
            this.chk_SegundoCurso.TabIndex = 1;
            this.chk_SegundoCurso.Text = "C++";
            this.chk_SegundoCurso.UseVisualStyleBackColor = true;
            // 
            // chk_PrimerCurso
            // 
            this.chk_PrimerCurso.AutoSize = true;
            this.chk_PrimerCurso.Location = new System.Drawing.Point(6, 22);
            this.chk_PrimerCurso.Name = "chk_PrimerCurso";
            this.chk_PrimerCurso.Size = new System.Drawing.Size(41, 19);
            this.chk_PrimerCurso.TabIndex = 0;
            this.chk_PrimerCurso.Text = "C#";
            this.chk_PrimerCurso.UseVisualStyleBackColor = true;
            // 
            // gbo_Genero
            // 
            this.gbo_Genero.Controls.Add(this.rad_NoBinario);
            this.gbo_Genero.Controls.Add(this.rad_Femenino);
            this.gbo_Genero.Controls.Add(this.rad_Masculino);
            this.gbo_Genero.Location = new System.Drawing.Point(312, 12);
            this.gbo_Genero.Name = "gbo_Genero";
            this.gbo_Genero.Size = new System.Drawing.Size(125, 112);
            this.gbo_Genero.TabIndex = 2;
            this.gbo_Genero.TabStop = false;
            this.gbo_Genero.Text = "Género";
            // 
            // rad_NoBinario
            // 
            this.rad_NoBinario.AutoSize = true;
            this.rad_NoBinario.Location = new System.Drawing.Point(6, 77);
            this.rad_NoBinario.Name = "rad_NoBinario";
            this.rad_NoBinario.Size = new System.Drawing.Size(81, 19);
            this.rad_NoBinario.TabIndex = 2;
            this.rad_NoBinario.TabStop = true;
            this.rad_NoBinario.Text = "No binario";
            this.rad_NoBinario.UseVisualStyleBackColor = true;
            // 
            // rad_Femenino
            // 
            this.rad_Femenino.AutoSize = true;
            this.rad_Femenino.Location = new System.Drawing.Point(6, 52);
            this.rad_Femenino.Name = "rad_Femenino";
            this.rad_Femenino.Size = new System.Drawing.Size(78, 19);
            this.rad_Femenino.TabIndex = 1;
            this.rad_Femenino.TabStop = true;
            this.rad_Femenino.Text = "Femenino";
            this.rad_Femenino.UseVisualStyleBackColor = true;
            // 
            // rad_Masculino
            // 
            this.rad_Masculino.AutoSize = true;
            this.rad_Masculino.Location = new System.Drawing.Point(6, 27);
            this.rad_Masculino.Name = "rad_Masculino";
            this.rad_Masculino.Size = new System.Drawing.Size(80, 19);
            this.rad_Masculino.TabIndex = 0;
            this.rad_Masculino.TabStop = true;
            this.rad_Masculino.Text = "Masculino";
            this.rad_Masculino.UseVisualStyleBackColor = true;
            // 
            // lbl_Pais
            // 
            this.lbl_Pais.AutoSize = true;
            this.lbl_Pais.Location = new System.Drawing.Point(12, 152);
            this.lbl_Pais.Name = "lbl_Pais";
            this.lbl_Pais.Size = new System.Drawing.Size(28, 15);
            this.lbl_Pais.TabIndex = 3;
            this.lbl_Pais.Text = "País";
            // 
            // lst_Pais
            // 
            this.lst_Pais.FormattingEnabled = true;
            this.lst_Pais.ItemHeight = 15;
            this.lst_Pais.Items.AddRange(new object[] {
            "Argentina",
            "Chile",
            "Uruguay"});
            this.lst_Pais.Location = new System.Drawing.Point(12, 170);
            this.lst_Pais.Name = "lst_Pais";
            this.lst_Pais.Size = new System.Drawing.Size(261, 109);
            this.lst_Pais.TabIndex = 4;
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Location = new System.Drawing.Point(312, 256);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(125, 23);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 291);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lst_Pais);
            this.Controls.Add(this.lbl_Pais);
            this.Controls.Add(this.gbo_Genero);
            this.Controls.Add(this.gbo_Cursos);
            this.Controls.Add(this.gbo_Detalles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Vista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista";
            this.gbo_Detalles.ResumeLayout(false);
            this.gbo_Detalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Edad)).EndInit();
            this.gbo_Cursos.ResumeLayout(false);
            this.gbo_Cursos.PerformLayout();
            this.gbo_Genero.ResumeLayout(false);
            this.gbo_Genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gbo_Detalles;
        private GroupBox gbo_Cursos;
        private GroupBox gbo_Genero;
        private Label lbl_Edad;
        private Label lbl_Direccion;
        private Label lbl_Nombre;
        private Label lbl_Pais;
        private TextBox txt_Direccion;
        private TextBox txt_Nombre;
        private NumericUpDown num_Edad;
        private CheckBox chk_TercerCurso;
        private CheckBox chk_SegundoCurso;
        private CheckBox chk_PrimerCurso;
        private RadioButton rad_NoBinario;
        private RadioButton rad_Femenino;
        private RadioButton rad_Masculino;
        private ListBox lst_Pais;
        private Button btn_Ingresar;
    }
}