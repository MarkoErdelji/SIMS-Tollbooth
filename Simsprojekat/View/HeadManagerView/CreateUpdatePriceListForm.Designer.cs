
namespace Simsprojekat.View.HeadManagerView
{
    partial class CreateUpdatePriceListForm
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
            this.lblEuroBase = new System.Windows.Forms.Label();
            this.lblDinarBase = new System.Windows.Forms.Label();
            this.lblCarCoef = new System.Windows.Forms.Label();
            this.lblTruckCoef = new System.Windows.Forms.Label();
            this.lblOtherCoef = new System.Windows.Forms.Label();
            this.lblBikeCoef = new System.Windows.Forms.Label();
            this.lblBusCoef = new System.Windows.Forms.Label();
            this.txbEuro = new System.Windows.Forms.TextBox();
            this.txbDinar = new System.Windows.Forms.TextBox();
            this.txbCar = new System.Windows.Forms.TextBox();
            this.txbTruck = new System.Windows.Forms.TextBox();
            this.txbOther = new System.Windows.Forms.TextBox();
            this.txbBike = new System.Windows.Forms.TextBox();
            this.txbBus = new System.Windows.Forms.TextBox();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEuroBase
            // 
            this.lblEuroBase.AutoSize = true;
            this.lblEuroBase.Location = new System.Drawing.Point(246, 15);
            this.lblEuroBase.Name = "lblEuroBase";
            this.lblEuroBase.Size = new System.Drawing.Size(114, 20);
            this.lblEuroBase.TabIndex = 0;
            this.lblEuroBase.Text = "Base price euro:";
            // 
            // lblDinarBase
            // 
            this.lblDinarBase.AutoSize = true;
            this.lblDinarBase.Location = new System.Drawing.Point(246, 68);
            this.lblDinarBase.Name = "lblDinarBase";
            this.lblDinarBase.Size = new System.Drawing.Size(122, 20);
            this.lblDinarBase.TabIndex = 1;
            this.lblDinarBase.Text = "Base price dinar: ";
            // 
            // lblCarCoef
            // 
            this.lblCarCoef.AutoSize = true;
            this.lblCarCoef.Location = new System.Drawing.Point(246, 116);
            this.lblCarCoef.Name = "lblCarCoef";
            this.lblCarCoef.Size = new System.Drawing.Size(103, 20);
            this.lblCarCoef.TabIndex = 2;
            this.lblCarCoef.Text = "Car coeficient:";
            // 
            // lblTruckCoef
            // 
            this.lblTruckCoef.AutoSize = true;
            this.lblTruckCoef.Location = new System.Drawing.Point(246, 164);
            this.lblTruckCoef.Name = "lblTruckCoef";
            this.lblTruckCoef.Size = new System.Drawing.Size(119, 20);
            this.lblTruckCoef.TabIndex = 3;
            this.lblTruckCoef.Text = "Truck coeficient: ";
            // 
            // lblOtherCoef
            // 
            this.lblOtherCoef.AutoSize = true;
            this.lblOtherCoef.Location = new System.Drawing.Point(246, 206);
            this.lblOtherCoef.Name = "lblOtherCoef";
            this.lblOtherCoef.Size = new System.Drawing.Size(122, 20);
            this.lblOtherCoef.TabIndex = 4;
            this.lblOtherCoef.Text = "Other coeficient: ";
            // 
            // lblBikeCoef
            // 
            this.lblBikeCoef.AutoSize = true;
            this.lblBikeCoef.Location = new System.Drawing.Point(246, 258);
            this.lblBikeCoef.Name = "lblBikeCoef";
            this.lblBikeCoef.Size = new System.Drawing.Size(109, 20);
            this.lblBikeCoef.TabIndex = 5;
            this.lblBikeCoef.Text = "Bike coeficient:";
            // 
            // lblBusCoef
            // 
            this.lblBusCoef.AutoSize = true;
            this.lblBusCoef.Location = new System.Drawing.Point(246, 308);
            this.lblBusCoef.Name = "lblBusCoef";
            this.lblBusCoef.Size = new System.Drawing.Size(108, 20);
            this.lblBusCoef.TabIndex = 6;
            this.lblBusCoef.Text = "Bus coeficient: ";
            // 
            // txbEuro
            // 
            this.txbEuro.Location = new System.Drawing.Point(376, 12);
            this.txbEuro.Name = "txbEuro";
            this.txbEuro.Size = new System.Drawing.Size(125, 27);
            this.txbEuro.TabIndex = 7;
            this.txbEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEuro_KeyPress);
            // 
            // txbDinar
            // 
            this.txbDinar.Location = new System.Drawing.Point(376, 61);
            this.txbDinar.Name = "txbDinar";
            this.txbDinar.Size = new System.Drawing.Size(125, 27);
            this.txbDinar.TabIndex = 8;
            this.txbDinar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDinar_KeyPress);
            // 
            // txbCar
            // 
            this.txbCar.Location = new System.Drawing.Point(376, 109);
            this.txbCar.Name = "txbCar";
            this.txbCar.Size = new System.Drawing.Size(125, 27);
            this.txbCar.TabIndex = 9;
            this.txbCar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCar_KeyPress);
            // 
            // txbTruck
            // 
            this.txbTruck.Location = new System.Drawing.Point(376, 157);
            this.txbTruck.Name = "txbTruck";
            this.txbTruck.Size = new System.Drawing.Size(125, 27);
            this.txbTruck.TabIndex = 10;
            this.txbTruck.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTruck_KeyPress);
            // 
            // txbOther
            // 
            this.txbOther.Location = new System.Drawing.Point(376, 199);
            this.txbOther.Name = "txbOther";
            this.txbOther.Size = new System.Drawing.Size(125, 27);
            this.txbOther.TabIndex = 11;
            this.txbOther.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbOther_KeyPress);
            // 
            // txbBike
            // 
            this.txbBike.Location = new System.Drawing.Point(376, 251);
            this.txbBike.Name = "txbBike";
            this.txbBike.Size = new System.Drawing.Size(125, 27);
            this.txbBike.TabIndex = 12;
            this.txbBike.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBike_KeyPress);
            // 
            // txbBus
            // 
            this.txbBus.Location = new System.Drawing.Point(376, 301);
            this.txbBus.Name = "txbBus";
            this.txbBus.Size = new System.Drawing.Size(125, 27);
            this.txbBus.TabIndex = 13;
            this.txbBus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbBus_KeyPress);
            // 
            // btnFinish
            // 
            this.btnFinish.Location = new System.Drawing.Point(313, 397);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(131, 41);
            this.btnFinish.TabIndex = 14;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // CreateUpdatePriceListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.txbBus);
            this.Controls.Add(this.txbBike);
            this.Controls.Add(this.txbOther);
            this.Controls.Add(this.txbTruck);
            this.Controls.Add(this.txbCar);
            this.Controls.Add(this.txbDinar);
            this.Controls.Add(this.txbEuro);
            this.Controls.Add(this.lblBusCoef);
            this.Controls.Add(this.lblBikeCoef);
            this.Controls.Add(this.lblOtherCoef);
            this.Controls.Add(this.lblTruckCoef);
            this.Controls.Add(this.lblCarCoef);
            this.Controls.Add(this.lblDinarBase);
            this.Controls.Add(this.lblEuroBase);
            this.Name = "CreateUpdatePriceListForm";
            this.Text = "CreateUpdatePriceListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuroBase;
        private System.Windows.Forms.Label lblDinarBase;
        private System.Windows.Forms.Label lblCarCoef;
        private System.Windows.Forms.Label lblTruckCoef;
        private System.Windows.Forms.Label lblOtherCoef;
        private System.Windows.Forms.Label lblBikeCoef;
        private System.Windows.Forms.Label lblBusCoef;
        private System.Windows.Forms.TextBox txbEuro;
        private System.Windows.Forms.TextBox txbDinar;
        private System.Windows.Forms.TextBox txbCar;
        private System.Windows.Forms.TextBox txbTruck;
        private System.Windows.Forms.TextBox txbOther;
        private System.Windows.Forms.TextBox txbBike;
        private System.Windows.Forms.TextBox txbBus;
        private System.Windows.Forms.Button btnFinish;
    }
}