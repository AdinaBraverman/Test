using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace DAL
{
    public class DonationDAL
    {
        private static Donation[] donation;
        public static IEnumerable<Donation> GetAllDonation()
        {
            donation = new Donation[3];
            donation[0] = new Donation("ישות 1", 100, 1, "חופשית", "מגיע הכל לנתמך", 1, 3.2);
            donation[1] = new Donation("ישות 2", 200, 2, "דינאמית", "אין תנאים", 2, 3.2);
            donation[2] = new Donation("ישות 3", 300, 3, "חופשית", "באישורי", 1, 3.2);
            return donation;
        }

        public static void SaveNewDonation(Donation donation)
        {
            
        }
    }
}
