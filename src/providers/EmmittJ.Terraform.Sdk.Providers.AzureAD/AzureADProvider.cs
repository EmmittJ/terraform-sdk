using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Represents the azuread Terraform provider.
/// 
/// Version: ~&gt; 3.0
/// Resources: 53
/// Data Sources: 20
/// </summary>
public class AzureADProvider : TerraformProvider
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AzureADProvider"/> class.
    /// </summary>
    /// <param name="name">The name of the provider instance. Defaults to "azuread".</param>
    public AzureADProvider(string name = "azuread") : base(name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ado_pipeline_service_connection_id");
        SetOutput("client_certificate");
        SetOutput("client_certificate_password");
        SetOutput("client_certificate_path");
        SetOutput("client_id");
        SetOutput("client_id_file_path");
        SetOutput("client_secret");
        SetOutput("client_secret_file_path");
        SetOutput("disable_terraform_partner_id");
        SetOutput("environment");
        SetOutput("metadata_host");
        SetOutput("msi_endpoint");
        SetOutput("oidc_request_token");
        SetOutput("oidc_request_url");
        SetOutput("oidc_token");
        SetOutput("oidc_token_file_path");
        SetOutput("partner_id");
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
    /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientCertificate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate");
        set => SetProperty("client_certificate", value);
    }

    /// <summary>
    /// The password to decrypt the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientCertificatePassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate_password");
        set => SetProperty("client_certificate_password", value);
    }

    /// <summary>
    /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientCertificatePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_certificate_path");
        set => SetProperty("client_certificate_path", value);
    }

    /// <summary>
    /// The Client ID which should be used for service principal authentication
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id");
        set => SetProperty("client_id", value);
    }

    /// <summary>
    /// The path to a file containing the Client ID which should be used for service principal authentication
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientIdFilePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_id_file_path");
        set => SetProperty("client_id_file_path", value);
    }

    /// <summary>
    /// The application password to use when authenticating as a Service Principal using a Client Secret
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientSecret
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret");
        set => SetProperty("client_secret", value);
    }

    /// <summary>
    /// The path to a file containing the application password to use when authenticating as a Service Principal using a Client Secret
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> ClientSecretFilePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("client_secret_file_path");
        set => SetProperty("client_secret_file_path", value);
    }

    /// <summary>
    /// Disable the Terraform Partner ID, which is used if a custom `partner_id` isn&#39;t specified
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> DisableTerraformPartnerId
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable_terraform_partner_id");
        set => SetProperty("disable_terraform_partner_id", value);
    }

    /// <summary>
    /// The cloud environment which should be used. Possible values are: `global` (also `public`), `usgovernmentl4` (also `usgovernment`), `usgovernmentl5` (also `dod`), and `china`. Defaults to `global`. Not used and should not be specified when `metadata_host` is specified.
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
    /// The path to a custom endpoint for Managed Identity - in most circumstances this should be detected automatically
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
    /// The ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OidcToken
    {
        get => GetRequiredOutput<TerraformProperty<string>>("oidc_token");
        set => SetProperty("oidc_token", value);
    }

    /// <summary>
    /// The path to a file containing an ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> OidcTokenFilePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("oidc_token_file_path");
        set => SetProperty("oidc_token_file_path", value);
    }

    /// <summary>
    /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution
    /// (Optional)
    /// </summary>
    public TerraformProperty<string> PartnerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partner_id");
        set => SetProperty("partner_id", value);
    }

    /// <summary>
    /// The Tenant ID which should be used. Works with all authentication methods except Managed Identity
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
    /// Allow Azure CLI to be used for Authentication
    /// (Optional)
    /// </summary>
    public TerraformProperty<bool> UseCli
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("use_cli");
        set => SetProperty("use_cli", value);
    }

    /// <summary>
    /// Allow Managed Identity to be used for Authentication
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
