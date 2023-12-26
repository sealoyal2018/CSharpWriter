/*****************************
CSharpWriter is a RTF style Text writer control written by C#,Currently,
it use <LGPL> license.More than RichTextBox, 
It is provide a DOM to access every thing in document and save in XML format.
It can use in WinForm.NET ,WPF,Console application.Any idea about CSharpWriter 
can write to 28348092@qq.com(or yyf9989@hotmail.com). 
Project web site is [https://github.com/dcsoft-yyf/CSharpWriter].
*****************************///@DCHC@
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DCSoft.CSharpWriter.Controls;
using DCSoft.CSharpWriter.Dom;
using System.IO;

namespace DCSoft.CSharpWriter.WinFormDemo
{
    /// <summary>
    /// Demo of DCSoft.CSharpWriter
    /// </summary>
    public partial class frmTextUseCommand : Form
    {
        public frmTextUseCommand()
        {
            InitializeComponent();
            myEditControl.ServerObject = new ServerObjectSample(this);
            myEditControl.DoubleBuffering = true;
            myEditControl.AllowDragContent = true;
              
        }

        private void frmTextUseCommand_Load(object sender, EventArgs e)
        {
            //DCSoft.CSharpWriter.Controls.TextWindowsFormsEditorHost.PopupFormSizeFix = new System.Drawing.Size(40, 20);
            myEditControl.Font = new Font(System.Windows.Forms.Control.DefaultFont.Name, 12);

            // 设置编辑器界面双缓冲
            myEditControl.DoubleBuffering = true;// _StartOptions.DoubleBuffering;
            // init command controler
            myEditControl.CommandControler = myCommandControler;
            myCommandControler.Start();

            myEditControl.DocumentOptions = new DocumentOptions();
            // 设置文档处于调试模式
            myEditControl.DocumentOptions.BehaviorOptions.DebugMode = true;

            // Without permission control


            var dir = Path.Combine(Application.StartupPath, "DemoFile");
            if (Directory.Exists(dir))
            {
                var fns = Directory.GetFiles(dir, "*.xml");
                if (fns != null && fns.Length > 0)
                {
                    foreach (var fn in fns)
                    {
                        this.Cursor = Cursors.WaitCursor;
                        this.myEditControl.LoadDocument(fn, FileFormat.XML);
                        this.Cursor = Cursors.Default;
                    }
                }
            }
        }

         
        /// <summary>
        /// Demo of server object in document
        /// </summary>
        public class ServerObjectSample
        {
            public ServerObjectSample(frmTextUseCommand frm)
            {
                _Form = frm;
            }

            private frmTextUseCommand _Form = null;
            public frmTextUseCommand Form
            {
                get
                {
                    return _Form;
                }
            }

            public string FormTitle
            {
                get
                {
                    return _Form.Text;
                }
            }

            public string AppPath
            {
                get
                {
                    return Application.StartupPath;
                }
            }

            private string _Name = "Zhang san";

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            private DateTime _Birthday = new DateTime( 1990 , 1 , 1);

            public DateTime Birthday
            {
                get { return _Birthday; }
                set { _Birthday = value; }
            }

            private string _Nation = "China";

            public string Nation
            {
                get { return _Nation; }
                set { _Nation = value; }
            }
        }

        private void menuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }

         

        private void mTestInsertXML_Click(object sender, EventArgs e)
        {

            myEditControl.XMLText = @"<?xml version='1.0'?>
<XTextDocument xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'>
  <XElements>
    <Element xsi:type='XTextBody'>
      <XElements>
        <Element xsi:type='XString'>
          <Text>111</Text>
        </Element>
        <Element xsi:type='XString' StyleIndex='0'>
          <Text>111</Text>
        </Element>
        <Element xsi:type='XString' StyleIndex='1'>
          <Text>11</Text>
        </Element>
        <Element xsi:type='XString' StyleIndex='2'>
          <Text>1</Text>
        </Element>
        <Element xsi:type='XString'>
          <Text>11</Text>
        </Element>
        <Element xsi:type='XParagraphFlag' />
      </XElements>
    </Element>
    <Element xsi:type='XTextHeader'>
      <XElements>
        <Element xsi:type='XParagraphFlag' />
      </XElements>
    </Element>
    <Element xsi:type='XTextFooter'>
      <XElements>
        <Element xsi:type='XParagraphFlag' />
      </XElements>
    </Element>
  </XElements>
  <Info>
    <CreationTime>2012-03-29T15:47:51.1032576+08:00</CreationTime>
    <LastModifiedTime>2012-03-29T15:47:51.1042577+08:00</LastModifiedTime>
    <LastPrintTime>1980-01-01T00:00:00</LastPrintTime>
    <Operator>DCSoft.CSharpWriter Version:1.0.1111.28434</Operator>
  </Info>
  <DefaultFont>
    <Size>12</Size>
  </DefaultFont>
  <ContentStyles>
    <Default>
      <FontName>宋体</FontName>
      <FontSize>12</FontSize>
    </Default>
    <Styles>
      <Style Index='0'>
        <Bold>true</Bold>
      </Style>
      <Style Index='1'>
        <FontSize>24</FontSize>
        <Bold>true</Bold>
      </Style>
      <Style Index='2'>
        <FontSize>24</FontSize>
      </Style>
    </Styles>
  </ContentStyles>
  <DocumentGraphicsUnit>Document</DocumentGraphicsUnit>
  <PageSettings>
    <DesignerPaperWidth>0</DesignerPaperWidth>
    <DesignerPaperHeight>0</DesignerPaperHeight>
  </PageSettings>
  <CustomerParameters />
</XTextDocument>";
        }

    }
}