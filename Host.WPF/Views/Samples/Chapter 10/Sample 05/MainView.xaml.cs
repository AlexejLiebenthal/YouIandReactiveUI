namespace Book.Views.Samples.Chapter10.Sample05
{
    using System.Reactive.Disposables;
    using ReactiveUI;
    using ViewModels.Samples.Chapter10.Sample05;

    public partial class MainView : ReactiveUserControl<MainViewModel>
    {
        public MainView()
        {
            InitializeComponent();

            this
                .WhenActivated(
                    disposables =>
                    {
                        this
                            .OneWayBind(this.ViewModel, x => x.Dinosaurs, x => x.dinosaursListBox.ItemsSource)
                            .DisposeWith(disposables);
                    });
        }
    }
}