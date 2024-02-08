using RegistrationWebRequestNew.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationWebRequestNew
{
    public class Filler
    {

        public void Fill(DataGridView table, List<RegisterUserDTO> users)
        {
            // Data data = GetData();

            table.Rows.Clear();
            table.Columns.Clear();

            CreateColumns(table);
            FillRows(table, users);
           

        }
        private void FillRows(DataGridView table, List<RegisterUserDTO> users)
        {
            //var context = new AppEFContext();
            foreach (var user in users)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Height = 125;

                row.CreateCells(table);

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    row.Cells[i].Style.BackColor = Color.Black;
                    //if (table.Columns[i].HeaderText == "Photo")
                    //{

                    //    WebClient w = new WebClient();
                    //    byte[] imageByte = w.DownloadData(user.PhotoUrl);
                    //    MemoryStream stream = new MemoryStream(imageByte);
                    //    row.Cells[i].Value = Image.FromStream(stream);




                    //    continue;//Bitmap.FromStream(user.PhotoUrl);//
                    //}
                    switch (table.Columns[i].HeaderText)
                    {
                        case "Email":
                            row.Cells[i].Value = user.Email;
                            break;
                        case "FirstName":
                            row.Cells[i].Value = user.FirstName;
                            break;
                        case "SecondName":
                            row.Cells[i].Value = user.SecondName;
                            break;
                        case "Photo":
                            WebClient w = new WebClient();
                            byte[] imageByte = w.DownloadData($"https://pv113.itstep.click{user.Photo}");
                            MemoryStream stream = new MemoryStream(imageByte);
                            row.Cells[i].Value = Image.FromStream(stream);
                            break;
                        case "Phone":
                            row.Cells[i].Value = user.Phone;
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
            table.Columns.Add(GetColumn("Email", false));
            table.Columns.Add(GetColumn("FirstName", false));
            table.Columns.Add(GetColumn("SecondName", false));
            table.Columns.Add(GetColumn("Photo", true));
            table.Columns.Add(GetColumn("Phone", false));



        }
    }
}
