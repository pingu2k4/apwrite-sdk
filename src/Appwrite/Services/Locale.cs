
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Appwrite
{
    public class Locale : Service
    {
        public Locale(Client client) : base(client) { }

        /// <summary>
        /// Get User Locale
        /// <para>
        /// Get the current user location based on IP. Returns an object with user
        /// country code, country name, continent name, continent code, ip address and
        /// suggested currency. You can use the locale header to get the data in a
        /// supported language.
        /// 
        /// ([IP Geolocation by DB-IP](https://db-ip.com))
        /// </para>
        /// </summary>
        public Task<Models.Locale> Get()
        {
            var path = "/locale";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.Locale convert(Dictionary<string, object> it)
            {
                return Models.Locale.From(map: it);
            }

            return _client.Call<Models.Locale>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.Locale));
        }

        /// <summary>
        /// List Continents
        /// <para>
        /// List of all continents. You can use the locale header to get the data in a
        /// supported language.
        /// </para>
        /// </summary>
        public Task<Models.ContinentList> GetContinents()
        {
            var path = "/locale/continents";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.ContinentList convert(Dictionary<string, object> it)
            {
                return Models.ContinentList.From(map: it);
            }

            return _client.Call<Models.ContinentList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.ContinentList));
        }

        /// <summary>
        /// List Countries
        /// <para>
        /// List of all countries. You can use the locale header to get the data in a
        /// supported language.
        /// </para>
        /// </summary>
        public Task<Models.CountryList> GetCountries()
        {
            var path = "/locale/countries";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.CountryList convert(Dictionary<string, object> it)
            {
                return Models.CountryList.From(map: it);
            }

            return _client.Call<Models.CountryList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.CountryList));
        }

        /// <summary>
        /// List EU Countries
        /// <para>
        /// List of all countries that are currently members of the EU. You can use the
        /// locale header to get the data in a supported language.
        /// </para>
        /// </summary>
        public Task<Models.CountryList> GetCountriesEU()
        {
            var path = "/locale/countries/eu";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.CountryList convert(Dictionary<string, object> it)
            {
                return Models.CountryList.From(map: it);
            }

            return _client.Call<Models.CountryList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.CountryList));
        }

        /// <summary>
        /// List Countries Phone Codes
        /// <para>
        /// List of all countries phone codes. You can use the locale header to get the
        /// data in a supported language.
        /// </para>
        /// </summary>
        public Task<Models.PhoneList> GetCountriesPhones()
        {
            var path = "/locale/countries/phones";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.PhoneList convert(Dictionary<string, object> it)
            {
                return Models.PhoneList.From(map: it);
            }

            return _client.Call<Models.PhoneList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.PhoneList));
        }

        /// <summary>
        /// List Currencies
        /// <para>
        /// List of all currencies, including currency symbol, name, plural, and
        /// decimal digits for all major and minor currencies. You can use the locale
        /// header to get the data in a supported language.
        /// </para>
        /// </summary>
        public Task<Models.CurrencyList> GetCurrencies()
        {
            var path = "/locale/currencies";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.CurrencyList convert(Dictionary<string, object> it)
            {
                return Models.CurrencyList.From(map: it);
            }

            return _client.Call<Models.CurrencyList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.CurrencyList));
        }

        /// <summary>
        /// List Languages
        /// <para>
        /// List of all languages classified by ISO 639-1 including 2-letter code, name
        /// in English, and name in the respective language.
        /// </para>
        /// </summary>
        public Task<Models.LanguageList> GetLanguages()
        {
            var path = "/locale/languages";

            var parameters = new Dictionary<string, object?>()
            {
            };

            var headers = new Dictionary<string, string>()
            {
                { "content-type", "application/json" }
            };


            static Models.LanguageList convert(Dictionary<string, object> it)
            {
                return Models.LanguageList.From(map: it);
            }

            return _client.Call<Models.LanguageList>(
                method: "GET",
                path: path,
                headers: headers,
                parameters: parameters.Where(it => it.Value != null).ToDictionary(it => it.Key, it => it.Value)!,
                convert: convert,
                responseType: typeof(Models.LanguageList));
        }
    };
}