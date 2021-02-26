using Todo.Services;

namespace Todo.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(Database db)
            => List = new(db.GetItems());

        public TodoListViewModel List { get; }
    }
}
