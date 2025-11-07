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
    }

    /// <summary>
    /// The Azure DevOps Pipeline Service Connection ID.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? AdoPipelineServiceConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ado_pipeline_service_connection_id");
        set => this.WithProperty("ado_pipeline_service_connection_id", value);
    }

    /// <summary>
    /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClientCertificate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate");
        set => this.WithProperty("client_certificate", value);
    }

    /// <summary>
    /// The password to decrypt the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClientCertificatePassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_password");
        set => this.WithProperty("client_certificate_password", value);
    }

    /// <summary>
    /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClientCertificatePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_path");
        set => this.WithProperty("client_certificate_path", value);
    }

    /// <summary>
    /// The Client ID which should be used for service principal authentication
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The path to a file containing the Client ID which should be used for service principal authentication
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClientIdFilePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id_file_path");
        set => this.WithProperty("client_id_file_path", value);
    }

    /// <summary>
    /// The application password to use when authenticating as a Service Principal using a Client Secret
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
    }

    /// <summary>
    /// The path to a file containing the application password to use when authenticating as a Service Principal using a Client Secret
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? ClientSecretFilePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret_file_path");
        set => this.WithProperty("client_secret_file_path", value);
    }

    /// <summary>
    /// Disable the Terraform Partner ID, which is used if a custom `partner_id` isn&#39;t specified
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableTerraformPartnerId
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_terraform_partner_id");
        set => this.WithProperty("disable_terraform_partner_id", value);
    }

    /// <summary>
    /// The cloud environment which should be used. Possible values are: `global` (also `public`), `usgovernmentl4` (also `usgovernment`), `usgovernmentl5` (also `dod`), and `china`. Defaults to `global`. Not used and should not be specified when `metadata_host` is specified.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? Environment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("environment");
        set => this.WithProperty("environment", value);
    }

    /// <summary>
    /// The Hostname which should be used for the Azure Metadata Service.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? MetadataHost
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metadata_host");
        set => this.WithProperty("metadata_host", value);
    }

    /// <summary>
    /// The path to a custom endpoint for Managed Identity - in most circumstances this should be detected automatically
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? MsiEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("msi_endpoint");
        set => this.WithProperty("msi_endpoint", value);
    }

    /// <summary>
    /// The bearer token for the request to the OIDC provider. For use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OidcRequestToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oidc_request_token");
        set => this.WithProperty("oidc_request_token", value);
    }

    /// <summary>
    /// The URL for the OIDC provider from which to request an ID token. For use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OidcRequestUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oidc_request_url");
        set => this.WithProperty("oidc_request_url", value);
    }

    /// <summary>
    /// The ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OidcToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oidc_token");
        set => this.WithProperty("oidc_token", value);
    }

    /// <summary>
    /// The path to a file containing an ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? OidcTokenFilePath
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oidc_token_file_path");
        set => this.WithProperty("oidc_token_file_path", value);
    }

    /// <summary>
    /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? PartnerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partner_id");
        set => this.WithProperty("partner_id", value);
    }

    /// <summary>
    /// The Tenant ID which should be used. Works with all authentication methods except Managed Identity
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<string>? TenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenant_id");
        set => this.WithProperty("tenant_id", value);
    }

    /// <summary>
    /// Allow Azure AKS Workload Identity to be used for Authentication.
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<bool>? UseAksWorkloadIdentity
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_aks_workload_identity");
        set => this.WithProperty("use_aks_workload_identity", value);
    }

    /// <summary>
    /// Allow Azure CLI to be used for Authentication
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<bool>? UseCli
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_cli");
        set => this.WithProperty("use_cli", value);
    }

    /// <summary>
    /// Allow Managed Identity to be used for Authentication
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<bool>? UseMsi
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_msi");
        set => this.WithProperty("use_msi", value);
    }

    /// <summary>
    /// Allow OpenID Connect to be used for authentication
    /// (Optional)
    /// </summary>
    public TerraformLiteralProperty<bool>? UseOidc
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("use_oidc");
        set => this.WithProperty("use_oidc", value);
    }
}
