using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for namespace_junction in .
/// Nesting mode: set
/// </summary>
public class AzurermHpcCacheNfsTargetNamespaceJunctionBlock : TerraformBlock
{
    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    public TerraformProperty<string>? AccessPolicyName
    {
        get => GetProperty<TerraformProperty<string>>("access_policy_name");
        set => WithProperty("access_policy_name", value);
    }

    /// <summary>
    /// The namespace_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacePath is required")]
    public required TerraformProperty<string> NamespacePath
    {
        get => GetProperty<TerraformProperty<string>>("namespace_path");
        set => WithProperty("namespace_path", value);
    }

    /// <summary>
    /// The nfs_export attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NfsExport is required")]
    public required TerraformProperty<string> NfsExport
    {
        get => GetProperty<TerraformProperty<string>>("nfs_export");
        set => WithProperty("nfs_export", value);
    }

    /// <summary>
    /// The target_path attribute.
    /// </summary>
    public TerraformProperty<string>? TargetPath
    {
        get => GetProperty<TerraformProperty<string>>("target_path");
        set => WithProperty("target_path", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHpcCacheNfsTargetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_hpc_cache_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermHpcCacheNfsTarget : TerraformResource
{
    public AzurermHpcCacheNfsTarget(string name) : base("azurerm_hpc_cache_nfs_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheName is required")]
    public required TerraformProperty<string> CacheName
    {
        get => GetProperty<TerraformProperty<string>>("cache_name");
        set => this.WithProperty("cache_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The target_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetHostName is required")]
    public required TerraformProperty<string> TargetHostName
    {
        get => GetProperty<TerraformProperty<string>>("target_host_name");
        set => this.WithProperty("target_host_name", value);
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageModel is required")]
    public required TerraformProperty<string> UsageModel
    {
        get => GetProperty<TerraformProperty<string>>("usage_model");
        set => this.WithProperty("usage_model", value);
    }

    /// <summary>
    /// The verification_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? VerificationTimerInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("verification_timer_in_seconds");
        set => this.WithProperty("verification_timer_in_seconds", value);
    }

    /// <summary>
    /// The write_back_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? WriteBackTimerInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("write_back_timer_in_seconds");
        set => this.WithProperty("write_back_timer_in_seconds", value);
    }

    /// <summary>
    /// Block for namespace_junction.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NamespaceJunction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 NamespaceJunction block(s) allowed")]
    public HashSet<AzurermHpcCacheNfsTargetNamespaceJunctionBlock>? NamespaceJunction
    {
        get => GetProperty<HashSet<AzurermHpcCacheNfsTargetNamespaceJunctionBlock>>("namespace_junction");
        set => this.WithProperty("namespace_junction", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHpcCacheNfsTargetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermHpcCacheNfsTargetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
