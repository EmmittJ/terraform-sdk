using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Represents the azurerm Terraform provider.
/// 
/// Version: ~&gt; 4.0
/// Resources: 1120
/// Data Sources: 399
/// </summary>
public partial class AzureRMProvider : TerraformProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AzureRMProvider"/> class.
    /// </summary>
    /// <param name="name">The name of the provider instance. Defaults to "azurerm".</param>
    public AzureRMProvider(string name = "azurerm") : base(name)
    {
    }

    /// <summary>
    /// The Azure DevOps Pipeline Service Connection ID.
    /// (Optional)
    /// </summary>
    [TerraformArgument("ado_pipeline_service_connection_id")]
    public TerraformValue<string>? AdoPipelineServiceConnectionId { get; set; }

    /// <summary>
    /// The auxiliary_tenant_ids configuration.
    /// (Optional)
    /// </summary>
    [TerraformArgument("auxiliary_tenant_ids")]
    public TerraformList<string>? AuxiliaryTenantIds { get; set; }

    /// <summary>
    /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    [TerraformArgument("client_certificate")]
    public TerraformValue<string>? ClientCertificate { get; set; }

    /// <summary>
    /// The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    [TerraformArgument("client_certificate_password")]
    public TerraformValue<string>? ClientCertificatePassword { get; set; }

    /// <summary>
    /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.
    /// (Optional)
    /// </summary>
    [TerraformArgument("client_certificate_path")]
    public TerraformValue<string>? ClientCertificatePath { get; set; }

    /// <summary>
    /// The Client ID which should be used.
    /// (Optional)
    /// </summary>
    [TerraformArgument("client_id")]
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The path to a file containing the Client ID which should be used.
    /// (Optional)
    /// </summary>
    [TerraformArgument("client_id_file_path")]
    public TerraformValue<string>? ClientIdFilePath { get; set; }

    /// <summary>
    /// The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
    /// (Optional)
    /// </summary>
    [TerraformArgument("client_secret")]
    public TerraformValue<string>? ClientSecret { get; set; }

    /// <summary>
    /// The path to a file containing the Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
    /// (Optional)
    /// </summary>
    [TerraformArgument("client_secret_file_path")]
    public TerraformValue<string>? ClientSecretFilePath { get; set; }

    /// <summary>
    /// This will disable the x-ms-correlation-request-id header.
    /// (Optional)
    /// </summary>
    [TerraformArgument("disable_correlation_request_id")]
    public TerraformValue<bool>? DisableCorrelationRequestId { get; set; }

    /// <summary>
    /// This will disable the Terraform Partner ID which is used if a custom `partner_id` isn&#39;t specified.
    /// (Optional)
    /// </summary>
    [TerraformArgument("disable_terraform_partner_id")]
    public TerraformValue<bool>? DisableTerraformPartnerId { get; set; }

    /// <summary>
    /// The Cloud Environment which should be used. Possible values are public, usgovernment, and china. Defaults to public. Not used and should not be specified when `metadata_host` is specified.
    /// (Optional)
    /// </summary>
    [TerraformArgument("environment")]
    public TerraformValue<string>? Environment { get; set; }

    /// <summary>
    /// The Hostname which should be used for the Azure Metadata Service.
    /// (Optional)
    /// </summary>
    [TerraformArgument("metadata_host")]
    public TerraformValue<string>? MetadataHost { get; set; }

    /// <summary>
    /// The API version to use for Managed Service Identity (IMDS) - for cases where the default API version is not supported by the endpoint. e.g. for Azure Container Apps.
    /// (Optional)
    /// </summary>
    [TerraformArgument("msi_api_version")]
    public TerraformValue<string>? MsiApiVersion { get; set; }

    /// <summary>
    /// The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically.
    /// (Optional)
    /// </summary>
    [TerraformArgument("msi_endpoint")]
    public TerraformValue<string>? MsiEndpoint { get; set; }

    /// <summary>
    /// The bearer token for the request to the OIDC provider. For use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    [TerraformArgument("oidc_request_token")]
    public TerraformValue<string>? OidcRequestToken { get; set; }

    /// <summary>
    /// The URL for the OIDC provider from which to request an ID token. For use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    [TerraformArgument("oidc_request_url")]
    public TerraformValue<string>? OidcRequestUrl { get; set; }

    /// <summary>
    /// The OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    [TerraformArgument("oidc_token")]
    public TerraformValue<string>? OidcToken { get; set; }

    /// <summary>
    /// The path to a file containing an OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    [TerraformArgument("oidc_token_file_path")]
    public TerraformValue<string>? OidcTokenFilePath { get; set; }

    /// <summary>
    /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.
    /// (Optional)
    /// </summary>
    [TerraformArgument("partner_id")]
    public TerraformValue<string>? PartnerId { get; set; }

    /// <summary>
    /// The set of Resource Providers which should be automatically registered for the subscription.
    /// (Optional)
    /// </summary>
    [TerraformArgument("resource_provider_registrations")]
    public TerraformValue<string>? ResourceProviderRegistrations { get; set; }

    /// <summary>
    /// A list of Resource Providers to explicitly register for the subscription, in addition to those specified by the `resource_provider_registrations` property.
    /// (Optional)
    /// </summary>
    [TerraformArgument("resource_providers_to_register")]
    public TerraformList<string>? ResourceProvidersToRegister { get; set; }

    /// <summary>
    /// Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they&#39;re not already registered?
    /// (Optional)
    /// </summary>
    [Obsolete("This property is deprecated.")]
    [TerraformArgument("skip_provider_registration")]
    public TerraformValue<bool>? SkipProviderRegistration { get; set; }

    /// <summary>
    /// Should the AzureRM Provider use Azure AD Authentication when accessing the Storage Data Plane APIs?
    /// (Optional)
    /// </summary>
    [TerraformArgument("storage_use_azuread")]
    public TerraformValue<bool>? StorageUseAzuread { get; set; }

    /// <summary>
    /// The Subscription ID which should be used.
    /// (Optional)
    /// </summary>
    [TerraformArgument("subscription_id")]
    public TerraformValue<string>? SubscriptionId { get; set; }

    /// <summary>
    /// The Tenant ID which should be used.
    /// (Optional)
    /// </summary>
    [TerraformArgument("tenant_id")]
    public TerraformValue<string>? TenantId { get; set; }

    /// <summary>
    /// Allow Azure AKS Workload Identity to be used for Authentication.
    /// (Optional)
    /// </summary>
    [TerraformArgument("use_aks_workload_identity")]
    public TerraformValue<bool>? UseAksWorkloadIdentity { get; set; }

    /// <summary>
    /// Allow Azure CLI to be used for Authentication.
    /// (Optional)
    /// </summary>
    [TerraformArgument("use_cli")]
    public TerraformValue<bool>? UseCli { get; set; }

    /// <summary>
    /// Allow Managed Service Identity to be used for Authentication.
    /// (Optional)
    /// </summary>
    [TerraformArgument("use_msi")]
    public TerraformValue<bool>? UseMsi { get; set; }

    /// <summary>
    /// Allow OpenID Connect to be used for authentication
    /// (Optional)
    /// </summary>
    [TerraformArgument("use_oidc")]
    public TerraformValue<bool>? UseOidc { get; set; }
}
