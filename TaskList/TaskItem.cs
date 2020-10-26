using System;

namespace TaskList
{
    internal class TaskItem
    {
        public TaskItem(string v1, string v2, DateTime dateTime)
        {
        }

        public object Description { get; internal set; }
        public object DueDate { get; internal set; }
        public object TaskOwner { get; internal set; }
        public bool Complete { get; internal set; }
    }
}