namespace DemoConcurrencia
{
    public partial class FrmGestionImpresion : Form
    {
        private Queue<string> trabajos = new(); // Cola de trabajos
        private SemaphoreSlim semaforo = new(1); // Permite procesar un trabajo a la vez
        private object bloqueo = new(); // Objeto para sincronización

        public FrmGestionImpresion()
        {
            InitializeComponent();
        }

        private void BtnAgregarTrabajo_Click(object sender, EventArgs e)
        {
            string trabajo = TxtTrabajo.Text.Trim();
            if (!string.IsNullOrEmpty(trabajo))
            {
                lock (bloqueo)
                {
                    trabajos.Enqueue(trabajo); // Agregar trabajo a la cola
                    Monitor.Pulse(bloqueo); // Notificar que hay un nuevo trabajo disponible
                }
                ActualizarResultado($"Impresion agregada: {trabajo}");
                TxtTrabajo.Clear();
            }
            else
            {
                ActualizarResultado("Por favor, ingresa una Impresion válida.");
            }
        }

        private void BtnProcesarTrabajos_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                while (true)
                {
                    string trabajo = null;

                    lock (bloqueo)
                    {
                        while (trabajos.Count == 0)
                        {
                            ActualizarResultado("Esperando nuevas Impresiones...");
                            Monitor.Wait(bloqueo); // Esperar hasta que haya trabajos en la cola
                        }
                        trabajo = trabajos.Dequeue(); // Obtener el siguiente trabajo
                    }

                    semaforo.Wait(); // Esperar acceso al procesamiento
                    try
                    {
                        ProcesarTrabajo(trabajo); // Procesar el trabajo
                    }
                    finally
                    {
                        semaforo.Release(); // Liberar el acceso al procesamiento
                    }
                }
            });
        }

        private void ProcesarTrabajo(string trabajo)
        {
            ActualizarResultado($"Imprimiendo: {trabajo}");
            Thread.Sleep(2000); // Simula tiempo de procesamiento
            ActualizarResultado($"Impresion Exitosa: {trabajo}");
        }

        private void ActualizarResultado(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarResultado(mensaje)));
            }
            else
            {
                TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss}: {mensaje}{Environment.NewLine}");
            }
        }
    }
}
