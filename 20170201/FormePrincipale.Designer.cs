namespace _20170201
{
    partial class frmPrincipale
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chtEcran = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clkMinuterie = new System.Windows.Forms.Timer(this.components);
            this.spc_config = new gei1076_tools.SerialPortConfigurator();
            this.btnStartCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chtEcran)).BeginInit();
            this.SuspendLayout();
            // 
            // chtEcran
            // 
            this.chtEcran.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chtEcran.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chtEcran.Legends.Add(legend2);
            this.chtEcran.Location = new System.Drawing.Point(12, 167);
            this.chtEcran.Name = "chtEcran";
            this.chtEcran.Size = new System.Drawing.Size(429, 299);
            this.chtEcran.TabIndex = 0;
            // 
            // clkMinuterie
            // 
            this.clkMinuterie.Interval = 20;
            this.clkMinuterie.Tick += new System.EventHandler(this.clkMinuterie_Tick);
            // 
            // spc_config
            // 
            this.spc_config.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spc_config.Location = new System.Drawing.Point(13, 13);
            this.spc_config.Name = "spc_config";
            this.spc_config.Size = new System.Drawing.Size(428, 114);
            this.spc_config.TabIndex = 1;
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.Location = new System.Drawing.Point(366, 133);
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(75, 23);
            this.btnStartCapture.TabIndex = 2;
            this.btnStartCapture.Text = "Démarrer";
            this.btnStartCapture.UseVisualStyleBackColor = true;
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 478);
            this.Controls.Add(this.btnStartCapture);
            this.Controls.Add(this.spc_config);
            this.Controls.Add(this.chtEcran);
            this.Name = "frmPrincipale";
            this.Text = "Oscilloscope";
            this.Load += new System.EventHandler(this.frmPrincipale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtEcran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chtEcran;
        private System.Windows.Forms.Timer clkMinuterie;
        private gei1076_tools.SerialPortConfigurator spc_config;
        private System.Windows.Forms.Button btnStartCapture;
    }
}

