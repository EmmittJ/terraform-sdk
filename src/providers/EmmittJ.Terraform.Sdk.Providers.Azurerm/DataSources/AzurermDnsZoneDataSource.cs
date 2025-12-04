using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDnsZoneDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDnsZoneDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dns_zone Terraform data source.
/// Retrieves information about a azurerm_dns_zone.
/// </summary>
public partial class AzurermDnsZoneDataSource(string name) : TerraformDataSource("azurerm_dns_zone", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformValue<string>? ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    public TerraformValue<double> MaxNumberOfRecordSets
        => AsReference("max_number_of_record_sets");

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformSet<string> NameServers
        => AsReference("name_servers");

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    public TerraformValue<double> NumberOfRecordSets
        => AsReference("number_of_record_sets");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDnsZoneDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDnsZoneDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
