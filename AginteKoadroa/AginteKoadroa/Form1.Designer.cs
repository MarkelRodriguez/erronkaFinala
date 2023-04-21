
namespace AginteKoadroa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grafikoa1 = new erronka1DLL.Grafikoa();
            this.CombBoxUsers = new System.Windows.Forms.ComboBox();
            this.lstViewPartidak = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // grafikoa1
            // 
            this.grafikoa1.Location = new System.Drawing.Point(42, 118);
            this.grafikoa1.Name = "grafikoa1";
            this.grafikoa1.Size = new System.Drawing.Size(420, 297);
            this.grafikoa1.TabIndex = 0;
            // 
            // CombBoxUsers
            // 
            this.CombBoxUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.CombBoxUsers.ForeColor = System.Drawing.SystemColors.Window;
            this.CombBoxUsers.FormattingEnabled = true;
            this.CombBoxUsers.Items.AddRange(new object[] {
            "markel"});
            this.CombBoxUsers.Location = new System.Drawing.Point(527, 118);
            this.CombBoxUsers.Name = "CombBoxUsers";
            this.CombBoxUsers.Size = new System.Drawing.Size(233, 21);
            this.CombBoxUsers.TabIndex = 1;
            this.CombBoxUsers.SelectedIndexChanged += new System.EventHandler(this.CombBoxUsers_SelectedIndexChanged);
            // 
            // lstViewPartidak
            // 
            this.lstViewPartidak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.lstViewPartidak.ForeColor = System.Drawing.SystemColors.Window;
            this.lstViewPartidak.HideSelection = false;
            this.lstViewPartidak.Location = new System.Drawing.Point(42, 430);
            this.lstViewPartidak.Name = "lstViewPartidak";
            this.lstViewPartidak.Size = new System.Drawing.Size(420, 297);
            this.lstViewPartidak.TabIndex = 2;
            this.lstViewPartidak.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(824, 749);
            this.Controls.Add(this.lstViewPartidak);
            this.Controls.Add(this.CombBoxUsers);
            this.Controls.Add(this.grafikoa1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private erronka1DLL.Grafikoa grafikoa1;
        private System.Windows.Forms.ComboBox CombBoxUsers;
        private System.Windows.Forms.ListView lstViewPartidak;
    }
}

