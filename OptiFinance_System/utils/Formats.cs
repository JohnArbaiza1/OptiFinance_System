namespace OptiFinance_System.utils;

public static class Formats
{
    public static void FormatNit(object sender, EventArgs e)
    {
        if (!sender.GetType().Name.Equals(nameof(TextBox))) return;
        TextBox textBox = (TextBox)sender;

        int cursorPosition = textBox.SelectionStart;
        string text = textBox.Text.Replace("-", "");

        if (text.Length > 13) text = text[..13];

        if (text.Length > 4) text = text.Insert(4, "-");

        if (text.Length > 11) text = text.Insert(11, "-");

        if (text.Length > 15) text = text.Insert(15, "-");

        textBox.Text = text;
        textBox.SelectionStart = cursorPosition;

        if (textBox.SelectionStart is 5 or 12 or 16) textBox.SelectionStart++;
    }
    public static void FormatDui(object sender, EventArgs e)
    {
        if (!sender.GetType().Name.Equals(nameof(TextBox))) return;
        TextBox textBox = (TextBox)sender;

        int cursorPosition = textBox.SelectionStart;
        string text = textBox.Text.Replace("-", "");

        if (text.Length > 9) text = text[..9];

        if (text.Length > 8) text = text.Insert(8, "-");

        textBox.Text = text;
        textBox.SelectionStart = cursorPosition;

        if (textBox.SelectionStart is 9) textBox.SelectionStart++;
    }

    public static void FormatTelefono(object sender, EventArgs e)
    {
        if (!sender.GetType().Name.Equals(nameof(TextBox))) return;
        TextBox textBox = (TextBox)sender;

        int cursorPosition = textBox.SelectionStart;
        string text = textBox.Text.Replace("-", "");

        if (text.Length > 8) text = text[..8];

        if (text.Length > 4) text = text.Insert(4, "-");

        textBox.Text = text;
        textBox.SelectionStart = cursorPosition;

        if (textBox.SelectionStart is 5) textBox.SelectionStart++;
    }

    public static void OnlyNumbers(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
    }
}