using System.ComponentModel;

namespace Parcial_2_POO
{
    partial class frmDeleteOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeleteOrder));
            this.btnAddAddres = new System.Windows.Forms.Button();
            this.txtAddAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddAddres
            // 
            this.btnAddAddres.BackColor = System.Drawing.Color.White;
            this.btnAddAddres.Location = new System.Drawing.Point(148, 188);
            this.btnAddAddres.Name = "btnAddAddres";
            this.btnAddAddres.Size = new System.Drawing.Size(107, 41);
            this.btnAddAddres.TabIndex = 5;
            this.btnAddAddres.Text = "Eliminar";
            this.btnAddAddres.UseVisualStyleBackColor = false;
            this.btnAddAddres.Click += new System.EventHandler(this.btnAddAddres_Click);
            // 
            // txtAddAddress
            // 
            this.txtAddAddress.Location = new System.Drawing.Point(75, 139);
            this.txtAddAddress.Name = "txtAddAddress";
            this.txtAddAddress.Size = new System.Drawing.Size(265, 20);
            this.txtAddAddress.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(74, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero de factura de orden a eliminar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmDeleteOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(413, 306);
            this.Controls.Add(this.btnAddAddres);
            this.Controls.Add(this.txtAddAddress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDeleteOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrar orden";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnAddAddres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddAddress;

        #endregion
    }
}