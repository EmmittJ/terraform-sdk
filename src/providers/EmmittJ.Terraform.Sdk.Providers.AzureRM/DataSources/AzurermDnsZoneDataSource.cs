using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "read");
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
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The max_number_of_record_sets attribute.
    /// </summary>
    public TerraformValue<double> MaxNumberOfRecordSets
    {
        get => new TerraformReference<double>(this, "max_number_of_record_sets");
    }

    /// <summary>
    /// The name_servers attribute.
    /// </summary>
    public TerraformSet<string> NameServers
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "name_servers").ResolveNodes(ctx));
    }

    /// <summary>
    /// The number_of_record_sets attribute.
    /// </summary>
    public TerraformValue<double> NumberOfRecordSets
    {
        get => new TerraformReference<double>(this, "number_of_record_sets");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDnsZoneDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDnsZoneDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
