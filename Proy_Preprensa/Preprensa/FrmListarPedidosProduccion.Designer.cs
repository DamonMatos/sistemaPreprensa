namespace Preprensa
{
    partial class FrmListarPedidosProduccion
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
            this.dgListarProduccion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListarProduccion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgListarProduccion
            // 
            this.dgListarProduccion.AllowUserToAddRows = false;
            this.dgListarProduccion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgListarProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListarProduccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListarProduccion.Location = new System.Drawing.Point(0, 0);
            this.dgListarProduccion.Name = "dgListarProduccion";
            this.dgListarProduccion.Size = new System.Drawing.Size(986, 444);
            this.dgListarProduccion.TabIndex = 0;
            this.dgListarProduccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListarProduccion_CellClick_1);
            this.dgListarProduccion.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgListarProduccion_CellPainting_1);
            // 
            // FrmListarPedidosProduccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 444);
            this.Controls.Add(this.dgListarProduccion);
            this.Name = "FrmListarPedidosProduccion";
            this.Text = "Preprensa";
            this.Load += new System.EventHandler(this.FrmListarPedidosProduccion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgListarProduccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgListarProduccion;
    }
}