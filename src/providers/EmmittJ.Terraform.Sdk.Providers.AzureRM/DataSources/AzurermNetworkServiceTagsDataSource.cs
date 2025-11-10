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
        set => SetProperty("read", value);
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
        SetOutput("address_prefixes");
        SetOutput("ipv4_cidrs");
        SetOutput("ipv6_cidrs");
        SetOutput("name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("location_filter");
        SetOutput("service");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The location_filter attribute.
    /// </summary>
    public TerraformProperty<string> LocationFilter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location_filter");
        set => SetProperty("location_filter", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkServiceTagsDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
