using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceVsAbstractSample
{
    public abstract class BasicFunctionality
    {
        public abstract void Incoming();

        public abstract void Outgoing();

        public void NormalFunction()
        {

        }

        public virtual void Keypad()
        {

        }
    }
    public class IPhone : BasicFunctionality, IDbHandshake
    {
        public void CreateConnectionString()
        {
            throw new NotImplementedException();
        }

        public override void Incoming()
        {
            //Apple style incoming
        }

        public override void Outgoing()
        {
            //Apple style outgoing
        }

        public void PassCredential()
        {
            throw new NotImplementedException();
        }

        public void TestConnection()
        {
            throw new NotImplementedException();
        }
    }

    public interface IDbHandshake
    {
        void CreateConnectionString();

        void PassCredential();

        void TestConnection();
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
