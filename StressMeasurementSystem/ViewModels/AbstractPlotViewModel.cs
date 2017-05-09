using System.Collections.Generic;
using OxyPlot;
using OxyPlot.Wpf;

namespace StressMeasurementSystem.ViewModels
{
    public abstract class AbstractPlotViewModel
    {
        protected PlotModel PlotModel { get; set; }
        protected List<DataPointSeries> SeriesList { get; set; }

        protected AbstractPlotViewModel()
        {
            PlotModel = new PlotModel();
            SeriesList = new List<DataPointSeries>();
        }
    }
}
