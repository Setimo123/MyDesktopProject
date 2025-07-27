namespace Consultation.App.Views
{
    partial class ConsultationDashBoardCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            materialLabelSubjectName = new MaterialSkin.Controls.MaterialLabel();
            materialLabelRequestedBy = new MaterialSkin.Controls.MaterialLabel();
            materialLabelRequestedTo = new MaterialSkin.Controls.MaterialLabel();
            materialLabelStatus = new MaterialSkin.Controls.MaterialLabel();
            materialLabelProgram = new MaterialSkin.Controls.MaterialLabel();
            materialLabelConcern = new MaterialSkin.Controls.MaterialLabel();
            materialLabelDateSchedule = new MaterialSkin.Controls.MaterialLabel();
            materialLabelDateRequested = new MaterialSkin.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // materialLabelSubjectName
            // 
            materialLabelSubjectName.AutoSize = true;
            materialLabelSubjectName.Depth = 0;
            materialLabelSubjectName.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelSubjectName.Location = new Point(331, 10);
            materialLabelSubjectName.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelSubjectName.Name = "materialLabelSubjectName";
            materialLabelSubjectName.Size = new Size(108, 19);
            materialLabelSubjectName.TabIndex = 0;
            materialLabelSubjectName.Text = "Subject Name: ";
            // 
            // materialLabelRequestedBy
            // 
            materialLabelRequestedBy.AutoSize = true;
            materialLabelRequestedBy.Depth = 0;
            materialLabelRequestedBy.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelRequestedBy.Location = new Point(30, 62);
            materialLabelRequestedBy.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelRequestedBy.Name = "materialLabelRequestedBy";
            materialLabelRequestedBy.Size = new Size(203, 19);
            materialLabelRequestedBy.TabIndex = 1;
            materialLabelRequestedBy.Text = "Requested By: Cedric Setimo";
            // 
            // materialLabelRequestedTo
            // 
            materialLabelRequestedTo.AutoSize = true;
            materialLabelRequestedTo.Depth = 0;
            materialLabelRequestedTo.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelRequestedTo.Location = new Point(30, 96);
            materialLabelRequestedTo.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelRequestedTo.Name = "materialLabelRequestedTo";
            materialLabelRequestedTo.Size = new Size(181, 19);
            materialLabelRequestedTo.TabIndex = 2;
            materialLabelRequestedTo.Text = "Requested To: Rey Mateo";
            // 
            // materialLabelStatus
            // 
            materialLabelStatus.AutoSize = true;
            materialLabelStatus.Depth = 0;
            materialLabelStatus.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelStatus.Location = new Point(384, 62);
            materialLabelStatus.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelStatus.Name = "materialLabelStatus";
            materialLabelStatus.Size = new Size(113, 19);
            materialLabelStatus.TabIndex = 3;
            materialLabelStatus.Text = "Status: Pending";
            // 
            // materialLabelProgram
            // 
            materialLabelProgram.AutoSize = true;
            materialLabelProgram.Depth = 0;
            materialLabelProgram.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelProgram.Location = new Point(384, 96);
            materialLabelProgram.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelProgram.Name = "materialLabelProgram";
            materialLabelProgram.Size = new Size(226, 19);
            materialLabelProgram.TabIndex = 4;
            materialLabelProgram.Text = "Program: Computer Engineering";
            // 
            // materialLabelConcern
            // 
            materialLabelConcern.AutoSize = true;
            materialLabelConcern.Depth = 0;
            materialLabelConcern.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelConcern.Location = new Point(30, 142);
            materialLabelConcern.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelConcern.Name = "materialLabelConcern";
            materialLabelConcern.Size = new Size(244, 19);
            materialLabelConcern.TabIndex = 5;
            materialLabelConcern.Text = "Concern: I need help for my Thesis";
            // 
            // materialLabelDateSchedule
            // 
            materialLabelDateSchedule.AutoSize = true;
            materialLabelDateSchedule.Depth = 0;
            materialLabelDateSchedule.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelDateSchedule.Location = new Point(655, 96);
            materialLabelDateSchedule.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelDateSchedule.Name = "materialLabelDateSchedule";
            materialLabelDateSchedule.Size = new Size(148, 19);
            materialLabelDateSchedule.TabIndex = 7;
            materialLabelDateSchedule.Text = "Date Schedule: None";
            // 
            // materialLabelDateRequested
            // 
            materialLabelDateRequested.AutoSize = true;
            materialLabelDateRequested.Depth = 0;
            materialLabelDateRequested.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabelDateRequested.Location = new Point(655, 62);
            materialLabelDateRequested.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabelDateRequested.Name = "materialLabelDateRequested";
            materialLabelDateRequested.Size = new Size(152, 19);
            materialLabelDateRequested.TabIndex = 6;
            materialLabelDateRequested.Text = "Date Requested: Now";
            // 
            // ConsultationDashBoardCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(materialLabelDateSchedule);
            Controls.Add(materialLabelDateRequested);
            Controls.Add(materialLabelConcern);
            Controls.Add(materialLabelProgram);
            Controls.Add(materialLabelStatus);
            Controls.Add(materialLabelRequestedTo);
            Controls.Add(materialLabelRequestedBy);
            Controls.Add(materialLabelSubjectName);
            Name = "ConsultationDashBoardCard";
            Size = new Size(825, 209);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabelSubjectName;
        private MaterialSkin.Controls.MaterialLabel materialLabelRequestedBy;
        private MaterialSkin.Controls.MaterialLabel materialLabelRequestedTo;
        private MaterialSkin.Controls.MaterialLabel materialLabelStatus;
        private MaterialSkin.Controls.MaterialLabel materialLabelProgram;
        private MaterialSkin.Controls.MaterialLabel materialLabelConcern;
        private MaterialSkin.Controls.MaterialLabel materialLabelDateSchedule;
        private MaterialSkin.Controls.MaterialLabel materialLabelDateRequested;
    }
}
