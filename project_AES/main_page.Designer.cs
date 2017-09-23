namespace project_AES
{
    partial class main_page
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
            this.lb_encinput = new System.Windows.Forms.Label();
            this.tb_encinput = new System.Windows.Forms.TextBox();
            this.lb_enckey = new System.Windows.Forms.Label();
            this.tb_enckey = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.tb_encoutput = new System.Windows.Forms.TextBox();
            this.lb_encoutput = new System.Windows.Forms.Label();
            this.lb_decinput = new System.Windows.Forms.Label();
            this.lb_deckey = new System.Windows.Forms.Label();
            this.tb_decinput = new System.Windows.Forms.TextBox();
            this.tb_deckey = new System.Windows.Forms.TextBox();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.tb_decoutput = new System.Windows.Forms.TextBox();
            this.lb_decoutput = new System.Windows.Forms.Label();
            this.cb_bitsize = new System.Windows.Forms.ComboBox();
            this.lb_Enc = new System.Windows.Forms.Label();
            this.lb_Dec = new System.Windows.Forms.Label();
            this.lb_size = new System.Windows.Forms.Label();
            this.lb_iformat = new System.Windows.Forms.Label();
            this.cb_iformat = new System.Windows.Forms.ComboBox();
            this.lb_selectfile = new System.Windows.Forms.Label();
            this.tb_selectfile = new System.Windows.Forms.TextBox();
            this.btn_selectfile = new System.Windows.Forms.Button();
            this.btn_enc_file = new System.Windows.Forms.Button();
            this.btn_dec_file = new System.Windows.Forms.Button();
            this.ofd_selectfile = new System.Windows.Forms.OpenFileDialog();
            this.tb_file_key = new System.Windows.Forms.TextBox();
            this.lb_file_key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_encinput
            // 
            this.lb_encinput.AutoSize = true;
            this.lb_encinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_encinput.Location = new System.Drawing.Point(23, 45);
            this.lb_encinput.Name = "lb_encinput";
            this.lb_encinput.Size = new System.Drawing.Size(61, 24);
            this.lb_encinput.TabIndex = 0;
            this.lb_encinput.Text = "Input :";
            // 
            // tb_encinput
            // 
            this.tb_encinput.Location = new System.Drawing.Point(90, 47);
            this.tb_encinput.Name = "tb_encinput";
            this.tb_encinput.Size = new System.Drawing.Size(240, 20);
            this.tb_encinput.TabIndex = 1;
            // 
            // lb_enckey
            // 
            this.lb_enckey.AutoSize = true;
            this.lb_enckey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_enckey.Location = new System.Drawing.Point(32, 69);
            this.lb_enckey.Name = "lb_enckey";
            this.lb_enckey.Size = new System.Drawing.Size(52, 24);
            this.lb_enckey.TabIndex = 2;
            this.lb_enckey.Text = "Key :";
            // 
            // tb_enckey
            // 
            this.tb_enckey.Location = new System.Drawing.Point(90, 73);
            this.tb_enckey.Name = "tb_enckey";
            this.tb_enckey.Size = new System.Drawing.Size(240, 20);
            this.tb_enckey.TabIndex = 3;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(110, 99);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(121, 23);
            this.btn_encrypt.TabIndex = 4;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // tb_encoutput
            // 
            this.tb_encoutput.Location = new System.Drawing.Point(27, 152);
            this.tb_encoutput.Name = "tb_encoutput";
            this.tb_encoutput.Size = new System.Drawing.Size(303, 20);
            this.tb_encoutput.TabIndex = 5;
            // 
            // lb_encoutput
            // 
            this.lb_encoutput.AutoSize = true;
            this.lb_encoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_encoutput.Location = new System.Drawing.Point(23, 125);
            this.lb_encoutput.Name = "lb_encoutput";
            this.lb_encoutput.Size = new System.Drawing.Size(167, 24);
            this.lb_encoutput.TabIndex = 6;
            this.lb_encoutput.Text = "Encrypted Output :";
            // 
            // lb_decinput
            // 
            this.lb_decinput.AutoSize = true;
            this.lb_decinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_decinput.Location = new System.Drawing.Point(23, 238);
            this.lb_decinput.Name = "lb_decinput";
            this.lb_decinput.Size = new System.Drawing.Size(61, 24);
            this.lb_decinput.TabIndex = 7;
            this.lb_decinput.Text = "Input :";
            // 
            // lb_deckey
            // 
            this.lb_deckey.AutoSize = true;
            this.lb_deckey.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_deckey.Location = new System.Drawing.Point(32, 262);
            this.lb_deckey.Name = "lb_deckey";
            this.lb_deckey.Size = new System.Drawing.Size(52, 24);
            this.lb_deckey.TabIndex = 8;
            this.lb_deckey.Text = "Key :";
            // 
            // tb_decinput
            // 
            this.tb_decinput.Location = new System.Drawing.Point(90, 243);
            this.tb_decinput.Name = "tb_decinput";
            this.tb_decinput.Size = new System.Drawing.Size(239, 20);
            this.tb_decinput.TabIndex = 9;
            // 
            // tb_deckey
            // 
            this.tb_deckey.Location = new System.Drawing.Point(90, 269);
            this.tb_deckey.Name = "tb_deckey";
            this.tb_deckey.Size = new System.Drawing.Size(239, 20);
            this.tb_deckey.TabIndex = 10;
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(110, 295);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(121, 23);
            this.btn_decrypt.TabIndex = 11;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // tb_decoutput
            // 
            this.tb_decoutput.Location = new System.Drawing.Point(27, 363);
            this.tb_decoutput.Name = "tb_decoutput";
            this.tb_decoutput.Size = new System.Drawing.Size(303, 20);
            this.tb_decoutput.TabIndex = 12;
            // 
            // lb_decoutput
            // 
            this.lb_decoutput.AutoSize = true;
            this.lb_decoutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_decoutput.Location = new System.Drawing.Point(23, 336);
            this.lb_decoutput.Name = "lb_decoutput";
            this.lb_decoutput.Size = new System.Drawing.Size(167, 24);
            this.lb_decoutput.TabIndex = 13;
            this.lb_decoutput.Text = "Decrypted Output :";
            // 
            // cb_bitsize
            // 
            this.cb_bitsize.FormattingEnabled = true;
            this.cb_bitsize.Items.AddRange(new object[] {
            "AES - 128",
            "AES - 192",
            "AES - 256"});
            this.cb_bitsize.Location = new System.Drawing.Point(403, 74);
            this.cb_bitsize.Name = "cb_bitsize";
            this.cb_bitsize.Size = new System.Drawing.Size(121, 21);
            this.cb_bitsize.TabIndex = 14;
            this.cb_bitsize.Text = "----------- Select -----------";
            // 
            // lb_Enc
            // 
            this.lb_Enc.AutoSize = true;
            this.lb_Enc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Enc.Location = new System.Drawing.Point(23, 9);
            this.lb_Enc.Name = "lb_Enc";
            this.lb_Enc.Size = new System.Drawing.Size(105, 24);
            this.lb_Enc.TabIndex = 15;
            this.lb_Enc.Text = "Encryption:";
            // 
            // lb_Dec
            // 
            this.lb_Dec.AutoSize = true;
            this.lb_Dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Dec.Location = new System.Drawing.Point(23, 200);
            this.lb_Dec.Name = "lb_Dec";
            this.lb_Dec.Size = new System.Drawing.Size(105, 24);
            this.lb_Dec.TabIndex = 16;
            this.lb_Dec.Text = "Decryption:";
            // 
            // lb_size
            // 
            this.lb_size.AutoSize = true;
            this.lb_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_size.Location = new System.Drawing.Point(416, 42);
            this.lb_size.Name = "lb_size";
            this.lb_size.Size = new System.Drawing.Size(85, 24);
            this.lb_size.TabIndex = 17;
            this.lb_size.Text = "Key size:";
            // 
            // lb_iformat
            // 
            this.lb_iformat.AutoSize = true;
            this.lb_iformat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_iformat.Location = new System.Drawing.Point(412, 112);
            this.lb_iformat.Name = "lb_iformat";
            this.lb_iformat.Size = new System.Drawing.Size(112, 24);
            this.lb_iformat.TabIndex = 18;
            this.lb_iformat.Text = "Input format:";
            // 
            // cb_iformat
            // 
            this.cb_iformat.FormattingEnabled = true;
            this.cb_iformat.Items.AddRange(new object[] {
            "PlainText",
            "Text"});
            this.cb_iformat.Location = new System.Drawing.Point(403, 152);
            this.cb_iformat.Name = "cb_iformat";
            this.cb_iformat.Size = new System.Drawing.Size(121, 21);
            this.cb_iformat.TabIndex = 19;
            this.cb_iformat.Text = "----------- Select -----------";
            // 
            // lb_selectfile
            // 
            this.lb_selectfile.AutoSize = true;
            this.lb_selectfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_selectfile.Location = new System.Drawing.Point(416, 219);
            this.lb_selectfile.Name = "lb_selectfile";
            this.lb_selectfile.Size = new System.Drawing.Size(95, 24);
            this.lb_selectfile.TabIndex = 20;
            this.lb_selectfile.Text = "Select file:";
            // 
            // tb_selectfile
            // 
            this.tb_selectfile.Location = new System.Drawing.Point(403, 256);
            this.tb_selectfile.Name = "tb_selectfile";
            this.tb_selectfile.Size = new System.Drawing.Size(120, 20);
            this.tb_selectfile.TabIndex = 21;
            // 
            // btn_selectfile
            // 
            this.btn_selectfile.Location = new System.Drawing.Point(529, 254);
            this.btn_selectfile.Name = "btn_selectfile";
            this.btn_selectfile.Size = new System.Drawing.Size(27, 23);
            this.btn_selectfile.TabIndex = 22;
            this.btn_selectfile.Text = "...";
            this.btn_selectfile.UseVisualStyleBackColor = true;
            this.btn_selectfile.Click += new System.EventHandler(this.btn_selectfile_Click);
            // 
            // btn_enc_file
            // 
            this.btn_enc_file.Location = new System.Drawing.Point(420, 314);
            this.btn_enc_file.Name = "btn_enc_file";
            this.btn_enc_file.Size = new System.Drawing.Size(121, 23);
            this.btn_enc_file.TabIndex = 23;
            this.btn_enc_file.Text = "Encrypt";
            this.btn_enc_file.UseVisualStyleBackColor = true;
            this.btn_enc_file.Click += new System.EventHandler(this.btn_enc_file_Click);
            // 
            // btn_dec_file
            // 
            this.btn_dec_file.Location = new System.Drawing.Point(420, 343);
            this.btn_dec_file.Name = "btn_dec_file";
            this.btn_dec_file.Size = new System.Drawing.Size(121, 23);
            this.btn_dec_file.TabIndex = 24;
            this.btn_dec_file.Text = "Decrypt";
            this.btn_dec_file.UseVisualStyleBackColor = true;
            this.btn_dec_file.Click += new System.EventHandler(this.btn_dec_file_Click);
            // 
            // tb_file_key
            // 
            this.tb_file_key.Location = new System.Drawing.Point(387, 288);
            this.tb_file_key.Name = "tb_file_key";
            this.tb_file_key.Size = new System.Drawing.Size(187, 20);
            this.tb_file_key.TabIndex = 25;
            // 
            // lb_file_key
            // 
            this.lb_file_key.AutoSize = true;
            this.lb_file_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_file_key.Location = new System.Drawing.Point(335, 283);
            this.lb_file_key.Name = "lb_file_key";
            this.lb_file_key.Size = new System.Drawing.Size(52, 24);
            this.lb_file_key.TabIndex = 26;
            this.lb_file_key.Text = "Key :";
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 406);
            this.Controls.Add(this.lb_file_key);
            this.Controls.Add(this.tb_file_key);
            this.Controls.Add(this.btn_dec_file);
            this.Controls.Add(this.btn_enc_file);
            this.Controls.Add(this.btn_selectfile);
            this.Controls.Add(this.tb_selectfile);
            this.Controls.Add(this.lb_selectfile);
            this.Controls.Add(this.cb_iformat);
            this.Controls.Add(this.lb_iformat);
            this.Controls.Add(this.lb_size);
            this.Controls.Add(this.lb_Dec);
            this.Controls.Add(this.lb_Enc);
            this.Controls.Add(this.cb_bitsize);
            this.Controls.Add(this.lb_decoutput);
            this.Controls.Add(this.tb_decoutput);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.tb_deckey);
            this.Controls.Add(this.tb_decinput);
            this.Controls.Add(this.lb_deckey);
            this.Controls.Add(this.lb_decinput);
            this.Controls.Add(this.lb_encoutput);
            this.Controls.Add(this.tb_encoutput);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.tb_enckey);
            this.Controls.Add(this.lb_enckey);
            this.Controls.Add(this.tb_encinput);
            this.Controls.Add(this.lb_encinput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "main_page";
            this.Text = "AES Encryptor & Decryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_encinput;
        private System.Windows.Forms.TextBox tb_encinput;
        private System.Windows.Forms.Label lb_enckey;
        private System.Windows.Forms.TextBox tb_enckey;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.TextBox tb_encoutput;
        private System.Windows.Forms.Label lb_encoutput;
        private System.Windows.Forms.Label lb_decinput;
        private System.Windows.Forms.Label lb_deckey;
        private System.Windows.Forms.TextBox tb_decinput;
        private System.Windows.Forms.TextBox tb_deckey;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox tb_decoutput;
        private System.Windows.Forms.Label lb_decoutput;
        private System.Windows.Forms.ComboBox cb_bitsize;
        private System.Windows.Forms.Label lb_Enc;
        private System.Windows.Forms.Label lb_Dec;
        private System.Windows.Forms.Label lb_size;
        private System.Windows.Forms.Label lb_iformat;
        private System.Windows.Forms.ComboBox cb_iformat;
        private System.Windows.Forms.Label lb_selectfile;
        private System.Windows.Forms.TextBox tb_selectfile;
        private System.Windows.Forms.Button btn_selectfile;
        private System.Windows.Forms.Button btn_enc_file;
        private System.Windows.Forms.Button btn_dec_file;
        private System.Windows.Forms.OpenFileDialog ofd_selectfile;
        private System.Windows.Forms.TextBox tb_file_key;
        private System.Windows.Forms.Label lb_file_key;
    }
}

