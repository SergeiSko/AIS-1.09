namespace WindowsFormsApp5
{
  partial class Student
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.отчиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выйтиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.моиОтценкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.моиПредметыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.мояГруппаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(10, 81);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(480, 240);
      this.dataGridView1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.Color.Red;
      this.label1.Location = new System.Drawing.Point(12, 61);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(13, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "-";
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(225)))), ((int)(((byte)(170)))));
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.опцииToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(502, 28);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem,
            this.отчиститьToolStripMenuItem,
            this.выйтиToolStripMenuItem1});
      this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      this.файлToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
      this.файлToolStripMenuItem.Text = "Файл";
      // 
      // обновитьToolStripMenuItem
      // 
      this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
      this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
      this.обновитьToolStripMenuItem.Text = "Обновить";
      this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click_1);
      // 
      // отчиститьToolStripMenuItem
      // 
      this.отчиститьToolStripMenuItem.Name = "отчиститьToolStripMenuItem";
      this.отчиститьToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
      this.отчиститьToolStripMenuItem.Text = "Отчистить";
      this.отчиститьToolStripMenuItem.Click += new System.EventHandler(this.отсчиститьToolStripMenuItem_Click);
      // 
      // выйтиToolStripMenuItem1
      // 
      this.выйтиToolStripMenuItem1.Name = "выйтиToolStripMenuItem1";
      this.выйтиToolStripMenuItem1.Size = new System.Drawing.Size(154, 26);
      this.выйтиToolStripMenuItem1.Text = "Выйти";
      this.выйтиToolStripMenuItem1.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
      // 
      // опцииToolStripMenuItem
      // 
      this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиОтценкиToolStripMenuItem,
            this.моиПредметыToolStripMenuItem,
            this.мояГруппаToolStripMenuItem});
      this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
      this.опцииToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
      this.опцииToolStripMenuItem.Text = "Опции";
      // 
      // моиОтценкиToolStripMenuItem
      // 
      this.моиОтценкиToolStripMenuItem.Name = "моиОтценкиToolStripMenuItem";
      this.моиОтценкиToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
      this.моиОтценкиToolStripMenuItem.Text = "Мои оценки";
      this.моиОтценкиToolStripMenuItem.Click += new System.EventHandler(this.моиОценкиToolStripMenuItem_Click);
      // 
      // моиПредметыToolStripMenuItem
      // 
      this.моиПредметыToolStripMenuItem.Name = "моиПредметыToolStripMenuItem";
      this.моиПредметыToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
      this.моиПредметыToolStripMenuItem.Text = "Мои предметы";
      this.моиПредметыToolStripMenuItem.Click += new System.EventHandler(this.моиПредметыToolStripMenuItem_Click);
      // 
      // мояГруппаToolStripMenuItem
      // 
      this.мояГруппаToolStripMenuItem.Name = "мояГруппаToolStripMenuItem";
      this.мояГруппаToolStripMenuItem.Size = new System.Drawing.Size(189, 26);
      this.мояГруппаToolStripMenuItem.Text = "Моя группа";
      this.мояГруппаToolStripMenuItem.Click += new System.EventHandler(this.мояГруппаToolStripMenuItem_Click);
      // 
      // Student
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(502, 333);
      this.ControlBox = false;
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.menuStrip1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Student";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Student: ";
      this.Load += new System.EventHandler(this.Student_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem отчиститьToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem моиОтценкиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem моиПредметыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem мояГруппаToolStripMenuItem;
  }
}