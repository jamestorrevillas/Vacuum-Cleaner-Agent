namespace Vacuum_agent
{
    partial class Form1
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
            this.label_Room_B = new System.Windows.Forms.Label();
            this.label_Room_A = new System.Windows.Forms.Label();
            this.btn_Clean = new System.Windows.Forms.Button();
            this.btn_NoOperation = new System.Windows.Forms.Button();
            this.label_RoomState_A = new System.Windows.Forms.Label();
            this.label_RoomState_B = new System.Windows.Forms.Label();
            this.label_RoomState_D = new System.Windows.Forms.Label();
            this.label_RoomState_C = new System.Windows.Forms.Label();
            this.label_Room_C = new System.Windows.Forms.Label();
            this.label_Room_D = new System.Windows.Forms.Label();
            this.textBox_ProcessInformation = new System.Windows.Forms.TextBox();
            this.btn_ResetToInitialState = new System.Windows.Forms.Button();
            this.pictureBox_Room_C = new System.Windows.Forms.PictureBox();
            this.pictureBox_Room_D = new System.Windows.Forms.PictureBox();
            this.pictureBox_Room_A = new System.Windows.Forms.PictureBox();
            this.pictureBox_Room_B = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room_C)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room_B)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Room_B
            // 
            this.label_Room_B.AutoSize = true;
            this.label_Room_B.Location = new System.Drawing.Point(379, 254);
            this.label_Room_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Room_B.Name = "label_Room_B";
            this.label_Room_B.Size = new System.Drawing.Size(63, 16);
            this.label_Room_B.TabIndex = 1;
            this.label_Room_B.Text = "Room B -";
            // 
            // label_Room_A
            // 
            this.label_Room_A.AutoSize = true;
            this.label_Room_A.Location = new System.Drawing.Point(94, 254);
            this.label_Room_A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Room_A.Name = "label_Room_A";
            this.label_Room_A.Size = new System.Drawing.Size(63, 16);
            this.label_Room_A.TabIndex = 1;
            this.label_Room_A.Text = "Room A -";
            // 
            // btn_Clean
            // 
            this.btn_Clean.Location = new System.Drawing.Point(694, 326);
            this.btn_Clean.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Clean.Name = "btn_Clean";
            this.btn_Clean.Size = new System.Drawing.Size(152, 50);
            this.btn_Clean.TabIndex = 3;
            this.btn_Clean.Text = "Clean";
            this.btn_Clean.UseVisualStyleBackColor = true;
            this.btn_Clean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btn_NoOperation
            // 
            this.btn_NoOperation.Location = new System.Drawing.Point(694, 395);
            this.btn_NoOperation.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NoOperation.Name = "btn_NoOperation";
            this.btn_NoOperation.Size = new System.Drawing.Size(152, 50);
            this.btn_NoOperation.TabIndex = 3;
            this.btn_NoOperation.Text = "No Operation";
            this.btn_NoOperation.UseVisualStyleBackColor = true;
            this.btn_NoOperation.Click += new System.EventHandler(this.btnNoOperation_Click);
            // 
            // label_RoomState_A
            // 
            this.label_RoomState_A.AutoSize = true;
            this.label_RoomState_A.ForeColor = System.Drawing.Color.Red;
            this.label_RoomState_A.Location = new System.Drawing.Point(158, 254);
            this.label_RoomState_A.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RoomState_A.Name = "label_RoomState_A";
            this.label_RoomState_A.Size = new System.Drawing.Size(34, 16);
            this.label_RoomState_A.TabIndex = 6;
            this.label_RoomState_A.Text = "Dirty";
            // 
            // label_RoomState_B
            // 
            this.label_RoomState_B.AutoSize = true;
            this.label_RoomState_B.ForeColor = System.Drawing.Color.Red;
            this.label_RoomState_B.Location = new System.Drawing.Point(443, 254);
            this.label_RoomState_B.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RoomState_B.Name = "label_RoomState_B";
            this.label_RoomState_B.Size = new System.Drawing.Size(34, 16);
            this.label_RoomState_B.TabIndex = 6;
            this.label_RoomState_B.Text = "Dirty";
            // 
            // label_RoomState_D
            // 
            this.label_RoomState_D.AutoSize = true;
            this.label_RoomState_D.ForeColor = System.Drawing.Color.Red;
            this.label_RoomState_D.Location = new System.Drawing.Point(443, 517);
            this.label_RoomState_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RoomState_D.Name = "label_RoomState_D";
            this.label_RoomState_D.Size = new System.Drawing.Size(34, 16);
            this.label_RoomState_D.TabIndex = 11;
            this.label_RoomState_D.Text = "Dirty";
            this.label_RoomState_D.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_RoomState_C
            // 
            this.label_RoomState_C.AutoSize = true;
            this.label_RoomState_C.ForeColor = System.Drawing.Color.Red;
            this.label_RoomState_C.Location = new System.Drawing.Point(158, 517);
            this.label_RoomState_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_RoomState_C.Name = "label_RoomState_C";
            this.label_RoomState_C.Size = new System.Drawing.Size(34, 16);
            this.label_RoomState_C.TabIndex = 12;
            this.label_RoomState_C.Text = "Dirty";
            this.label_RoomState_C.Click += new System.EventHandler(this.label4_Click);
            // 
            // label_Room_C
            // 
            this.label_Room_C.AutoSize = true;
            this.label_Room_C.Location = new System.Drawing.Point(94, 517);
            this.label_Room_C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Room_C.Name = "label_Room_C";
            this.label_Room_C.Size = new System.Drawing.Size(63, 16);
            this.label_Room_C.TabIndex = 9;
            this.label_Room_C.Text = "Room C -";
            this.label_Room_C.Click += new System.EventHandler(this.label5_Click);
            // 
            // label_Room_D
            // 
            this.label_Room_D.AutoSize = true;
            this.label_Room_D.Location = new System.Drawing.Point(379, 516);
            this.label_Room_D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Room_D.Name = "label_Room_D";
            this.label_Room_D.Size = new System.Drawing.Size(64, 16);
            this.label_Room_D.TabIndex = 10;
            this.label_Room_D.Text = "Room D -";
            this.label_Room_D.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBox_ProcessInformation
            // 
            this.textBox_ProcessInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_ProcessInformation.Location = new System.Drawing.Point(600, 32);
            this.textBox_ProcessInformation.Multiline = true;
            this.textBox_ProcessInformation.Name = "textBox_ProcessInformation";
            this.textBox_ProcessInformation.ReadOnly = true;
            this.textBox_ProcessInformation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_ProcessInformation.Size = new System.Drawing.Size(342, 265);
            this.textBox_ProcessInformation.TabIndex = 2;
            // 
            // btn_ResetToInitialState
            // 
            this.btn_ResetToInitialState.Location = new System.Drawing.Point(694, 462);
            this.btn_ResetToInitialState.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ResetToInitialState.Name = "btn_ResetToInitialState";
            this.btn_ResetToInitialState.Size = new System.Drawing.Size(152, 50);
            this.btn_ResetToInitialState.TabIndex = 13;
            this.btn_ResetToInitialState.Text = "Reset to Initial State";
            this.btn_ResetToInitialState.UseVisualStyleBackColor = true;
            this.btn_ResetToInitialState.Click += new System.EventHandler(this.btnResetToInitialState_Click);
            // 
            // pictureBox_Room_C
            // 
            this.pictureBox_Room_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Room_C.Image = global::Vaccum_agent.Properties.Resources.v1_r;
            this.pictureBox_Room_C.Location = new System.Drawing.Point(26, 295);
            this.pictureBox_Room_C.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Room_C.Name = "pictureBox_Room_C";
            this.pictureBox_Room_C.Size = new System.Drawing.Size(247, 217);
            this.pictureBox_Room_C.TabIndex = 7;
            this.pictureBox_Room_C.TabStop = false;
            this.pictureBox_Room_C.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox_Room_D
            // 
            this.pictureBox_Room_D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Room_D.Image = global::Vaccum_agent.Properties.Resources.v1_l;
            this.pictureBox_Room_D.Location = new System.Drawing.Point(309, 295);
            this.pictureBox_Room_D.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Room_D.Name = "pictureBox_Room_D";
            this.pictureBox_Room_D.Size = new System.Drawing.Size(247, 217);
            this.pictureBox_Room_D.TabIndex = 8;
            this.pictureBox_Room_D.TabStop = false;
            this.pictureBox_Room_D.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_Room_A
            // 
            this.pictureBox_Room_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Room_A.Image = global::Vaccum_agent.Properties.Resources.v1_r;
            this.pictureBox_Room_A.Location = new System.Drawing.Point(26, 32);
            this.pictureBox_Room_A.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Room_A.Name = "pictureBox_Room_A";
            this.pictureBox_Room_A.Size = new System.Drawing.Size(247, 217);
            this.pictureBox_Room_A.TabIndex = 0;
            this.pictureBox_Room_A.TabStop = false;
            // 
            // pictureBox_Room_B
            // 
            this.pictureBox_Room_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Room_B.Location = new System.Drawing.Point(309, 32);
            this.pictureBox_Room_B.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_Room_B.Name = "pictureBox_Room_B";
            this.pictureBox_Room_B.Size = new System.Drawing.Size(247, 217);
            this.pictureBox_Room_B.TabIndex = 0;
            this.pictureBox_Room_B.TabStop = false;
            this.pictureBox_Room_B.Click += new System.EventHandler(this.pictureBox_Room_B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btn_ResetToInitialState);
            this.Controls.Add(this.textBox_ProcessInformation);
            this.Controls.Add(this.label_RoomState_D);
            this.Controls.Add(this.label_RoomState_C);
            this.Controls.Add(this.label_Room_C);
            this.Controls.Add(this.label_Room_D);
            this.Controls.Add(this.pictureBox_Room_C);
            this.Controls.Add(this.pictureBox_Room_D);
            this.Controls.Add(this.label_RoomState_B);
            this.Controls.Add(this.label_RoomState_A);
            this.Controls.Add(this.btn_NoOperation);
            this.Controls.Add(this.btn_Clean);
            this.Controls.Add(this.label_Room_A);
            this.Controls.Add(this.label_Room_B);
            this.Controls.Add(this.pictureBox_Room_A);
            this.Controls.Add(this.pictureBox_Room_B);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1000, 800);
            this.MinimumSize = new System.Drawing.Size(866, 592);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room_C)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Room_B)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Room_A;
        private System.Windows.Forms.PictureBox pictureBox_Room_B;
        private System.Windows.Forms.PictureBox pictureBox_Room_C;
        private System.Windows.Forms.PictureBox pictureBox_Room_D;
        private System.Windows.Forms.Label label_Room_A;
        private System.Windows.Forms.Label label_Room_B;
        private System.Windows.Forms.Label label_Room_C;
        private System.Windows.Forms.Label label_Room_D;
        private System.Windows.Forms.Label label_RoomState_A;
        private System.Windows.Forms.Label label_RoomState_B;
        private System.Windows.Forms.Label label_RoomState_D;
        private System.Windows.Forms.Label label_RoomState_C;
        private System.Windows.Forms.Button btn_Clean;
        private System.Windows.Forms.Button btn_NoOperation;
        private System.Windows.Forms.Button btn_ResetToInitialState;
        private System.Windows.Forms.TextBox textBox_ProcessInformation;

    }
}

