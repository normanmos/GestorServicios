using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WindowsFormsApplication2.Mysql;
using System.Windows.Forms;
using System.Data;
using ProyectoISOO_.clases.MODELO;

namespace WindowsFormsApplication2
{
    class ventana
    {
        public static List<servicio> ObtenerServicios()
        {
            List<servicio> _lista = new List<servicio>();
            MySqlConnection conect = conexion.obtenerconexion(); 
            MySqlCommand _comando = new MySqlCommand("select idservicio , descripcion from servicio", conect);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                servicio pservicio = new servicio();
                pservicio.id = _reader.GetInt32(0);
                pservicio.descripcion = _reader.GetString(1);
                _lista.Add(pservicio);
            }
            conect.Close();
            return _lista;
        }

        public static List<departamento> ObtenerDepartamento()
        {
            List<departamento> _lista = new List<departamento>();
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand _comando = new MySqlCommand("select iddepartamento , descripcion from departamento", conect);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                departamento pdepartamento = new departamento();
                pdepartamento.id = _reader.GetInt32(0);
                pdepartamento.descripcion = _reader.GetString(1);
                _lista.Add(pdepartamento);
            }
            conect.Close();
            return _lista;
        }

        public static List<zona> ObtenerZonas()
        {
            List<zona> _lista = new List<zona>();
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand _comando = new MySqlCommand("select idzona , descripcion from zona", conect);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                zona pzona = new zona();
                pzona.id = _reader.GetInt32(0);
                pzona.descripcion = _reader.GetString(1);
                _lista.Add(pzona);
            }
            conect.Close();
            return _lista;
        }

        public static List<grupo> ObtenerGrupos()
        {
            List<grupo> _lista = new List<grupo>();
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand _comando = new MySqlCommand("select idgrupo , descripcion from grupo", conect);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                grupo pgrupo = new grupo();
                pgrupo.id = _reader.GetInt32(0);
                pgrupo.descripcion = _reader.GetString(1);
                _lista.Add(pgrupo);
            }
            conect.Close();
            return _lista;
        }

        public static List<usuario> ObtenerUsuarios()
        {
            List<usuario> _lista = new List<usuario>();
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand _comando = new MySqlCommand("select idusuario, concat(nombre,' ',apellido) as nombrecompleto from usuario;", conect);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                usuario pusuario = new usuario();
                pusuario.id = _reader.GetString(0);
                pusuario.nombre = _reader.GetString(1);
                _lista.Add(pusuario);
            }
            conect.Close();
            return _lista;
        }

        public static List<trabajo> ObtenerTrabajos()
        {
            List<trabajo> _lista = new List<trabajo>();
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand _comando = new MySqlCommand("select id_trabajo, razon from trabajo;", conect);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                trabajo ptrabajo = new trabajo();
                ptrabajo.id = _reader.GetInt32(0);
                ptrabajo.razon = _reader.GetString(1);
                _lista.Add(ptrabajo);
            }
            conect.Close();
            return _lista;
        }


        public static List<estado> ObtenerEstados()
        {
            List<estado> _lista = new List<estado>();
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand _comando = new MySqlCommand("select idcodigo_ejecucion, descripcion from codigo_ejecucion;", conect);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                estado pestado = new estado();
                pestado.id = _reader.GetInt32(0);
                pestado.descripcion = _reader.GetString(1);
                _lista.Add(pestado);
            }
            conect.Close();
            return _lista;
        }

        public static int Agregar (usuario_agenda pusuarioa)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into usuario_agenda (idusuario_agenda,id_creador, id_responsable, id_ejecutor, est_fecha_inicio, est_fecha_fin) values ('{0}','{1}','{2}','{3}', '{4}', '{5}')",
                pusuarioa.idusuario_agenda,pusuarioa.idusuario_creador,pusuarioa.idusuario_ejecutor, pusuarioa.idusuario_responsable, pusuarioa.fecha_inicio, pusuarioa.fecha_fin),conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
                return retorno;
        }

        public static int AgregarAgenda(agendar pagendar)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into agenda_mantenimiento (id_trabajo, detalle, id_servicio, id_usuario_agenda, id_departamento, id_zona, id_grupo_afectado, id_estado_ejecucion) values ('{0}', '{1}', '{2}',(select idusuario_agenda from usuario_agenda order by idusuario_agenda desc limit 1),'{3}','{4}','{5}','{6}')",
               pagendar.id_trabajo, pagendar.detalle, pagendar.id_servicio, 
               pagendar.id_departamento, pagendar.id_zona, pagendar.id_grupo, pagendar.id_estado),conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActulizarAgenda(agendar pagendar)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("update agenda_mantenimiento set id_estado_ejecucion = {0}, detalle = '{1}' where idagenda_mantenimiento = {2}" ,
              pagendar.id_estado , pagendar.detalle , pagendar.id_agenda ), conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }


        public static int EliminarAgenda(agendar pagendar)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("delete from agenda_mantenimiento where idagenda_mantenimiento = {0}",
               pagendar.id_agenda), conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }



        public void llenarGrid(DataGridView grid)       
        {
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand cmd = new MySqlCommand("select idagenda_mantenimiento as ID, detalle AS DETALLE, id_estado_ejecucion AS ESTADO from agenda_mantenimiento order by idagenda_mantenimiento desc;", conect);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            grid.DataSource = dt;
        }

        public void llenarGridUsuario(DataGridView grid)
        {
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand cmd = new MySqlCommand("select usuario.idusuario, usuario.contrasena, usuario.nombre, usuario.apellido, tipo_usuario.descripcion, departamento.descripcion from usuario, tipo_usuario, departamento where usuario.idtipo_usuario = tipo_usuario.idtipo_usuario and usuario.iddepartamento= departamento.iddepartamento;", conect);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            grid.DataSource = dt;
        }

        public static List<tipo_usuario> Obtenertipos()
        {
            List<tipo_usuario> _lista = new List<tipo_usuario>();
            MySqlConnection conect = conexion.obtenerconexion();
            MySqlCommand _comando = new MySqlCommand("select idtipo_usuario , descripcion from tipo_usuario", conect);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                tipo_usuario ptipo = new tipo_usuario();
                ptipo.id = _reader.GetInt32(0);
                ptipo.descripcion = _reader.GetString(1);
                _lista.Add(ptipo);
            }
            conect.Close();
            return _lista;
        }

        public static int EliminarUsuario(tipo_usuario ptipo)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("delete from tipo_usuario where idtipo_usuario = {0}",
               ptipo.id), conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int AgregarUsuario(usuario pusuario)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("insert into usuario values ('{0}', '{1}', '{2}','{3}','{4}','{5}')",
               pusuario.id, pusuario.contrasena, pusuario.nombre,
               pusuario.apellido, pusuario.id_tipo, pusuario.id_dpto), conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int ActulizarUsuario(usuario pusuario)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("update usuario set contrasena = '{0}', idtipo_usuario = '{1}', iddepartamento = '{2}' where idusuario = '{3}'",
              pusuario.contrasena, pusuario.id_tipo, pusuario.id_dpto, pusuario.id), conexion.obtenerconexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

    }
}
    

