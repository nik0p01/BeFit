using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit
{

//    Напишите простой класс асинхронной обработки задач.Класс должен иметь метод для добавления задач, принимающий объекты типа Task:
//public delegate void Task();
//    Задачи должны выполняться последовательно.Также должна быть возможность дождаться окончания выполнения всех заданий.


    public class TaskHandler
    {
        public delegate void MyTask();

        private MyTask? _task;
        private Task? _result;

        public void AddTask(MyTask task)
        {
            if (task == null)
                _task = task;
            else
                _task += task;
        }

        public void BeginInvoke()
        {
            _result = Task.Run(() => _task?.Invoke());
        }

        public async Task EndInvoke()
        {
            if (_result != null)
            {
                await _result;
            }
        }
    }
}
