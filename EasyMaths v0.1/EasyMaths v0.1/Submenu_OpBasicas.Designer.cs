namespace EasyMaths_v0._1
{
    partial class Submenu_OpBasicas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Submenu_OpBasicas));
            this.Combobox_1 = new System.Windows.Forms.ComboBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.button_solve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Combobox_1
            // 
            this.Combobox_1.DisplayMember = "(ninguno)";
            this.Combobox_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Combobox_1.FormattingEnabled = true;
            this.Combobox_1.Items.AddRange(new object[] {
            resources.GetString("Combobox_1.Items"),
            resources.GetString("Combobox_1.Items1"),
            resources.GetString("Combobox_1.Items2"),
            resources.GetString("Combobox_1.Items3")});
            resources.ApplyResources(this.Combobox_1, "Combobox_1");
            this.Combobox_1.Name = "Combobox_1";
            this.Combobox_1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // textBox_input
            // 
            resources.ApplyResources(this.textBox_input, "textBox_input");
            this.textBox_input.Name = "textBox_input";
            // 
            // button_solve
            // 
            resources.ApplyResources(this.button_solve, "button_solve");
            this.button_solve.Name = "button_solve";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Submenu_OpBasicas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.Combobox_1);
            this.Name = "Submenu_OpBasicas";
            this.Load += new System.EventHandler(this.Submenu_OpBasicas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combobox_1;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Label label1;
    }
}