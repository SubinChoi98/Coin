
namespace Coin
{
    partial class BidOrderbookUnit
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
            this.bidPanel = new System.Windows.Forms.Panel();
            this.bidRatePanel = new System.Windows.Forms.Panel();
            this.bidRateLabel = new System.Windows.Forms.Label();
            this.bidContentPart2Panel = new System.Windows.Forms.Panel();
            this.bidContentPart1Panel = new System.Windows.Forms.Panel();
            this.bidPricePanel = new System.Windows.Forms.Panel();
            this.bidPriceLabel = new System.Windows.Forms.Label();
            this.bidVolumePanel = new System.Windows.Forms.Panel();
            this.bidVolumeLabel = new System.Windows.Forms.Label();
            this.bidPanel.SuspendLayout();
            this.bidRatePanel.SuspendLayout();
            this.bidPricePanel.SuspendLayout();
            this.bidVolumePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bidPanel
            // 
            this.bidPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.bidPanel.Controls.Add(this.bidRatePanel);
            this.bidPanel.Controls.Add(this.bidContentPart2Panel);
            this.bidPanel.Controls.Add(this.bidContentPart1Panel);
            this.bidPanel.Controls.Add(this.bidPricePanel);
            this.bidPanel.Controls.Add(this.bidVolumePanel);
            this.bidPanel.Location = new System.Drawing.Point(0, 0);
            this.bidPanel.Name = "bidPanel";
            this.bidPanel.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.bidPanel.Size = new System.Drawing.Size(425, 50);
            this.bidPanel.TabIndex = 1;
            // 
            // bidRatePanel
            // 
            this.bidRatePanel.BackColor = System.Drawing.Color.White;
            this.bidRatePanel.Controls.Add(this.bidRateLabel);
            this.bidRatePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidRatePanel.Location = new System.Drawing.Point(184, 1);
            this.bidRatePanel.Name = "bidRatePanel";
            this.bidRatePanel.Size = new System.Drawing.Size(100, 48);
            this.bidRatePanel.TabIndex = 3;
            // 
            // bidRateLabel
            // 
            this.bidRateLabel.BackColor = System.Drawing.Color.Transparent;
            this.bidRateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidRateLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bidRateLabel.ForeColor = System.Drawing.Color.DimGray;
            this.bidRateLabel.Location = new System.Drawing.Point(0, 0);
            this.bidRateLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bidRateLabel.Name = "bidRateLabel";
            this.bidRateLabel.Size = new System.Drawing.Size(100, 48);
            this.bidRateLabel.TabIndex = 1;
            this.bidRateLabel.Text = "0%";
            this.bidRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bidContentPart2Panel
            // 
            this.bidContentPart2Panel.BackColor = System.Drawing.Color.Transparent;
            this.bidContentPart2Panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bidContentPart2Panel.Location = new System.Drawing.Point(284, 1);
            this.bidContentPart2Panel.Margin = new System.Windows.Forms.Padding(0);
            this.bidContentPart2Panel.Name = "bidContentPart2Panel";
            this.bidContentPart2Panel.Size = new System.Drawing.Size(1, 48);
            this.bidContentPart2Panel.TabIndex = 5;
            // 
            // bidContentPart1Panel
            // 
            this.bidContentPart1Panel.BackColor = System.Drawing.Color.Transparent;
            this.bidContentPart1Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bidContentPart1Panel.Location = new System.Drawing.Point(183, 1);
            this.bidContentPart1Panel.Margin = new System.Windows.Forms.Padding(0);
            this.bidContentPart1Panel.Name = "bidContentPart1Panel";
            this.bidContentPart1Panel.Size = new System.Drawing.Size(1, 48);
            this.bidContentPart1Panel.TabIndex = 0;
            // 
            // bidPricePanel
            // 
            this.bidPricePanel.BackColor = System.Drawing.Color.White;
            this.bidPricePanel.Controls.Add(this.bidPriceLabel);
            this.bidPricePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.bidPricePanel.Location = new System.Drawing.Point(1, 1);
            this.bidPricePanel.Name = "bidPricePanel";
            this.bidPricePanel.Size = new System.Drawing.Size(182, 48);
            this.bidPricePanel.TabIndex = 2;
            // 
            // bidPriceLabel
            // 
            this.bidPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.bidPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidPriceLabel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bidPriceLabel.ForeColor = System.Drawing.Color.DimGray;
            this.bidPriceLabel.Location = new System.Drawing.Point(0, 0);
            this.bidPriceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bidPriceLabel.Name = "bidPriceLabel";
            this.bidPriceLabel.Size = new System.Drawing.Size(182, 48);
            this.bidPriceLabel.TabIndex = 1;
            this.bidPriceLabel.Text = "0";
            this.bidPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bidVolumePanel
            // 
            this.bidVolumePanel.BackColor = System.Drawing.Color.White;
            this.bidVolumePanel.Controls.Add(this.bidVolumeLabel);
            this.bidVolumePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.bidVolumePanel.Location = new System.Drawing.Point(285, 1);
            this.bidVolumePanel.Margin = new System.Windows.Forms.Padding(0);
            this.bidVolumePanel.Name = "bidVolumePanel";
            this.bidVolumePanel.Size = new System.Drawing.Size(140, 48);
            this.bidVolumePanel.TabIndex = 0;
            // 
            // bidVolumeLabel
            // 
            this.bidVolumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.bidVolumeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bidVolumeLabel.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bidVolumeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.bidVolumeLabel.Location = new System.Drawing.Point(0, 0);
            this.bidVolumeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.bidVolumeLabel.Name = "bidVolumeLabel";
            this.bidVolumeLabel.Size = new System.Drawing.Size(140, 48);
            this.bidVolumeLabel.TabIndex = 1;
            this.bidVolumeLabel.Text = "0";
            this.bidVolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BidOrderbookUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bidPanel);
            this.Name = "BidOrderbookUnit";
            this.Size = new System.Drawing.Size(425, 50);
            this.bidPanel.ResumeLayout(false);
            this.bidRatePanel.ResumeLayout(false);
            this.bidPricePanel.ResumeLayout(false);
            this.bidVolumePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bidPanel;
        private System.Windows.Forms.Panel bidPricePanel;
        private System.Windows.Forms.Label bidPriceLabel;
        private System.Windows.Forms.Panel bidVolumePanel;
        private System.Windows.Forms.Label bidVolumeLabel;
        private System.Windows.Forms.Panel bidRatePanel;
        private System.Windows.Forms.Label bidRateLabel;
        private System.Windows.Forms.Panel bidContentPart2Panel;
        private System.Windows.Forms.Panel bidContentPart1Panel;
    }
}
