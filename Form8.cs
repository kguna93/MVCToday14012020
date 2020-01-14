using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpodS
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            this.richTextBox1.SelectionStart = 0;
            this.richTextBox1.SelectionLength = this.richTextBox1.Text.Length;
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, FontStyle.Underline);
            this.richTextBox1.SelectionLength = 0;
            string path = "C:\\UPOD 3D Full Foot Scan\\Bin\\UPOD_TEMP";
            DataTable dataTable1 = CsvFileReader1.DataTableFromTextFile(path, '\t');
            DataTable dataTable2 = CsvFileReader2.DataTableFromTextFile(path, '\t');
            measurementsDatagridview.DataSource = dataTable1;
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
            timer1.Stop();
        }

        public class CsvFileReader1
        {
            public static DataTable DataTableFromTextFile(string location, char delimiter = '\t')
            {
                DataTable result = new DataTable();
                try
                {
                    foreach (string file in Directory.EnumerateFiles(location, "*.csv"))
                    {
                        //string contents = File.ReadAllText(file);
                        string[] lineArray = File.ReadAllLines(file);
                        result = FormDataTable(lineArray, delimiter);
                    }
                    return result;
                }
                catch (Exception cv)
                {
                    Console.WriteLine(cv);
                    return result;
                }

            }

            private static DataTable FormDataTable(string[] lineArray, char delimiter)
            {
                DataTable dataTable = new DataTable();
                try
                {
                    int index = AddColumnToTable(lineArray, delimiter, ref dataTable);
                    AddRowToTable(lineArray, delimiter, ref dataTable, index);
                    return dataTable;
                }
                catch (Exception csv)
                {
                    Console.WriteLine(csv);
                    return dataTable;
                }
            }

            //Reads all the measurements from the .csv file and assigns to a data table
            private static void AddRowToTable(string[] valueCollection, char delimiter, ref DataTable dataTable, int index)
            {
                try
                {
                    //Length Measurements
                    DataRow dataRow0 = dataTable.NewRow();
                    dataRow0[0] = "LEFT FOOT";
                    dataRow0[1] = "LENGTH MEASUREMENTS";
                    dataRow0[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow0);
                    for (int i = index; i < 70; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Width Measurements
                    DataRow dataRow1 = dataTable.NewRow();
                    dataRow1[0] = "LEFT FOOT";
                    dataRow1[1] = "WIDTH MEASUREMENTS";
                    dataRow1[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow1);
                    for (int i = 72; i < 82; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Height Measurements
                    DataRow dataRow2 = dataTable.NewRow();
                    dataRow2[0] = "LEFT FOOT";
                    dataRow2[1] = "HEIGHT MEASUREMENTS";
                    dataRow2[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow2);
                    for (int i = 84; i < 94; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                }
                catch (Exception rw)
                {
                    Console.WriteLine(rw);
                }

            }

            // To add columns to the data table
            private static int AddColumnToTable(string[] columnCollection, char delimiter, ref DataTable dataTable)
            {
                try
                {
                    DataColumn dataColumn = new DataColumn("MEASUREMENTS", typeof(string));
                    dataTable.Columns.Add(dataColumn);
                    DataColumn dataColumn1 = new DataColumn("--------------", typeof(string));
                    dataTable.Columns.Add(dataColumn1);
                    DataColumn dataColumn2 = new DataColumn("MM", typeof(string));
                    dataTable.Columns.Add(dataColumn2);
                    return 57;
                }
                catch (Exception cn)
                {
                    Console.WriteLine(cn);
                    return 57;
                }
            }
        }

        public class CsvFileReader2
        {
            public static DataTable DataTableFromTextFile(string location, char delimiter = '\t')
            {
                DataTable result = new DataTable();
                try
                {
                    foreach (string file in Directory.EnumerateFiles(location, "*.csv"))
                    {
                        //string contents = File.ReadAllText(file);
                        string[] lineArray = File.ReadAllLines(file);
                        result = FormDataTable(lineArray, delimiter);
                    }
                    return result;
                }
                catch (Exception cv)
                {
                    Console.WriteLine(cv);
                    return result;
                }
            }

            private static DataTable FormDataTable(string[] lineArray, char delimiter)
            {
                DataTable dataTable = new DataTable();
                try
                {
                    int index = AddColumnToTable(lineArray, delimiter, ref dataTable);
                    AddRowToTable(lineArray, delimiter, ref dataTable, index);
                    return dataTable;
                }
                catch (Exception csv)
                {
                    Console.WriteLine(csv);
                    return dataTable;
                }
            }

            //Reads all the measurements from the .csv file and assigns to a data table
            private static void AddRowToTable(string[] valueCollection, char delimiter, ref DataTable dataTable, int index)
            {
                try
                {
                    //Angle Measurements
                    DataRow dataRow3 = dataTable.NewRow();
                    dataRow3[0] = "LEFT FOOT";
                    dataRow3[1] = "ANGLE MEASUREMENTS";
                    dataRow3[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow3);
                    for (int i = 96; i < 99; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Girth Measurements
                    DataRow dataRow4 = dataTable.NewRow();
                    dataRow4[0] = "LEFT FOOT";
                    dataRow4[1] = "GIRTH MEASUREMENTS";
                    dataRow4[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow4);
                    for (int i = 101; i < 107; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Shoe Size
                    DataRow dataRow5 = dataTable.NewRow();
                    dataRow5[0] = "LEFT FOOT";
                    dataRow5[1] = "SHOE SIZE";
                    dataRow5[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow5);
                    for (int i = 109; i < 110; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Arch Height
                    DataRow dataRow6 = dataTable.NewRow();
                    dataRow6[0] = "LEFT FOOT";
                    dataRow6[1] = "ARCH HEIGHT";
                    dataRow6[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow6);
                    for (int i = 112; i < 115; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Arch index
                    DataRow dataRow7 = dataTable.NewRow();
                    dataRow7[0] = "LEFT FOOT";
                    dataRow7[1] = "ARCH INDEX";
                    dataRow7[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow7);
                    for (int i = 117; i < 119; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Hallux Angle
                    DataRow dataRow8 = dataTable.NewRow();
                    dataRow8[0] = "LEFT FOOT";
                    dataRow8[1] = "HALLUX ANGLE";
                    dataRow8[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow8);
                    for (int i = 121; i < 123; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Heel Angle
                    DataRow dataRow9 = dataTable.NewRow();
                    dataRow9[0] = "LEFT FOOT";
                    dataRow9[1] = "HEEL ANGLE";
                    dataRow9[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow9);
                    for (int i = 125; i < 126; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Malleolar Valgus Index
                    DataRow dataRow10 = dataTable.NewRow();
                    dataRow10[0] = "LEFT FOOT";
                    dataRow10[1] = "MALLEOLAR VALGUS INDEX";
                    dataRow10[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow10);
                    for (int i = 128; i < 129; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Longitudinal Arch Angle
                    DataRow dataRow11 = dataTable.NewRow();
                    dataRow11[0] = "LEFT FOOT";
                    dataRow11[1] = "LONGITUDINAL ARCH ANGLE";
                    dataRow11[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow11);
                    for (int i = 131; i < 133; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                    //Toe Type
                    DataRow dataRow12 = dataTable.NewRow();
                    dataRow12[0] = "LEFT FOOT";
                    dataRow12[1] = "TOE TYPE";
                    dataRow12[2] = "RIGHT FOOT";
                    dataTable.Rows.Add(dataRow12);
                    for (int i = 134; i < 135; i++)
                    {
                        string[] values = valueCollection[i].Split(delimiter);
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = values[1];
                        dataRow[1] = values[0];
                        dataRow[2] = values[2];
                        dataTable.Rows.Add(dataRow);
                    }
                }
                catch (Exception rw)
                {
                    Console.WriteLine(rw);
                }
            }

            //To add columns to the data table
            private static int AddColumnToTable(string[] columnCollection, char delimiter, ref DataTable dataTable)
            {
                try
                {
                    DataColumn dataColumn = new DataColumn("", typeof(string));
                    dataTable.Columns.Add(dataColumn);
                    DataColumn dataColumn1 = new DataColumn("", typeof(string));
                    dataTable.Columns.Add(dataColumn1);
                    DataColumn dataColumn2 = new DataColumn("", typeof(string));
                    dataTable.Columns.Add(dataColumn2);
                    return 109;
                }
                catch (Exception cn)
                {
                    Console.WriteLine(cn);
                    return 109;
                }
            }
        }

        private void Measurements_Click(object sender, EventArgs e)
        {
            string path = "C:\\UPOD 3D Full Foot Scan\\Bin\\UPOD_TEMP";
            DataTable dataTable1 = CsvFileReader1.DataTableFromTextFile(path, '\t');
            DataTable dataTable2 = CsvFileReader2.DataTableFromTextFile(path, '\t');
            measurementsDatagridview.DataSource = dataTable1;
        }

        private void Analysis_Click(object sender, EventArgs e)
        {
            string path = "C:\\UPOD 3D Full Foot Scan\\Bin\\UPOD_TEMP";
            DataTable dataTable1 = CsvFileReader1.DataTableFromTextFile(path, '\t');
            DataTable dataTable2 = CsvFileReader2.DataTableFromTextFile(path, '\t');
            measurementsDatagridview.DataSource = dataTable2;
        }
    }
}
