using PostSharp.Aspects;
using PostSharp.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileManagement.Logger;
using System.Windows.Forms;

namespace MobileManagement.UI.Aspects
{
    [PSerializable]
    public class ExceptionAspect : OnExceptionAspect
    {

        public override void OnException(MethodExecutionArgs args)
        {
            if (args.Exception != null)
            {
                Logging.Logger.Instance.LogError("Error occured. Message: " + args.Exception.Message);
                MessageBox.Show("Došlo je do greške u radu sustava. Pogledajte logove...", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            args.FlowBehavior = FlowBehavior.Return;
            args.ReturnValue = null;
        }
    }
}
