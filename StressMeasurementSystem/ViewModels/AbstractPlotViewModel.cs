using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Wpf;

namespace StressMeasurementSystem.ViewModels
{
    public abstract class AbstractPlotViewModel<T> where T : PlotModel, new()
    {
        protected AbstractPlotViewModel()
        {
            Plot = new T();

            Title = Plot.Title;
            SeriesList = new List<DataPointSeries>();
        }

        public string Title { get; }
        public IList<DataPointSeries> SeriesList { get; }

        protected T Plot { get; set; }
    }
}
