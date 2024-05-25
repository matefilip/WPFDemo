using WPFDemo.ViewModels;

namespace WPFDemo.Stores
{
    public class NavigationStore
    {
        public event Action? CurrentViewModelChanged;

        private ViewModelBase _currentViewModel = new();
        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                if (_currentViewModel != value)
                {
                    _currentViewModel = value;
                    OnCurrentViewModelChanged();
                }
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
