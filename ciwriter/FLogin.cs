using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ciwriter
{


   //DevilRevelation\Context\
   //DevilRevelation\Resources\
   //DevilRevelation\PlanningCase\
   //DevilRevelation\Build\
   //DevilRevelation\config.novelproject-ci


   public partial class FLogin : ciwriter.FHaveMinButtonDialogWindow
   {
      private bool _shouldCloseWindow = true;
      public FLogin()
      {
         InitializeComponent();
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtPassword.Text))
         {
            MessageBox.Show("The password isn't null or empty!", "Error");
         }
         else
         {
            FMainForm mainForm = new FMainForm();
            mainForm.Show();
            _shouldCloseWindow = true;
            Close();
         }
      }

      private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
      {
         if (!_shouldCloseWindow)
         {
            e.Cancel = true;
            Visible = !e.Cancel;
         }
      }
   }
}
