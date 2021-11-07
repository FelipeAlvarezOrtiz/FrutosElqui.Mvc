using System.Windows.Forms;
using MediatR;

namespace FrutosElqui.Escritorio.Formularios
{
    public partial class IngresarIngresoDinero : Form
    {
        private readonly IMediator _mediator;
        
        public IngresarIngresoDinero(IMediator mediator)
        {
            _mediator = mediator;
            InitializeComponent();
        }
    }
}
