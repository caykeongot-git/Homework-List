using System.Drawing;
using System.Windows.Forms;

namespace Hotel.GUI
{
    // Class này chứa các hàm trang trí giao diện dùng chung cho cả App
    public static class GUIHelper
    {
        public static void DecorateDataGridView(DataGridView dgv)
        {
            // Các cài đặt cơ bản
            dgv.BorderStyle = BorderStyle.None;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.SeaGreen; // Màu khi chọn
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;

            // Chỉnh Header (Tiêu đề)
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72); // Màu nền Header
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 40;

            // Cấu hình dòng và cột
            dgv.RowTemplate.Height = 30;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Tự co giãn cột
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // Chọn cả dòng
        }
    }
}