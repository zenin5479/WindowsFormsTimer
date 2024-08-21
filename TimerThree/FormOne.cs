using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerThree
{
   public partial class FormOne : Form
   {
      private System.Windows.Forms.Timer _timer;
      private readonly Queue<TimerTask> _timerTaskQueue = new Queue<TimerTask>();

      public FormOne()
      {
         InitializeComponent();
      }

      private void FormOne_Load(object sender, EventArgs e)
      {

      }

      private void ButtonTimerStart_Click(object sender, EventArgs e)
      {
         _timerTaskQueue.Enqueue(new TimerTask { WaitTimeMsec = 1000, Message = "Первая задача" });
         _timerTaskQueue.Enqueue(new TimerTask { WaitTimeMsec = 700, Message = "Вторая задача" });
         _timerTaskQueue.Enqueue(new TimerTask { WaitTimeMsec = 300, Message = "Третья задача" });
         _timer = new System.Windows.Forms.Timer();

         _timer.Tick += Timer_Tick;
         _timer.Interval = 100;
         _timer.Start();
      }

      private void Timer_Tick(object sender, EventArgs e)
      {
         if (_timerTaskQueue.Count == 0)
         {
            _timer.Stop();
            return;
         }

         TimerTask task = _timerTaskQueue.Dequeue();
         Thread.Sleep(task.WaitTimeMsec);
         TextBoxOne.AppendText(task.Message + Environment.NewLine);
      }
   }

   public class TimerTask
   {
      public int WaitTimeMsec { get; set; }

      public string Message { get; set; }
   }
}