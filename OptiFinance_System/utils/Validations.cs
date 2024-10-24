using Microsoft.IdentityModel.Tokens;
using OptiFinance_System.database.models;

namespace OptiFinance_System.utils;

public class Validations
{
    public static bool ComparePasswordHash(string password, string passwordHash)
    {
        return BCrypt.Net.BCrypt.Verify(password, passwordHash);
    }

    public static bool UserExist(People? people)
    {
        if (people == null) return false;
        if (people is MiembroEmpresa)
        {
            Console.WriteLine(@"Es miembro empresa");
            MiembroEmpresa miembroEmpresa = (MiembroEmpresa)people;
            Console.WriteLine(miembroEmpresa.Alias);
            Console.WriteLine(miembroEmpresa.Password);
            return !miembroEmpresa.Alias.IsNullOrEmpty() && !miembroEmpresa.Password.IsNullOrEmpty();
        }

        Usuario usuario = (Usuario)people;
        return !usuario.Alias.IsNullOrEmpty() && !usuario.Password.IsNullOrEmpty();
    }

    public static bool FieldNullOrEmpty(ErrorProvider errorProvider, Control control, string message,
        ErrorIconAlignment iconAlignment = ErrorIconAlignment.MiddleLeft)
    {
        if (control.Text.IsNullOrEmpty())
        {
            errorProvider.SetError(control, message);
            return true;
        }

        errorProvider.SetError(control, "");
        return false;
    }

    public static bool TextBoxNullOrEmpty(ErrorProvider errorProvider, TextBox control, string message,
        ErrorIconAlignment iconAlignment = ErrorIconAlignment.MiddleLeft)
    {
        errorProvider.SetIconAlignment(control, iconAlignment);
        if (control.Text.IsNullOrEmpty())
        {
            errorProvider.SetError(control, message);
            return true;
        }

        errorProvider.SetError(control, "");
        return false;
    }

    public static bool ComboBoxNullOrEmpty(ErrorProvider errorProvider, ComboBox control, string message,
        ErrorIconAlignment iconAlignment = ErrorIconAlignment.MiddleLeft)
    {
        errorProvider.SetIconAlignment(control, iconAlignment);
        if (control.SelectedItem == null)
        {
            errorProvider.SetError(control, message);
            return true;
        }

        errorProvider.SetError(control, "");
        return false;
    }
}