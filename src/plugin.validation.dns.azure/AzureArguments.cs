﻿namespace PKISharp.WACS.Plugins.ValidationPlugins
{
    public class AzureArguments
    {
        public string AzureEnvironment { get; set; }
        public bool AzureUseMsi { get; set; }
        public string AzureTenantId { get; set; }
        public string AzureClientId { get; set; }
        public string AzureSecret { get; set; }
        public string AzureSubscriptionId { get; set; }
        public string AzureResourceGroupName { get; set; }
    }
}