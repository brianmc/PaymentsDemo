using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PaymentsDemo.Controllers
{
    public class ProviderController : Controller
    {
        //
        // GET: /Provider/

        public ActionResult Stripe()
        {
            return View();
        }

        public async Task<ActionResult> StripeCharge(String stripeToken)
        {
            String api_key = "sk_test_wBSn2SRAu2uWr1BqZsX42TA0";

            StringContent chargeData = new StringContent(String.Format("amount=400&currency=usd&card={0}&description=\"Charge from Brian\"",stripeToken));

            HttpClient restClient = new HttpClient();

            // Post charge data
            restClient.DefaultRequestHeaders.Add("Authorization", "Basic "+api_key);

           var result = await restClient.PostAsync("https://api.stripe.com/v1/charges", chargeData); 

            return View();
        }

    }
}
