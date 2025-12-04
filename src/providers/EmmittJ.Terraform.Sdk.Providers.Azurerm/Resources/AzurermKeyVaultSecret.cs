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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    public TerraformValue<string>? ExpirationDate
    {
        get => GetArgument<TerraformValue<string>>("expiration_date");
        set => SetArgument("expiration_date", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    public required TerraformValue<string> KeyVaultId
    {
        get => GetArgument<TerraformValue<string>>("key_vault_id");
        set => SetArgument("key_vault_id", value);
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
    /// The not_before_date attribute.
    /// </summary>
    public TerraformValue<string>? NotBeforeDate
    {
        get => GetArgument<TerraformValue<string>>("not_before_date");
        set => SetArgument("not_before_date", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// The value_wo attribute.
    /// </summary>
    public TerraformValue<string>? ValueWo
    {
        get => GetArgument<TerraformValue<string>>("value_wo");
        set => SetArgument("value_wo", value);
    }

    /// <summary>
    /// The value_wo_version attribute.
    /// </summary>
    public TerraformValue<double>? ValueWoVersion
    {
        get => GetArgument<TerraformValue<double>>("value_wo_version");
        set => SetArgument("value_wo_version", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
        => AsReference("resource_id");

    /// <summary>
    /// The resource_versionless_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceVersionlessId
        => AsReference("resource_versionless_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The versionless_id attribute.
    /// </summary>
    public TerraformValue<string> VersionlessId
        => AsReference("versionless_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermKeyVaultSecretTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermKeyVaultSecretTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
