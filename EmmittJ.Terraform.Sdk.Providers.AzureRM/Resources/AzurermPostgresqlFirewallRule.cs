using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_postgresql_firewall_rule resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermPostgresqlFirewallRule : TerraformResource
{
    public AzurermPostgresqlFirewallRule(string name) : base("azurerm_postgresql_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The end_ip_address attribute.
    /// </summary>
    public string? EndIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_ip_address")?.Value;
        set => this.WithProperty("end_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The server_name attribute.
    /// </summary>
    public string? ServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_name")?.Value;
        set => this.WithProperty("server_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_ip_address attribute.
    /// </summary>
    public string? StartIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_ip_address")?.Value;
        set => this.WithProperty("start_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
