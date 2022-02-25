
namespace TP1
{
    partial class Fsudoku
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fsudoku));
            this.BT_exit = new System.Windows.Forms.Button();
            this.BT_start = new System.Windows.Forms.Button();
            this.BT_Reset = new System.Windows.Forms.Button();
            this.BT_show = new System.Windows.Forms.Button();
            this.BT_maskSolution = new System.Windows.Forms.Button();
            this.DG_Sudoku = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Sudoku)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_exit
            // 
            this.BT_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BT_exit.Location = new System.Drawing.Point(606, 232);
            this.BT_exit.Name = "BT_exit";
            this.BT_exit.Size = new System.Drawing.Size(172, 37);
            this.BT_exit.TabIndex = 0;
            this.BT_exit.Text = "Quitter";
            this.BT_exit.UseVisualStyleBackColor = true;
            this.BT_exit.Click += new System.EventHandler(this.BT_exit_Click);
            // 
            // BT_start
            // 
            this.BT_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BT_start.Location = new System.Drawing.Point(226, 382);
            this.BT_start.Name = "BT_start";
            this.BT_start.Size = new System.Drawing.Size(172, 37);
            this.BT_start.TabIndex = 1;
            this.BT_start.Text = "Générer une grille";
            this.BT_start.UseVisualStyleBackColor = true;
            this.BT_start.Click += new System.EventHandler(this.BT_start_Click);
            // 
            // BT_Reset
            // 
            this.BT_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BT_Reset.Location = new System.Drawing.Point(414, 382);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(172, 37);
            this.BT_Reset.TabIndex = 3;
            this.BT_Reset.Text = "Effacer la grille";
            this.BT_Reset.UseVisualStyleBackColor = true;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // BT_show
            // 
            this.BT_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BT_show.Location = new System.Drawing.Point(606, 146);
            this.BT_show.Name = "BT_show";
            this.BT_show.Size = new System.Drawing.Size(172, 37);
            this.BT_show.TabIndex = 4;
            this.BT_show.Text = "Afficher la solution";
            this.BT_show.UseVisualStyleBackColor = true;
            this.BT_show.Click += new System.EventHandler(this.BT_show_Click);
            // 
            // BT_maskSolution
            // 
            this.BT_maskSolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BT_maskSolution.Location = new System.Drawing.Point(606, 189);
            this.BT_maskSolution.Name = "BT_maskSolution";
            this.BT_maskSolution.Size = new System.Drawing.Size(172, 37);
            this.BT_maskSolution.TabIndex = 5;
            this.BT_maskSolution.Text = "Masquer la solution";
            this.BT_maskSolution.UseVisualStyleBackColor = true;
            this.BT_maskSolution.Click += new System.EventHandler(this.BT_maskSolution_Click);
            // 
            // DG_Sudoku
            // 
            this.DG_Sudoku.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DG_Sudoku.AllowUserToAddRows = false;
            this.DG_Sudoku.AllowUserToDeleteRows = false;
            this.DG_Sudoku.AllowUserToResizeColumns = false;
            this.DG_Sudoku.AllowUserToResizeRows = false;
            this.DG_Sudoku.CausesValidation = false;
            this.DG_Sudoku.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.DG_Sudoku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Sudoku.ColumnHeadersVisible = false;
            this.DG_Sudoku.Location = new System.Drawing.Point(226, 16);
            this.DG_Sudoku.Name = "DG_Sudoku";
            this.DG_Sudoku.ReadOnly = true;
            this.DG_Sudoku.RowHeadersVisible = false;
            this.DG_Sudoku.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DG_Sudoku.ShowCellErrors = false;
            this.DG_Sudoku.ShowCellToolTips = false;
            this.DG_Sudoku.ShowEditingIcon = false;
            this.DG_Sudoku.ShowRowErrors = false;
            this.DG_Sudoku.Size = new System.Drawing.Size(360, 360);
            this.DG_Sudoku.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Générateur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "De Sudoku";
            // 
            // Fsudoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_Sudoku);
            this.Controls.Add(this.BT_maskSolution);
            this.Controls.Add(this.BT_show);
            this.Controls.Add(this.BT_Reset);
            this.Controls.Add(this.BT_start);
            this.Controls.Add(this.BT_exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fsudoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Générateur de Sudoku";
            ((System.ComponentModel.ISupportInitialize)(this.DG_Sudoku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_exit;
        private System.Windows.Forms.Button BT_start;
        private System.Windows.Forms.Button BT_Reset;
        private System.Windows.Forms.Button BT_show;
        private System.Windows.Forms.Button BT_maskSolution;
        private System.Windows.Forms.DataGridView DG_Sudoku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

