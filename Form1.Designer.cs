namespace PR6_DOBLE
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnColorVerView = new System.Windows.Forms.Button();
            this.btnColorLigaView = new System.Windows.Forms.Button();
            this.btnColorVerificar = new System.Windows.Forms.Button();
            this.btnColorLiga = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnInvertirNodos = new System.Windows.Forms.Button();
            this.BtnDesplegar = new System.Windows.Forms.Button();
            this.btnInserD = new System.Windows.Forms.Button();
            this.BtnDesplegarInv = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnOrdenar = new System.Windows.Forms.Button();
            this.btnInsertarA = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cuadernito = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnColorVerView);
            this.panel1.Controls.Add(this.btnColorLigaView);
            this.panel1.Controls.Add(this.btnColorVerificar);
            this.panel1.Controls.Add(this.btnColorLiga);
            this.panel1.Location = new System.Drawing.Point(12, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 168);
            this.panel1.TabIndex = 0;
            // 
            // BtnColorVerView
            // 
            this.BtnColorVerView.BackColor = System.Drawing.Color.Transparent;
            this.BtnColorVerView.FlatAppearance.BorderSize = 0;
            this.BtnColorVerView.Location = new System.Drawing.Point(269, 88);
            this.BtnColorVerView.Margin = new System.Windows.Forms.Padding(4);
            this.BtnColorVerView.Name = "BtnColorVerView";
            this.BtnColorVerView.Size = new System.Drawing.Size(40, 27);
            this.BtnColorVerView.TabIndex = 12;
            this.BtnColorVerView.UseVisualStyleBackColor = false;
            // 
            // btnColorLigaView
            // 
            this.btnColorLigaView.BackColor = System.Drawing.Color.Transparent;
            this.btnColorLigaView.FlatAppearance.BorderSize = 0;
            this.btnColorLigaView.Location = new System.Drawing.Point(269, 38);
            this.btnColorLigaView.Margin = new System.Windows.Forms.Padding(4);
            this.btnColorLigaView.Name = "btnColorLigaView";
            this.btnColorLigaView.Size = new System.Drawing.Size(40, 27);
            this.btnColorLigaView.TabIndex = 11;
            this.btnColorLigaView.UseVisualStyleBackColor = false;
            // 
            // btnColorVerificar
            // 
            this.btnColorVerificar.Location = new System.Drawing.Point(27, 89);
            this.btnColorVerificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnColorVerificar.Name = "btnColorVerificar";
            this.btnColorVerificar.Size = new System.Drawing.Size(233, 30);
            this.btnColorVerificar.TabIndex = 1;
            this.btnColorVerificar.Text = "Cambiar color de Verificacion";
            this.btnColorVerificar.UseVisualStyleBackColor = true;
            this.btnColorVerificar.Click += new System.EventHandler(this.btnColorVerificar_Click);
            // 
            // btnColorLiga
            // 
            this.btnColorLiga.Location = new System.Drawing.Point(27, 39);
            this.btnColorLiga.Margin = new System.Windows.Forms.Padding(4);
            this.btnColorLiga.Name = "btnColorLiga";
            this.btnColorLiga.Size = new System.Drawing.Size(233, 30);
            this.btnColorLiga.TabIndex = 0;
            this.btnColorLiga.Text = "Cambiar Color Liga";
            this.btnColorLiga.UseVisualStyleBackColor = true;
            this.btnColorLiga.Click += new System.EventHandler(this.btnColorLiga_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Location = new System.Drawing.Point(363, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 168);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dato a buscar:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(153, 46);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(160, 24);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dato a Insertar:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(153, 97);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(160, 24);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.BtnInvertirNodos);
            this.panel3.Controls.Add(this.BtnDesplegar);
            this.panel3.Controls.Add(this.btnInserD);
            this.panel3.Controls.Add(this.BtnDesplegarInv);
            this.panel3.Controls.Add(this.BtnEliminar);
            this.panel3.Controls.Add(this.BtnOrdenar);
            this.panel3.Controls.Add(this.btnInsertarA);
            this.panel3.Controls.Add(this.BtnAgregar);
            this.panel3.Location = new System.Drawing.Point(715, 16);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 168);
            this.panel3.TabIndex = 13;
            // 
            // BtnInvertirNodos
            // 
            this.BtnInvertirNodos.Location = new System.Drawing.Point(273, 88);
            this.BtnInvertirNodos.Margin = new System.Windows.Forms.Padding(4);
            this.BtnInvertirNodos.Name = "BtnInvertirNodos";
            this.BtnInvertirNodos.Size = new System.Drawing.Size(137, 58);
            this.BtnInvertirNodos.TabIndex = 18;
            this.BtnInvertirNodos.Text = "Invertir Mov Nodos";
            this.BtnInvertirNodos.UseVisualStyleBackColor = true;
            // 
            // BtnDesplegar
            // 
            this.BtnDesplegar.Location = new System.Drawing.Point(165, 88);
            this.BtnDesplegar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDesplegar.Name = "BtnDesplegar";
            this.BtnDesplegar.Size = new System.Drawing.Size(100, 58);
            this.BtnDesplegar.TabIndex = 17;
            this.BtnDesplegar.Text = "Desplegar";
            this.BtnDesplegar.UseVisualStyleBackColor = true;
            this.BtnDesplegar.Click += new System.EventHandler(this.BtnDesplegar_Click);
            // 
            // btnInserD
            // 
            this.btnInserD.Location = new System.Drawing.Point(20, 88);
            this.btnInserD.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserD.Name = "btnInserD";
            this.btnInserD.Size = new System.Drawing.Size(137, 58);
            this.btnInserD.TabIndex = 15;
            this.btnInserD.Text = "Insertar Despues";
            this.btnInserD.UseVisualStyleBackColor = true;
            this.btnInserD.Click += new System.EventHandler(this.btnInserD_Click);
            // 
            // BtnDesplegarInv
            // 
            this.BtnDesplegarInv.Location = new System.Drawing.Point(128, 16);
            this.BtnDesplegarInv.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDesplegarInv.Name = "BtnDesplegarInv";
            this.BtnDesplegarInv.Size = new System.Drawing.Size(100, 58);
            this.BtnDesplegarInv.TabIndex = 16;
            this.BtnDesplegarInv.Text = "Desplegar Invertido";
            this.BtnDesplegarInv.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(418, 88);
            this.BtnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 58);
            this.BtnEliminar.TabIndex = 14;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnOrdenar
            // 
            this.BtnOrdenar.Location = new System.Drawing.Point(381, 16);
            this.BtnOrdenar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnOrdenar.Name = "BtnOrdenar";
            this.BtnOrdenar.Size = new System.Drawing.Size(100, 58);
            this.BtnOrdenar.TabIndex = 13;
            this.BtnOrdenar.Text = "Ordenar";
            this.BtnOrdenar.UseVisualStyleBackColor = true;
            // 
            // btnInsertarA
            // 
            this.btnInsertarA.Location = new System.Drawing.Point(236, 16);
            this.btnInsertarA.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarA.Name = "btnInsertarA";
            this.btnInsertarA.Size = new System.Drawing.Size(137, 58);
            this.btnInsertarA.TabIndex = 12;
            this.btnInsertarA.Text = "Insertar antes de";
            this.btnInsertarA.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(20, 16);
            this.BtnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(100, 58);
            this.BtnAgregar.TabIndex = 11;
            this.BtnAgregar.Text = "Agregar (crear)";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Info;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1098, 208);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(149, 344);
            this.listBox1.TabIndex = 14;
            // 
            // cuadernito
            // 
            this.cuadernito.BackColor = System.Drawing.Color.SeaShell;
            this.cuadernito.Location = new System.Drawing.Point(12, 204);
            this.cuadernito.Name = "cuadernito";
            this.cuadernito.Size = new System.Drawing.Size(1078, 412);
            this.cuadernito.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1123, 558);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 58);
            this.button1.TabIndex = 19;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1266, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuadernito);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnColorVerificar;
        private System.Windows.Forms.Button btnColorLiga;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button BtnColorVerView;
        private System.Windows.Forms.Button btnColorLigaView;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnInvertirNodos;
        private System.Windows.Forms.Button BtnDesplegar;
        private System.Windows.Forms.Button btnInserD;
        private System.Windows.Forms.Button BtnDesplegarInv;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnOrdenar;
        private System.Windows.Forms.Button btnInsertarA;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.FlowLayoutPanel cuadernito;
        private System.Windows.Forms.Button button1;
    }
}

