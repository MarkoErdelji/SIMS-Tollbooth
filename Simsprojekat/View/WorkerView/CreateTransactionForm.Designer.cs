
namespace Simsprojekat.View.WorkerView
{
    partial class CreateTransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbGivenAmount = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblKusur = new System.Windows.Forms.Label();
            this.btnKusur = new System.Windows.Forms.Button();
            this.lblDobijenaSuma = new System.Windows.Forms.Label();
            this.rbEur = new System.Windows.Forms.RadioButton();
            this.rbDin = new System.Windows.Forms.RadioButton();
            this.btnPodigniRampu = new System.Windows.Forms.Button();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a transaction";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSpeed.Location = new System.Drawing.Point(39, 62);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(64, 25);
            this.lblSpeed.TabIndex = 2;
            this.lblSpeed.Text = "Speed";
            // 
            // tbGivenAmount
            // 
            this.tbGivenAmount.Location = new System.Drawing.Point(172, 247);
            this.tbGivenAmount.Name = "tbGivenAmount";
            this.tbGivenAmount.Size = new System.Drawing.Size(118, 23);
            this.tbGivenAmount.TabIndex = 3;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCena.Location = new System.Drawing.Point(194, 142);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(41, 20);
            this.lblCena.TabIndex = 4;
            this.lblCena.Text = "Price";
            this.lblCena.Visible = false;
            this.lblCena.Click += new System.EventHandler(this.lblCena_Click);
            // 
            // lblKusur
            // 
            this.lblKusur.AutoSize = true;
            this.lblKusur.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKusur.Location = new System.Drawing.Point(172, 341);
            this.lblKusur.Name = "lblKusur";
            this.lblKusur.Size = new System.Drawing.Size(63, 21);
            this.lblKusur.TabIndex = 5;
            this.lblKusur.Text = "Change";
            this.lblKusur.Visible = false;
            // 
            // btnKusur
            // 
            this.btnKusur.Location = new System.Drawing.Point(172, 296);
            this.btnKusur.Name = "btnKusur";
            this.btnKusur.Size = new System.Drawing.Size(118, 23);
            this.btnKusur.TabIndex = 6;
            this.btnKusur.Text = "Calculate change";
            this.btnKusur.UseVisualStyleBackColor = true;
            this.btnKusur.Click += new System.EventHandler(this.btnKusur_Click);
            // 
            // lblDobijenaSuma
            // 
            this.lblDobijenaSuma.AutoSize = true;
            this.lblDobijenaSuma.Location = new System.Drawing.Point(183, 213);
            this.lblDobijenaSuma.Name = "lblDobijenaSuma";
            this.lblDobijenaSuma.Size = new System.Drawing.Size(82, 15);
            this.lblDobijenaSuma.TabIndex = 7;
            this.lblDobijenaSuma.Text = "Given amount";
            // 
            // rbEur
            // 
            this.rbEur.AutoSize = true;
            this.rbEur.Checked = true;
            this.rbEur.Location = new System.Drawing.Point(172, 178);
            this.rbEur.Name = "rbEur";
            this.rbEur.Size = new System.Drawing.Size(42, 19);
            this.rbEur.TabIndex = 8;
            this.rbEur.TabStop = true;
            this.rbEur.Text = "Eur";
            this.rbEur.UseVisualStyleBackColor = true;
            this.rbEur.CheckedChanged += new System.EventHandler(this.rbEur_CheckedChanged);
            // 
            // rbDin
            // 
            this.rbDin.AutoSize = true;
            this.rbDin.Location = new System.Drawing.Point(247, 178);
            this.rbDin.Name = "rbDin";
            this.rbDin.Size = new System.Drawing.Size(43, 19);
            this.rbDin.TabIndex = 9;
            this.rbDin.Text = "Din";
            this.rbDin.UseVisualStyleBackColor = true;
            // 
            // btnPodigniRampu
            // 
            this.btnPodigniRampu.Location = new System.Drawing.Point(125, 405);
            this.btnPodigniRampu.Name = "btnPodigniRampu";
            this.btnPodigniRampu.Size = new System.Drawing.Size(244, 44);
            this.btnPodigniRampu.TabIndex = 10;
            this.btnPodigniRampu.Text = "Create the transaction and raise the ramp";
            this.btnPodigniRampu.UseVisualStyleBackColor = true;
            this.btnPodigniRampu.Click += new System.EventHandler(this.btnPodigniRampu_Click);
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVehicle.Location = new System.Drawing.Point(39, 97);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(95, 21);
            this.lblVehicle.TabIndex = 11;
            this.lblVehicle.Text = "Vehicle Type";
            // 
            // CreateTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 471);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.btnPodigniRampu);
            this.Controls.Add(this.rbDin);
            this.Controls.Add(this.rbEur);
            this.Controls.Add(this.lblDobijenaSuma);
            this.Controls.Add(this.btnKusur);
            this.Controls.Add(this.lblKusur);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.tbGivenAmount);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.label1);
            this.Name = "CreateTransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TextBox tbGivenAmount;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblKusur;
        private System.Windows.Forms.Button btnKusur;
        private System.Windows.Forms.Label lblDobijenaSuma;
        private System.Windows.Forms.RadioButton rbEur;
        private System.Windows.Forms.RadioButton rbDin;
        private System.Windows.Forms.Button btnPodigniRampu;
        private System.Windows.Forms.Label lblVehicle;
    }
}