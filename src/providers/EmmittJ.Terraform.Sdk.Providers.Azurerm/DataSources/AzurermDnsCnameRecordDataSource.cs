using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDnsCnameRecordDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDnsCnameRecordDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dns_cname_record Terraform data source.
/// Retrieves information about a azurerm_dns_cname_record.
/// </summary>
public partial class AzurermDnsCnameRecordDataSource(string name) : TerraformDataSource("azurerm_dns_cname_record", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    public required TerraformValue<string> ZoneName
    {
        get => GetArgument<TerraformValue<string>>("zone_name");
        set => SetArgument("zone_name", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The record attribute.
    /// </summary>
    public TerraformValue<string> Record
        => AsReference("record");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformValue<string> TargetResourceId
        => AsReference("target_resource_id");

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double> Ttl
        => AsReference("ttl");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDnsCnameRecordDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDnsCnameRecordDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
