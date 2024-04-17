namespace Lab2b
{
    partial class HairSalon
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
            this.HairDresser = new System.Windows.Forms.GroupBox();
            this.Laura = new System.Windows.Forms.RadioButton();
            this.Sue = new System.Windows.Forms.RadioButton();
            this.Ron = new System.Windows.Forms.RadioButton();
            this.Pat = new System.Windows.Forms.RadioButton();
            this.Jane = new System.Windows.Forms.RadioButton();
            this.Services = new System.Windows.Forms.GroupBox();
            this.Extensions = new System.Windows.Forms.CheckBox();
            this.Highlights = new System.Windows.Forms.CheckBox();
            this.Colour = new System.Windows.Forms.CheckBox();
            this.Cut = new System.Windows.Forms.CheckBox();
            this.ClientType = new System.Windows.Forms.GroupBox();
            this.Senior = new System.Windows.Forms.RadioButton();
            this.Child = new System.Windows.Forms.RadioButton();
            this.Student = new System.Windows.Forms.RadioButton();
            this.Adult = new System.Windows.Forms.RadioButton();
            this.ClientVisit = new System.Windows.Forms.GroupBox();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.PriceOutput = new System.Windows.Forms.Label();
            this.CalculateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.HairDresser.SuspendLayout();
            this.Services.SuspendLayout();
            this.ClientType.SuspendLayout();
            this.ClientVisit.SuspendLayout();
            this.SuspendLayout();
            // 
            // HairDresser
            // 
            this.HairDresser.Controls.Add(this.Laura);
            this.HairDresser.Controls.Add(this.Sue);
            this.HairDresser.Controls.Add(this.Ron);
            this.HairDresser.Controls.Add(this.Pat);
            this.HairDresser.Controls.Add(this.Jane);
            this.HairDresser.Location = new System.Drawing.Point(14, 26);
            this.HairDresser.Margin = new System.Windows.Forms.Padding(5);
            this.HairDresser.Name = "HairDresser";
            this.HairDresser.Padding = new System.Windows.Forms.Padding(5);
            this.HairDresser.Size = new System.Drawing.Size(250, 261);
            this.HairDresser.TabIndex = 0;
            this.HairDresser.TabStop = false;
            this.HairDresser.Text = "Hairdresser";
            // 
            // Laura
            // 
            this.Laura.AutoSize = true;
            this.Laura.Location = new System.Drawing.Point(18, 205);
            this.Laura.Margin = new System.Windows.Forms.Padding(5);
            this.Laura.Name = "Laura";
            this.Laura.Size = new System.Drawing.Size(171, 29);
            this.Laura.TabIndex = 4;
            this.Laura.Text = "Laura Renkins";
            this.Laura.UseVisualStyleBackColor = true;
            // 
            // Sue
            // 
            this.Sue.AutoSize = true;
            this.Sue.Location = new System.Drawing.Point(18, 166);
            this.Sue.Margin = new System.Windows.Forms.Padding(5);
            this.Sue.Name = "Sue";
            this.Sue.Size = new System.Drawing.Size(138, 29);
            this.Sue.TabIndex = 3;
            this.Sue.Text = "Sue Pallon";
            this.Sue.UseVisualStyleBackColor = true;
            // 
            // Ron
            // 
            this.Ron.AutoSize = true;
            this.Ron.Location = new System.Drawing.Point(18, 127);
            this.Ron.Margin = new System.Windows.Forms.Padding(5);
            this.Ron.Name = "Ron";
            this.Ron.Size = new System.Drawing.Size(176, 29);
            this.Ron.TabIndex = 2;
            this.Ron.Text = "Ron Chambers";
            this.Ron.UseVisualStyleBackColor = true;
            // 
            // Pat
            // 
            this.Pat.AutoSize = true;
            this.Pat.Location = new System.Drawing.Point(18, 88);
            this.Pat.Margin = new System.Windows.Forms.Padding(5);
            this.Pat.Name = "Pat";
            this.Pat.Size = new System.Drawing.Size(154, 29);
            this.Pat.TabIndex = 1;
            this.Pat.Text = "Pat Johnson";
            this.Pat.UseVisualStyleBackColor = true;
            // 
            // Jane
            // 
            this.Jane.AutoSize = true;
            this.Jane.Checked = true;
            this.Jane.Location = new System.Drawing.Point(18, 49);
            this.Jane.Margin = new System.Windows.Forms.Padding(5);
            this.Jane.Name = "Jane";
            this.Jane.Size = new System.Drawing.Size(159, 29);
            this.Jane.TabIndex = 0;
            this.Jane.TabStop = true;
            this.Jane.Text = "Jane Samley";
            this.Jane.UseVisualStyleBackColor = true;
            // 
            // Services
            // 
            this.Services.Controls.Add(this.Extensions);
            this.Services.Controls.Add(this.Highlights);
            this.Services.Controls.Add(this.Colour);
            this.Services.Controls.Add(this.Cut);
            this.Services.Location = new System.Drawing.Point(284, 26);
            this.Services.Margin = new System.Windows.Forms.Padding(5);
            this.Services.Name = "Services";
            this.Services.Padding = new System.Windows.Forms.Padding(5);
            this.Services.Size = new System.Drawing.Size(259, 240);
            this.Services.TabIndex = 1;
            this.Services.TabStop = false;
            this.Services.Text = "Services";
            // 
            // Extensions
            // 
            this.Extensions.AutoSize = true;
            this.Extensions.Location = new System.Drawing.Point(26, 170);
            this.Extensions.Name = "Extensions";
            this.Extensions.Size = new System.Drawing.Size(140, 29);
            this.Extensions.TabIndex = 3;
            this.Extensions.Text = "Extensions";
            this.Extensions.UseVisualStyleBackColor = true;
            // 
            // Highlights
            // 
            this.Highlights.AutoSize = true;
            this.Highlights.Location = new System.Drawing.Point(26, 131);
            this.Highlights.Name = "Highlights";
            this.Highlights.Size = new System.Drawing.Size(129, 29);
            this.Highlights.TabIndex = 2;
            this.Highlights.Text = "Highlights";
            this.Highlights.UseVisualStyleBackColor = true;
            // 
            // Colour
            // 
            this.Colour.AutoSize = true;
            this.Colour.Location = new System.Drawing.Point(26, 89);
            this.Colour.Name = "Colour";
            this.Colour.Size = new System.Drawing.Size(98, 29);
            this.Colour.TabIndex = 1;
            this.Colour.Text = "Colour";
            this.Colour.UseVisualStyleBackColor = true;
            // 
            // Cut
            // 
            this.Cut.AutoSize = true;
            this.Cut.Location = new System.Drawing.Point(26, 49);
            this.Cut.Name = "Cut";
            this.Cut.Size = new System.Drawing.Size(68, 29);
            this.Cut.TabIndex = 0;
            this.Cut.Text = "Cut";
            this.Cut.UseVisualStyleBackColor = true;
            // 
            // ClientType
            // 
            this.ClientType.Controls.Add(this.Senior);
            this.ClientType.Controls.Add(this.Child);
            this.ClientType.Controls.Add(this.Student);
            this.ClientType.Controls.Add(this.Adult);
            this.ClientType.Location = new System.Drawing.Point(14, 320);
            this.ClientType.Margin = new System.Windows.Forms.Padding(5);
            this.ClientType.Name = "ClientType";
            this.ClientType.Padding = new System.Windows.Forms.Padding(5);
            this.ClientType.Size = new System.Drawing.Size(250, 208);
            this.ClientType.TabIndex = 0;
            this.ClientType.TabStop = false;
            this.ClientType.Text = "Client Type";
            // 
            // Senior
            // 
            this.Senior.AutoSize = true;
            this.Senior.Location = new System.Drawing.Point(18, 153);
            this.Senior.Name = "Senior";
            this.Senior.Size = new System.Drawing.Size(190, 29);
            this.Senior.TabIndex = 3;
            this.Senior.Text = "Senior (over 65)";
            this.Senior.UseVisualStyleBackColor = true;
            // 
            // Child
            // 
            this.Child.AutoSize = true;
            this.Child.Location = new System.Drawing.Point(18, 83);
            this.Child.Name = "Child";
            this.Child.Size = new System.Drawing.Size(232, 29);
            this.Child.TabIndex = 2;
            this.Child.Text = "Child (12 and under)";
            this.Child.UseVisualStyleBackColor = true;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(18, 118);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(108, 29);
            this.Student.TabIndex = 1;
            this.Student.Text = "Student";
            this.Student.UseVisualStyleBackColor = true;
            // 
            // Adult
            // 
            this.Adult.AutoSize = true;
            this.Adult.Checked = true;
            this.Adult.Location = new System.Drawing.Point(18, 46);
            this.Adult.Margin = new System.Windows.Forms.Padding(5);
            this.Adult.Name = "Adult";
            this.Adult.Size = new System.Drawing.Size(177, 29);
            this.Adult.TabIndex = 0;
            this.Adult.TabStop = true;
            this.Adult.Text = "Standard Adult";
            this.Adult.UseVisualStyleBackColor = true;
            // 
            // ClientVisit
            // 
            this.ClientVisit.Controls.Add(this.ClientLabel);
            this.ClientVisit.Controls.Add(this.ClientTextBox);
            this.ClientVisit.Location = new System.Drawing.Point(284, 320);
            this.ClientVisit.Margin = new System.Windows.Forms.Padding(5);
            this.ClientVisit.Name = "ClientVisit";
            this.ClientVisit.Padding = new System.Windows.Forms.Padding(5);
            this.ClientVisit.Size = new System.Drawing.Size(259, 156);
            this.ClientVisit.TabIndex = 0;
            this.ClientVisit.TabStop = false;
            this.ClientVisit.Text = "Client Visits";
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(10, 46);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(239, 25);
            this.ClientLabel.TabIndex = 2;
            this.ClientLabel.Text = "Number of Client Visits:";
            this.ClientLabel.Click += new System.EventHandler(this.ClientLabel_Click);
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Location = new System.Drawing.Point(10, 82);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(239, 30);
            this.ClientTextBox.TabIndex = 1;
            this.ClientTextBox.TextChanged += new System.EventHandler(this.ClientTextBox_TextChanged);
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(178, 544);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(123, 25);
            this.TotalPrice.TabIndex = 2;
            this.TotalPrice.Text = "Total Price:";
            // 
            // PriceOutput
            // 
            this.PriceOutput.Location = new System.Drawing.Point(307, 544);
            this.PriceOutput.Name = "PriceOutput";
            this.PriceOutput.Size = new System.Drawing.Size(102, 31);
            this.PriceOutput.TabIndex = 3;
            // 
            // CalculateBtn
            // 
            this.CalculateBtn.Location = new System.Drawing.Point(32, 593);
            this.CalculateBtn.Name = "CalculateBtn";
            this.CalculateBtn.Size = new System.Drawing.Size(120, 43);
            this.CalculateBtn.TabIndex = 4;
            this.CalculateBtn.Text = "Calculate";
            this.CalculateBtn.UseVisualStyleBackColor = true;
            this.CalculateBtn.Click += new System.EventHandler(this.CalculateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(206, 593);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(120, 43);
            this.ClearBtn.TabIndex = 5;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(386, 593);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(120, 43);
            this.ExitBtn.TabIndex = 6;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // HairSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 669);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.CalculateBtn);
            this.Controls.Add(this.PriceOutput);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.ClientType);
            this.Controls.Add(this.ClientVisit);
            this.Controls.Add(this.Services);
            this.Controls.Add(this.HairDresser);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HairSalon";
            this.Text = " ";
            this.HairDresser.ResumeLayout(false);
            this.HairDresser.PerformLayout();
            this.Services.ResumeLayout(false);
            this.Services.PerformLayout();
            this.ClientType.ResumeLayout(false);
            this.ClientType.PerformLayout();
            this.ClientVisit.ResumeLayout(false);
            this.ClientVisit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox HairDresser;
        private System.Windows.Forms.GroupBox Services;
        private System.Windows.Forms.GroupBox ClientType;
        private System.Windows.Forms.GroupBox ClientVisit;
        private System.Windows.Forms.RadioButton Laura;
        private System.Windows.Forms.RadioButton Sue;
        private System.Windows.Forms.RadioButton Ron;
        private System.Windows.Forms.RadioButton Pat;
        private System.Windows.Forms.RadioButton Jane;
        private System.Windows.Forms.RadioButton Adult;
        private System.Windows.Forms.CheckBox Extensions;
        private System.Windows.Forms.CheckBox Highlights;
        private System.Windows.Forms.CheckBox Colour;
        private System.Windows.Forms.CheckBox Cut;
        private System.Windows.Forms.RadioButton Senior;
        private System.Windows.Forms.RadioButton Child;
        private System.Windows.Forms.RadioButton Student;
        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Label PriceOutput;
        private System.Windows.Forms.Button CalculateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

