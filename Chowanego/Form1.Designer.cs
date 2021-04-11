
namespace Chowanego
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
            this.description = new System.Windows.Forms.TextBox();
            this.exits = new System.Windows.Forms.ComboBox();
            this.goHere = new System.Windows.Forms.Button();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // description
            // 
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(391, 252);
            this.description.TabIndex = 0;
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(120, 270);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(283, 21);
            this.exits.TabIndex = 1;
            // 
            // goHere
            // 
            this.goHere.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goHere.Location = new System.Drawing.Point(12, 270);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(102, 23);
            this.goHere.TabIndex = 2;
            this.goHere.Text = "Idź tutaj:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.goThroughTheDoor.Location = new System.Drawing.Point(12, 298);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(391, 23);
            this.goThroughTheDoor.TabIndex = 3;
            this.goThroughTheDoor.Text = "Przejdź przez drzwi";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // check
            // 
            this.check.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.check.Location = new System.Drawing.Point(12, 328);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(391, 23);
            this.check.TabIndex = 4;
            this.check.Text = "Sprawdź";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.hide.Location = new System.Drawing.Point(12, 357);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(391, 23);
            this.hide.TabIndex = 5;
            this.hide.Text = "Kryj się!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(415, 391);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.description);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Chowanego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
    }
}

