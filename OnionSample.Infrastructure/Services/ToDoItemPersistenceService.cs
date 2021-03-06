﻿using OnionSample.Application.Interfaces;
using OnionSample.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnionSample.Infrastructure.Persistence.Services
{
    internal class ToDoItemPersistenceService : IToDoItemPersistenceService
    {
        private readonly ToDoContext _context;

        public ToDoItemPersistenceService(ToDoContext context)
        {
            _context = context;
        }

        public void Save(ToDoItem item)
        {
            _context.ToDoItems.Add(item);

            _context.SaveChanges();
        }

        public IEnumerable<ToDoItem> GetToDoItems()
        {
            return _context.ToDoItems;
        }

        public ToDoItem GetToDoItem(DateTime eventDateTime)
        {
            return _context.ToDoItems.FirstOrDefault(t =>
                t.EventDateTime.Hour == eventDateTime.Hour && t.EventDateTime.Day == eventDateTime.Day && t.EventDateTime.Year == eventDateTime.Year);
        }
    }
}
