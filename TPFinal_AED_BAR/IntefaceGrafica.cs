using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TPFinal_AED_BAR.EstruturasDeDados.Pilha;

namespace TPFinal_AED_BAR {
    class IntefaceGrafica:MarshalByRefObject {

        public delegate void SendDataHandler(long clientID, ref Pilha result);
        public static SendDataHandler DataSent;

        public Pilha Process(long clientID) {
                Pilha result = new Pilha();

                if(DataSent != null)
                    DataSent(clientID, ref result);

                return result;
            }
    }
}
