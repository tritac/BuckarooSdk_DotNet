﻿using BuckarooSdk.Transaction;

namespace BuckarooSdk.Services.Visa
{
    public class VisaTransaction
    {
        /// <summary>
		/// The configured transaction
		/// </summary>
		private ConfiguredTransaction ConfiguredTransaction { get; set; }


        internal VisaTransaction(ConfiguredTransaction baseTransaction)
        {
            this.ConfiguredTransaction = baseTransaction;
        }
        
        /// <summary>
		/// The pay function creates a configured transaction with a PayPerEmailPaymentInvitationRequest, 
        /// that is ready to be executed.
		/// </summary>
		/// <param name="request">A PayPerEmailPaymentInvitationRequest</param>
		/// <returns></returns>
		public ConfiguredServiceTransaction Pay(VisaPayRequest request)
        {
            var parameters = ServiceHelper.CreateServiceParameters(request);
            var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
            configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "pay");

            return configuredServiceTransaction;
        }
        public ConfiguredServiceTransaction Refund(VisaRefundRequest request)
        {
            var parameters = ServiceHelper.CreateServiceParameters(request);
            var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
            configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "refund");

            return configuredServiceTransaction;
        }
        public ConfiguredServiceTransaction Authorize(VisaAuthorizeRequest request)
        {
            var parameters = ServiceHelper.CreateServiceParameters(request);
            var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
            configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "authorize");

            return configuredServiceTransaction;
        }
        public ConfiguredServiceTransaction Capture(VisaCaptureRequest request)
        {
            var parameters = ServiceHelper.CreateServiceParameters(request);
            var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
            configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "capture");

            return configuredServiceTransaction;
        }
        public ConfiguredServiceTransaction PayRecurrent(VisaPayRecurrentRequest request)
        {
            var parameters = ServiceHelper.CreateServiceParameters(request);
            var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
            configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "payrecurrent");

            return configuredServiceTransaction;
        }
        public ConfiguredServiceTransaction PayRemainder(VisaPayRemainderRequest request)
        {
            var parameters = ServiceHelper.CreateServiceParameters(request);
            var configuredServiceTransaction = new ConfiguredServiceTransaction(this.ConfiguredTransaction.BaseTransaction);
            configuredServiceTransaction.BaseTransaction.AddService("Mastercard", parameters, "payremainder");

            return configuredServiceTransaction;
        }
    }
}
