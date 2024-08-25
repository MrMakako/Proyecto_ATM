namespace Proyecto_ATM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pantallaMenuRetiro.cambiarPantallita += new EventHandler(transicion_a_retiro_sinTarjeta);
            pantallaRetiroSinTarjetaP11.cambioPt2 += new EventHandler(transicion_a_retiro_sinTarjetaP2);
            pantallaRetiroSinTarjetaP11.cambioMenuRetiro += new EventHandler(transicion_a_menuRetiro);
            pantallaSaldo1.cambiarEspera += new EventHandler(cambiar_a_espera);

            pantallaBienvenida.BringToFront();
            pantallaDespedida.Hide();
            pantallaMenuRetiro.Hide();
            pantallaRetiroNormalP1.Hide();
            pantallaRetiroNormalP2.Hide();
            pantallaMenuTecnico.Hide();

            pantallaDespedida.OnTimeout = switch_to_bienvenida;
        }

        protected void cambiar_a_espera(object sender, EventArgs e) {

            pantallaSaldo1.Hide();
            pantallaBienvenida.BringToFront();
            pantallaBienvenida.Show();

        }

        protected void transicion_a_retiro_sinTarjetaP2(object sender, EventArgs e)
        {
            pantallaRetiroSinTarjetaP11.Hide();
            pantallaRetiroSinTarjetaP21.BringToFront();
            pantallaRetiroSinTarjetaP21.Show();

            // pantallaRetiroSinTarjetaP1.BringToFront();
            // pantallaRetiroSinTarjetaP1.Show();
        }

        protected void transicion_a_menuRetiro(object sender, EventArgs e)
        {
            
            pantallaRetiroSinTarjetaP11.Hide();
            pantallaMenuRetiro.BringToFront();
            pantallaMenuRetiro.Show();

            // pantallaRetiroSinTarjetaP1.BringToFront();
            // pantallaRetiroSinTarjetaP1.Show();
        }

        protected void transicion_a_retiro_sinTarjeta(object sender, EventArgs e)
        {
            pantallaMenuRetiro.Hide();
            pantallaRetiroSinTarjetaP11.BringToFront();
            pantallaRetiroSinTarjetaP11.Show();

            // pantallaRetiroSinTarjetaP1.BringToFront();
            // pantallaRetiroSinTarjetaP1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch_to_bienvenida();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch_to_retiro_normal_1();

        }

        /// <summary>
        /// Esta funcion hace qu todas las pantallas se oculten
        /// </summary>
        private void hide_all()
        {

            pantallaDespedida.Hide();
            pantallaMenuRetiro.Hide();
            pantallaRetiroNormalP1.Hide();
            pantallaRetiroNormalP2.Hide();
            pantallaMenuTecnico.Hide();
            pantallaBienvenida.Hide();
        }
        public void switch_to_bienvenida()
        {
            hide_all();
            pantallaBienvenida.Show();
            pantallaBienvenida.BringToFront();

        }

        private void switch_to_menu_tecnico()
        {
            hide_all();
            pantallaMenuTecnico.Show();
            pantallaMenuTecnico.BringToFront();



        }

        public void switch_to_retiro_normal_1()
        {
            hide_all();
            pantallaRetiroNormalP1.Show();
            pantallaRetiroNormalP1.BringToFront();
        }
        private void switch_to_retiro_normal_2()
        {

            hide_all();
            pantallaRetiroNormalP2.Show();
            pantallaRetiroNormalP2.BringToFront();


        }
        private void switch_to_despedida()
        {

            hide_all();
            pantallaDespedida.Show();
            pantallaDespedida.BringToFront();

        }
        private void switch_to_menu_retiro()
        {
            hide_all();

            pantallaMenuRetiro.Show();
            pantallaMenuRetiro.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch_to_despedida();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch_to_retiro_normal_2();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch_to_menu_tecnico();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch_to_menu_retiro();
        }
    }
}
