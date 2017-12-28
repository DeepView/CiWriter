namespace ciwriter
{
   partial class FMainForm
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
         this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
         this.showMainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.materialContextMenuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // materialContextMenuStrip1
         // 
         this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
         this.materialContextMenuStrip1.Depth = 0;
         this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMainWindowToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
         this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseStatus.HOVER;
         this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
         this.materialContextMenuStrip1.Size = new System.Drawing.Size(192, 48);
         // 
         // showMainWindowToolStripMenuItem
         // 
         this.showMainWindowToolStripMenuItem.Name = "showMainWindowToolStripMenuItem";
         this.showMainWindowToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
         this.showMainWindowToolStripMenuItem.Text = "Show Main Window";
         // 
         // exitApplicationToolStripMenuItem
         // 
         this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
         this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
         this.exitApplicationToolStripMenuItem.Text = "Exit Application";
         // 
         // FMainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
         this.ClientSize = new System.Drawing.Size(782, 431);
         this.ContextMenuStrip = this.materialContextMenuStrip1;
         this.Name = "FMainForm";
         this.materialContextMenuStrip1.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
      private System.Windows.Forms.ToolStripMenuItem showMainWindowToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
   }
}
