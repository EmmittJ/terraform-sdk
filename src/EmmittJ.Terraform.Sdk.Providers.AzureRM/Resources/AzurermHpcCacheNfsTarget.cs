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
    public string? CacheName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cache_name")?.Value;
        set => this.WithProperty("cache_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_host_name attribute.
    /// </summary>
    public string? TargetHostName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_host_name")?.Value;
        set => this.WithProperty("target_host_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The usage_model attribute.
    /// </summary>
    public string? UsageModel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("usage_model")?.Value;
        set => this.WithProperty("usage_model", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The verification_timer_in_seconds attribute.
    /// </summary>
    public double? VerificationTimerInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("verification_timer_in_seconds")?.Value;
        set => this.WithProperty("verification_timer_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The write_back_timer_in_seconds attribute.
    /// </summary>
    public double? WriteBackTimerInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("write_back_timer_in_seconds")?.Value;
        set => this.WithProperty("write_back_timer_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

}
