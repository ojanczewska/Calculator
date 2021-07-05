namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.result = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.buttonComma = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSubstract = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonBAckspace = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyświetlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ądToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńKolorTłaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńKolorKlawiszToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyfryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.znakiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.result, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(501, 631);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(501, 631);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 631);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // result
            // 
            this.result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.result.Location = new System.Drawing.Point(3, 66);
            this.result.MaximumSize = new System.Drawing.Size(495, 39);
            this.result.MinimumSize = new System.Drawing.Size(495, 39);
            this.result.Name = "result";
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.Size = new System.Drawing.Size(495, 39);
            this.result.TabIndex = 2;
            this.result.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.MaximumSize = new System.Drawing.Size(495, 30);
            this.label1.MinimumSize = new System.Drawing.Size(495, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonC, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.button4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button5, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button6, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button8, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button9, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button0, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonChange, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonComma, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonEqual, 3, 4);
            this.tableLayoutPanel2.Controls.Add(this.buttonAdd, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.buttonSubstract, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonMultiply, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonDivide, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonBAckspace, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonCE, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 153);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(497, 507);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.Orchid;
            this.buttonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Location = new System.Drawing.Point(3, 3);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(118, 95);
            this.buttonC.TabIndex = 19;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Coral;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(127, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 95);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Coral;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(251, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 95);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Coral;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 95);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Coral;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(127, 205);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(118, 95);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Coral;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(251, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(118, 95);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Coral;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(3, 104);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(118, 95);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Coral;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(127, 104);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(118, 95);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Coral;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(251, 104);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(118, 95);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.Coral;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Location = new System.Drawing.Point(127, 407);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(118, 97);
            this.button0.TabIndex = 9;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.Orchid;
            this.buttonChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChange.FlatAppearance.BorderSize = 0;
            this.buttonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChange.Location = new System.Drawing.Point(3, 407);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(118, 97);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "+/-";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // buttonComma
            // 
            this.buttonComma.BackColor = System.Drawing.Color.Orchid;
            this.buttonComma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonComma.FlatAppearance.BorderSize = 0;
            this.buttonComma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonComma.Location = new System.Drawing.Point(251, 407);
            this.buttonComma.Name = "buttonComma";
            this.buttonComma.Size = new System.Drawing.Size(118, 97);
            this.buttonComma.TabIndex = 11;
            this.buttonComma.Text = ",";
            this.buttonComma.UseVisualStyleBackColor = false;
            this.buttonComma.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.Orchid;
            this.buttonEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Location = new System.Drawing.Point(375, 407);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(119, 97);
            this.buttonEqual.TabIndex = 12;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Orchid;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Location = new System.Drawing.Point(375, 306);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(119, 95);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.operation);
            // 
            // buttonSubstract
            // 
            this.buttonSubstract.BackColor = System.Drawing.Color.Orchid;
            this.buttonSubstract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubstract.FlatAppearance.BorderSize = 0;
            this.buttonSubstract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubstract.Location = new System.Drawing.Point(375, 205);
            this.buttonSubstract.Name = "buttonSubstract";
            this.buttonSubstract.Size = new System.Drawing.Size(119, 95);
            this.buttonSubstract.TabIndex = 14;
            this.buttonSubstract.Text = "-";
            this.buttonSubstract.UseVisualStyleBackColor = false;
            this.buttonSubstract.Click += new System.EventHandler(this.operation);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.BackColor = System.Drawing.Color.Orchid;
            this.buttonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiply.FlatAppearance.BorderSize = 0;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Location = new System.Drawing.Point(375, 104);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(119, 95);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.operation);
            // 
            // buttonDivide
            // 
            this.buttonDivide.BackColor = System.Drawing.Color.Orchid;
            this.buttonDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivide.FlatAppearance.BorderSize = 0;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Location = new System.Drawing.Point(375, 3);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(119, 95);
            this.buttonDivide.TabIndex = 16;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.operation);
            // 
            // buttonBAckspace
            // 
            this.buttonBAckspace.BackColor = System.Drawing.Color.Orchid;
            this.buttonBAckspace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBAckspace.FlatAppearance.BorderSize = 0;
            this.buttonBAckspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBAckspace.Location = new System.Drawing.Point(251, 3);
            this.buttonBAckspace.Name = "buttonBAckspace";
            this.buttonBAckspace.Size = new System.Drawing.Size(118, 95);
            this.buttonBAckspace.TabIndex = 17;
            this.buttonBAckspace.Text = "Backspace";
            this.buttonBAckspace.UseVisualStyleBackColor = false;
            this.buttonBAckspace.Click += new System.EventHandler(this.buttonBAckspace_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.BackColor = System.Drawing.Color.Orchid;
            this.buttonCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCE.FlatAppearance.BorderSize = 0;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCE.Location = new System.Drawing.Point(127, 3);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(118, 95);
            this.buttonCE.TabIndex = 18;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zegarToolStripMenuItem,
            this.ądToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(501, 33);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(501, 33);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zegarToolStripMenuItem
            // 
            this.zegarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyświetlToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.zegarToolStripMenuItem.Name = "zegarToolStripMenuItem";
            this.zegarToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.zegarToolStripMenuItem.Text = "Zegar";
            this.zegarToolStripMenuItem.Click += new System.EventHandler(this.zegarToolStripMenuItem_Click);
            // 
            // wyświetlToolStripMenuItem
            // 
            this.wyświetlToolStripMenuItem.Name = "wyświetlToolStripMenuItem";
            this.wyświetlToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.wyświetlToolStripMenuItem.Text = "Wyświetl";
            this.wyświetlToolStripMenuItem.Click += new System.EventHandler(this.wyświetlToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(166, 30);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // ądToolStripMenuItem
            // 
            this.ądToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zmieńKolorTłaToolStripMenuItem,
            this.zmieńKolorKlawiszToolStripMenuItem});
            this.ądToolStripMenuItem.Name = "ądToolStripMenuItem";
            this.ądToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.ądToolStripMenuItem.Text = "Wygląd";
            // 
            // zmieńKolorTłaToolStripMenuItem
            // 
            this.zmieńKolorTłaToolStripMenuItem.Name = "zmieńKolorTłaToolStripMenuItem";
            this.zmieńKolorTłaToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.zmieńKolorTłaToolStripMenuItem.Text = "Zmień kolor tła";
            this.zmieńKolorTłaToolStripMenuItem.Click += new System.EventHandler(this.zmieńKolorTłaToolStripMenuItem_Click);
            // 
            // zmieńKolorKlawiszToolStripMenuItem
            // 
            this.zmieńKolorKlawiszToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cyfryToolStripMenuItem,
            this.znakiToolStripMenuItem});
            this.zmieńKolorKlawiszToolStripMenuItem.Name = "zmieńKolorKlawiszToolStripMenuItem";
            this.zmieńKolorKlawiszToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.zmieńKolorKlawiszToolStripMenuItem.Text = "Zmień kolor klawiszy ";
            this.zmieńKolorKlawiszToolStripMenuItem.Click += new System.EventHandler(this.zmieńKolorKlawiszToolStripMenuItem_Click);
            // 
            // cyfryToolStripMenuItem
            // 
            this.cyfryToolStripMenuItem.Name = "cyfryToolStripMenuItem";
            this.cyfryToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.cyfryToolStripMenuItem.Text = "Cyfry";
            this.cyfryToolStripMenuItem.Click += new System.EventHandler(this.cyfryToolStripMenuItem_Click);
            // 
            // znakiToolStripMenuItem
            // 
            this.znakiToolStripMenuItem.Name = "znakiToolStripMenuItem";
            this.znakiToolStripMenuItem.Size = new System.Drawing.Size(138, 30);
            this.znakiToolStripMenuItem.Text = "Znaki";
            this.znakiToolStripMenuItem.Click += new System.EventHandler(this.znakiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(497, 660);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(523, 720);
            this.MinimumSize = new System.Drawing.Size(523, 720);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Button buttonComma;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubstract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonBAckspace;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ądToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńKolorTłaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmieńKolorKlawiszToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyfryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem znakiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem wyświetlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamknijToolStripMenuItem;
    }
}

