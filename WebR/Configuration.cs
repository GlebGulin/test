using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebR
{
    public static class Configuration
    {
        /*Settings for sending email 1*/
        public static string NameFrom = "JsonSender";
        public static string MailFrom = "yourmail";
        public static string MailPass = "yourpass";
        public static string Smtp = "smtp.gmail.com";
        public static string MailTo = "hannah.petrova@gmail.com";
        public static int Port = 25;
        /*Settings for sending email 2*/
        public static string NameFrom2 = "JsonSender";
        public static string MailFrom2 = "yourmail";
        public static string MailPass2 = "yourpass";
        public static string Smtp2 = "smtp.gmail.com";
        public static string MailTo2 = "yourmail";
        public static int Port2 = 25;
        /*Settings for TelegramBot*/
       
        public static string NameChanelOne { get; set; } = "@test_task";
        public static string ApiKEY { get; set; } = "975305099:AAErrElJHG6z0sVUksa64X0O5NnT2XUDnNk";
        public static string NameChanelTwo { get; set; } = "@test2_test";
        public static string ApiKEY2 { get; set; } = "919193081:AAEhC_f9XgVCACGpn1bWxCRDrx3fXU3AXPs";
        

    }
}
