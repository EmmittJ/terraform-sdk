using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNginxCertificateDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_nginx_certificate Terraform data source.
/// Retrieves information about a azurerm_nginx_certificate.
/// </summary>
public partial class AzurermNginxCertificateDataSource(string name) : TerraformDataSource("azurerm_nginx_certificate", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// The certificate_virtual_path attribute.
    /// </summary>
    public TerraformValue<string> CertificateVirtualPath
    {
        get => new TerraformReference<string>(this, "certificate_virtual_path");
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    public TerraformValue<string> ErrorCode
    {
        get => new TerraformReference<string>(this, "error_code");
    }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
    {
        get => new TerraformReference<string>(this, "error_message");
    }

    /// <summary>
    /// The key_vault_secret_creation_date attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultSecretCreationDate
    {
        get => new TerraformReference<string>(this, "key_vault_secret_creation_date");
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
    }

    /// <summary>
    /// The key_vault_secret_version attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultSecretVersion
    {
        get => new TerraformReference<string>(this, "key_vault_secret_version");
    }

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    public TerraformValue<string> KeyVirtualPath
    {
        get => new TerraformReference<string>(this, "key_virtual_path");
    }

    /// <summary>
    /// The sha1_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Sha1Thumbprint
    {
        get => new TerraformReference<string>(this, "sha1_thumbprint");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxCertificateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxCertificateDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
