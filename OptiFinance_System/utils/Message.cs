namespace OptiFinance_System.utils;

public static class Message
{
    public static void MessageView(string message, MessageBoxIcon icon, MessageBoxButtons buttons)
    {
        MessageBox.Show(message, @"OptiFinance", buttons, icon);
    }

    public static void MessageViewError(string message)
    {
        MessageBox.Show(message, @"OptiFinance", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static void MessageViewSuccess(string message)
    {
        MessageBox.Show(message, @"OptiFinance", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}