using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormProject
{
    internal class DataStream
    {
        // fields
        readonly string directory = @".\Files\";
        private string fileName;
        private string msgBoxTitle;
        private string output;
        private string description;
        private string ext = ".txt";

        // constructors
        public DataStream()
        {

        }

        public DataStream(string fileName, string msgBoxTitle, string output, string description)
        {
            FileName = fileName;
            MsgBoxTitle = msgBoxTitle;
            Output = output;
            Description = description;
        }

        // property
        public string FileName
        {
            get 
            {
                if (fileName == "BinaryIpv4")
                {
                    ext = ".dat";
                }

                return fileName + ext;
            }
            set { fileName = value; }
        }

        public string MsgBoxTitle
        {
            get { return msgBoxTitle + " Results by Bernadette"; }
            set { msgBoxTitle = value; }
        }

        public string Output
        {
            get { return output; }
            set { output = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        // methods
        // function to check and create directory
        public void CreateDir ()
        {
            if(!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        // function write to file
        public void WriteFile()
        {
            FileStream fs = null;
            string path = directory + FileName;

            // verifyiung if the file path exists
            try
            {
                fs = new FileStream(path, FileMode.Open);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show($"Directory: {directory} not found.\nCreating...", "Directory not existing.");
                CreateDir();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"{FileName} not found.\nCreating...", "New File Created");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error! {ex.Message}", "Exception IO");

            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }


            // create the output stream for a text file that exists
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter textFile = new StreamWriter(fs);

            // building each row of text file
            textFile.WriteLine($"{Output},  {DateTime.Now:yyyy'/'MM'/'dd HH:mm:ss tt}{Description}");

            MessageBox.Show($"Saved Changes to {FileName}!", "Saved");

            textFile.Close();
            fs.Close();
        }


        // function to read file
        public void ReadFile()
        {
            FileStream fs = null;
            string path = directory + FileName;

            // verifyiung if the file path exists
            try
            {
                fs = new FileStream(path, FileMode.Open);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show($"Directory: {directory} not found.\nCreating...", "Directory not existing.");
                CreateDir();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"{FileName} not found.\nCreating...", "New File Created");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error! {ex.Message}", "Exception IO");

            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            // create the object for the input stream for a text file
            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader textFile = new StreamReader(fs);

            // reading each row of text file
            string line = "";
            while (textFile.Peek() != -1)
            {
                line += textFile.ReadLine() + "\n";
            }

            // check if file is empty
            if (line == "")
            {
                MessageBox.Show("File Empty.", MsgBoxTitle);
            }
            else
            {
                MessageBox.Show(line, MsgBoxTitle);
                
            }

            textFile.Close();
            fs.Close();
        }

        // function write to calculator file
        public void WriteCalcFile()
        {
            FileName = "Calculator";
            FileStream fs = null;
            string path = directory + FileName;

            // verifyiung if the file path exists
            try
            {
                fs = new FileStream(path, FileMode.Open);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show($"Directory: {directory} not found.\nCreating...", "Directory not existing.");
                CreateDir();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"{FileName} not found.\nCreating...", "New File Created");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error! {ex.Message}", "Exception IO");

            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }


            // create the output stream for a text file that exists
            fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter textFile = new StreamWriter(fs);

            // building each row of text file
            textFile.WriteLine($"{Output}");

            textFile.Close();
            fs.Close();
        }

        // function write to binary
        public void WriteBinFile ()
        {
            FileStream fs = null;
            string path = directory + FileName;

            // verifyiung if the file path exists
            try
            {
                fs = new FileStream(path, FileMode.Open);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show($"Directory: {directory} not found.\nCreating...", "Directory not existing.");
                CreateDir();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"{FileName} not found.\nCreating...", "New File Created");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Error! {ex.Message}", "Exception IO");

            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }

            fs = new FileStream(path, FileMode.Append, FileAccess.Write);

            BinaryWriter binFile = new BinaryWriter(fs);
            Output += DateTime.Now.ToString();
            string[] output = Regex.Split(Output, "\\.?\\s?\\-?\\:?[B-L]?[NO]?[Q-Z]?");

            foreach (string item in output)
            {
                binFile.Write($"{item}");
            }

            MessageBox.Show($"Saved Changes to {FileName}!", "Saved");

            binFile.Close();
        }

    }
}
