using System.Diagnostics;
using System.Runtime.InteropServices;

namespace KMTimer2
{
    internal partial class KMTimer2 : Form
    {
        PerformanceCounter cpu = new("Processor", "% Processor Time", "_Total");
        PerformanceCounter memory = new("Memory", "% Committed Bytes in Use");
        const int WM_SYSCOMMAND = 0x112;
        const int SC_MOVE = 0xF012;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        delegate void D_timer1_Tick();
        delegate void D_timer2_Tick();

        public KMTimer2()
        {
            InitializeComponent();
            TimeTick();
            InfoTick();
        }

        private void KMTimer2_Load(object sender, EventArgs e)
        {
            MouseDown += MoveForm;
            lblTime.MouseDown += MoveForm;
            lblCPU.MouseDown += MoveForm;
            lblMemory.MouseDown += MoveForm;
            lblDate.MouseDown += MoveForm;
            tsmiReset.Click += (s, e) =>
            {
                Location = new(0, 0);
            };
            tsmiClose.Click += (s, e) =>
            {
                Close();
            };
            Move += (s, e) =>
            {
                int screenRight = Screen.PrimaryScreen!.Bounds.Right;
                int screenBottom = Screen.PrimaryScreen!.Bounds.Bottom;
                int formRight = Left + Size.Width;
                int formBottom = Top + Size.Height;
                if (Math.Abs(screenRight - formRight) <= 20) Location = new(screenRight - Size.Width, Top);
                if (Math.Abs(Left) <= 20) Location = new(0, Top);
                if (Math.Abs(screenBottom - formBottom) <= 20) Location = new(Left, screenBottom - Size.Height);
                if (Math.Abs(Top) <= 20) Location = new(Left, 0);
            };
            var timer1 = new System.Timers.Timer(200)
            {
                Enabled = true
            };
            timer1.Elapsed += (s, e) => TimeTick();
            timer1.Start();
            var timer2 = new System.Timers.Timer(2000)
            {
                Enabled = true
            };
            timer2.Elapsed += (s, e) => InfoTick();
            timer2.Start();
        }

        void MoveForm(object? s, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _ = ReleaseCapture();
                _ = SendMessage(Handle, 161, 2, 0);
            }
        }

        void TimeTick()
        {
            if (InvokeRequired)
            {
                try
                {
                    var t1 = new D_timer1_Tick(TimeTick);
                    Invoke(t1);
                }
                finally { }
            }
            else
            {
                lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        void InfoTick()
        {
            if (InvokeRequired)
            {
                try
                {
                    var t1 = new D_timer2_Tick(InfoTick);
                    Invoke(t1);
                }
                finally { }
            }
            else
            {
                lblCPU.Text = $"CPU: {cpu.NextValue():n1}%";
                lblMemory.Text = $"Memory: {memory.NextValue():n0}%";
                lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd ddd");
            }
        }
    }
}
