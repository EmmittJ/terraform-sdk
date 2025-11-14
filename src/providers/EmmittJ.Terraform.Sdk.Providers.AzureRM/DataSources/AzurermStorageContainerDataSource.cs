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
public class AzurermStorageContainerDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_storage_container.
/// </summary>
public class AzurermStorageContainerDataSource : TerraformDataSource
{
    public AzurermStorageContainerDataSource(string name) : base("azurerm_storage_container", name)
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
    /// The metadata attribute.
    /// </summary>
    [TerraformArgument("metadata")]
    public TerraformMap<string> Metadata
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "metadata").ResolveNodes(ctx));
        set => SetArgument("metadata", value);
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
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_id")]
    public TerraformValue<string>? StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [TerraformArgument("storage_account_name")]
    public TerraformValue<string>? StorageAccountName
    {
        get => new TerraformReference<string>(this, "storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageContainerDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The container_access_type attribute.
    /// </summary>
    [TerraformArgument("container_access_type")]
    public TerraformValue<string> ContainerAccessType
    {
        get => new TerraformReference<string>(this, "container_access_type");
    }

    /// <summary>
    /// The default_encryption_scope attribute.
    /// </summary>
    [TerraformArgument("default_encryption_scope")]
    public TerraformValue<string> DefaultEncryptionScope
    {
        get => new TerraformReference<string>(this, "default_encryption_scope");
    }

    /// <summary>
    /// The encryption_scope_override_enabled attribute.
    /// </summary>
    [TerraformArgument("encryption_scope_override_enabled")]
    public TerraformValue<bool> EncryptionScopeOverrideEnabled
    {
        get => new TerraformReference<bool>(this, "encryption_scope_override_enabled");
    }

    /// <summary>
    /// The has_immutability_policy attribute.
    /// </summary>
    [TerraformArgument("has_immutability_policy")]
    public TerraformValue<bool> HasImmutabilityPolicy
    {
        get => new TerraformReference<bool>(this, "has_immutability_policy");
    }

    /// <summary>
    /// The has_legal_hold attribute.
    /// </summary>
    [TerraformArgument("has_legal_hold")]
    public TerraformValue<bool> HasLegalHold
    {
        get => new TerraformReference<bool>(this, "has_legal_hold");
    }

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    [TerraformArgument("resource_manager_id")]
    public TerraformValue<string> ResourceManagerId
    {
        get => new TerraformReference<string>(this, "resource_manager_id");
    }

}
