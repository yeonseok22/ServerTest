
namespace ServerTest
{
    partial class serverTest
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbPiServer = new System.Windows.Forms.TextBox();
            this.btnPi_DisConn = new System.Windows.Forms.Button();
            this.btnPi_Conn = new System.Windows.Forms.Button();
            this.btnPi_Debug = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPi_Send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPi_Msg = new System.Windows.Forms.TextBox();
            this.tbPi_Port = new System.Windows.Forms.TextBox();
            this.tbPi_IP = new System.Windows.Forms.TextBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tbAndServer = new System.Windows.Forms.TextBox();
            this.btnAnd_Conn = new System.Windows.Forms.Button();
            this.btnAnd_Debug = new System.Windows.Forms.Button();
            this.btnAnd_DisConn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnd_Send = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAnd_Msg = new System.Windows.Forms.TextBox();
            this.tbAnd_Port = new System.Windows.Forms.TextBox();
            this.tbAnd_IP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer1.Size = new System.Drawing.Size(800, 488);
            this.splitContainer1.SplitterDistance = 409;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbPiServer);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnPi_DisConn);
            this.splitContainer2.Panel2.Controls.Add(this.btnPi_Conn);
            this.splitContainer2.Panel2.Controls.Add(this.btnPi_Debug);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer2.Size = new System.Drawing.Size(408, 488);
            this.splitContainer2.SplitterDistance = 347;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbPiServer
            // 
            this.tbPiServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPiServer.Location = new System.Drawing.Point(1, 1);
            this.tbPiServer.Multiline = true;
            this.tbPiServer.Name = "tbPiServer";
            this.tbPiServer.ReadOnly = true;
            this.tbPiServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbPiServer.Size = new System.Drawing.Size(407, 343);
            this.tbPiServer.TabIndex = 0;
            // 
            // btnPi_DisConn
            // 
            this.btnPi_DisConn.Location = new System.Drawing.Point(154, 105);
            this.btnPi_DisConn.Name = "btnPi_DisConn";
            this.btnPi_DisConn.Size = new System.Drawing.Size(105, 29);
            this.btnPi_DisConn.TabIndex = 2;
            this.btnPi_DisConn.Text = "연결 끊기";
            this.btnPi_DisConn.UseVisualStyleBackColor = true;
            this.btnPi_DisConn.Click += new System.EventHandler(this.btnPi_DisConn_Click);
            // 
            // btnPi_Conn
            // 
            this.btnPi_Conn.Location = new System.Drawing.Point(33, 105);
            this.btnPi_Conn.Name = "btnPi_Conn";
            this.btnPi_Conn.Size = new System.Drawing.Size(105, 29);
            this.btnPi_Conn.TabIndex = 2;
            this.btnPi_Conn.Text = "연결";
            this.btnPi_Conn.UseVisualStyleBackColor = true;
            this.btnPi_Conn.Click += new System.EventHandler(this.btnPi_Conn_Click);
            // 
            // btnPi_Debug
            // 
            this.btnPi_Debug.Location = new System.Drawing.Point(273, 105);
            this.btnPi_Debug.Name = "btnPi_Debug";
            this.btnPi_Debug.Size = new System.Drawing.Size(105, 29);
            this.btnPi_Debug.TabIndex = 2;
            this.btnPi_Debug.Text = "Pi 디버깅";
            this.btnPi_Debug.UseVisualStyleBackColor = true;
            this.btnPi_Debug.Click += new System.EventHandler(this.btnPi_Debug_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPi_Send);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbPi_Msg);
            this.groupBox2.Controls.Add(this.tbPi_Port);
            this.groupBox2.Controls.Add(this.tbPi_IP);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "라즈베리파이";
            // 
            // btnPi_Send
            // 
            this.btnPi_Send.Location = new System.Drawing.Point(291, 50);
            this.btnPi_Send.Name = "btnPi_Send";
            this.btnPi_Send.Size = new System.Drawing.Size(105, 29);
            this.btnPi_Send.TabIndex = 2;
            this.btnPi_Send.Text = "메시지 보내기";
            this.btnPi_Send.UseVisualStyleBackColor = true;
            this.btnPi_Send.Click += new System.EventHandler(this.btnPi_Send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "PORT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "메시지 전송";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connect IP";
            // 
            // tbPi_Msg
            // 
            this.tbPi_Msg.Location = new System.Drawing.Point(78, 54);
            this.tbPi_Msg.Name = "tbPi_Msg";
            this.tbPi_Msg.Size = new System.Drawing.Size(202, 21);
            this.tbPi_Msg.TabIndex = 0;
            // 
            // tbPi_Port
            // 
            this.tbPi_Port.Location = new System.Drawing.Point(208, 24);
            this.tbPi_Port.Name = "tbPi_Port";
            this.tbPi_Port.ReadOnly = true;
            this.tbPi_Port.Size = new System.Drawing.Size(72, 21);
            this.tbPi_Port.TabIndex = 0;
            this.tbPi_Port.Text = "9090";
            // 
            // tbPi_IP
            // 
            this.tbPi_IP.Location = new System.Drawing.Point(78, 23);
            this.tbPi_IP.Name = "tbPi_IP";
            this.tbPi_IP.Size = new System.Drawing.Size(72, 21);
            this.tbPi_IP.TabIndex = 0;
            this.tbPi_IP.Text = "127.0.0.1";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer3.Location = new System.Drawing.Point(1, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tbAndServer);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnAnd_Conn);
            this.splitContainer3.Panel2.Controls.Add(this.btnAnd_Debug);
            this.splitContainer3.Panel2.Controls.Add(this.btnAnd_DisConn);
            this.splitContainer3.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer3.Size = new System.Drawing.Size(386, 488);
            this.splitContainer3.SplitterDistance = 347;
            this.splitContainer3.TabIndex = 0;
            // 
            // tbAndServer
            // 
            this.tbAndServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAndServer.Location = new System.Drawing.Point(1, 1);
            this.tbAndServer.Multiline = true;
            this.tbAndServer.Name = "tbAndServer";
            this.tbAndServer.ReadOnly = true;
            this.tbAndServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAndServer.Size = new System.Drawing.Size(385, 343);
            this.tbAndServer.TabIndex = 0;
            // 
            // btnAnd_Conn
            // 
            this.btnAnd_Conn.Location = new System.Drawing.Point(24, 105);
            this.btnAnd_Conn.Name = "btnAnd_Conn";
            this.btnAnd_Conn.Size = new System.Drawing.Size(105, 29);
            this.btnAnd_Conn.TabIndex = 2;
            this.btnAnd_Conn.Text = "연결";
            this.btnAnd_Conn.UseVisualStyleBackColor = true;
            this.btnAnd_Conn.Click += new System.EventHandler(this.btnAnd_Conn_Click);
            // 
            // btnAnd_Debug
            // 
            this.btnAnd_Debug.Location = new System.Drawing.Point(264, 105);
            this.btnAnd_Debug.Name = "btnAnd_Debug";
            this.btnAnd_Debug.Size = new System.Drawing.Size(105, 29);
            this.btnAnd_Debug.TabIndex = 2;
            this.btnAnd_Debug.Text = "Android 디버깅";
            this.btnAnd_Debug.UseVisualStyleBackColor = true;
            this.btnAnd_Debug.Click += new System.EventHandler(this.btnAnd_Debug_Click);
            // 
            // btnAnd_DisConn
            // 
            this.btnAnd_DisConn.Location = new System.Drawing.Point(144, 105);
            this.btnAnd_DisConn.Name = "btnAnd_DisConn";
            this.btnAnd_DisConn.Size = new System.Drawing.Size(105, 29);
            this.btnAnd_DisConn.TabIndex = 3;
            this.btnAnd_DisConn.Text = "연결 끊기";
            this.btnAnd_DisConn.UseVisualStyleBackColor = true;
            this.btnAnd_DisConn.Click += new System.EventHandler(this.btnAnd_DisConn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnAnd_Send);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbAnd_Msg);
            this.groupBox1.Controls.Add(this.tbAnd_Port);
            this.groupBox1.Controls.Add(this.tbAnd_IP);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "안드로이드";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "PORT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "메시지 전송";
            // 
            // btnAnd_Send
            // 
            this.btnAnd_Send.Location = new System.Drawing.Point(279, 48);
            this.btnAnd_Send.Name = "btnAnd_Send";
            this.btnAnd_Send.Size = new System.Drawing.Size(100, 29);
            this.btnAnd_Send.TabIndex = 3;
            this.btnAnd_Send.Text = "메시지 보내기";
            this.btnAnd_Send.UseVisualStyleBackColor = true;
            this.btnAnd_Send.Click += new System.EventHandler(this.btnAnd_Send_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Connect IP";
            // 
            // tbAnd_Msg
            // 
            this.tbAnd_Msg.Location = new System.Drawing.Point(78, 56);
            this.tbAnd_Msg.Name = "tbAnd_Msg";
            this.tbAnd_Msg.Size = new System.Drawing.Size(195, 21);
            this.tbAnd_Msg.TabIndex = 0;
            // 
            // tbAnd_Port
            // 
            this.tbAnd_Port.Location = new System.Drawing.Point(198, 25);
            this.tbAnd_Port.Name = "tbAnd_Port";
            this.tbAnd_Port.ReadOnly = true;
            this.tbAnd_Port.Size = new System.Drawing.Size(75, 21);
            this.tbAnd_Port.TabIndex = 0;
            this.tbAnd_Port.Text = "9000";
            // 
            // tbAnd_IP
            // 
            this.tbAnd_IP.Location = new System.Drawing.Point(78, 24);
            this.tbAnd_IP.Name = "tbAnd_IP";
            this.tbAnd_IP.Size = new System.Drawing.Size(72, 21);
            this.tbAnd_IP.TabIndex = 0;
            this.tbAnd_IP.Text = "127.0.0.1";
            // 
            // serverTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 490);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "serverTest";
            this.Text = "서버 테스트";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.serverTest_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TextBox tbPiServer;
        private System.Windows.Forms.TextBox tbAndServer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPi_Conn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPi_Debug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPi_Msg;
        private System.Windows.Forms.TextBox tbPi_Port;
        private System.Windows.Forms.TextBox tbPi_IP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnd_Conn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAnd_Debug;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAnd_Msg;
        private System.Windows.Forms.TextBox tbAnd_Port;
        private System.Windows.Forms.TextBox tbAnd_IP;
        private System.Windows.Forms.Button btnPi_DisConn;
        private System.Windows.Forms.Button btnPi_Send;
        private System.Windows.Forms.Button btnAnd_DisConn;
        private System.Windows.Forms.Button btnAnd_Send;
    }
}

