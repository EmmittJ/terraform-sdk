using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_hpc_cache resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermHpcCache : TerraformResource
{
    public AzurermHpcCache(string name) : base("azurerm_hpc_cache", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("mount_addresses");
    }

    /// <summary>
    /// The automatically_rotate_key_to_latest_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticallyRotateKeyToLatestEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automatically_rotate_key_to_latest_enabled");
        set => this.WithProperty("automatically_rotate_key_to_latest_enabled", value);
    }

    /// <summary>
    /// The cache_size_in_gb attribute.
    /// </summary>
    public TerraformProperty<double>? CacheSizeInGb
    {
        get => GetProperty<TerraformProperty<double>>("cache_size_in_gb");
        set => this.WithProperty("cache_size_in_gb", value);
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
    /// The key_vault_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KeyVaultKeyId
    {
        get => GetProperty<TerraformProperty<string>>("key_vault_key_id");
        set => this.WithProperty("key_vault_key_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mtu attribute.
    /// </summary>
    public TerraformProperty<double>? Mtu
    {
        get => GetProperty<TerraformProperty<double>>("mtu");
        set => this.WithProperty("mtu", value);
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
    /// The ntp_server attribute.
    /// </summary>
    public TerraformProperty<string>? NtpServer
    {
        get => GetProperty<TerraformProperty<string>>("ntp_server");
        set => this.WithProperty("ntp_server", value);
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
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The mount_addresses attribute.
    /// </summary>
    public TerraformExpression MountAddresses => this["mount_addresses"];

}
