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

            //bienvenida & despedida
            pantallaBienvenida.BringToFront();
            pantallaDespedida.Hide();

            //Menus
            pantallaMenuRetiro.Hide();
            pantallaMenuTecnico.Hide();
            pantallaMenuAgente.Hide();
            pantallaMenuConsulta.Hide();

            //Retiro normal
            pantallaRetiroNormalP1.Hide();
            pantallaRetiroNormalP2.Hide();
            pantallaIngresoTarjeta.Hide();
            pantallaIngresoPin.Hide();

            //Retiro sin Tarjeta
            pantallaRetiroSinTarjetaP1.Hide();
            pantallaRetiroSinTarjetaP2.Hide();


            //Transiciones
            //menu de Retiro
            pantallaMenuRetiro.salirMenuRetiro += new EventHandler(switch_to_bienvenida);
            pantallaMenuRetiro.redIngresoTarjeta_MenuRetiro += new EventHandler(switch_to_ingreso_tarjeta);
            pantallaMenuRetiro.redIngresoSinTarjeta_MenuRetiro += new EventHandler(switch_to_retiro_sin_tarjeta);

            //menu de Consulta
            pantallaMenuConsulta.salirMenuConsulta += new EventHandler(switch_to_bienvenida);
            pantallaMenuConsulta.regresarMenuConsulta += new EventHandler(switch_to_menu_retiro);
            //pantallaMenuConsulta.redConsulta_MenuConsulta += new EventHandler();
            pantallaMenuConsulta.redRetiroP1_MenuConsulta += new EventHandler(switch_to_retiro_normal_1);

            //despedida 
            pantallaDespedida.despedidaTimeUp += new EventHandler(switch_to_bienvenida);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch_to_bienvenida(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch_to_retiro_normal_1(sender, e);

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
            pantallaIngresoTarjeta.Hide();
            pantallaIngresoPin.Hide();
        }

        //Transiciones

        //Bienvenida & Despedida
        public void switch_to_bienvenida(object sender, EventArgs e)
        {
            hide_all();
            pantallaBienvenida.Show();
            pantallaBienvenida.BringToFront();

        }
        private void switch_to_despedida()
        {

            hide_all();
            pantallaDespedida.Show();
            pantallaDespedida.BringToFront();

        }

        //Ingreso de Tarjeta & Pin
        public void switch_to_ingreso_tarjeta(object sender, EventArgs e)
        {
            hide_all();
            pantallaIngresoTarjeta.Show();
            pantallaIngresoTarjeta.BringToFront();

        }
        public void switch_to_ingreso_pin(object sender, EventArgs e)
        {
            hide_all();
            pantallaIngresoPin.Show();
            pantallaIngresoPin.BringToFront();

        }

        //Retiro Normal 
        public void switch_to_retiro_normal_1(object sender, EventArgs e)
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
        //Retiro Sin Tarjeta
        private void switch_to_retiro_sin_tarjeta(object sender, EventArgs e)
        {
            hide_all();
            pantallaRetiroSinTarjetaP1.Show();
            pantallaRetiroSinTarjetaP1.BringToFront();
        }

        //Menus
        private void switch_to_menu_retiro(object sender, EventArgs e)
        {
            hide_all();

            pantallaMenuRetiro.Show();
            pantallaMenuRetiro.BringToFront();
        }

        private void switch_to_menu_tecnico()
        {
            hide_all();
            pantallaMenuTecnico.Show();
            pantallaMenuTecnico.BringToFront();
        }

        private void switch_to_menu_consulta()
        {
            hide_all();
            pantallaMenuConsulta.Show();
            pantallaMenuConsulta.BringToFront();
        }

        //Botones 
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
            switch_to_menu_retiro(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            switch_to_menu_consulta();
        }
    }
}
