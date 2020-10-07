using System;
using System.ComponentModel;

namespace TaskManager.Models
{
    class Model : INotifyPropertyChanging
    {
        public DateTime StartDate { get; set; } = DateTime.Now;

        private bool _Status;
        private string _Task;

        public bool Status
        {
            get { return _Status; }
            set
            {
                if (_Status == value)
                    return;
                _Status = value;
                OnPropertyChanging("Status");
            }
        }



        public string Task
        {
            get { return _Task; }
            set
            {
                if (_Task == value)
                    return;
                _Task = value;
                OnPropertyChanging("Task");
            }
        }

        public event PropertyChangingEventHandler PropertyChanging;

        protected virtual void OnPropertyChanging(string propertyName = "")
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
        }
    }
}
