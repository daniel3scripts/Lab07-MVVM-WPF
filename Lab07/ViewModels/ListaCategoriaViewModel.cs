using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Windows;

namespace Lab07.ViewModels
{
    public class ListaCategoriaViewModel: ViewModelBase
    {
        public ObservableCollection<Categoria> Categorias { get; set; }

        public ICommand NuevoComand { set;get; }

        public ICommand ConsultarComand { set; get; } 
        
        public ListaCategoriaViewModel()
        {
            Categorias = new Models.CategoriaModel().Categorias;

            NuevoComand = new RelayCommand<Window>(
                param => Abrir()
            );

            ConsultarComand = new RelayCommand<object>(
                o => { Categorias = (new Models.CategoriaModel()).Categorias; }
                );
            void Abrir()
            {
                Views.ManCategoria window = new Views.ManCategoria();
                window.ShowDialog();
            }
        }

    }
}
