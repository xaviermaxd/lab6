using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<Estudiante> estudiantes1= new List<Estudiante>();
            for (int i = 0; i < 10; i++)
            {
                estudiantes1.Add(
                    new Estudiante
                    {
                        Nombres = "Nombres " + i.ToString(),
                        Apellidos = "Apellidos " + i.ToString(),
                        Edad = i,
                        Seccion = (i % 3 == 0) ? "A" : (i % 3 == 1) ? "B" : "C"
                    }
                    ); ;
            }
            

            var groupedStudents = estudiantes1.GroupBy(e => e.Seccion).Select(g => new GroupStudent<string, Estudiante>(g.Key, g));

            lvEstudiantes1.ItemsSource = groupedStudents;

        }
    }
}
