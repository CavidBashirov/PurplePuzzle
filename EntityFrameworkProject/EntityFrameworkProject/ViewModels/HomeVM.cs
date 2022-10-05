using EntityFrameworkProject.Models;
using System.Collections.Generic;

namespace EntityFrameworkProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail SliderDetail { get; set; }
    }
}
