using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace BL
{
    public class DonationBl
    {
        public static IEnumerable<Donation> GetAllDonation()
        {
            return DonationDAL.GetAllDonation();
        }

        public static void SaveNewDonation(Donation donation)
        {
            //if(donation.Pricing>10000)
              //  await Utils.MailService.SendEmailAsync(new Utils.MailRequest("adina8519753@gmail.com", "try", "help"));
            DonationDAL.SaveNewDonation(donation);
        }
    }
}
