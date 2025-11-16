using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Represents the azurerm Terraform provider.
/// Version: ~&gt; 4.0
/// Resources: 1120
/// Data Sources: 399
/// </summary>
public partial class AzurermProvider(string name = "azurerm") : TerraformProvider(name)
{
    /// <summary>
    /// The Azure DevOps Pipeline Service Connection ID.
    /// </summary>
    public TerraformValue<string>? AdoPipelineServiceConnectionId
    {
        get => new TerraformReference<string>(this, "ado_pipeline_service_connection_id");
        set => SetArgument("ado_pipeline_service_connection_id", value);
    }


    /// <summary>
    /// The auxiliary_tenant_ids attribute.
    /// </summary>
    public TerraformList<string>? AuxiliaryTenantIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "auxiliary_tenant_ids").ResolveNodes(ctx));
        set => SetArgument("auxiliary_tenant_ids", value);
    }


    /// <summary>
    /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => new TerraformReference<string>(this, "client_certificate");
        set => SetArgument("client_certificate", value);
    }


    /// <summary>
    /// The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
    /// </summary>
    public TerraformValue<string>? ClientCertificatePassword
    {
        get => new TerraformReference<string>(this, "client_certificate_password");
        set => SetArgument("client_certificate_password", value);
    }


    /// <summary>
    /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.
    /// </summary>
    public TerraformValue<string>? ClientCertificatePath
    {
        get => new TerraformReference<string>(this, "client_certificate_path");
        set => SetArgument("client_certificate_path", value);
    }


    /// <summary>
    /// The Client ID which should be used.
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => new TerraformReference<string>(this, "client_id");
        set => SetArgument("client_id", value);
    }


    /// <summary>
    /// The path to a file containing the Client ID which should be used.
    /// </summary>
    public TerraformValue<string>? ClientIdFilePath
    {
        get => new TerraformReference<string>(this, "client_id_file_path");
        set => SetArgument("client_id_file_path", value);
    }


    /// <summary>
    /// The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => new TerraformReference<string>(this, "client_secret");
        set => SetArgument("client_secret", value);
    }


    /// <summary>
    /// The path to a file containing the Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
    /// </summary>
    public TerraformValue<string>? ClientSecretFilePath
    {
        get => new TerraformReference<string>(this, "client_secret_file_path");
        set => SetArgument("client_secret_file_path", value);
    }


    /// <summary>
    /// This will disable the x-ms-correlation-request-id header.
    /// </summary>
    public TerraformValue<bool>? DisableCorrelationRequestId
    {
        get => new TerraformReference<bool>(this, "disable_correlation_request_id");
        set => SetArgument("disable_correlation_request_id", value);
    }


    /// <summary>
    /// This will disable the Terraform Partner ID which is used if a custom `partner_id` isn&#39;t specified.
    /// </summary>
    public TerraformValue<bool>? DisableTerraformPartnerId
    {
        get => new TerraformReference<bool>(this, "disable_terraform_partner_id");
        set => SetArgument("disable_terraform_partner_id", value);
    }


    /// <summary>
    /// The Cloud Environment which should be used. Possible values are public, usgovernment, and china. Defaults to public. Not used and should not be specified when `metadata_host` is specified.
    /// </summary>
    public TerraformValue<string>? Environment
    {
        get => new TerraformReference<string>(this, "environment");
        set => SetArgument("environment", value);
    }


    /// <summary>
    /// The Hostname which should be used for the Azure Metadata Service.
    /// </summary>
    public TerraformValue<string>? MetadataHost
    {
        get => new TerraformReference<string>(this, "metadata_host");
        set => SetArgument("metadata_host", value);
    }


    /// <summary>
    /// The API version to use for Managed Service Identity (IMDS) - for cases where the default API version is not supported by the endpoint. e.g. for Azure Container Apps.
    /// </summary>
    public TerraformValue<string>? MsiApiVersion
    {
        get => new TerraformReference<string>(this, "msi_api_version");
        set => SetArgument("msi_api_version", value);
    }


    /// <summary>
    /// The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically.
    /// </summary>
    public TerraformValue<string>? MsiEndpoint
    {
        get => new TerraformReference<string>(this, "msi_endpoint");
        set => SetArgument("msi_endpoint", value);
    }


    /// <summary>
    /// The bearer token for the request to the OIDC provider. For use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcRequestToken
    {
        get => new TerraformReference<string>(this, "oidc_request_token");
        set => SetArgument("oidc_request_token", value);
    }


    /// <summary>
    /// The URL for the OIDC provider from which to request an ID token. For use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcRequestUrl
    {
        get => new TerraformReference<string>(this, "oidc_request_url");
        set => SetArgument("oidc_request_url", value);
    }


    /// <summary>
    /// The OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcToken
    {
        get => new TerraformReference<string>(this, "oidc_token");
        set => SetArgument("oidc_token", value);
    }


    /// <summary>
    /// The path to a file containing an OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcTokenFilePath
    {
        get => new TerraformReference<string>(this, "oidc_token_file_path");
        set => SetArgument("oidc_token_file_path", value);
    }


    /// <summary>
    /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.
    /// </summary>
    public TerraformValue<string>? PartnerId
    {
        get => new TerraformReference<string>(this, "partner_id");
        set => SetArgument("partner_id", value);
    }


    /// <summary>
    /// The set of Resource Providers which should be automatically registered for the subscription.
    /// </summary>
    public TerraformValue<string>? ResourceProviderRegistrations
    {
        get => new TerraformReference<string>(this, "resource_provider_registrations");
        set => SetArgument("resource_provider_registrations", value);
    }


    /// <summary>
    /// A list of Resource Providers to explicitly register for the subscription, in addition to those specified by the `resource_provider_registrations` property.
    /// </summary>
    public TerraformList<string>? ResourceProvidersToRegister
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "resource_providers_to_register").ResolveNodes(ctx));
        set => SetArgument("resource_providers_to_register", value);
    }


    /// <summary>
    /// Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they&#39;re not already registered?
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<bool>? SkipProviderRegistration
    {
        get => new TerraformReference<bool>(this, "skip_provider_registration");
        set => SetArgument("skip_provider_registration", value);
    }


    /// <summary>
    /// Should the AzureRM Provider use Azure AD Authentication when accessing the Storage Data Plane APIs?
    /// </summary>
    public TerraformValue<bool>? StorageUseAzuread
    {
        get => new TerraformReference<bool>(this, "storage_use_azuread");
        set => SetArgument("storage_use_azuread", value);
    }


    /// <summary>
    /// The Subscription ID which should be used.
    /// </summary>
    public TerraformValue<string>? SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
    }


    /// <summary>
    /// The Tenant ID which should be used.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }


    /// <summary>
    /// Allow Azure AKS Workload Identity to be used for Authentication.
    /// </summary>
    public TerraformValue<bool>? UseAksWorkloadIdentity
    {
        get => new TerraformReference<bool>(this, "use_aks_workload_identity");
        set => SetArgument("use_aks_workload_identity", value);
    }


    /// <summary>
    /// Allow Azure CLI to be used for Authentication.
    /// </summary>
    public TerraformValue<bool>? UseCli
    {
        get => new TerraformReference<bool>(this, "use_cli");
        set => SetArgument("use_cli", value);
    }


    /// <summary>
    /// Allow Managed Service Identity to be used for Authentication.
    /// </summary>
    public TerraformValue<bool>? UseMsi
    {
        get => new TerraformReference<bool>(this, "use_msi");
        set => SetArgument("use_msi", value);
    }


    /// <summary>
    /// Allow OpenID Connect to be used for authentication
    /// </summary>
    public TerraformValue<bool>? UseOidc
    {
        get => new TerraformReference<bool>(this, "use_oidc");
        set => SetArgument("use_oidc", value);
    }


}
