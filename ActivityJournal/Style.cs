using System.Drawing;
using System.Windows.Forms;

namespace ActivityJournal
{
    class Style
    {
        // styling of the datagrid
        public void styleDataGrid(DataGridView dataGrid)
        {
            // main stuff
            dataGrid.BackgroundColor = Color.FromArgb(24,24,24);
            dataGrid.BorderStyle = BorderStyle.None;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGrid.ColumnHeadersHeight = 30;
            // alternating
            dataGrid.AlternatingRowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(17, 17, 17);
            dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            // default
            dataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dataGrid.RowsDefaultCellStyle.ForeColor = Color.White;
            //dataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(254, 178, 0);
            dataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(17, 17, 17);
            // header
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 24, 24);
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(24, 24, 24);
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12);
            // default cell style
            dataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGrid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
        }
    }
}
