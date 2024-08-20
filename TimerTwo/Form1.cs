using System;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerTwo
{
   public partial class Form1 : Form
   {
      private int _value;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void ButtonStart_Click(object sender, EventArgs e)
      {
         if (int.TryParse(TextBoxSeconds.Text, out _value))
         {
            TimerOne.Start();
         }
      }

      private void ButtonStop_Click(object sender, EventArgs e)
      {
         TimerOne.Stop();
      }
   }
}
