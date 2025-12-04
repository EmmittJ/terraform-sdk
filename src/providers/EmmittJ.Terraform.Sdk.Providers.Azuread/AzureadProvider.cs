using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Represents the azuread Terraform provider.
/// Version: ~&gt; 3.0
/// Resources: 53
/// Data Sources: 20
/// </summary>
public partial class AzureadProvider(string name = "azuread") : TerraformProvider(name)
{
    /// <summary>
    /// The Azure DevOps Pipeline Service Connection ID.
    /// </summary>
    public TerraformValue<string>? AdoPipelineServiceConnectionId
    {
        get => GetArgument<TerraformValue<string>>("ado_pipeline_service_connection_id");
        set => SetArgument("ado_pipeline_service_connection_id", value);
    }


    /// <summary>
    /// Base64 encoded PKCS#12 certificate bundle to use when authenticating as a Service Principal using a Client Certificate
    /// </summary>
    public TerraformValue<string>? ClientCertificate
    {
        get => GetArgument<TerraformValue<string>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }


    /// <summary>
    /// The password to decrypt the Client Certificate. For use when authenticating as a Service Principal using a Client Certificate
    /// </summary>
    public TerraformValue<string>? ClientCertificatePassword
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_password");
        set => SetArgument("client_certificate_password", value);
    }


    /// <summary>
    /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a Service Principal using a Client Certificate
    /// </summary>
    public TerraformValue<string>? ClientCertificatePath
    {
        get => GetArgument<TerraformValue<string>>("client_certificate_path");
        set => SetArgument("client_certificate_path", value);
    }


    /// <summary>
    /// The Client ID which should be used for service principal authentication
    /// </summary>
    public TerraformValue<string>? ClientId
    {
        get => GetArgument<TerraformValue<string>>("client_id");
        set => SetArgument("client_id", value);
    }


    /// <summary>
    /// The path to a file containing the Client ID which should be used for service principal authentication
    /// </summary>
    public TerraformValue<string>? ClientIdFilePath
    {
        get => GetArgument<TerraformValue<string>>("client_id_file_path");
        set => SetArgument("client_id_file_path", value);
    }


    /// <summary>
    /// The application password to use when authenticating as a Service Principal using a Client Secret
    /// </summary>
    public TerraformValue<string>? ClientSecret
    {
        get => GetArgument<TerraformValue<string>>("client_secret");
        set => SetArgument("client_secret", value);
    }


    /// <summary>
    /// The path to a file containing the application password to use when authenticating as a Service Principal using a Client Secret
    /// </summary>
    public TerraformValue<string>? ClientSecretFilePath
    {
        get => GetArgument<TerraformValue<string>>("client_secret_file_path");
        set => SetArgument("client_secret_file_path", value);
    }


    /// <summary>
    /// Disable the Terraform Partner ID, which is used if a custom `partner_id` isn&#39;t specified
    /// </summary>
    public TerraformValue<bool>? DisableTerraformPartnerId
    {
        get => GetArgument<TerraformValue<bool>>("disable_terraform_partner_id");
        set => SetArgument("disable_terraform_partner_id", value);
    }


    /// <summary>
    /// The cloud environment which should be used. Possible values are: `global` (also `public`), `usgovernmentl4` (also `usgovernment`), `usgovernmentl5` (also `dod`), and `china`. Defaults to `global`. Not used and should not be specified when `metadata_host` is specified.
    /// </summary>
    public TerraformValue<string>? Environment
    {
        get => GetArgument<TerraformValue<string>>("environment");
        set => SetArgument("environment", value);
    }


    /// <summary>
    /// The Hostname which should be used for the Azure Metadata Service.
    /// </summary>
    public TerraformValue<string>? MetadataHost
    {
        get => GetArgument<TerraformValue<string>>("metadata_host");
        set => SetArgument("metadata_host", value);
    }


    /// <summary>
    /// The path to a custom endpoint for Managed Identity - in most circumstances this should be detected automatically
    /// </summary>
    public TerraformValue<string>? MsiEndpoint
    {
        get => GetArgument<TerraformValue<string>>("msi_endpoint");
        set => SetArgument("msi_endpoint", value);
    }


    /// <summary>
    /// The bearer token for the request to the OIDC provider. For use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcRequestToken
    {
        get => GetArgument<TerraformValue<string>>("oidc_request_token");
        set => SetArgument("oidc_request_token", value);
    }


    /// <summary>
    /// The URL for the OIDC provider from which to request an ID token. For use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcRequestUrl
    {
        get => GetArgument<TerraformValue<string>>("oidc_request_url");
        set => SetArgument("oidc_request_url", value);
    }


    /// <summary>
    /// The ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcToken
    {
        get => GetArgument<TerraformValue<string>>("oidc_token");
        set => SetArgument("oidc_token", value);
    }


    /// <summary>
    /// The path to a file containing an ID token for use when authenticating as a Service Principal using OpenID Connect.
    /// </summary>
    public TerraformValue<string>? OidcTokenFilePath
    {
        get => GetArgument<TerraformValue<string>>("oidc_token_file_path");
        set => SetArgument("oidc_token_file_path", value);
    }


    /// <summary>
    /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution
    /// </summary>
    public TerraformValue<string>? PartnerId
    {
        get => GetArgument<TerraformValue<string>>("partner_id");
        set => SetArgument("partner_id", value);
    }


    /// <summary>
    /// The Tenant ID which should be used. Works with all authentication methods except Managed Identity
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }


    /// <summary>
    /// Allow Azure AKS Workload Identity to be used for Authentication.
    /// </summary>
    public TerraformValue<bool>? UseAksWorkloadIdentity
    {
        get => GetArgument<TerraformValue<bool>>("use_aks_workload_identity");
        set => SetArgument("use_aks_workload_identity", value);
    }


    /// <summary>
    /// Allow Azure CLI to be used for Authentication
    /// </summary>
    public TerraformValue<bool>? UseCli
    {
        get => GetArgument<TerraformValue<bool>>("use_cli");
        set => SetArgument("use_cli", value);
    }


    /// <summary>
    /// Allow Managed Identity to be used for Authentication
    /// </summary>
    public TerraformValue<bool>? UseMsi
    {
        get => GetArgument<TerraformValue<bool>>("use_msi");
        set => SetArgument("use_msi", value);
    }


    /// <summary>
    /// Allow OpenID Connect to be used for authentication
    /// </summary>
    public TerraformValue<bool>? UseOidc
    {
        get => GetArgument<TerraformValue<bool>>("use_oidc");
        set => SetArgument("use_oidc", value);
    }


}
