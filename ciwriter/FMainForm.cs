using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ciwriter
{
   public partial class FMainForm : ciwriter.FNormalWindow
   {
      public FMainForm()
      {
         InitializeComponent();
      }

      public FMainForm(string password) : this()
      {

      }

   }
}
