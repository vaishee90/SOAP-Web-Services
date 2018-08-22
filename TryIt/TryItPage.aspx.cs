using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TryIt.StorageService;
using TryIt.NewsService;

namespace TryIt
{
    public partial class TryItPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // button click event for uploading file to server
        protected void btnFileUpload_Click(object sender, EventArgs e)
        {
            StorageServiceClient storageClient = new StorageServiceClient();
            Console.WriteLine("filename: {0}", FileUpload1.FileName);
            string filePath = storageClient.storeFile(FileUpload1.FileName);
            FileUpload1.SaveAs(filePath);
            lblFilePath.Text = filePath.Trim();
        }

        // button click event to get top news links
        protected void btnGetLinks_Click(object sender, EventArgs e)
        {
            txtResultUrl.Text = "";
            NewsService.TopicalNewsServiceClient newsClient = new TopicalNewsServiceClient();
            try
            {
                // check if keyword textbox is empty
                if (string.IsNullOrEmpty(txtKeyWords.Text))
                {
                    lblKeyWordValid.Text = "Please enter a keyword";
                    lblKeyWordValid.Visible = true;
                }
                else
                {
                    // call the NewsFocus method in the News Service to get the top 10 links
                    lblKeyWordValid.Visible = false;
                    string[] result = newsClient.NewsFocus(txtKeyWords.Text.Trim().Split(' '));
                    for (Int32 i = 0; i < result.Length; i++)
                    {
                        txtResultUrl.Text += (i + 1).ToString() + ") " + result[i] + "\n\n";
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}