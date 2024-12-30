namespace LogFreqGraph.Views
{
    partial class AddFunctionForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            submitBtn = new Button();
            cancelBtn = new Button();
            enumeratorTextBox = new TextBox();
            denominatorTextBox = new TextBox();
            tCoefTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            enumeratorLabel = new Label();
            helpLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(submitBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(cancelBtn, 1, 4);
            tableLayoutPanel1.Controls.Add(enumeratorTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(denominatorTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(tCoefTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(enumeratorLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(helpLabel, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(290, 369);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(3, 334);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(94, 29);
            submitBtn.TabIndex = 0;
            submitBtn.Text = "Добавить";
            submitBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cancelBtn.Location = new Point(193, 334);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(94, 29);
            cancelBtn.TabIndex = 1;
            cancelBtn.Text = "Отмена";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // enumeratorTextBox
            // 
            enumeratorTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            enumeratorTextBox.Location = new Point(148, 87);
            enumeratorTextBox.Name = "enumeratorTextBox";
            enumeratorTextBox.Size = new Size(139, 27);
            enumeratorTextBox.TabIndex = 2;
            // 
            // denominatorTextBox
            // 
            denominatorTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            denominatorTextBox.Location = new Point(148, 179);
            denominatorTextBox.Name = "denominatorTextBox";
            denominatorTextBox.Size = new Size(139, 27);
            denominatorTextBox.TabIndex = 3;
            // 
            // tCoefTextBox
            // 
            tCoefTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tCoefTextBox.Location = new Point(148, 271);
            tCoefTextBox.Name = "tCoefTextBox";
            tCoefTextBox.Size = new Size(139, 27);
            tCoefTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 163);
            label2.Name = "label2";
            label2.Size = new Size(139, 60);
            label2.TabIndex = 6;
            label2.Text = "Значения коэффициентов знаменателя";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 255);
            label3.Name = "label3";
            label3.Size = new Size(139, 60);
            label3.TabIndex = 7;
            label3.Text = "Значение постоянной времени T";
            // 
            // enumeratorLabel
            // 
            enumeratorLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            enumeratorLabel.AutoSize = true;
            enumeratorLabel.Font = new Font("Segoe UI", 9F);
            enumeratorLabel.Location = new Point(3, 71);
            enumeratorLabel.Name = "enumeratorLabel";
            enumeratorLabel.Size = new Size(139, 60);
            enumeratorLabel.TabIndex = 5;
            enumeratorLabel.Text = "Значения коэффициентов числителя";
            // 
            // helpLabel
            // 
            helpLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            helpLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(helpLabel, 2);
            helpLabel.Location = new Point(3, 7);
            helpLabel.Name = "helpLabel";
            helpLabel.Size = new Size(284, 40);
            helpLabel.TabIndex = 8;
            helpLabel.Text = "Введите значения необходимых коэффициентов";
            helpLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddFunctionForm
            // 
            AcceptButton = submitBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelBtn;
            ClientSize = new Size(293, 370);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddFunctionForm";
            Text = "Добавить передаточную функцию";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox denominatorTextBox;
        private TextBox tCoefTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button submitBtn;
        private Button cancelBtn;
        private TextBox enumeratorTextBox;
        private Label enumeratorLabel;
        private Label label2;
        private Label label3;
        private Label helpLabel;
    }
}