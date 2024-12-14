namespace LogFreqGraph.Views
{
    partial class MainForm
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
            kCoefRefreshBtn = new Button();
            addBtn = new Button();
            functionLabel = new Label();
            kInfoLabel = new Label();
            kLabel = new Label();
            kTextBox = new TextBox();
            removeBtn = new Button();
            graphBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            functionsListBox = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // kCoefRefreshBtn
            // 
            kCoefRefreshBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kCoefRefreshBtn.Location = new Point(264, 142);
            kCoefRefreshBtn.Name = "kCoefRefreshBtn";
            kCoefRefreshBtn.Size = new Size(126, 29);
            kCoefRefreshBtn.TabIndex = 0;
            kCoefRefreshBtn.Text = "Обновить K";
            kCoefRefreshBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            addBtn.Location = new Point(3, 35);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(124, 54);
            addBtn.TabIndex = 1;
            addBtn.Text = "Добавить функцию";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // functionLabel
            // 
            functionLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            functionLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(functionLabel, 3);
            functionLabel.Location = new Point(3, 5);
            functionLabel.Name = "functionLabel";
            functionLabel.Size = new Size(387, 20);
            functionLabel.TabIndex = 2;
            functionLabel.Text = "Список передаточных функций";
            functionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kInfoLabel
            // 
            kInfoLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(kInfoLabel, 3);
            kInfoLabel.Location = new Point(3, 94);
            kInfoLabel.Name = "kInfoLabel";
            kInfoLabel.Size = new Size(387, 31);
            kInfoLabel.TabIndex = 4;
            kInfoLabel.Text = "Текущее значение коэффициента k:";
            kInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kLabel
            // 
            kLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kLabel.Location = new Point(3, 133);
            kLabel.Name = "kLabel";
            kLabel.Size = new Size(124, 47);
            kLabel.TabIndex = 5;
            kLabel.Text = "Введите коэффициент k";
            kLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // kTextBox
            // 
            kTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            kTextBox.Location = new Point(133, 143);
            kTextBox.Name = "kTextBox";
            kTextBox.Size = new Size(125, 27);
            kTextBox.TabIndex = 6;
            // 
            // removeBtn
            // 
            removeBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            removeBtn.Location = new Point(133, 36);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(125, 53);
            removeBtn.TabIndex = 13;
            removeBtn.Text = "Удалить функцию";
            removeBtn.UseVisualStyleBackColor = true;
            // 
            // graphBtn
            // 
            graphBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            graphBtn.Location = new Point(264, 36);
            graphBtn.Name = "graphBtn";
            graphBtn.Size = new Size(126, 53);
            graphBtn.TabIndex = 14;
            graphBtn.Text = "Построить график";
            graphBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(functionLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(functionsListBox, 0, 4);
            tableLayoutPanel1.Controls.Add(addBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(kCoefRefreshBtn, 2, 3);
            tableLayoutPanel1.Controls.Add(graphBtn, 2, 1);
            tableLayoutPanel1.Controls.Add(kLabel, 0, 3);
            tableLayoutPanel1.Controls.Add(removeBtn, 1, 1);
            tableLayoutPanel1.Controls.Add(kInfoLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(kTextBox, 1, 3);
            tableLayoutPanel1.Location = new Point(-1, -2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Size = new Size(393, 637);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // functionsListBox
            // 
            functionsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.SetColumnSpan(functionsListBox, 3);
            functionsListBox.FormattingEnabled = true;
            functionsListBox.Location = new Point(3, 191);
            functionsListBox.Name = "functionsListBox";
            functionsListBox.Size = new Size(387, 424);
            functionsListBox.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 634);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "MainForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button kCoefRefreshBtn;
        private Button addBtn;
        private Label functionLabel;
        private Label kInfoLabel;
        private Label kLabel;
        private TextBox kTextBox;
        private Button removeBtn;
        private Button graphBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private ListBox functionsListBox;
    }
}