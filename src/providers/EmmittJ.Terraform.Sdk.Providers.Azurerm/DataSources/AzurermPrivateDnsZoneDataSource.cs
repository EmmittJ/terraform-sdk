using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateDnsZoneDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_private_dns_zone Terraform data source.
/// Retrieves information about a azurerm_private_dns_zone.
/// </summary>
public partial class AzurermPrivateDnsZoneDataSource(string name) : TerraformDataSource("azurerm_private_dns_zone", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name") ?? AsReference("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    public TerraformValue<double> MaxNumberOfRecordSets
        => AsReference("max_number_of_record_sets");

    /// <summary>
    /// The max_number_of_virtual_network_links attribute.
    /// </summary>
    public TerraformValue<double> MaxNumberOfVirtualNetworkLinks
        => AsReference("max_number_of_virtual_network_links");

    /// <summary>
    /// The max_number_of_virtual_network_links_with_registration attribute.
    /// </summary>
    public TerraformValue<double> MaxNumberOfVirtualNetworkLinksWithRegistration
        => AsReference("max_number_of_virtual_network_links_with_registration");

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    public TerraformValue<double> NumberOfRecordSets
        => AsReference("number_of_record_sets");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsZoneDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsZoneDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
