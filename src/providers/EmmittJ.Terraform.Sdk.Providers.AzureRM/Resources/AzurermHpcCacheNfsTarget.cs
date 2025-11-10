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
        set => SetProperty("access_policy_name", value);
    }

    /// <summary>
    /// The namespace_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacePath is required")]
    public required TerraformProperty<string> NamespacePath
    {
        set => SetProperty("namespace_path", value);
    }

    /// <summary>
    /// The nfs_export attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NfsExport is required")]
    public required TerraformProperty<string> NfsExport
    {
        set => SetProperty("nfs_export", value);
    }

    /// <summary>
    /// The target_path attribute.
    /// </summary>
    public TerraformProperty<string>? TargetPath
    {
        set => SetProperty("target_path", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_hpc_cache_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermHpcCacheNfsTarget : TerraformResource
{
    public AzurermHpcCacheNfsTarget(string name) : base("azurerm_hpc_cache_nfs_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cache_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("target_host_name");
        SetOutput("usage_model");
        SetOutput("verification_timer_in_seconds");
        SetOutput("write_back_timer_in_seconds");
    }

    /// <summary>
    /// The cache_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CacheName is required")]
    public required TerraformProperty<string> CacheName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cache_name");
        set => SetProperty("cache_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The target_host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetHostName is required")]
    public required TerraformProperty<string> TargetHostName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_host_name");
        set => SetProperty("target_host_name", value);
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UsageModel is required")]
    public required TerraformProperty<string> UsageModel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("usage_model");
        set => SetProperty("usage_model", value);
    }

    /// <summary>
    /// The verification_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> VerificationTimerInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("verification_timer_in_seconds");
        set => SetProperty("verification_timer_in_seconds", value);
    }

    /// <summary>
    /// The write_back_timer_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> WriteBackTimerInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("write_back_timer_in_seconds");
        set => SetProperty("write_back_timer_in_seconds", value);
    }

    /// <summary>
    /// Block for namespace_junction.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespaceJunction is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NamespaceJunction block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 NamespaceJunction block(s) allowed")]
    public HashSet<AzurermHpcCacheNfsTargetNamespaceJunctionBlock>? NamespaceJunction
    {
        set => SetProperty("namespace_junction", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHpcCacheNfsTargetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
