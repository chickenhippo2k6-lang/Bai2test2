
namespace BookManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer? components = null;

        private MenuStrip menuStrip1 = null!;
        private ToolStrip toolStrip1 = null!;
        private StatusStrip statusStrip1 = null!;

        private ToolStripMenuItem menuFile = null!;
        private ToolStripMenuItem menuOpen = null!;
        private ToolStripMenuItem menuSave = null!;
        private ToolStripMenuItem menuExit = null!;
        private ToolStripMenuItem menuEdit = null!;
        private ToolStripMenuItem menuAdd = null!;
        private ToolStripMenuItem menuDelete = null!;
        private ToolStripMenuItem menuSearch = null!;

        private ToolStripButton toolOpen = null!;
        private ToolStripButton toolSave = null!;
        private ToolStripButton toolAdd = null!;

        private ToolStripStatusLabel lblCount = null!;
        private ToolStripStatusLabel lblTotal = null!;
        private ToolStripStatusLabel lblTime = null!;

        private TableLayoutPanel tableMain = null!;
        private TableLayoutPanel tableInput = null!;
        private FlowLayoutPanel panelButtons = null!;
        private GroupBox grpInfo = null!;
        private GroupBox grpList = null!;

        private Label lblId = null!;
        private Label lblName = null!;
        private Label lblAuthor = null!;
        private Label lblCategory = null!;
        private Label lblPrice = null!;
        private Label lblQuantity = null!;
        private Label lblCover = null!;

        private TextBox txtBookId = null!;
        private TextBox txtBookName = null!;
        private TextBox txtAuthor = null!;
        private TextBox txtCategory = null!;
        private TextBox txtPrice = null!;
        private TextBox txtQuantity = null!;
        private TextBox txtSearch = null!;

        private PictureBox picBookCover = null!;
        private Button btnCover = null!;
        private Button btnAdd = null!;
        private Button btnEdit = null!;
        private Button btnDelete = null!;
        private Button btnReset = null!;
        private Button btnSearch = null!;

        private DataGridView dgvBooks = null!;
        private System.Windows.Forms.Timer timer1 = null!;

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuOpen = new ToolStripMenuItem();
            menuSave = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            menuEdit = new ToolStripMenuItem();
            menuAdd = new ToolStripMenuItem();
            menuDelete = new ToolStripMenuItem();
            menuSearch = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolOpen = new ToolStripButton();
            toolSave = new ToolStripButton();
            toolAdd = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblCount = new ToolStripStatusLabel();
            lblTotal = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            tableMain = new TableLayoutPanel();
            grpInfo = new GroupBox();
            tableInput = new TableLayoutPanel();
            lblId = new Label();
            txtBookId = new TextBox();
            lblName = new Label();
            txtBookName = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblQuantity = new Label();
            txtQuantity = new TextBox();
            lblCover = new Label();
            picBookCover = new PictureBox();
            btnCover = new Button();
            panelButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnReset = new Button();
            grpList = new GroupBox();
            dgvBooks = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableMain.SuspendLayout();
            grpInfo.SuspendLayout();
            tableInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).BeginInit();
            panelButtons.SuspendLayout();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuEdit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1250, 28);
            menuStrip1.TabIndex = 3;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuOpen, menuSave, menuExit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuOpen
            // 
            menuOpen.Name = "menuOpen";
            menuOpen.Size = new Size(171, 26);
            menuOpen.Text = "Mở file CSV";
            // 
            // menuSave
            // 
            menuSave.Name = "menuSave";
            menuSave.Size = new Size(171, 26);
            menuSave.Text = "Lưu file CSV";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(171, 26);
            menuExit.Text = "Thoát";
            // 
            // menuEdit
            // 
            menuEdit.DropDownItems.AddRange(new ToolStripItem[] { menuAdd, menuDelete, menuSearch });
            menuEdit.Name = "menuEdit";
            menuEdit.Size = new Size(49, 24);
            menuEdit.Text = "Edit";
            // 
            // menuAdd
            // 
            menuAdd.Name = "menuAdd";
            menuAdd.Size = new Size(153, 26);
            menuAdd.Text = "Thêm";
            // 
            // menuDelete
            // 
            menuDelete.Name = "menuDelete";
            menuDelete.Size = new Size(153, 26);
            menuDelete.Text = "Xóa";
            // 
            // menuSearch
            // 
            menuSearch.Name = "menuSearch";
            menuSearch.Size = new Size(153, 26);
            menuSearch.Text = "Tìm kiếm";
            // 
            // toolStrip1
            // 
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolOpen, toolSave, toolAdd });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1250, 27);
            toolStrip1.TabIndex = 2;
            // 
            // toolOpen
            // 
            toolOpen.Name = "toolOpen";
            toolOpen.Size = new Size(60, 24);
            toolOpen.Text = "Mở file";
            // 
            // toolSave
            // 
            toolSave.Name = "toolSave";
            toolSave.Size = new Size(62, 24);
            toolSave.Text = "Lưu file";
            // 
            // toolAdd
            // 
            toolAdd.Name = "toolAdd";
            toolAdd.Size = new Size(80, 24);
            toolAdd.Text = "Thêm mới";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblCount, lblTotal, lblTime });
            statusStrip1.Location = new Point(0, 670);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1250, 30);
            statusStrip1.TabIndex = 1;
            // 
            // lblCount
            // 
            lblCount.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(124, 24);
            lblCount.Text = "Tổng đầu sách: 0";
            // 
            // lblTotal
            // 
            lblTotal.BorderSides = ToolStripStatusLabelBorderSides.Right;
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(131, 24);
            lblTotal.Text = "Giá trị kho: 0 VNĐ";
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(980, 24);
            lblTime.Spring = true;
            lblTime.Text = "Thời gian";
            lblTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableMain
            // 
            tableMain.ColumnCount = 2;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableMain.Controls.Add(grpInfo, 0, 0);
            tableMain.Controls.Add(grpList, 1, 0);
            tableMain.Dock = DockStyle.Fill;
            tableMain.Location = new Point(0, 55);
            tableMain.Name = "tableMain";
            tableMain.Padding = new Padding(10);
            tableMain.RowCount = 1;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableMain.Size = new Size(1250, 615);
            tableMain.TabIndex = 0;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(tableInput);
            grpInfo.Dock = DockStyle.Fill;
            grpInfo.Location = new Point(13, 13);
            grpInfo.Name = "grpInfo";
            grpInfo.Padding = new Padding(10);
            grpInfo.Size = new Size(486, 589);
            grpInfo.TabIndex = 0;
            grpInfo.TabStop = false;
            grpInfo.Text = "THÔNG TIN SÁCH";
            // 
            // tableInput
            // 
            tableInput.ColumnCount = 2;
            tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableInput.Controls.Add(lblId, 0, 0);
            tableInput.Controls.Add(txtBookId, 1, 0);
            tableInput.Controls.Add(lblName, 0, 1);
            tableInput.Controls.Add(txtBookName, 1, 1);
            tableInput.Controls.Add(lblAuthor, 0, 2);
            tableInput.Controls.Add(txtAuthor, 1, 2);
            tableInput.Controls.Add(lblCategory, 0, 3);
            tableInput.Controls.Add(txtCategory, 1, 3);
            tableInput.Controls.Add(lblPrice, 0, 4);
            tableInput.Controls.Add(txtPrice, 1, 4);
            tableInput.Controls.Add(lblQuantity, 0, 5);
            tableInput.Controls.Add(txtQuantity, 1, 5);
            tableInput.Controls.Add(lblCover, 0, 6);
            tableInput.Controls.Add(picBookCover, 1, 6);
            tableInput.Controls.Add(btnCover, 1, 7);
            tableInput.Controls.Add(panelButtons, 0, 8);
            tableInput.Dock = DockStyle.Fill;
            tableInput.Location = new Point(10, 33);
            tableInput.Name = "tableInput";
            tableInput.RowCount = 9;
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 125F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            tableInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableInput.Size = new Size(466, 546);
            tableInput.TabIndex = 0;
            // 
            // lblId
            // 
            lblId.Dock = DockStyle.Fill;
            lblId.Location = new Point(3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(133, 43);
            lblId.TabIndex = 0;
            lblId.Text = "Mã sách";
            lblId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBookId
            // 
            txtBookId.Dock = DockStyle.Fill;
            txtBookId.Location = new Point(142, 6);
            txtBookId.Margin = new Padding(3, 6, 12, 6);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(312, 30);
            txtBookId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(3, 43);
            lblName.Name = "lblName";
            lblName.Size = new Size(133, 43);
            lblName.TabIndex = 2;
            lblName.Text = "Tên sách";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtBookName
            // 
            txtBookName.Dock = DockStyle.Fill;
            txtBookName.Location = new Point(142, 49);
            txtBookName.Margin = new Padding(3, 6, 12, 6);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(312, 30);
            txtBookName.TabIndex = 3;
            // 
            // lblAuthor
            // 
            lblAuthor.Dock = DockStyle.Fill;
            lblAuthor.Location = new Point(3, 86);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(133, 43);
            lblAuthor.TabIndex = 4;
            lblAuthor.Text = "Tác giả";
            lblAuthor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAuthor
            // 
            txtAuthor.Dock = DockStyle.Fill;
            txtAuthor.Location = new Point(142, 92);
            txtAuthor.Margin = new Padding(3, 6, 12, 6);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(312, 30);
            txtAuthor.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(3, 129);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(133, 43);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Thể loại";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCategory
            // 
            txtCategory.Dock = DockStyle.Fill;
            txtCategory.Location = new Point(142, 135);
            txtCategory.Margin = new Padding(3, 6, 12, 6);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(312, 30);
            txtCategory.TabIndex = 7;
            // 
            // lblPrice
            // 
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(3, 172);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(133, 43);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Đơn giá";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPrice
            // 
            txtPrice.Dock = DockStyle.Fill;
            txtPrice.Location = new Point(142, 178);
            txtPrice.Margin = new Padding(3, 6, 12, 6);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(312, 30);
            txtPrice.TabIndex = 9;
            // 
            // lblQuantity
            // 
            lblQuantity.Dock = DockStyle.Fill;
            lblQuantity.Location = new Point(3, 215);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(133, 43);
            lblQuantity.TabIndex = 10;
            lblQuantity.Text = "Số lượng";
            lblQuantity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtQuantity
            // 
            txtQuantity.Dock = DockStyle.Fill;
            txtQuantity.Location = new Point(142, 221);
            txtQuantity.Margin = new Padding(3, 6, 12, 6);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(312, 30);
            txtQuantity.TabIndex = 11;
            // 
            // lblCover
            // 
            lblCover.Dock = DockStyle.Fill;
            lblCover.Location = new Point(3, 258);
            lblCover.Name = "lblCover";
            lblCover.Size = new Size(133, 125);
            lblCover.TabIndex = 12;
            lblCover.Text = "Ảnh bìa";
            lblCover.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picBookCover
            // 
            picBookCover.BackColor = Color.WhiteSmoke;
            picBookCover.BorderStyle = BorderStyle.FixedSingle;
            picBookCover.Dock = DockStyle.Fill;
            picBookCover.Location = new Point(142, 261);
            picBookCover.Margin = new Padding(3, 3, 12, 3);
            picBookCover.Name = "picBookCover";
            picBookCover.Size = new Size(312, 119);
            picBookCover.SizeMode = PictureBoxSizeMode.Zoom;
            picBookCover.TabIndex = 13;
            picBookCover.TabStop = false;
            // 
            // btnCover
            // 
            btnCover.Location = new Point(142, 386);
            btnCover.Name = "btnCover";
            btnCover.Size = new Size(135, 32);
            btnCover.TabIndex = 14;
            btnCover.Text = "Tải ảnh bìa";
            btnCover.UseVisualStyleBackColor = true;
            // 
            // panelButtons
            // 
            tableInput.SetColumnSpan(panelButtons, 2);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnEdit);
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnReset);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(3, 428);
            panelButtons.Name = "panelButtons";
            panelButtons.Padding = new Padding(0, 8, 0, 0);
            panelButtons.Size = new Size(460, 115);
            panelButtons.TabIndex = 15;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 38);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm mới";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(134, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(125, 38);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(265, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(3, 55);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(125, 38);
            btnReset.TabIndex = 3;
            btnReset.Text = "Làm mới";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // grpList
            // 
            grpList.Controls.Add(dgvBooks);
            grpList.Controls.Add(btnSearch);
            grpList.Controls.Add(txtSearch);
            grpList.Dock = DockStyle.Fill;
            grpList.Location = new Point(505, 13);
            grpList.Name = "grpList";
            grpList.Padding = new Padding(10);
            grpList.Size = new Size(732, 589);
            grpList.TabIndex = 1;
            grpList.TabStop = false;
            grpList.Text = "DANH SÁCH SÁCH";
            // 
            // dgvBooks
            // 
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.AllowUserToDeleteRows = false;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Dock = DockStyle.Fill;
            dgvBooks.Location = new Point(10, 98);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersVisible = false;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(712, 481);
            dgvBooks.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Top;
            btnSearch.Location = new Point(10, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(712, 35);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Top;
            txtSearch.Location = new Point(10, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Nhập mã hoặc tên sách...";
            txtSearch.Size = new Size(712, 30);
            txtSearch.TabIndex = 2;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1250, 700);
            Controls.Add(tableMain);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1050, 620);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QUẢN LÝ TÀI LIỆU SÁCH VÀ NHÀ SÁCH";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableMain.ResumeLayout(false);
            grpInfo.ResumeLayout(false);
            tableInput.ResumeLayout(false);
            tableInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBookCover).EndInit();
            panelButtons.ResumeLayout(false);
            grpList.ResumeLayout(false);
            grpList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
