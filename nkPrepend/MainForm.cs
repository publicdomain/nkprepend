// <copyright file="MainForm.cs" company="PublicDomainWeekly.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>

namespace nkPrepend
{
    // Directives
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualBasic;
    using System.Windows.Forms;
    using System.Diagnostics;
    using PublicDomain;
    using System.Reflection;

    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        // The list view item
        private ListViewItem listViewItem = null;

        /// <summary>
        /// The padding zeros.
        /// </summary>
        private int paddingZeros = 1;

        /// <summary>
        /// Gets or sets the associated icon.
        /// </summary>
        /// <value>The associated icon.</value>
        private Icon associatedIcon = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:nkPrepend.MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            // The InitializeComponent() call is required for Windows Forms designer support.
            this.InitializeComponent();

            // Set associated icon from exe file
            this.associatedIcon = Icon.ExtractAssociatedIcon(typeof(MainForm).GetTypeInfo().Assembly.Location);

            // Set public domain weekly tool strip menu item image
            this.freeReleasesPublicDomainisToolStripMenuItem.Image = this.associatedIcon.ToBitmap();
        }

        /// <summary>
        /// Handles the new tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnNewToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Clear list view items
            this.fileListView.Items.Clear();

            // Update count
            this.fileCountToolStripStatusLabel.Text = "0";

            // Disable buttons
            this.renameButton.Enabled = false;
            this.copyButton.Enabled = false;
            this.moveButton.Enabled = false;
        }

        /// <summary>
        /// Handles the options tool strip menu item drop down item clicked.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOptionsToolStripMenuItemDropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Set clicked item
            var clickedItem = (ToolStripMenuItem)e.ClickedItem;

            // Set zeros
            if (clickedItem == this.setPaddingZerosToolStripMenuItem)
            {
                // TODO Prevent z-order [Can be made conditional]
                this.TopMost = false;

                // Set padding zeros
                if (int.TryParse(Interaction.InputBox("Enter number of padding zeros:", "Set zeros", this.paddingZeros.ToString()), out int zeros) && zeros > 0)
                {
                    this.paddingZeros = zeros;
                }
            }
            else
            {
                // Toggle checked
                clickedItem.Checked = !clickedItem.Checked;

                // Set topmost
                this.TopMost = this.alwaysOnTopToolStripMenuItem.Checked;
            }
        }

        /// <summary>
        /// Handles the free releases public domainis tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFreeReleasesPublicDomainisToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open our website
            Process.Start("https://publicdomain.is");
        }

        /// <summary>
        /// Handles the original thread donation codercom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnOriginalThreadDonationCodercomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open orignal thread
            Process.Start("https://www.donationcoder.com/forum/index.php?topic=52090.0");
        }

        /// <summary>
        /// Handles the source code githubcom tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnSourceCodeGithubcomToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Open GitHub repository
            Process.Start("https://github.com/publicdomain/nkprepend");
        }

        /// <summary>
        /// Handles the about tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnAboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Set license text
            var licenseText = $"CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication{Environment.NewLine}" +
                $"https://creativecommons.org/publicdomain/zero/1.0/legalcode{Environment.NewLine}{Environment.NewLine}" +
                $"Libraries and icons have separate licenses.{Environment.NewLine}{Environment.NewLine}" +
                $"Hashtag icon by inspire-studio - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/hash-tag-hashtag-sign-social-6834139/{Environment.NewLine}{Environment.NewLine}" +
                $"Patreon icon used according to published brand guidelines{Environment.NewLine}" +
                $"https://www.patreon.com/brand{Environment.NewLine}{Environment.NewLine}" +
                $"GitHub mark icon used according to published logos and usage guidelines{Environment.NewLine}" +
                $"https://github.com/logos{Environment.NewLine}{Environment.NewLine}" +
                $"DonationCoder icon used with permission{Environment.NewLine}" +
                $"https://www.donationcoder.com/forum/index.php?topic=48718{Environment.NewLine}{Environment.NewLine}" +
                $"PublicDomain icon is based on the following source images:{Environment.NewLine}{Environment.NewLine}" +
                $"Bitcoin by GDJ - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/vectors/bitcoin-digital-currency-4130319/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter P by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/p-glamour-gold-lights-2790632/{Environment.NewLine}{Environment.NewLine}" +
                $"Letter D by ArtsyBee - Pixabay License{Environment.NewLine}" +
                $"https://pixabay.com/illustrations/d-glamour-gold-lights-2790573/{Environment.NewLine}{Environment.NewLine}";

            // Prepend sponsors
            licenseText = $"RELEASE SPONSORS:{Environment.NewLine}{Environment.NewLine}* Jesse Reichler{Environment.NewLine}* Max P.{Environment.NewLine}{Environment.NewLine}=========={Environment.NewLine}{Environment.NewLine}" + licenseText;

            // Set title
            string programTitle = typeof(MainForm).GetTypeInfo().Assembly.GetCustomAttribute<AssemblyTitleAttribute>().Title;

            // Set version for generating semantic version 
            Version version = typeof(MainForm).GetTypeInfo().Assembly.GetName().Version;

            // Set about form
            var aboutForm = new AboutForm(
                $"About {programTitle}",
                $"{programTitle} {version.Major}.{version.Minor}.{version.Build}",
                $"Made for: nkormanik{Environment.NewLine}DonationCoder.com{Environment.NewLine}Day #31, Week #05 @ January 31, 2022",
                licenseText,
                this.Icon.ToBitmap())
            {
                // Set about form icon
                Icon = this.associatedIcon,

                // Set always on top
                TopMost = this.TopMost
            };

            // Show about form
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// Handles the browse button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnBrowseButtonClick(object sender, EventArgs e)
        {
            // Set description
            this.folderBrowserDialog.Description = "Populate file list";

            // Reset selected path
            this.folderBrowserDialog.SelectedPath = string.Empty;

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Clear list view 
                this.fileListView.Items.Clear();

                // TODO Populate file list [Might want to check for files prior to populate & enabling buttons]
                foreach (string file in Directory.GetFiles(this.folderBrowserDialog.SelectedPath, "*", SearchOption.TopDirectoryOnly))
                {
                    // Set item to file name 
                    ListViewItem item = new ListViewItem(Path.GetFileName(file))
                    {
                        // Store full path as tag
                        Tag = file
                    };

                    // Add item to list 
                    this.fileListView.Items.Add(item);
                }

                // Check for items
                if (this.fileListView.Items.Count > 0)
                {
                    // Enable buttons 
                    this.renameButton.Enabled = true;
                    this.copyButton.Enabled = true;
                    this.moveButton.Enabled = true;
                }

                // Update file count
                this.fileCountToolStripStatusLabel.Text = this.fileListView.Items.Count.ToString();
            }
        }

        /// <summary>
        /// Handles the rename button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnRenameButtonClick(object sender, EventArgs e)
        {
            // Check there's something to work with
            if (this.fileListView.Items.Count == 0)
            {
                // Halt flow
                return;
            }

            // Iterate items 
            for (int i = 0; i < this.fileListView.Items.Count; i++)
            {
                // Set source and destination paths
                var sourcePath = this.fileListView.Items[i].Tag.ToString();
                var sourceFileName = Path.GetFileName(sourcePath);
                var prefix = $"{(i + 1).ToString().PadLeft(this.paddingZeros, '0')}";
                var destination = Path.Combine(Path.GetDirectoryName(sourcePath), $"{prefix} {sourceFileName}");

                // "Move" to new name
                try
                {
                    File.Move(sourcePath, destination);
                }
                catch (Exception ex)
                {
                    // Inform about error
                    MessageBox.Show($"Source:{Environment.NewLine}{sourcePath}{Environment.NewLine}Destination:{Environment.NewLine}{destination}{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{ex.Message}", "File rename error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Save file count
            int fileCount = this.fileListView.Items.Count;

            // Clear list items
            this.fileListView.Items.Clear();

            // Update item count
            this.fileCountToolStripStatusLabel.Text = this.fileListView.Items.Count.ToString();

            // Advise user
            MessageBox.Show($"Renamed {fileCount} files.", "Rename", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Handles the copy button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnCopyButtonClick(object sender, EventArgs e)
        {
            // Check there's something to work with
            if (this.fileListView.Items.Count == 0)
            {
                // Halt flow
                return;
            }

            // Set description
            this.folderBrowserDialog.Description = "Set target copy directory";

            // Reset selected path
            this.folderBrowserDialog.SelectedPath = string.Empty;

            // Show folder browser dialog
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK && this.folderBrowserDialog.SelectedPath.Length > 0)
            {
                // Iterate items 
                for (int i = 0; i < this.fileListView.Items.Count; i++)
                {
                    // Set source and destination paths
                    var sourcePath = this.fileListView.Items[i].Tag.ToString();
                    var sourceFileName = Path.GetFileName(sourcePath);
                    var prefix = $"{(i + 1).ToString().PadLeft(this.paddingZeros, '0')}";
                    var destination = Path.Combine(this.folderBrowserDialog.SelectedPath, $"{prefix} {sourceFileName}");

                    // Copy with new name
                    try
                    {
                        File.Copy(sourcePath, destination);
                    }
                    catch (Exception ex)
                    {
                        // Inform about error
                        MessageBox.Show($"Source:{Environment.NewLine}{sourcePath}{Environment.NewLine}Destination:{Environment.NewLine}{destination}{Environment.NewLine}{Environment.NewLine}Message:{Environment.NewLine}{ex.Message}", "File copy error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // Save file count
                int fileCount = this.fileListView.Items.Count;

                // Update item count
                this.fileCountToolStripStatusLabel.Text = this.fileListView.Items.Count.ToString();

                // Advise user
                MessageBox.Show($"Copied {fileCount} files.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Handles the move button click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnMoveButtonClick(object sender, EventArgs e)
        {
            // TODO Add code
        }

        /// <summary>
        /// Handles the file list view mouse down.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFileListViewMouseDown(object sender, MouseEventArgs e)
        {
            listViewItem = fileListView.GetItemAt(e.X, e.Y);
        }

        /// <summary>
        /// Handles the file list view mouse move.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFileListViewMouseMove(object sender, MouseEventArgs e)
        {
            if (listViewItem != null)
            {
                Cursor = Cursors.Hand;
            }
        }

        /// <summary>
        /// Handles the file list view mouse up.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnFileListViewMouseUp(object sender, MouseEventArgs e)
        {
            if (listViewItem != null)
            {
                try
                {
                    ListViewItem destinationListViewItem = fileListView.GetItemAt(0, Math.Min(e.Y, fileListView.Items[fileListView.Items.Count - 1].GetBounds(ItemBoundsPortion.Entire).Bottom - 1));

                    if (destinationListViewItem != null)
                    {
                        Rectangle rectangle = destinationListViewItem.GetBounds(ItemBoundsPortion.Entire);

                        bool insertBefore = (e.Y < rectangle.Top + (rectangle.Height / 2));

                        if (listViewItem != destinationListViewItem)
                        {
                            fileListView.Items.Remove(listViewItem);

                            fileListView.Items.Insert(destinationListViewItem.Index + (insertBefore ? 1 : 0), listViewItem);
                        }

                        fileListView.Invalidate();
                    }
                }
                finally
                {
                    listViewItem = null;

                    Cursor = Cursors.Default;
                }
            }
        }

        /// <summary>
        /// Handles the delete tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnDeleteToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Prevent drawing 
            this.fileListView.BeginUpdate();

            // Remove selected items
            while (this.fileListView.SelectedIndices.Count > 0)
            {
                this.fileListView.Items.RemoveAt(this.fileListView.SelectedIndices[0]);
            }

            // Update count
            this.fileCountToolStripStatusLabel.Text = this.fileListView.Items.Count.ToString();

            // Resume drawing
            this.fileListView.EndUpdate();
        }

        /// <summary>
        /// Handles the exit tool strip menu item click.
        /// </summary>
        /// <param name="sender">Sender object.</param>
        /// <param name="e">Event arguments.</param>
        private void OnExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            // Close program
            this.Close();
        }
    }
}
