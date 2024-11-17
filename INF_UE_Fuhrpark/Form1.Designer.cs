namespace INF_UE_Fuhrpark
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
            cbMarken = new ComboBox();
            cbModel = new ComboBox();
            cbColor = new ComboBox();
            tbPrice = new TextBox();
            lbCars = new ListBox();
            label1 = new Label();
            lblPriceGes = new Label();
            btAdd = new Button();
            btRemove = new Button();
            btUp = new Button();
            btDown = new Button();
            SuspendLayout();
            // 
            // cbMarken
            // 
            cbMarken.FormattingEnabled = true;
            cbMarken.Location = new Point(42, 75);
            cbMarken.Name = "cbMarken";
            cbMarken.Size = new Size(242, 40);
            cbMarken.TabIndex = 0;
            cbMarken.SelectedIndexChanged += cbMarken_SelectedIndexChanged;
            // 
            // cbModel
            // 
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(42, 141);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(242, 40);
            cbModel.TabIndex = 1;
            // 
            // cbColor
            // 
            cbColor.FormattingEnabled = true;
            cbColor.Location = new Point(42, 210);
            cbColor.Name = "cbColor";
            cbColor.Size = new Size(242, 40);
            cbColor.TabIndex = 2;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(65, 286);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(200, 39);
            tbPrice.TabIndex = 3;
            // 
            // lbCars
            // 
            lbCars.FormattingEnabled = true;
            lbCars.ItemHeight = 32;
            lbCars.Location = new Point(773, 53);
            lbCars.Name = "lbCars";
            lbCars.Size = new Size(410, 548);
            lbCars.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(773, 633);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 5;
            label1.Text = "Worth: ";
            // 
            // lblPriceGes
            // 
            lblPriceGes.AutoSize = true;
            lblPriceGes.Location = new Point(870, 633);
            lblPriceGes.Name = "lblPriceGes";
            lblPriceGes.Size = new Size(25, 32);
            lblPriceGes.TabIndex = 6;
            lblPriceGes.Text = "?";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(593, 53);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(150, 46);
            btAdd.TabIndex = 7;
            btAdd.Text = "Add Car";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(593, 124);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(150, 43);
            btRemove.TabIndex = 8;
            btRemove.Text = "Remove Car";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // btUp
            // 
            btUp.Location = new Point(581, 204);
            btUp.Name = "btUp";
            btUp.Size = new Size(174, 46);
            btUp.TabIndex = 9;
            btUp.Text = "Move up";
            btUp.UseVisualStyleBackColor = true;
            btUp.Click += btUp_Click;
            // 
            // btDown
            // 
            btDown.Location = new Point(581, 268);
            btDown.Name = "btDown";
            btDown.Size = new Size(174, 45);
            btDown.TabIndex = 10;
            btDown.Text = "Move Down";
            btDown.UseVisualStyleBackColor = true;
            btDown.Click += btDown_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 754);
            Controls.Add(btDown);
            Controls.Add(btUp);
            Controls.Add(btRemove);
            Controls.Add(btAdd);
            Controls.Add(lblPriceGes);
            Controls.Add(label1);
            Controls.Add(lbCars);
            Controls.Add(tbPrice);
            Controls.Add(cbColor);
            Controls.Add(cbModel);
            Controls.Add(cbMarken);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMarken;
        private ComboBox cbModel;
        private ComboBox cbColor;
        private TextBox tbPrice;
        private ListBox lbCars;
        private Label label1;
        private Label lblPriceGes;
        private Button btAdd;
        private Button btRemove;
        private Button btUp;
        private Button btDown;
    }
}
