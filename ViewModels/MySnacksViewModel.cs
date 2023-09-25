using CommunityToolkit.Mvvm.ComponentModel;
using SnackerUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackerUI.ViewModels;

public partial class MySnacksViewModel : ObservableObject 
{
    [ObservableProperty]
    List<Snack> snacks;
}
