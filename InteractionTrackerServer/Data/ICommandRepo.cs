﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalkDeskInterviewApp.Models;

namespace TalkDeskInterviewApp.Data
{
    public interface ICommandRepo
    {
        IQueryable<Command> GetAllCommands();
        Task<Command> GetCommandById(int id);
        void CreateCommand(Command command);
        void UpdateCommand(Command command);
        void DeleteCommand(Command command);
        Task<bool> SaveChanges();
    }
}
