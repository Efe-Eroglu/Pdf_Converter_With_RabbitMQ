namespace Pdf_Converter_RabbitMQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_convert = new Button();
            btn_connect = new Button();
            txt_connection = new TextBox();
            label1 = new Label();
            txt_logs = new TextBox();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btn_Select = new Button();
            SuspendLayout();
            // 
            // btn_convert
            // 
            btn_convert.Font = new Font("Verdana", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_convert.Location = new Point(320, 307);
            btn_convert.Name = "btn_convert";
            btn_convert.Size = new Size(211, 45);
            btn_convert.TabIndex = 0;
            btn_convert.Text = "Convert";
            btn_convert.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            btn_connect.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_connect.Location = new Point(628, 126);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(193, 42);
            btn_connect.TabIndex = 1;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            // 
            // txt_connection
            // 
            txt_connection.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txt_connection.Location = new Point(40, 130);
            txt_connection.Name = "txt_connection";
            txt_connection.Size = new Size(537, 38);
            txt_connection.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(242, 38);
            label1.Name = "label1";
            label1.Size = new Size(360, 48);
            label1.TabIndex = 3;
            label1.Text = "PDF CONVERTER";
            // 
            // txt_logs
            // 
            txt_logs.Location = new Point(0, 476);
            txt_logs.Multiline = true;
            txt_logs.Name = "txt_logs";
            txt_logs.Size = new Size(868, 203);
            txt_logs.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(0, 439);
            label2.Name = "label2";
            label2.Size = new Size(72, 34);
            label2.TabIndex = 5;
            label2.Text = "Logs";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Select
            // 
            btn_Select.Location = new Point(687, 261);
            btn_Select.Name = "btn_Select";
            btn_Select.Size = new Size(94, 29);
            btn_Select.TabIndex = 6;
            btn_Select.Text = "Select File";
            btn_Select.UseVisualStyleBackColor = true;
            btn_Select.Click += btn_Select_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(866, 675);
            Controls.Add(btn_Select);
            Controls.Add(label2);
            Controls.Add(txt_logs);
            Controls.Add(label1);
            Controls.Add(txt_connection);
            Controls.Add(btn_connect);
            Controls.Add(btn_convert);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pdf Converter";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_convert;
        private Button btn_connect;
        private TextBox txt_connection;
        private Label label1;
        private TextBox txt_logs;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private Button btn_Select;
    }
}
