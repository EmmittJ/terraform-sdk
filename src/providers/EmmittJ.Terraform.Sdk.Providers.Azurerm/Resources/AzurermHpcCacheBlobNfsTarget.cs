using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermHpcCacheBlobNfsTarget.
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
/// Represents a azurerm_hpc_cache_blob_nfs_target Terraform resource.
/// Manages a azurerm_hpc_cache_blob_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermHpcCacheBlobNfsTarget(string name) : TerraformResource("azurerm_hpc_cache_blob_nfs_target", name)
{
    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    public TerraformValue<string>? AccessPolicyName
    {
        get => GetArgument<TerraformValue<string>>("access_policy_name");
        set => SetArgument("access_policy_name", value);
    }

    /// <summary>
    /// The cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheName is required")]
    public required TerraformValue<string> CacheName
    {
        get => GetRequiredArgument<TerraformValue<string>>("cache_name");
        set => SetArgument("cache_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The namespace_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacePath is required")]
    public required TerraformValue<string> NamespacePath
    {
        get => GetRequiredArgument<TerraformValue<string>>("namespace_path");
        set => SetArgument("namespace_path", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    public required TerraformValue<string> StorageContainerId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_container_id");
        set => SetArgument("storage_container_id", value);
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageModel is required")]
    public required TerraformValue<string> UsageModel
    {
        get => GetRequiredArgument<TerraformValue<string>>("usage_model");
        set => SetArgument("usage_model", value);
    }

    /// <summary>
    /// The verification_timer_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? VerificationTimerInSeconds
    {
        get => GetArgument<TerraformValue<double>>("verification_timer_in_seconds");
        set => SetArgument("verification_timer_in_seconds", value);
    }

    /// <summary>
    /// The write_back_timer_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? WriteBackTimerInSeconds
    {
        get => GetArgument<TerraformValue<double>>("write_back_timer_in_seconds");
        set => SetArgument("write_back_timer_in_seconds", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHpcCacheBlobNfsTargetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHpcCacheBlobNfsTargetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
