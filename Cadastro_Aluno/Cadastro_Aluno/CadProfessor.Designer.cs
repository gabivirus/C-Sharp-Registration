
namespace Cadastro_Aluno
{
    partial class CadProfessor
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
            this.matterBox = new System.Windows.Forms.TextBox();
            this.matterLabel = new System.Windows.Forms.Label();
            this.wageBox = new System.Windows.Forms.TextBox();
            this.wageLabel = new System.Windows.Forms.Label();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // matterBox
            // 
            this.matterBox.Location = new System.Drawing.Point(191, 88);
            this.matterBox.MaxLength = 50;
            this.matterBox.Name = "matterBox";
            this.matterBox.Size = new System.Drawing.Size(155, 20);
            this.matterBox.TabIndex = 17;
            // 
            // matterLabel
            // 
            this.matterLabel.AutoSize = true;
            this.matterLabel.Location = new System.Drawing.Point(191, 71);
            this.matterLabel.Name = "matterLabel";
            this.matterLabel.Size = new System.Drawing.Size(42, 13);
            this.matterLabel.TabIndex = 16;
            this.matterLabel.Text = "Matéria";
            // 
            // wageBox
            // 
            this.wageBox.Location = new System.Drawing.Point(12, 88);
            this.wageBox.MaxLength = 5;
            this.wageBox.Name = "wageBox";
            this.wageBox.Size = new System.Drawing.Size(173, 20);
            this.wageBox.TabIndex = 15;
            // 
            // wageLabel
            // 
            this.wageLabel.AutoSize = true;
            this.wageLabel.Location = new System.Drawing.Point(12, 71);
            this.wageLabel.Name = "wageLabel";
            this.wageLabel.Size = new System.Drawing.Size(39, 13);
            this.wageLabel.TabIndex = 14;
            this.wageLabel.Text = "Salário";
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(272, 26);
            this.ageBox.MaxLength = 3;
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(74, 20);
            this.ageBox.TabIndex = 13;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(272, 9);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(34, 13);
            this.AgeLabel.TabIndex = 12;
            this.AgeLabel.Text = "Idade";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 26);
            this.nameBox.MaxLength = 100;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(254, 20);
            this.nameBox.TabIndex = 11;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 9);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Nome";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 167);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(334, 39);
            this.Register.TabIndex = 9;
            this.Register.Text = "Cadastrar Professor";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // CadProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 230);
            this.Controls.Add(this.matterBox);
            this.Controls.Add(this.matterLabel);
            this.Controls.Add(this.wageBox);
            this.Controls.Add(this.wageLabel);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Register);
            this.Name = "CadProfessor";
            this.Text = "Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox matterBox;
        private System.Windows.Forms.Label matterLabel;
        private System.Windows.Forms.TextBox wageBox;
        private System.Windows.Forms.Label wageLabel;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button Register;
    }
}