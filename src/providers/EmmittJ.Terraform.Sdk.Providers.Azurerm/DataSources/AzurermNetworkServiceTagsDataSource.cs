using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNetworkServiceTagsDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNetworkServiceTagsDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_network_service_tags Terraform data source.
/// Retrieves information about a azurerm_network_service_tags.
/// </summary>
public partial class AzurermNetworkServiceTagsDataSource(string name) : TerraformDataSource("azurerm_network_service_tags", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The location_filter attribute.
    /// </summary>
    public TerraformValue<string>? LocationFilter
    {
        get => GetArgument<TerraformValue<string>>("location_filter");
        set => SetArgument("location_filter", value);
    }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetRequiredArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// The address_prefixes attribute.
    /// </summary>
    public TerraformList<string> AddressPrefixes
        => CreateReference("address_prefixes");

    /// <summary>
    /// The ipv4_cidrs attribute.
    /// </summary>
    public TerraformList<string> Ipv4Cidrs
        => CreateReference("ipv4_cidrs");

    /// <summary>
    /// The ipv6_cidrs attribute.
    /// </summary>
    public TerraformList<string> Ipv6Cidrs
        => CreateReference("ipv6_cidrs");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNetworkServiceTagsDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNetworkServiceTagsDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
