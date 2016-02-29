namespace PatientWeightAssessment
{
    partial class FrmPatientWeightAssessment
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
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabPageExercise = new System.Windows.Forms.TabPage();
            this.tabPageNutrition = new System.Windows.Forms.TabPage();
            this.tabPageOverAllHealth = new System.Windows.Forms.TabPage();
            this.tabPageHistoryOf = new System.Windows.Forms.TabPage();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.tbPatientWeightAssessment = new System.Windows.Forms.TabControl();
            this.tabPageMedicalHistory = new System.Windows.Forms.TabPage();
            this.tabPageOther.SuspendLayout();
            this.tbPatientWeightAssessment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageOther
            // 
            this.tabPageOther.Controls.Add(this.btnClear);
            this.tabPageOther.Controls.Add(this.btnSave);
            this.tabPageOther.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageOther.Location = new System.Drawing.Point(4, 33);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Size = new System.Drawing.Size(1467, 820);
            this.tabPageOther.TabIndex = 6;
            this.tabPageOther.Text = "Other";
            this.tabPageOther.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(1216, 662);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 49);
            this.btnClear.TabIndex = 86;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(990, 662);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 49);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabPageExercise
            // 
            this.tabPageExercise.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageExercise.Location = new System.Drawing.Point(4, 33);
            this.tabPageExercise.Name = "tabPageExercise";
            this.tabPageExercise.Size = new System.Drawing.Size(1467, 820);
            this.tabPageExercise.TabIndex = 5;
            this.tabPageExercise.Text = "Exercise";
            this.tabPageExercise.UseVisualStyleBackColor = true;
            // 
            // tabPageNutrition
            // 
            this.tabPageNutrition.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageNutrition.Location = new System.Drawing.Point(4, 33);
            this.tabPageNutrition.Name = "tabPageNutrition";
            this.tabPageNutrition.Size = new System.Drawing.Size(1467, 820);
            this.tabPageNutrition.TabIndex = 4;
            this.tabPageNutrition.Text = "Nutrition";
            this.tabPageNutrition.UseVisualStyleBackColor = true;
            // 
            // tabPageOverAllHealth
            // 
            this.tabPageOverAllHealth.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageOverAllHealth.Location = new System.Drawing.Point(4, 33);
            this.tabPageOverAllHealth.Name = "tabPageOverAllHealth";
            this.tabPageOverAllHealth.Size = new System.Drawing.Size(1467, 820);
            this.tabPageOverAllHealth.TabIndex = 3;
            this.tabPageOverAllHealth.Text = "Overall Health";
            this.tabPageOverAllHealth.UseVisualStyleBackColor = true;
            // 
            // tabPageHistoryOf
            // 
            this.tabPageHistoryOf.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageHistoryOf.Location = new System.Drawing.Point(4, 33);
            this.tabPageHistoryOf.Name = "tabPageHistoryOf";
            this.tabPageHistoryOf.Size = new System.Drawing.Size(1467, 820);
            this.tabPageHistoryOf.TabIndex = 2;
            this.tabPageHistoryOf.Text = "History Of..";
            this.tabPageHistoryOf.UseVisualStyleBackColor = true;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 33);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(1467, 820);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // tbPatientWeightAssessment
            // 
            this.tbPatientWeightAssessment.Controls.Add(this.tabPageGeneral);
            this.tbPatientWeightAssessment.Controls.Add(this.tabPageMedicalHistory);
            this.tbPatientWeightAssessment.Controls.Add(this.tabPageHistoryOf);
            this.tbPatientWeightAssessment.Controls.Add(this.tabPageOverAllHealth);
            this.tbPatientWeightAssessment.Controls.Add(this.tabPageNutrition);
            this.tbPatientWeightAssessment.Controls.Add(this.tabPageExercise);
            this.tbPatientWeightAssessment.Controls.Add(this.tabPageOther);
            this.tbPatientWeightAssessment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPatientWeightAssessment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPatientWeightAssessment.Location = new System.Drawing.Point(0, 0);
            this.tbPatientWeightAssessment.Name = "tbPatientWeightAssessment";
            this.tbPatientWeightAssessment.SelectedIndex = 0;
            this.tbPatientWeightAssessment.Size = new System.Drawing.Size(1475, 857);
            this.tbPatientWeightAssessment.TabIndex = 0;
            // 
            // tabPageMedicalHistory
            // 
            this.tabPageMedicalHistory.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageMedicalHistory.Location = new System.Drawing.Point(4, 33);
            this.tabPageMedicalHistory.Name = "tabPageMedicalHistory";
            this.tabPageMedicalHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMedicalHistory.Size = new System.Drawing.Size(1467, 820);
            this.tabPageMedicalHistory.TabIndex = 1;
            this.tabPageMedicalHistory.Text = "Medical History";
            this.tabPageMedicalHistory.UseVisualStyleBackColor = true;
            // 
            // FrmPatientWeightAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 857);
            this.Controls.Add(this.tbPatientWeightAssessment);
            this.Name = "FrmPatientWeightAssessment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Weight Assessment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPatientWeightAssessment_Load);
            this.tabPageOther.ResumeLayout(false);
            this.tbPatientWeightAssessment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageOther;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TabPage tabPageExercise;
        private System.Windows.Forms.TabPage tabPageNutrition;
        private System.Windows.Forms.TabPage tabPageOverAllHealth;
        private System.Windows.Forms.TabPage tabPageHistoryOf;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabControl tbPatientWeightAssessment;
        private System.Windows.Forms.TabPage tabPageMedicalHistory;
    }
}