namespace TClicker
{
    partial class TClicker
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TClicker));
            this.StartButton = new System.Windows.Forms.Button();
            this.fixedInterval = new System.Windows.Forms.TextBox();
            this.FixedLabel = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.RandomLabel = new System.Windows.Forms.Label();
            this.minValue = new System.Windows.Forms.TextBox();
            this.maxValue = new System.Windows.Forms.TextBox();
            this.unit0 = new System.Windows.Forms.Label();
            this.hyphen = new System.Windows.Forms.Label();
            this.RandomMode = new System.Windows.Forms.CheckBox();
            this.DisplayCPS = new System.Windows.Forms.CheckBox();
            this.ChecklistKeys = new System.Windows.Forms.CheckedListBox();
            this.RightButton = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 132);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(204, 64);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Começar a clicar!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.ClickButtonClicked);
            // 
            // fixedInterval
            // 
            this.fixedInterval.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.fixedInterval.Location = new System.Drawing.Point(62, 99);
            this.fixedInterval.Name = "fixedInterval";
            this.fixedInterval.Size = new System.Drawing.Size(71, 26);
            this.fixedInterval.TabIndex = 1;
            this.fixedInterval.Text = "100";
            // 
            // FixedLabel
            // 
            this.FixedLabel.AutoSize = true;
            this.FixedLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FixedLabel.Location = new System.Drawing.Point(12, 67);
            this.FixedLabel.Name = "FixedLabel";
            this.FixedLabel.Size = new System.Drawing.Size(215, 27);
            this.FixedLabel.TabIndex = 2;
            this.FixedLabel.Text = "Intervalo constante";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.Location = new System.Drawing.Point(139, 108);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(31, 17);
            this.unit.TabIndex = 3;
            this.unit.Text = "Ms.";
            // 
            // RandomLabel
            // 
            this.RandomLabel.AutoSize = true;
            this.RandomLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandomLabel.Location = new System.Drawing.Point(12, 67);
            this.RandomLabel.Name = "RandomLabel";
            this.RandomLabel.Size = new System.Drawing.Size(201, 27);
            this.RandomLabel.TabIndex = 4;
            this.RandomLabel.Text = "Intervalo aleatório";
            this.RandomLabel.Visible = false;
            // 
            // minValue
            // 
            this.minValue.Location = new System.Drawing.Point(12, 99);
            this.minValue.Name = "minValue";
            this.minValue.Size = new System.Drawing.Size(71, 26);
            this.minValue.TabIndex = 5;
            this.minValue.Text = "50";
            this.minValue.Visible = false;
            // 
            // maxValue
            // 
            this.maxValue.Location = new System.Drawing.Point(110, 99);
            this.maxValue.Name = "maxValue";
            this.maxValue.Size = new System.Drawing.Size(71, 26);
            this.maxValue.TabIndex = 6;
            this.maxValue.Text = "150";
            this.maxValue.Visible = false;
            // 
            // unit0
            // 
            this.unit0.AutoSize = true;
            this.unit0.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit0.Location = new System.Drawing.Point(186, 108);
            this.unit0.Name = "unit0";
            this.unit0.Size = new System.Drawing.Size(31, 17);
            this.unit0.TabIndex = 7;
            this.unit0.Text = "Ms.";
            this.unit0.Visible = false;
            // 
            // hyphen
            // 
            this.hyphen.AutoSize = true;
            this.hyphen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hyphen.Location = new System.Drawing.Point(89, 103);
            this.hyphen.Name = "hyphen";
            this.hyphen.Size = new System.Drawing.Size(13, 17);
            this.hyphen.TabIndex = 8;
            this.hyphen.Text = "-";
            this.hyphen.Visible = false;
            // 
            // RandomMode
            // 
            this.RandomMode.AutoSize = true;
            this.RandomMode.Location = new System.Drawing.Point(12, 41);
            this.RandomMode.Name = "RandomMode";
            this.RandomMode.Size = new System.Drawing.Size(90, 22);
            this.RandomMode.TabIndex = 9;
            this.RandomMode.Text = "Aleatório";
            this.RandomMode.UseVisualStyleBackColor = true;
            this.RandomMode.CheckedChanged += new System.EventHandler(this.RandomCheckboxChanged);
            // 
            // DisplayCPS
            // 
            this.DisplayCPS.AutoSize = true;
            this.DisplayCPS.Location = new System.Drawing.Point(12, 12);
            this.DisplayCPS.Name = "DisplayCPS";
            this.DisplayCPS.Size = new System.Drawing.Size(143, 22);
            this.DisplayCPS.TabIndex = 10;
            this.DisplayCPS.Text = "Display em CPS";
            this.DisplayCPS.UseVisualStyleBackColor = true;
            this.DisplayCPS.CheckedChanged += new System.EventHandler(this.CPSCheckboxChanged);
            // 
            // ChecklistKeys
            // 
            this.ChecklistKeys.FormattingEnabled = true;
            this.ChecklistKeys.Location = new System.Drawing.Point(222, 24);
            this.ChecklistKeys.Name = "ChecklistKeys";
            this.ChecklistKeys.Size = new System.Drawing.Size(207, 172);
            this.ChecklistKeys.TabIndex = 12;
            this.ChecklistKeys.SelectedValueChanged += new System.EventHandler(this.KeySelected);
            // 
            // RightButton
            // 
            this.RightButton.AutoSize = true;
            this.RightButton.Location = new System.Drawing.Point(104, 41);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(117, 22);
            this.RightButton.TabIndex = 14;
            this.RightButton.Text = "Botão direito";
            this.RightButton.UseVisualStyleBackColor = true;
            // 
            // TClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 209);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.ChecklistKeys);
            this.Controls.Add(this.DisplayCPS);
            this.Controls.Add(this.RandomMode);
            this.Controls.Add(this.hyphen);
            this.Controls.Add(this.unit0);
            this.Controls.Add(this.maxValue);
            this.Controls.Add(this.minValue);
            this.Controls.Add(this.RandomLabel);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.FixedLabel);
            this.Controls.Add(this.fixedInterval);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TClicker";
            this.Text = "TClicker";
            this.Load += new System.EventHandler(this.TClicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.TextBox fixedInterval;
        private System.Windows.Forms.Label FixedLabel;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.Label RandomLabel;
        private System.Windows.Forms.TextBox minValue;
        private System.Windows.Forms.TextBox maxValue;
        private System.Windows.Forms.Label unit0;
        private System.Windows.Forms.Label hyphen;
        private System.Windows.Forms.CheckBox RandomMode;
        private System.Windows.Forms.CheckBox DisplayCPS;
        private System.Windows.Forms.CheckedListBox ChecklistKeys;
        private System.Windows.Forms.CheckBox RightButton;
    }
}

