using Registration.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Registration
{
    public class Filler
    {
        public void Fill(DataGridView table)
        {
           // Data data = GetData();

            table.Rows.Clear();
            table.Columns.Clear();

            CreateColumns(table);
            FillRows(table);
            table.ReadOnly = true;
        }
        private void FillRows(DataGridView table)
        {
            var context = new AppEFContext();
            foreach (var user in context.Users)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 200;
                
                row.CreateCells(table);

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    row.Cells[i].Style.BackColor = Color.Black;
                    if (i == row.Cells.Count-1)
                    {
                        //if (items[i] == null || items[i].GetType() == typeof(System.DBNull))
                        //    continue;
                        WebClient w = new WebClient();
                        byte[] imageByte = w.DownloadData(user.PhotoUrl);
                        MemoryStream stream = new MemoryStream(imageByte);
                        //Bitmap bitmap = new Bitmap(Image.FromStream(stream),new Size(200,200));
                        row.Cells[i].Value = Image.FromStream(stream);//(Image)bitmap;
                       

                        continue;//Bitmap.FromStream(user.PhotoUrl);//
                    }
                    switch(i)
                    {
                        case 0:
                            row.Cells[i].Value = user.Id;
                            break;
                        case 1:
                            row.Cells[i].Value = user.Nickname;
                            break;
                        case 2:
                            row.Cells[i].Value = user.Password;
                            break;
                    }    
                  
                }

                table.Rows.Add(row);
            }
        }
        DataGridViewColumn GetColumn(string text, bool isImage)
        {
            DataGridViewColumn column;
            
            if (isImage)
            {
                DataGridViewImageColumn dgv = new DataGridViewImageColumn();
                dgv.ImageLayout = DataGridViewImageCellLayout.Zoom;
                column = dgv;
                column.Width = 300;
            }
               
            else
                column = new DataGridViewTextBoxColumn();
            column.HeaderText = column.Name = text;
           return column;
        }
        private void CreateColumns(DataGridView table)
        {
            table.Columns.Add(GetColumn("Id",false));
            table.Columns.Add(GetColumn("Nickname", false));
            table.Columns.Add(GetColumn("Password", false));
            table.Columns.Add(GetColumn("Photo", true));


            //var context = new AppEFContext();
            //for (int i = 0; i < context.Users i++)
            //{
            //    DataGridViewColumn column;
            //    if (data.ColumnsTypes[i] == typeof(byte[]))
            //    {
            //        column = new DataGridViewImageColumn();
            //    }
            //    else
            //    {
            //        column = new DataGridViewTextBoxColumn();
            //    }
            //    column.HeaderText = column.Name = data.ColumnsNames[i];
            //    column.ValueType = data.ColumnsTypes[i];

            //    table.Columns.Add(column);
            //}
        }


    }
}
