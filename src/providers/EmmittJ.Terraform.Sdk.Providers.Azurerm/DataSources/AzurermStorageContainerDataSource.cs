using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageContainerDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermStorageContainerDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_container Terraform data source.
/// Retrieves information about a azurerm_storage_container.
/// </summary>
public partial class AzurermStorageContainerDataSource(string name) : TerraformDataSource("azurerm_storage_container", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformMap<string> Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata") ?? CreateReference("metadata");
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
    public TerraformValue<string>? StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    public TerraformValue<string> ContainerAccessType
        => CreateReference("container_access_type");

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    public TerraformValue<string> DefaultEncryptionScope
        => CreateReference("default_encryption_scope");

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    public TerraformValue<bool> EncryptionScopeOverrideEnabled
        => CreateReference("encryption_scope_override_enabled");

    /// <summary>
    /// The has_immutability_policy attribute.
    /// </summary>
    public TerraformValue<bool> HasImmutabilityPolicy
        => CreateReference("has_immutability_policy");

    /// <summary>
    /// The has_legal_hold attribute.
    /// </summary>
    public TerraformValue<bool> HasLegalHold
        => CreateReference("has_legal_hold");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformValue<string> ResourceManagerId
        => CreateReference("resource_manager_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageContainerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageContainerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
