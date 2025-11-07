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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The location_filter attribute.
    /// </summary>
    public TerraformProperty<string>? LocationFilter
    {
        get => GetProperty<TerraformProperty<string>>("location_filter");
        set => this.WithProperty("location_filter", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
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
