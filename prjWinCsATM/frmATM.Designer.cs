namespace prjWinCsATM
{
    partial class frmATM
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
            this.grpAccInfo = new System.Windows.Forms.GroupBox();
            this.btnTerminate = new System.Windows.Forms.Button();
            this.lblAccInfo = new System.Windows.Forms.Label();
            this.grpTransType = new System.Windows.Forms.GroupBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.txtWithdraw = new System.Windows.Forms.TextBox();
            this.rdbWithdraw = new System.Windows.Forms.RadioButton();
            this.rdbConsult = new System.Windows.Forms.RadioButton();
            this.rdbDeposit = new System.Windows.Forms.RadioButton();
            this.btnNextTransType = new System.Windows.Forms.Button();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.grpAccountType = new System.Windows.Forms.GroupBox();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.btnNextAccType = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPinValid = new System.Windows.Forms.GroupBox();
            this.lblWelcomeName = new System.Windows.Forms.Label();
            this.btnNextPinValid = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpReadCard = new System.Windows.Forms.GroupBox();
            this.btnNextReadCard = new System.Windows.Forms.Button();
            this.txtCardNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAccInfo.SuspendLayout();
            this.grpTransType.SuspendLayout();
            this.grpAccountType.SuspendLayout();
            this.grpPinValid.SuspendLayout();
            this.grpReadCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAccInfo
            // 
            this.grpAccInfo.Controls.Add(this.btnTerminate);
            this.grpAccInfo.Controls.Add(this.lblAccInfo);
            this.grpAccInfo.Location = new System.Drawing.Point(37, 571);
            this.grpAccInfo.Name = "grpAccInfo";
            this.grpAccInfo.Size = new System.Drawing.Size(507, 129);
            this.grpAccInfo.TabIndex = 11;
            this.grpAccInfo.TabStop = false;
            this.grpAccInfo.Text = "ACCOUNT INFORMATIONS";
            // 
            // btnTerminate
            // 
            this.btnTerminate.Location = new System.Drawing.Point(306, 88);
            this.btnTerminate.Name = "btnTerminate";
            this.btnTerminate.Size = new System.Drawing.Size(131, 25);
            this.btnTerminate.TabIndex = 3;
            this.btnTerminate.Text = "TERMINATE";
            this.btnTerminate.UseVisualStyleBackColor = true;
            this.btnTerminate.Click += new System.EventHandler(this.btnTerminate_Click);
            // 
            // lblAccInfo
            // 
            this.lblAccInfo.AutoSize = true;
            this.lblAccInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblAccInfo.Location = new System.Drawing.Point(18, 30);
            this.lblAccInfo.Name = "lblAccInfo";
            this.lblAccInfo.Size = new System.Drawing.Size(52, 18);
            this.lblAccInfo.TabIndex = 0;
            this.lblAccInfo.Text = "label7";
            // 
            // grpTransType
            // 
            this.grpTransType.Controls.Add(this.lblWithdraw);
            this.grpTransType.Controls.Add(this.lblDeposit);
            this.grpTransType.Controls.Add(this.txtWithdraw);
            this.grpTransType.Controls.Add(this.rdbWithdraw);
            this.grpTransType.Controls.Add(this.rdbConsult);
            this.grpTransType.Controls.Add(this.rdbDeposit);
            this.grpTransType.Controls.Add(this.btnNextTransType);
            this.grpTransType.Controls.Add(this.txtDeposit);
            this.grpTransType.Location = new System.Drawing.Point(37, 413);
            this.grpTransType.Name = "grpTransType";
            this.grpTransType.Size = new System.Drawing.Size(507, 146);
            this.grpTransType.TabIndex = 10;
            this.grpTransType.TabStop = false;
            this.grpTransType.Text = "TRANSACTION TYPES";
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Location = new System.Drawing.Point(302, 71);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(17, 18);
            this.lblWithdraw.TabIndex = 8;
            this.lblWithdraw.Text = "$";
            this.lblWithdraw.Visible = false;
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(302, 37);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(17, 18);
            this.lblDeposit.TabIndex = 7;
            this.lblDeposit.Text = "$";
            this.lblDeposit.Visible = false;
            // 
            // txtWithdraw
            // 
            this.txtWithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtWithdraw.Location = new System.Drawing.Point(199, 68);
            this.txtWithdraw.Name = "txtWithdraw";
            this.txtWithdraw.Size = new System.Drawing.Size(97, 24);
            this.txtWithdraw.TabIndex = 6;
            this.txtWithdraw.Visible = false;
            this.txtWithdraw.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWithdraw_KeyPress);
            // 
            // rdbWithdraw
            // 
            this.rdbWithdraw.AutoSize = true;
            this.rdbWithdraw.Location = new System.Drawing.Point(22, 69);
            this.rdbWithdraw.Name = "rdbWithdraw";
            this.rdbWithdraw.Size = new System.Drawing.Size(118, 22);
            this.rdbWithdraw.TabIndex = 5;
            this.rdbWithdraw.TabStop = true;
            this.rdbWithdraw.Text = "WITHDRAW";
            this.rdbWithdraw.UseVisualStyleBackColor = true;
            this.rdbWithdraw.CheckedChanged += new System.EventHandler(this.rdbWithdraw_CheckedChanged);
            // 
            // rdbConsult
            // 
            this.rdbConsult.AutoSize = true;
            this.rdbConsult.Location = new System.Drawing.Point(22, 103);
            this.rdbConsult.Name = "rdbConsult";
            this.rdbConsult.Size = new System.Drawing.Size(105, 22);
            this.rdbConsult.TabIndex = 4;
            this.rdbConsult.TabStop = true;
            this.rdbConsult.Text = "CONSULT";
            this.rdbConsult.UseVisualStyleBackColor = true;
            // 
            // rdbDeposit
            // 
            this.rdbDeposit.AutoSize = true;
            this.rdbDeposit.Location = new System.Drawing.Point(22, 35);
            this.rdbDeposit.Name = "rdbDeposit";
            this.rdbDeposit.Size = new System.Drawing.Size(98, 22);
            this.rdbDeposit.TabIndex = 3;
            this.rdbDeposit.TabStop = true;
            this.rdbDeposit.Text = "DEPOSIT";
            this.rdbDeposit.UseVisualStyleBackColor = true;
            this.rdbDeposit.CheckedChanged += new System.EventHandler(this.rdbDeposit_CheckedChanged);
            // 
            // btnNextTransType
            // 
            this.btnNextTransType.Location = new System.Drawing.Point(303, 111);
            this.btnNextTransType.Name = "btnNextTransType";
            this.btnNextTransType.Size = new System.Drawing.Size(112, 25);
            this.btnNextTransType.TabIndex = 2;
            this.btnNextTransType.Text = "NEXT >>";
            this.btnNextTransType.UseVisualStyleBackColor = true;
            this.btnNextTransType.Click += new System.EventHandler(this.btnNextTransType_Click);
            // 
            // txtDeposit
            // 
            this.txtDeposit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtDeposit.Location = new System.Drawing.Point(199, 34);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(97, 24);
            this.txtDeposit.TabIndex = 1;
            this.txtDeposit.Visible = false;
            this.txtDeposit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDeposit_KeyPress);
            // 
            // grpAccountType
            // 
            this.grpAccountType.Controls.Add(this.cmbAccountType);
            this.grpAccountType.Controls.Add(this.btnNextAccType);
            this.grpAccountType.Controls.Add(this.label4);
            this.grpAccountType.Location = new System.Drawing.Point(37, 289);
            this.grpAccountType.Name = "grpAccountType";
            this.grpAccountType.Size = new System.Drawing.Size(507, 112);
            this.grpAccountType.TabIndex = 9;
            this.grpAccountType.TabStop = false;
            this.grpAccountType.Text = "ACCOUNT TYPES";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(199, 35);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(195, 26);
            this.cmbAccountType.TabIndex = 3;
            // 
            // btnNextAccType
            // 
            this.btnNextAccType.Location = new System.Drawing.Point(303, 72);
            this.btnNextAccType.Name = "btnNextAccType";
            this.btnNextAccType.Size = new System.Drawing.Size(112, 25);
            this.btnNextAccType.TabIndex = 2;
            this.btnNextAccType.Text = "NEXT >>";
            this.btnNextAccType.UseVisualStyleBackColor = true;
            this.btnNextAccType.Click += new System.EventHandler(this.btnNextAccType_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "SELECT TYPE :";
            // 
            // grpPinValid
            // 
            this.grpPinValid.Controls.Add(this.lblWelcomeName);
            this.grpPinValid.Controls.Add(this.btnNextPinValid);
            this.grpPinValid.Controls.Add(this.txtPin);
            this.grpPinValid.Controls.Add(this.label3);
            this.grpPinValid.Location = new System.Drawing.Point(37, 161);
            this.grpPinValid.Name = "grpPinValid";
            this.grpPinValid.Size = new System.Drawing.Size(507, 116);
            this.grpPinValid.TabIndex = 8;
            this.grpPinValid.TabStop = false;
            this.grpPinValid.Text = "PIN VALIDATION";
            // 
            // lblWelcomeName
            // 
            this.lblWelcomeName.AutoSize = true;
            this.lblWelcomeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeName.ForeColor = System.Drawing.Color.Red;
            this.lblWelcomeName.Location = new System.Drawing.Point(18, 24);
            this.lblWelcomeName.Name = "lblWelcomeName";
            this.lblWelcomeName.Size = new System.Drawing.Size(103, 20);
            this.lblWelcomeName.TabIndex = 3;
            this.lblWelcomeName.Text = "BIENVENUE";
            // 
            // btnNextPinValid
            // 
            this.btnNextPinValid.Location = new System.Drawing.Point(303, 85);
            this.btnNextPinValid.Name = "btnNextPinValid";
            this.btnNextPinValid.Size = new System.Drawing.Size(112, 25);
            this.btnNextPinValid.TabIndex = 2;
            this.btnNextPinValid.Text = "NEXT >>";
            this.btnNextPinValid.UseVisualStyleBackColor = true;
            this.btnNextPinValid.Click += new System.EventHandler(this.btnNextPinValid_Click);
            // 
            // txtPin
            // 
            this.txtPin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtPin.Location = new System.Drawing.Point(199, 53);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(195, 24);
            this.txtPin.TabIndex = 1;
            this.txtPin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ENTER PIN :";
            // 
            // grpReadCard
            // 
            this.grpReadCard.Controls.Add(this.btnNextReadCard);
            this.grpReadCard.Controls.Add(this.txtCardNum);
            this.grpReadCard.Controls.Add(this.label2);
            this.grpReadCard.Location = new System.Drawing.Point(37, 47);
            this.grpReadCard.Name = "grpReadCard";
            this.grpReadCard.Size = new System.Drawing.Size(507, 102);
            this.grpReadCard.TabIndex = 7;
            this.grpReadCard.TabStop = false;
            this.grpReadCard.Text = "READING OF CARD";
            // 
            // btnNextReadCard
            // 
            this.btnNextReadCard.Location = new System.Drawing.Point(303, 72);
            this.btnNextReadCard.Name = "btnNextReadCard";
            this.btnNextReadCard.Size = new System.Drawing.Size(112, 25);
            this.btnNextReadCard.TabIndex = 2;
            this.btnNextReadCard.Text = "NEXT >>";
            this.btnNextReadCard.UseVisualStyleBackColor = true;
            this.btnNextReadCard.Click += new System.EventHandler(this.btnNextReadCard_Click);
            // 
            // txtCardNum
            // 
            this.txtCardNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtCardNum.Location = new System.Drawing.Point(199, 35);
            this.txtCardNum.Name = "txtCardNum";
            this.txtCardNum.Size = new System.Drawing.Size(195, 24);
            this.txtCardNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "CARD NUMBER :";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(137, 6);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(303, 33);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "ROYALE BANK ATM";
            // 
            // frmATM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 703);
            this.Controls.Add(this.grpAccInfo);
            this.Controls.Add(this.grpTransType);
            this.Controls.Add(this.grpAccountType);
            this.Controls.Add(this.grpPinValid);
            this.Controls.Add(this.grpReadCard);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmATM";
            this.Text = "frmATM";
            this.Load += new System.EventHandler(this.frmATM_Load);
            this.grpAccInfo.ResumeLayout(false);
            this.grpAccInfo.PerformLayout();
            this.grpTransType.ResumeLayout(false);
            this.grpTransType.PerformLayout();
            this.grpAccountType.ResumeLayout(false);
            this.grpAccountType.PerformLayout();
            this.grpPinValid.ResumeLayout(false);
            this.grpPinValid.PerformLayout();
            this.grpReadCard.ResumeLayout(false);
            this.grpReadCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAccInfo;
        private System.Windows.Forms.Button btnTerminate;
        private System.Windows.Forms.Label lblAccInfo;
        private System.Windows.Forms.GroupBox grpTransType;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.TextBox txtWithdraw;
        private System.Windows.Forms.RadioButton rdbWithdraw;
        private System.Windows.Forms.RadioButton rdbConsult;
        private System.Windows.Forms.RadioButton rdbDeposit;
        private System.Windows.Forms.Button btnNextTransType;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.GroupBox grpAccountType;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Button btnNextAccType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpPinValid;
        private System.Windows.Forms.Label lblWelcomeName;
        private System.Windows.Forms.Button btnNextPinValid;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpReadCard;
        private System.Windows.Forms.Button btnNextReadCard;
        private System.Windows.Forms.TextBox txtCardNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
    }
}