﻿using log4net;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PayWithAmazon.ProviderCreditRequests
{
    /// <summary>
    /// Request class to set the GetProviderCreditReversalDetails API call parameters
    /// </summary>
    public class GetProviderCreditReversalDetailsRequest
    {
        
        private string action;
        private string merchant_id;
        private string amazon_provider_credit_reversal_id;
        private string mws_auth_token;
        private ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public GetProviderCreditReversalDetailsRequest()
        {
            log4net.Config.XmlConfigurator.Configure();
            log.Debug("METHOD__GetProviderCreditReversalDetailsRequest Constructor | MESSAGE__Constructor Initiate");
            this.action = Constants.GetProviderCreditReversalDetails;
            log.Debug("METHOD__GetProviderCreditReversalDetailsRequest | MESSAGE__Action: " + this.action);
        }
        public string GetAction()
        {
            return this.action;
        }

        /// <summary>
        /// Sets the Merchant ID
        /// </summary>
        /// <param name="merchant_id"></param>
        /// <returns>GetProviderCreditReversalDetailsRequest Object</returns>
        public GetProviderCreditReversalDetailsRequest WithMerchantId(string merchant_id)
        {
            this.merchant_id = merchant_id;
            log.Debug("METHOD__WithMerchantId | MESSAGE__merchant_id: " + this.merchant_id);
            return this;
        }
        public string GetMerchantId()
        {
            return this.merchant_id;
        }

        /// <summary>
        /// Sets the Amazon Provider Credit Reversal ID
        /// </summary>
        /// <param name="amazon_provider_credit_reversal_id"></param>
        /// <returns>GetProviderCreditReversalDetailsRequest Object</returns>
        public GetProviderCreditReversalDetailsRequest WithAmazonProviderCreditReversalId(string amazon_provider_credit_reversal_id)
        {
            this.amazon_provider_credit_reversal_id = amazon_provider_credit_reversal_id;
            log.Debug("METHOD__WithAmazonProviderCreditReversalId | MESSAGE__amazon_provider_credit_reversal_id: " + this.amazon_provider_credit_reversal_id);
            return this;
        }
        public string GetAmazonProviderCreditReversalId()
        {
            return this.amazon_provider_credit_reversal_id;
        }

        /// <summary>
        /// Sets the MWS Auth Token
        /// </summary>
        /// <param name="mws_auth_token"></param>
        /// <returns>GetProviderCreditReversalDetailsRequest Object</returns>
        public GetProviderCreditReversalDetailsRequest WithMWSAuthToken(string mws_auth_token)
        {
            this.mws_auth_token = mws_auth_token;
            log.Debug("METHOD__WithMWSAuthToken | MESSAGE__mws_auth_token: " + this.mws_auth_token);
            return this;
        }
        public string GetMWSAuthToken()
        {
            return this.mws_auth_token;
        }
    }
}