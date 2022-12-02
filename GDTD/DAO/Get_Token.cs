using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GDBH.DAO
{
    public class Get_Token
    {
        [JsonProperty("maKetQua")]
        public string MaKetQua { get; set; }

        [JsonProperty("APIKey")]
        public List<_APIKey> APIKey { get; set; }
    }

    public class _APIKey
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("id_token")]
        public string IdToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("expires_in")]
        public DateTime ExpiresIn { get; set; }
    }
}
