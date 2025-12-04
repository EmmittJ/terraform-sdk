using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for namespace_junction in AzurermHpcCacheNfsTarget.
/// Nesting mode: set
/// </summary>
public class AzurermHpcCacheNfsTargetNamespaceJunctionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "namespace_junction";

    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    public TerraformValue<string>? AccessPolicyName
    {
        get => GetArgument<TerraformValue<string>>("access_policy_name");
        set => SetArgument("access_policy_name", value);
    }

    /// <summary>
    /// The namespace_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacePath is required")]
    public required TerraformValue<string> NamespacePath
    {
        get => GetArgument<TerraformValue<string>>("namespace_path");
        set => SetArgument("namespace_path", value);
    }

    /// <summary>
    /// The nfs_export attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NfsExport is required")]
    public required TerraformValue<string> NfsExport
    {
        get => GetArgument<TerraformValue<string>>("nfs_export");
        set => SetArgument("nfs_export", value);
    }

    /// <summary>
    /// The target_path attribute.
    /// </summary>
    public TerraformValue<string>? TargetPath
    {
        get => GetArgument<TerraformValue<string>>("target_path");
        set => SetArgument("target_path", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermHpcCacheNfsTarget.
/// Nesting mode: single
/// </summary>
public class AzurermHpcCacheNfsTargetTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_hpc_cache_nfs_target Terraform resource.
/// Manages a azurerm_hpc_cache_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermHpcCacheNfsTarget(string name) : TerraformResource("azurerm_hpc_cache_nfs_target", name)
{
    /// <summary>
    /// The cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheName is required")]
    public required TerraformValue<string> CacheName
    {
        get => GetArgument<TerraformValue<string>>("cache_name");
        set => SetArgument("cache_name", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The target_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetHostName is required")]
    public required TerraformValue<string> TargetHostName
    {
        get => GetArgument<TerraformValue<string>>("target_host_name");
        set => SetArgument("target_host_name", value);
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageModel is required")]
    public required TerraformValue<string> UsageModel
    {
        get => GetArgument<TerraformValue<string>>("usage_model");
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
    /// NamespaceJunction block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceJunction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NamespaceJunction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 NamespaceJunction block(s) allowed")]
    public required TerraformSet<AzurermHpcCacheNfsTargetNamespaceJunctionBlock> NamespaceJunction
    {
        get => GetRequiredArgument<TerraformSet<AzurermHpcCacheNfsTargetNamespaceJunctionBlock>>("namespace_junction");
        set => SetArgument("namespace_junction", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermHpcCacheNfsTargetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermHpcCacheNfsTargetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
