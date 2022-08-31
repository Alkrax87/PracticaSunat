
namespace ClienteSunatCSharp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bttnBuscarNombre = new System.Windows.Forms.Button();
            this.bttnBuscarDNI = new System.Windows.Forms.Button();
            this.bttnBuscarRUC = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.bttnBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            this.bttnCerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.panel1.Controls.Add(this.bttnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criterios de la búsqueda";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 8;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bttnBuscarNombre);
            this.panel2.Controls.Add(this.bttnBuscarDNI);
            this.panel2.Controls.Add(this.bttnBuscarRUC);
            this.panel2.Location = new System.Drawing.Point(322, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 40);
            this.panel2.TabIndex = 2;
            // 
            // bttnBuscarNombre
            // 
            this.bttnBuscarNombre.BackColor = System.Drawing.Color.White;
            this.bttnBuscarNombre.Dock = System.Windows.Forms.DockStyle.Left;
            this.bttnBuscarNombre.Location = new System.Drawing.Point(240, 0);
            this.bttnBuscarNombre.Name = "bttnBuscarNombre";
            this.bttnBuscarNombre.Size = new System.Drawing.Size(120, 40);
            this.bttnBuscarNombre.TabIndex = 2;
            this.bttnBuscarNombre.Text = "Por Nomb,/Raz. Soc.";
            this.bttnBuscarNombre.UseVisualStyleBackColor = false;
            // 
            // bttnBuscarDNI
            // 
            this.bttnBuscarDNI.BackColor = System.Drawing.Color.White;
            this.bttnBuscarDNI.Dock = System.Windows.Forms.DockStyle.Left;
            this.bttnBuscarDNI.Location = new System.Drawing.Point(120, 0);
            this.bttnBuscarDNI.Name = "bttnBuscarDNI";
            this.bttnBuscarDNI.Size = new System.Drawing.Size(120, 40);
            this.bttnBuscarDNI.TabIndex = 1;
            this.bttnBuscarDNI.Text = "Por Documento";
            this.bttnBuscarDNI.UseVisualStyleBackColor = false;
            // 
            // bttnBuscarRUC
            // 
            this.bttnBuscarRUC.BackColor = System.Drawing.Color.White;
            this.bttnBuscarRUC.Dock = System.Windows.Forms.DockStyle.Left;
            this.bttnBuscarRUC.Location = new System.Drawing.Point(0, 0);
            this.bttnBuscarRUC.Name = "bttnBuscarRUC";
            this.bttnBuscarRUC.Size = new System.Drawing.Size(120, 40);
            this.bttnBuscarRUC.TabIndex = 0;
            this.bttnBuscarRUC.Text = "Por RUC";
            this.bttnBuscarRUC.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.White;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.Silver;
            this.txtBuscar.Location = new System.Drawing.Point(197, 144);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(611, 26);
            this.txtBuscar.TabIndex = 162;
            this.txtBuscar.Text = "Ingrese RUC";
            this.txtBuscar.Enter += new System.EventHandler(this.txtCodAlumno_Enter);
            this.txtBuscar.Leave += new System.EventHandler(this.txtCodAlumno_Leave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(182, 135);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(640, 43);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 161;
            this.pictureBox5.TabStop = false;
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bttnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bttnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnBuscar.BorderRadius = 7;
            this.bttnBuscar.ButtonText = "Buscar";
            this.bttnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.bttnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.bttnBuscar.Iconimage = ((System.Drawing.Image)(resources.GetObject("bttnBuscar.Iconimage")));
            this.bttnBuscar.Iconimage_right = null;
            this.bttnBuscar.Iconimage_right_Selected = null;
            this.bttnBuscar.Iconimage_Selected = null;
            this.bttnBuscar.IconMarginLeft = 0;
            this.bttnBuscar.IconMarginRight = 0;
            this.bttnBuscar.IconRightVisible = true;
            this.bttnBuscar.IconRightZoom = 0D;
            this.bttnBuscar.IconVisible = false;
            this.bttnBuscar.IconZoom = 90D;
            this.bttnBuscar.IsTab = false;
            this.bttnBuscar.Location = new System.Drawing.Point(459, 189);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bttnBuscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bttnBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.bttnBuscar.selected = false;
            this.bttnBuscar.Size = new System.Drawing.Size(80, 35);
            this.bttnBuscar.TabIndex = 163;
            this.bttnBuscar.Text = "Buscar";
            this.bttnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bttnBuscar.Textcolor = System.Drawing.Color.White;
            this.bttnBuscar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.Location = new System.Drawing.Point(394, 135);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.Size = new System.Drawing.Size(80, 35);
            this.dgvEmpresa.TabIndex = 164;
            // 
            // bttnCerrar
            // 
            this.bttnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("bttnCerrar.Image")));
            this.bttnCerrar.Location = new System.Drawing.Point(960, 7);
            this.bttnCerrar.Name = "bttnCerrar";
            this.bttnCerrar.Size = new System.Drawing.Size(33, 34);
            this.bttnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnCerrar.TabIndex = 172;
            this.bttnCerrar.TabStop = false;
            this.bttnCerrar.Click += new System.EventHandler(this.bttnCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 235);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bttnBuscarNombre;
        private System.Windows.Forms.Button bttnBuscarDNI;
        private System.Windows.Forms.Button bttnBuscarRUC;
        private Bunifu.Framework.UI.BunifuFlatButton bttnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView dgvEmpresa;
        private System.Windows.Forms.PictureBox bttnCerrar;
    }
}

