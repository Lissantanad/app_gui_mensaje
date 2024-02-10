namespace app_gui_mensaje
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
            btn_salir = new Button();
            btn_Mostrar = new Button();
            SuspendLayout();
            // 
            // btn_salir
            // 
            btn_salir.BackColor = Color.LightBlue;
            btn_salir.Location = new Point(87, 86);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(227, 44);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "Salir";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // btn_Mostrar
            // 
            btn_Mostrar.BackColor = Color.LightBlue;
            btn_Mostrar.Location = new Point(84, 12);
            btn_Mostrar.Name = "btn_Mostrar";
            btn_Mostrar.Size = new Size(230, 47);
            btn_Mostrar.TabIndex = 1;
            btn_Mostrar.Text = "Mostrar Mensaje";
            btn_Mostrar.UseVisualStyleBackColor = false;
            btn_Mostrar.Click += btn_Mostrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(378, 178);
            Controls.Add(btn_Mostrar);
            Controls.Add(btn_salir);
            Name = "Form1";
            Text = "vandeja de mensajes ";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_salir;
        private Button btn_Mostrar;
    }
}
