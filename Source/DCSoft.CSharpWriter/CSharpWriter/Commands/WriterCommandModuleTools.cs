/*****************************
CSharpWriter is a RTF style Text writer control written by C#,Currently,
it use <LGPL> license.More than RichTextBox, 
It is provide a DOM to access every thing in document and save in XML format.
It can use in WinForm.NET ,WPF,Console application.Any idea about CSharpWriter 
can write to 28348092@qq.com(or yyf9989@hotmail.com). 
Project web site is [https://github.com/dcsoft-yyf/CSharpWriter].
*****************************///@DCHC@
using System;
using System.Collections.Generic;
using System.Text;
using DCSoft.CSharpWriter.Dom;
using DCSoft.CSharpWriter.Controls;
using System.Windows.Forms;
using DCSoft.Drawing;
using DCSoft.CSharpWriter.Undo;
using System.Drawing;
using DCSoft.Common;
using DCSoft.WinForms.Design;
using DCSoft.CSharpWriter.Data;
using System.ComponentModel;

namespace DCSoft.CSharpWriter.Commands
{
    /// <summary>
    /// 工具类型的编辑器命令容器
    /// </summary>
    /// <remarks>编制 袁永福</remarks>
    [WriterCommandDescription("Tools")]
    internal class WriterCommandModuleTools : CSWriterCommandModule
    {
        /// <summary>
        /// 初始化对象
        /// </summary>
        public WriterCommandModuleTools()
        {
        }
         

         
        /// <summary>
        /// 显示文档字数统计信息
        /// </summary>
        /// <param name="sender">参数</param>
        /// <param name="args">参数</param>
        [WriterCommandDescription(StandardCommandNames.WordCount,
            ImageResource = "DCSoft.CSharpWriter.Commands.Images.CommandWordCount.bmp")]
        protected void WordCount(object sender, WriterCommandEventArgs args)
        {
            if (args.Mode == WriterCommandEventMode.QueryState)
            {
                args.Enabled = args.Document != null;
            }
            else if (args.Mode == WriterCommandEventMode.Invoke)
            {
                if (args.Document != null)
                {
                    DomElementList list = new DomElementList();
                    if (args.Document.Selection.Length != 0)
                    {
                        // 计算被选择区域
                        list = args.Document.Selection.ContentElements.Clone();
                    }
                    else
                    {
                        // 计算整个文档
                        foreach (DomDocumentContentElement ce in args.Document.Elements)
                        {
                            if (ce.IsEmpty == false)
                            {
                                list.AddRange(ce.Content);
                            }
                        }
                    }
                    WordCountResult result = new WordCountResult(args.Document, list);
                    args.Result = result;
                    if (args.ShowUI)
                    {
                        using (dlgWordCount dlg = new dlgWordCount())
                        {
                            dlg.CountResult = result;
                            dlg.ShowDialog(args.EditorControl);
                        }
                    }
                    args.RefreshLevel = UIStateRefreshLevel.None;
                }
            }
        }


    }
}
