using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_redis_firewall_rule resource.
/// </summary>
public class AzurermRedisFirewallRule : TerraformResource
{
    public AzurermRedisFirewallRule(string name) : base("azurerm_redis_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The end_ip attribute.
    /// </summary>
    public TerraformProperty<string>? EndIp
    {
        get => GetProperty<TerraformProperty<string>>("end_ip");
        set => this.WithProperty("end_ip", value);
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
    /// The redis_cache_name attribute.
    /// </summary>
    public TerraformProperty<string>? RedisCacheName
    {
        get => GetProperty<TerraformProperty<string>>("redis_cache_name");
        set => this.WithProperty("redis_cache_name", value);
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
    /// The start_ip attribute.
    /// </summary>
    public TerraformProperty<string>? StartIp
    {
        get => GetProperty<TerraformProperty<string>>("start_ip");
        set => this.WithProperty("start_ip", value);
    }

}
