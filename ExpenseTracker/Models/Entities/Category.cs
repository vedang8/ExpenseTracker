﻿namespace ExpenseTracker.Models.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Icon { get; set; }

        public List<Expense> Expenses { get; set; }
    }
}
