
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace BookManager
{
    public partial class Form1 : Form
    {
        private readonly BindingList<BookModel> books = new();
        private readonly BindingSource source = new();

        private BookModel? selectedBook;
        private string coverPath = "";
        private bool loading = false;

        public Form1()
        {
            InitializeComponent();

            SetupGrid();

            source.DataSource = books;
            dgvBooks.DataSource = source;

            books.ListChanged += (s, e) => UpdateStatus();

            btnAdd.Click += AddBook;
            btnEdit.Click += EditBook;
            btnDelete.Click += DeleteBook;
            btnReset.Click += (s, e) => ResetForm();
            btnCover.Click += ChooseCover;
            btnSearch.Click += SearchBook;

            menuOpen.Click += OpenCsv;
            menuSave.Click += SaveCsv;
            menuExit.Click += (s, e) => Close();

            menuAdd.Click += AddBook;
            menuDelete.Click += DeleteBook;
            menuSearch.Click += SearchBook;

            toolOpen.Click += OpenCsv;
            toolSave.Click += SaveCsv;
            toolAdd.Click += AddBook;

            toolOpen.Image = SystemIcons.Application.ToBitmap();
            toolSave.Image = SystemIcons.Information.ToBitmap();
            toolAdd.Image = SystemIcons.Shield.ToBitmap();

            dgvBooks.SelectionChanged += GridSelectionChanged;
            dgvBooks.CellFormatting += GridCellFormatting;

            timer1.Tick += (s, e) => UpdateClock();
            timer1.Start();

            UpdateClock();
            UpdateStatus();
            ResetForm();
        }

        private void SetupGrid()
        {
            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.Columns.Clear();

            AddColumn("Mã sách", nameof(BookModel.BookId));
            AddColumn("Tên sách", nameof(BookModel.BookName));
            AddColumn("Tác giả", nameof(BookModel.Author));
            AddColumn("Thể loại", nameof(BookModel.Category));

            DataGridViewTextBoxColumn priceCol = new()
            {
                HeaderText = "Đơn giá",
                DataPropertyName = nameof(BookModel.Price),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment =
                        DataGridViewContentAlignment.MiddleRight
                }
            };

            dgvBooks.Columns.Add(priceCol);

            AddColumn("Số lượng", nameof(BookModel.Quantity));

            DataGridViewTextBoxColumn totalCol = new()
            {
                HeaderText = "Thành tiền",
                DataPropertyName = nameof(BookModel.Total),
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0"
                }
            };

            dgvBooks.Columns.Add(totalCol);

            AddColumn("Ảnh bìa", nameof(BookModel.CoverPath));
        }

        private void AddColumn(string header, string property)
        {
            dgvBooks.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = header,
                DataPropertyName = property,
                Name = "col" + property
            });
        }

        private void GridCellFormatting(
            object? sender,
            DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBooks.Columns[e.ColumnIndex].DataPropertyName
                == nameof(BookModel.CoverPath))
            {
                string path = e.Value?.ToString() ?? "";

                e.Value = string.IsNullOrEmpty(path)
                    ? ""
                    : Path.GetFileName(path);

                e.FormattingApplied = true;
            }
        }

        private void UpdateStatus()
        {
            lblCount.Text = $"Tổng đầu sách: {books.Count}";

            decimal total = books.Sum(b => b.Total);

            lblTotal.Text =
                $"Giá trị kho: {total:N0} VNĐ";
        }

        private void UpdateClock()
        {
            lblTime.Text =
                DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void ShowCover(string path)
        {
            Image? oldImage = picBookCover.Image;
            picBookCover.Image = null;
            oldImage?.Dispose();

            if (string.IsNullOrWhiteSpace(path) ||
                !File.Exists(path))
                return;

            try
            {
                using FileStream fs = new(
                    path, FileMode.Open, FileAccess.Read,
                    FileShare.ReadWrite);

                using Image temp = Image.FromStream(fs);

                picBookCover.Image = new Bitmap(temp);
            }
            catch
            {
                picBookCover.Image = null;
            }
        }

        private void ChooseCover(object? sender, EventArgs e)
        {
            using OpenFileDialog dialog = new()
            {
                Title = "Chọn ảnh bìa sách",
                Filter = "Ảnh PNG/JPG|*.png;*.jpg;*.jpeg",
                CheckFileExists = true
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            coverPath = dialog.FileName;
            ShowCover(coverPath);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtBookId.Text) ||
                string.IsNullOrWhiteSpace(txtBookName.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ thông tin sách.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (!decimal.TryParse(
                txtPrice.Text.Trim(),
                NumberStyles.Number,
                CultureInfo.CurrentCulture,
                out decimal price) || price <= 0)
            {
                MessageBox.Show(
                    "Đơn giá phải là số lớn hơn 0.");
                return false;
            }

            if (!int.TryParse(
                txtQuantity.Text.Trim(),
                out int quantity) || quantity < 0)
            {
                MessageBox.Show(
                    "Số lượng phải là số nguyên không âm.");
                return false;
            }

            return true;
        }

        private void AddBook(object? sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            string id = txtBookId.Text.Trim();

            if (books.Any(b =>
                b.BookId.Equals(id,
                    StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sách đã tồn tại!");
                return;
            }

            loading = true;

            books.Add(new BookModel
            {
                BookId = id,
                BookName = txtBookName.Text.Trim(),
                Author = txtAuthor.Text.Trim(),
                Category = txtCategory.Text.Trim(),
                Price = decimal.Parse(
                    txtPrice.Text.Trim(),
                    CultureInfo.CurrentCulture),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                CoverPath = coverPath
            });

            loading = false;

            MessageBox.Show("Thêm sách thành công!");
            ResetForm();
        }

        private void EditBook(object? sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa.");
                return;
            }

            if (!ValidateInput())
                return;

            string id = txtBookId.Text.Trim();

            if (books.Any(b =>
                b != selectedBook &&
                b.BookId.Equals(id,
                    StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Mã sách đã tồn tại!");
                return;
            }

            loading = true;

            selectedBook.BookId = id;
            selectedBook.BookName = txtBookName.Text.Trim();
            selectedBook.Author = txtAuthor.Text.Trim();
            selectedBook.Category = txtCategory.Text.Trim();

            selectedBook.Price = decimal.Parse(
                txtPrice.Text.Trim(),
                CultureInfo.CurrentCulture);

            selectedBook.Quantity =
                int.Parse(txtQuantity.Text.Trim());

            selectedBook.CoverPath = coverPath;

            loading = false;

            UpdateStatus();

            MessageBox.Show("Cập nhật sách thành công!");
        }

        private void DeleteBook(object? sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần xóa.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có muốn xóa sách {selectedBook.BookName}?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            loading = true;
            books.Remove(selectedBook);
            loading = false;

            ResetForm();
        }

        private void GridSelectionChanged(
            object? sender, EventArgs e)
        {
            if (loading || dgvBooks.SelectedRows.Count == 0)
                return;

            BookModel? book =
                dgvBooks.SelectedRows[0].DataBoundItem
                as BookModel;

            if (book == null)
                return;

            selectedBook = book;

            txtBookId.Text = book.BookId;
            txtBookName.Text = book.BookName;
            txtAuthor.Text = book.Author;
            txtCategory.Text = book.Category;
            txtPrice.Text = book.Price.ToString(
                CultureInfo.CurrentCulture);
            txtQuantity.Text = book.Quantity.ToString();

            coverPath = book.CoverPath;
            ShowCover(coverPath);

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void ResetForm()
        {
            loading = true;

            selectedBook = null;
            source.Position = -1;
            dgvBooks.ClearSelection();
            dgvBooks.CurrentCell = null;

            txtBookId.Clear();
            txtBookName.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();

            coverPath = "";
            ShowCover("");

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;

            loading = false;
        }

        private void SearchBook(object? sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (keyword.Length == 0)
            {
                MessageBox.Show("Nhập mã hoặc tên sách cần tìm.");
                return;
            }

            BookModel? book = books.FirstOrDefault(b =>
                b.BookId.Contains(keyword,
                    StringComparison.OrdinalIgnoreCase) ||
                b.BookName.Contains(keyword,
                    StringComparison.OrdinalIgnoreCase));

            if (book == null)
            {
                MessageBox.Show("Không tìm thấy sách.");
                return;
            }

            source.Position = books.IndexOf(book);
            dgvBooks.ClearSelection();

            foreach (DataGridViewRow row in dgvBooks.Rows)
            {
                if (ReferenceEquals(row.DataBoundItem, book))
                {
                    row.Selected = true;
                    dgvBooks.CurrentCell = row.Cells[0];
                    break;
                }
            }
        }

        private static string CsvField(string value)
        {
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }

        private void SaveCsv(object? sender, EventArgs e)
        {
            using SaveFileDialog dialog = new()
            {
                Title = "Lưu danh sách sách",
                Filter = "CSV files (*.csv)|*.csv",
                DefaultExt = "csv",
                AddExtension = true,
                FileName = "DanhSachSach.csv"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string folder = Path.GetDirectoryName(
                    dialog.FileName)!;

                using StreamWriter writer = new(
                    dialog.FileName,
                    false,
                    new UTF8Encoding(true));

                writer.WriteLine(
                    "BookId,BookName,Author,Category,Price,Quantity,CoverPath");

                foreach (BookModel b in books)
                {
                    string imagePath = b.CoverPath;

                    if (!string.IsNullOrWhiteSpace(imagePath))
                    {
                        imagePath = Path.GetRelativePath(
                            folder, Path.GetFullPath(imagePath));
                    }

                    string line = string.Join(",",
                        CsvField(b.BookId),
                        CsvField(b.BookName),
                        CsvField(b.Author),
                        CsvField(b.Category),
                        b.Price.ToString(CultureInfo.InvariantCulture),
                        b.Quantity.ToString(CultureInfo.InvariantCulture),
                        CsvField(imagePath));

                    writer.WriteLine(line);
                }

                MessageBox.Show(
                    "Xuất CSV thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu file: " + ex.Message);
            }
        }

        private void OpenCsv(object? sender, EventArgs e)
        {
            using OpenFileDialog dialog = new()
            {
                Title = "Mở danh sách sách",
                Filter = "CSV files (*.csv)|*.csv",
                CheckFileExists = true
            };

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                BindingList<BookModel> imported = new();

                using TextFieldParser parser = new(
                    dialog.FileName, Encoding.UTF8, true);

                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                parser.HasFieldsEnclosedInQuotes = true;

                if (parser.EndOfData)
                    throw new Exception("File CSV trống.");

                string[]? header = parser.ReadFields();

                if (header == null ||
                    !header.SequenceEqual(new[]
                    {
                        "BookId", "BookName", "Author",
                        "Category", "Price", "Quantity", "CoverPath"
                    }))
                {
                    throw new Exception(
                        "File CSV không đúng cấu trúc 7 cột.");
                }

                string folder = Path.GetDirectoryName(
                    dialog.FileName)!;

                while (!parser.EndOfData)
                {
                    string[]? f = parser.ReadFields();

                    if (f == null)
                        continue;

                    if (f.Length != 7)
                        throw new Exception(
                            "Dòng CSV không đủ 7 cột.");

                    string imagePath = f[6];

                    if (!string.IsNullOrWhiteSpace(imagePath))
                    {
                        imagePath = Path.GetFullPath(
                            Path.Combine(folder, imagePath));
                    }

                    if (string.IsNullOrWhiteSpace(f[0]) ||
                        string.IsNullOrWhiteSpace(f[1]) ||
                        imported.Any(b => b.BookId.Equals(
                            f[0], StringComparison.OrdinalIgnoreCase)))
                    {
                        throw new Exception(
                            "Mã sách trống, tên sách trống hoặc trùng mã.");
                    }

                    decimal price = decimal.Parse(
                        f[4], CultureInfo.InvariantCulture);

                    int quantity = int.Parse(
                        f[5], CultureInfo.InvariantCulture);

                    if (price <= 0 || quantity < 0)
                        throw new Exception(
                            "Đơn giá hoặc số lượng không hợp lệ.");

                    imported.Add(new BookModel
                    {
                        BookId = f[0],
                        BookName = f[1],
                        Author = f[2],
                        Category = f[3],
                        Price = price,
                        Quantity = quantity,
                        CoverPath = imagePath
                    });
                }

                loading = true;

                books.Clear();

                foreach (BookModel book in imported)
                    books.Add(book);

                loading = false;

                ResetForm();
                UpdateStatus();

                MessageBox.Show(
                    "Nhập CSV thành công!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                loading = false;

                MessageBox.Show(
                    "Không thể đọc CSV: " + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
