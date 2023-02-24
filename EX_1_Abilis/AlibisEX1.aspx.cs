using System;
using System.Drawing;
using System.Web.UI.WebControls;

namespace EX_1_Abilis
{
    public partial class AlibisEX1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate the matrix size dropdownlist
                for (int i = 3; i <= 15; i++)
                {
                    ddlMatrixSize.Items.Add(i.ToString());
                }
                ddlMatrixSize.SelectedValue = "10";

                // Generate the multiplication table
                GenerateMultiplicationTable();
            }
        }

        protected void ddlMatrixSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateMultiplicationTable();
        }

        protected void rblMatrixBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateMultiplicationTable();
        }

        private void GenerateMultiplicationTable()
        {
            int matrixSize = int.Parse(ddlMatrixSize.SelectedValue);
            string matrixBase = rblMatrixBase.SelectedValue;

            tblMultiplicationTable.Rows.Clear();

            for (int i = 1; i <= matrixSize; i++)
            {
                TableRow row = new TableRow();
                for (int j = 1; j <= matrixSize; j++)
                {
                    TableCell cell = new TableCell();
                    int value = i * j;
                    string formattedValue = FormatValue(value, matrixBase);
                    cell.Text = formattedValue;
                    cell.ToolTip = $"{i} X {j} = {value}";
                    if (IsPrime(value))
                    {
                        cell.BackColor = Color.Yellow;
                    }
                    row.Cells.Add(cell);
                }
                tblMultiplicationTable.Rows.Add(row);
            }
        }

        private string FormatValue(int value, string matrixBase)
        {
            switch (matrixBase)
            {
                case "decimal":
                    return value.ToString();
                case "binary":
                    return Convert.ToString(value, 2);
                case "hex":
                    return Convert.ToString(value, 16);
                default:
                    return value.ToString();
            }
        }

        private bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
