using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class AlarmClock
    {
        int seconds;//default 0
        int alarmSeconds;
        bool alarmOn;//default false
        
        public void SetTime(int hours, int minutes)
        {
            seconds = (hours * 3600 + minutes * 60);
        }
        public int GetTime()
        {
            return seconds;
        }
        public void SetAlarm(int hours, int minutes)
        {
            alarmSeconds = (hours * 3600 + minutes * 60);
        }
        public void TurnAlarmOn(bool alarmOn)
        {
            this.alarmOn = alarmOn;
        }
    }
}
    
