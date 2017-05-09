using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Wpf;

namespace StressMeasurementSystem.ViewModels
{
    public abstract class AbstractPlotViewModel<T> where T : PlotModel, new()
    {
        protected AbstractPlotViewModel()
        {
            Title = typeof(T).Name;
            SeriesList = new List<DataPointSeries>();

            Plot = new T();
        }

        public string Title { get; }
        public IList<DataPointSeries> SeriesList { get; }

        protected T Plot { get; set; }
    }
}
