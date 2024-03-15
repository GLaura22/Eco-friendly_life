namespace eco_friendly_life_winform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.habitLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.recipeSuggestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tippsAndTricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowPanel = new System.Windows.Forms.Panel();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.resultRecipeLabel = new System.Windows.Forms.Label();
            this.recipeButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.noMeatRadioButton = new System.Windows.Forms.RadioButton();
            this.meatRadioButton = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.ingLabel5 = new System.Windows.Forms.Label();
            this.ingLabel4 = new System.Windows.Forms.Label();
            this.ingLabel3 = new System.Windows.Forms.Label();
            this.ingLabel2 = new System.Windows.Forms.Label();
            this.ingLabel1 = new System.Windows.Forms.Label();
            this.ingredientComboBox5 = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox4 = new System.Windows.Forms.ComboBox();
            this.generalasButton = new System.Windows.Forms.Button();
            this.ingredientComboBox3 = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox2 = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox1 = new System.Windows.Forms.ComboBox();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.TippPanel = new System.Windows.Forms.Panel();
            this.dishPictureBox = new System.Windows.Forms.PictureBox();
            this.apiReadButton = new System.Windows.Forms.Button();
            this.todaysTippTextBox = new System.Windows.Forms.TextBox();
            this.tippLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.mainWindowPanel.SuspendLayout();
            this.RecipePanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.TippPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(35, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Eco-friendly life";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // habitLabel
            // 
            this.habitLabel.AutoSize = true;
            this.habitLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.habitLabel.Location = new System.Drawing.Point(3, 363);
            this.habitLabel.Name = "habitLabel";
            this.habitLabel.Size = new System.Drawing.Size(268, 30);
            this.habitLabel.TabIndex = 2;
            this.habitLabel.Text = "A változás velünk kezdődik!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeSuggestionToolStripMenuItem,
            this.tippsAndTricksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // recipeSuggestionToolStripMenuItem
            // 
            this.recipeSuggestionToolStripMenuItem.Name = "recipeSuggestionToolStripMenuItem";
            this.recipeSuggestionToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.recipeSuggestionToolStripMenuItem.Text = "Recipe suggestion";
            this.recipeSuggestionToolStripMenuItem.Click += new System.EventHandler(this.recipeSuggestionToolStripMenuItem_Click);
            // 
            // tippsAndTricksToolStripMenuItem
            // 
            this.tippsAndTricksToolStripMenuItem.Name = "tippsAndTricksToolStripMenuItem";
            this.tippsAndTricksToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.tippsAndTricksToolStripMenuItem.Text = "Tipps and Tricks";
            this.tippsAndTricksToolStripMenuItem.Click += new System.EventHandler(this.tippsAndTricksToolStripMenuItem_Click);
            // 
            // mainWindowPanel
            // 
            this.mainWindowPanel.Controls.Add(this.habitLabel);
            this.mainWindowPanel.Controls.Add(this.pictureBox1);
            this.mainWindowPanel.Controls.Add(this.titleLabel);
            this.mainWindowPanel.Location = new System.Drawing.Point(254, 60);
            this.mainWindowPanel.Name = "mainWindowPanel";
            this.mainWindowPanel.Size = new System.Drawing.Size(284, 409);
            this.mainWindowPanel.TabIndex = 4;
            // 
            // RecipePanel
            // 
            this.RecipePanel.Controls.Add(this.resultPanel);
            this.RecipePanel.Controls.Add(this.noMeatRadioButton);
            this.RecipePanel.Controls.Add(this.meatRadioButton);
            this.RecipePanel.Controls.Add(this.questionLabel);
            this.RecipePanel.Controls.Add(this.ingLabel5);
            this.RecipePanel.Controls.Add(this.ingLabel4);
            this.RecipePanel.Controls.Add(this.ingLabel3);
            this.RecipePanel.Controls.Add(this.ingLabel2);
            this.RecipePanel.Controls.Add(this.ingLabel1);
            this.RecipePanel.Controls.Add(this.ingredientComboBox5);
            this.RecipePanel.Controls.Add(this.ingredientComboBox4);
            this.RecipePanel.Controls.Add(this.generalasButton);
            this.RecipePanel.Controls.Add(this.ingredientComboBox3);
            this.RecipePanel.Controls.Add(this.ingredientComboBox2);
            this.RecipePanel.Controls.Add(this.ingredientComboBox1);
            this.RecipePanel.Controls.Add(this.IngredientsLabel);
            this.RecipePanel.Controls.Add(this.recipeLabel);
            this.RecipePanel.Location = new System.Drawing.Point(12, 73);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(740, 543);
            this.RecipePanel.TabIndex = 5;
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.resultRecipeLabel);
            this.resultPanel.Controls.Add(this.recipeButton);
            this.resultPanel.Controls.Add(this.resultPictureBox);
            this.resultPanel.Location = new System.Drawing.Point(342, 91);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(362, 340);
            this.resultPanel.TabIndex = 23;
            // 
            // resultRecipeLabel
            // 
            this.resultRecipeLabel.AutoSize = true;
            this.resultRecipeLabel.Location = new System.Drawing.Point(63, 231);
            this.resultRecipeLabel.Name = "resultRecipeLabel";
            this.resultRecipeLabel.Size = new System.Drawing.Size(0, 15);
            this.resultRecipeLabel.TabIndex = 23;
            // 
            // recipeButton
            // 
            this.recipeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.recipeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recipeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recipeButton.Location = new System.Drawing.Point(103, 273);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Size = new System.Drawing.Size(153, 46);
            this.recipeButton.TabIndex = 22;
            this.recipeButton.Text = "Recipe";
            this.recipeButton.UseVisualStyleBackColor = false;
            this.recipeButton.Click += new System.EventHandler(this.recipeButton_Click);
            // 
            // resultPictureBox
            // 
            this.resultPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("resultPictureBox.Image")));
            this.resultPictureBox.Location = new System.Drawing.Point(40, 19);
            this.resultPictureBox.Name = "resultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(292, 209);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 18;
            this.resultPictureBox.TabStop = false;
            // 
            // noMeatRadioButton
            // 
            this.noMeatRadioButton.AutoSize = true;
            this.noMeatRadioButton.Checked = true;
            this.noMeatRadioButton.Location = new System.Drawing.Point(126, 502);
            this.noMeatRadioButton.Name = "noMeatRadioButton";
            this.noMeatRadioButton.Size = new System.Drawing.Size(41, 19);
            this.noMeatRadioButton.TabIndex = 21;
            this.noMeatRadioButton.TabStop = true;
            this.noMeatRadioButton.Text = "No";
            this.noMeatRadioButton.UseVisualStyleBackColor = true;
            // 
            // meatRadioButton
            // 
            this.meatRadioButton.AutoSize = true;
            this.meatRadioButton.Location = new System.Drawing.Point(55, 502);
            this.meatRadioButton.Name = "meatRadioButton";
            this.meatRadioButton.Size = new System.Drawing.Size(42, 19);
            this.meatRadioButton.TabIndex = 20;
            this.meatRadioButton.Text = "Yes";
            this.meatRadioButton.UseVisualStyleBackColor = true;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(23, 465);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(189, 15);
            this.questionLabel.TabIndex = 19;
            this.questionLabel.Text = "Should the dish contain any meat?";
            // 
            // ingLabel5
            // 
            this.ingLabel5.AutoSize = true;
            this.ingLabel5.Location = new System.Drawing.Point(23, 381);
            this.ingLabel5.Name = "ingLabel5";
            this.ingLabel5.Size = new System.Drawing.Size(40, 15);
            this.ingLabel5.TabIndex = 17;
            this.ingLabel5.Text = "Other:";
            // 
            // ingLabel4
            // 
            this.ingLabel4.AutoSize = true;
            this.ingLabel4.Location = new System.Drawing.Point(23, 318);
            this.ingLabel4.Name = "ingLabel4";
            this.ingLabel4.Size = new System.Drawing.Size(37, 15);
            this.ingLabel4.TabIndex = 16;
            this.ingLabel4.Text = "Dairy:";
            // 
            // ingLabel3
            // 
            this.ingLabel3.AutoSize = true;
            this.ingLabel3.Location = new System.Drawing.Point(23, 253);
            this.ingLabel3.Name = "ingLabel3";
            this.ingLabel3.Size = new System.Drawing.Size(39, 15);
            this.ingLabel3.TabIndex = 15;
            this.ingLabel3.Text = "Fruits:";
            // 
            // ingLabel2
            // 
            this.ingLabel2.AutoSize = true;
            this.ingLabel2.Location = new System.Drawing.Point(23, 191);
            this.ingLabel2.Name = "ingLabel2";
            this.ingLabel2.Size = new System.Drawing.Size(66, 15);
            this.ingLabel2.TabIndex = 14;
            this.ingLabel2.Text = "Vegetables:";
            // 
            // ingLabel1
            // 
            this.ingLabel1.AutoSize = true;
            this.ingLabel1.Location = new System.Drawing.Point(23, 128);
            this.ingLabel1.Name = "ingLabel1";
            this.ingLabel1.Size = new System.Drawing.Size(37, 15);
            this.ingLabel1.TabIndex = 13;
            this.ingLabel1.Text = "Meat:";
            // 
            // ingredientComboBox5
            // 
            this.ingredientComboBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.ingredientComboBox5.ForeColor = System.Drawing.SystemColors.Window;
            this.ingredientComboBox5.FormattingEnabled = true;
            this.ingredientComboBox5.Location = new System.Drawing.Point(42, 402);
            this.ingredientComboBox5.Name = "ingredientComboBox5";
            this.ingredientComboBox5.Size = new System.Drawing.Size(218, 23);
            this.ingredientComboBox5.TabIndex = 12;
            // 
            // ingredientComboBox4
            // 
            this.ingredientComboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.ingredientComboBox4.ForeColor = System.Drawing.SystemColors.Window;
            this.ingredientComboBox4.FormattingEnabled = true;
            this.ingredientComboBox4.Location = new System.Drawing.Point(42, 336);
            this.ingredientComboBox4.MaxDropDownItems = 13;
            this.ingredientComboBox4.Name = "ingredientComboBox4";
            this.ingredientComboBox4.Size = new System.Drawing.Size(218, 23);
            this.ingredientComboBox4.TabIndex = 11;
            // 
            // generalasButton
            // 
            this.generalasButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.generalasButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generalasButton.ForeColor = System.Drawing.Color.White;
            this.generalasButton.Location = new System.Drawing.Point(555, 446);
            this.generalasButton.Name = "generalasButton";
            this.generalasButton.Size = new System.Drawing.Size(134, 54);
            this.generalasButton.TabIndex = 10;
            this.generalasButton.Text = "Generating";
            this.generalasButton.UseVisualStyleBackColor = false;
            this.generalasButton.Click += new System.EventHandler(this.generalasButton_Click);
            // 
            // ingredientComboBox3
            // 
            this.ingredientComboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.ingredientComboBox3.ForeColor = System.Drawing.SystemColors.Window;
            this.ingredientComboBox3.FormattingEnabled = true;
            this.ingredientComboBox3.Location = new System.Drawing.Point(42, 271);
            this.ingredientComboBox3.Name = "ingredientComboBox3";
            this.ingredientComboBox3.Size = new System.Drawing.Size(218, 23);
            this.ingredientComboBox3.TabIndex = 9;
            // 
            // ingredientComboBox2
            // 
            this.ingredientComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.ingredientComboBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.ingredientComboBox2.FormattingEnabled = true;
            this.ingredientComboBox2.Location = new System.Drawing.Point(42, 209);
            this.ingredientComboBox2.Name = "ingredientComboBox2";
            this.ingredientComboBox2.Size = new System.Drawing.Size(218, 23);
            this.ingredientComboBox2.TabIndex = 8;
            // 
            // ingredientComboBox1
            // 
            this.ingredientComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.ingredientComboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.ingredientComboBox1.FormattingEnabled = true;
            this.ingredientComboBox1.Location = new System.Drawing.Point(42, 147);
            this.ingredientComboBox1.Name = "ingredientComboBox1";
            this.ingredientComboBox1.Size = new System.Drawing.Size(218, 23);
            this.ingredientComboBox1.TabIndex = 7;
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(20, 81);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(175, 15);
            this.IngredientsLabel.TabIndex = 2;
            this.IngredientsLabel.Text = "Preffered ingredients (optional):";
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipeLabel.Location = new System.Drawing.Point(20, 38);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(318, 25);
            this.recipeLabel.TabIndex = 0;
            this.recipeLabel.Text = "Choose what kind of food you\'d like!";
            // 
            // TippPanel
            // 
            this.TippPanel.Controls.Add(this.dishPictureBox);
            this.TippPanel.Controls.Add(this.apiReadButton);
            this.TippPanel.Controls.Add(this.todaysTippTextBox);
            this.TippPanel.Controls.Add(this.tippLabel);
            this.TippPanel.Location = new System.Drawing.Point(221, 73);
            this.TippPanel.Name = "TippPanel";
            this.TippPanel.Size = new System.Drawing.Size(337, 408);
            this.TippPanel.TabIndex = 6;
            // 
            // dishPictureBox
            // 
            this.dishPictureBox.Location = new System.Drawing.Point(38, 280);
            this.dishPictureBox.Name = "dishPictureBox";
            this.dishPictureBox.Size = new System.Drawing.Size(263, 108);
            this.dishPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dishPictureBox.TabIndex = 3;
            this.dishPictureBox.TabStop = false;
            // 
            // apiReadButton
            // 
            this.apiReadButton.Location = new System.Drawing.Point(38, 71);
            this.apiReadButton.Name = "apiReadButton";
            this.apiReadButton.Size = new System.Drawing.Size(133, 35);
            this.apiReadButton.TabIndex = 2;
            this.apiReadButton.Text = "Read API";
            this.apiReadButton.UseVisualStyleBackColor = true;
            this.apiReadButton.Click += new System.EventHandler(this.apiReadButton_Click);
            // 
            // todaysTippTextBox
            // 
            this.todaysTippTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.todaysTippTextBox.Location = new System.Drawing.Point(30, 142);
            this.todaysTippTextBox.Multiline = true;
            this.todaysTippTextBox.Name = "todaysTippTextBox";
            this.todaysTippTextBox.Size = new System.Drawing.Size(271, 112);
            this.todaysTippTextBox.TabIndex = 1;
            // 
            // tippLabel
            // 
            this.tippLabel.AutoSize = true;
            this.tippLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tippLabel.Location = new System.Drawing.Point(21, 24);
            this.tippLabel.Name = "tippLabel";
            this.tippLabel.Size = new System.Drawing.Size(222, 25);
            this.tippLabel.TabIndex = 0;
            this.tippLabel.Text = "Today\'s eco-friendly tipp:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 640);
            this.Controls.Add(this.RecipePanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TippPanel);
            this.Controls.Add(this.mainWindowPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Eco-friendly life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainWindowPanel.ResumeLayout(false);
            this.mainWindowPanel.PerformLayout();
            this.RecipePanel.ResumeLayout(false);
            this.RecipePanel.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            this.TippPanel.ResumeLayout(false);
            this.TippPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
        private Label habitLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem recipeSuggestionToolStripMenuItem;
        private ToolStripMenuItem tippsAndTricksToolStripMenuItem;
        private Panel mainWindowPanel;
        private Panel RecipePanel;
        private Label recipeLabel;
        private Label IngredientsLabel;
        private ComboBox ingredientComboBox3;
        private ComboBox ingredientComboBox2;
        private ComboBox ingredientComboBox1;
        private Button generalasButton;
        private Panel TippPanel;
        private Label tippLabel;
        private TextBox todaysTippTextBox;
        private Button apiReadButton;
        private PictureBox dishPictureBox;
        private ComboBox ingredientComboBox4;
        private ComboBox ingredientComboBox5;
        private Button recipeButton;
        private RadioButton noMeatRadioButton;
        private RadioButton meatRadioButton;
        private Label questionLabel;
        private PictureBox resultPictureBox;
        private Label ingLabel5;
        private Label ingLabel4;
        private Label ingLabel3;
        private Label ingLabel2;
        private Label ingLabel1;
        private Panel resultPanel;
        private Label resultRecipeLabel;
    }
}