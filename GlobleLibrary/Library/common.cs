using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Text.RegularExpressions;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;

namespace GlobleLibrary
{
   public class Common
    {
        #region Message
        public static void MessageUpdate()
        {
            MessageBox.Show("Record Update Sucessfully");
        }
        public static void MessageSave()
        {
            MessageBox.Show("Record Save Sucessfully");
        }
        public static void MessageDelete()
        {
            MessageBox.Show("Record Delete Sucessfully");
        }
        public static void MessageAlert(string msg)
        {
            MessageBox.Show(msg);
        }
        public static bool MessageConfim(string msg)
        {
            string str = MessageBox.Show(msg, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning).ToString();
            if (str.Equals("Yes"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Style
        public void SetStyle(Form Form1)
        {
            if (Form1.AccessibleName == "SetStyle1")
            {
                //Form1.WindowState = FormWindowState.Normal;
                Form1.FormBorderStyle = FormBorderStyle.None;
                Form1.StartPosition = FormStartPosition.CenterParent;
                Form1.ControlBox = false;
            }
            SetControlStyle(Form1);
            
        }
        public void SetControlStyle(Control ParentControl)
        {
            foreach (Control ctr in ParentControl.Controls)
            {
                #region GroupBox style
                if (ctr.GetType().Equals(typeof(GroupBox)))
                {
                    ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ctr.ForeColor = System.Drawing.Color.DarkBlue;
                    ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));

                    if (ctr.AccessibleName == "SetStyle1")
                    {
                        ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        ctr.ForeColor = System.Drawing.Color.White;
                        ctr.BackColor = System.Drawing.Color.LightSlateGray;
                    }
                    if (ctr.AccessibleName == "SetStyle2")
                    {
                        ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        ctr.ForeColor = System.Drawing.Color.Chartreuse;
                        ctr.BackColor = System.Drawing.Color.LightSlateGray;
                    }
                    if (ctr.AccessibleName == "StyleTransparent")
                    {
                        //ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        ctr.ForeColor = System.Drawing.Color.Black;
                        ctr.BackColor = System.Drawing.Color.Transparent;
                    }
                }
                #endregion
                #region RadioButton style
                if (ctr.GetType().Equals(typeof(RadioButton)))
                {
                    ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ctr.ForeColor = System.Drawing.Color.White;

                    if (ctr.AccessibleName == "NoStyle")
                    {
                        
                    }
                }
                #endregion
                #region CheckBox style
                if (ctr.GetType().Equals(typeof(CheckBox)))
                {
                    ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    ctr.ForeColor = System.Drawing.Color.LightSalmon;

                    if (ctr.AccessibleName == "NoStyle")
                    {
                        
                    }
                }
                #endregion
                #region Panel Style
                if (ctr.GetType().Equals(typeof(Panel)))
                {
                    //ctr.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
                    ctr.BackColor = System.Drawing.Color.Black;
                    if (ctr.AccessibleName == "SetStyle1")
                    {
                        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
                    }
                    if (ctr.AccessibleName == "StyleWhite")
                    {
                        ctr.BackColor = System.Drawing.Color.White;
                    }
                    if (ctr.AccessibleName == "StyleRosyBrown")
                    {
                        ctr.BackColor = System.Drawing.Color.RosyBrown;
                    }
                    if (ctr.AccessibleName == "StylePlum")
                    {
                        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(222)))), ((int)(((byte)(200)))));

                    }
                    if (ctr.AccessibleName == "StyleTransparent")
                    {
                        ctr.BackColor = System.Drawing.Color.Transparent; ;

                    }
                    
                }
                #endregion               
                #region Button Style
                if (ctr.GetType().Equals(typeof(Button)))
                {
                    if (ctr.AccessibleName == "SetStyle1")
                    {
                        ctr.Font = new System.Drawing.Font("Arial", 10F); 
                        ctr.BackColor = System.Drawing.Color.Maroon;
                        ctr.ForeColor = System.Drawing.Color.White;
                        ctr.Margin = new System.Windows.Forms.Padding(2);
                        //ctr.Size = new System.Drawing.Size(80, 28);
                    }
                    if (ctr.AccessibleName == "SetStyle2")
                    {
                        ctr.Font = new System.Drawing.Font("Arial", 10F); 
                        ctr.BackColor = System.Drawing.Color.BurlyWood;
                        ctr.ForeColor = System.Drawing.Color.Black;
                        ctr.Margin = new System.Windows.Forms.Padding(2);
                       // ctr.Size = new System.Drawing.Size(80, 28);
                    }
                    if (ctr.AccessibleName == "SetStyle3")
                    {
                        ctr.Font = new System.Drawing.Font("Arial", 10F); 
                        ctr.BackColor = System.Drawing.Color.DarkSeaGreen;
                        ctr.ForeColor = System.Drawing.Color.White;
                        ctr.Margin = new System.Windows.Forms.Padding(2);
                        // ctr.Size = new System.Drawing.Size(80, 28);
                    }
                    if (ctr.AccessibleName == "WhiteColor")
                    {
                        ctr.Font = new System.Drawing.Font("Arial", 10F);
                        ctr.BackColor = System.Drawing.Color.White;
                        ctr.ForeColor = System.Drawing.Color.Black;
                        ctr.Margin = new System.Windows.Forms.Padding(2);
                        // ctr.Size = new System.Drawing.Size(80, 28);
                    }
                }
                #endregion 
                #region ComboBox Style
                if (ctr.GetType().Equals(typeof(ComboBox)))
                {
                    ComboBox combo = ctr as ComboBox;

                    combo.DropDownStyle = ComboBoxStyle.DropDownList;
                    combo.AutoCompleteSource = AutoCompleteSource.ListItems;
                    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    
                    if (ctr.AccessibleName == "SetStyle1")
                    {
                        ctr.BackColor = System.Drawing.SystemColors.WindowFrame;
                        ctr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        ctr.ForeColor = System.Drawing.Color.Transparent;
                        ctr.Margin = new System.Windows.Forms.Padding(2);
                    }
                    if (ctr.AccessibleName == "SetStyle2")
                    {
                        ctr.BackColor = System.Drawing.Color.Teal;
                        ctr.ForeColor = System.Drawing.Color.White;
                        ctr.Margin = new System.Windows.Forms.Padding(2);
                        //ctr.Size = new System.Drawing.Size(80, 28);
                    }
                }
                #endregion 
                #region Datagridview Style 
                if (ctr.GetType().Equals(typeof(DataGridView)))
                {
                    if (ctr.AccessibleName == "SetStyle1")
                    {
                        DataGridView ctr1 = (DataGridView)ctr;
                        ctr1.AllowUserToAddRows = false;
                        ctr1.AllowUserToDeleteRows = false;
                        ctr1.AllowUserToOrderColumns = true;
                        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
                        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        ctr1.ColumnHeadersHeight = 60;
                        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
                        ctr1.GridColor = System.Drawing.Color.Black;
                        ctr1.MultiSelect = false;
                        ctr1.ReadOnly = true;
                        ctr1.RowHeadersVisible = false;
                        //ctr1.RowTemplate.ReadOnly = true;
                        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
                        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

                        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
                        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
                        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
                        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

                        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

                        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
                        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
                        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
                        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
                        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
                    }
                    if (ctr.AccessibleName == "WeekEndStyle")
                    {
                        DataGridView ctr1 = (DataGridView)ctr;
                        ctr1.AllowUserToAddRows = false;
                        ctr1.AllowUserToDeleteRows = false;
                        ctr1.AllowUserToOrderColumns = true;
                        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
                        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        ctr1.ColumnHeadersHeight = 60;
                        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
                        ctr1.GridColor = System.Drawing.Color.DarkCyan;
                        ctr1.MultiSelect = false;
                        ctr1.ReadOnly = false;
                        ctr1.RowHeadersVisible = false;
                        //ctr1.RowTemplate.ReadOnly = true;
                        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.SelectionMode = DataGridViewSelectionMode.CellSelect;

                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
                        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

                        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
                        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
                        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
                        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

                        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

                        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
                        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
                        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
                        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
                        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
                    }
                    if (ctr.AccessibleName == "SetStyle2")
                    {
                        DataGridView ctr1 = (DataGridView)ctr;
                        ctr1.AllowUserToAddRows = false;
                        ctr1.AllowUserToDeleteRows = false;
                        ctr1.AllowUserToOrderColumns = true;
                        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
                        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        ctr1.ColumnHeadersHeight = 100;
                        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
                        ctr1.GridColor = System.Drawing.Color.Black;
                        ctr1.MultiSelect = false;
                        ctr1.ReadOnly = false;
                        ctr1.RowHeadersVisible = false;
                        //ctr1.RowTemplate.ReadOnly = true;
                        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.SelectionMode = DataGridViewSelectionMode.CellSelect;

                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
                        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

                        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
                        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
                        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
                        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
                        //dataGridViewCellStyle1.hei
                        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

                        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
                        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

                        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
                        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
                        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
                        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
                        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
                    }
                    if (ctr.AccessibleName == "rowSelection1")
                    {
                        DataGridView ctr1 = (DataGridView)ctr;
                        ctr1.AllowUserToAddRows = false;
                        ctr1.AllowUserToDeleteRows = false;
                        ctr1.AllowUserToOrderColumns = true;
                        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
                        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        ctr1.ColumnHeadersHeight = 60;
                        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
                        ctr1.GridColor = System.Drawing.Color.Black;
                        ctr1.MultiSelect = false;
                        ctr1.ReadOnly = true;
                        ctr1.RowHeadersVisible = false;
                        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        ctr1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
                        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
                    }
                    if (ctr.AccessibleName == "rowSelection2")
                    {
                        DataGridView ctr1 = (DataGridView)ctr;
                        ctr1.AllowUserToAddRows = false;
                        ctr1.AllowUserToDeleteRows = false;
                        ctr1.AllowUserToOrderColumns = true;
                        ctr1.BackgroundColor = System.Drawing.Color.AliceBlue;
                        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        ctr1.ColumnHeadersHeight = 60;
                        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
                        ctr1.GridColor = System.Drawing.Color.Black;
                        ctr1.MultiSelect = false;
                        ctr1.ReadOnly = true;
                        ctr1.RowHeadersVisible = false;
                        //ctr1.RowTemplate.ReadOnly = true;
                        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
                        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        ctr1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
                        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
                        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
                    }
                    if (ctr.AccessibleName == "rowSelection1WithoutSort")
                    {
                        DataGridView ctr1 = (DataGridView)ctr;
                        ctr1.AllowUserToAddRows = false;
                        ctr1.AllowUserToDeleteRows = false;
                        ctr1.AllowUserToOrderColumns = true;
                        //ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
                        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        ctr1.ColumnHeadersHeight = 60;
                        //ctr1.Cursor = System.Windows.Forms.Cursors.Default;
                        //ctr1.GridColor = System.Drawing.Color.Black;
                        ctr1.MultiSelect = false;
                        ctr1.ReadOnly = true;
                        ctr1.RowHeadersVisible = false;
                        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        ctr1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkGreen;
                        //ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
                    }
                    if (ctr.AccessibleName == "CellSelection1")
                    {
                        DataGridView ctr1 = (DataGridView)ctr;
                        ctr1.AllowUserToAddRows = false;
                        ctr1.AllowUserToDeleteRows = false;
                        ctr1.AllowUserToOrderColumns = true;
                        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
                        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
                        ctr1.ColumnHeadersHeight = 60;
                        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
                        ctr1.GridColor = System.Drawing.Color.Black;
                        ctr1.MultiSelect = false;
                        //ctr1.ReadOnly = true;
                        ctr1.RowHeadersVisible = false;
                        //ctr1.RowTemplate.ReadOnly = true;
                        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
                        ctr1.SelectionMode = DataGridViewSelectionMode.CellSelect;
                        ctr1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
                        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
                        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
                    }
                   
                }
                #endregion                             
                #region Label Style
                if (ctr.GetType().Equals(typeof(Label)))
                {
                    ctr.ForeColor = System.Drawing.Color.Black;

                    if (ctr.AccessibleName == "GoldColor")
                    {
                        ctr.ForeColor = System.Drawing.Color.Gold;
                    }
                    if (ctr.AccessibleName == "MaroonColor")
                    {
                        ctr.ForeColor = System.Drawing.Color.Maroon;
                    }
                    if (ctr.AccessibleName == "LightSalmonColor")
                    {
                        ctr.ForeColor = System.Drawing.Color.LightSalmon;
                    }
                    if (ctr.AccessibleName == "WhiteColor")
                    {
                        ctr.ForeColor = System.Drawing.Color.White;
                    }
                    if (ctr.AccessibleName == "BlackColor")
                    {
                        ctr.ForeColor = System.Drawing.Color.Black;
                    }
                    if (ctr.AccessibleName == "heading")
                    {
                        ctr.ForeColor = System.Drawing.Color.White;
                        ctr.Size = new System.Drawing.Size(58, 22);
                    } 

                }
                #endregion                
                
                
                #region Children Style
                if (ctr.HasChildren)
                {
                    SetControlStyle(ctr);
                }
                #endregion
            }
            //#region GroupBox style
            //if (ctr.GetType().Equals(typeof(GroupBox)))
            //{
            //    if (ctr.AccessibleName != "NoStyle")
            //    {
            //        ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        ctr.ForeColor = System.Drawing.Color.Chartreuse;
            //    }


            //}
            //#endregion
            //#region RadioButton style
            //if (ctr.GetType().Equals(typeof(RadioButton)))
            //{
            //    if (ctr.AccessibleName != "NoStyle")
            //    {
            //        ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        ctr.ForeColor = System.Drawing.Color.White;
            //    }


            //}
            //#endregion
            //#region RadioButton style
            //if (ctr.GetType().Equals(typeof(CheckBox)))
            //{
            //    if (ctr.AccessibleName != "NoStyle")
            //    {
            //        ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        ctr.ForeColor = System.Drawing.Color.LightSalmon;
            //    }


            //}
            //#endregion
            //#region Panel Style
            //if (ctr.GetType().Equals(typeof(Panel)))
            //{
            //    ctr.BackColor = System.Drawing.Color.Black;
            //}
            //#endregion
            //#region Button Style
            //if (ctr.GetType().Equals(typeof(Button)))
            //{
            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        ctr.Font = new System.Drawing.Font("Arial", 10F); 
            //        ctr.BackColor = System.Drawing.Color.Maroon;
            //        ctr.ForeColor = System.Drawing.Color.White;
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //        //ctr.Size = new System.Drawing.Size(80, 28);
            //    }
            //    if (ctr.AccessibleName == "SetStyle2")
            //    {
            //        ctr.Font = new System.Drawing.Font("Arial", 10F); 
            //        ctr.BackColor = System.Drawing.Color.BurlyWood;
            //        ctr.ForeColor = System.Drawing.Color.Black;
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //       // ctr.Size = new System.Drawing.Size(80, 28);
            //    }
            //    if (ctr.AccessibleName == "SetStyle3")
            //    {
            //        ctr.Font = new System.Drawing.Font("Arial", 10F); 
            //        ctr.BackColor = System.Drawing.Color.DarkSeaGreen;
            //        ctr.ForeColor = System.Drawing.Color.White;
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //        // ctr.Size = new System.Drawing.Size(80, 28);
            //    }
            //}
            //#endregion 
            //#region ComboBox Style
            //if (ctr.GetType().Equals(typeof(ComboBox)))
            //{
            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        ctr.BackColor = System.Drawing.SystemColors.WindowFrame;
            //        ctr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        ctr.ForeColor = System.Drawing.Color.Transparent;
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //    }
            //    if (ctr.AccessibleName == "SetStyle2")
            //    {
            //        ctr.BackColor = System.Drawing.Color.Teal;
            //        ctr.ForeColor = System.Drawing.Color.White;
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //        //ctr.Size = new System.Drawing.Size(80, 28);
            //    }
            //}
            //#endregion 
            //#region Datagridview Style 
            //if (ctr.GetType().Equals(typeof(DataGridView)))
            //{
            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 60;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = true;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            //        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            //        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            //        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
            //        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            //        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

            //        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            //        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            //        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            //    }
            //    if (ctr.AccessibleName == "WeekEndStyle")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 60;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.DarkCyan;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = false;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            //        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            //        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            //        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
            //        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            //        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

            //        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            //        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            //        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            //        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            //    }
            //    if (ctr.AccessibleName == "SetStyle2")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 100;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = false;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            //        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            //        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            //        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
            //        //dataGridViewCellStyle1.hei
            //        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            //        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

            //        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            //        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            //        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            //    }
            //    if (ctr.AccessibleName == "DefaultStyle")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 60;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = true;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            //    }
            //    if (ctr.AccessibleName == "DefaultStyle2")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.AliceBlue;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 30;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = true;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkCyan;
            //        dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            //    }


            //}
            //#endregion                                            
            //#region Children Style
            //if (ctr.HasChildren)
            //{
            //    SetControlStyle(ctr);
            //}
            //#endregion
            //#region Label Style
            //if (ctr.GetType().Equals(typeof(Label)))
            //{
            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.Gold;
            //    }
            //    if (ctr.AccessibleName == "SetStyle2")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.LightSalmon;                       
            //    }
            //    if (ctr.AccessibleName == "SetStyle3")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.Turquoise;
            //    }
            //    if (ctr.AccessibleName != "SetStyle2" && ctr.AccessibleName != "SetStyle1" && ctr.AccessibleName != "SetStyle3")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.White;
            //    }

            //}
            //#endregion

















            //#region GroupBox style
            //if (ctr.GetType().Equals(typeof(GroupBox)))
            //{
            //    ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    ctr.ForeColor = System.Drawing.Color.DarkBlue;
            //    ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));

            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        ctr.ForeColor = System.Drawing.Color.White;
            //        ctr.BackColor = System.Drawing.Color.LightSlateGray;
            //    }
            //}
            //#endregion
            //#region RadioButton style
            //if (ctr.GetType().Equals(typeof(RadioButton)))
            //{
            //    ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    ctr.ForeColor = System.Drawing.Color.Black;

            //    if (ctr.AccessibleName == "NoStyle")
            //    {

            //    }
            //}
            //#endregion
            //#region CheckBox style
            //if (ctr.GetType().Equals(typeof(CheckBox)))
            //{
            //    ctr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    ctr.ForeColor = System.Drawing.Color.Black;

            //    if (ctr.AccessibleName == "NoStyle")
            //    {

            //    }
            //}
            //#endregion
            //#region Panel Style
            //if (ctr.GetType().Equals(typeof(Panel)))
            //{
            //    ctr.BackColor = System.Drawing.Color.LightSlateGray;
            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        ctr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(219)))), ((int)(((byte)(234)))));
            //    }
            //    if (ctr.AccessibleName == "StyleWhite")
            //    {
            //        ctr.BackColor = System.Drawing.Color.White;
            //    }
            //}
            //#endregion               
            //#region Button Style
            //if (ctr.GetType().Equals(typeof(Button)))
            //{
            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        ctr.Font = new System.Drawing.Font("Arial", 10F); 
            //        ctr.BackColor = System.Drawing.Color.SteelBlue;
            //        ctr.ForeColor = System.Drawing.Color.White;
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //        //ctr.Size = new System.Drawing.Size(75, 28);
            //    }
            //    if (ctr.AccessibleName == "SetStyle2")
            //    {
            //        ctr.Font = new System.Drawing.Font("Arial", 10F);
            //        ctr.BackColor = System.Drawing.Color.Teal;
            //        ctr.ForeColor = System.Drawing.Color.White;
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //        //ctr.Size = new System.Drawing.Size(75, 28);
            //    }
            //}
            //#endregion 
            //#region ComboBox Style
            //if (ctr.GetType().Equals(typeof(ComboBox)))
            //{
            //    ComboBox combo = ctr as ComboBox;

            //    combo.DropDownStyle = ComboBoxStyle.DropDownList;
            //    combo.AutoCompleteSource = AutoCompleteSource.ListItems;
            //    combo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        ctr.BackColor = System.Drawing.SystemColors.WindowFrame;
            //        ctr.ForeColor = System.Drawing.Color.Transparent;
            //        ctr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //    }
            //    if (ctr.AccessibleName == "SetStyle2")
            //    {
            //        ctr.BackColor = System.Drawing.Color.Teal;
            //        ctr.ForeColor = System.Drawing.Color.White;
            //        ctr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        ctr.Margin = new System.Windows.Forms.Padding(2);
            //        //ctr.Size = new System.Drawing.Size(80, 28);
            //    }
            //}
            //#endregion 
            //#region Datagridview Style 
            //if (ctr.GetType().Equals(typeof(DataGridView)))
            //{
            //    if (ctr.AccessibleName == "SetStyle1")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 60;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = true;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            //        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            //        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            //        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
            //        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            //        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

            //        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            //        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            //        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            //    }
            //    if (ctr.AccessibleName == "WeekEndStyle")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 60;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.DarkCyan;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = false;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            //        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            //        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            //        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
            //        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            //        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

            //        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGreen;
            //        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateBlue;
            //        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            //        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            //    }
            //    if (ctr.AccessibleName == "SetStyle2")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 100;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = false;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.CellSelect;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            //        DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();

            //        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle1.BackColor = System.Drawing.Color.Crimson;
            //        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BlueViolet;
            //        dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            //        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.NotSet;
            //        //dataGridViewCellStyle1.hei
            //        ctr1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;

            //        dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            //        dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;

            //        dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon;
            //        dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            //        dataGridViewCellStyle3.BackColor = System.Drawing.Color.Beige;
            //        dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            //    }
            //    if (ctr.AccessibleName == "rowSelection1")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 60;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = true;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //        ctr1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            //    }
            //    if (ctr.AccessibleName == "CellSelection1")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.DarkGray;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 60;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        //ctr1.ReadOnly = true;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            //        ctr1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Purple;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            //    }
            //    if (ctr.AccessibleName == "DefaultStyle2")
            //    {
            //        DataGridView ctr1 = (DataGridView)ctr;
            //        ctr1.AllowUserToAddRows = false;
            //        ctr1.AllowUserToDeleteRows = false;
            //        ctr1.AllowUserToOrderColumns = true;
            //        ctr1.BackgroundColor = System.Drawing.Color.AliceBlue;
            //        ctr1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            //        ctr1.ColumnHeadersHeight = 30;
            //        ctr1.Cursor = System.Windows.Forms.Cursors.Default;
            //        ctr1.GridColor = System.Drawing.Color.Black;
            //        ctr1.MultiSelect = false;
            //        ctr1.ReadOnly = true;
            //        ctr1.RowHeadersVisible = false;
            //        //ctr1.RowTemplate.ReadOnly = true;
            //        ctr1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //        ctr1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //        ctr1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            //        dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            //        dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //        dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            //        ctr1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            //    }


            //}
            //#endregion                             
            //#region Label Style
            //if (ctr.GetType().Equals(typeof(Label)))
            //{
            //    ctr.ForeColor = System.Drawing.Color.Black;

            //    if (ctr.AccessibleName == "GoldColor")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.Gold;
            //    }
            //    if (ctr.AccessibleName == "MaroonColor")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.Maroon;
            //    }
            //    if (ctr.AccessibleName == "LightSalmonColor")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.LightSalmon;
            //    }
            //    if (ctr.AccessibleName == "WhiteColor")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.White;
            //    }
            //    if (ctr.AccessibleName == "heading")
            //    {
            //        ctr.ForeColor = System.Drawing.Color.White;
            //        ctr.Size = new System.Drawing.Size(58, 22);
            //    } 

            //}
            //#endregion                

        }
        #endregion

        #region control clear

        public  void ClearControl(Control ParentControl)
        {
            foreach (Control ctr in ParentControl.Controls)
            {
                #region TextBox
                if (ctr.GetType().Equals(typeof(TextBox)))
                {
                    ctr.Text = "";
                }
                #endregion
                #region Combo Box
                if (ctr.GetType().Equals(typeof(ComboBox)))
                {
                    ComboBox ctr1 = (ComboBox)ctr;
                    if (ctr1.Items.Count > 0)
                    {
                        //ctr1.SelectedIndex = 0;
                    }
                }
                #endregion             
                #region Children Style
                if (ctr.HasChildren)
                {
                    ClearControl(ctr);
                }
                #endregion

            }
        }

        #endregion 
      
        #region Excel Export

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
        public void ExcelExport(DataGridView dataGridView1, SaveFileDialog saveFileDialog1, string Heading, string SubHeading)
        {
            try
            {
                Excel.Range rg = null;
                Excel.Application xlApp;
                Excel.Workbook xlWorkBook;
                Excel.Worksheet xlWorkSheet;
                object misValue = System.Reflection.Missing.Value;

                xlApp = new Excel.ApplicationClass();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                xlWorkSheet.Cells[2, 6] = Heading;
                xlWorkSheet.Cells[3, 6] = SubHeading;


                for (j = 1; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[6, j] = dataGridView1.Columns[j].HeaderText;
                    rg = (Excel.Range)xlWorkSheet.Cells[6, j];
                    rg.Cells.ColumnWidth = (dataGridView1.Columns[j].Width)/10 +4;
                    rg.Cells.WrapText = true;
                }


                for (i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    for (j = 1; j <= dataGridView1.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = dataGridView1[j, i];
                        xlWorkSheet.Cells[i + 7, j] = cell.Value;
                        rg = (Excel.Range)xlWorkSheet.Cells[i + 7, j];
                        rg.Cells.WrapText = true;
                    }
                }

                #region Excel Style formating
                //formate excel file cell header style
                rg = (Excel.Range)xlWorkSheet.Rows[6, Type.Missing];
                rg.HorizontalAlignment = Excel.Constants.xlCenter;
                rg.Font.Name = "Aerial";
                rg.Font.Size = 10;
                rg.WrapText = true;
                rg.Font.Bold = true;

                //formate excel Heading Style
                rg = (Excel.Range)xlWorkSheet.Cells[2, 6];
                rg.Font.Bold = true;
                rg.Font.Size = 15;

                //formate excel sub Heading Style
                rg = (Excel.Range)xlWorkSheet.Cells[3, 6];
                rg.Font.Size = 12;



                //formate excel file cell header width
                //rg = (Excel.Range)xlWorkSheet.Cells[6, 1];
                //rg.Cells.ColumnWidth = 25;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 2];
                //rg.Cells.ColumnWidth = 11;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 3];
                //rg.Cells.ColumnWidth = 11;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 4];
                //rg.Cells.ColumnWidth = 8;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 5];
                //rg.Cells.ColumnWidth = 10;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 6];
                //rg.Cells.ColumnWidth = 8;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 7];
                //rg.Cells.ColumnWidth = 13;
                //rg = (Excel.Range)xlWorkSheet.Cells[6, 8];
                //rg.Cells.ColumnWidth = 8;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 9];
                //rg.Cells.ColumnWidth = 12;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 10];
                //rg.Cells.ColumnWidth = 9;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 11];
                //rg.Cells.ColumnWidth = 10;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 12];
                //rg.Cells.ColumnWidth = 13;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 13];
                //rg.Cells.ColumnWidth = 11;

                //rg = (Excel.Range)xlWorkSheet.Cells[6, 14];
                //rg.Cells.ColumnWidth = 20;
                //rg.HorizontalAlignment = HorizontalAlignment.Right;


                #endregion

                DialogResult result = saveFileDialog1.ShowDialog();

                if (result.Equals(DialogResult.OK))
                {

                    xlWorkBook.SaveAs(saveFileDialog1.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    releaseObject(xlWorkSheet);
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);

                    MessageBox.Show("Excel file created , you can find the file " + saveFileDialog1.FileName);//c:\\csharp.net-informations.xls");
                }
            }
            catch
            { }
        }
        public void Clearcontrol(Form form1)
        {
            form1.Controls.OfType<TextBox>().ToList().ForEach(row => row.Text = "");

        }

        #endregion
    }
}




      
                