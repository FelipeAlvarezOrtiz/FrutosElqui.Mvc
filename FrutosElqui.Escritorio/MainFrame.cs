using System.Windows.Forms;
using FrutosElqui.Negocio.Misc.Bancos;
using FrutosElqui.Persistencia;
using MediatR;

namespace FrutosElqui.Escritorio
{
    public partial class MainFrame : Form
    {
        protected IMediator Mediator;
        private readonly ApplicationDbContext _context;

        public MainFrame(IMediator mediator, ApplicationDbContext context)
        {
            Mediator = mediator;
            _context = context;
            InitializeComponent();
        }

        private async void button1_Click(object sender, System.EventArgs e)
        {
            var bancos = await Mediator.Send(new ListaDeBancos.Query());
            foreach (var banco in bancos)
            {
                MessageBox.Show(this,banco.NombreBanco,"El banco",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
