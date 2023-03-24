using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        private string formTitle;
        private string output;
        private string description;

        // constructors
        public DataStream()
        {

        }

        public DataStream(string fileName, string formTitle, string output, string description)
        {
            FileName = fileName;
            FormTitle = formTitle;
            Output = output;
            Description = description;
        }

        // property
        public string FileName
        {
            get { return fileName + ".txt"; }
            set { fileName = value; }
        }

        public string FormTitle
        {
            get { return formTitle + " Results by Bernadette"; }
            set { formTitle = value; }
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
            catch (FileNotFoundException)
            {
                MessageBox.Show(fileName + " not found.\nCreating...", "New File Created");
                File.Create(path).Close();
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(directory + " not found.", "Directory not existing.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error! " + ex.Message, "Exception IO");
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
            textFile.WriteLine($"{Output}, {DateTime.Now,5:yyyy'/'MM'/'dd HH:mm:ss tt}, {Description}");

            MessageBox.Show($"Saved Changes to {fileName}!", "Saved");

            textFile.Close();
            fs.Close();
        }


        // function to read file
        public void ReadFile()
        {
            FileStream fs = null;
            string path = directory + FileName;

            // verifying if the file path exists
            try
            {
                fs = new FileStream(path, FileMode.Open);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(FileName + " not found.", "File Not Found");

            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(directory + " not found.", "Directory not existing.");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error! " + ex.Message, "Exception IO");
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
                MessageBox.Show("File Empty.", FormTitle);
            }
            else
            {
                MessageBox.Show(line, FormTitle);
                
            }

            textFile.Close();
            fs.Close();
        }
    }
}
