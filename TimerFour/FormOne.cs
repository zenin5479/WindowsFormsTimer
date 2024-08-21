using System;
using System.Windows.Forms;

// System.Windows.Forms.Timer

namespace TimerFour
{
   public partial class FormOne : Form
   {
      private static readonly Timer MyTimer = new Timer();
      private static int _alarmCounter = 1;
      private static bool _exitFlag;

      public FormOne()
      {
         InitializeComponent();
      }

      private void FormOne_Load(object sender, EventArgs e)
      {

      }

      private void ButtonTimerStart_Click(object sender, EventArgs e)
      {
         // Добавляет событие и обработчик события для метода, который будет обрабатывать событие таймера в timer
         MyTimer.Tick += TimerEventProcessor;

         //TimerEventProcessor();

         // Устанавливаем интервал таймера равным 1 секуде
         MyTimer.Interval = 1000;
         MyTimer.Start();

         // Запускаем таймер и вызывает событие
         while (_exitFlag == false)
         {
            // Обрабатываем все события в очереди
            Application.DoEvents();
         }
      }

      // Метод запускается при запуске таймера
      private static void TimerEventProcessor(object myObject, EventArgs myEventArgs)
      {
         MyTimer.Stop();

         // Отображает окно сообщения с запросом, следует ли продолжать запуск таймера
         if (MessageBox.Show(@"Продолжать?", @"Подсчет равен: " + _alarmCounter, MessageBoxButtons.YesNo) == DialogResult.Yes)
         {
            // Перезапускает таймер и увеличивает значение счетчика
            _alarmCounter += 1;
            MyTimer.Enabled = true;
         }
         else
         {
            // Останавливает таймер
            _exitFlag = true;
         }
      }
   }
}