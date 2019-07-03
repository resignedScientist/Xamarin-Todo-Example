﻿using System;
using ToDo.DataStore;

namespace ToDo.Pages.ToDoView.ViewModels
{
    public class TodoViewViewModel
    {
        public ToDoItem Item { get; }

        public string DoneButtonTitle => Item.IsChecked ? "Doch nicht erledigt" : "Erledigt";

        public TodoViewViewModel(ToDoItem item)
        {
            Item = item;
        }
    }
}