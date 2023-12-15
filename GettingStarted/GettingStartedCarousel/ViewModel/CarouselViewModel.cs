using Syncfusion.Maui.Carousel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedCarousel.ViewModel
{
    public class CarouselViewModel
    {
        public CarouselViewModel()
        {
            ImageCollection.Add(new SfCarouselItem() { ImageName = "image1.png" });
            ImageCollection.Add(new SfCarouselItem() { ImageName = "image2.png" });
            ImageCollection.Add(new SfCarouselItem() { ImageName = "image3.png" });
            ImageCollection.Add(new SfCarouselItem() { ImageName = "image4.png" });
            ImageCollection.Add(new SfCarouselItem() { ImageName = "image5.png" });
        }
        private List<SfCarouselItem> imageCollection = new List<SfCarouselItem>();
        public List<SfCarouselItem> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }
}
