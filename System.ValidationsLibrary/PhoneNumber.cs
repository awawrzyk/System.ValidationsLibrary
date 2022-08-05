using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace System.ValidationsLibrary
{
    public static class PhoneNumber
    {
        static Regex regexPL = new Regex(@"(?<!\w)(\(?(\+|00)?48\)?)?[ -]?\d{3}[ -]?\d{3}[ -]?\d{3}(?!\w)");
        static Regex regexUS = new Regex(@"^\\(?([0-9]{3})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})$");
        static Regex regexUK = new Regex(@"^(((\+44\s?\d{4}|\(?0\d{4}\)?)\s?\d{3}\s?\d{3})|((\+44\s?\d{3}|\(?0\d{3}\)?)\s?\d{3}\s?\d{4})|((\+44\s?\d{2}|\(?0\d{2}\)?)\s?\d{4}\s?\d{4}))(\s?\#(\d{4}|\d{3}))?$");
        static Regex regexFR = new Regex(@"^(?:(?:\+|00)33[\s.-]{0,3}(?:\(0\)[\s.-]{0,3})?|0)[1-9](?:(?:[\s.-]?\d{2}){4}|\d{2}(?:[\s.-]?\d{3}){2})$");
        static Regex regexDE = new Regex(@"(\(?([\d \-\)\–\+\/\(]+){6,}\)?([ .\-–\/]?)([\d]+))");
        static Regex regexIN = new Regex(@"((\+*)((0[ -]*)*|((91 )*))((\d{12})+|(\d{10})+))|\d{5}([- ]*)\d{6}");
        static Regex regexBR = new Regex(@"\(([0-9]{2}|0{1}((x|[0-9]){2}[0-9]{2}))\)\s*[0-9]{3,4}[- ]*[0-9]{4}");
        static Regex regexAU = new Regex(@"(^1300\d{6}$)|(^1800|1900|1902\d{6}$)|(^0[2|3|7|8]{1}[0-9]{8}$)|(^13\d{4}$)|(^04\d{2,3}\d{6}$)");
        static Regex regexDN = new Regex(@"(^\+[0-9]{2}|^\+[0-9]{2}\(0\)|^\(\+[0-9]{2}\)\(0\)|^00[0-9]{2}|^0)([0-9]{9}$|[0-9\-\s]{10}$)");
        static Regex regexSW = new Regex(@"^(([+]\d{2}[ ][1-9]\d{0,2}[ ])|([0]\d{1,3}[-]))((\d{2}([ ]\d{2}){2})|(\d{3}([ ]\d{3})*([ ]\d{2})+))$");

        public static bool isValid(string countryCode, string phoneNumber)
        {
            Match checkPhoneNumber;

            countryCode=countryCode.ToUpper();  
            if(countryCode=="PL")
            {
                checkPhoneNumber=regexPL.Match(phoneNumber);
                if(checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            }
            else if(countryCode=="US")
            {
                checkPhoneNumber=regexUS.Match(phoneNumber);
                if(checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(countryCode=="UK")
            {
                checkPhoneNumber = regexUK.Match(phoneNumber);
                if (checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(countryCode=="FR")
            {
                checkPhoneNumber = regexFR.Match(phoneNumber);
                if (checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(countryCode=="DE")
            {
                checkPhoneNumber = regexDE.Match(phoneNumber);
                if (checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(countryCode=="IN")
            {
                checkPhoneNumber = regexIN.Match(phoneNumber);
                if (checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(countryCode=="BR")
            {
                checkPhoneNumber = regexBR.Match(phoneNumber);
                if (checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(countryCode=="AU")
            {
                checkPhoneNumber = regexAU.Match(phoneNumber);
                if (checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(countryCode=="DN")
            {
                checkPhoneNumber = regexDN.Match(phoneNumber);
                if (checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if(countryCode=="SW")
            {
                checkPhoneNumber = regexSW.Match(phoneNumber);
                if (checkPhoneNumber.Success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Incorrect country code!");
            }
            return false;
        }
    }
}
