
namespace Cadastro_Aluno
{
    partial class CadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadAluno));
            this.Register = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ageBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.registerBox = new System.Windows.Forms.TextBox();
            this.regLabel = new System.Windows.Forms.Label();
            this.courseBox = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 171);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(334, 39);
            this.Register.TabIndex = 0;
            this.Register.Text = "Cadastrar Aluno";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Nome";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 30);
            this.nameBox.MaxLength = 100;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(254, 20);
            this.nameBox.TabIndex = 2;
            // 
            // ageBox
            // 
            this.ageBox.Location = new System.Drawing.Point(272, 30);
            this.ageBox.MaxLength = 3;
            this.ageBox.Name = "ageBox";
            this.ageBox.Size = new System.Drawing.Size(74, 20);
            this.ageBox.TabIndex = 4;
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(272, 13);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(34, 13);
            this.AgeLabel.TabIndex = 3;
            this.AgeLabel.Text = "Idade";
            // 
            // registerBox
            // 
            this.registerBox.Location = new System.Drawing.Point(12, 92);
            this.registerBox.MaxLength = 5;
            this.registerBox.Name = "registerBox";
            this.registerBox.Size = new System.Drawing.Size(173, 20);
            this.registerBox.TabIndex = 6;
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Location = new System.Drawing.Point(12, 75);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(52, 13);
            this.regLabel.TabIndex = 5;
            this.regLabel.Text = "Matrícula";
            // 
            // courseBox
            // 
            this.courseBox.Location = new System.Drawing.Point(191, 92);
            this.courseBox.MaxLength = 50;
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(155, 20);
            this.courseBox.TabIndex = 8;
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Location = new System.Drawing.Point(191, 75);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(34, 13);
            this.courseLabel.TabIndex = 7;
            this.courseLabel.Text = "Curso";
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 230);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.registerBox);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.ageBox);
            this.Controls.Add(this.AgeLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Register);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aluno";
            this.Text = "Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox ageBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.TextBox registerBox;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.TextBox courseBox;
        private System.Windows.Forms.Label courseLabel;
    }
}