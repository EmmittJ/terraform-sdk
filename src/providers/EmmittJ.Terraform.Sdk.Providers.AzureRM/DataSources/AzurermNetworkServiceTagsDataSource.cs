using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkServiceTagsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("address_prefixes");
        this.WithOutput("ipv4_cidrs");
        this.WithOutput("ipv6_cidrs");
        this.WithOutput("name");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkServiceTagsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkServiceTagsDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
