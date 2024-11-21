namespace DemoConcurrencia
{
    public partial class FrmConcurrencia : Form
    {
        private CancellationTokenSource _cts;
        public FrmConcurrencia()
        {
            InitializeComponent();
        }

        private void BtnIniciarSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando procesos secuenciales...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                ActualizarResultado($" Actividad - Paso: {i + 1}");
            }

            ActualizarResultado("Fin del proceso secuencial.");
        }

        private void ActualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now: HH:mm:ss.fff}: {mensaje}{Environment.NewLine}");
        }

        private void BtnIniciarHilo_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread hilo1 = new Thread(() =>
            {
            try
            {
                ActualizarResultado($"Inciar nuevo thread {Thread.CurrentThread.ManagedThreadId}...");
                for (int i = 0; i < 5; i++)
                {
                    token.ThrowIfCancellationRequested();
                    Thread.Sleep(2000);
                    ActualizarResultado($" Actividad en hilo {Thread.CurrentThread.ManagedThreadId}: {i + 1}");
                }
                ActualizarResultado($"Thread {Thread.CurrentThread.ManagedThreadId} terminado.");
            
            }

            catch (OperationCanceledException)
                {
                    ActualizarResultado("Hilo Cancelado");
                }

            });
            hilo1.Start();
        }

        private async void BtnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
                {

                    try
                    {
                        ActualizarResultado($"Iniciando task {Task.CurrentId} ...");
                        for (int i = 0; i < 5; i++)
                        {
                            token.ThrowIfCancellationRequested();
                            Thread.Sleep(5000);
                            ActualizarResultado($"Actividad en tarea{Task.CurrentId} - Paso {i + 1}");
                        }

                        ActualizarResultado($"Task {Task.CurrentId} completada.");
                    }
                    catch (OperationCanceledException)
                    {

                        ActualizarResultado("Tarea Cancelada");
                    }
                    
                });
        }

        private void BtnCancelarHilo_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}
