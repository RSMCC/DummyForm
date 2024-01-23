namespace DummyForm.View
{
    partial class AddProduct
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
            idLabel = new Label();
            titleLabel = new Label();
            priceLabel = new Label();
            idInput = new TextBox();
            titleInput = new TextBox();
            priceInput = new TextBox();
            addProductButton = new Button();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(87, 64);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(17, 15);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(87, 97);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(37, 15);
            titleLabel.TabIndex = 1;
            titleLabel.Text = "Título";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(87, 136);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(40, 15);
            priceLabel.TabIndex = 9;
            priceLabel.Text = "Precio";
            // 
            // idInput
            // 
            idInput.Location = new Point(133, 64);
            idInput.Name = "idInput";
            idInput.Size = new Size(100, 23);
            idInput.TabIndex = 10;
            // 
            // titleInput
            // 
            titleInput.Location = new Point(133, 94);
            titleInput.Name = "titleInput";
            titleInput.Size = new Size(100, 23);
            titleInput.TabIndex = 11;
            // 
            // priceInput
            // 
            priceInput.Location = new Point(133, 133);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(100, 23);
            priceInput.TabIndex = 12;
            // 
            // addProductButton
            // 
            addProductButton.BackColor = Color.DeepSkyBlue;
            addProductButton.ForeColor = SystemColors.Control;
            addProductButton.Location = new Point(108, 211);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(144, 34);
            addProductButton.TabIndex = 13;
            addProductButton.Text = "Confirmar y agregar";
            addProductButton.UseVisualStyleBackColor = false;
            addProductButton.Click += addProductButton_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 311);
            Controls.Add(addProductButton);
            Controls.Add(priceInput);
            Controls.Add(titleInput);
            Controls.Add(idInput);
            Controls.Add(priceLabel);
            Controls.Add(titleLabel);
            Controls.Add(idLabel);
            Name = "AddProduct";
            Text = "AddProduct";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label titleLabel;
        private Label priceLabel;
        private TextBox idInput;
        private TextBox titleInput;
        private TextBox priceInput;
        private Button addProductButton;
    }
}