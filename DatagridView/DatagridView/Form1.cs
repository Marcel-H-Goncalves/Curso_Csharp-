using System.Data;
namespace DatagridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));

            DataRow linha1 = dt.NewRow();
            linha1["Id"] = 1;
            linha1["Nome"] = "Marcel";
            dt.Rows.Add(linha1);

            DataRow linha2 = dt.NewRow();
            linha2["Id"] = 2;
            linha2["Nome"] = "Regilaine";
            dt.Rows.Add(linha2);

            DataRow linha3 = dt.NewRow();
            linha3["Id"] = 3;
            linha3["Nome"] = "Yasmin";
            dt.Rows.Add(linha3);

            dataGridView1.DataSource = dt;


        }
    }
}
