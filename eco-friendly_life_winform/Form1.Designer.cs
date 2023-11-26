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
            this.nearestRecycleBinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tippsAndTricksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowPanel = new System.Windows.Forms.Panel();
            this.RecipePanel = new System.Windows.Forms.Panel();
            this.generalasButton = new System.Windows.Forms.Button();
            this.ingredientComboBox3 = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox2 = new System.Windows.Forms.ComboBox();
            this.ingredientComboBox1 = new System.Windows.Forms.ComboBox();
            this.soupCheckBox = new System.Windows.Forms.CheckBox();
            this.dessertCheckBox = new System.Windows.Forms.CheckBox();
            this.mainDishCheckBox = new System.Windows.Forms.CheckBox();
            this.appetizerCheckBox = new System.Windows.Forms.CheckBox();
            this.IngredientsLabel = new System.Windows.Forms.Label();
            this.DishTypeLabel = new System.Windows.Forms.Label();
            this.recipeLabel = new System.Windows.Forms.Label();
            this.TippPanel = new System.Windows.Forms.Panel();
            this.todaysTippTextBox = new System.Windows.Forms.TextBox();
            this.tippLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.mainWindowPanel.SuspendLayout();
            this.RecipePanel.SuspendLayout();
            this.TippPanel.SuspendLayout();
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
            this.nearestRecycleBinToolStripMenuItem,
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
            // nearestRecycleBinToolStripMenuItem
            // 
            this.nearestRecycleBinToolStripMenuItem.Name = "nearestRecycleBinToolStripMenuItem";
            this.nearestRecycleBinToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.nearestRecycleBinToolStripMenuItem.Text = "Nearest recycle bin";
            this.nearestRecycleBinToolStripMenuItem.Click += new System.EventHandler(this.nearestRecycleBinToolStripMenuItem_Click);
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
            this.RecipePanel.Controls.Add(this.generalasButton);
            this.RecipePanel.Controls.Add(this.ingredientComboBox3);
            this.RecipePanel.Controls.Add(this.ingredientComboBox2);
            this.RecipePanel.Controls.Add(this.ingredientComboBox1);
            this.RecipePanel.Controls.Add(this.soupCheckBox);
            this.RecipePanel.Controls.Add(this.dessertCheckBox);
            this.RecipePanel.Controls.Add(this.mainDishCheckBox);
            this.RecipePanel.Controls.Add(this.appetizerCheckBox);
            this.RecipePanel.Controls.Add(this.IngredientsLabel);
            this.RecipePanel.Controls.Add(this.DishTypeLabel);
            this.RecipePanel.Controls.Add(this.recipeLabel);
            this.RecipePanel.Location = new System.Drawing.Point(179, 73);
            this.RecipePanel.Name = "RecipePanel";
            this.RecipePanel.Size = new System.Drawing.Size(409, 393);
            this.RecipePanel.TabIndex = 5;
            // 
            // generalasButton
            // 
            this.generalasButton.Location = new System.Drawing.Point(223, 339);
            this.generalasButton.Name = "generalasButton";
            this.generalasButton.Size = new System.Drawing.Size(80, 33);
            this.generalasButton.TabIndex = 10;
            this.generalasButton.Text = "Generálás";
            this.generalasButton.UseVisualStyleBackColor = true;
            this.generalasButton.Click += new System.EventHandler(this.generalasButton_Click);
            // 
            // ingredientComboBox3
            // 
            this.ingredientComboBox3.FormattingEnabled = true;
            this.ingredientComboBox3.Items.AddRange(new object[] {
            "hagyma",
            "paprika",
            "paradicsom",
            "uborka"});
            this.ingredientComboBox3.Location = new System.Drawing.Point(28, 273);
            this.ingredientComboBox3.Name = "ingredientComboBox3";
            this.ingredientComboBox3.Size = new System.Drawing.Size(218, 23);
            this.ingredientComboBox3.TabIndex = 9;
            // 
            // ingredientComboBox2
            // 
            this.ingredientComboBox2.FormattingEnabled = true;
            this.ingredientComboBox2.Items.AddRange(new object[] {
            "marhahús",
            "hal",
            "sonka",
            "kolbász"});
            this.ingredientComboBox2.Location = new System.Drawing.Point(28, 235);
            this.ingredientComboBox2.Name = "ingredientComboBox2";
            this.ingredientComboBox2.Size = new System.Drawing.Size(218, 23);
            this.ingredientComboBox2.TabIndex = 8;
            // 
            // ingredientComboBox1
            // 
            this.ingredientComboBox1.FormattingEnabled = true;
            this.ingredientComboBox1.Items.AddRange(new object[] {
            "túró",
            "sajt",
            "tej",
            "tojás"});
            this.ingredientComboBox1.Location = new System.Drawing.Point(28, 197);
            this.ingredientComboBox1.Name = "ingredientComboBox1";
            this.ingredientComboBox1.Size = new System.Drawing.Size(218, 23);
            this.ingredientComboBox1.TabIndex = 7;
            // 
            // soupCheckBox
            // 
            this.soupCheckBox.AutoSize = true;
            this.soupCheckBox.Location = new System.Drawing.Point(127, 129);
            this.soupCheckBox.Name = "soupCheckBox";
            this.soupCheckBox.Size = new System.Drawing.Size(52, 19);
            this.soupCheckBox.TabIndex = 6;
            this.soupCheckBox.Text = "leves";
            this.soupCheckBox.UseVisualStyleBackColor = true;
            // 
            // dessertCheckBox
            // 
            this.dessertCheckBox.AutoSize = true;
            this.dessertCheckBox.Location = new System.Drawing.Point(311, 129);
            this.dessertCheckBox.Name = "dessertCheckBox";
            this.dessertCheckBox.Size = new System.Drawing.Size(68, 19);
            this.dessertCheckBox.TabIndex = 5;
            this.dessertCheckBox.Text = "desszert";
            this.dessertCheckBox.UseVisualStyleBackColor = true;
            // 
            // mainDishCheckBox
            // 
            this.mainDishCheckBox.AutoSize = true;
            this.mainDishCheckBox.Location = new System.Drawing.Point(218, 129);
            this.mainDishCheckBox.Name = "mainDishCheckBox";
            this.mainDishCheckBox.Size = new System.Drawing.Size(56, 19);
            this.mainDishCheckBox.TabIndex = 4;
            this.mainDishCheckBox.Text = "főétel";
            this.mainDishCheckBox.UseVisualStyleBackColor = true;
            // 
            // appetizerCheckBox
            // 
            this.appetizerCheckBox.AutoSize = true;
            this.appetizerCheckBox.Location = new System.Drawing.Point(23, 129);
            this.appetizerCheckBox.Name = "appetizerCheckBox";
            this.appetizerCheckBox.Size = new System.Drawing.Size(61, 19);
            this.appetizerCheckBox.TabIndex = 3;
            this.appetizerCheckBox.Text = "előétel";
            this.appetizerCheckBox.UseVisualStyleBackColor = true;
            // 
            // IngredientsLabel
            // 
            this.IngredientsLabel.AutoSize = true;
            this.IngredientsLabel.Location = new System.Drawing.Point(21, 169);
            this.IngredientsLabel.Name = "IngredientsLabel";
            this.IngredientsLabel.Size = new System.Drawing.Size(180, 15);
            this.IngredientsLabel.TabIndex = 2;
            this.IngredientsLabel.Text = "Preferált hozzávalók (opcionális):";
            // 
            // DishTypeLabel
            // 
            this.DishTypeLabel.AutoSize = true;
            this.DishTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DishTypeLabel.Location = new System.Drawing.Point(21, 101);
            this.DishTypeLabel.Name = "DishTypeLabel";
            this.DishTypeLabel.Size = new System.Drawing.Size(84, 21);
            this.DishTypeLabel.TabIndex = 1;
            this.DishTypeLabel.Text = "Étel típusa:";
            // 
            // recipeLabel
            // 
            this.recipeLabel.AutoSize = true;
            this.recipeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipeLabel.Location = new System.Drawing.Point(20, 38);
            this.recipeLabel.Name = "recipeLabel";
            this.recipeLabel.Size = new System.Drawing.Size(283, 25);
            this.recipeLabel.TabIndex = 0;
            this.recipeLabel.Text = "Válaszd ki milyen ételt szeretnél:";
            // 
            // TippPanel
            // 
            this.TippPanel.Controls.Add(this.todaysTippTextBox);
            this.TippPanel.Controls.Add(this.tippLabel);
            this.TippPanel.Location = new System.Drawing.Point(221, 73);
            this.TippPanel.Name = "TippPanel";
            this.TippPanel.Size = new System.Drawing.Size(337, 408);
            this.TippPanel.TabIndex = 6;
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
            this.tippLabel.Size = new System.Drawing.Size(117, 25);
            this.tippLabel.TabIndex = 0;
            this.tippLabel.Text = "Mai tippünk:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 640);
            this.Controls.Add(this.TippPanel);
            this.Controls.Add(this.RecipePanel);
            this.Controls.Add(this.mainWindowPanel);
            this.Controls.Add(this.menuStrip1);
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
            this.TippPanel.ResumeLayout(false);
            this.TippPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
        private Label habitLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem recipeSuggestionToolStripMenuItem;
        private ToolStripMenuItem nearestRecycleBinToolStripMenuItem;
        private ToolStripMenuItem tippsAndTricksToolStripMenuItem;
        private Panel mainWindowPanel;
        private Panel RecipePanel;
        private Label recipeLabel;
        private CheckBox dessertCheckBox;
        private CheckBox mainDishCheckBox;
        private CheckBox appetizerCheckBox;
        private Label IngredientsLabel;
        private Label DishTypeLabel;
        private ComboBox ingredientComboBox3;
        private ComboBox ingredientComboBox2;
        private ComboBox ingredientComboBox1;
        private CheckBox soupCheckBox;
        private Button generalasButton;
        private Panel TippPanel;
        private Label tippLabel;
        private TextBox todaysTippTextBox;
    }
}