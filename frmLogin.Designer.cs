namespace WindowsFormsLogin
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfermaPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelRegione = new System.Windows.Forms.Label();
            this.comboBoxRegione = new System.Windows.Forms.ComboBox();
            this.comboBoxProvincia = new System.Windows.Forms.ComboBox();
            this.labelProvincia = new System.Windows.Forms.Label();
            this.comboBoxComune = new System.Windows.Forms.ComboBox();
            this.labelComune = new System.Windows.Forms.Label();
            this.buttonJson = new System.Windows.Forms.Button();
            this.buttonObject = new System.Windows.Forms.Button();
            this.saveFileDialogJson = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogJson = new System.Windows.Forms.OpenFileDialog();
            this.buttonObjectProvincia = new System.Windows.Forms.Button();
            this.buttonJsonProvincia = new System.Windows.Forms.Button();
            this.buttonObjectComune = new System.Windows.Forms.Button();
            this.buttonJsonComune = new System.Windows.Forms.Button();
            this.buttonObjectComuneByte = new System.Windows.Forms.Button();
            this.buttonJsonComuneByte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 125);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Conferma Password:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(373, 58);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(671, 35);
            this.textBoxUsername.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(373, 116);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(671, 35);
            this.textBoxPassword.TabIndex = 4;
            // 
            // textBoxConfermaPassword
            // 
            this.textBoxConfermaPassword.Location = new System.Drawing.Point(373, 194);
            this.textBoxConfermaPassword.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxConfermaPassword.Name = "textBoxConfermaPassword";
            this.textBoxConfermaPassword.PasswordChar = '*';
            this.textBoxConfermaPassword.Size = new System.Drawing.Size(671, 35);
            this.textBoxConfermaPassword.TabIndex = 5;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(1244, 91);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(371, 96);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 680);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Result:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(89, 736);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(1717, 417);
            this.textBoxResult.TabIndex = 8;
            // 
            // labelRegione
            // 
            this.labelRegione.AutoSize = true;
            this.labelRegione.Location = new System.Drawing.Point(82, 344);
            this.labelRegione.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelRegione.Name = "labelRegione";
            this.labelRegione.Size = new System.Drawing.Size(111, 29);
            this.labelRegione.TabIndex = 9;
            this.labelRegione.Text = "Regione:";
            // 
            // comboBoxRegione
            // 
            this.comboBoxRegione.FormattingEnabled = true;
            this.comboBoxRegione.Location = new System.Drawing.Point(373, 337);
            this.comboBoxRegione.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxRegione.Name = "comboBoxRegione";
            this.comboBoxRegione.Size = new System.Drawing.Size(671, 37);
            this.comboBoxRegione.TabIndex = 10;
            this.comboBoxRegione.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegione_SelectedIndexChanged);
            // 
            // comboBoxProvincia
            // 
            this.comboBoxProvincia.FormattingEnabled = true;
            this.comboBoxProvincia.Location = new System.Drawing.Point(373, 419);
            this.comboBoxProvincia.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxProvincia.Name = "comboBoxProvincia";
            this.comboBoxProvincia.Size = new System.Drawing.Size(671, 37);
            this.comboBoxProvincia.TabIndex = 12;
            this.comboBoxProvincia.SelectedIndexChanged += new System.EventHandler(this.comboBoxProvincia_SelectedIndexChanged);
            // 
            // labelProvincia
            // 
            this.labelProvincia.AutoSize = true;
            this.labelProvincia.Location = new System.Drawing.Point(82, 426);
            this.labelProvincia.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelProvincia.Name = "labelProvincia";
            this.labelProvincia.Size = new System.Drawing.Size(118, 29);
            this.labelProvincia.TabIndex = 11;
            this.labelProvincia.Text = "Provincia:";
            // 
            // comboBoxComune
            // 
            this.comboBoxComune.FormattingEnabled = true;
            this.comboBoxComune.Location = new System.Drawing.Point(373, 506);
            this.comboBoxComune.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.comboBoxComune.Name = "comboBoxComune";
            this.comboBoxComune.Size = new System.Drawing.Size(671, 37);
            this.comboBoxComune.TabIndex = 14;
            this.comboBoxComune.SelectedIndexChanged += new System.EventHandler(this.comboBoxComune_SelectedIndexChanged);
            // 
            // labelComune
            // 
            this.labelComune.AutoSize = true;
            this.labelComune.Location = new System.Drawing.Point(82, 513);
            this.labelComune.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelComune.Name = "labelComune";
            this.labelComune.Size = new System.Drawing.Size(110, 29);
            this.labelComune.TabIndex = 13;
            this.labelComune.Text = "Comune:";
            // 
            // buttonJson
            // 
            this.buttonJson.Location = new System.Drawing.Point(1104, 337);
            this.buttonJson.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonJson.Name = "buttonJson";
            this.buttonJson.Size = new System.Drawing.Size(278, 51);
            this.buttonJson.TabIndex = 15;
            this.buttonJson.Text = "Serialize in JSON";
            this.buttonJson.UseVisualStyleBackColor = true;
            this.buttonJson.Click += new System.EventHandler(this.buttonJson_Click);
            // 
            // buttonObject
            // 
            this.buttonObject.Location = new System.Drawing.Point(1440, 337);
            this.buttonObject.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonObject.Name = "buttonObject";
            this.buttonObject.Size = new System.Drawing.Size(371, 51);
            this.buttonObject.TabIndex = 16;
            this.buttonObject.Text = "Deserialize FROM JSON";
            this.buttonObject.UseVisualStyleBackColor = true;
            this.buttonObject.Click += new System.EventHandler(this.buttonObject_Click);
            // 
            // buttonObjectProvincia
            // 
            this.buttonObjectProvincia.Location = new System.Drawing.Point(1440, 419);
            this.buttonObjectProvincia.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonObjectProvincia.Name = "buttonObjectProvincia";
            this.buttonObjectProvincia.Size = new System.Drawing.Size(371, 51);
            this.buttonObjectProvincia.TabIndex = 18;
            this.buttonObjectProvincia.Text = "Deserialize FROM JSON";
            this.buttonObjectProvincia.UseVisualStyleBackColor = true;
            this.buttonObjectProvincia.Click += new System.EventHandler(this.buttonObjectProvincia_Click);
            // 
            // buttonJsonProvincia
            // 
            this.buttonJsonProvincia.Location = new System.Drawing.Point(1104, 419);
            this.buttonJsonProvincia.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonJsonProvincia.Name = "buttonJsonProvincia";
            this.buttonJsonProvincia.Size = new System.Drawing.Size(278, 51);
            this.buttonJsonProvincia.TabIndex = 17;
            this.buttonJsonProvincia.Text = "Serialize in JSON";
            this.buttonJsonProvincia.UseVisualStyleBackColor = true;
            this.buttonJsonProvincia.Click += new System.EventHandler(this.buttonJsonProvincia_Click);
            // 
            // buttonObjectComune
            // 
            this.buttonObjectComune.Location = new System.Drawing.Point(1440, 502);
            this.buttonObjectComune.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonObjectComune.Name = "buttonObjectComune";
            this.buttonObjectComune.Size = new System.Drawing.Size(371, 51);
            this.buttonObjectComune.TabIndex = 20;
            this.buttonObjectComune.Text = "Deserialize FROM JSON";
            this.buttonObjectComune.UseVisualStyleBackColor = true;
            this.buttonObjectComune.Click += new System.EventHandler(this.buttonObjectComune_Click);
            // 
            // buttonJsonComune
            // 
            this.buttonJsonComune.Location = new System.Drawing.Point(1104, 502);
            this.buttonJsonComune.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.buttonJsonComune.Name = "buttonJsonComune";
            this.buttonJsonComune.Size = new System.Drawing.Size(278, 51);
            this.buttonJsonComune.TabIndex = 19;
            this.buttonJsonComune.Text = "Serialize in JSON";
            this.buttonJsonComune.UseVisualStyleBackColor = true;
            this.buttonJsonComune.Click += new System.EventHandler(this.buttonJsonComune_Click);
            // 
            // buttonObjectComuneByte
            // 
            this.buttonObjectComuneByte.Location = new System.Drawing.Point(1440, 580);
            this.buttonObjectComuneByte.Margin = new System.Windows.Forms.Padding(7);
            this.buttonObjectComuneByte.Name = "buttonObjectComuneByte";
            this.buttonObjectComuneByte.Size = new System.Drawing.Size(371, 51);
            this.buttonObjectComuneByte.TabIndex = 22;
            this.buttonObjectComuneByte.Text = "Byte[] Deserialize FROM JSON";
            this.buttonObjectComuneByte.UseVisualStyleBackColor = true;
            this.buttonObjectComuneByte.Click += new System.EventHandler(this.buttonObjectComuneByte_Click);
            // 
            // buttonJsonComuneByte
            // 
            this.buttonJsonComuneByte.Location = new System.Drawing.Point(1104, 580);
            this.buttonJsonComuneByte.Margin = new System.Windows.Forms.Padding(7);
            this.buttonJsonComuneByte.Name = "buttonJsonComuneByte";
            this.buttonJsonComuneByte.Size = new System.Drawing.Size(278, 51);
            this.buttonJsonComuneByte.TabIndex = 21;
            this.buttonJsonComuneByte.Text = "Byte[] Serialize in JSON";
            this.buttonJsonComuneByte.UseVisualStyleBackColor = true;
            this.buttonJsonComuneByte.Click += new System.EventHandler(this.buttonJsonComuneByte_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 1185);
            this.Controls.Add(this.buttonObjectComuneByte);
            this.Controls.Add(this.buttonJsonComuneByte);
            this.Controls.Add(this.buttonObjectComune);
            this.Controls.Add(this.buttonJsonComune);
            this.Controls.Add(this.buttonObjectProvincia);
            this.Controls.Add(this.buttonJsonProvincia);
            this.Controls.Add(this.buttonObject);
            this.Controls.Add(this.buttonJson);
            this.Controls.Add(this.comboBoxComune);
            this.Controls.Add(this.labelComune);
            this.Controls.Add(this.comboBoxProvincia);
            this.Controls.Add(this.labelProvincia);
            this.Controls.Add(this.comboBoxRegione);
            this.Controls.Add(this.labelRegione);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxConfermaPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfermaPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelRegione;
        private System.Windows.Forms.ComboBox comboBoxRegione;
        private System.Windows.Forms.ComboBox comboBoxProvincia;
        private System.Windows.Forms.Label labelProvincia;
        private System.Windows.Forms.ComboBox comboBoxComune;
        private System.Windows.Forms.Label labelComune;
        private System.Windows.Forms.Button buttonJson;
        private System.Windows.Forms.Button buttonObject;
        private System.Windows.Forms.SaveFileDialog saveFileDialogJson;
        private System.Windows.Forms.OpenFileDialog openFileDialogJson;
        private System.Windows.Forms.Button buttonObjectProvincia;
        private System.Windows.Forms.Button buttonJsonProvincia;
        private System.Windows.Forms.Button buttonObjectComune;
        private System.Windows.Forms.Button buttonJsonComune;
        private System.Windows.Forms.Button buttonObjectComuneByte;
        private System.Windows.Forms.Button buttonJsonComuneByte;
    }
}

