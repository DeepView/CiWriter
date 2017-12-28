namespace ciwriter
{
   partial class FLogin
   {
      /// <summary>
      /// 必需的设计器变量。
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// 清理所有正在使用的资源。
      /// </summary>
      /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows 窗体设计器生成的代码

      /// <summary>
      /// 设计器支持所需的方法 - 不要修改
      /// 使用代码编辑器修改此方法的内容。
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
         this.label2 = new System.Windows.Forms.Label();
         this.txtPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
         this.btnLogin = new MaterialSkin.Controls.MaterialFlatWaveButton();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.label2.ForeColor = System.Drawing.Color.Gray;
         this.label2.Location = new System.Drawing.Point(42, 142);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(260, 17);
         this.label2.TabIndex = 1;
         this.label2.Text = "请输入您设置的访问密码并从上一次的地方继续";
         // 
         // txtPassword
         // 
         this.txtPassword.Depth = 0;
         this.txtPassword.Hint = "请输入您的密码";
         this.txtPassword.Location = new System.Drawing.Point(77, 225);
         this.txtPassword.MaxLength = 32;
         this.txtPassword.MouseState = MaterialSkin.MouseStatus.HOVER;
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.PasswordChar = '\0';
         this.txtPassword.SelectedText = "";
         this.txtPassword.SelectionLength = 0;
         this.txtPassword.SelectionStart = 0;
         this.txtPassword.Size = new System.Drawing.Size(191, 23);
         this.txtPassword.TabIndex = 1;
         this.txtPassword.TabStop = false;
         this.txtPassword.UseSystemPasswordChar = true;
         // 
         // btnLogin
         // 
         this.btnLogin.AutoSize = true;
         this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
         this.btnLogin.Depth = 0;
         this.btnLogin.Location = new System.Drawing.Point(96, 333);
         this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
         this.btnLogin.MouseState = MaterialSkin.MouseStatus.HOVER;
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Primary = false;
         this.btnLogin.Size = new System.Drawing.Size(153, 36);
         this.btnLogin.TabIndex = 0;
         this.btnLogin.Text = "Login And Continue";
         this.btnLogin.UseVisualStyleBackColor = true;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
         this.pictureBox1.Location = new System.Drawing.Point(89, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(166, 64);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pictureBox1.TabIndex = 2;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
         this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
         this.label1.Location = new System.Drawing.Point(131, 93);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(82, 41);
         this.label1.TabIndex = 0;
         this.label1.Text = "欢迎";
         // 
         // FLogin
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.ClientSize = new System.Drawing.Size(345, 397);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.txtPassword);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "FLogin";
         this.Text = "Login";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLogin_FormClosing);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.Label label2;
      private MaterialSkin.Controls.MaterialSingleLineTextField txtPassword;
      private MaterialSkin.Controls.MaterialFlatWaveButton btnLogin;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
   }
}
