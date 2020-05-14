using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Constants.GeneralConstants
{
    public static class GeneralApiConstants
    {
        public const string Configuration_Policy = "Policy";
        public const string Configuration_DbConnection = "AppDbConnection";
        public const string Configuration_SwaggerDoc = "Swagger:Doc";
        public const string Configuration_SwaggerEndpoint = "Swagger:Endpoint";

        public const string AuthenticationOptions = "AuthenticationOptions";

        public const string Token = "Token";
        public const string Bearer = "Bearer";
        public const string RefreshToken = "RefreshToken";

        public const string SwaggerApiTitle = "ExLibris API";
        public const string SwaggerApiVersion = "v1";
        public const string SwaggerApiSecuritySchemeDescription = "JWT Authorization header using the Bearer scheme. " +
            "Example: \"Authorization: Bearer {token}\"";

        public const string SwaggerApiSecuritySchemeName = "Authorization";
        public const string SwaggerApiSecurityScheme = "oauth2";
    }
}
