using System;
using System.Windows.Forms;
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
        
    }

}
