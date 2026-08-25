using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ERP_EntityFramework_UI.Functions
{
    public static class Generic
    {
        public static T GetSelected<T>(GridView gridView) where T : class
        {
            return gridView.GetFocusedRow() as T;
        }

        public static void DeleteSelected<T>(GridView gridView, Action<T> deleteAction) where T : class
        {
            int[] selectedRows = gridView.GetSelectedRows();

            if (selectedRows.Length == 0) return;

            gridView.BeginUpdate();

            try
            {
                foreach (int rowHandle in selectedRows.OrderByDescending(x => x))
                {
                    T entity = gridView.GetRow(rowHandle) as T;

                    if (entity == null) continue;

                    deleteAction(entity);
                }
            }
            finally
            {
                gridView.EndUpdate();
            }
        }

        public static void ExportToFile(GridView gv, string filter)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = filter;
                saveDialog.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss");

                if (saveDialog.ShowDialog() != DialogResult.OK) return;

                string fileName = saveDialog.FileName;

                switch (filter)
                {
                    case "Excel Dosyaları|*.xlsx":
                        gv.ExportToXlsx(fileName);
                        break;

                    case "PDF Dosyaları|*.pdf":
                        gv.ExportToPdf(fileName);
                        break;

                    case "HTML Dosyaları|*.html":
                        gv.ExportToHtml(fileName);
                        break;
                }
            }
        }

        public static void Print(GridView gridView)
        {
            gridView.ShowRibbonPrintPreview();
        }

        private static void FocusRow(GridView gv, int rowHandle)
        {
            gv.FocusedRowHandle = rowHandle;
            gv.SelectRow(rowHandle);
            gv.MakeRowVisible(rowHandle);
        }

        public static void GetFirstRow(this GridView gv)
        {
            if (gv.RowCount == 0) return;

            FocusRow(gv, 0);
        }

        public static void GetMiddleRow(this GridView gv)
        {
            if (gv.RowCount == 0) return;

            FocusRow(gv, gv.RowCount / 2);
        }

        public static void GetLastRow(this GridView gv)
        {
            if (gv.RowCount == 0) return;

            FocusRow(gv, gv.RowCount - 1);
        }

        public static void GetNextRow(this GridView gv)
        {
            if (gv.RowCount == 0) return;

            int nextRow = gv.FocusedRowHandle + 1;

            if (nextRow < gv.RowCount) FocusRow(gv, nextRow);
        }

        public static void GetPreviousRow(this GridView gv)
        {
            if (gv.RowCount == 0) return;

            int previousRow = gv.FocusedRowHandle - 1;

            if (previousRow >= 0) FocusRow(gv, previousRow);
        }
    }
}
