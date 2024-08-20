using System;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerTwo
{
   public partial class FormOne : Form
   {
      private int _value;

      public FormOne()
      {
         InitializeComponent();
      }

      private void FormOne_Load(object sender, EventArgs e)
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

      private void TimerOne_Tick(object sender, EventArgs e)
      {
         // Обновляем TextBox
         TextBoxSeconds.Text = (_value++).ToString();
      }
   }
}