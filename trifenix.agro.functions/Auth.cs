﻿using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using trifenix.connect.aad.auth;
using trifenix.connect.interfaces.auth;

namespace trifenix.agro.functions
{
    public static class Auth {
        
        
        //Recibe como parametro una request http para validar el bearer token incluido en su cabecera
        //Retorna un conjunto de claims si posee token de acceso valido, de lo contrario retorna null
        public static async Task<ClaimsPrincipal> Validate(HttpRequest request) {
            
            string accessToken;
            ClaimsPrincipal authorize;
            IAuthentication auth = new Authentication(
                Environment.GetEnvironmentVariable("clientID", EnvironmentVariableTarget.Process),
                Environment.GetEnvironmentVariable("tenant", EnvironmentVariableTarget.Process),
                Environment.GetEnvironmentVariable("tenantID", EnvironmentVariableTarget.Process),
                Environment.GetEnvironmentVariable("validAudiences", EnvironmentVariableTarget.Process).Split(";")
            );
            //Console.WriteLine("El Token que recibo:");
            //Console.WriteLine(GetAccessToken(request));
            //Console.WriteLine("|-----------------|");
            if ((accessToken = GetAccessToken(request)) != null) {
                authorize = await auth.ValidateAccessToken(accessToken);
                if (authorize != null)
                    return authorize;
            }
            return null;
        }

        private static string GetAccessToken(HttpRequest req) {
            var authorizationHeader = req.Headers?["Authorization"];
            string[] parts = authorizationHeader?.ToString().Split(null) ?? new string[0];
            if (parts.Length == 2 && parts[0].ToLower().Equals("bearer"))
                return parts[1];
            return null;
        }

    }
}