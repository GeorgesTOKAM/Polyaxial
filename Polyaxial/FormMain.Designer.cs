namespace Polyaxial
{
    partial class FormMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btce = new System.Windows.Forms.Button();
            this.btrp = new System.Windows.Forms.Button();
            this.btrd = new System.Windows.Forms.Button();
            this.btetal = new System.Windows.Forms.Button();
            this.bttr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btce
            // 
            this.btce.Location = new System.Drawing.Point(12, 12);
            this.btce.Name = "btce";
            this.btce.Size = new System.Drawing.Size(159, 33);
            this.btce.TabIndex = 0;
            this.btce.Text = "Fixer conditions essai";
            this.btce.UseVisualStyleBackColor = true;
            this.btce.Click += new System.EventHandler(this.btce_Click);
            // 
            // btrp
            // 
            this.btrp.Location = new System.Drawing.Point(12, 51);
            this.btrp.Name = "btrp";
            this.btrp.Size = new System.Drawing.Size(159, 33);
            this.btrp.TabIndex = 0;
            this.btrp.Text = "Rupture en pression";
            this.btrp.UseVisualStyleBackColor = true;
            // 
            // btrd
            // 
            this.btrd.Location = new System.Drawing.Point(12, 90);
            this.btrd.Name = "btrd";
            this.btrd.Size = new System.Drawing.Size(159, 33);
            this.btrd.TabIndex = 0;
            this.btrd.Text = "Rupture en déformation";
            this.btrd.UseVisualStyleBackColor = true;
            // 
            // btetal
            // 
            this.btetal.Location = new System.Drawing.Point(12, 129);
            this.btetal.Name = "btetal";
            this.btetal.Size = new System.Drawing.Size(159, 33);
            this.btetal.TabIndex = 0;
            this.btetal.Text = "Etallonage capteurs";
            this.btetal.UseVisualStyleBackColor = true;
            // 
            // bttr
            // 
            this.bttr.Location = new System.Drawing.Point(12, 168);
            this.bttr.Name = "bttr";
            this.bttr.Size = new System.Drawing.Size(159, 33);
            this.bttr.TabIndex = 0;
            this.bttr.Text = "Traiter Ancien Essai";
            this.bttr.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 213);
            this.Controls.Add(this.bttr);
            this.Controls.Add(this.btetal);
            this.Controls.Add(this.btrd);
            this.Controls.Add(this.btrp);
            this.Controls.Add(this.btce);
            this.Name = "FormMain";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btce;
        private System.Windows.Forms.Button btrp;
        private System.Windows.Forms.Button btrd;
        private System.Windows.Forms.Button btetal;
        private System.Windows.Forms.Button bttr;
    }
}

