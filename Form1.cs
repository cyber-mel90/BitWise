namespace Bitwise_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "BitWise - Character Decoder";
            lbl.Text = "BitWise";
            lbl.Font = new Font("Segoe UI", 20, FontStyle.Bold);
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Char", "Karakter");
            dataGridView1.Columns.Add("Ascii", "ASCII");
            dataGridView1.Columns.Add("Binary", "Binary");
            dataGridView1.Columns.Add("Hex", "Hex");
            dataGridView1.Columns.Add("Unicode", "Unicode");
        }

        private void button_Convert_Click(object sender, EventArgs e)
        {
            string input = textBox_Convert_Value.Text;
            dataGridView1.Rows.Clear(); //DataGridView Data Clear

            foreach (char c in input)
            {
                int ascii = (int)c;
                string binary = Convert.ToString(ascii, 2).PadLeft(8, '0');
                string hex = ascii.ToString("X2");

                dataGridView1.Rows.Add(c.ToString(), ascii, binary, hex);
            }
        }

        private void button_Conver_Char_Click(object sender, EventArgs e)
        {
            string inputValue = textBox_Convert_Value.Text;

            if (int.TryParse(inputValue, out int ascıı_value))
            {
                // ASCII → Character
                char character = (char)ascıı_value;
                MessageBox.Show($"ASCII {ascıı_value} -> Character: {character}", "Conversion Result");
            }
            else if (inputValue.Length == 8 && inputValue.All(c => c == '0' || c == '1'))
            {
                // Binary → Character
                int binary_value = Convert.ToInt32(inputValue, 2);
                char character = (char)binary_value;
                MessageBox.Show($"Binary {inputValue} -> Character: {character}", "Conversion Result");
            }
            else if (inputValue.Length == 2 && inputValue.All(c => "0123456789ABCDEF".Contains(c)))
            {
                // Hex → Character
                int hex_value = Convert.ToInt32(inputValue, 16);
                char character = (char)hex_value;
                MessageBox.Show($"Hex {inputValue} -> Character: {character}", "Conversion Result");
            }
            else
            {
                MessageBox.Show("Invalid entry. Please enter a valid ASCII, Binary, or Hex value.", "Fault");
            }
            foreach (char c in inputValue)
            {
                int ascıı = (int)c;
                string binary = Convert.ToString(ascıı, 2).PadLeft(8, '0');
                string hex = ascıı.ToString("X2");
                string unicode = $"U+{ascıı:X4}";  // → Unicode

                dataGridView1.Rows.Add(c.ToString(), ascıı, binary, hex, unicode);
            }

        }

        private void button_Copy_to_Clipboard_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // We get the data in the selected row
                var selectedRow = dataGridView1.SelectedRows[0];
                string ascii = selectedRow.Cells["Ascii"].Value.ToString();
                string binary = selectedRow.Cells["Binary"].Value.ToString();
                string hex = selectedRow.Cells["Hex"].Value.ToString();
                string unicode = selectedRow.Cells["UniCode"].Value.ToString();

                // Copy to clipboard
                string copiedText = $"ASCII: {ascii}\nBinary: {binary}\nHex: {hex}\nUnicode: {unicode}";
                Clipboard.SetText(copiedText);

                MessageBox.Show("Data copied to clipboard!", "Copy Successful");
            }
            else
            {
                MessageBox.Show("Please select a row to copy.", "Fault");
            }
        }

        private void button_Convert_Code_Click(object sender, EventArgs e)
        {
            string input = textBox_Convert_Value.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a character, word, or phrase.", "Caution");
                return;
            }

            dataGridView1.Rows.Clear(); // DataGridView Data Clear

            foreach (char c in input)
            {
                int ascıı = (int)c;
                string binary = Convert.ToString(ascıı, 2).PadLeft(8, '0');
                string hex = ascıı.ToString("X2");
                string unicode = $"U+{ascıı:X4}";

                dataGridView1.Rows.Add(c.ToString(), ascıı, binary, hex, unicode);
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Go To About Form
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();

            // This Form Close
            this.Close();
        }
    }

}

