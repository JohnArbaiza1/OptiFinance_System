using global::OptiFinance_System.global;
using OptiFinance_System.database.models;
using OptiFinance_System.database.query;
using OptiFinance_System.utils;
using Formats = OptiFinance_System.utils.Formats;
using Message = OptiFinance_System.utils.Message;

namespace OptiFinance_System.Views;

public partial class InfoEmpresacs : Form
{
    public static TextBox txtGiroAux;
    private List<string> _errores;
    private Empresa? _empresaInsert;
    private List<Distrito> _distritos;
    private List<Municipio> _municipios;
    private List<Departamento> _departamentos;

    public InfoEmpresacs()
    {
        InitializeComponent();
        txtGiroAux = textBox4;
        _errores = new()
        {
            "El campo nombre de la empresa es obligatorio",
            "El campo giro económico de la empresa es obligatorio",
            "El campo NIT de la empresa es obligatorio",
            "El campo representante legal de la empresa es obligatorio",
            "El campo teléfono de la empresa es obligatorio",
            "El campo email de la empresa es obligatorio",
            "El campo dirección de la empresa es obligatorio",
            "El campo distrito de la empresa es obligatorio"
        };
    }

    private void btnAtras_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnRegistrar_Click(object sender, EventArgs e)
    {
        bool validateNombre = Validations.TextBoxNullOrEmpty(errorProvider, txtNombreEmpresa, _errores[0]);
        bool validateGiro = Validations.TextBoxNullOrEmpty(errorProvider, textBox4, _errores[1]);
        bool validateNit = Validations.TextBoxNullOrEmpty(errorProvider, txtNit, _errores[2]);
        bool validateRepresentante = Validations.TextBoxNullOrEmpty(errorProvider, txtRepresentante, _errores[3]);
        bool validateTelefono = Validations.TextBoxNullOrEmpty(errorProvider, textBox1, _errores[4]);
        bool validateEmail = Validations.TextBoxNullOrEmpty(errorProvider, textBox2, _errores[5]);
        bool validateDireccion = Validations.TextBoxNullOrEmpty(errorProvider, textBox3, _errores[6]);
        bool validateDistrito = Validations.ComboBoxNullOrEmpty(errorProvider, comboDistrito, _errores[7]);
        if (validateNombre || validateGiro || validateNit || validateRepresentante || validateTelefono ||
            validateEmail || validateDireccion || validateDistrito) return;
        Empresa empresa = new();

        Console.WriteLine();
        empresa.Nombre = txtNombreEmpresa.Text;
        empresa.GiroEconomico = textBox4.Tag as GiroEconomico;
        empresa.Nit = txtNit.Text;
        empresa.RepresentanteLegal = txtRepresentante.Text;
        empresa.Telefono = textBox1.Text;
        empresa.Email = textBox2.Text;
        empresa.Direccion = textBox3.Text;
        empresa.Distrito = comboDistrito.SelectedItem as Distrito;
        empresa.Usuario = Form1.currentUser;

        Empresa? empresaInsert = EmpresaQuery.Instance.InsertWithResult(empresa);

        if (empresaInsert == null)
        {
            Message.MessageViewError(@"Error al registrar la empresa");
            return;
        }

        _empresaInsert = empresaInsert;
        Message.MessageViewSuccess(@"Empresa registrada correctamente");
        lblEmpresa.Text = empresaInsert.Nombre;
        lblComercio.Text = empresaInsert.GiroEconomico?.ToString() ?? "";
        lblNit.Text = empresaInsert.Nit;
        lblRepre.Text = empresaInsert.RepresentanteLegal;
        lblPhone.Text = empresaInsert.Telefono;
        lblEmail.Text = empresaInsert.Email;
        lblDepartamento.Text = DepartamentoQuery.Instance.FindById(empresaInsert.Distrito?.Municipio?.Departamento?.Id ?? 0)?.Nombre ?? "";
        lblMunicipio.Text = MunicipioQuery.Instance.FindById(empresaInsert.Distrito?.Municipio?.Id ?? 0)?.Nombre ?? "";
        Distrito? distritoInsert = DistritoQuery.Instance.FindById(empresaInsert.Distrito?.Id ?? 0);
        if (distritoInsert != null)
        {
            lblDistrito.Text = distritoInsert.Nombre;

        }
        else
        {
            lblDistrito.Text = @"No asignado";
        }
        lblAddres.Text = empresaInsert.Direccion;
        ClearText();
        Close();
    }

    private void InfoEmpresacs_Load(object sender, EventArgs e)
    {
        // await Task.Run(cargarDistritos);
    }

    private void CargarDistritos()
    {
        if (_distritos.Count == 0) return;
        if (comMunucipio.SelectedIndex < 0) return;

        Municipio currentMunicipio = (Municipio)comMunucipio.SelectedItem;
        comboDistrito.DataSource = _distritos.FindAll(
            entity => entity.Municipio?.Id == currentMunicipio.Id);
    }

    private void CargarMunicipios()
    {
        if (_municipios.Count == 0) return;
        if (comboDepartamento.SelectedIndex < 0) return;
        
        Departamento currentDepartamento = (Departamento)comboDepartamento.SelectedItem;
        comMunucipio.DataSource = _municipios.FindAll(
            entity => entity.Departamento?.Id == currentDepartamento.Id);
    }

    private void CargarDepartamentos()
    {
        if (_departamentos.Count == 0) return;
        comboDepartamento.DataSource = _departamentos;
    }

    private void btnBuscarGiro_Click(object sender, EventArgs e)
    {
        busquedaGiro busqueda = new();
        busqueda.Show();
    }

    private void InfoEmpresacs_Shown(object sender, EventArgs e)
    {
        _departamentos = Global.ListDepartamentos;
        _municipios = Global.ListMunicipios;
        _distritos = Global.ListDistritos;
        CargarDepartamentos();
        CargarMunicipios();
        CargarDistritos();
    }

    private void txtNit_TextChanged(object sender, EventArgs e)
    {
        Formats.FormatNit(sender, e);
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        Formats.FormatTelefono(sender, e);
    }

    private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
    {
        Formats.OnlyNumbers(sender, e);
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
        Formats.OnlyNumbers(sender, e);
    }

    private void groupBoxDoc_Enter_1(object sender, EventArgs e)
    {
        if (_empresaInsert == null) return;
        btnDelete.Visible = true;
        btnEdit.Visible = true;
        txtNombreEmpresa.Text = _empresaInsert.Nombre;
        textBox4.Text = _empresaInsert.GiroEconomico?.Nombre ?? "";
        txtNit.Text = _empresaInsert.Nit;
        txtRepresentante.Text = _empresaInsert.RepresentanteLegal;
        textBox1.Text = _empresaInsert.Telefono;
        textBox2.Text = _empresaInsert.Email;
        List<Distrito> distritosCombobox = comboDistrito.Items.Cast<Distrito>().ToList();
        comboDistrito.SelectedItem = distritosCombobox.Find(d => d.Id == _empresaInsert.Distrito?.Id) ?? null;
        textBox3.Text = _empresaInsert.Direccion;
    }

    private void SetErrorProvider(ErrorProvider errorProvider, Control control, string message,
        ErrorIconAlignment iconAlignment = ErrorIconAlignment.MiddleLeft)
    {
        errorProvider.SetIconAlignment(control, iconAlignment);
        errorProvider.SetError(control, message);
    }

    private void txtNit_KeyUp(object sender, KeyEventArgs e)
    {
        timerNit.Stop();
        timerNit.Start();
    }

    private void timerNit_Tick(object sender, EventArgs e)
    {
        if (btnEdit.Visible)
            if (txtNit.Text == _empresaInsert?.Nit)
            {
                SetErrorProvider(errorProvider, txtNit, "");
                return;
            }

        if (EmpresaQuery.Instance.FindByNit(txtNit.Text) != null)
        {
            SetErrorProvider(errorProvider, txtNit, "El NIT ya está registrado");
        }
        else
        {
            errorProvider.SetError(txtNit, "");
        }

        timerNit.Stop();
    }

    private void ClearText()
    {
        btnDelete.Visible = false;
        btnEdit.Visible = false;
        txtNombreEmpresa.Text = "";
        textBox4.Text = "";
        txtNit.Text = "";
        txtRepresentante.Text = "";
        textBox1.Text = "";
        textBox2.Text = "";
        comboDistrito.SelectedIndex = -1;
        textBox3.Text = "";
    }

    private void textBox1_KeyUp(object sender, KeyEventArgs e)
    {
        timerTelefono.Stop();
        timerTelefono.Start();
    }

    private void timerTelefono_Tick(object sender, EventArgs e)
    {
        if (btnEdit.Visible)
            if (textBox1.Text == _empresaInsert?.Telefono)
            {
                SetErrorProvider(errorProvider, textBox1, "");
                return;
            }

        if (Validations.ExistTelefono(textBox1.Text))
        {
            SetErrorProvider(errorProvider, textBox1, "El teléfono ya está registrado");
        }
        else
        {
            errorProvider.SetError(textBox1, "");
        }

        timerTelefono.Stop();
    }

    private void textBox2_KeyUp(object sender, KeyEventArgs e)
    {
        timerCorreo.Stop();
        timerCorreo.Start();
    }

    private void timerCorreo_Tick(object sender, EventArgs e)
    {
        if (btnEdit.Visible)
            if (textBox2.Text == _empresaInsert?.Email)
            {
                SetErrorProvider(errorProvider, textBox2, "");
                return;
            }

        if (Validations.ExistEmail(textBox2.Text))
        {
            SetErrorProvider(errorProvider, textBox2, "El correo ya está registrado");
        }
        else
        {
            errorProvider.SetError(textBox2, "");
        }

        timerCorreo.Stop();
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (_empresaInsert == null) return;

        bool validateNombre = Validations.TextBoxNullOrEmpty(errorProvider, txtNombreEmpresa, _errores[0]);
        bool validateGiro = Validations.TextBoxNullOrEmpty(errorProvider, textBox4, _errores[1]);
        bool validateNit = Validations.TextBoxNullOrEmpty(errorProvider, txtNit, _errores[2])
            || (txtNit.Text != _empresaInsert.Nit && EmpresaQuery.Instance.FindByNit(txtNit.Text) != null);
        bool validateRepresentante = Validations.TextBoxNullOrEmpty(errorProvider, txtRepresentante, _errores[3]);
        bool validateTelefono = Validations.TextBoxNullOrEmpty(errorProvider, textBox1, _errores[4])
            || (textBox1.Text != _empresaInsert.Telefono && Validations.ExistTelefono(textBox1.Text));
        bool validateEmail = Validations.TextBoxNullOrEmpty(errorProvider, textBox2, _errores[5])
            || (textBox2.Text != _empresaInsert.Email && Validations.ExistEmail(textBox2.Text));
        bool validateDireccion = Validations.TextBoxNullOrEmpty(errorProvider, textBox3, _errores[6]);
        bool validateDistrito = Validations.ComboBoxNullOrEmpty(errorProvider, comboDistrito, _errores[7]);

        if (validateNombre || validateGiro || validateNit || validateRepresentante || validateTelefono ||
            validateEmail || validateDireccion || validateDistrito) return;

        _empresaInsert.Nombre = txtNombreEmpresa.Text;
        _empresaInsert.GiroEconomico = textBox4.Tag as GiroEconomico;
        _empresaInsert.Nit = txtNit.Text;
        _empresaInsert.RepresentanteLegal = txtRepresentante.Text;
        _empresaInsert.Telefono = textBox1.Text;
        _empresaInsert.Email = textBox2.Text;
        _empresaInsert.Direccion = textBox3.Text;
        _empresaInsert.Distrito = comboDistrito.SelectedItem as Distrito;

        bool update = EmpresaQuery.Instance.Update(_empresaInsert);
        if (update)
        {
            Message.MessageViewSuccess(@"Empresa actualizada correctamente");
            ClearText();
        }
        else
        {
            Message.MessageViewError(@"Error al actualizar la empresa");
        }

    }

    private void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarMunicipios();
    }

    private void comMunucipio_SelectedIndexChanged(object sender, EventArgs e)
    {
        CargarDistritos();
    }
    
    private void comboDistrito_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}