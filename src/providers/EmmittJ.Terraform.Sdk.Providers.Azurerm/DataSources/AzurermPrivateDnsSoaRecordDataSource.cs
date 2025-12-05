using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPrivateDnsSoaRecordDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_private_dns_soa_record Terraform data source.
/// Retrieves information about a azurerm_private_dns_soa_record.
/// </summary>
public partial class AzurermPrivateDnsSoaRecordDataSource(string name) : TerraformDataSource("azurerm_private_dns_soa_record", name)
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
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
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    public required TerraformValue<string> ZoneName
    {
        get => GetRequiredArgument<TerraformValue<string>>("zone_name");
        set => SetArgument("zone_name", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => CreateReference("email");

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    public TerraformValue<double> ExpireTime
        => CreateReference("expire_time");

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => CreateReference("fqdn");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string> HostName
        => CreateReference("host_name");

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    public TerraformValue<double> MinimumTtl
        => CreateReference("minimum_ttl");

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    public TerraformValue<double> RefreshTime
        => CreateReference("refresh_time");

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    public TerraformValue<double> RetryTime
        => CreateReference("retry_time");

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformValue<double> SerialNumber
        => CreateReference("serial_number");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double> Ttl
        => CreateReference("ttl");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
