namespace UC12_App1
{
    partial class Form_LOGIN
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
            this.textBox_USUARIO = new System.Windows.Forms.TextBox();
            this.label_USUARIO = new System.Windows.Forms.Label();
            this.checkBox_ADM = new System.Windows.Forms.CheckBox();
            this.button_ENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_USUARIO
            // 
            this.textBox_USUARIO.Location = new System.Drawing.Point(54, 85);
            this.textBox_USUARIO.Name = "textBox_USUARIO";
            this.textBox_USUARIO.Size = new System.Drawing.Size(227, 20);
            this.textBox_USUARIO.TabIndex = 0;
            // 
            // label_USUARIO
            // 
            this.label_USUARIO.AutoSize = true;
            this.label_USUARIO.Location = new System.Drawing.Point(51, 69);
            this.label_USUARIO.Name = "label_USUARIO";
            this.label_USUARIO.Size = new System.Drawing.Size(43, 13);
            this.label_USUARIO.TabIndex = 1;
            this.label_USUARIO.Text = "Usuario";
            // 
            // checkBox_ADM
            // 
            this.checkBox_ADM.AutoSize = true;
            this.checkBox_ADM.Location = new System.Drawing.Point(126, 111);
            this.checkBox_ADM.Name = "checkBox_ADM";
            this.checkBox_ADM.Size = new System.Drawing.Size(89, 17);
            this.checkBox_ADM.TabIndex = 2;
            this.checkBox_ADM.Text = "Administrador";
            this.checkBox_ADM.UseVisualStyleBackColor = true;
            this.checkBox_ADM.CheckedChanged += new System.EventHandler(this.checkBox_ADM_CheckedChanged);
            // 
            // button_ENTRAR
            // 
            this.button_ENTRAR.Location = new System.Drawing.Point(124, 134);
            this.button_ENTRAR.Name = "button_ENTRAR";
            this.button_ENTRAR.Size = new System.Drawing.Size(91, 40);
            this.button_ENTRAR.TabIndex = 3;
            this.button_ENTRAR.Text = "Entrar";
            this.button_ENTRAR.UseVisualStyleBackColor = true;
            this.button_ENTRAR.Click += new System.EventHandler(this.button_ENTRAR_Click);
            // 
            // Form_LOGIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 268);
            this.Controls.Add(this.label_USUARIO);
            this.Controls.Add(this.textBox_USUARIO);
            this.Controls.Add(this.checkBox_ADM);
            this.Controls.Add(this.button_ENTRAR);
            this.Name = "Form_LOGIN";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_USUARIO;
        private System.Windows.Forms.Label label_USUARIO;
        private System.Windows.Forms.CheckBox checkBox_ADM;
        private System.Windows.Forms.Button button_ENTRAR;
    }
}