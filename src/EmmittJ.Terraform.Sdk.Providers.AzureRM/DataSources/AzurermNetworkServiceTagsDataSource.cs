using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_network_service_tags.
/// </summary>
public class AzurermNetworkServiceTagsDataSource : TerraformDataSource
{
    public AzurermNetworkServiceTagsDataSource(string name) : base("azurerm_network_service_tags", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("address_prefixes");
        this.DeclareOutput("ipv4_cidrs");
        this.DeclareOutput("ipv6_cidrs");
        this.DeclareOutput("name");
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location_filter attribute.
    /// </summary>
    public string? LocationFilter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location_filter")?.Value;
        set => this.WithProperty("location_filter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformExpression AddressPrefixes => this["address_prefixes"];

    /// <summary>
    /// The ipv4_cidrs attribute.
    /// </summary>
    public TerraformExpression Ipv4Cidrs => this["ipv4_cidrs"];

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    public TerraformExpression Ipv6Cidrs => this["ipv6_cidrs"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
