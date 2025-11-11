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
    public TerraformValue<string>? AdoPipelineServiceConnectionId { get; set; }

    /// <summary>
    /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClientCertificate { get; set; }

    /// <summary>
    /// The password to decrypt the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClientCertificatePassword { get; set; }

    /// <summary>
    /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClientCertificatePath { get; set; }

    /// <summary>
    /// The Client ID which should be used for service principal authentication
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClientId { get; set; }

    /// <summary>
    /// The path to a file containing the Client ID which should be used for service principal authentication
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClientIdFilePath { get; set; }

    /// <summary>
    /// The application password to use when authenticating as a Service Principal using a Client Secret
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClientSecret { get; set; }

    /// <summary>
    /// The path to a file containing the application password to use when authenticating as a Service Principal using a Client Secret
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? ClientSecretFilePath { get; set; }

    /// <summary>
    /// Disable the Terraform Partner ID, which is used if a custom `partner_id` isn&#39;t specified
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? DisableTerraformPartnerId { get; set; }

    /// <summary>
    /// The cloud environment which should be used. Possible values are: `global` (also `public`), `usgovernmentl4` (also `usgovernment`), `usgovernmentl5` (also `dod`), and `china`. Defaults to `global`. Not used and should not be specified when `metadata_host` is specified.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? Environment { get; set; }

    /// <summary>
    /// The Hostname which should be used for the Azure Metadata Service.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? MetadataHost { get; set; }

    /// <summary>
    /// The path to a custom endpoint for Managed Identity - in most circumstances this should be detected automatically
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? MsiEndpoint { get; set; }

    /// <summary>
    /// The bearer token for the request to the OIDC provider. For use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OidcRequestToken { get; set; }

    /// <summary>
    /// The URL for the OIDC provider from which to request an ID token. For use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OidcRequestUrl { get; set; }

    /// <summary>
    /// The ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OidcToken { get; set; }

    /// <summary>
    /// The path to a file containing an ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? OidcTokenFilePath { get; set; }

    /// <summary>
    /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? PartnerId { get; set; }

    /// <summary>
    /// The Tenant ID which should be used. Works with all authentication methods except Managed Identity
    /// (Optional)
    /// </summary>
    public TerraformValue<string>? TenantId { get; set; }

    /// <summary>
    /// Allow Azure AKS Workload Identity to be used for Authentication.
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? UseAksWorkloadIdentity { get; set; }

    /// <summary>
    /// Allow Azure CLI to be used for Authentication
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? UseCli { get; set; }

    /// <summary>
    /// Allow Managed Identity to be used for Authentication
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? UseMsi { get; set; }

    /// <summary>
    /// Allow OpenID Connect to be used for authentication
    /// (Optional)
    /// </summary>
    public TerraformValue<bool>? UseOidc { get; set; }
}
