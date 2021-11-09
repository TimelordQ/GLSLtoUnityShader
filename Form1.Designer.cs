
namespace GLSLtoSHADER
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mainSplitter = new System.Windows.Forms.SplitContainer();
            this.lblStatic = new System.Windows.Forms.Label();
            this.txtGLSL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShaderOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).BeginInit();
            this.mainSplitter.Panel1.SuspendLayout();
            this.mainSplitter.Panel2.SuspendLayout();
            this.mainSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitter
            // 
            this.mainSplitter.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.mainSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitter.Location = new System.Drawing.Point(0, 0);
            this.mainSplitter.Name = "mainSplitter";
            // 
            // mainSplitter.Panel1
            // 
            this.mainSplitter.Panel1.Controls.Add(this.lblStatic);
            this.mainSplitter.Panel1.Controls.Add(this.txtGLSL);
            this.mainSplitter.Panel1MinSize = 40;
            // 
            // mainSplitter.Panel2
            // 
            this.mainSplitter.Panel2.Controls.Add(this.label1);
            this.mainSplitter.Panel2.Controls.Add(this.txtShaderOut);
            this.mainSplitter.Panel2MinSize = 40;
            this.mainSplitter.Size = new System.Drawing.Size(1031, 528);
            this.mainSplitter.SplitterDistance = 512;
            this.mainSplitter.TabIndex = 1;
            this.mainSplitter.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.mainSplitter_SplitterMoved);
            this.mainSplitter.SizeChanged += new System.EventHandler(this.splitContainer1_SizeChanged);
            // 
            // lblStatic
            // 
            this.lblStatic.AutoSize = true;
            this.lblStatic.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatic.Location = new System.Drawing.Point(3, 0);
            this.lblStatic.Name = "lblStatic";
            this.lblStatic.Size = new System.Drawing.Size(79, 16);
            this.lblStatic.TabIndex = 1;
            this.lblStatic.Text = "GLSL Code";
            // 
            // txtGLSL
            // 
            this.txtGLSL.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGLSL.Location = new System.Drawing.Point(0, 19);
            this.txtGLSL.Multiline = true;
            this.txtGLSL.Name = "txtGLSL";
            this.txtGLSL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGLSL.Size = new System.Drawing.Size(497, 506);
            this.txtGLSL.TabIndex = 0;
            this.txtGLSL.Text = resources.GetString("txtGLSL.Text");
            this.txtGLSL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtGLSL_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Shader Code";
            // 
            // txtShaderOut
            // 
            this.txtShaderOut.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtShaderOut.Location = new System.Drawing.Point(3, 19);
            this.txtShaderOut.Multiline = true;
            this.txtShaderOut.Name = "txtShaderOut";
            this.txtShaderOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShaderOut.Size = new System.Drawing.Size(497, 506);
            this.txtShaderOut.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 528);
            this.Controls.Add(this.mainSplitter);
            this.Name = "frmMain";
            this.Text = "HLSL to Unity Shader Converter";
            this.mainSplitter.Panel1.ResumeLayout(false);
            this.mainSplitter.Panel1.PerformLayout();
            this.mainSplitter.Panel2.ResumeLayout(false);
            this.mainSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitter)).EndInit();
            this.mainSplitter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer mainSplitter;
        private System.Windows.Forms.Label lblStatic;
        private System.Windows.Forms.TextBox txtGLSL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShaderOut;
    }
}

