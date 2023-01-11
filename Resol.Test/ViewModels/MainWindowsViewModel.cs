using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Resol.Test.Infrastructure.Commands;
using Resol.Test.Model;
using Resol.Test.ViewModels.Base;

namespace Resol.Test.ViewModels
{
    internal class MainWindowsViewModel : ViewModel
    {
        private string _title = "QuickPick";
       
        public string Title 
        { 
            get => _title;
            set => Set( ref _title, value );
        }
        
        public ObservableCollection<RoundButtonViewModel> RoundButtons { get; }


        #region Commands

        public ICommand CreateNewRoundButtonCommand { get; }

        private bool CanCreateNewRoundButtonCommandExecute(object p) => true;

        private void OnCreateNewRoundButtonCommandExecuted(object p)
        {
            RoundButtons.Insert(0,new RoundButtonViewModel(RoundButtons.Count.ToString()));
        }

        public ICommand RemoveRoundButtonCommand { get; }

        private bool CanRemoveRoundButtonCommandExecute(object p) => RoundButtons.Count > 0;

        private void OnRemoveRoundButtonCommandExecuted(object p)
        {
            RoundButtons.RemoveAt(0);
        }
       
        #endregion

        public MainWindowsViewModel()
        {
            CreateNewRoundButtonCommand = new RelayCommand(OnCreateNewRoundButtonCommandExecuted,
                CanCreateNewRoundButtonCommandExecute);
            RemoveRoundButtonCommand = new RelayCommand(OnRemoveRoundButtonCommandExecuted,
                CanRemoveRoundButtonCommandExecute);
            RoundButtons = new ObservableCollection<RoundButtonViewModel>(Enumerable.Range(1,10) .Select(rb => new RoundButtonViewModel(rb.ToString())));
        }
    }
}
