
namespace WindowsFormsApplication1
{
    partial class FormAddCaptain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddCaptain));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_capname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_boatname = new System.Windows.Forms.TextBox();
            this.txt_licenseId = new System.Windows.Forms.TextBox();
            this.txt_fishingGround = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cbox_capname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            this.link_add = new System.Windows.Forms.LinkLabel();
            this.link_edit = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pic_close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(14)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(211, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boat Captain Record";
            // 
            // txt_capname
            // 
            this.txt_capname.Location = new System.Drawing.Point(127, 146);
            this.txt_capname.Name = "txt_capname";
            this.txt_capname.Size = new System.Drawing.Size(170, 20);
            this.txt_capname.TabIndex = 1;
            this.txt_capname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Captain Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Boat Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "License Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fishing Ground:";
            // 
            // txt_boatname
            // 
            this.txt_boatname.Location = new System.Drawing.Point(127, 179);
            this.txt_boatname.Name = "txt_boatname";
            this.txt_boatname.Size = new System.Drawing.Size(170, 20);
            this.txt_boatname.TabIndex = 1;
            this.txt_boatname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_licenseId
            // 
            this.txt_licenseId.Location = new System.Drawing.Point(127, 209);
            this.txt_licenseId.Name = "txt_licenseId";
            this.txt_licenseId.Size = new System.Drawing.Size(170, 20);
            this.txt_licenseId.TabIndex = 1;
            this.txt_licenseId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_fishingGround
            // 
            this.txt_fishingGround.Location = new System.Drawing.Point(127, 244);
            this.txt_fishingGround.Name = "txt_fishingGround";
            this.txt_fishingGround.Size = new System.Drawing.Size(170, 20);
            this.txt_fishingGround.TabIndex = 1;
            this.txt_fishingGround.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_cancel.Location = new System.Drawing.Point(141, 280);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(222, 280);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 38);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            // 
            // cbox_capname
            // 
            this.cbox_capname.FormattingEnabled = true;
            this.cbox_capname.Location = new System.Drawing.Point(122, 64);
            this.cbox_capname.Name = "cbox_capname";
            this.cbox_capname.Size = new System.Drawing.Size(170, 21);
            this.cbox_capname.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Captain Name:";
            // 
            // btn_done
            // 
            this.btn_done.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_done.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_done.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_done.Location = new System.Drawing.Point(217, 91);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(77, 38);
            this.btn_done.TabIndex = 6;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = false;
            // 
            // link_add
            // 
            this.link_add.AutoSize = true;
            this.link_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_add.Location = new System.Drawing.Point(122, 88);
            this.link_add.Name = "link_add";
            this.link_add.Size = new System.Drawing.Size(29, 13);
            this.link_add.TabIndex = 7;
            this.link_add.TabStop = true;
            this.link_add.Text = "Add";
            this.link_add.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_add_LinkClicked);
            // 
            // link_edit
            // 
            this.link_edit.AutoSize = true;
            this.link_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_edit.Location = new System.Drawing.Point(162, 88);
            this.link_edit.Name = "link_edit";
            this.link_edit.Size = new System.Drawing.Size(29, 13);
            this.link_edit.TabIndex = 7;
            this.link_edit.TabStop = true;
            this.link_edit.Text = "Edit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(151, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "/";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(122, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "________________________";
            // 
            // pic_close
            // 
            this.pic_close.Image = global::WindowsFormsApplication1.Properties.Resources.close_button_png_30225;
            this.pic_close.InitialImage = global::WindowsFormsApplication1.Properties.Resources.close_button_png_30225;
            this.pic_close.Location = new System.Drawing.Point(274, 6);
            this.pic_close.Name = "pic_close";
            this.pic_close.Size = new System.Drawing.Size(38, 33);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 9;
            this.pic_close.TabStop = false;
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            // 
            // FormAddCaptain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(319, 337);
            this.Controls.Add(this.pic_close);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.link_edit);
            this.Controls.Add(this.link_add);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.cbox_capname);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fishingGround);
            this.Controls.Add(this.txt_licenseId);
            this.Controls.Add(this.txt_boatname);
            this.Controls.Add(this.txt_capname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAddCaptain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddCaptain";
            this.Load += new System.EventHandler(this.FormAddCaptain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_capname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_boatname;
        private System.Windows.Forms.TextBox txt_licenseId;
        private System.Windows.Forms.TextBox txt_fishingGround;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cbox_capname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.LinkLabel link_add;
        private System.Windows.Forms.LinkLabel link_edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pic_close;
    }
}