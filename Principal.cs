using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InfraCodeEditor
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public static List<String> OpenedFilesList = new List<String> { };


        //***********************************************************************************
        //  ChangeTextOfReadyLabel() function to change text of ReadyLabel
        //***********************************************************************************
        public void ChangeTextOfReadyLabel(ToolStripMenuItem menuitem)
        {
            menuitem.MouseEnter += new EventHandler(this.menuitem_MouseEnter);
            menuitem.MouseLeave += new EventHandler(this.menuitem_MouseLeave);
        }
        private void menuitem_MouseEnter(object sender,EventArgs e)
        {
        //    Object b = (ToolStripMenuItem)sender;
        //    String s = b.ToString().Trim();
        //    switch(s)
        //    {
        //        case "Ficheiro":
        //            AboutLabel.Text = "Criar novo, abrir, salvar, fechar e imprimir documentos";

        //            break;
        //        case "Novo":
        //            AboutLabel.Text = "Criar novo documento";
        //            break;
        //        case "Abrir":
        //            AboutLabel.Text = "Abrir novo documento";
        //            break;
        //        case "Salvar":
        //            AboutLabel.Text = "Salvar o documento corrente";
        //            break;
        //        case "Salvar como":
        //            AboutLabel.Text = "Salvar o documento corrente como";
        //            break;
        //        case "Salvar todos":
        //            AboutLabel.Text = "Salvar todos documentos abertos";
        //            break;
        //        case "Fechar":
        //            AboutLabel.Text = "Fechar o documento corrente";
        //            break;
        //        case "Fechar todos":
        //            AboutLabel.Text = "Fechar todos documentos abertos";
        //            break;
        //        case "Imprimir":
        //            AboutLabel.Text = "Imprimir o documento corrente";
        //            break;
        //        case "Prever impressão":
        //            AboutLabel.Text = "Previsualizar o documento corrente";
        //            break;
        //        case "Sair":
        //            AboutLabel.Text = "Encerrar a aplicação";
        //            break;

        //        case "Editar":
        //            AboutLabel.Text = "Cortar, copiar, colar, desfazer, refazer, encontrar, substituir etc. no documento corrente";
        //            break;
        //        case "Cortar":
        //            AboutLabel.Text = "Cortar o texto selecionar do documento corrente";
        //            break;
        //        case "Copiar":
        //            AboutLabel.Text = "Copiar o texto selecionar do documento corrente";
        //            break;
        //        case "Colar":
        //            AboutLabel.Text = "Colar o texto no documento corrente";
        //            break;
        //        case "Desfazer":
        //            AboutLabel.Text = "Desfazer a última operação no documento corrente";
        //            break;
        //        case "Refazer":
        //            AboutLabel.Text = "Refazer a última operação no documento corrente";
        //            break;
        //        case "Encontrar":
        //            AboutLabel.Text = "Encontrar texto no documento corrente";
        //            break;
        //        case "Substituir":
        //            AboutLabel.Text = "Susbstituir texto no documento corrente";
        //            break;
        //        case "Ir para":
        //            AboutLabel.Text = "Ir para uma linha específica no documento corrente";
        //            break;
        //        case "Selecionar tudo":
        //            AboutLabel.Text = "Selecionar todo texto no documento corrente";
        //            break;
        //        case "Change Case":
        //            AboutLabel.Text = "Change Upper and Lower do texto selecionado";
        //            break;
        //        case "Upper":
        //            AboutLabel.Text = "Mudar o texto selecionado para Upper case";
        //            break;
        //        case "Lower":
        //            AboutLabel.Text = "Mudar o texto selecionado para Lower case";
        //            break;
        //        case "Próximo documento":
        //            AboutLabel.Text = "Ir para o próximo documento";
        //            break;
        //        case "Documento anterior":
        //            AboutLabel.Text = "Ir para o doc anterior";
        //            break;

        //        case "Aparência":
        //            AboutLabel.Text = " Definir fonte, cor de letra e de fundo no documento corrente";
        //            break;
        //        case "Fonte":
        //            AboutLabel.Text = "Definir fonte no documento corrente";
        //            break;
        //        case "Cor do texto":
        //            AboutLabel.Text = "Definir cor de letra no documento corrente";
        //            break;
        //        case "Cor do fundo":
        //            AboutLabel.Text = "Definir cor do fundo no documento corrente";
        //            break;
        //    }
        }
        private void menuitem_MouseLeave(object sender, EventArgs e)
        {
            AboutLabel.Text = "Pronto";
            AboutLabel.ForeColor = Color.Black;
        }

        public void UpdateReadyLabel()
        {
            ChangeTextOfReadyLabel(File_MenuItem);
            ChangeTextOfReadyLabel(File_New_MenuItem);
            ChangeTextOfReadyLabel(File_Open_MenuItem);
            ChangeTextOfReadyLabel(File_Save_MenuItem);
            ChangeTextOfReadyLabel(File_SaveAs_MenuItem);
            ChangeTextOfReadyLabel(File_SaveAll_MenuItem);
            ChangeTextOfReadyLabel(File_Close_MenuItem);
            ChangeTextOfReadyLabel(File_CloseAll_MenuItem);
            ChangeTextOfReadyLabel(File_Print_MenuItem);
            ChangeTextOfReadyLabel(File_PrintPreview_MenuItem);
            ChangeTextOfReadyLabel(File_Exit_MenuItem);

            ChangeTextOfReadyLabel(Edit_MenuItem);
            ChangeTextOfReadyLabel(Edit_Cut_MenuItem);
            ChangeTextOfReadyLabel(Edit_Copy_MenuItem);
            ChangeTextOfReadyLabel(Edit_Paste_MenuItem);
            ChangeTextOfReadyLabel(Edit_Undo_MenuItem);
            ChangeTextOfReadyLabel(Edit_Redo_MenuItem);
            ChangeTextOfReadyLabel(Edit_Find_MenuItem);
            ChangeTextOfReadyLabel(Edit_Replace_MenuItem);
            ChangeTextOfReadyLabel(Edit_GoTo_MenuItem);
            ChangeTextOfReadyLabel(Edit_SelectAll_MenuItem);
            ChangeTextOfReadyLabel(Edit_ChangeCase_MenuItem);
            ChangeTextOfReadyLabel(Edit_ChangeCase_Upper_MenuItem);
            ChangeTextOfReadyLabel(Edit_ChangeCase_Lower_MenuItem);
            ChangeTextOfReadyLabel(Edit_NextDocument_MenuItem);
            ChangeTextOfReadyLabel(Edit_PreviousDocument_MenuItem);

            ChangeTextOfReadyLabel(View_MenuItem);
            ChangeTextOfReadyLabel(View_Font_MenuItem);
            ChangeTextOfReadyLabel(View_ForeColor_MenuItem);
            ChangeTextOfReadyLabel(View_BackColor_MenuItem);
        }




        //***************************************************************************
        //       IsArgumentNull Property  
        //***************************************************************************
        public static Boolean _isArgsNull = true;
        public Boolean IsArgumentNull
        {
            get { return _isArgsNull; }
            set { _isArgsNull = value; Invalidate(); }
        }


        //***************************************************************************
        //         MainForm Load
        //***************************************************************************
        private void MainForm_Load(object sender, EventArgs e)
        {
            if(_isArgsNull)
            {
                File_New_MenuItem_Click(sender, e);
                UpdateReadyLabel();
            }
        }

        //***************************************************************************
        //         MainForm Closing
        //***************************************************************************
        private void MainForm_Closing(object sender, FormClosingEventArgs e) 
        {
            if (myTabControlZ.TabCount > 0) 
            { 
                TabControl.TabPageCollection tabcoll = myTabControlZ.TabPages; 
                foreach (TabPage tabpage in tabcoll)
                { 
                    myTabControlZ.SelectedTab = tabpage; 
                    if (tabpage.Text.Contains("*")) 
                    { 
                        DialogResult dg = MessageBox.Show("Desejas salvar o ficheiro " + tabpage.Text + " antes de sair?", "Salvar ou Não", MessageBoxButtons.YesNoCancel); 
                        if (dg == DialogResult.Yes) 
                        { 
                            File_Save_MenuItem_Click(sender, e); 
                            myTabControlZ.TabPages.Remove(tabpage); 
                            myTabControlZ_SelectedIndexChanged(sender, e); 
                        } 
                        else if (dg == DialogResult.Cancel) 
                        { 
                            e.Cancel = true;
                            myTabControlZ.Select();
                            break;
                        } 
                    } 
                    else 
                    {
                        myTabControlZ.TabPages.Remove(tabpage); 
                        myTabControlZ_SelectedIndexChanged(sender, e); 
                    } 
                } 
            } 
        }
        



        //******************************************************************************************



        //*************************************************************************************
        // Update windows list to Window menu
        //*************************************************************************************
        public void UpdateWindowsList_WindowMenu()
        {
            TabControl.TabPageCollection tabcoll = myTabControlZ.TabPages;

            int n = Window_MenuItem.DropDownItems.Count;
            for (int i = n - 1; i >= 4; i--)
            {
                Window_MenuItem.DropDownItems.RemoveAt(i);
            }


            foreach (TabPage tabpage in tabcoll)
            {
                ToolStripMenuItem menuitem = new ToolStripMenuItem();
                String s = tabpage.Text;
                menuitem.Text = s;
                if (myTabControlZ.SelectedTab == tabpage)
                {
                    menuitem.Checked = true;
                }
                else
                {
                    menuitem.Checked = false;
                }
                Window_MenuItem.DropDownItems.Add(menuitem);

                menuitem.Click += new System.EventHandler(WindowListEvent_Click);
            }
        }

        private void WindowListEvent_Click(object sender, EventArgs e)
        {
            ToolStripItem toolstripitem = (ToolStripItem)sender;
            TabControl.TabPageCollection tabcoll = myTabControlZ.TabPages;
            foreach (TabPage tb in tabcoll)
            {
                if (toolstripitem.Text == tb.Text)
                {
                    myTabControlZ.SelectedTab = tb;

                    var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBox1.Select();

                    UpdateWindowsList_WindowMenu();
                }
            }
        }


        //*************************************************************************************
        //  File_MenuItem_DropDownOpening
        //*************************************************************************************
        private void File_MenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if(myTabControlZ.TabCount>0)
            {
                File_New_MenuItem.Enabled = true;
                File_Open_MenuItem.Enabled = true;
                File_Save_MenuItem.Enabled = true;
                File_SaveAs_MenuItem.Enabled = true;
                File_SaveAll_MenuItem.Enabled = true;
                File_Close_MenuItem.Enabled = true;
                File_CloseAll_MenuItem.Enabled = true;
                File_Print_MenuItem.Enabled = true;
                File_PrintPreview_MenuItem.Enabled = true;
                File_Exit_MenuItem.Enabled = true;
            }
            else
            {
                File_New_MenuItem.Enabled = true;
                File_Open_MenuItem.Enabled = true;
                File_Save_MenuItem.Enabled = false;
                File_SaveAs_MenuItem.Enabled = false;
                File_SaveAll_MenuItem.Enabled = false;
                File_Close_MenuItem.Enabled = false;
                File_CloseAll_MenuItem.Enabled = false;
                File_Print_MenuItem.Enabled = false;
                File_PrintPreview_MenuItem.Enabled = false;
                File_Exit_MenuItem.Enabled = true;
            }
        }


        //*************************************************************************************
        //  Edit_MenuItem_DropDownOpening
        //*************************************************************************************
        private void Edit_Menu_DropDownOpening(object sender, EventArgs e)
        {
            if(myTabControlZ.TabCount>0)
            {
                Edit_Cut_MenuItem.Enabled = true;
                Edit_Copy_MenuItem.Enabled = true;
                Edit_Paste_MenuItem.Enabled = true;
                Edit_Undo_MenuItem.Enabled = true;
                Edit_Redo_MenuItem.Enabled = true;
                Edit_Find_MenuItem.Enabled = true;
                Edit_Replace_MenuItem.Enabled = true;
                Edit_GoTo_MenuItem.Enabled = true;
                Edit_SelectAll_MenuItem.Enabled = true;
                Edit_ChangeCase_MenuItem.Enabled = true;

                if(myTabControlZ.TabCount>1)
                {
                    Edit_NextDocument_MenuItem.Enabled = true;
                    Edit_PreviousDocument_MenuItem.Enabled = true;
                }
            }
            else
            {
                Edit_Cut_MenuItem.Enabled = false;
                Edit_Copy_MenuItem.Enabled = false;
                Edit_Paste_MenuItem.Enabled = false;
                Edit_Undo_MenuItem.Enabled = false;
                Edit_Redo_MenuItem.Enabled = false;
                Edit_Find_MenuItem.Enabled = false;
                Edit_Replace_MenuItem.Enabled = false;
                Edit_GoTo_MenuItem.Enabled = false;
                Edit_SelectAll_MenuItem.Enabled = false;
                Edit_ChangeCase_MenuItem.Enabled = false;
                Edit_NextDocument_MenuItem.Enabled = false;
                Edit_PreviousDocument_MenuItem.Enabled = false;
            }
        }


        //*************************************************************************************
        //  View_MenuItem_DropDownOpening
        //*************************************************************************************
        private void View_MenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if(myTabControlZ.TabCount>0)
            {
                View_Font_MenuItem.Enabled = true;
                View_ForeColor_MenuItem.Enabled = true;
                View_BackColor_MenuItem.Enabled = true;
            }
            else
            {
                View_Font_MenuItem.Enabled = false;
                View_ForeColor_MenuItem.Enabled = false;
                View_BackColor_MenuItem.Enabled = false;
            }
        }


        //*************************************************************************************
        //  Run_MenuItem_DropDownOpening
        //*************************************************************************************
        private void Run_MenuItem_DropDownOpening(object sender, EventArgs e)
        {
            if(myTabControlZ.TabCount>0)
            {
                Run_RunInBrowser_MenuItem.Enabled = true;
                Run_PreviewHTMLPage_MenuItem.Enabled = true;
            }
            else
            {
                Run_RunInBrowser_MenuItem.Enabled = false;
                Run_PreviewHTMLPage_MenuItem.Enabled = false;
            }
        }


        public void UpdateDocumentSelectorList()
        {
            TabControl.TabPageCollection tabcoll = myTabControlZ.TabPages;
            foreach(TabPage tabpage in tabcoll)
            {
               String fname = tabpage.Text;
               Color color = Color.FromArgb(245, 255, 245);
                if (fname.Contains("*"))
                {
                    fname = fname.Remove(fname.Length - 1);
                }
                if(fname.Contains("Sem título"))
                {
                    color = Color.FromArgb(245, 255, 245);
                }
                else
                {
                    color = Color.FromArgb(255,250,250);
                }

                TreeNode trnode = new TreeNode();
                trnode.Text = fname;
                trnode.BackColor = color;
            }
        }




        //*************************************************************************************
        //  OpenAssociatedFiles_WhenApplicationStarts()
        //*************************************************************************************
        public void OpenAssociatedFiles_WhenApplicationStarts(String[] files)
        {
            StreamReader strReader;
            String str;
            foreach (string filename in files)
            {
                MyTabPage tabpage = new MyTabPage(this);

                strReader = new StreamReader(filename);
                str = strReader.ReadToEnd();
                strReader.Close();

                String fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                tabpage.Text = fname;

                //add contextmenustrip to richTextBox1
                tabpage._myRichTextBox.richTextBox1.ContextMenuStrip = myContextMenuStrip;

                tabpage._myRichTextBox.richTextBox1.Text = str;
                myTabControlZ.TabPages.Add(tabpage);
                myTabControlZ.SelectedTab = tabpage;


                this.UpdateDocumentSelectorList();


                /* check (*) is available on TabPage Text
                 adding filename to tab page by removing (*) */
                fname = tabpage.Text;
                if (fname.Contains("*"))
                {
                    fname = fname.Remove(fname.Length - 1);
                }
                tabpage.Text = fname;

                //adding filenames to OpenedFilesList list
                OpenedFilesList.Add(filename);

                FilenameToolStripLabel.Text = filename;
                this.Text = "Infra Code Editor [ " + fname + " ]";
            }


            if (myTabControlZ.SelectedIndex >= 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.Select();
            }
            UpdateWindowsList_WindowMenu();
        }



//*****************************************************************************************************************************
//                          File
//*****************************************************************************************************************************

        //***************************************************************************
        //         File -> New
        //***************************************************************************
        public static int count = 1;
        private void File_New_MenuItem_Click(object sender, EventArgs e)
        {
            MyTabPage tabpage = new MyTabPage(this);
            tabpage.Text = "Sem título " + count;
            myTabControlZ.TabPages.Add(tabpage);

            myTabControlZ.SelectedTab = tabpage;

            var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
            _myRichTextBox.richTextBox1.Select();

            //add contextmenustrip to richTextBox1
            _myRichTextBox.richTextBox1.ContextMenuStrip = myContextMenuStrip;

            this.UpdateDocumentSelectorList();

            this.Text = "Infra Code Editor [ Sem título "+count+" ]";

            FilenameToolStripLabel.Text = tabpage.Text;

            UpdateWindowsList_WindowMenu();

            count++;
        }


        //***************************************************************************
        //          File -> Open
        //***************************************************************************
        private void File_Open_MenuItem_Click(object sender, EventArgs e)
        {
            StreamReader strReader;
            String str;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                String[] files = openFileDialog1.FileNames;
                foreach (string filename in files)
                {
                    
                    MyTabPage tabpage = new MyTabPage(this);

                    strReader = new StreamReader(filename);
                    str = strReader.ReadToEnd();
                    strReader.Close();

                    String fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                    tabpage.Text = fname;

                    //add contextmenustrip to richTextBox1
                    tabpage._myRichTextBox.richTextBox1.ContextMenuStrip = myContextMenuStrip;

                    tabpage._myRichTextBox.richTextBox1.Text = str;
                    myTabControlZ.TabPages.Add(tabpage);
                    myTabControlZ.SelectedTab = tabpage;


                    this.UpdateDocumentSelectorList();


                    /* check (*) is available on TabPage Text
                     adding filename to tab page by removing (*) */
                    fname = tabpage.Text;
                    if (fname.Contains("*"))
                    {
                        fname = fname.Remove(fname.Length - 1);
                    }
                    tabpage.Text = fname;

                    //adding filenames to OpenedFilesList list
                    OpenedFilesList.Add(filename);
                    
                    FilenameToolStripLabel.Text = filename;
                    this.Text = "Infra Code Editor [ "+fname+" ]";
                }

                if (myTabControlZ.SelectedIndex >= 0)
                {
                    var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBox1.Select();
                }
                UpdateWindowsList_WindowMenu();
            }
        }


        //***************************************************************************
        //         File -> Save
        //***************************************************************************
        private void File_Save_MenuItem_Click(object sender, EventArgs e)
        {
            TabPage seltab = myTabControlZ.SelectedTab;
            String selecttabname = seltab.Text;

            if (FilenameToolStripLabel.Text.Contains("\\"))
            {
                TabPage tabpage = myTabControlZ.SelectedTab;
                if (tabpage.Text.Contains("*"))
                {
                    String filename = FilenameToolStripLabel.Text;
                    if (File.Exists(filename))
                    {
                        var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                        File.WriteAllText(filename, "");
                        StreamWriter strwriter = System.IO.File.AppendText(filename);
                        strwriter.Write(_myRichTextBox.richTextBox1.Text);
                        strwriter.Close();
                        strwriter.Dispose();
                        tabpage.Text = tabpage.Text.Remove(tabpage.Text.Length - 1);

                        UpdateWindowsList_WindowMenu();

                        this.UpdateDocumentSelectorList();
                    }
                }
            }
            else
            {
                File_SaveAs_MenuItem_Click(sender, e);
            }
        }


        //***************************************************************************
        //         File -> Save As
        //***************************************************************************
        private void File_SaveAs_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                TabPage tabpage = myTabControlZ.SelectedTab;
                if (tabpage != null)
                {
                    var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        String filename = saveFileDialog1.FileName;
                        if (filename != "")
                        {
                            File.WriteAllText(filename, "");
                            StreamWriter strw = new StreamWriter(filename);
                            strw.Write(_myRichTextBox.richTextBox1.Text);
                            strw.Close();
                            strw.Dispose();

                            String fname = filename.Substring(filename.LastIndexOf("\\") + 1);
                            tabpage.Text = fname;
                            this.Text = "Infra Code Editor [ " + fname + " ]";
                            FilenameToolStripLabel.Text = filename;

                            OpenedFilesList.Add(filename);
                            UpdateWindowsList_WindowMenu();

                            this.UpdateDocumentSelectorList();
                        }
                    }
                }
            }
        }



        //***************************************************************************
        //         File -> Save All
        //***************************************************************************
        private void File_SaveAll_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                OpenedFilesList.Reverse();
                TabControl.TabPageCollection tabcoll = myTabControlZ.TabPages;

                foreach(TabPage tabpage in tabcoll)
                {
                    myTabControlZ.SelectedTab = tabpage;
                    myTabControlZ_SelectedIndexChanged(sender, e);
                    
                    if( ! tabpage.Text.Contains("Sem título"))
                    {
                        try
                        {
                            var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                            File.WriteAllText(FilenameToolStripLabel.Text, "");
                            StreamWriter strwriter = System.IO.File.AppendText(FilenameToolStripLabel.Text);
                            strwriter.Write(_myRichTextBox.richTextBox1.Text);
                            strwriter.Close();
                            strwriter.Dispose();
                        }
                        catch { }
                    }
                }

                System.Windows.Forms.TabControl.TabPageCollection tabcollection = myTabControlZ.TabPages;
                foreach (TabPage tabpage in tabcollection)
                {
                    String str = tabpage.Text;
                    if (str.Contains("*")&& !str.Contains("Sem título"))
                    {
                        str = str.Remove(str.Length - 1);
                    }
                    tabpage.Text = str;
                }
                UpdateWindowsList_WindowMenu();
            }
        }



        //***************************************************************************
        //         File -> Close
        //***************************************************************************
        private void File_Close_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                TabPage tabpage = myTabControlZ.SelectedTab;
                if (tabpage.Text.Contains("*"))
                {
                    DialogResult dg = MessageBox.Show("Pretendes salvar o ficheiro " + tabpage.Text + " antes de fechar?", "Salvar antes de fechar?", MessageBoxButtons.YesNo);
                    if (dg == DialogResult.Yes)
                    {
                        //save file before close
                        File_Save_MenuItem_Click(sender, e);
                        //remove tab
                        myTabControlZ.TabPages.Remove(tabpage);

                        //RemoveFileNamesFromTreeView(tabpage.Text);
                        this.UpdateDocumentSelectorList();

                        UpdateWindowsList_WindowMenu();
                        myTabControlZ_SelectedIndexChanged(sender, e);

                        LineToolStripLabel.Text = "Linha";
                        ColumnToolStripLabel.Text = "Coluna";

                        if (myTabControlZ.TabCount == 0)
                        {
                            FilenameToolStripLabel.Text = "Infra Code Editor";
                            count = 1;
                        }
                    }
                    else
                    {
                        //remove tab
                        myTabControlZ.TabPages.Remove(tabpage);

                        UpdateDocumentSelectorList();

                        UpdateWindowsList_WindowMenu();
                        myTabControlZ_SelectedIndexChanged(sender, e);

                        LineToolStripLabel.Text = "Linha";
                        ColumnToolStripLabel.Text = "Coluna";

                        if (myTabControlZ.TabCount == 0)
                        {
                            FilenameToolStripLabel.Text = "Infra Code Editor";
                            count = 1;
                        }
                    }
                }
                else
                {
                    //remove tab
                    myTabControlZ.TabPages.Remove(tabpage);

                   
                    UpdateDocumentSelectorList();

                    UpdateWindowsList_WindowMenu();
                    myTabControlZ_SelectedIndexChanged(sender, e);

                    LineToolStripLabel.Text = "Linha";
                    ColumnToolStripLabel.Text = "Coluna";

                    if (myTabControlZ.TabCount == 0)
                    {
                        FilenameToolStripLabel.Text = "Infra Code Editor";
                        count = 1;
                    }
                }

                if (myTabControlZ.SelectedIndex >= 0)
                {
                    var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                    _myRichTextBox.richTextBox1.Select();
                }

            }
            else
            {
                count = 1;
                FilenameToolStripLabel.Text = "Infra Code Editor";

                LineToolStripLabel.Text = "Linha";
                ColumnToolStripLabel.Text = "Coluna";
                File_New_MenuItem_Click(sender, e);
            }
        }



        //***************************************************************************
        //         File -> Close All
        //***************************************************************************
        private void File_CloseAll_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                System.Windows.Forms.TabControl.TabPageCollection tabcoll = myTabControlZ.TabPages;
                foreach (TabPage tabpage in tabcoll)
                {
                    myTabControlZ.SelectedTab = tabpage;

                    if (tabpage.Text.Contains("*"))
                    {
                        DialogResult dg = MessageBox.Show("Pretendes salvar o ficheiro " + tabpage.Text + " antes de fechar?", "Salvar antes de fechar?", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            //save file
                            File_Save_MenuItem_Click(sender, e);
                            //remove tab
                            myTabControlZ.TabPages.Remove(tabpage);
                            UpdateWindowsList_WindowMenu();
                            myTabControlZ_SelectedIndexChanged(sender, e);
                            LineToolStripLabel.Text = "Linha";
                            ColumnToolStripLabel.Text = "Coluna";

                            if (myTabControlZ.TabCount == 0)
                            {
                                count = 1;
                            }
                        }
                        else
                        {
                            //remove tab
                            myTabControlZ.TabPages.Remove(tabpage);
                            UpdateWindowsList_WindowMenu();
                            myTabControlZ_SelectedIndexChanged(sender, e);
                            LineToolStripLabel.Text = "Linha";
                            ColumnToolStripLabel.Text = "Coluna";

                            if (myTabControlZ.TabCount == 0)
                            {
                                count = 1;
                            }
                        }
                    }
                    else
                    {
                        //remove tab
                        myTabControlZ.TabPages.Remove(tabpage);
                        UpdateWindowsList_WindowMenu();
                        myTabControlZ_SelectedIndexChanged(sender, e);
                        LineToolStripLabel.Text = "Linha";
                        ColumnToolStripLabel.Text = "Coluna";

                        if (myTabControlZ.TabCount == 0)
                        {
                            count = 1;
                        }
                    }
                }
            }
            else
            {
                count = 1;
                FilenameToolStripLabel.Text = "Infra Code Editor";
                LineToolStripLabel.Text = "Linha";
                ColumnToolStripLabel.Text = "Coluna";
            }
        }


        //***************************************************************************


        //***************************************************************************
        //         File -> Print
        //***************************************************************************
        private void File_Print_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.Print();
            }
        }


        //***************************************************************************
        //         File -> Print Preview
        //***************************************************************************
        private void File_PrintPreview_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                if (myTabControlZ.SelectedTab.Text != "Start Page")
                {
                    int select_index = myTabControlZ.SelectedIndex;
                    var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                    e.Graphics.DrawString(_myRichTextBox.richTextBox1.Text, _myRichTextBox.richTextBox1.Font, Brushes.Black, e.MarginBounds.Left, 0, new StringFormat());
                    e.Graphics.PageUnit = GraphicsUnit.Inch;
                }
            }
        }


        //***************************************************************************
        //         File -> Exit
        //***************************************************************************
        private void File_Exit_MenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


//*****************************************************************************************************************************
//                          Edit
//*****************************************************************************************************************************

        //***************************************************************************
        //         Edit -> Cut
        //***************************************************************************
        private void Edit_Cut_MenuItem_Click(object sender, EventArgs e)
        {
            if(myTabControlZ.TabCount>0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                if(_myRichTextBox.richTextBox1.SelectedText!="")
                {
                    if(Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(_myRichTextBox.richTextBox1.SelectedText);
                        _myRichTextBox.richTextBox1.SelectedText = "";
                    }
                    else
                    {
                        Clipboard.SetText(_myRichTextBox.richTextBox1.SelectedText);
                        _myRichTextBox.richTextBox1.SelectedText = "";
                    }
                }
            }
        }

        //***************************************************************************
        //         Edit -> Copy
        //***************************************************************************
        private void Edit_Copy_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                if (_myRichTextBox.richTextBox1.SelectedText != "")
                {
                    if (Clipboard.ContainsText())
                    {
                        Clipboard.Clear();
                        Clipboard.SetText(_myRichTextBox.richTextBox1.SelectedText);
                    }
                    else
                    {
                        Clipboard.SetText(_myRichTextBox.richTextBox1.SelectedText);
                    }
                }
            }
        }

        //***************************************************************************
        //         Edit -> Paste
        //***************************************************************************
        private void Edit_Paste_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];

                if (Clipboard.ContainsText())
                {
                    String str = Clipboard.GetText();
                    _myRichTextBox.richTextBox1.Paste();
                }
            }
        }

        //***************************************************************************
        //         Edit -> Undo
        //***************************************************************************
        private void Edit_Undo_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                if(_myRichTextBox.richTextBox1.CanUndo)
                {
                    _myRichTextBox.richTextBox1.Undo();
                }
            }
        }

        //***************************************************************************
        //         Edit -> Redo
        //***************************************************************************
        private void Edit_Redo_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                if (_myRichTextBox.richTextBox1.CanRedo)
                {
                    _myRichTextBox.richTextBox1.Redo();
                }
            }
        }

        //***************************************************************************
        //         Edit -> Find
        //***************************************************************************
        private void Edit_Find_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                Encontrar f = new Encontrar(_myRichTextBox.richTextBox1);
                f.Show();
            }
        }

        //***************************************************************************
        //         Edit -> Replace
        //***************************************************************************
        private void Edit_Replace_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                Substituir f = new Substituir(_myRichTextBox.richTextBox1);
                f.ShowDialog();
            }
        }

        //***************************************************************************
        //         Edit -> GoTo
        //***************************************************************************
        private void Edit_GoTo_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                IrPara rtf = new IrPara(_myRichTextBox.richTextBox1);
                rtf.ShowDialog();
            }
        }

        //***************************************************************************
        //         Edit -> Select All
        //***************************************************************************
        private void Edit_SelectAll_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectAll();
            }
        }

        //***************************************************************************
        //         Edit -> Change Case -> Upper
        //***************************************************************************
        private void Edit_ChangeCase_Upper_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                int select_index = myTabControlZ.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectedText=_myRichTextBox.richTextBox1.SelectedText.ToUpper();
            }
        }

        //***************************************************************************
        //         Edit -> Change Case -> Lower
        //***************************************************************************
        private void Edit_ChangeCase_Lower_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                int select_index = myTabControlZ.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                _myRichTextBox.richTextBox1.SelectedText = _myRichTextBox.richTextBox1.SelectedText.ToLower();
            }
        }

        //***************************************************************************
        //         Edit -> Change Case -> Sentence
        //***************************************************************************
        private void Edit_ChangeCase_Sentence_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                int select_index = myTabControlZ.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                String s = _myRichTextBox.richTextBox1.SelectedText;
                if (s != "")
                {
                    String firstchar = s[0].ToString();
                    firstchar = firstchar.ToUpper();
                    String str = firstchar + s.Remove(0, 1);
                    str = firstchar + str.Substring(1);
                    _myRichTextBox.richTextBox1.SelectedText = _myRichTextBox.richTextBox1.SelectedText.Replace(_myRichTextBox.richTextBox1.SelectedText, str);
                }
            }
        }

        //***************************************************************************
        //         Edit -> Next Document
        //***************************************************************************
        private void Edit_NextDocument_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                int count = myTabControlZ.TabCount;
                if (myTabControlZ.SelectedIndex <= count)
                {
                    myTabControlZ.SelectedIndex = myTabControlZ.SelectedIndex + 1;
                }
                UpdateWindowsList_WindowMenu();
            }
        }

        //***************************************************************************
        //         Edit -> Previous Document
        //***************************************************************************
        private void Edit_PreviousDocument_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                if (myTabControlZ.SelectedIndex == 0)
                {
                }
                else
                {
                    myTabControlZ.SelectedIndex = myTabControlZ.SelectedIndex - 1;
                }
                UpdateWindowsList_WindowMenu();
            }
        }



//*****************************************************************************************************************************
//                           View
//*****************************************************************************************************************************

        //***************************************************************************
        //         View -> Font
        //***************************************************************************
        private void View_Font_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                int select_index = myTabControlZ.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                FontDialog fd = new FontDialog();
                if(fd.ShowDialog()==DialogResult.OK)
                {
                    _myRichTextBox.richTextBox1.Font = fd.Font;
                }
            }
        }

        //***************************************************************************
        //         View -> Fore Color
        //***************************************************************************
        private void View_ForeColor_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                int select_index = myTabControlZ.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _myRichTextBox.richTextBox1.ForeColor = cd.Color;
                }
            }
        }

        //***************************************************************************
        //         View -> Back Color
        //***************************************************************************
        private void View_BackColor_MenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                int select_index = myTabControlZ.SelectedIndex;
                var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];
                ColorDialog cd = new ColorDialog();
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _myRichTextBox.richTextBox1.BackColor = cd.Color;
                }
            }
        }

        //***************************************************************************

        //***************************************************************************
        //         View -> ToolStrip
        //***************************************************************************
        private void View_ToolStrip_MenuItem_Click(object sender, EventArgs e)
        {
            if(View_ToolStrip_MenuItem.Checked==false)
            {
                myToolStripZ.Visible = true;
                View_ToolStrip_MenuItem.Checked = true;
            }
            else
            {
                myToolStripZ.Visible = false;
                View_ToolStrip_MenuItem.Checked = false;
            }
        }

        //***************************************************************************
        //         View -> Status Strip
        //***************************************************************************
        private void View_StatusStrip_MenuItem_Click(object sender, EventArgs e)
        {
            if (View_StatusStrip_MenuItem.Checked == false)
            {
                statusStrip1.Visible = true;
                View_StatusStrip_MenuItem.Checked = true;
            }
            else
            {
                 statusStrip1.Visible = false;
                View_StatusStrip_MenuItem.Checked = false;
            }
        }

        private void View_FullScreen_MenuItem_Click(object sender, EventArgs e)
        {
            if(View_FullScreen_MenuItem.Checked==false)
            {
                this.Visible = false;
                this.FormBorderStyle = FormBorderStyle.None;
                this.Visible = true;

                View_FullScreen_MenuItem.Checked = true;
            }
            else
            {
                this.Visible = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.Visible = true;

                View_FullScreen_MenuItem.Checked =false ;
            }
        }

        //***************************************************************************
        //         View -> Tabs Align -> Top
        //***************************************************************************
        private void View_TabsAlign_Top_MenuItem_Click(object sender, EventArgs e)
        {
            if(View_TabsAlign_Top_MenuItem.Checked==false)
            {
                myTabControlZ.Alignment = TabAlignment.Top;
                View_TabsAlign_Top_MenuItem.Checked = true;

                if(View_TabsAlign_Bottom_MenuItem.Checked==true)
                {
                    View_TabsAlign_Bottom_MenuItem.Checked = false;
                }
            }
        }

        //***************************************************************************
        //         View -> Tabs Align -> Bottom
        //***************************************************************************
        private void View_TabsAlign_Bottom_MenuItem_Click(object sender, EventArgs e)
        {
            if (View_TabsAlign_Bottom_MenuItem.Checked == false)
            {
                myTabControlZ.Alignment = TabAlignment.Bottom;
                View_TabsAlign_Bottom_MenuItem.Checked = true;

                if (View_TabsAlign_Top_MenuItem.Checked == true)
                {
                    View_TabsAlign_Top_MenuItem.Checked = false;
                }
            }
        }


//*****************************************************************************************************************************
//                           Run
//*****************************************************************************************************************************

        //***************************************************************************
        //         Run -> Run
        //***************************************************************************
    

        //***************************************************************************
        //         Run -> Run In Browser
        //***************************************************************************
      

        //***************************************************************************
        //         Run -> Preview HTML Page
        //***************************************************************************
 

        //***************************************************************************
        //         Run -> Google Search
        //***************************************************************************
        private void Run_GoogleSearch_MenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https:\\www.google.com");
        }

        //***************************************************************************
        //         Run -> Facebook
        //***************************************************************************
        private void Run_Facebook_MenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https:\\www.facebook.com");
        }

        //***************************************************************************
        //         Run -> Twitter
        //***************************************************************************
        private void Run_Twitter_MenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https:\\twitter.com"); 
        }


//*****************************************************************************************************************************
//                           Window
//*****************************************************************************************************************************
        //***************************************************************************
        //         Window -> Restart
        //***************************************************************************
        private void Window_Restart_MenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //***************************************************************************
        //         Window -> Close All Windows
        //***************************************************************************
        private void Window_CloseAllWindows_MenuItem_Click(object sender, EventArgs e)
        {
            File_CloseAll_MenuItem_Click(sender, e);
        }


//*****************************************************************************************************************************
//                           Help
//*****************************************************************************************************************************
        //***************************************************************************
        //         Help -> Help Contents
        //***************************************************************************
        private void Help_HelpContents_MenuItem_Click(object sender, EventArgs e)
        {
            String filename=Application.StartupPath+ "\\Help\\Infra Code Editor Help.pdf";
            if(File.Exists(filename))
            {
                Process.Start(filename);
            }
        }

        //***************************************************************************
        //         Help -> Online Help
        //***************************************************************************
        private void Help_OnlineHelp_MenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https:\\www.google.com");
        }

        //***************************************************************************
        //         Help -> About
        //***************************************************************************
        private void Help_About_MenuItem_Click(object sender, EventArgs e)
        {
            About_Form af = new About_Form();
            af.ShowDialog();
        }




//*****************************************************************************************************************************
//                           Tool Strip Buttons Actions
//*****************************************************************************************************************************
        private void New_ToolStripButton_Click(object sender, EventArgs e)
        {
            File_New_MenuItem_Click(sender, e);
        }

        private void Open_ToolStripButton_Click(object sender, EventArgs e)
        {
            File_Open_MenuItem_Click(sender, e);
        }

        private void Save_ToolStripButton_Click(object sender, EventArgs e)
        {
            File_Save_MenuItem_Click(sender, e);
        }

        private void SaveAs_ToolStripButton_Click(object sender, EventArgs e)
        {
            File_SaveAs_MenuItem_Click(sender, e);
        }

        private void Cut_ToolStripButton_Click(object sender, EventArgs e)
        {
            Edit_Cut_MenuItem_Click(sender, e);
        }

        private void Copy_ToolStripButton_Click(object sender, EventArgs e)
        {
            Edit_Copy_MenuItem_Click(sender, e);
        }

        private void Paste_ToolStripButton_Click(object sender, EventArgs e)
        {
            Edit_Paste_MenuItem_Click(sender, e);
        }

        private void Undo_ToolStripButton_Click(object sender, EventArgs e)
        {
            Edit_Undo_MenuItem_Click(sender, e);
        }

        private void Redo_ToolStripButton_Click(object sender, EventArgs e)
        {
            Edit_Redo_MenuItem_Click(sender, e);
        }

        private void Font_ToolStripButton_Click(object sender, EventArgs e)
        {
            View_Font_MenuItem_Click(sender, e);
        }




//*****************************************************************************************************************************
//                        richTextBox1 Context Menu Strip menus Actions
//*****************************************************************************************************************************
        private void Cut_ContextMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Cut_MenuItem_Click(sender, e);
        }

        private void Copy_ContextMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Copy_MenuItem_Click(sender, e);
        }

        private void Paste_ContextMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Paste_MenuItem_Click(sender, e);
        }

        private void SelectAll_ContextMenuItem_Click(object sender, EventArgs e)
        {
            Edit_SelectAll_MenuItem_Click(sender, e);
        }

        private void Upper_ContextMenuItem_Click(object sender, EventArgs e)
        {
            Edit_ChangeCase_Upper_MenuItem_Click(sender, e);
        }

        private void Lower_ContextMenuItem_Click(object sender, EventArgs e)
        {
            Edit_ChangeCase_Lower_MenuItem_Click(sender, e);
        }

        private void Sentence_ContextMenuItem_Click(object sender, EventArgs e)
        {
            Edit_ChangeCase_Sentence_MenuItem_Click(sender, e);
        }

        private void SetFont_ContextMenuItem_Click(object sender, EventArgs e)
        {
            View_Font_MenuItem_Click(sender, e);
        }






//*****************************************************************************************************************************
//                        myTabControlZ Context Menu Strip menus Actions
//*****************************************************************************************************************************
        private void myTabControl_ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if(myTabControlZ.TabCount>0)
            {
                TabPage tabpage = myTabControlZ.SelectedTab;
                myTabControl_Save_MenuItem.Text = "Salvar  " + tabpage.Text;
            }
        }

        private void myTabControl_Save_MenuItem_Click(object sender, EventArgs e)
        {
            File_Save_MenuItem_Click(sender, e);
        }

        private void myTabControl_SaveAll_MenuItem_Click(object sender, EventArgs e)
        {
            File_SaveAll_MenuItem_Click(sender, e);
        }

        private void myTabControl_Close_MenuItem_Click(object sender, EventArgs e)
        {
            File_Close_MenuItem_Click(sender, e);
        }

        private void myTabControl_CloseAll_MenuItem_Click(object sender, EventArgs e)
        {
            File_CloseAll_MenuItem_Click(sender, e);
        }


        private void myTabControl_CloseAllButThis_MenuItem_Click(object sender, EventArgs e)
        {
            String tabtext = myTabControlZ.SelectedTab.Text;
            if (myTabControlZ.TabCount > 1)
            {
                TabControl.TabPageCollection tabcoll = myTabControlZ.TabPages;
                foreach (TabPage tabpage in tabcoll)
                {
                    myTabControlZ.SelectedTab = tabpage;
                    if (myTabControlZ.SelectedTab.Text != tabtext)
                    {
                        File_Close_MenuItem_Click(sender, e);
                    }
                }
            }
            else if (myTabControlZ.TabCount == 1)
            {
                File_Close_MenuItem_Click(sender, e);
            }
        }


        private void myTabControl_OpenFileFolder_MenuItem_Click(object sender, EventArgs e)
        {
            if(myTabControlZ.TabCount>0)
            {
                if( ! myTabControlZ.SelectedTab.Text.Contains("Sem título"))
                {
                    if(FilenameToolStripLabel.Text.Contains("\\"))
                    {
                        TabPage tabpage = myTabControlZ.SelectedTab;
                        String tabtext = tabpage.Text;
                        if(tabtext.Contains("*"))
                        {
                            tabtext = tabtext.Remove(tabtext.Length - 1);
                        }
                        String fname = FilenameToolStripLabel.Text;
                        String filename=fname.Remove(fname.Length-(tabtext.Length+1));
                        Process.Start(filename);
                    }
                }
            }
        }

        private void compilarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                File_Save_MenuItem_Click(sender, e);

                if (FilenameToolStripLabel.Text.Contains("\\"))
                {
                    compilarToolStripMenuItem.Enabled = false;
                    toolStripButton1.Enabled = false;
                    listView1.Items.Clear();

                    AboutLabel.Text = "Analisando o código fonte...";

                    Process p = new Process();
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.FileName = "cmd";
                    p.StartInfo.RedirectStandardInput = true;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.UseShellExecute = false;

                    p.Start();

                    var _myRichTextBox = (MyRichTextBox)myTabControlZ.TabPages[myTabControlZ.SelectedIndex].Controls[0];

                    p.StandardInput.WriteLine("infra\\bin\\infra<" + FilenameToolStripLabel.Text);
                    p.StandardInput.WriteLine("exit");
                    RichTextBox resultado = new RichTextBox();
                    resultado.Text  = p.StandardOutput.ReadToEnd();

                    panel2.Visible = true;
                    
                    foreach(String linha in resultado.Lines)
                    {
                        if (linha.StartsWith("ME"))
                        {
                            ListViewItem itm = new ListViewItem();
                            itm.Text = linha.Substring (linha.IndexOf("LE"));
                            itm.Text = itm.Text.Remove(0, 2);

                            String tipo = linha.Split(',')[0];
                            tipo = tipo.Replace("ME", "");
                            itm.SubItems.Add(tipo);

                            String mensagem = "";
                            for (int i=0; i<linha.Length; i++)
                            {
                                if (linha[i]==',')
                                {
                                    mensagem = linha.Substring(i);
                                    mensagem = mensagem.Remove(mensagem.IndexOf ("LE"));
                                    mensagem = mensagem.Remove(0, 2);
                                    break;
                                }

                            }

                            itm.SubItems.Add(mensagem);

                            TabPage tabpage = myTabControlZ.SelectedTab;
                            itm.SubItems.Add(tabpage.Text);

                            itm.Font = new Font("Arial", 10, FontStyle.Regular);

                            listView1.Items.Add(itm);
                        }
                        if (linha.StartsWith("MFF"))
                        {
                            AboutLabel.Text = linha.Replace("MFF", "");
                            AboutLabel.Text = "Falha, compilação sem éxito.";
                            AboutLabel.ForeColor = Color.DarkRed;
                        }
                        if (linha.StartsWith("MFO"))
                        {
                            AboutLabel.Text = linha.Replace("MFO", "");
                            AboutLabel.Text = "Ok, código compilado com sucesso.";
                            AboutLabel.ForeColor = Color.Black;
                        }
                    }
                    compilarToolStripMenuItem.Enabled = true;
                    toolStripButton1.Enabled = true;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem1.Checked == false)
            {
                panel2.Visible = true;
                toolStripMenuItem1.Checked = true;
            }
            else
            {
                panel2.Visible = false;
                toolStripMenuItem1.Checked = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            compilarToolStripMenuItem_Click(sender, e);
        }

        private void myTabControlZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (myTabControlZ.TabCount > 0)
            {
                TabPage tabpage = myTabControlZ.SelectedTab;
                if (tabpage.Text.Contains("Sem título"))
                {
                    FilenameToolStripLabel.Text = tabpage.Text;
                    this.Text = "Infra Code Editor [ " + tabpage.Text + " ]";
                    UpdateWindowsList_WindowMenu();
                }
                else
                {
                    foreach (String filename in OpenedFilesList)
                    {
                        if (tabpage != null)
                        {
                            String str = filename.Substring(filename.LastIndexOf("\\") + 1);
                            if (tabpage.Text.Contains("*"))
                            {
                                String str2 = tabpage.Text.Remove(tabpage.Text.Length - 1);
                                if (str == str2)
                                {
                                    FilenameToolStripLabel.Text = filename;
                                    this.Text = "Infra Code Editor [ " + tabpage.Text + " ]";
                                }
                            }

                            else
                            {
                                if (str == tabpage.Text)
                                {
                                    FilenameToolStripLabel.Text = filename;
                                    this.Text = "Infra Code Editor [ " + tabpage.Text + " ]";
                                }
                            }
                        }
                    }

                    UpdateWindowsList_WindowMenu();
                }
            }
            else
            {
                FilenameToolStripLabel.Text = "Infra Code Editor";
                this.Text = "Infra Code Editor";
                UpdateWindowsList_WindowMenu();
            }
        }
    }
}
