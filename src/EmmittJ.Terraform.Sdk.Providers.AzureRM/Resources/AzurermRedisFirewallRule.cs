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
    public TerraformLiteralProperty<string>? EndIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_ip");
        set => this.WithProperty("end_ip", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The redis_cache_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RedisCacheName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_cache_name");
        set => this.WithProperty("redis_cache_name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The start_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_ip");
        set => this.WithProperty("start_ip", value);
    }

}
