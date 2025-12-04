using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNginxCertificateDataSource.
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
        get => GetArgument<TerraformValue<string>>("read");
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => GetArgument<TerraformValue<string>>("nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// The certificate_virtual_path attribute.
    /// </summary>
    public TerraformValue<string> CertificateVirtualPath
        => AsReference("certificate_virtual_path");

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    public TerraformValue<string> ErrorCode
        => AsReference("error_code");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
        => AsReference("error_message");

    /// <summary>
    /// The key_vault_secret_creation_date attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultSecretCreationDate
        => AsReference("key_vault_secret_creation_date");

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultSecretId
        => AsReference("key_vault_secret_id");

    /// <summary>
    /// The key_vault_secret_version attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultSecretVersion
        => AsReference("key_vault_secret_version");

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    public TerraformValue<string> KeyVirtualPath
        => AsReference("key_virtual_path");

    /// <summary>
    /// The sha1_thumbprint attribute.
    /// </summary>
    public TerraformValue<string> Sha1Thumbprint
        => AsReference("sha1_thumbprint");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxCertificateDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxCertificateDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
