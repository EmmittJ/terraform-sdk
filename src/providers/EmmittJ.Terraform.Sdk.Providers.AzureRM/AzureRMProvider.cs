using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Represents the azurerm Terraform provider.
/// 
/// Version: ~&gt; 4.0
/// Resources: 1120
/// Data Sources: 399
/// </summary>
public class AzureRMProvider : TerraformProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AzureRMProvider"/> class.
    /// </summary>
    /// <param name="name">The name of the provider instance. Defaults to "azurerm".</param>
    public AzureRMProvider(string name = "azurerm") : base(name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ado_pipeline_service_connection_id");
        SetOutput("auxiliary_tenant_ids");
        SetOutput("client_certificate");
        SetOutput("client_certificate_password");
        SetOutput("client_certificate_path");
        SetOutput("client_id");
        SetOutput("client_id_file_path");
        SetOutput("client_secret");
        SetOutput("client_secret_file_path");
        SetOutput("disable_correlation_request_id");
        SetOutput("disable_terraform_partner_id");
        SetOutput("environment");
        SetOutput("metadata_host");
        SetOutput("msi_api_version");
        SetOutput("msi_endpoint");
        SetOutput("oidc_request_token");
        SetOutput("oidc_request_url");
        SetOutput("oidc_token");
        SetOutput("oidc_token_file_path");
        SetOutput("partner_id");
        SetOutput("resource_provider_registrations");
        SetOutput("resource_providers_to_register");
        SetOutput("skip_provider_registration");
        SetOutput("storage_use_azuread");
        SetOutput("subscription_id");
        SetOutput("tenant_id");
        SetOutput("use_aks_workload_identity");
        SetOutput("use_cli");
        SetOutput("use_msi");
        SetOutput("use_oidc");
    }

    /// <summary>
    /// The Azure DevOps Pipeline Service Connection ID.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> AdoPipelineServiceConnectionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ado_pipeline_service_connection_id");
        set => SetProperty("ado_pipeline_service_connection_id", value);
    }

    /// <summary>
    /// The auxiliary_tenant_ids configuration.
    /// (Optional)
    /// </summary>
    public List<TerraformProperty<string>> AuxiliaryTenantIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("auxiliary_tenant_ids");
        set => SetProperty("auxiliary_tenant_ids", value);
    }

    /// <summary>
    /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientCertificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate");
        set => SetProperty("client_certificate", value);
    }

    /// <summary>
    /// The password associated with the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientCertificatePassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate_password");
        set => SetProperty("client_certificate_password", value);
    }

    /// <summary>
    /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientCertificatePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate_path");
        set => SetProperty("client_certificate_path", value);
    }

    /// <summary>
    /// The Client ID which should be used.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The path to a file containing the Client ID which should be used.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientIdFilePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id_file_path");
        set => SetProperty("client_id_file_path", value);
    }

    /// <summary>
    /// The Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret");
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The path to a file containing the Client Secret which should be used. For use When authenticating as a Service Principal using a Client Secret.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientSecretFilePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret_file_path");
        set => SetProperty("client_secret_file_path", value);
    }

    /// <summary>
    /// This will disable the x-ms-correlation-request-id header.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> DisableCorrelationRequestId
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_correlation_request_id");
        set => SetProperty("disable_correlation_request_id", value);
    }

    /// <summary>
    /// This will disable the Terraform Partner ID which is used if a custom `partner_id` isn&#39;t specified.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> DisableTerraformPartnerId
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_terraform_partner_id");
        set => SetProperty("disable_terraform_partner_id", value);
    }

    /// <summary>
    /// The Cloud Environment which should be used. Possible values are public, usgovernment, and china. Defaults to public. Not used and should not be specified when `metadata_host` is specified.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> Environment
    {
        get => GetRequiredOutput<TerraformProperty<string>>("environment");
        set => SetProperty("environment", value);
    }

    /// <summary>
    /// The Hostname which should be used for the Azure Metadata Service.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> MetadataHost
    {
        get => GetRequiredOutput<TerraformProperty<string>>("metadata_host");
        set => SetProperty("metadata_host", value);
    }

    /// <summary>
    /// The API version to use for Managed Service Identity (IMDS) - for cases where the default API version is not supported by the endpoint. e.g. for Azure Container Apps.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> MsiApiVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("msi_api_version");
        set => SetProperty("msi_api_version", value);
    }

    /// <summary>
    /// The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected automatically.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> MsiEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("msi_endpoint");
        set => SetProperty("msi_endpoint", value);
    }

    /// <summary>
    /// The bearer token for the request to the OIDC provider. For use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OidcRequestToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("oidc_request_token");
        set => SetProperty("oidc_request_token", value);
    }

    /// <summary>
    /// The URL for the OIDC provider from which to request an ID token. For use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OidcRequestUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("oidc_request_url");
        set => SetProperty("oidc_request_url", value);
    }

    /// <summary>
    /// The OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OidcToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("oidc_token");
        set => SetProperty("oidc_token", value);
    }

    /// <summary>
    /// The path to a file containing an OIDC ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OidcTokenFilePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("oidc_token_file_path");
        set => SetProperty("oidc_token_file_path", value);
    }

    /// <summary>
    /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> PartnerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partner_id");
        set => SetProperty("partner_id", value);
    }

    /// <summary>
    /// The set of Resource Providers which should be automatically registered for the subscription.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ResourceProviderRegistrations
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_provider_registrations");
        set => SetProperty("resource_provider_registrations", value);
    }

    /// <summary>
    /// A list of Resource Providers to explicitly register for the subscription, in addition to those specified by the `resource_provider_registrations` property.
    /// (Optional)
    /// </summary>
    public List<TerraformProperty<string>> ResourceProvidersToRegister
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("resource_providers_to_register");
        set => SetProperty("resource_providers_to_register", value);
    }

    /// <summary>
    /// Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they&#39;re not already registered?
    /// (Optional)
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<bool> SkipProviderRegistration
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("skip_provider_registration");
        set => SetProperty("skip_provider_registration", value);
    }

    /// <summary>
    /// Should the AzureRM Provider use Azure AD Authentication when accessing the Storage Data Plane APIs?
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> StorageUseAzuread
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("storage_use_azuread");
        set => SetProperty("storage_use_azuread", value);
    }

    /// <summary>
    /// The Subscription ID which should be used.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// The Tenant ID which should be used.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> TenantId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tenant_id");
        set => SetProperty("tenant_id", value);
    }

    /// <summary>
    /// Allow Azure AKS Workload Identity to be used for Authentication.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> UseAksWorkloadIdentity
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_aks_workload_identity");
        set => SetProperty("use_aks_workload_identity", value);
    }

    /// <summary>
    /// Allow Azure CLI to be used for Authentication.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> UseCli
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_cli");
        set => SetProperty("use_cli", value);
    }

    /// <summary>
    /// Allow Managed Service Identity to be used for Authentication.
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> UseMsi
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_msi");
        set => SetProperty("use_msi", value);
    }

    /// <summary>
    /// Allow OpenID Connect to be used for authentication
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> UseOidc
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_oidc");
        set => SetProperty("use_oidc", value);
    }
}
