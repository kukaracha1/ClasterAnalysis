using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccidentForecast
{

    public partial class ImportFromExcelUI : Form
    {
        public string fileName=null;
        public string listName=null;
        public ImportFromExcelUI()
        {
            InitializeComponent();
        }

                private void ChooseFile_Dialog_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Файлы Excel (*.xls; *.xlsx; *.xlsm) | *.xls; *.xlsx; *.xlsm; |Все файлы (*.*)|*.*";
                //openFileDialog.InitialDirectory = "<путь к папке>";//если нужно

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
            }
            nameFile_text.Text = fileName;


        }
        BackgroundWorker bw;
        private async void ImportData_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(i.ToString());
            }
                var progress = new Progress<ProgressReport>();
                progress.ProgressChanged += (o, report) =>
                {
                    progressBar.Value = report.PercentComplete;
                    progressBar.Update();
                };
                

            listName = Promt.ShowDialog("Введите имя Листа", "Имя Листа в файле Excel");
            //   nameFile_text.Text = listName;
            //  progressBar.Visible = true;
            await ProcessData(list, progress);
            ImportData.Enabled = false;
            if (Weather_radio.Checked)
            {                
                ImportExcel.LoadExcelFactors(listName, fileName);           
            }
            else if(Accident_radio.Checked)
            {
                ImportExcel.LoadExcelAccident(listName, fileName);
            }
            else if (Fires_radio.Checked)
            {
                ImportExcel.LoadExcelFires(listName, fileName);
            }
            else if (HaCS_radio.Checked)
            {
                ImportExcel.LoadExcelHaCS(listName, fileName);
            }
            ImportData.Enabled = true;
        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
            });
        }

    }

    public class ProgressReport
    {
        public int PercentComplete { get; set; }
    }
}