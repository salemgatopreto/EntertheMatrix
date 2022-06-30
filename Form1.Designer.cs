namespace EntertheMatrix
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblmatrix = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblsobrenome = new System.Windows.Forms.Label();
            this.txtsobrenome = new System.Windows.Forms.TextBox();
            this.lblnascimeno = new System.Windows.Forms.Label();
            this.txtnascimento = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.lblmensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmatrix
            // 
            this.lblmatrix.AutoSize = true;
            this.lblmatrix.Font = new System.Drawing.Font("Perpetua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatrix.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblmatrix.Location = new System.Drawing.Point(123, 20);
            this.lblmatrix.Name = "lblmatrix";
            this.lblmatrix.Size = new System.Drawing.Size(362, 31);
            this.lblmatrix.TabIndex = 0;
            this.lblmatrix.Text = "ENTER THE VAI DAR NAMORO";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(24, 52);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(39, 13);
            this.lblnome.TabIndex = 1;
            this.lblnome.Text = "NOME";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(27, 78);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(165, 20);
            this.txtnome.TabIndex = 2;
            // 
            // lblsobrenome
            // 
            this.lblsobrenome.AutoSize = true;
            this.lblsobrenome.Location = new System.Drawing.Point(27, 124);
            this.lblsobrenome.Name = "lblsobrenome";
            this.lblsobrenome.Size = new System.Drawing.Size(76, 13);
            this.lblsobrenome.TabIndex = 3;
            this.lblsobrenome.Text = "SOBRENOME";
            // 
            // txtsobrenome
            // 
            this.txtsobrenome.Location = new System.Drawing.Point(27, 155);
            this.txtsobrenome.Name = "txtsobrenome";
            this.txtsobrenome.Size = new System.Drawing.Size(165, 20);
            this.txtsobrenome.TabIndex = 4;
            // 
            // lblnascimeno
            // 
            this.lblnascimeno.AutoSize = true;
            this.lblnascimeno.Location = new System.Drawing.Point(27, 205);
            this.lblnascimeno.Name = "lblnascimeno";
            this.lblnascimeno.Size = new System.Drawing.Size(128, 13);
            this.lblnascimeno.TabIndex = 5;
            this.lblnascimeno.Text = "DATA DE NASCIMENTO";
            // 
            // txtnascimento
            // 
            this.txtnascimento.Location = new System.Drawing.Point(27, 230);
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.Size = new System.Drawing.Size(100, 20);
            this.txtnascimento.TabIndex = 6;
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(30, 273);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(75, 23);
            this.btnverificar.TabIndex = 7;
            this.btnverificar.Text = "VERIFICAR";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(117, 273);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 8;
            this.btnlimpar.Text = "LIMPAR";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(207, 273);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 9;
            this.btnsair.Text = "SAIR";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(304, 78);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(222, 218);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture.TabIndex = 10;
            this.picture.TabStop = false;
            // 
            // lblmensagem
            // 
            this.lblmensagem.AutoSize = true;
            this.lblmensagem.Location = new System.Drawing.Point(157, 233);
            this.lblmensagem.Name = "lblmensagem";
            this.lblmensagem.Size = new System.Drawing.Size(0, 13);
            this.lblmensagem.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(567, 498);
            this.Controls.Add(this.lblmensagem);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.txtnascimento);
            this.Controls.Add(this.lblnascimeno);
            this.Controls.Add(this.txtsobrenome);
            this.Controls.Add(this.lblsobrenome);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblmatrix);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmatrix;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblsobrenome;
        private System.Windows.Forms.TextBox txtsobrenome;
        private System.Windows.Forms.Label lblnascimeno;
        private System.Windows.Forms.TextBox txtnascimento;
        private System.Windows.Forms.Button btnverificar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label lblmensagem;
    }
}

