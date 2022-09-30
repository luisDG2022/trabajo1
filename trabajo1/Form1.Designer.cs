namespace trabajo1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtNombre2 = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "primer nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(723, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "segundo nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "segundo apellido";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(1153, 422);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(188, 58);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "button1";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "primer apellido";
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(340, 101);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(250, 47);
            this.txtNombre1.TabIndex = 5;
            this.txtNombre1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre1_KeyPress);
            this.txtNombre1.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre1_Validating);
            this.txtNombre1.Validated += new System.EventHandler(this.txtNombre1_Validated);
            // 
            // txtNombre2
            // 
            this.txtNombre2.Location = new System.Drawing.Point(1008, 93);
            this.txtNombre2.Name = "txtNombre2";
            this.txtNombre2.Size = new System.Drawing.Size(250, 47);
            this.txtNombre2.TabIndex = 6;
            this.txtNombre2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre2_KeyPress);
            this.txtNombre2.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre2_Validating);
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.Location = new System.Drawing.Point(340, 222);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(250, 47);
            this.txtApellidoP.TabIndex = 7;
            this.txtApellidoP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoP_KeyPress);
            this.txtApellidoP.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre1_Validating);
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(1008, 222);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(250, 47);
            this.txtApellido2.TabIndex = 8;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre2_KeyPress);
            this.txtApellido2.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellido2_Validating);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(48, 528);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(1265, 375);
            this.dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PRIMER NOMBRE";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SEGUNDO NOMBRE";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "APELLIDO P.";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            this.Column3.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "APELLIDO M.";
            this.Column4.MinimumWidth = 12;
            this.Column4.Name = "Column4";
            this.Column4.Width = 250;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 947);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1535, 54);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 41);
            this.toolStripStatusLabel1.Text = "err";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 1001);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtApellido2);
            this.Controls.Add(this.txtApellidoP);
            this.Controls.Add(this.txtNombre2);
            this.Controls.Add(this.txtNombre1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnIngresar;
        private Label label4;
        private TextBox txtNombre1;
        private TextBox txtNombre2;
        private TextBox txtApellidoP;
        private TextBox txtApellido2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private NotifyIcon notifyIcon1;
        private ToolTip toolTip1;
    }
}