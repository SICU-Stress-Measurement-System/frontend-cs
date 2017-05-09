namespace StressMeasurementSystem.ViewModels
{
    public class TemporalPlotViewModel : AbstractPlotViewModel
    {
        public TemporalPlotViewModel()
        {
            PlotModel = new TemporalPlot();  //TODO: Create TemporalPlot model
            Title = GetType().Name;
        }

        public string Title { get; }
    }
}
