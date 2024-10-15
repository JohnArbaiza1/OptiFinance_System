namespace OptiFinance_System.utils;

public class Message
{
    public static void MessageView (string message, MessageBoxIcon icon, MessageBoxButtons buttons)
    {
        MessageBox.Show(message, @"OptiFinance", buttons, icon);
    }
    
    public static void MessageViewError (string message)
    {
        MessageBox.Show(message, @"OptiFinance", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}