using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cosmosdb_postgresql_firewall_rule resource.
/// </summary>
public class AzurermCosmosdbPostgresqlFirewallRule : TerraformResource
{
    public AzurermCosmosdbPostgresqlFirewallRule(string name) : base("azurerm_cosmosdb_postgresql_firewall_rule", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    public string? ClusterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_id")?.Value;
        set => this.WithProperty("cluster_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The start_ip_address attribute.
    /// </summary>
    public string? StartIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_ip_address")?.Value;
        set => this.WithProperty("start_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
