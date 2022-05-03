namespace estudocsharp
{
    partial class Frm_SelecionarTurma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_SelecionarT = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SelecionarT)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_SelecionarT
            // 
            this.Dgv_SelecionarT.AllowUserToAddRows = false;
            this.Dgv_SelecionarT.AllowUserToDeleteRows = false;
            this.Dgv_SelecionarT.BackgroundColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_SelecionarT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_SelecionarT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_SelecionarT.EnableHeadersVisualStyles = false;
            this.Dgv_SelecionarT.Location = new System.Drawing.Point(13, 13);
            this.Dgv_SelecionarT.Name = "Dgv_SelecionarT";
            this.Dgv_SelecionarT.ReadOnly = true;
            this.Dgv_SelecionarT.RowHeadersVisible = false;
            this.Dgv_SelecionarT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_SelecionarT.Size = new System.Drawing.Size(625, 321);
            this.Dgv_SelecionarT.TabIndex = 0;
            this.Dgv_SelecionarT.DoubleClick += new System.EventHandler(this.Dgv_SelecionarT_DoubleClick);
            // 
            // Frm_SelecionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(647, 351);
            this.Controls.Add(this.Dgv_SelecionarT);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_SelecionarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_SelecionarTurma";
            this.Load += new System.EventHandler(this.Frm_SelecionarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_SelecionarT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_SelecionarT;
    }
}