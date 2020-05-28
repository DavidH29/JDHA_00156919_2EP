using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            this.btnUpdateAddres = new System.Windows.Forms.Button();
            this.btnSelectAddress = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnShowOrders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSingout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.BackColor = System.Drawing.Color.White;
            this.btnAddAddress.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddAddress.Location = new System.Drawing.Point(63, 220);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(92, 35);
            this.btnAddAddress.TabIndex = 2;
            this.btnAddAddress.Text = "Agregar";
            this.btnAddAddress.UseVisualStyleBackColor = false;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.BackColor = System.Drawing.Color.White;
            this.btnDeleteAddress.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteAddress.Location = new System.Drawing.Point(63, 284);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(92, 35);
            this.btnDeleteAddress.TabIndex = 3;
            this.btnDeleteAddress.Text = "Eliminar";
            this.btnDeleteAddress.UseVisualStyleBackColor = false;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // btnUpdateAddres
            // 
            this.btnUpdateAddres.BackColor = System.Drawing.Color.White;
            this.btnUpdateAddres.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUpdateAddres.Location = new System.Drawing.Point(63, 347);
            this.btnUpdateAddres.Name = "btnUpdateAddres";
            this.btnUpdateAddres.Size = new System.Drawing.Size(92, 35);
            this.btnUpdateAddres.TabIndex = 4;
            this.btnUpdateAddres.Text = "Modificar";
            this.btnUpdateAddres.UseVisualStyleBackColor = false;
            this.btnUpdateAddres.Click += new System.EventHandler(this.btnUpdateAddres_Click);
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.BackColor = System.Drawing.Color.White;
            this.btnSelectAddress.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSelectAddress.Location = new System.Drawing.Point(63, 408);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(92, 35);
            this.btnSelectAddress.TabIndex = 5;
            this.btnSelectAddress.Text = "Mis direcciones";
            this.btnSelectAddress.UseVisualStyleBackColor = false;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.White;
            this.btnAddOrder.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddOrder.Location = new System.Drawing.Point(214, 220);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(92, 35);
            this.btnAddOrder.TabIndex = 6;
            this.btnAddOrder.Text = "Agregar";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(214, 284);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(92, 35);
            this.btnDeleteOrder.TabIndex = 7;
            this.btnDeleteOrder.Text = "Eliminar";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnShowOrders
            // 
            this.btnShowOrders.BackColor = System.Drawing.Color.White;
            this.btnShowOrders.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnShowOrders.Location = new System.Drawing.Point(214, 347);
            this.btnShowOrders.Name = "btnShowOrders";
            this.btnShowOrders.Size = new System.Drawing.Size(92, 35);
            this.btnShowOrders.TabIndex = 8;
            this.btnShowOrders.Text = "Ver";
            this.btnShowOrders.UseVisualStyleBackColor = false;
            this.btnShowOrders.Click += new System.EventHandler(this.btnShowOrders_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 45);
            this.label1.TabIndex = 13;
            this.label1.Text = "Direcciones";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 45);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ordenes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Impact", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button8.Location = new System.Drawing.Point(361, 220);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 35);
            this.button8.TabIndex = 15;
            this.button8.Text = "Cambiar password";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnSingout
            // 
            this.btnSingout.BackColor = System.Drawing.Color.White;
            this.btnSingout.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSingout.Location = new System.Drawing.Point(361, 284);
            this.btnSingout.Name = "btnSingout";
            this.btnSingout.Size = new System.Drawing.Size(92, 35);
            this.btnSingout.TabIndex = 16;
            this.btnSingout.Text = "Cerrar sesion";
            this.btnSingout.UseVisualStyleBackColor = false;
            this.btnSingout.Click += new System.EventHandler(this.btnSingout_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(345, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 45);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cuenta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(527, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSingout);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowOrders);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnSelectAddress);
            this.Controls.Add(this.btnUpdateAddres);
            this.Controls.Add(this.btnDeleteAddress);
            this.Controls.Add(this.btnAddAddress);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hugo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCustomer_FormClosed);
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnAddAddress;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnSelectAddress;
        private System.Windows.Forms.Button btnShowOrders;
        private System.Windows.Forms.Button btnSingout;
        private System.Windows.Forms.Button btnUpdateAddres;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}