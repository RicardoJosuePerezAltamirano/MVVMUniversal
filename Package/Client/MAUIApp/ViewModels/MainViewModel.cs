using Sysne.Core.MVVM;
using Sysne.Core.MVVM.Patterns;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MAUIApp.ViewModels
{
    public class MainViewModel:ViewModelWithBL<ViewModelWithBL<DemoBL>>
    {
        private string mensaje;
        
        public string Message { get => mensaje; set => Set(ref mensaje, value); }
        public MainViewModel()
        {
            Message = "MAUI usando MVVM Universal desde nugets de pollo";
        }
        
    }
}
