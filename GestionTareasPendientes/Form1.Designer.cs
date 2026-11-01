namespace GestionTareasPendientes
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            INGRESAR = new TextBox();
            listBox1 = new ListBox();
            button2 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 16);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 24);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 32);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(16, 115);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 5;
            button1.Text = "Agregar Tarea";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // INGRESAR
            // 
            INGRESAR.BackColor = SystemColors.ScrollBar;
            INGRESAR.Cursor = Cursors.IBeam;
            INGRESAR.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            INGRESAR.ForeColor = SystemColors.InactiveCaptionText;
            INGRESAR.Location = new Point(103, 60);
            INGRESAR.Name = "INGRESAR";
            INGRESAR.Size = new Size(381, 27);
            INGRESAR.TabIndex = 6;
            INGRESAR.Text = "INGRESAR TAREAS";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.Linen;
            listBox1.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(16, 178);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(586, 194);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(71, 392);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 8;
            button2.Text = "Eliminar Tarea";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 16);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 9;
            label5.Text = "AGRESE LAS TAREAS";
            label5.Click += label5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(632, 453);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(INGRESAR);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTION DE TAREAS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox INGRESAR;
        private ListBox listBox1;
        private Button button2;
        private Label label5;
    }
}
