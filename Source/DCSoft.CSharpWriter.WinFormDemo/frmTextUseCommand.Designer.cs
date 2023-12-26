/*****************************
CSharpWriter is a RTF style Text writer control written by C#,Currently,
it use <LGPL> license.More than RichTextBox, 
It is provide a DOM to access every thing in document and save in XML format.
It can use in WinForm.NET ,WPF,Console application.Any idea about CSharpWriter 
can write to 28348092@qq.com(or yyf9989@hotmail.com). 
Project web site is [https://github.com/dcsoft-yyf/CSharpWriter].
*****************************///@DCHC@
namespace DCSoft.CSharpWriter.WinFormDemo
{
    partial class frmTextUseCommand
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextUseCommand));
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.myCommandControler = new DCSoft.CSharpWriter.Commands.CSWriterCommandControler(this.components);
            this.cmRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCut = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.cmPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmFont = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.cmAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.cmProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.myEditControl = new DCSoft.CSharpWriter.Controls.CSWriterControl();
            this.cmEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.myCommandControler)).BeginInit();
            this.cmEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.White;
            this.myImageList.Images.SetKeyName(0, "");
            this.myImageList.Images.SetKeyName(1, "");
            this.myImageList.Images.SetKeyName(2, "");
            this.myImageList.Images.SetKeyName(3, "");
            this.myImageList.Images.SetKeyName(4, "");
            this.myImageList.Images.SetKeyName(5, "");
            this.myImageList.Images.SetKeyName(6, "");
            this.myImageList.Images.SetKeyName(7, "");
            this.myImageList.Images.SetKeyName(8, "");
            this.myImageList.Images.SetKeyName(9, "");
            this.myImageList.Images.SetKeyName(10, "");
            this.myImageList.Images.SetKeyName(11, "");
            this.myImageList.Images.SetKeyName(12, "");
            this.myImageList.Images.SetKeyName(13, "");
            this.myImageList.Images.SetKeyName(14, "");
            this.myImageList.Images.SetKeyName(15, "");
            this.myImageList.Images.SetKeyName(16, "");
            this.myImageList.Images.SetKeyName(17, "");
            this.myImageList.Images.SetKeyName(18, "");
            this.myImageList.Images.SetKeyName(19, "");
            this.myImageList.Images.SetKeyName(20, "");
            this.myImageList.Images.SetKeyName(21, "");
            this.myImageList.Images.SetKeyName(22, "");
            this.myImageList.Images.SetKeyName(23, "");
            this.myImageList.Images.SetKeyName(24, "");
            this.myImageList.Images.SetKeyName(25, "");
            this.myImageList.Images.SetKeyName(26, "");
            this.myImageList.Images.SetKeyName(27, "");
            this.myImageList.Images.SetKeyName(28, "");
            this.myImageList.Images.SetKeyName(29, "");
            this.myImageList.Images.SetKeyName(30, "");
            this.myImageList.Images.SetKeyName(31, "");
            this.myImageList.Images.SetKeyName(32, "");
            // 
            // cmRedo
            // 
            this.myCommandControler.SetCommandName(this.cmRedo, "Redo");
            this.cmRedo.Image = ((System.Drawing.Image)(resources.GetObject("cmRedo.Image")));
            this.cmRedo.Name = "cmRedo";
            this.cmRedo.Size = new System.Drawing.Size(187, 22);
            this.cmRedo.Text = "Redo";
            // 
            // cmUndo
            // 
            this.myCommandControler.SetCommandName(this.cmUndo, "Undo");
            this.cmUndo.Image = ((System.Drawing.Image)(resources.GetObject("cmUndo.Image")));
            this.cmUndo.Name = "cmUndo";
            this.cmUndo.Size = new System.Drawing.Size(187, 22);
            this.cmUndo.Text = "Undo";
            // 
            // cmCut
            // 
            this.myCommandControler.SetCommandName(this.cmCut, "Cut");
            this.cmCut.Image = ((System.Drawing.Image)(resources.GetObject("cmCut.Image")));
            this.cmCut.Name = "cmCut";
            this.cmCut.Size = new System.Drawing.Size(187, 22);
            this.cmCut.Text = "Cut";
            // 
            // cmCopy
            // 
            this.myCommandControler.SetCommandName(this.cmCopy, "Copy");
            this.cmCopy.Image = ((System.Drawing.Image)(resources.GetObject("cmCopy.Image")));
            this.cmCopy.Name = "cmCopy";
            this.cmCopy.Size = new System.Drawing.Size(187, 22);
            this.cmCopy.Text = "Copy";
            // 
            // cmPaste
            // 
            this.myCommandControler.SetCommandName(this.cmPaste, "Paste");
            this.cmPaste.Image = ((System.Drawing.Image)(resources.GetObject("cmPaste.Image")));
            this.cmPaste.Name = "cmPaste";
            this.cmPaste.Size = new System.Drawing.Size(187, 22);
            this.cmPaste.Text = "Paste";
            // 
            // cmDelete
            // 
            this.myCommandControler.SetCommandName(this.cmDelete, "Delete");
            this.cmDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmDelete.Image")));
            this.cmDelete.Name = "cmDelete";
            this.cmDelete.Size = new System.Drawing.Size(187, 22);
            this.cmDelete.Text = "Delete";
            // 
            // cmColor
            // 
            this.myCommandControler.SetCommandName(this.cmColor, "Color");
            this.cmColor.Name = "cmColor";
            this.cmColor.Size = new System.Drawing.Size(187, 22);
            this.cmColor.Text = "Color";
            // 
            // cmFont
            // 
            this.myCommandControler.SetCommandName(this.cmFont, "Font");
            this.cmFont.Image = ((System.Drawing.Image)(resources.GetObject("cmFont.Image")));
            this.cmFont.Name = "cmFont";
            this.cmFont.Size = new System.Drawing.Size(187, 22);
            this.cmFont.Text = "Font...";
            // 
            // cmAlignLeft
            // 
            this.myCommandControler.SetCommandName(this.cmAlignLeft, "AlignLeft");
            this.cmAlignLeft.Image = ((System.Drawing.Image)(resources.GetObject("cmAlignLeft.Image")));
            this.cmAlignLeft.Name = "cmAlignLeft";
            this.cmAlignLeft.Size = new System.Drawing.Size(187, 22);
            this.cmAlignLeft.Text = "Align left";
            // 
            // cmAlignCenter
            // 
            this.myCommandControler.SetCommandName(this.cmAlignCenter, "AlignCenter");
            this.cmAlignCenter.Image = ((System.Drawing.Image)(resources.GetObject("cmAlignCenter.Image")));
            this.cmAlignCenter.Name = "cmAlignCenter";
            this.cmAlignCenter.Size = new System.Drawing.Size(187, 22);
            this.cmAlignCenter.Text = "Align center";
            // 
            // cmAlignRight
            // 
            this.myCommandControler.SetCommandName(this.cmAlignRight, "AlignRight");
            this.cmAlignRight.Image = ((System.Drawing.Image)(resources.GetObject("cmAlignRight.Image")));
            this.cmAlignRight.Name = "cmAlignRight";
            this.cmAlignRight.Size = new System.Drawing.Size(187, 22);
            this.cmAlignRight.Text = "Align right";
            // 
            // cmProperties
            // 
            this.myCommandControler.SetCommandName(this.cmProperties, "ElementProperties");
            this.cmProperties.Name = "cmProperties";
            this.cmProperties.Size = new System.Drawing.Size(187, 22);
            this.cmProperties.Text = "Element properties...";
            // 
            // myEditControl
            // 
            this.myEditControl.AllowDrop = true;
            this.myEditControl.AutoScroll = true;
            this.myEditControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.myEditControl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.myEditControl.ContextMenuStrip = this.cmEdit;
            this.myEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myEditControl.Location = new System.Drawing.Point(0, 0);
            this.myEditControl.Name = "myEditControl";
            this.myEditControl.Size = new System.Drawing.Size(811, 413);
            this.myEditControl.TabIndex = 4;
            // 
            // cmEdit
            // 
            this.cmEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmRedo,
            this.cmUndo,
            this.toolStripMenuItem4,
            this.cmCut,
            this.cmCopy,
            this.cmPaste,
            this.cmDelete,
            this.toolStripMenuItem5,
            this.cmColor,
            this.cmFont,
            this.toolStripMenuItem6,
            this.cmAlignLeft,
            this.cmAlignCenter,
            this.cmAlignRight,
            this.toolStripMenuItem8,
            this.cmProperties});
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Size = new System.Drawing.Size(188, 292);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(184, 6);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(184, 6);
            // 
            // frmTextUseCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 413);
            this.Controls.Add(this.myEditControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTextUseCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharpWriter winform.net demo";
            this.Load += new System.EventHandler(this.frmTextUseCommand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myCommandControler)).EndInit();
            this.cmEdit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList myImageList;
        private DCSoft.CSharpWriter.Commands.CSWriterCommandControler myCommandControler;
        private System.Windows.Forms.ContextMenuStrip cmEdit;
        private System.Windows.Forms.ToolStripMenuItem cmRedo;
        private System.Windows.Forms.ToolStripMenuItem cmUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cmCut;
        private System.Windows.Forms.ToolStripMenuItem cmCopy;
        private System.Windows.Forms.ToolStripMenuItem cmPaste;
        private System.Windows.Forms.ToolStripMenuItem cmDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cmColor;
        private System.Windows.Forms.ToolStripMenuItem cmFont;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem cmAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem cmAlignCenter;
        private System.Windows.Forms.ToolStripMenuItem cmAlignRight;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem cmProperties;
        internal DCSoft.CSharpWriter.Controls.CSWriterControl myEditControl;
    }
}