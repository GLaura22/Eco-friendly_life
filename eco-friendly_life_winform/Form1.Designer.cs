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
            this.reviewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.noMeatRadioButton = new System.Windows.Forms.RadioButton();
            this.meatRadioButton = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.ingLabel3 = new System.Windows.Forms.Label();
            this.ingLabel2 = new System.Windows.Forms.Label();
            this.ingLabel1 = new System.Windows.Forms.Label();
            this.generalasButton = new System.Windows.Forms.Button();
            this.ingredientComboBox3 = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox2 = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox1 = new System.Windows.Forms.ComboBox();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.ingredientsButton = new System.Windows.Forms.Button();
            this.carbonFootprintLabel = new System.Windows.Forms.Label();
            this.resultRecipeLabel = new System.Windows.Forms.Label();
            this.recipeButton = new System.Windows.Forms.Button();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.TippPanel = new System.Windows.Forms.Panel();
            this.dishPictureBox = new System.Windows.Forms.PictureBox();
            this.todaysTippTextBox = new System.Windows.Forms.TextBox();
            this.tippLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.ratingPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.commentsDataGridView = new System.Windows.Forms.DataGridView();
            this.UserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MealColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rateButton = new System.Windows.Forms.Button();
            this.ratingBar = new System.Windows.Forms.TrackBar();
            this.ratedMealNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.optionsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.mainWindowPanel.SuspendLayout();
            this.RecipePanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            this.TippPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishPictureBox)).BeginInit();
            this.ratingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBar)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.Location = new System.Drawing.Point(65, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Eco-friendly life";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 65);
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
            this.habitLabel.Location = new System.Drawing.Point(25, 363);
            this.habitLabel.Name = "habitLabel";
            this.habitLabel.Size = new System.Drawing.Size(319, 60);
            this.habitLabel.TabIndex = 2;
            this.habitLabel.Text = "       \"Change starts with you, \n but it doesn\'t start until you do.\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recipeSuggestionToolStripMenuItem,
            this.tippsAndTricksToolStripMenuItem,
            this.reviewsToolStripMenuItem});
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
            this.tippsAndTricksToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.tippsAndTricksToolStripMenuItem.Text = "Tips and Tricks";
            this.tippsAndTricksToolStripMenuItem.Click += new System.EventHandler(this.tippsAndTricksToolStripMenuItem_Click);
            // 
            // reviewsToolStripMenuItem
            // 
            this.reviewsToolStripMenuItem.Name = "reviewsToolStripMenuItem";
            this.reviewsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.reviewsToolStripMenuItem.Text = "Reviews";
            this.reviewsToolStripMenuItem.Click += new System.EventHandler(this.reviewsToolStripMenuItem_Click);
            // 
            // mainWindowPanel
            // 
            this.mainWindowPanel.Controls.Add(this.label2);
            this.mainWindowPanel.Controls.Add(this.habitLabel);
            this.mainWindowPanel.Controls.Add(this.pictureBox1);
            this.mainWindowPanel.Controls.Add(this.titleLabel);
            this.mainWindowPanel.Location = new System.Drawing.Point(224, 60);
            this.mainWindowPanel.Name = "mainWindowPanel";
            this.mainWindowPanel.Size = new System.Drawing.Size(434, 474);
            this.mainWindowPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(286, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tom Ziglar";
            // 
            // RecipePanel
            // 
            this.RecipePanel.Controls.Add(this.optionsButton);
            this.RecipePanel.Controls.Add(this.label1);
            this.RecipePanel.Controls.Add(this.noMeatRadioButton);
            this.RecipePanel.Controls.Add(this.meatRadioButton);
            this.RecipePanel.Controls.Add(this.questionLabel);
            this.RecipePanel.Controls.Add(this.ingLabel3);
            this.RecipePanel.Controls.Add(this.ingLabel2);
            this.RecipePanel.Controls.Add(this.ingLabel1);
            this.RecipePanel.Controls.Add(this.generalasButton);
            this.RecipePanel.Controls.Add(this.ingredientComboBox3);
            this.RecipePanel.Controls.Add(this.ingredientComboBox2);
            this.RecipePanel.Controls.Add(this.ingredientComboBox1);
            this.RecipePanel.Controls.Add(this.IngredientsLabel);
            this.RecipePanel.Controls.Add(this.recipeLabel);
            this.RecipePanel.Controls.Add(this.resultPanel);
            this.RecipePanel.Location = new System.Drawing.Point(12, 73);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(740, 543);
            this.RecipePanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "If you didn\'t choose any preffered ingredients";
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
            this.questionLabel.Size = new System.Drawing.Size(188, 15);
            this.questionLabel.TabIndex = 19;
            this.questionLabel.Text = "should the dish contain any meat?";
            // 
            // ingLabel3
            // 
            this.ingLabel3.AutoSize = true;
            this.ingLabel3.Location = new System.Drawing.Point(23, 253);
            this.ingLabel3.Name = "ingLabel3";
            this.ingLabel3.Size = new System.Drawing.Size(94, 15);
            this.ingLabel3.TabIndex = 15;
            this.ingLabel3.Text = "Third ingredient:";
            // 
            // ingLabel2
            // 
            this.ingLabel2.AutoSize = true;
            this.ingLabel2.Location = new System.Drawing.Point(23, 191);
            this.ingLabel2.Name = "ingLabel2";
            this.ingLabel2.Size = new System.Drawing.Size(106, 15);
            this.ingLabel2.TabIndex = 14;
            this.ingLabel2.Text = "Second ingredient:";
            // 
            // ingLabel1
            // 
            this.ingLabel1.AutoSize = true;
            this.ingLabel1.Location = new System.Drawing.Point(23, 128);
            this.ingLabel1.Name = "ingLabel1";
            this.ingLabel1.Size = new System.Drawing.Size(89, 15);
            this.ingLabel1.TabIndex = 13;
            this.ingLabel1.Text = "First ingredient:";
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
            this.generalasButton.Text = "Generate";
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
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.ingredientsButton);
            this.resultPanel.Controls.Add(this.carbonFootprintLabel);
            this.resultPanel.Controls.Add(this.resultRecipeLabel);
            this.resultPanel.Controls.Add(this.recipeButton);
            this.resultPanel.Controls.Add(this.resultPictureBox);
            this.resultPanel.Location = new System.Drawing.Point(342, 91);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(362, 340);
            this.resultPanel.TabIndex = 23;
            // 
            // ingredientsButton
            // 
            this.ingredientsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.ingredientsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ingredientsButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ingredientsButton.Location = new System.Drawing.Point(213, 288);
            this.ingredientsButton.Name = "ingredientsButton";
            this.ingredientsButton.Size = new System.Drawing.Size(119, 46);
            this.ingredientsButton.TabIndex = 25;
            this.ingredientsButton.Text = "Ingredients";
            this.ingredientsButton.UseVisualStyleBackColor = false;
            this.ingredientsButton.Click += new System.EventHandler(this.ingredientsButton_Click);
            // 
            // carbonFootprintLabel
            // 
            this.carbonFootprintLabel.AutoSize = true;
            this.carbonFootprintLabel.Location = new System.Drawing.Point(255, 244);
            this.carbonFootprintLabel.Name = "carbonFootprintLabel";
            this.carbonFootprintLabel.Size = new System.Drawing.Size(104, 15);
            this.carbonFootprintLabel.TabIndex = 24;
            this.carbonFootprintLabel.Text = "*carbon footprint*";
            // 
            // resultRecipeLabel
            // 
            this.resultRecipeLabel.AutoSize = true;
            this.resultRecipeLabel.Location = new System.Drawing.Point(40, 244);
            this.resultRecipeLabel.Name = "resultRecipeLabel";
            this.resultRecipeLabel.Size = new System.Drawing.Size(82, 15);
            this.resultRecipeLabel.TabIndex = 23;
            this.resultRecipeLabel.Text = "*recipe name*";
            // 
            // recipeButton
            // 
            this.recipeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.recipeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recipeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.recipeButton.Location = new System.Drawing.Point(48, 288);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Size = new System.Drawing.Size(102, 46);
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
            // TippPanel
            // 
            this.TippPanel.Controls.Add(this.dishPictureBox);
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
            // todaysTippTextBox
            // 
            this.todaysTippTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.todaysTippTextBox.Location = new System.Drawing.Point(30, 142);
            this.todaysTippTextBox.Multiline = true;
            this.todaysTippTextBox.Name = "todaysTippTextBox";
            this.todaysTippTextBox.ReadOnly = true;
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
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.userNameLabel.Location = new System.Drawing.Point(609, 35);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(53, 21);
            this.userNameLabel.TabIndex = 7;
            this.userNameLabel.Text = "label3";
            // 
            // ratingPanel
            // 
            this.ratingPanel.Controls.Add(this.label8);
            this.ratingPanel.Controls.Add(this.label7);
            this.ratingPanel.Controls.Add(this.commentsDataGridView);
            this.ratingPanel.Controls.Add(this.pictureBox2);
            this.ratingPanel.Controls.Add(this.rateButton);
            this.ratingPanel.Controls.Add(this.ratingBar);
            this.ratingPanel.Controls.Add(this.ratedMealNameTextBox);
            this.ratingPanel.Controls.Add(this.label6);
            this.ratingPanel.Controls.Add(this.label5);
            this.ratingPanel.Controls.Add(this.label4);
            this.ratingPanel.Controls.Add(this.label3);
            this.ratingPanel.Location = new System.Drawing.Point(15, 59);
            this.ratingPanel.Name = "ratingPanel";
            this.ratingPanel.Size = new System.Drawing.Size(757, 569);
            this.ratingPanel.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(472, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(203, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "1";
            // 
            // commentsDataGridView
            // 
            this.commentsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.commentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.commentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserColumn,
            this.MealColumn,
            this.RatingColumn,
            this.ImageColumn});
            this.commentsDataGridView.GridColor = System.Drawing.SystemColors.MenuBar;
            this.commentsDataGridView.Location = new System.Drawing.Point(20, 328);
            this.commentsDataGridView.Name = "commentsDataGridView";
            this.commentsDataGridView.RowTemplate.Height = 25;
            this.commentsDataGridView.Size = new System.Drawing.Size(697, 226);
            this.commentsDataGridView.TabIndex = 9;
            // 
            // UserColumn
            // 
            this.UserColumn.HeaderText = "User";
            this.UserColumn.Name = "UserColumn";
            this.UserColumn.ReadOnly = true;
            // 
            // MealColumn
            // 
            this.MealColumn.HeaderText = "Meal";
            this.MealColumn.Name = "MealColumn";
            this.MealColumn.ReadOnly = true;
            // 
            // RatingColumn
            // 
            this.RatingColumn.HeaderText = "Rating";
            this.RatingColumn.Name = "RatingColumn";
            this.RatingColumn.ReadOnly = true;
            // 
            // ImageColumn
            // 
            this.ImageColumn.HeaderText = "Image of it";
            this.ImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageColumn.Name = "ImageColumn";
            this.ImageColumn.ReadOnly = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(215, 181);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rateButton
            // 
            this.rateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.rateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rateButton.Location = new System.Drawing.Point(479, 233);
            this.rateButton.Name = "rateButton";
            this.rateButton.Size = new System.Drawing.Size(95, 45);
            this.rateButton.TabIndex = 7;
            this.rateButton.Text = "OK";
            this.rateButton.UseVisualStyleBackColor = false;
            this.rateButton.Click += new System.EventHandler(this.rateButton_Click);
            // 
            // ratingBar
            // 
            this.ratingBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.ratingBar.Location = new System.Drawing.Point(226, 118);
            this.ratingBar.Maximum = 5;
            this.ratingBar.Minimum = 1;
            this.ratingBar.Name = "ratingBar";
            this.ratingBar.Size = new System.Drawing.Size(232, 45);
            this.ratingBar.TabIndex = 5;
            this.ratingBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.ratingBar.Value = 1;
            // 
            // ratedMealNameTextBox
            // 
            this.ratedMealNameTextBox.Location = new System.Drawing.Point(277, 86);
            this.ratedMealNameTextBox.Name = "ratedMealNameTextBox";
            this.ratedMealNameTextBox.Size = new System.Drawing.Size(275, 23);
            this.ratedMealNameTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "A picture of it:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "How well it turned out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "The name of the recipe you prepared:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(52, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(522, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Have you made one of the recipes? Share the results with us!";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // optionsButton
            // 
            this.optionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(143)))), ((int)(((byte)(224)))));
            this.optionsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.optionsButton.ForeColor = System.Drawing.Color.White;
            this.optionsButton.Location = new System.Drawing.Point(387, 446);
            this.optionsButton.Name = "optionsButton";
            this.optionsButton.Size = new System.Drawing.Size(123, 54);
            this.optionsButton.TabIndex = 25;
            this.optionsButton.Text = "Other options";
            this.optionsButton.UseVisualStyleBackColor = false;
            this.optionsButton.Click += new System.EventHandler(this.optionsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 640);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.RecipePanel);
            this.Controls.Add(this.TippPanel);
            this.Controls.Add(this.ratingPanel);
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
            this.ratingPanel.ResumeLayout(false);
            this.ratingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commentsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingBar)).EndInit();
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
        private PictureBox dishPictureBox;
        private Button recipeButton;
        private RadioButton noMeatRadioButton;
        private RadioButton meatRadioButton;
        private Label questionLabel;
        private PictureBox resultPictureBox;
        private Label ingLabel3;
        private Label ingLabel2;
        private Label ingLabel1;
        private Panel resultPanel;
        private Label resultRecipeLabel;
        private Label carbonFootprintLabel;
        private Label label1;
        private Button ingredientsButton;
        private Label label2;
        private Label userNameLabel;
        private ToolStripMenuItem reviewsToolStripMenuItem;
        private Panel ratingPanel;
        private Button rateButton;
        private TrackBar ratingBar;
        private TextBox ratedMealNameTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox2;
        private DataGridView commentsDataGridView;
        private DataGridViewTextBoxColumn UserColumn;
        private DataGridViewTextBoxColumn MealColumn;
        private DataGridViewTextBoxColumn RatingColumn;
        private DataGridViewImageColumn ImageColumn;
        private Label label8;
        private Label label7;
        private Button optionsButton;
    }
}