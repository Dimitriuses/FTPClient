using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        Client client;
        string ServerPatch = "";
        string ClientPach = "C:/";

        ImageList imageList = new ImageList();
        
        public Form1()
        {
            InitializeComponent();
            Image File = Image.FromFile("./file.png");
            Image Folder = Image.FromFile("./folder.png");
            imageList.Images.Add("File",File);
            imageList.Images.Add("Folder", Folder);
            listViewServer.LargeImageList = imageList;
        }

        private void підключитисьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection connection = new Connection();
            if(connection.ShowDialog() == DialogResult.OK)
            {
                client = connection.client;
                treeViewServer.Nodes.Clear();
                treeViewServer.Nodes.Add(ServerPatch);
                UpdateDirServer(ServerPatch, treeViewServer.Nodes[0]);
            }
        }

        private void UpdateDirServer(string Patch, TreeNode node)
        {
            FileStruct[] Tmp = client.ListDirectory(Patch);
            foreach (var item in Tmp)
            {
                if (item.IsDirectory)
                {
                    TreeNode tmp = new TreeNode(item.Name);
                    tmp.Tag = Patch + "/" + item.Name;
                    node.Nodes.Add(tmp);
                }
            }
            foreach (TreeNode item in node.Nodes)
            {
                UpdateDirServer(Patch + "/" + item.Text, item);
            }
            
        }
        private void UpdateDirViev(string Patch)
        {
            listViewServer.Clear();
            FileStruct[] Tmp = client.ListDirectory(Patch);
            foreach (var item in Tmp)
            {
                listViewServer.Items.Add(item.Name);
                if (item.IsDirectory)
                {
                    listViewServer.Items[listViewServer.Items.Count - 1].ImageKey = "Folder";
                    listViewServer.Items[listViewServer.Items.Count - 1].Tag = Patch + "/" + item.Name;
                }
                else
                {
                    listViewServer.Items[listViewServer.Items.Count - 1].ImageKey = "File";
                }
            }
        }

        private void treeViewServer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = treeViewServer.SelectedNode;
            UpdateDirViev((string)node.Tag);
        }

        private void listViewServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = listViewServer.SelectedItems[0];
            if(item.Tag != null)
            {
                UpdateDirViev((string)item.Tag);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //client.CreateDirectory("/", "Dmitrius");
            //client.UploadFile("/Dmitrius/", "./file.png");
            //client.CreateDirectory("/Dmitrius/", "png");
            client.UploadFile("/Dmitrius/png/", "./howto_wpf_xps_to_png.png");
            //client.UploadFile("/Dmitrius/png/", "./folder.png");
        }
    }
}