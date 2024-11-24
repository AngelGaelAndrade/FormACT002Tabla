namespace FormACT002Tabla
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
            panelPrincipal = new Panel();
            richTextBoxResultados = new RichTextBox();
            buttonVer = new Button();
            textBoxNum = new TextBox();
            labelNumero = new Label();
            labeltitulo = new Label();
            NOM = new Label();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = SystemColors.GradientActiveCaption;
            panelPrincipal.Controls.Add(NOM);
            panelPrincipal.Controls.Add(richTextBoxResultados);
            panelPrincipal.Controls.Add(buttonVer);
            panelPrincipal.Controls.Add(textBoxNum);
            panelPrincipal.Controls.Add(labelNumero);
            panelPrincipal.Controls.Add(labeltitulo);
            panelPrincipal.Location = new Point(12, 12);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(776, 426);
            panelPrincipal.TabIndex = 0;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBoxResultados.Location = new Point(372, 43);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(311, 272);
            richTextBoxResultados.TabIndex = 4;
            richTextBoxResultados.Text = "";
            // 
            // buttonVer
            // 
            buttonVer.BackColor = SystemColors.AppWorkspace;
            buttonVer.Location = new Point(94, 274);
            buttonVer.Name = "buttonVer";
            buttonVer.Size = new Size(167, 41);
            buttonVer.TabIndex = 3;
            buttonVer.Text = "Ver tabla";
            buttonVer.UseVisualStyleBackColor = false;
            buttonVer.Click += buttonVer_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(94, 216);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(167, 31);
            textBoxNum.TabIndex = 2;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.BackColor = SystemColors.ButtonFace;
            labelNumero.BorderStyle = BorderStyle.Fixed3D;
            labelNumero.Location = new Point(94, 146);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(167, 27);
            labelNumero.TabIndex = 1;
            labelNumero.Text = "¿cual tabla quieres?";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.BackColor = SystemColors.ButtonFace;
            labeltitulo.BorderStyle = BorderStyle.Fixed3D;
            labeltitulo.Location = new Point(85, 43);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(166, 27);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Tabla de multiplicar";
            // 
            // NOM
            // 
            NOM.AutoSize = true;
            NOM.BackColor = SystemColors.GradientActiveCaption;
            NOM.Font = new Font("Tahoma", 11F, FontStyle.Italic, GraphicsUnit.Point, 0);
            NOM.Location = new Point(252, 371);
            NOM.Name = "NOM";
            NOM.Size = new Size(273, 27);
            NOM.TabIndex = 5;
            NOM.Text = "Angel Gael Andrade Ovalle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelPrincipal);
            Name = "Form1";
            Text = " ";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Button buttonVer;
        private TextBox textBoxNum;
        private Label labelNumero;
        private Label labeltitulo;
        private RichTextBox richTextBoxResultados;
        private Label NOM;
    }
}
