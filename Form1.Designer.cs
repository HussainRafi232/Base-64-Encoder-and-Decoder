namespace Base64
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.encodeRadioButton = new System.Windows.Forms.RadioButton();
            this.decodeRadioButton = new System.Windows.Forms.RadioButton();
            this.Enter = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.autocopyCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.copyAlert = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base 64 Encode and Decode";
            // 
            // encodeRadioButton
            // 
            this.encodeRadioButton.AutoSize = true;
            this.encodeRadioButton.Checked = true;
            this.encodeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeRadioButton.Location = new System.Drawing.Point(8, 16);
            this.encodeRadioButton.Name = "encodeRadioButton";
            this.encodeRadioButton.Size = new System.Drawing.Size(82, 24);
            this.encodeRadioButton.TabIndex = 1;
            this.encodeRadioButton.TabStop = true;
            this.encodeRadioButton.Text = "Encode";
            this.encodeRadioButton.UseVisualStyleBackColor = true;
            this.encodeRadioButton.CheckedChanged += new System.EventHandler(this.encodeRadioButton_CheckedChanged);
            // 
            // decodeRadioButton
            // 
            this.decodeRadioButton.AutoSize = true;
            this.decodeRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeRadioButton.Location = new System.Drawing.Point(121, 16);
            this.decodeRadioButton.Name = "decodeRadioButton";
            this.decodeRadioButton.Size = new System.Drawing.Size(83, 24);
            this.decodeRadioButton.TabIndex = 1;
            this.decodeRadioButton.Text = "Decode";
            this.decodeRadioButton.UseVisualStyleBackColor = true;
            this.decodeRadioButton.CheckedChanged += new System.EventHandler(this.decodeRadioButton_CheckedChanged);
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter.Location = new System.Drawing.Point(37, 152);
            this.Enter.Multiline = true;
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(361, 104);
            this.Enter.TabIndex = 0;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(37, 282);
            this.Result.Multiline = true;
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(361, 91);
            this.Result.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Result";
            // 
            // copyButton
            // 
            this.copyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.Location = new System.Drawing.Point(213, 410);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(171, 39);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "Copy to Clipboard";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(36, 410);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(171, 39);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // autocopyCheckBox
            // 
            this.autocopyCheckBox.AutoSize = true;
            this.autocopyCheckBox.Checked = true;
            this.autocopyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autocopyCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autocopyCheckBox.Location = new System.Drawing.Point(100, 122);
            this.autocopyCheckBox.Name = "autocopyCheckBox";
            this.autocopyCheckBox.Size = new System.Drawing.Size(201, 24);
            this.autocopyCheckBox.TabIndex = 5;
            this.autocopyCheckBox.Text = "Copy to Clipboard (Auto)";
            this.autocopyCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.decodeRadioButton);
            this.groupBox1.Controls.Add(this.encodeRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(100, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // copyAlert
            // 
            this.copyAlert.AutoSize = true;
            this.copyAlert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyAlert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.copyAlert.Location = new System.Drawing.Point(40, 383);
            this.copyAlert.Name = "copyAlert";
            this.copyAlert.Size = new System.Drawing.Size(44, 19);
            this.copyAlert.TabIndex = 7;
            this.copyAlert.Text = "Alert";
            // 
            // timer2
            // 
            this.timer2.Interval = 30000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.copyAlert);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.autocopyCheckBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 500);
            this.MinimumSize = new System.Drawing.Size(450, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base 64 Encode & Decode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton encodeRadioButton;
        private System.Windows.Forms.RadioButton decodeRadioButton;
        private System.Windows.Forms.TextBox Enter;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.CheckBox autocopyCheckBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label copyAlert;
        private System.Windows.Forms.Timer timer2;
    }
}

