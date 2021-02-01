namespace Adobe.Target.Client.Util
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Adobe.Target.Client.Model;

    /// <summary>
    /// Cookie Utils
    /// </summary>
    internal static class CookieUtils
    {
        private const string CookieValueSeparator = "|";
        private const string InternalCookieSerializationSeparator = "#";
        private const int SessionIdCookieMaxAge = 1860;
        private const int DeviceIdCookieMaxAge = 63244800;
        private const int ClusterLocationHintMaxAge = 1860;

        /// <summary>
        /// Parse Target cookie
        /// </summary>
        /// <param name="targetCookie">Target cookie</param>
        /// <returns>Parsed Target cookies</returns>
        internal static Dictionary<string, string> ParseTargetCookie(string targetCookie)
        {
            if (string.IsNullOrEmpty(targetCookie))
            {
                return new Dictionary<string, string>();
            }

            var nowInSeconds = (int)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000);

            return targetCookie.Split(CookieValueSeparator)
                .TakeWhile(cookie => !string.IsNullOrEmpty(cookie))
                .Select(DeserializeInternalCookie)
                .Where(internalCookie => internalCookie != null && internalCookie.MaxAge > nowInSeconds)
                .ToDictionary(internalCookie => internalCookie.Name, internalCookie => internalCookie.Value);
        }

        /// <summary>
        /// Gets Location Hint from Tnt Id
        /// </summary>
        /// <param name="tntId">Tnt Id</param>
        /// <returns>Location hint</returns>
        internal static string LocationHintFromTntId(string tntId)
        {
            var parts = tntId.Split('.');
            if (parts.Length != 2)
            {
                return null;
            }

            var nodeDetails = parts[1].Split('_');
            return nodeDetails.Length != 2 ? null : nodeDetails[0];
        }

        internal static TargetCookie CreateTargetCookie(string sessionId, string deviceId)
        {
            var nowInSeconds = (int)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000);
            var targetCookieValue = new StringBuilder();
            long maxAge = 0;
            maxAge = CreateSessionId(sessionId, nowInSeconds, targetCookieValue, maxAge);
            maxAge = CreateDeviceId(deviceId, nowInSeconds, targetCookieValue, maxAge);
            var cookieValue = targetCookieValue.ToString();

            return string.IsNullOrEmpty(cookieValue) ? null : new TargetCookie(TargetConstants.MboxCookieName, cookieValue, (int)(maxAge / 1000));
        }

        internal static TargetCookie CreateClusterCookie(string tntId)
        {
            if (tntId == null)
            {
                return null;
            }

            var locationHint = LocationHintFromTntId(tntId);

            if (string.IsNullOrEmpty(locationHint))
            {
                return null;
            }

            var nowInSeconds = (int)(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() / 1000);
            long maxAge = nowInSeconds + ClusterLocationHintMaxAge;

            return new TargetCookie(TargetConstants.ClusterCookieName, locationHint, (int)(maxAge / 1000));
        }

        private static long CreateDeviceId(string deviceId, int nowInSeconds, StringBuilder targetCookieValue, long maxAge)
        {
            if (string.IsNullOrEmpty(deviceId))
            {
                return maxAge;
            }

            long deviceIdMaxAge = nowInSeconds + DeviceIdCookieMaxAge;
            maxAge = Math.Max(maxAge, deviceIdMaxAge);
            AppendCookieValue(deviceId, targetCookieValue, deviceIdMaxAge, TargetConstants.DeviceIdCookieName);

            return maxAge;
        }

        private static long CreateSessionId(string sessionId, int nowInSeconds, StringBuilder targetCookieValue, long maxAge)
        {
            if (string.IsNullOrEmpty(sessionId))
            {
                return maxAge;
            }

            long sessionIdMaxAge = nowInSeconds + SessionIdCookieMaxAge;
            maxAge = sessionIdMaxAge;
            AppendCookieValue(sessionId, targetCookieValue, sessionIdMaxAge, TargetConstants.SessionIdCookieName);

            return maxAge;
        }

        private static void AppendCookieValue(string id, StringBuilder targetCookieValue, long maxAge, string cookieName)
        {
            targetCookieValue.Append(cookieName)
                .Append(InternalCookieSerializationSeparator)
                .Append(id)
                .Append(InternalCookieSerializationSeparator)
                .Append(maxAge)
                .Append(CookieValueSeparator);
        }

        private static TargetCookie DeserializeInternalCookie(string cookie)
        {
            var cookieTokens = cookie.Split(InternalCookieSerializationSeparator);
            if (cookieTokens.Length != 3)
            {
                return null;
            }

            var maxAge = int.Parse(cookieTokens[2]);
            return new TargetCookie(cookieTokens[0], cookieTokens[1], maxAge);
        }
    }
}
