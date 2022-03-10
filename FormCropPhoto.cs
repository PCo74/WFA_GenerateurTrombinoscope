using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WFA_GenerateurTrombinoscope
{
    public partial class FormCropPhoto : Form
    {
        private bool _isMove = true; // paint mask or not
        private ListViewItem _listViewItem; // related listViewItem 

        private Size _sizeSmallImageSize = new Size(196, 252); // HTML
        private Size _sizeLargeImageSize = new Size(77, 99); // APPLICATION C#

        public FormCropPhoto(ListViewItem aListViewItem=null)
        {
            InitializeComponent();
            ClientSize = userPortrait1.ClientSize;
            if (aListViewItem != null) changeListViewItem(aListViewItem);
        }

        public void changeListViewItem(ListViewItem aListViewItem)
        {
            _listViewItem = aListViewItem;
            _sizeLargeImageSize = _listViewItem.ListView.LargeImageList.ImageSize;
            _sizeSmallImageSize = _listViewItem.ListView.SmallImageList.ImageSize;
            userPortrait1.PathImage = _listViewItem.Tag.ToString();
            Text = Path.GetFileName(_listViewItem.Tag.ToString());
        }

        private void FormCropPhoto_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }

        private void userPortrait1_ButtonOkClick(object sender, EventArgs e)
        {
            updateListViewItemImage();
        }

        public void updateListViewItemImage()
        {
            Bitmap bm = userPortrait1.getActualImage();
            int iCurrent = _listViewItem.ImageIndex;
            Bitmap sbm = new Bitmap(bm, _sizeSmallImageSize); // HTML
            _listViewItem.ListView.SmallImageList.Images[iCurrent] = sbm;
            Bitmap lbm = new Bitmap(bm, _sizeLargeImageSize); // APPLICATION C#
            _listViewItem.ListView.LargeImageList.Images[iCurrent] = lbm;
            _listViewItem.ListView.Refresh();
            //userPortrait1.save();
        }

        private void FormCropPhoto_Move(object sender, EventArgs e)
        {
            if (!_isMove)
            {
                userPortrait1.IsMarked = false;
                _isMove = true;
            }
        }

        private void FormCropPhoto_ResizeEnd(object sender, EventArgs e)
        {
            if (_isMove)
            {
                userPortrait1.IsMarked = true;
                _isMove = false;
            }
        }

    }
}
