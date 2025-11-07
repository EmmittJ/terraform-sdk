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
    public TerraformLiteralProperty<string>? EndIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("end_ip_address");
        set => this.WithProperty("end_ip_address", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("server_name");
        set => this.WithProperty("server_name", value);
    }

    /// <summary>
    /// The start_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_ip_address");
        set => this.WithProperty("start_ip_address", value);
    }

}
