using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

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
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_nginx_certificate.
/// </summary>
public class AzurermNginxCertificateDataSource : TerraformDataSource
{
    public AzurermNginxCertificateDataSource(string name) : base("azurerm_nginx_certificate", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformArgument("nginx_deployment_id")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNginxCertificateDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_virtual_path attribute.
    /// </summary>
    [TerraformArgument("certificate_virtual_path")]
    public TerraformValue<string> CertificateVirtualPath
    {
        get => new TerraformReference<string>(this, "certificate_virtual_path");
    }

    /// <summary>
    /// The error_code attribute.
    /// </summary>
    [TerraformArgument("error_code")]
    public TerraformValue<string> ErrorCode
    {
        get => new TerraformReference<string>(this, "error_code");
    }

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    [TerraformArgument("error_message")]
    public TerraformValue<string> ErrorMessage
    {
        get => new TerraformReference<string>(this, "error_message");
    }

    /// <summary>
    /// The key_vault_secret_creation_date attribute.
    /// </summary>
    [TerraformArgument("key_vault_secret_creation_date")]
    public TerraformValue<string> KeyVaultSecretCreationDate
    {
        get => new TerraformReference<string>(this, "key_vault_secret_creation_date");
    }

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_secret_id")]
    public TerraformValue<string> KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
    }

    /// <summary>
    /// The key_vault_secret_version attribute.
    /// </summary>
    [TerraformArgument("key_vault_secret_version")]
    public TerraformValue<string> KeyVaultSecretVersion
    {
        get => new TerraformReference<string>(this, "key_vault_secret_version");
    }

    /// <summary>
    /// The key_virtual_path attribute.
    /// </summary>
    [TerraformArgument("key_virtual_path")]
    public TerraformValue<string> KeyVirtualPath
    {
        get => new TerraformReference<string>(this, "key_virtual_path");
    }

    /// <summary>
    /// The sha1_thumbprint attribute.
    /// </summary>
    [TerraformArgument("sha1_thumbprint")]
    public TerraformValue<string> Sha1Thumbprint
    {
        get => new TerraformReference<string>(this, "sha1_thumbprint");
    }

}
