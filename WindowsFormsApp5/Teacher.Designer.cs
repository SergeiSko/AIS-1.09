namespace WindowsFormsApp5
{
  partial class Teacher
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.cписокСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.списокПредметовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.списокСтудентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.списокПредметовToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.поГруппамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.своднаяТаблицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.списокНеаттестованыхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 95);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowTemplate.Height = 24;
      this.dataGridView1.Size = new System.Drawing.Size(992, 455);
      this.dataGridView1.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(225)))), ((int)(((byte)(170)))));
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem,
            this.студентыToolStripMenuItem,
            this.toolStripMenuItem1});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1023, 28);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // функцииToolStripMenuItem
      // 
      this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
      this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
      this.функцииToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
      this.функцииToolStripMenuItem.Text = "Функции";
      // 
      // выйтиToolStripMenuItem
      // 
      this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
      this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
      this.выйтиToolStripMenuItem.Text = "Выйти";
      // 
      // студентыToolStripMenuItem
      // 
      this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
      this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
      this.студентыToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
      this.студентыToolStripMenuItem.Text = "Группы";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cписокСтудентовToolStripMenuItem,
            this.списокПредметовToolStripMenuItem});
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
      this.toolStripMenuItem2.Text = "1234";
      // 
      // cписокСтудентовToolStripMenuItem
      // 
      this.cписокСтудентовToolStripMenuItem.Name = "cписокСтудентовToolStripMenuItem";
      this.cписокСтудентовToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.cписокСтудентовToolStripMenuItem.Text = "Студенты";
      this.cписокСтудентовToolStripMenuItem.Click += new System.EventHandler(this.cписокСтудентовToolStripMenuItem_Click_1);
      // 
      // списокПредметовToolStripMenuItem
      // 
      this.списокПредметовToolStripMenuItem.Name = "списокПредметовToolStripMenuItem";
      this.списокПредметовToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.списокПредметовToolStripMenuItem.Text = "Предметы";
      this.списокПредметовToolStripMenuItem.Click += new System.EventHandler(this.списокПредметовToolStripMenuItem_Click_1);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСтудентовToolStripMenuItem,
            this.списокПредметовToolStripMenuItem1});
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 26);
      this.toolStripMenuItem3.Text = "2234";
      // 
      // списокСтудентовToolStripMenuItem
      // 
      this.списокСтудентовToolStripMenuItem.Name = "списокСтудентовToolStripMenuItem";
      this.списокСтудентовToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
      this.списокСтудентовToolStripMenuItem.Text = "Студенты";
      this.списокСтудентовToolStripMenuItem.Click += new System.EventHandler(this.списокСтудентовToolStripMenuItem_Click_1);
      // 
      // списокПредметовToolStripMenuItem1
      // 
      this.списокПредметовToolStripMenuItem1.Name = "списокПредметовToolStripMenuItem1";
      this.списокПредметовToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
      this.списокПредметовToolStripMenuItem1.Text = "Предметы";
      this.списокПредметовToolStripMenuItem1.Click += new System.EventHandler(this.списокПредметовToolStripMenuItem1_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поГруппамToolStripMenuItem,
            this.своднаяТаблицаToolStripMenuItem,
            this.списокНеаттестованыхToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(74, 24);
      this.toolStripMenuItem1.Text = "Оценки";
      // 
      // поГруппамToolStripMenuItem
      // 
      this.поГруппамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
      this.поГруппамToolStripMenuItem.Name = "поГруппамToolStripMenuItem";
      this.поГруппамToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
      this.поГруппамToolStripMenuItem.Text = "По группам";
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(116, 26);
      this.toolStripMenuItem4.Text = "1234";
      this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(116, 26);
      this.toolStripMenuItem5.Text = "2234";
      this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
      // 
      // своднаяТаблицаToolStripMenuItem
      // 
      this.своднаяТаблицаToolStripMenuItem.Name = "своднаяТаблицаToolStripMenuItem";
      this.своднаяТаблицаToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
      this.своднаяТаблицаToolStripMenuItem.Text = "Сводная таблица";
      this.своднаяТаблицаToolStripMenuItem.Click += new System.EventHandler(this.своднаяТаблицаToolStripMenuItem_Click);
      // 
      // списокНеаттестованыхToolStripMenuItem
      // 
      this.списокНеаттестованыхToolStripMenuItem.Name = "списокНеаттестованыхToolStripMenuItem";
      this.списокНеаттестованыхToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
      this.списокНеаттестованыхToolStripMenuItem.Text = "Неуспевающие студенты";
      this.списокНеаттестованыхToolStripMenuItem.Click += new System.EventHandler(this.списокНеаттестованыхToolStripMenuItem_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.label1.Location = new System.Drawing.Point(13, 72);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(13, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "-";
      // 
      // Teacher
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.ClientSize = new System.Drawing.Size(1023, 562);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Teacher";
      this.Text = "Teacher: ";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem поГруппамToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem своднаяТаблицаToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem списокНеаттестованыхToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem cписокСтудентовToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem списокПредметовToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem списокСтудентовToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem списокПредметовToolStripMenuItem1;
  }
}