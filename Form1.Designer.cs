namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pMeteor = new System.Windows.Forms.PictureBox();
            this.pBG = new System.Windows.Forms.PictureBox();
            this.pBase = new System.Windows.Forms.PictureBox();
            this.pPlayer = new System.Windows.Forms.PictureBox();
            this.pGameover = new System.Windows.Forms.PictureBox();
            this.pExp = new System.Windows.Forms.PictureBox();
            this.pMsg = new System.Windows.Forms.PictureBox();
            this.pTitle = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pMeteor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGameover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMsg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTitle)).BeginInit();
            this.SuspendLayout();
            // 
            // pMeteor
            // 
            this.pMeteor.Image = ((System.Drawing.Image)(resources.GetObject("pMeteor.Image")));
            this.pMeteor.Location = new System.Drawing.Point(320, 12);
            this.pMeteor.Name = "pMeteor";
            this.pMeteor.Size = new System.Drawing.Size(87, 82);
            this.pMeteor.TabIndex = 0;
            this.pMeteor.TabStop = false;
            // 
            // pBG
            // 
            this.pBG.Image = ((System.Drawing.Image)(resources.GetObject("pBG.Image")));
            this.pBG.Location = new System.Drawing.Point(320, 105);
            this.pBG.Name = "pBG";
            this.pBG.Size = new System.Drawing.Size(100, 164);
            this.pBG.TabIndex = 1;
            this.pBG.TabStop = false;
            // 
            // pBase
            // 
            this.pBase.Location = new System.Drawing.Point(-2, -28);
            this.pBase.Name = "pBase";
            this.pBase.Size = new System.Drawing.Size(469, 313);
            this.pBase.TabIndex = 2;
            this.pBase.TabStop = false;
            this.pBase.Click += new System.EventHandler(this.pBase_Click);
            // 
            // pPlayer
            // 
            this.pPlayer.Image = ((System.Drawing.Image)(resources.GetObject("pPlayer.Image")));
            this.pPlayer.Location = new System.Drawing.Point(74, 24);
            this.pPlayer.Name = "pPlayer";
            this.pPlayer.Size = new System.Drawing.Size(100, 50);
            this.pPlayer.TabIndex = 3;
            this.pPlayer.TabStop = false;
            // 
            // pGameover
            // 
            this.pGameover.Image = ((System.Drawing.Image)(resources.GetObject("pGameover.Image")));
            this.pGameover.Location = new System.Drawing.Point(225, 24);
            this.pGameover.Name = "pGameover";
            this.pGameover.Size = new System.Drawing.Size(100, 50);
            this.pGameover.TabIndex = 4;
            this.pGameover.TabStop = false;
            // 
            // pExp
            // 
            this.pExp.Image = ((System.Drawing.Image)(resources.GetObject("pExp.Image")));
            this.pExp.Location = new System.Drawing.Point(56, 105);
            this.pExp.Name = "pExp";
            this.pExp.Size = new System.Drawing.Size(100, 50);
            this.pExp.TabIndex = 5;
            this.pExp.TabStop = false;
            // 
            // pMsg
            // 
            this.pMsg.Image = ((System.Drawing.Image)(resources.GetObject("pMsg.Image")));
            this.pMsg.Location = new System.Drawing.Point(74, 188);
            this.pMsg.Name = "pMsg";
            this.pMsg.Size = new System.Drawing.Size(100, 50);
            this.pMsg.TabIndex = 6;
            this.pMsg.TabStop = false;
            // 
            // pTitle
            // 
            this.pTitle.Image = ((System.Drawing.Image)(resources.GetObject("pTitle.Image")));
            this.pTitle.Location = new System.Drawing.Point(249, 144);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(146, 94);
            this.pTitle.TabIndex = 7;
            this.pTitle.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 281);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.pMsg);
            this.Controls.Add(this.pExp);
            this.Controls.Add(this.pGameover);
            this.Controls.Add(this.pPlayer);
            this.Controls.Add(this.pBase);
            this.Controls.Add(this.pMeteor);
            this.Controls.Add(this.pBG);
            this.Name = "Form1";
            this.Text = "宇宙";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMeteor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pGameover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMsg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTitle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pMeteor;
        private System.Windows.Forms.PictureBox pBG;
        private System.Windows.Forms.PictureBox pBase;
        private System.Windows.Forms.PictureBox pPlayer;
        private System.Windows.Forms.PictureBox pGameover;
        private System.Windows.Forms.PictureBox pExp;
        private System.Windows.Forms.PictureBox pMsg;
        private System.Windows.Forms.PictureBox pTitle;
        private System.Windows.Forms.Timer timer1;
    }
}

