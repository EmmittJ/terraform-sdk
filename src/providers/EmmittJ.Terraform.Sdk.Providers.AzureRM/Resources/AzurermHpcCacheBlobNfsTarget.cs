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
public class AzurermHpcCacheBlobNfsTargetTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_hpc_cache_blob_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermHpcCacheBlobNfsTarget : TerraformResource
{
    public AzurermHpcCacheBlobNfsTarget(string name) : base("azurerm_hpc_cache_blob_nfs_target", name)
    {
    }

    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    [TerraformArgument("access_policy_name")]
    public TerraformValue<string>? AccessPolicyName
    {
        get => new TerraformReference<string>(this, "access_policy_name");
        set => SetArgument("access_policy_name", value);
    }

    /// <summary>
    /// The cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheName is required")]
    [TerraformArgument("cache_name")]
    public required TerraformValue<string> CacheName
    {
        get => new TerraformReference<string>(this, "cache_name");
        set => SetArgument("cache_name", value);
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
    /// The namespace_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacePath is required")]
    [TerraformArgument("namespace_path")]
    public required TerraformValue<string> NamespacePath
    {
        get => new TerraformReference<string>(this, "namespace_path");
        set => SetArgument("namespace_path", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    [TerraformArgument("storage_container_id")]
    public required TerraformValue<string> StorageContainerId
    {
        get => new TerraformReference<string>(this, "storage_container_id");
        set => SetArgument("storage_container_id", value);
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageModel is required")]
    [TerraformArgument("usage_model")]
    public required TerraformValue<string> UsageModel
    {
        get => new TerraformReference<string>(this, "usage_model");
        set => SetArgument("usage_model", value);
    }

    /// <summary>
    /// The verification_timer_in_seconds attribute.
    /// </summary>
    [TerraformArgument("verification_timer_in_seconds")]
    public TerraformValue<double>? VerificationTimerInSeconds
    {
        get => new TerraformReference<double>(this, "verification_timer_in_seconds");
        set => SetArgument("verification_timer_in_seconds", value);
    }

    /// <summary>
    /// The write_back_timer_in_seconds attribute.
    /// </summary>
    [TerraformArgument("write_back_timer_in_seconds")]
    public TerraformValue<double>? WriteBackTimerInSeconds
    {
        get => new TerraformReference<double>(this, "write_back_timer_in_seconds");
        set => SetArgument("write_back_timer_in_seconds", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermHpcCacheBlobNfsTargetTimeoutsBlock Timeouts { get; set; } = new();

}
