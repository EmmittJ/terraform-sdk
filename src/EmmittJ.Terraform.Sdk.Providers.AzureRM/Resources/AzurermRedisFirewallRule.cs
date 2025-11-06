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
    public string? EndIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_ip")?.Value;
        set => this.WithProperty("end_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The redis_cache_name attribute.
    /// </summary>
    public string? RedisCacheName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("redis_cache_name")?.Value;
        set => this.WithProperty("redis_cache_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The start_ip attribute.
    /// </summary>
    public string? StartIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_ip")?.Value;
        set => this.WithProperty("start_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
