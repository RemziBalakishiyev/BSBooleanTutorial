using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00.Pracitce.AbstractPractice
{
    internal class DatabaseManager
    {
        public void SetConnectServer(Connection connection) // Connection connection = new MySql())
        {
            connection.Connect();
            Console.WriteLine(connection.GetConnection());
        }
    }


    interface IConnection
    {
        void Connect();

    }

    abstract class Connection
    {
        public string GetConnection() => "Server Connection";//
        public abstract void Connect();
    }


    class MySql:Connection
    {
        public override void Connect()
        {
            Console.WriteLine("MySql connected");
        }

        

    }

    class SqlServer : Connection
    {
        public override void Connect()
        {
            Console.WriteLine("SqlServer connected");
        }
        public string GetConnection() => "Server Connection";//
    }

    class Oracle : Connection
    {
        public override void Connect()
        {
            Console.WriteLine("Oracle connected");
        }

       

        public string GetConnection() => "Server Connection";//
    }

}
