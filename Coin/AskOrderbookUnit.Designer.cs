
namespace Coin
{
    partial class AskOrderbookUnit
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.askPanel = new System.Windows.Forms.Panel();
            this.askPricePanel = new System.Windows.Forms.Panel();
            this.askPriceLabel = new System.Windows.Forms.Label();
            this.askContentPart2Panel = new System.Windows.Forms.Panel();
            this.askContentPart1Panel = new System.Windows.Forms.Panel();
            this.askVolumePanel = new System.Windows.Forms.Panel();
            this.askVolumeLabel = new System.Windows.Forms.Label();
            this.askRatePanel = new System.Windows.Forms.Panel();
            this.askRateLabel = new System.Windows.Forms.Label();
            this.askPanel.SuspendLayout();
            this.askPricePanel.SuspendLayout();
            this.askVolumePanel.SuspendLayout();
            this.askRatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // askPanel
            // 
            this.askPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.askPanel.Controls.Add(this.askPricePanel);
            this.askPanel.Controls.Add(this.askContentPart2Panel);
            this.askPanel.Controls.Add(this.askContentPart1Panel);
            this.askPanel.Controls.Add(this.askVolumePanel);
            this.askPanel.Controls.Add(this.askRatePanel);
            this.askPanel.Location = new System.Drawing.Point(0, 0);
            this.askPanel.Name = "askPanel";
            this.askPanel.Padding = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.askPanel.Size = new System.Drawing.Size(425, 50);
            this.askPanel.TabIndex = 1;
            // 
            // askPricePanel
            // 
            this.askPricePanel.BackColor = System.Drawing.Color.White;
            this.askPricePanel.Controls.Add(this.askPriceLabel);
            this.askPricePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askPricePanel.Location = new System.Drawing.Point(141, 1);
            this.askPricePanel.Name = "askPricePanel";
            this.askPricePanel.Size = new System.Drawing.Size(182, 48);
            this.askPricePanel.TabIndex = 2;
            // 
            // askPriceLabel
            // 
            this.askPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.askPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askPriceLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.askPriceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.askPriceLabel.Location = new System.Drawing.Point(0, 0);
            this.askPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.askPriceLabel.Name = "askPriceLabel";
            this.askPriceLabel.Size = new System.Drawing.Size(182, 48);
            this.askPriceLabel.TabIndex = 1;
            this.askPriceLabel.Text = "0";
            this.askPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // askContentPart2Panel
            // 
            this.askContentPart2Panel.BackColor = System.Drawing.Color.Transparent;
            this.askContentPart2Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.askContentPart2Panel.Location = new System.Drawing.Point(323, 1);
            this.askContentPart2Panel.Margin = new System.Windows.Forms.Padding(0);
            this.askContentPart2Panel.Name = "askContentPart2Panel";
            this.askContentPart2Panel.Size = new System.Drawing.Size(1, 48);
            this.askContentPart2Panel.TabIndex = 5;
            // 
            // askContentPart1Panel
            // 
            this.askContentPart1Panel.BackColor = System.Drawing.Color.Transparent;
            this.askContentPart1Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.askContentPart1Panel.Location = new System.Drawing.Point(140, 1);
            this.askContentPart1Panel.Margin = new System.Windows.Forms.Padding(0);
            this.askContentPart1Panel.Name = "askContentPart1Panel";
            this.askContentPart1Panel.Size = new System.Drawing.Size(1, 48);
            this.askContentPart1Panel.TabIndex = 4;
            // 
            // askVolumePanel
            // 
            this.askVolumePanel.BackColor = System.Drawing.Color.White;
            this.askVolumePanel.Controls.Add(this.askVolumeLabel);
            this.askVolumePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.askVolumePanel.Location = new System.Drawing.Point(0, 1);
            this.askVolumePanel.Margin = new System.Windows.Forms.Padding(0);
            this.askVolumePanel.Name = "askVolumePanel";
            this.askVolumePanel.Size = new System.Drawing.Size(140, 48);
            this.askVolumePanel.TabIndex = 0;
            // 
            // askVolumeLabel
            // 
            this.askVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.askVolumeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askVolumeLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.askVolumeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.askVolumeLabel.Location = new System.Drawing.Point(0, 0);
            this.askVolumeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.askVolumeLabel.Name = "askVolumeLabel";
            this.askVolumeLabel.Size = new System.Drawing.Size(140, 48);
            this.askVolumeLabel.TabIndex = 1;
            this.askVolumeLabel.Text = "0";
            this.askVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // askRatePanel
            // 
            this.askRatePanel.BackColor = System.Drawing.Color.White;
            this.askRatePanel.Controls.Add(this.askRateLabel);
            this.askRatePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.askRatePanel.Location = new System.Drawing.Point(324, 1);
            this.askRatePanel.Name = "askRatePanel";
            this.askRatePanel.Size = new System.Drawing.Size(100, 48);
            this.askRatePanel.TabIndex = 3;
            // 
            // askRateLabel
            // 
            this.askRateLabel.BackColor = System.Drawing.Color.Transparent;
            this.askRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.askRateLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.askRateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.askRateLabel.Location = new System.Drawing.Point(0, 0);
            this.askRateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.askRateLabel.Name = "askRateLabel";
            this.askRateLabel.Size = new System.Drawing.Size(100, 48);
            this.askRateLabel.TabIndex = 1;
            this.askRateLabel.Text = "0%";
            this.askRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AskOrderbookUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.askPanel);
            this.Name = "AskOrderbookUnit";
            this.Size = new System.Drawing.Size(425, 50);
            this.askPanel.ResumeLayout(false);
            this.askPricePanel.ResumeLayout(false);
            this.askVolumePanel.ResumeLayout(false);
            this.askRatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel askPanel;
        private System.Windows.Forms.Panel askPricePanel;
        private System.Windows.Forms.Label askPriceLabel;
        private System.Windows.Forms.Panel askVolumePanel;
        private System.Windows.Forms.Label askVolumeLabel;
        private System.Windows.Forms.Panel askRatePanel;
        private System.Windows.Forms.Label askRateLabel;
        private System.Windows.Forms.Panel askContentPart2Panel;
        private System.Windows.Forms.Panel askContentPart1Panel;
    }
}
