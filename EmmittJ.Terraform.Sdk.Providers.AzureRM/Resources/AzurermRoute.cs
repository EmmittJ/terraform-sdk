using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_route resource.
/// </summary>
public class AzurermRoute : TerraformResource
{
    public AzurermRoute(string name) : base("azurerm_route", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The address_prefix attribute.
    /// </summary>
    public string? AddressPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("address_prefix")?.Value;
        set => this.WithProperty("address_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The next_hop_in_ip_address attribute.
    /// </summary>
    public string? NextHopInIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_in_ip_address")?.Value;
        set => this.WithProperty("next_hop_in_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The next_hop_type attribute.
    /// </summary>
    public string? NextHopType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("next_hop_type")?.Value;
        set => this.WithProperty("next_hop_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The route_table_name attribute.
    /// </summary>
    public string? RouteTableName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("route_table_name")?.Value;
        set => this.WithProperty("route_table_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
