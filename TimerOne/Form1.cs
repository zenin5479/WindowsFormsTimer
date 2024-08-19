using System;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerOne
{
   public partial class Form1 : Form
   {
      private int _seconds;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void ButtonStart_Click(object sender, EventArgs e)
      {
         _seconds = Convert.ToInt32(TextBoxSeconds.Text);
         TextBoxSeconds.Enabled = false;
         TimerOne.Start();
      }

      private void TimerOne_Tick(object sender, EventArgs e)
      {
         LabelCounter.Text = _seconds--.ToString();
         if (_seconds < 0)
         {
            TimerOne.Stop();
            TextBoxSeconds.Enabled = true;
         }
      }
   }
}