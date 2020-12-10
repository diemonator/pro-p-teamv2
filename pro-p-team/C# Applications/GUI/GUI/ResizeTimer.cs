using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public class ResizeTimer
    {
        private static System.Timers.Timer _timer;
        private static PictureBox[] tempArrayHolder;
        private static PictureBox picuture;
        private static Image[] frame;
        private static int counte = 0;
        private static int tick = 0;
        private static bool TimerEnable = false;
        private static bool TimerEnableSwitch = false;
        private static short counter = 0;
        private static short counterIncrement = 120;
        private static int listBoxY;
        private static ListBox lb;
        public ResizeTimer(ListBox listbox)
        {
            lb = listbox;
            listBoxY = listbox.Location.Y;
            _timer = new System.Timers.Timer(0.1);
            _timer.AutoReset = true;
        }
        public ResizeTimer()
        {      
            _timer = new System.Timers.Timer(0.1);
            _timer.AutoReset = true;
        }
        public void StartTimerButtonAnim(PictureBox[] array)
        { 
            if (!TimerEnable)
            {
                _timer.Elapsed += timer_TickButtons;
                TimerEnable = true;
                tempArrayHolder = array;
                for (int i = 0; i < tempArrayHolder.Length; i++)
                {
                    _timer.SynchronizingObject = tempArrayHolder[i];
                    tempArrayHolder[i].Height = 0;
                    tempArrayHolder[i].Width = 0;
                }
                counte = 0;
                tick = 0;
                _timer.Start();
            }
        }
        public void StartTimerSuccessAnim(PictureBox pb, Image[] frames)
        {
            if (!TimerEnable)
            {
                frame = frames;
                picuture = pb;
                _timer.Elapsed += timer_TickSuccess;
                TimerEnable = true;
                counte = 0;
                tick = 0;
                _timer.SynchronizingObject = picuture;
                _timer.Start();
            }
        }
        public void StartTimerListBoxAnim()
        {
            if (!TimerEnableSwitch)
            {
                _timer.Elapsed += timer_moveDownListBox;
                TimerEnableSwitch = true;
                _timer.SynchronizingObject = lb;
                counte = 0;
                tick = 0;
                _timer.Start();
            }
            else
            {
                _timer.Elapsed += timer_moveUpListBox;
                TimerEnableSwitch = false;
                counte = 0;
                tick = listBoxY;
                _timer.SynchronizingObject = lb;
                _timer.Start();
            }
        }
        public void StartTimerResizeAnim(PictureBox[] array)
        {
            try
            {
                if (!TimerEnableSwitch)
                {
                    tempArrayHolder = array;
                    _timer.Elapsed += timer_moveLeft;
                    TimerEnableSwitch = true;
                    for (int i = 0; i < tempArrayHolder.Length; i++)
                        _timer.SynchronizingObject = tempArrayHolder[i];
                    counter = 0;
                    counte = 0;
                    tick = 0;
                    _timer.Start();
                }
                else
                {
                    tempArrayHolder = array;
                    _timer.Elapsed += timer_moveRight;
                    TimerEnableSwitch = false;
                    for (int i = 0; i < tempArrayHolder.Length; i++)
                        _timer.SynchronizingObject = tempArrayHolder[i];
                    counter = 0;
                    counte = 0;
                    tick = 0;
                    _timer.Start();
                }
            }
            catch (System.Exception)
            {

            }
            
        }
        private static void timer_TickButtons(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (counte == tempArrayHolder.Length)
            {
                _timer.Stop();
                counte = 0;
                tick = 0;
                TimerEnable = false;
                _timer.Elapsed -= timer_TickButtons;
            }
            else if (tick < 120)
            {
                tempArrayHolder[counte].Height = tick;
                tempArrayHolder[counte].Width = tick;
                tick += 30;
            }
            else
            {
                counte++;
                tick = 0;
            }
        }
        private static void timer_TickSuccess(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (counte >= frame.Length)
            {
                _timer.Stop();
                counte = 0;
                picuture.Visible = false;
                picuture.Enabled = false;
                TimerEnable = false;
                _timer.Elapsed -= timer_TickSuccess;
            }
            else
            {
                picuture.Image = frame[counte];
                counte++;
            }
        }
        private void timer_moveLeft(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (tick >= 0)
            {
                tempArrayHolder[counte].Location = new Point(tick, tempArrayHolder[counte].Location.Y);
                tick -= 200;
            }
            else
            {
                counte++;
                tick = 1000;
            }
            if (counte == tempArrayHolder.Length)
            {
                _timer.Stop();
                counte = 0;
                tick = 0;
                TimerEnableSwitch = true;
                StartTimerListBoxAnim();
                _timer.Elapsed -= timer_moveLeft;
            }
        }
        private void timer_moveRight(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (counte == tempArrayHolder.Length)
            {
                _timer.Stop();
                counte = 0;
                tick = 0;
                TimerEnableSwitch = false;
                StartTimerListBoxAnim();
                _timer.Elapsed -= timer_moveRight;
            }
            else if (tick <= 1000 + counter)
            {
                tempArrayHolder[counte].Location = new Point(tick, tempArrayHolder[counte].Location.Y);
                tick += 120;
            }
            else
            {
                counte++;
                tick = 0;
                counter += counterIncrement;
                if (Animation.IsFourth(counte))
                {
                    counter = 0;
                }
            }
        }
        private static void timer_moveUpListBox(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (tick >= 100)
            {
                lb.Location = new Point(lb.Location.X, (tick));
                lb.Height += 100;
                lb.Update();
                tick -= 100;
            }
            else
            {
                _timer.Stop();
                TimerEnableSwitch = true;
                _timer.Elapsed -= timer_moveUpListBox;
                tick = 0;
            }

        }
        private static void timer_moveDownListBox(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (tick < listBoxY)
            {
                lb.Location = new Point(lb.Location.X, tick);
                lb.Height -= 52;
                lb.Update();
                tick += 81;
            }
            else
            {
                _timer.Stop();
                TimerEnableSwitch = false;
                lb.Height = 50;
                _timer.Elapsed -= timer_moveDownListBox;
                tick = 0;
            }

        }
    }
}