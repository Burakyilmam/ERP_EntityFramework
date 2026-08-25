namespace ERP_EntityFramework_UI.Forms
{
    partial class frmCalendar
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
            acCalendar = new DevExpress.XtraEditors.Controls.CalendarControl();
            ((System.ComponentModel.ISupportInitialize)acCalendar.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // acCalendar
            // 
            acCalendar.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            acCalendar.ColumnCount = 4;
            acCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            acCalendar.Location = new System.Drawing.Point(0, 0);
            acCalendar.Name = "acCalendar";
            acCalendar.RowCount = 4;
            acCalendar.ShowClearButton = true;
            acCalendar.ShowWeekNumbers = true;
            acCalendar.Size = new System.Drawing.Size(1015, 741);
            acCalendar.TabIndex = 0;
            // 
            // frmCalendar
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1015, 741);
            Controls.Add(acCalendar);
            Name = "frmCalendar";
            Text = "Takvim";
            ((System.ComponentModel.ISupportInitialize)acCalendar.CalendarTimeProperties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.Controls.CalendarControl acCalendar;
    }
}