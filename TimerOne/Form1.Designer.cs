namespace TimerOne
{
   partial class Form1
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
         LabelSeconds = new System.Windows.Forms.Label();
         ButtonStart = new System.Windows.Forms.Button();
         TextBoxSeconds = new System.Windows.Forms.TextBox();
         LabelCounter = new System.Windows.Forms.Label();
         SuspendLayout();
         // 
         // LabelSeconds
         // 
         LabelSeconds.AutoSize = true;
         LabelSeconds.Location = new System.Drawing.Point(252, 19);
         LabelSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         LabelSeconds.Name = "LabelSeconds";
         LabelSeconds.Size = new System.Drawing.Size(59, 21);
         LabelSeconds.TabIndex = 15;
         LabelSeconds.Text = "секунд";
         // 
         // ButtonStart
         // 
         ButtonStart.Location = new System.Drawing.Point(13, 13);
         ButtonStart.Margin = new System.Windows.Forms.Padding(4);
         ButtonStart.Name = "ButtonStart";
         ButtonStart.Size = new System.Drawing.Size(96, 32);
         ButtonStart.TabIndex = 14;
         ButtonStart.Text = "Старт";
         ButtonStart.UseVisualStyleBackColor = true;
         // 
         // TextBoxSeconds
         // 
         TextBoxSeconds.Location = new System.Drawing.Point(117, 16);
         TextBoxSeconds.Margin = new System.Windows.Forms.Padding(4);
         TextBoxSeconds.Name = "TextBoxSeconds";
         TextBoxSeconds.Size = new System.Drawing.Size(127, 29);
         TextBoxSeconds.TabIndex = 13;
         TextBoxSeconds.Text = "10";
         // 
         // LabelCounter
         // 
         LabelCounter.AutoSize = true;
         LabelCounter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
         LabelCounter.Location = new System.Drawing.Point(117, 49);
         LabelCounter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         LabelCounter.Name = "LabelCounter";
         LabelCounter.Size = new System.Drawing.Size(49, 37);
         LabelCounter.TabIndex = 12;
         LabelCounter.Text = "10";
         // 
         // Form1
         // 
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         ClientSize = new System.Drawing.Size(324, 93);
         Controls.Add(LabelSeconds);
         Controls.Add(ButtonStart);
         Controls.Add(TextBoxSeconds);
         Controls.Add(LabelCounter);
         Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "Form1";
         Text = "Таймер обратного отсчета";
         Load += Form1_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label LabelSeconds;
      private System.Windows.Forms.Button ButtonStart;
      private System.Windows.Forms.TextBox TextBoxSeconds;
      private System.Windows.Forms.Label LabelCounter;
   }
}