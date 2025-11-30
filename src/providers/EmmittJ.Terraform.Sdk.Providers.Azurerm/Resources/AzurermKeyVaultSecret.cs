using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermKeyVaultSecret.
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultSecretTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_key_vault_secret Terraform resource.
/// Manages a azurerm_key_vault_secret resource.
/// </summary>
public partial class AzurermKeyVaultSecret(string name) : TerraformResource("azurerm_key_vault_secret", name)
{
    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformValue<string>? ContentType
    {
        get => new TerraformReference<string>(this, "content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string>? ExpirationDate
    {
        get => new TerraformReference<string>(this, "expiration_date");
        set => SetArgument("expiration_date", value);
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
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
    /// The not_before_date attribute.
    /// </summary>
    public TerraformValue<string>? NotBeforeDate
    {
        get => new TerraformReference<string>(this, "not_before_date");
        set => SetArgument("not_before_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public TerraformValue<string>? ValueWo
    {
        get => new TerraformReference<string>(this, "value_wo");
        set => SetArgument("value_wo", value);
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ValueWoVersion
    {
        get => new TerraformReference<double>(this, "value_wo_version");
        set => SetArgument("value_wo_version", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceVersionlessId
    {
        get => new TerraformReference<string>(this, "resource_versionless_id");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformValue<string> VersionlessId
    {
        get => new TerraformReference<string>(this, "versionless_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultSecretTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultSecretTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
