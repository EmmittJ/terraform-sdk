using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_private_dns_zone.
/// </summary>
public class AzurermPrivateDnsZoneDataSource : TerraformDataSource
{
    public AzurermPrivateDnsZoneDataSource(string name) : base("azurerm_private_dns_zone", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [TerraformArgument("resource_group_name")]
    public TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPrivateDnsZoneDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    [TerraformArgument("max_number_of_record_sets")]
    public TerraformValue<double> MaxNumberOfRecordSets
    {
        get => new TerraformReference<double>(this, "max_number_of_record_sets");
    }

    /// <summary>
    /// The max_number_of_virtual_network_links attribute.
    /// </summary>
    [TerraformArgument("max_number_of_virtual_network_links")]
    public TerraformValue<double> MaxNumberOfVirtualNetworkLinks
    {
        get => new TerraformReference<double>(this, "max_number_of_virtual_network_links");
    }

    /// <summary>
    /// The max_number_of_virtual_network_links_with_registration attribute.
    /// </summary>
    [TerraformArgument("max_number_of_virtual_network_links_with_registration")]
    public TerraformValue<double> MaxNumberOfVirtualNetworkLinksWithRegistration
    {
        get => new TerraformReference<double>(this, "max_number_of_virtual_network_links_with_registration");
    }

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    [TerraformArgument("number_of_record_sets")]
    public TerraformValue<double> NumberOfRecordSets
    {
        get => new TerraformReference<double>(this, "number_of_record_sets");
    }

}
