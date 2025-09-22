namespace pizzaProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSizeOfPizza = new System.Windows.Forms.GroupBox();
            this.rbLargePizza = new System.Windows.Forms.RadioButton();
            this.rbMediumPizza = new System.Windows.Forms.RadioButton();
            this.rbSmallPizza = new System.Windows.Forms.RadioButton();
            this.gbCrustTypeOfPizza = new System.Windows.Forms.GroupBox();
            this.rbTuckPizza = new System.Windows.Forms.RadioButton();
            this.rbThinPizza = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbToppingsOfPizza = new System.Windows.Forms.GroupBox();
            this.chbGreenPepper = new System.Windows.Forms.CheckBox();
            this.chbOlives = new System.Windows.Forms.CheckBox();
            this.chbOnion = new System.Windows.Forms.CheckBox();
            this.chbTomatoes = new System.Windows.Forms.CheckBox();
            this.chbMushrooms = new System.Windows.Forms.CheckBox();
            this.chbExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.labPriceResult = new System.Windows.Forms.Label();
            this.labWhereToEatResult = new System.Windows.Forms.Label();
            this.labCrustTypeResult = new System.Windows.Forms.Label();
            this.labToppingResult = new System.Windows.Forms.Label();
            this.labSizeResult = new System.Windows.Forms.Label();
            this.labPrice = new System.Windows.Forms.Label();
            this.labWhereToEat = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.labTopping = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbSizeOfPizza.SuspendLayout();
            this.gbCrustTypeOfPizza.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppingsOfPizza.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbSizeOfPizza
            // 
            this.gbSizeOfPizza.Controls.Add(this.rbLargePizza);
            this.gbSizeOfPizza.Controls.Add(this.rbMediumPizza);
            this.gbSizeOfPizza.Controls.Add(this.rbSmallPizza);
            this.gbSizeOfPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSizeOfPizza.Location = new System.Drawing.Point(24, 112);
            this.gbSizeOfPizza.Name = "gbSizeOfPizza";
            this.gbSizeOfPizza.Size = new System.Drawing.Size(170, 192);
            this.gbSizeOfPizza.TabIndex = 1;
            this.gbSizeOfPizza.TabStop = false;
            this.gbSizeOfPizza.Text = "Size";
            // 
            // rbLargePizza
            // 
            this.rbLargePizza.AutoSize = true;
            this.rbLargePizza.Location = new System.Drawing.Point(17, 130);
            this.rbLargePizza.Name = "rbLargePizza";
            this.rbLargePizza.Size = new System.Drawing.Size(81, 26);
            this.rbLargePizza.TabIndex = 2;
            this.rbLargePizza.Tag = "17";
            this.rbLargePizza.Text = "Large";
            this.rbLargePizza.UseVisualStyleBackColor = true;
            this.rbLargePizza.CheckedChanged += new System.EventHandler(this.rbLargePizza_CheckedChanged);
            // 
            // rbMediumPizza
            // 
            this.rbMediumPizza.AutoSize = true;
            this.rbMediumPizza.Location = new System.Drawing.Point(17, 86);
            this.rbMediumPizza.Name = "rbMediumPizza";
            this.rbMediumPizza.Size = new System.Drawing.Size(97, 26);
            this.rbMediumPizza.TabIndex = 1;
            this.rbMediumPizza.Tag = "15";
            this.rbMediumPizza.Text = "Medium";
            this.rbMediumPizza.UseVisualStyleBackColor = true;
            this.rbMediumPizza.CheckedChanged += new System.EventHandler(this.rbMediumPizza_CheckedChanged);
            // 
            // rbSmallPizza
            // 
            this.rbSmallPizza.AutoSize = true;
            this.rbSmallPizza.Location = new System.Drawing.Point(17, 42);
            this.rbSmallPizza.Name = "rbSmallPizza";
            this.rbSmallPizza.Size = new System.Drawing.Size(79, 26);
            this.rbSmallPizza.TabIndex = 0;
            this.rbSmallPizza.Tag = "10";
            this.rbSmallPizza.Text = "Small";
            this.rbSmallPizza.UseVisualStyleBackColor = true;
            this.rbSmallPizza.CheckedChanged += new System.EventHandler(this.rbSmallPizza_CheckedChanged);
            // 
            // gbCrustTypeOfPizza
            // 
            this.gbCrustTypeOfPizza.Controls.Add(this.rbTuckPizza);
            this.gbCrustTypeOfPizza.Controls.Add(this.rbThinPizza);
            this.gbCrustTypeOfPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrustTypeOfPizza.Location = new System.Drawing.Point(30, 310);
            this.gbCrustTypeOfPizza.Name = "gbCrustTypeOfPizza";
            this.gbCrustTypeOfPizza.Size = new System.Drawing.Size(164, 174);
            this.gbCrustTypeOfPizza.TabIndex = 2;
            this.gbCrustTypeOfPizza.TabStop = false;
            this.gbCrustTypeOfPizza.Text = "Crust type";
            // 
            // rbTuckPizza
            // 
            this.rbTuckPizza.AutoSize = true;
            this.rbTuckPizza.Location = new System.Drawing.Point(17, 86);
            this.rbTuckPizza.Name = "rbTuckPizza";
            this.rbTuckPizza.Size = new System.Drawing.Size(75, 26);
            this.rbTuckPizza.TabIndex = 1;
            this.rbTuckPizza.Tag = "0";
            this.rbTuckPizza.Text = "Tuck";
            this.rbTuckPizza.UseVisualStyleBackColor = true;
            this.rbTuckPizza.CheckedChanged += new System.EventHandler(this.rbTuckPizza_CheckedChanged);
            // 
            // rbThinPizza
            // 
            this.rbThinPizza.AutoSize = true;
            this.rbThinPizza.Location = new System.Drawing.Point(17, 42);
            this.rbThinPizza.Name = "rbThinPizza";
            this.rbThinPizza.Size = new System.Drawing.Size(71, 26);
            this.rbThinPizza.TabIndex = 0;
            this.rbThinPizza.Tag = "5";
            this.rbThinPizza.Text = "Thin";
            this.rbThinPizza.UseVisualStyleBackColor = true;
            this.rbThinPizza.CheckedChanged += new System.EventHandler(this.rbThinPizza_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.Location = new System.Drawing.Point(230, 329);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(320, 80);
            this.gbWhereToEat.TabIndex = 3;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(128, 42);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(110, 26);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Location = new System.Drawing.Point(17, 42);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(81, 26);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.Tag = "";
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbToppingsOfPizza
            // 
            this.gbToppingsOfPizza.Controls.Add(this.chbGreenPepper);
            this.gbToppingsOfPizza.Controls.Add(this.chbOlives);
            this.gbToppingsOfPizza.Controls.Add(this.chbOnion);
            this.gbToppingsOfPizza.Controls.Add(this.chbTomatoes);
            this.gbToppingsOfPizza.Controls.Add(this.chbMushrooms);
            this.gbToppingsOfPizza.Controls.Add(this.chbExtraCheese);
            this.gbToppingsOfPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppingsOfPizza.Location = new System.Drawing.Point(230, 115);
            this.gbToppingsOfPizza.Name = "gbToppingsOfPizza";
            this.gbToppingsOfPizza.Size = new System.Drawing.Size(322, 189);
            this.gbToppingsOfPizza.TabIndex = 4;
            this.gbToppingsOfPizza.TabStop = false;
            this.gbToppingsOfPizza.Text = "Toppings";
            // 
            // chbGreenPepper
            // 
            this.chbGreenPepper.AutoSize = true;
            this.chbGreenPepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chbGreenPepper.Location = new System.Drawing.Point(181, 127);
            this.chbGreenPepper.Name = "chbGreenPepper";
            this.chbGreenPepper.Size = new System.Drawing.Size(139, 24);
            this.chbGreenPepper.TabIndex = 5;
            this.chbGreenPepper.Tag = "5";
            this.chbGreenPepper.Text = "Green Pepper";
            this.chbGreenPepper.UseVisualStyleBackColor = true;
            this.chbGreenPepper.CheckedChanged += new System.EventHandler(this.chbGreenPepper_CheckedChanged);
            // 
            // chbOlives
            // 
            this.chbOlives.AutoSize = true;
            this.chbOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chbOlives.Location = new System.Drawing.Point(181, 83);
            this.chbOlives.Name = "chbOlives";
            this.chbOlives.Size = new System.Drawing.Size(82, 24);
            this.chbOlives.TabIndex = 4;
            this.chbOlives.Tag = "5";
            this.chbOlives.Text = "Olives";
            this.chbOlives.UseVisualStyleBackColor = true;
            this.chbOlives.CheckedChanged += new System.EventHandler(this.chbOlives_CheckedChanged);
            // 
            // chbOnion
            // 
            this.chbOnion.AutoSize = true;
            this.chbOnion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chbOnion.Location = new System.Drawing.Point(181, 39);
            this.chbOnion.Name = "chbOnion";
            this.chbOnion.Size = new System.Drawing.Size(79, 24);
            this.chbOnion.TabIndex = 3;
            this.chbOnion.Tag = "5";
            this.chbOnion.Text = "Onion";
            this.chbOnion.UseVisualStyleBackColor = true;
            this.chbOnion.CheckedChanged += new System.EventHandler(this.chbOnion_CheckedChanged);
            // 
            // chbTomatoes
            // 
            this.chbTomatoes.AutoSize = true;
            this.chbTomatoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chbTomatoes.Location = new System.Drawing.Point(17, 130);
            this.chbTomatoes.Name = "chbTomatoes";
            this.chbTomatoes.Size = new System.Drawing.Size(109, 24);
            this.chbTomatoes.TabIndex = 2;
            this.chbTomatoes.Tag = "5";
            this.chbTomatoes.Text = "Tomatoes";
            this.chbTomatoes.UseVisualStyleBackColor = true;
            this.chbTomatoes.CheckedChanged += new System.EventHandler(this.chbTomatoes_CheckedChanged);
            // 
            // chbMushrooms
            // 
            this.chbMushrooms.AutoSize = true;
            this.chbMushrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chbMushrooms.Location = new System.Drawing.Point(17, 83);
            this.chbMushrooms.Name = "chbMushrooms";
            this.chbMushrooms.Size = new System.Drawing.Size(123, 24);
            this.chbMushrooms.TabIndex = 1;
            this.chbMushrooms.Tag = "5";
            this.chbMushrooms.Text = "Mushrooms";
            this.chbMushrooms.UseVisualStyleBackColor = true;
            this.chbMushrooms.CheckedChanged += new System.EventHandler(this.chbMushrooms_CheckedChanged);
            // 
            // chbExtraCheese
            // 
            this.chbExtraCheese.AutoSize = true;
            this.chbExtraCheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.chbExtraCheese.Location = new System.Drawing.Point(17, 39);
            this.chbExtraCheese.Name = "chbExtraCheese";
            this.chbExtraCheese.Size = new System.Drawing.Size(136, 24);
            this.chbExtraCheese.TabIndex = 0;
            this.chbExtraCheese.Tag = "5";
            this.chbExtraCheese.Text = "Extra Cheese";
            this.chbExtraCheese.UseVisualStyleBackColor = true;
            this.chbExtraCheese.CheckedChanged += new System.EventHandler(this.chbExtraCheese_CheckedChanged);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.labPriceResult);
            this.gbOrderSummary.Controls.Add(this.labWhereToEatResult);
            this.gbOrderSummary.Controls.Add(this.labCrustTypeResult);
            this.gbOrderSummary.Controls.Add(this.labToppingResult);
            this.gbOrderSummary.Controls.Add(this.labSizeResult);
            this.gbOrderSummary.Controls.Add(this.labPrice);
            this.gbOrderSummary.Controls.Add(this.labWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labCrustType);
            this.gbOrderSummary.Controls.Add(this.labTopping);
            this.gbOrderSummary.Controls.Add(this.labSize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(569, 91);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(302, 399);
            this.gbOrderSummary.TabIndex = 5;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // labPriceResult
            // 
            this.labPriceResult.AutoSize = true;
            this.labPriceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPriceResult.ForeColor = System.Drawing.Color.Green;
            this.labPriceResult.Location = new System.Drawing.Point(143, 316);
            this.labPriceResult.Name = "labPriceResult";
            this.labPriceResult.Size = new System.Drawing.Size(59, 40);
            this.labPriceResult.TabIndex = 9;
            this.labPriceResult.Text = "0$";
            this.labPriceResult.Visible = false;
            // 
            // labWhereToEatResult
            // 
            this.labWhereToEatResult.AutoSize = true;
            this.labWhereToEatResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWhereToEatResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labWhereToEatResult.Location = new System.Drawing.Point(174, 248);
            this.labWhereToEatResult.Name = "labWhereToEatResult";
            this.labWhereToEatResult.Size = new System.Drawing.Size(63, 25);
            this.labWhereToEatResult.TabIndex = 8;
            this.labWhereToEatResult.Text = "None";
            this.labWhereToEatResult.Visible = false;
            // 
            // labCrustTypeResult
            // 
            this.labCrustTypeResult.AutoSize = true;
            this.labCrustTypeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustTypeResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labCrustTypeResult.Location = new System.Drawing.Point(174, 209);
            this.labCrustTypeResult.Name = "labCrustTypeResult";
            this.labCrustTypeResult.Size = new System.Drawing.Size(63, 25);
            this.labCrustTypeResult.TabIndex = 7;
            this.labCrustTypeResult.Text = "None";
            this.labCrustTypeResult.Visible = false;
            // 
            // labToppingResult
            // 
            this.labToppingResult.AutoSize = true;
            this.labToppingResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppingResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labToppingResult.Location = new System.Drawing.Point(24, 122);
            this.labToppingResult.MaximumSize = new System.Drawing.Size(290, 0);
            this.labToppingResult.Name = "labToppingResult";
            this.labToppingResult.Size = new System.Drawing.Size(63, 25);
            this.labToppingResult.TabIndex = 6;
            this.labToppingResult.Text = "None";
            this.labToppingResult.Visible = false;
            // 
            // labSizeResult
            // 
            this.labSizeResult.AutoSize = true;
            this.labSizeResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSizeResult.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labSizeResult.Location = new System.Drawing.Point(133, 43);
            this.labSizeResult.Name = "labSizeResult";
            this.labSizeResult.Size = new System.Drawing.Size(63, 25);
            this.labSizeResult.TabIndex = 5;
            this.labSizeResult.Text = "None";
            this.labSizeResult.Visible = false;
            // 
            // labPrice
            // 
            this.labPrice.AutoSize = true;
            this.labPrice.Location = new System.Drawing.Point(21, 293);
            this.labPrice.Name = "labPrice";
            this.labPrice.Size = new System.Drawing.Size(116, 25);
            this.labPrice.TabIndex = 4;
            this.labPrice.Text = "Total Price :";
            // 
            // labWhereToEat
            // 
            this.labWhereToEat.AutoSize = true;
            this.labWhereToEat.Location = new System.Drawing.Point(21, 248);
            this.labWhereToEat.Name = "labWhereToEat";
            this.labWhereToEat.Size = new System.Drawing.Size(139, 25);
            this.labWhereToEat.TabIndex = 3;
            this.labWhereToEat.Text = "where To Eat :";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Location = new System.Drawing.Point(21, 209);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(120, 25);
            this.labCrustType.TabIndex = 2;
            this.labCrustType.Text = "Crust Type :";
            // 
            // labTopping
            // 
            this.labTopping.AutoSize = true;
            this.labTopping.Location = new System.Drawing.Point(21, 82);
            this.labTopping.Name = "labTopping";
            this.labTopping.Size = new System.Drawing.Size(105, 25);
            this.labTopping.TabIndex = 1;
            this.labTopping.Text = "Toppings :";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labSize.Location = new System.Drawing.Point(21, 43);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(62, 25);
            this.labSize.TabIndex = 0;
            this.labSize.Text = "Size :";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(230, 436);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(126, 38);
            this.btnOrderPizza.TabIndex = 6;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(426, 436);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(126, 38);
            this.btnResetForm.TabIndex = 7;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 496);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppingsOfPizza);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustTypeOfPizza);
            this.Controls.Add(this.gbSizeOfPizza);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbSizeOfPizza.ResumeLayout(false);
            this.gbSizeOfPizza.PerformLayout();
            this.gbCrustTypeOfPizza.ResumeLayout(false);
            this.gbCrustTypeOfPizza.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppingsOfPizza.ResumeLayout(false);
            this.gbToppingsOfPizza.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSizeOfPizza;
        private System.Windows.Forms.RadioButton rbLargePizza;
        private System.Windows.Forms.RadioButton rbMediumPizza;
        private System.Windows.Forms.RadioButton rbSmallPizza;
        private System.Windows.Forms.GroupBox gbCrustTypeOfPizza;
        private System.Windows.Forms.RadioButton rbTuckPizza;
        private System.Windows.Forms.RadioButton rbThinPizza;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbToppingsOfPizza;
        private System.Windows.Forms.CheckBox chbOlives;
        private System.Windows.Forms.CheckBox chbOnion;
        private System.Windows.Forms.CheckBox chbTomatoes;
        private System.Windows.Forms.CheckBox chbMushrooms;
        private System.Windows.Forms.CheckBox chbExtraCheese;
        private System.Windows.Forms.CheckBox chbGreenPepper;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label labTopping;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Label labSizeResult;
        private System.Windows.Forms.Label labPrice;
        private System.Windows.Forms.Label labWhereToEat;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label labCrustTypeResult;
        private System.Windows.Forms.Label labToppingResult;
        private System.Windows.Forms.Label labPriceResult;
        private System.Windows.Forms.Label labWhereToEatResult;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
    }
}

