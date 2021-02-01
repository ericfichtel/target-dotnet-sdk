namespace Adobe.Target.Client.Model
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using Adobe.Target.Client.Util;
    using Adobe.Target.Delivery.Model;

    /// <summary>
    /// Target Delivery request
    /// </summary>
    public class TargetDeliveryRequest
    {
        private TargetDeliveryRequest()
        {
        }

        private TargetDeliveryRequest(Builder builder)
        {
            this.DeliveryRequest = builder.DeliveryRequest;
            this.DecisioningMethod = builder.DecisioningMethod;
            this.SessionId = builder.SessionId;
            this.LocationHint = builder.LocationHint;
        }

        /// <summary>
        /// Delivery Request
        /// </summary>
        public DeliveryRequest DeliveryRequest { get; }

        /// <summary>
        /// Decisioning Method
        /// </summary>
        public DecisioningMethod? DecisioningMethod { get; }

        /// <summary>
        /// Session Id
        /// </summary>
        public string SessionId { get; }

        /// <summary>
        /// Location Hint
        /// </summary>
        public string LocationHint { get; }

        /// <summary>
        /// TargetDeliveryRequest Builder
        /// </summary>
        public sealed class Builder
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Builder"/> class.
            /// </summary>
            public Builder()
            {
                this.DeliveryRequest = new DeliveryRequest(null, null, null, default, null, null, new Context(ChannelType.Web));
            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Builder"/> class from a <see cref="DeliveryRequest"/> instance.
            /// </summary>
            /// <param name="deliveryRequest">Delivery request</param>
            public Builder(DeliveryRequest deliveryRequest)
            {
                this.DeliveryRequest = deliveryRequest;
            }

            /// <summary>
            /// Delivery request
            /// </summary>
            internal DeliveryRequest DeliveryRequest { get; }

            /// <summary>
            /// Session Id
            /// </summary>
            internal string SessionId { get; private set; }

            /// <summary>
            /// Location hint
            /// </summary>
            internal string LocationHint { get; private set; }

            /// <summary>
            /// Tracking Server
            /// </summary>
            internal string TrackingServer { get; set; }

            /// <summary>
            /// Tracking Server Secure
            /// </summary>
            internal string TrackingServerSecure { get; set; }

            /// <summary>
            /// Decisioning Method
            /// </summary>
            internal DecisioningMethod DecisioningMethod { get; set; }

            /// <summary>
            /// Request cookies
            /// </summary>
            internal CookieCollection Cookies { get; private set; } = new ();

            /// <summary>
            /// Third-party Id
            /// </summary>
            private string ThirdPartyId { get; set; }

            /// <summary>
            /// Tnt Id
            /// </summary>
            private string TntId { get; set; }

            /// <summary>
            /// Marketing Cloud Visitor Id
            /// </summary>
            private string MarketingCloudVisitorId { get; set; }

            /// <summary>
            /// Target Customer Ids
            /// </summary>
            private List<CustomerId> TargetCustomerIds { get; set; }

            /// <summary>
            /// Sets Request Id
            /// </summary>
            /// <param name="requestId">Request Id</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetRequestId(string requestId)
            {
                this.DeliveryRequest.RequestId = requestId;
                return this;
            }

            /// <summary>
            /// Sets Impression Id
            /// </summary>
            /// <param name="impressionId">Impression Id</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetImpressionId(string impressionId)
            {
                this.DeliveryRequest.ImpressionId = impressionId;
                return this;
            }

            /// <summary>
            /// Sets Environment Id
            /// </summary>
            /// <param name="environmentId">Environment Id</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetEnvironmentId(long environmentId)
            {
                this.DeliveryRequest.EnvironmentId = environmentId;
                return this;
            }

            /// <summary>
            /// Sets Property
            /// </summary>
            /// <param name="property">Property</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetProperty(Property property)
            {
                this.DeliveryRequest.Property = property;
                return this;
            }

            /// <summary>
            /// Sets Trace
            /// </summary>
            /// <param name="trace">Trace</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetTrace(Trace trace)
            {
                this.DeliveryRequest.Trace = trace;
                return this;
            }

            /// <summary>
            /// Sets Context
            /// </summary>
            /// <param name="context">Context</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetContext(Context context)
            {
                this.DeliveryRequest.Context = context;
                return this;
            }

            /// <summary>
            /// Sets Execute
            /// </summary>
            /// <param name="execute">Execute</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetExecute(ExecuteRequest execute)
            {
                this.DeliveryRequest.Execute = execute;
                return this;
            }

            /// <summary>
            /// Sets Prefetch
            /// </summary>
            /// <param name="prefetch">Prefetch</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetPrefetch(PrefetchRequest prefetch)
            {
                this.DeliveryRequest.Prefetch = prefetch;
                return this;
            }

            /// <summary>
            /// Sets Notifications
            /// </summary>
            /// <param name="notifications">Notifications</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetNotifications(List<Notification> notifications)
            {
                this.DeliveryRequest.Notifications = notifications;
                return this;
            }

            /// <summary>
            /// Sets Telemetry
            /// </summary>
            /// <param name="telemetry">Telemetry</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetTelemetry(Telemetry telemetry)
            {
                this.DeliveryRequest.Telemetry = telemetry;
                return this;
            }

            /// <summary>
            /// Sets QA Mode
            /// </summary>
            /// <param name="qaMode">QA Mode</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetQaMode(QAMode qaMode)
            {
                this.DeliveryRequest.QaMode = qaMode;
                return this;
            }

            /// <summary>
            /// Sets Session Id
            /// </summary>
            /// <param name="sessionId">SessionId</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetSessionId(string sessionId)
            {
                this.SessionId = sessionId;
                return this;
            }

            /// <summary>
            /// Sets Location Hint
            /// </summary>
            /// <param name="locationHint">Location Hint</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetLocationHint(string locationHint)
            {
                this.LocationHint = locationHint;
                return this;
            }

            /// <summary>
            /// Sets Id
            /// </summary>
            /// <param name="id">Id</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetId(VisitorId id)
            {
                this.DeliveryRequest.Id = id;
                return this;
            }

            /// <summary>
            /// Sets ExperienceCloud
            /// </summary>
            /// <param name="experienceCloud">Experience Cloud</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetExperienceCloud(ExperienceCloud experienceCloud)
            {
                this.DeliveryRequest.ExperienceCloud = experienceCloud;
                return this;
            }

            /// <summary>
            /// Sets Decisioning Method
            /// </summary>
            /// <param name="decisioningMethod">Decisioning Method</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetDecisioningMethod(DecisioningMethod decisioningMethod)
            {
                this.DecisioningMethod = decisioningMethod;
                return this;
            }

            /// <summary>
            /// Sets Cookies
            /// </summary>
            /// <param name="cookies">Cookies</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetCookies(CookieCollection cookies)
            {
                if (cookies == null || cookies.Count == 0)
                {
                    return this;
                }

                this.Cookies = cookies;
                return this;
            }

            /// <summary>
            /// Sets Third-party Id
            /// </summary>
            /// <param name="thirdPartyId">Third-party Id</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetThirdPartyId(string thirdPartyId)
            {
                this.ThirdPartyId = thirdPartyId;
                return this;
            }

            /// <summary>
            /// Sets Tnt Id
            /// </summary>
            /// <param name="tntId">Tnt Id</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetTntId(string tntId)
            {
                this.TntId = tntId;
                return this;
            }

            /// <summary>
            /// Sets Marketing Cloud Visitor Id
            /// </summary>
            /// <param name="marketingCloudVisitorId">Marketing Cloud Visitor Id</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetMarketingCloudVisitorId(string marketingCloudVisitorId)
            {
                this.MarketingCloudVisitorId = marketingCloudVisitorId;
                return this;
            }

            /// <summary>
            /// Sets Target Customer Ids
            /// </summary>
            /// <param name="customerIds">Target Customer Ids</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetTargetCustomerIds(List<CustomerId> customerIds)
            {
                this.TargetCustomerIds = customerIds;
                return this;
            }

            /// <summary>
            /// Sets Tracking Server
            /// </summary>
            /// <param name="trackingServer">Tracking Server</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetTrackingServer(string trackingServer)
            {
                this.TrackingServer = trackingServer;
                return this;
            }

            /// <summary>
            /// Sets Tracking Server Secure
            /// </summary>
            /// <param name="trackingServerSecure">Tracking Server Secure</param>
            /// <returns><see cref="Builder"/> instance</returns>
            public Builder SetTrackingServerSecure(string trackingServerSecure)
            {
                this.TrackingServerSecure = trackingServerSecure;
                return this;
            }

            /// <summary>
            /// Builds the <see cref="TargetDeliveryRequest"/>
            /// </summary>
            /// <returns>Built <see cref="TargetDeliveryRequest"/></returns>
            public TargetDeliveryRequest Build()
            {
                this.SetTargetValues();
                this.CreateVisitorId();
                return new TargetDeliveryRequest(this);
            }

            private void SetTargetValues()
            {
                var targetCookie = this.Cookies[TargetConstants.MboxCookieName]?.ToString();
                var targetCookies = CookieUtils.ParseTargetCookie(targetCookie);
                this.SetSessionId(targetCookies);
                this.SetTntId(targetCookies);
                this.SetEdgeCluster();
            }

            private void CreateVisitorId()
            {
                if (this.DeliveryRequest.Id != null)
                {
                    return;
                }

                if (string.IsNullOrEmpty(this.TntId) && string.IsNullOrEmpty(this.MarketingCloudVisitorId)
                                                     && string.IsNullOrEmpty(this.ThirdPartyId))
                {
                    return;
                }

                var visitorId = new VisitorId(this.TntId, this.ThirdPartyId, this.MarketingCloudVisitorId, this.TargetCustomerIds);

                this.DeliveryRequest.Id = visitorId;
            }

            private void SetSessionId(IReadOnlyDictionary<string, string> targetCookies)
            {
                if (!string.IsNullOrEmpty(this.SessionId))
                {
                    return;
                }

                if (targetCookies.TryGetValue(TargetConstants.SessionIdCookieName, out var cookieId) && cookieId.Length > 0)
                {
                    this.SessionId = cookieId;
                    return;
                }

                this.SessionId = Guid.NewGuid().ToString();
            }

            private void SetTntId(IReadOnlyDictionary<string, string> targetCookies)
            {
                if (!string.IsNullOrEmpty(this.TntId))
                {
                    return;
                }

                if (targetCookies.TryGetValue(TargetConstants.DeviceIdCookieName, out var cookieId) && cookieId.Length > 0)
                {
                    this.TntId = cookieId;
                }
            }

            private void SetEdgeCluster()
            {
                if (!string.IsNullOrEmpty(this.LocationHint))
                {
                    return;
                }

                this.LocationHint = this.Cookies[TargetConstants.ClusterCookieName]?.ToString();
            }
        }
    }
}
