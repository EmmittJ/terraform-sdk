using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermHpcCacheBlobNfsTargetTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_hpc_cache_blob_nfs_target resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermHpcCacheBlobNfsTarget : TerraformResource
{
    public AzurermHpcCacheBlobNfsTarget(string name) : base("azurerm_hpc_cache_blob_nfs_target", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("access_policy_name");
        SetOutput("cache_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("namespace_path");
        SetOutput("resource_group_name");
        SetOutput("storage_container_id");
        SetOutput("usage_model");
        SetOutput("verification_timer_in_seconds");
        SetOutput("write_back_timer_in_seconds");
    }

    /// <summary>
    /// The access_policy_name attribute.
    /// </summary>
    public TerraformProperty<string> AccessPolicyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("access_policy_name");
        set => SetProperty("access_policy_name", value);
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
    /// The namespace_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NamespacePath is required")]
    public required TerraformProperty<string> NamespacePath
    {
        get => GetRequiredOutput<TerraformProperty<string>>("namespace_path");
        set => SetProperty("namespace_path", value);
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
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    public required TerraformProperty<string> StorageContainerId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_container_id");
        set => SetProperty("storage_container_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermHpcCacheBlobNfsTargetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
