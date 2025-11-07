using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public TerraformProperty<string>? CacheName
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The target_host_name attribute.
    /// </summary>
    public TerraformProperty<string>? TargetHostName
    {
        get => GetProperty<TerraformProperty<string>>("target_host_name");
        set => this.WithProperty("target_host_name", value);
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    public TerraformProperty<string>? UsageModel
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

}
