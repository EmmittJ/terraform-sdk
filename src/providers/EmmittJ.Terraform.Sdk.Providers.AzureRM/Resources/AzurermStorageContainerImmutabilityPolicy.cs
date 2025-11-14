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
public class AzurermStorageContainerImmutabilityPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_storage_container_immutability_policy resource.
/// </summary>
public class AzurermStorageContainerImmutabilityPolicy : TerraformResource
{
    public AzurermStorageContainerImmutabilityPolicy(string name) : base("azurerm_storage_container_immutability_policy", name)
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
    /// The immutability_period_in_days attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImmutabilityPeriodInDays is required")]
    [TerraformArgument("immutability_period_in_days")]
    public required TerraformValue<double> ImmutabilityPeriodInDays
    {
        get => new TerraformReference<double>(this, "immutability_period_in_days");
        set => SetArgument("immutability_period_in_days", value);
    }

    /// <summary>
    /// The locked attribute.
    /// </summary>
    [TerraformArgument("locked")]
    public TerraformValue<bool>? Locked
    {
        get => new TerraformReference<bool>(this, "locked");
        set => SetArgument("locked", value);
    }

    /// <summary>
    /// The protected_append_writes_all_enabled attribute.
    /// </summary>
    [TerraformArgument("protected_append_writes_all_enabled")]
    public TerraformValue<bool>? ProtectedAppendWritesAllEnabled
    {
        get => new TerraformReference<bool>(this, "protected_append_writes_all_enabled");
        set => SetArgument("protected_append_writes_all_enabled", value);
    }

    /// <summary>
    /// The protected_append_writes_enabled attribute.
    /// </summary>
    [TerraformArgument("protected_append_writes_enabled")]
    public TerraformValue<bool>? ProtectedAppendWritesEnabled
    {
        get => new TerraformReference<bool>(this, "protected_append_writes_enabled");
        set => SetArgument("protected_append_writes_enabled", value);
    }

    /// <summary>
    /// The storage_container_resource_manager_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerResourceManagerId is required")]
    [TerraformArgument("storage_container_resource_manager_id")]
    public required TerraformValue<string> StorageContainerResourceManagerId
    {
        get => new TerraformReference<string>(this, "storage_container_resource_manager_id");
        set => SetArgument("storage_container_resource_manager_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermStorageContainerImmutabilityPolicyTimeoutsBlock Timeouts { get; set; } = new();

}
