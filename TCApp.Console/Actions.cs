using CLAP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCApp.WebServices.SubmitResumeWebService;

namespace TCApp.Cmd
{
    class Actions
    {
        SubmitResumeSoapClient client = new SubmitResumeSoapClient();

        [Verb]
        void GetInstructions()
        {
            Console.WriteLine("INSTRUCTIONS.. SHOULD YOU CHOOSE TO ACCEPT:\n\n{0}", client.GetInstructions());
        }

        [Verb]
        void SubmitInformation([Required]string fname, [Required]string lname, [Required]string email, [Required]string phone)
        {
            var furtherInstructions = client.SubmitInformation(fname, lname, email, phone);
            Console.WriteLine("FURTHER INSTRUCTIONS... SHOULD YOU CHOOSE TO ACCEPT:\n\n{0}", furtherInstructions);
        }
    }
}
