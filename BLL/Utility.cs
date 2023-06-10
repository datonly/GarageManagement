using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public static class Utility
    {
        #region ValidateSupport
        public static string Validate(this object obj)
        {
            StringBuilder sb = new StringBuilder();
            ValidationContext context = new ValidationContext(obj, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();
            if (!Validator.TryValidateObject(obj, context, errors, true))
            {
                foreach (ValidationResult vr in errors)
                {
                    sb.AppendLine(vr.ErrorMessage);
                }
            }
            return sb.ToString();
        }
        #endregion
        public static string GetMD5(this string str)
        {
            MD5 md5 = MD5.Create();
            byte[] fromData = Encoding.ASCII.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < targetData.Length; i++)
            {
                sb.Append(targetData[i].ToString("x2"));
            }
            return sb.ToString();
        }
        #region XuLyGUI
        // Dinh dang DGV
        public static void FormatTable(this DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;

            dgv.BorderStyle = BorderStyle.None;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToResizeRows = false;

            dgv.GridColor = Color.Gainsboro;
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.DefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightPink;
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Cambria", 12);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public static SortableBindingList<T> ToSortableBindingList<T>(this IEnumerable<T> list)
        {
            return new SortableBindingList<T>(list);
        }
        #endregion
    }
}
