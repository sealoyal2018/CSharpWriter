﻿/*****************************
CSharpWriter is a RTF style Text writer control written by C#,Currently,
it use <LGPL> license.More than RichTextBox, 
It is provide a DOM to access every thing in document and save in XML format.
It can use in WinForm.NET ,WPF,Console application.Any idea about CSharpWriter 
can write to 28348092@qq.com(or yyf9989@hotmail.com). 
Project web site is [https://github.com/dcsoft-yyf/CSharpWriter].
*****************************///@DCHC@
using System;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using DCSoft.CSharpWriter.Dom;
using DCSoft.CSharpWriter.Data;
using DCSoft.HtmlDom;

namespace DCSoft.CSharpWriter
{
    /// <summary>
    /// 文档加载器
    /// </summary>
    /// <remarks>编制 袁永福</remarks>
    internal class DocumentLoader
    {
      

        private IFileSystem _fileSystem = null;
        public static DomDocument LoadXmlFileWithCreateDocument(
            string fileName ,
            DomDocument sourceDocument )
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName");
            }
            if (System.IO.File.Exists(fileName) == false)
            {
                throw new System.IO.FileNotFoundException(fileName);
            }
            using ( System.IO.FileStream stream = new System.IO.FileStream(
                fileName,
                System.IO.FileMode.Open,
                System.IO.FileAccess.Read))
            {
                return LoadXmlFileWithCreateDocument(stream, sourceDocument);
            }
        }

        internal static DomDocument FastLoadXMLFile(System.IO.Stream stream, Type documentType)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            XmlSerializer ser = DocumentSaver.GetDocumentXmlSerializer(documentType);
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(stream);
            reader.Normalization = false;
            DomDocument document = (DomDocument)ser.Deserialize(reader);
            if (string.Compare(document.EditorVersionString, "1.1") < 0)
            {
                // 修复ListSource
            }
            return document;
        }

        public static DomDocument LoadXmlFileWithCreateDocument(
            System.IO.Stream stream ,
            DomDocument sourceDocument )
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            XmlSerializer ser = DocumentSaver.GetDocumentXmlSerializer(
                sourceDocument == null ? typeof(DomDocument) : sourceDocument.GetType());
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(stream);
            reader.Normalization = false;
            DomDocument document = ( DomDocument ) ser.Deserialize(reader);
            if ( string.Compare( document.EditorVersionString , "1.1" ) < 0 )
            {
                // 修复ListSource
            }
            if (sourceDocument != null)
            {
                document.ServerObject = sourceDocument.ServerObject;
                document.Options = sourceDocument.Options;
               
            }
            document.AfterLoad(FileFormat.XML);
            return document;
        }


        public static DomDocument LoadXmlFileWithCreateDocument(
            System.IO.TextReader reader ,
            DomDocument sourceDocument )
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            XmlSerializer ser = DocumentSaver.GetDocumentXmlSerializer(
                sourceDocument == null ? typeof( DomDocument ): sourceDocument.GetType() );
            System.Xml.XmlTextReader reader2 = new System.Xml.XmlTextReader(reader);
            reader2.Normalization = false;
            DomDocument document = (DomDocument)ser.Deserialize( reader2 );
            if (sourceDocument != null)
            {
                document.ServerObject = sourceDocument.ServerObject;
                document.Options = sourceDocument.Options;
                
            }
             
            document.AfterLoad(FileFormat.XML);
            return document;
        }

        public static DomDocument LoadXmlFileWithCreateDocument(
            System.Xml.XmlReader reader,
            DomDocument sourceDocument )
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            XmlSerializer ser = DocumentSaver.GetDocumentXmlSerializer(
                sourceDocument == null ? typeof( DomDocument ) : sourceDocument.GetType() );
            if (reader is System.Xml.XmlTextReader)
            {
                ((System.Xml.XmlTextReader)reader).Normalization = false;
            }
            DomDocument document = (DomDocument)ser.Deserialize(reader);
            if (sourceDocument != null)
            {
                document.ServerObject = sourceDocument.ServerObject;
                document.Options = sourceDocument.Options;
                
            }
            document.AfterLoad(FileFormat.XML);
            return document;
        }

        public static void LoadXmlFile(
            System.IO.Stream stream, 
            DomDocument document)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            if (document == null)
            {
                throw new ArgumentNullException("document");
            }

            DomDocument doc = LoadXmlFileWithCreateDocument(stream, document);
            if (doc != null)
            {
                document.CopyContent(doc , true );
                document.AfterLoad(FileFormat.XML);
            }
        }


        public static void LoadXmlFile(
            System.IO.TextReader reader ,
            DomDocument document)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }
            if (document == null)
            {
                throw new ArgumentNullException("document");
            }
            DomDocument tempDoc = LoadXmlFileWithCreateDocument(reader, document);
            if (tempDoc != null)
            {
                //string txt = tempDoc.GetDebugText() ;
                //System.Windows.Forms.MessageBox.Show(txt);
                document.CopyContent(tempDoc, true);
                document.AfterLoad(FileFormat.XML);
                //txt = txt + "\r\n------------\r\n" + document.GetDebugText();
                //System.Windows.Forms.MessageBox.Show(txt);
                
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("Load NULL");
            }
        }

        public static void LoadXmlFile(
            string fileName,
            DomDocument document)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName");
            }
            if (System.IO.File.Exists(fileName) == false)
            {
                throw new System.IO.FileNotFoundException(fileName);
            }
            if (document == null)
            {
                throw new ArgumentNullException("document");
            }
            DomDocument doc = LoadXmlFileWithCreateDocument(fileName, document);
            if (doc != null)
            {
                document.CopyContent(doc , true );
                document.AfterLoad(FileFormat.XML);
            }
        }

        //internal static bool LoadOldXmlFile(
        //    System.IO.Stream stream,
        //    XTextDocument document )
        //{
        //    if (stream == null)
        //    {
        //        throw new ArgumentNullException("stream");
        //    }
        //    if (document == null)
        //    {
        //        throw new ArgumentNullException("document");
        //    }

        //    System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
        //    xmlDoc.Load( stream );
        //    DCSoft.CSharpWriter.Xml.OldXMLLoader loader = new Xml.OldXMLLoader();
        //    return loader.LoadOldXml(document, xmlDoc.DocumentElement);
        //}

        //internal static bool LoadOldXmlFile(
        //    System.IO.TextReader reader,
        //    XTextDocument document)
        //{
        //    if (reader == null)
        //    {
        //        throw new ArgumentNullException("reader");
        //    }
        //    if (document == null)
        //    {
        //        throw new ArgumentNullException("document");
        //    }

        //    System.Xml.XmlDocument xmlDoc = new System.Xml.XmlDocument();
        //    xmlDoc.Load(reader);
        //    DCSoft.CSharpWriter.Xml.OldXMLLoader loader = new Xml.OldXMLLoader();
        //    return loader.LoadOldXml(document, xmlDoc.DocumentElement);
        //}


        public static void LoadTextFile(string fileName, DomDocument document)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName");
            }
            if (System.IO.File.Exists(fileName) == false)
            {
                throw new System.IO.FileNotFoundException(fileName);
            } 

            if (document == null)
            {
                throw new ArgumentNullException("document");
            }
            using (StreamReader reader = new StreamReader(
               fileName,
               Encoding.Default,
               true))
            {
                string txt = reader.ReadToEnd();
                document.Text = txt;
                document.AfterLoad(FileFormat.Text);
                document.Modified = false;
            }
        }

        public static void LoadTextFile(TextReader reader, DomDocument document)
        {
            if (reader == null)
            {
                throw new ArgumentNullException("reader");
            }

            if (document == null)
            {
                throw new ArgumentNullException("document");
            }
            string txt = reader.ReadToEnd();
            document.Text = txt;
            document.AfterLoad(FileFormat.Text);
            document.Modified = false;
        }


        public static void LoadTextFile(
            Stream stream,
            DomDocument document)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            if (document == null)
            {
                throw new ArgumentNullException("document");
            }
            using (StreamReader reader = new StreamReader(
                stream,
                Encoding.Default,
                true))
            {
                string txt = reader.ReadToEnd();
                document.Text = txt;
                document.AfterLoad(FileFormat.Text);
                document.Modified = false;
            }
        }
    }
}
