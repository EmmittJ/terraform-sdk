using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageContainer.
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_container Terraform resource.
/// Manages a azurerm_storage_container resource.
/// </summary>
public partial class AzurermStorageContainer(string name) : TerraformResource("azurerm_storage_container", name)
{
    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    public TerraformValue<string>? ContainerAccessType
    {
        get => GetArgument<TerraformValue<string>>("container_access_type");
        set => SetArgument("container_access_type", value);
    }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    public TerraformValue<string> DefaultEncryptionScope
    {
        get => GetArgument<TerraformValue<string>>("default_encryption_scope") ?? AsReference("default_encryption_scope");
        set => SetArgument("default_encryption_scope", value);
    }

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? EncryptionScopeOverrideEnabled
    {
        get => GetArgument<TerraformValue<bool>>("encryption_scope_override_enabled");
        set => SetArgument("encryption_scope_override_enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata") ?? AsReference("metadata");
        set => SetArgument("metadata", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string>? StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The has_immutability_policy attribute.
    /// </summary>
    public TerraformValue<bool> HasImmutabilityPolicy
        => AsReference("has_immutability_policy");

    /// <summary>
    /// The has_legal_hold attribute.
    /// </summary>
    public TerraformValue<bool> HasLegalHold
        => AsReference("has_legal_hold");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ResourceManagerId
        => AsReference("resource_manager_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageContainerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageContainerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
