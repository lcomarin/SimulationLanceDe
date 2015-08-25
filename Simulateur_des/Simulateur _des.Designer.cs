using System;

namespace Simulateur_des
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.d4 = new System.Windows.Forms.Button();
            this.AffRes = new System.Windows.Forms.TextBox();
            this.d6 = new System.Windows.Forms.Button();
            this.d8 = new System.Windows.Forms.Button();
            this.d10 = new System.Windows.Forms.Button();
            this.d12 = new System.Windows.Forms.Button();
            this.d20 = new System.Windows.Forms.Button();
            this.d100 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.piped_values = new System.Windows.Forms.TextBox();
            this.nb_des = new System.Windows.Forms.TextBox();
            this.Jeter = new System.Windows.Forms.Button();
            this.historique = new System.Windows.Forms.Button();
            this.obj_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.obj_inf = new System.Windows.Forms.Button();
            this.obj_egal = new System.Windows.Forms.Button();
            this.obj_sup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // d4
            // 
            this.d4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d4.Image = ((System.Drawing.Image)(resources.GetObject("d4.Image")));
            this.d4.Location = new System.Drawing.Point(11, 26);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(75, 108);
            this.d4.TabIndex = 0;
            this.d4.UseVisualStyleBackColor = true;
            this.d4.Click += new System.EventHandler(this.d4_Click);
            // 
            // AffRes
            // 
            this.AffRes.Location = new System.Drawing.Point(11, 361);
            this.AffRes.Name = "AffRes";
            this.AffRes.Size = new System.Drawing.Size(561, 20);
            this.AffRes.TabIndex = 2;
            // 
            // d6
            // 
            this.d6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d6.Image = ((System.Drawing.Image)(resources.GetObject("d6.Image")));
            this.d6.Location = new System.Drawing.Point(92, 26);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(75, 108);
            this.d6.TabIndex = 3;
            this.d6.UseVisualStyleBackColor = true;
            this.d6.Click += new System.EventHandler(this.d6_Click);
            // 
            // d8
            // 
            this.d8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d8.Image = ((System.Drawing.Image)(resources.GetObject("d8.Image")));
            this.d8.Location = new System.Drawing.Point(173, 26);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(75, 108);
            this.d8.TabIndex = 4;
            this.d8.UseVisualStyleBackColor = true;
            this.d8.Click += new System.EventHandler(this.d8_Click);
            // 
            // d10
            // 
            this.d10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d10.Image = ((System.Drawing.Image)(resources.GetObject("d10.Image")));
            this.d10.Location = new System.Drawing.Point(254, 26);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(75, 108);
            this.d10.TabIndex = 5;
            this.d10.UseVisualStyleBackColor = true;
            this.d10.Click += new System.EventHandler(this.d10_Click);
            // 
            // d12
            // 
            this.d12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d12.Image = ((System.Drawing.Image)(resources.GetObject("d12.Image")));
            this.d12.Location = new System.Drawing.Point(335, 26);
            this.d12.Name = "d12";
            this.d12.Size = new System.Drawing.Size(75, 108);
            this.d12.TabIndex = 6;
            this.d12.UseVisualStyleBackColor = true;
            this.d12.Click += new System.EventHandler(this.d12_Click);
            // 
            // d20
            // 
            this.d20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.d20.Image = ((System.Drawing.Image)(resources.GetObject("d20.Image")));
            this.d20.Location = new System.Drawing.Point(416, 26);
            this.d20.Name = "d20";
            this.d20.Size = new System.Drawing.Size(75, 108);
            this.d20.TabIndex = 7;
            this.d20.UseVisualStyleBackColor = true;
            this.d20.Click += new System.EventHandler(this.d20_Click);
            // 
            // d100
            // 
            this.d100.Image = ((System.Drawing.Image)(resources.GetObject("d100.Image")));
            this.d100.Location = new System.Drawing.Point(497, 26);
            this.d100.Name = "d100";
            this.d100.Size = new System.Drawing.Size(75, 108);
            this.d100.TabIndex = 8;
            this.d100.UseVisualStyleBackColor = true;
            this.d100.Click += new System.EventHandler(this.d100_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Veuillez choisir le nombre de dés à lancer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Veuillez choisir le type de dés à lancer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Voici votre résultat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(374, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ou définissez votre propre dé, en séparant les valeurs par des points-virgules :";
            // 
            // piped_values
            // 
            this.piped_values.Location = new System.Drawing.Point(12, 153);
            this.piped_values.Name = "piped_values";
            this.piped_values.Size = new System.Drawing.Size(560, 20);
            this.piped_values.TabIndex = 12;
            // 
            // nb_des
            // 
            this.nb_des.Location = new System.Drawing.Point(12, 192);
            this.nb_des.Name = "nb_des";
            this.nb_des.Size = new System.Drawing.Size(560, 20);
            this.nb_des.TabIndex = 14;
            this.nb_des.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Jeter
            // 
            this.Jeter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Jeter.BackgroundImage")));
            this.Jeter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Jeter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jeter.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Jeter.FlatAppearance.BorderSize = 0;
            this.Jeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jeter.Location = new System.Drawing.Point(123, 261);
            this.Jeter.Name = "Jeter";
            this.Jeter.Size = new System.Drawing.Size(78, 94);
            this.Jeter.TabIndex = 15;
            this.Jeter.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Jeter.UseVisualStyleBackColor = true;
            this.Jeter.Click += new System.EventHandler(this.jeter_Click);
            // 
            // historique
            // 
            this.historique.Image = ((System.Drawing.Image)(resources.GetObject("historique.Image")));
            this.historique.Location = new System.Drawing.Point(389, 261);
            this.historique.Name = "historique";
            this.historique.Size = new System.Drawing.Size(67, 83);
            this.historique.TabIndex = 16;
            this.historique.UseVisualStyleBackColor = true;
            this.historique.Click += new System.EventHandler(this.historique_Click);
            // 
            // obj_text
            // 
            this.obj_text.Location = new System.Drawing.Point(12, 235);
            this.obj_text.Name = "obj_text";
            this.obj_text.Size = new System.Drawing.Size(155, 20);
            this.obj_text.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Fixez un objectif:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 20);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // obj_inf
            // 
            this.obj_inf.Location = new System.Drawing.Point(189, 235);
            this.obj_inf.Name = "obj_inf";
            this.obj_inf.Size = new System.Drawing.Size(40, 20);
            this.obj_inf.TabIndex = 19;
            this.obj_inf.Text = "<";
            this.obj_inf.UseVisualStyleBackColor = true;
            this.obj_inf.Click += new System.EventHandler(this.obj_inf_Click);
            // 
            // obj_egal
            // 
            this.obj_egal.Location = new System.Drawing.Point(235, 235);
            this.obj_egal.Name = "obj_egal";
            this.obj_egal.Size = new System.Drawing.Size(40, 20);
            this.obj_egal.TabIndex = 20;
            this.obj_egal.Text = "=";
            this.obj_egal.UseVisualStyleBackColor = true;
            this.obj_egal.Click += new System.EventHandler(this.obj_egal_Click);
            // 
            // obj_sup
            // 
            this.obj_sup.Location = new System.Drawing.Point(281, 235);
            this.obj_sup.Name = "obj_sup";
            this.obj_sup.Size = new System.Drawing.Size(40, 20);
            this.obj_sup.TabIndex = 21;
            this.obj_sup.Text = ">";
            this.obj_sup.UseVisualStyleBackColor = true;
            this.obj_sup.Click += new System.EventHandler(this.obj_sup_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 393);
            this.Controls.Add(this.obj_sup);
            this.Controls.Add(this.obj_egal);
            this.Controls.Add(this.obj_inf);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.obj_text);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.historique);
            this.Controls.Add(this.Jeter);
            this.Controls.Add(this.nb_des);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.piped_values);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.d100);
            this.Controls.Add(this.d20);
            this.Controls.Add(this.d12);
            this.Controls.Add(this.d10);
            this.Controls.Add(this.d8);
            this.Controls.Add(this.d6);
            this.Controls.Add(this.AffRes);
            this.Controls.Add(this.d4);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulateur de dés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button d4;
        private System.Windows.Forms.TextBox AffRes;
        private System.Windows.Forms.Button d6;
        private System.Windows.Forms.Button d8;
        private System.Windows.Forms.Button d10;
        private System.Windows.Forms.Button d12;
        private System.Windows.Forms.Button d20;
        private System.Windows.Forms.Button d100;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox piped_values;
        private System.Windows.Forms.TextBox nb_des;
        private System.Windows.Forms.Button Jeter;
        private System.Windows.Forms.Button historique;
        private System.Windows.Forms.TextBox obj_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button obj_inf;
        private System.Windows.Forms.Button obj_egal;
        private System.Windows.Forms.Button obj_sup;
    }
}

