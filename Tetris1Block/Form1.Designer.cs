namespace Tetris1Block
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
            this.blockPanel = new System.Windows.Forms.Panel();
            this.blockLabels = new System.Windows.Forms.Label[40];
            this.SuspendLayout();
            // 
            // blockPanel
            // 
            this.blockPanel.Location = new System.Drawing.Point(13, 13);
            this.blockPanel.Name = "blockPanel";
            this.blockPanel.Size = new System.Drawing.Size(350, 500);
            this.blockPanel.TabIndex = 0;

            //Label creation

            int blockNumber = 0;
            int blockPositionX = 0;
            int blocRow = 0;

            foreach(System.Windows.Forms.Label block in blockLabels){

                blockLabels[blockNumber] = new System.Windows.Forms.Label();
                this.blockLabels[blockNumber].BackColor = System.Drawing.Color.Black;
                this.blockLabels[blockNumber].Location = new System.Drawing.Point(60 * blockPositionX, 60 * blocRow);
                this.blockLabels[blockNumber].Name = "blockLabel" + blockNumber.ToString();
                this.blockLabels[blockNumber].Size = new System.Drawing.Size(50, 50);
                this.blockLabels[blockNumber].TabIndex = blockNumber;
                blockNumber++;
                blockPositionX++;

                if (blockNumber == 5){
                    blocRow++;
                    blockPositionX = 0;
                }
                if(blockNumber == 10)
                {
                    blocRow++;
                    blockPositionX = 0;
                } if(blockNumber == 15)
                {
                    blocRow++;
                    blockPositionX = 0;
                } if(blockNumber == 20)
                {
                    blocRow++;
                    blockPositionX = 0;
                } if(blockNumber == 25)
                {
                    blocRow++;
                    blockPositionX = 0;
                } if(blockNumber == 30)
                {
                    blocRow++;
                    blockPositionX = 0;
                } if(blockNumber == 35)
                {
                    blocRow++;
                    blockPositionX = 0;
                }if(blockNumber == 40)
                {
                    blocRow++;
                    blockPositionX = 0;
                }
            }

            blockNumber = 0;

            foreach(System.Windows.Forms.Label block in blockLabels){
                this.blockPanel.Controls.Add(this.blockLabels[blockNumber]);
                blockNumber++;
            }
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.blockPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel blockPanel;

        private System.Windows.Forms.Label[] blockLabels;

        public System.Windows.Forms.Label[] BlockLabels
        {
            get { return blockLabels; }
            set { blockLabels = value; }
        }
    }
}

