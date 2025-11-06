using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_hub_route_table resource.
/// </summary>
public class AzurermVirtualHubRouteTable : TerraformResource
{
    public AzurermVirtualHubRouteTable(string name) : base("azurerm_virtual_hub_route_table", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The labels attribute.
    /// </summary>
    public HashSet<string>? Labels
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("labels")?.Value;
        set => this.WithProperty("labels", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The virtual_hub_id attribute.
    /// </summary>
    public string? VirtualHubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_hub_id")?.Value;
        set => this.WithProperty("virtual_hub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
