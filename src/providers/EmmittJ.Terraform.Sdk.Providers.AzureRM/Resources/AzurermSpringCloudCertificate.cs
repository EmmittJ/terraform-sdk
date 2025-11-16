using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudCertificateTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

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
/// Represents a azurerm_spring_cloud_certificate Terraform resource.
/// Manages a azurerm_spring_cloud_certificate resource.
/// </summary>
public partial class AzurermSpringCloudCertificate(string name) : TerraformResource("azurerm_spring_cloud_certificate", name)
{
    /// <summary>
    /// The certificate_content attribute.
    /// </summary>
    public TerraformValue<string>? CertificateContent
    {
        get => new TerraformReference<string>(this, "certificate_content");
        set => SetArgument("certificate_content", value);
    }

    /// <summary>
    /// The exclude_private_key attribute.
    /// </summary>
    public TerraformValue<bool>? ExcludePrivateKey
    {
        get => new TerraformReference<bool>(this, "exclude_private_key");
        set => SetArgument("exclude_private_key", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_certificate_id attribute.
    /// </summary>
    public TerraformValue<string>? KeyVaultCertificateId
    {
        get => new TerraformReference<string>(this, "key_vault_certificate_id");
        set => SetArgument("key_vault_certificate_id", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => new TerraformReference<string>(this, "service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudCertificateTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudCertificateTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
