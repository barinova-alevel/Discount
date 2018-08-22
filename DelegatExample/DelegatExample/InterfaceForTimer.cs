using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatExample
{
    public interface ITimer
    {
        /// <summary>
        /// Pass minutes when alarm will be rised
        /// example: SetAlarm(30) will rize alarm in 30 minutes
        /// </summary>
        /// <param name="minutes"></param>
        void SetAlarm(int minutes);

        /// <summary>
        /// Print out time in nice format
        /// </summary>
        void ShowCurrentTime();
    }
    private void Counter()
    {
        Task.Factory.StartNew(() =>
        {
            do
            {
                //Sleep for one second
                Thread.Sleep(1000);
                //And increment our inner counter
                _currentTime += 1;

                if (_alarmTime == _currentTime) OnAlarm?.Invoke();
            } while (true);
        });
    }
}
