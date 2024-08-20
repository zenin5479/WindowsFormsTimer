namespace TimerTwo
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         components = new System.ComponentModel.Container();
         ButtonStop = new System.Windows.Forms.Button();
         ButtonStart = new System.Windows.Forms.Button();
         TextBoxSeconds = new System.Windows.Forms.TextBox();
         TimerOne = new System.Windows.Forms.Timer(components);
         SuspendLayout();
         // 
         // ButtonStop
         // 
         ButtonStop.Location = new System.Drawing.Point(81, 50);
         ButtonStop.Margin = new System.Windows.Forms.Padding(4);
         ButtonStop.Name = "ButtonStop";
         ButtonStop.Size = new System.Drawing.Size(60, 32);
         ButtonStop.TabIndex = 19;
         ButtonStop.Text = "Стоп";
         ButtonStop.UseVisualStyleBackColor = true;
         ButtonStop.Click += ButtonStop_Click;
         // 
         // ButtonStart
         // 
         ButtonStart.Location = new System.Drawing.Point(13, 50);
         ButtonStart.Margin = new System.Windows.Forms.Padding(4);
         ButtonStart.Name = "ButtonStart";
         ButtonStart.Size = new System.Drawing.Size(60, 32);
         ButtonStart.TabIndex = 18;
         ButtonStart.Text = "Старт";
         ButtonStart.UseVisualStyleBackColor = true;
         ButtonStart.Click += ButtonStart_Click;
         // 
         // TextBoxSeconds
         // 
         TextBoxSeconds.Location = new System.Drawing.Point(13, 13);
         TextBoxSeconds.Margin = new System.Windows.Forms.Padding(4);
         TextBoxSeconds.Name = "TextBoxSeconds";
         TextBoxSeconds.Size = new System.Drawing.Size(128, 29);
         TextBoxSeconds.TabIndex = 17;
         TextBoxSeconds.Text = "0";
         TextBoxSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // TimerOne
         // 
         TimerOne.Tick += TimerOne_Tick;
         // 
         // FormOne
         // 
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         ClientSize = new System.Drawing.Size(151, 93);
         Controls.Add(ButtonStop);
         Controls.Add(ButtonStart);
         Controls.Add(TextBoxSeconds);
         Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Таймер";
         Load += Form1_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Button ButtonStop;
      private System.Windows.Forms.Button ButtonStart;
      private System.Windows.Forms.TextBox TextBoxSeconds;
      private System.Windows.Forms.Timer TimerOne;
   }
}
