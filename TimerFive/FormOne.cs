using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerFive
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      private void FormOne_Load(object sender, EventArgs e)
      {

      }

      private void ButtonTimerStart_Click(object sender, EventArgs e)
      {
         Stopwatch stopwatch = new Stopwatch();
         stopwatch.Start();
         Thread.Sleep(1000);
         stopwatch.Stop();
         TextBoxOne.AppendText($"Всего миллисекунд: {stopwatch.Elapsed.TotalMilliseconds:F4}" + Environment.NewLine);
         TextBoxOne.AppendText($"Общее количество секунд: {stopwatch.Elapsed.TotalSeconds:F7}" + Environment.NewLine);

         // Возвращает прошедшее время в качестве значения временного интервала
         TimeSpan ts = stopwatch.Elapsed;
         TextBoxOne.AppendText("Время выполнения " + ts + Environment.NewLine);
         TextBoxOne.AppendText("Время выполнения " + ts.TotalMilliseconds + Environment.NewLine);
      }
   }
}