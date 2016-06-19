namespace _3_oop
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this._Console = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Label();
            this.ChooseAnimal = new System.Windows.Forms.ComboBox();
            this.Serialize = new System.Windows.Forms.Button();
            this.Deserialize = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this._delete = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.ChangeProp = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.classSelection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.ser = new System.Windows.Forms.Button();
            this.des = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.format = new System.Windows.Forms.Button();
            this.formating = new System.Windows.Forms.ComboBox();
            this.listoxml = new System.Windows.Forms.Button();
            this.download = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _Console
            // 
            this._Console.Location = new System.Drawing.Point(12, 12);
            this._Console.Multiline = true;
            this._Console.Name = "_Console";
            this._Console.Size = new System.Drawing.Size(204, 292);
            this._Console.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Animal creation";
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.Location = new System.Drawing.Point(298, 45);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(69, 13);
            this.select.TabIndex = 9;
            this.select.Text = "Animal select";
            // 
            // ChooseAnimal
            // 
            this.ChooseAnimal.FormattingEnabled = true;
            this.ChooseAnimal.Location = new System.Drawing.Point(298, 66);
            this.ChooseAnimal.Name = "ChooseAnimal";
            this.ChooseAnimal.Size = new System.Drawing.Size(135, 21);
            this.ChooseAnimal.TabIndex = 10;
            this.ChooseAnimal.SelectedIndexChanged += new System.EventHandler(this._Delete_SelectedIndexChanged);
            // 
            // Serialize
            // 
            this.Serialize.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Serialize.Location = new System.Drawing.Point(225, 98);
            this.Serialize.Name = "Serialize";
            this.Serialize.Size = new System.Drawing.Size(92, 32);
            this.Serialize.TabIndex = 11;
            this.Serialize.Text = "Serialize";
            this.Serialize.UseVisualStyleBackColor = true;
            this.Serialize.Click += new System.EventHandler(this.Serialize_Click);
            // 
            // Deserialize
            // 
            this.Deserialize.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deserialize.Location = new System.Drawing.Point(341, 98);
            this.Deserialize.Name = "Deserialize";
            this.Deserialize.Size = new System.Drawing.Size(92, 32);
            this.Deserialize.TabIndex = 12;
            this.Deserialize.Text = "Deserialize";
            this.Deserialize.UseVisualStyleBackColor = true;
            this.Deserialize.Click += new System.EventHandler(this.Deserialize_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(817, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "_________________________________________________________________________________" +
    "______________________________________________________";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(553, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(323, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "/";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(228, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 47;
            this.label20.Text = "Swimmers";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(288, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Walkers";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(352, 16);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 13);
            this.label22.TabIndex = 49;
            this.label22.Text = "Flyers";
            // 
            // _delete
            // 
            this._delete.Location = new System.Drawing.Point(520, 45);
            this._delete.Name = "_delete";
            this._delete.Size = new System.Drawing.Size(50, 44);
            this._delete.TabIndex = 56;
            this._delete.Text = "delete";
            this._delete.UseVisualStyleBackColor = true;
            this._delete.Click += new System.EventHandler(this._delete_Click);
            // 
            // change
            // 
            this.change.Location = new System.Drawing.Point(439, 45);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(75, 44);
            this.change.TabIndex = 57;
            this.change.Text = "SelectForm";
            this.change.UseVisualStyleBackColor = true;
            this.change.Click += new System.EventHandler(this.change_Click);
            // 
            // ChangeProp
            // 
            this.ChangeProp.Location = new System.Drawing.Point(439, 95);
            this.ChangeProp.Multiline = true;
            this.ChangeProp.Name = "ChangeProp";
            this.ChangeProp.Size = new System.Drawing.Size(253, 209);
            this.ChangeProp.TabIndex = 58;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // classSelection
            // 
            this.classSelection.FormattingEnabled = true;
            this.classSelection.Location = new System.Drawing.Point(508, 16);
            this.classSelection.Name = "classSelection";
            this.classSelection.Size = new System.Drawing.Size(121, 21);
            this.classSelection.TabIndex = 67;
            this.classSelection.SelectedIndexChanged += new System.EventHandler(this.classSelection_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "Class selection";
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(636, 16);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(56, 23);
            this.create.TabIndex = 69;
            this.create.Text = "create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // ser
            // 
            this.ser.Location = new System.Drawing.Point(576, 45);
            this.ser.Name = "ser";
            this.ser.Size = new System.Drawing.Size(55, 44);
            this.ser.TabIndex = 70;
            this.ser.Text = "Ser";
            this.ser.UseVisualStyleBackColor = true;
            this.ser.Click += new System.EventHandler(this.ser_Click);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(637, 45);
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(55, 44);
            this.des.TabIndex = 71;
            this.des.Text = "Des";
            this.des.UseVisualStyleBackColor = true;
            this.des.Click += new System.EventHandler(this.des_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 42);
            this.button1.TabIndex = 62;
            this.button1.Text = "Load assembly";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // format
            // 
            this.format.Location = new System.Drawing.Point(227, 136);
            this.format.Name = "format";
            this.format.Size = new System.Drawing.Size(206, 39);
            this.format.TabIndex = 72;
            this.format.Text = "Load formatting pluggin";
            this.format.UseVisualStyleBackColor = true;
            this.format.Click += new System.EventHandler(this.format_Click);
            // 
            // formating
            // 
            this.formating.FormattingEnabled = true;
            this.formating.Location = new System.Drawing.Point(227, 181);
            this.formating.Name = "formating";
            this.formating.Size = new System.Drawing.Size(206, 21);
            this.formating.TabIndex = 73;
            this.formating.SelectedIndexChanged += new System.EventHandler(this.formating_SelectedIndexChanged);
            // 
            // listoxml
            // 
            this.listoxml.Location = new System.Drawing.Point(291, 208);
            this.listoxml.Name = "listoxml";
            this.listoxml.Size = new System.Drawing.Size(75, 39);
            this.listoxml.TabIndex = 75;
            this.listoxml.Text = "TO XML";
            this.listoxml.UseVisualStyleBackColor = true;
            this.listoxml.Click += new System.EventHandler(this.listoxml_Click);
            // 
            // download
            // 
            this.download.Location = new System.Drawing.Point(291, 253);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(75, 39);
            this.download.TabIndex = 76;
            this.download.Text = "download from file";
            this.download.UseVisualStyleBackColor = true;
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 316);
            this.Controls.Add(this.download);
            this.Controls.Add(this.listoxml);
            this.Controls.Add(this.formating);
            this.Controls.Add(this.format);
            this.Controls.Add(this.des);
            this.Controls.Add(this.ser);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.classSelection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChangeProp);
            this.Controls.Add(this.change);
            this.Controls.Add(this._delete);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Deserialize);
            this.Controls.Add(this.Serialize);
            this.Controls.Add(this.ChooseAnimal);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._Console);
            this.Name = "MainForm";
            this.Text = "Animal planet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _Console;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label select;
        private System.Windows.Forms.ComboBox ChooseAnimal;
        private System.Windows.Forms.Button Serialize;
        private System.Windows.Forms.Button Deserialize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button _delete;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.TextBox ChangeProp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox classSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Button ser;
        private System.Windows.Forms.Button des;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button format;
        private System.Windows.Forms.ComboBox formating;
        private System.Windows.Forms.Button listoxml;
        private System.Windows.Forms.Button download;
    }
}

