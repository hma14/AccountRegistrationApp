using AccountRegistrationApp.AccountWS;
using Microsoft.Owin.Security;
using System;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;


namespace AccountRegistrationApp.Controllers
{
    public class HomeController : Controller
    {
        private AccountServiceClient svcClient;
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(string userId, string password)
        {
            AccountInfo info = new AccountInfo();
            
            if (ModelState.IsValid)
            {                
                info.userid = userId;
                info.password = password;                
                try {
                    using (svcClient = new AccountServiceClient())
                    {
                        if (svcClient.Authenticate(info))
                        {
                            Session["IsAuthenticated"] = true;
                            Session["User"] = userId;
                            return View("LoggedIn");
                        }
                    }                       
                }
                catch (FaultException<AccountServiceFault> ex)
                {
                    HandleErrorInfo errorInfo = new HandleErrorInfo(ex, "Home", "Login");
                    return View("Error", errorInfo);
                }

            }
            ViewBag.LoginFailed = "Oops... user credential is not matched, please try again!";
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Register(string userId, string password, string firstName, string lastName)
        {
            AccountInfo info = new AccountInfo ();
            if (ModelState.IsValid)
            {
                info.userid = userId;
                info.password = password;
                info.firstname = firstName;
                info.lastname = lastName;
                try {
                    using (svcClient = new AccountServiceClient())
                    {
                        if (svcClient.CreateAccount(info))
                        {
                            return View("Index");
                        }
                    }             
                }
                catch (FaultException<AccountServiceFault> ex)
                {
                    HandleErrorInfo errorInfo = new HandleErrorInfo(ex, "Home", "Register");
                    return View("Error", errorInfo);
                }
            }
            ViewBag.RegistionFailed =  String.Format("Oops... user id: {0}  already exists, please choose another one!", userId);
            return View();
        }

        public ActionResult LoggedIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogOff()
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            Session["IsAuthenticated"] = false;
            return RedirectToAction("Index", "Home");
        }



        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
#if false
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
#endif
    }

}