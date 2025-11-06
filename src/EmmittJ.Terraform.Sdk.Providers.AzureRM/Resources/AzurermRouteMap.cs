using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_route_map resource.
/// </summary>
public class AzurermRouteMap : TerraformResource
{
    public AzurermRouteMap(string name) : base("azurerm_route_map", name)
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
