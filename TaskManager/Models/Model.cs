using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    class Model
    {
        public DateTime StartDate { get; set; } = DateTime.Now;

        private bool _Status;

        public bool Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private string _Task;

        public string Task
        {
            get { return _Task; }
            set { _Task = value; }
        }
    }
}
