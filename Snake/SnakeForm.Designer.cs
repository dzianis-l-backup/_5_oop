namespace _3_oop
{
    partial class SnakeForm
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
            this.fly = new System.Windows.Forms.CheckBox();
            this.submit = new System.Windows.Forms.Button();
            this.wings = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fly
            // 
            this.fly.AutoSize = true;
            this.fly.Location = new System.Drawing.Point(158, 71);
            this.fly.Name = "fly";
            this.fly.Size = new System.Drawing.Size(63, 17);
            this.fly.TabIndex = 49;
            this.fly.Text = "can fly?";
            this.fly.UseVisualStyleBackColor = true;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(12, 17);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(101, 71);
            this.submit.TabIndex = 48;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            // 
            // wings
            // 
            this.wings.Location = new System.Drawing.Point(158, 94);
            this.wings.Name = "wings";
            this.wings.Size = new System.Drawing.Size(100, 20);
            this.wings.TabIndex = 47;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(158, 39);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(100, 20);
            this.age.TabIndex = 46;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(158, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Quantity of wings";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "name";
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 124);
            this.Controls.Add(this.fly);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.wings);
            this.Controls.Add(this.age);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SnakeForm";
            this.Text = "SnakeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fly;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox wings;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}