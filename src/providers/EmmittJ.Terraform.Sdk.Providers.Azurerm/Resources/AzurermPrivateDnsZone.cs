using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for soa_record in AzurermPrivateDnsZone.
/// Nesting mode: list
/// </summary>
public class AzurermPrivateDnsZoneSoaRecordBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "soa_record";

    /// <summary>
    /// The email attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Email is required")]
    public required TerraformValue<string> Email
    {
        get => GetArgument<TerraformValue<string>>("email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    public TerraformValue<double>? ExpireTime
    {
        get => GetArgument<TerraformValue<double>>("expire_time");
        set => SetArgument("expire_time", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string> HostName
        => AsReference("host_name");

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MinimumTtl
    {
        get => GetArgument<TerraformValue<double>>("minimum_ttl");
        set => SetArgument("minimum_ttl", value);
    }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    public TerraformValue<double>? RefreshTime
    {
        get => GetArgument<TerraformValue<double>>("refresh_time");
        set => SetArgument("refresh_time", value);
    }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    public TerraformValue<double>? RetryTime
    {
        get => GetArgument<TerraformValue<double>>("retry_time");
        set => SetArgument("retry_time", value);
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformValue<double> SerialNumber
        => AsReference("serial_number");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => GetArgument<TerraformValue<double>>("ttl");
        set => SetArgument("ttl", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermPrivateDnsZone.
/// Nesting mode: single
/// </summary>
public class AzurermPrivateDnsZoneTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_private_dns_zone Terraform resource.
/// Manages a azurerm_private_dns_zone resource.
/// </summary>
public partial class AzurermPrivateDnsZone(string name) : TerraformResource("azurerm_private_dns_zone", name)
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
    /// SoaRecord block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoaRecord block(s) allowed")]
    public TerraformList<AzurermPrivateDnsZoneSoaRecordBlock>? SoaRecord
    {
        get => GetArgument<TerraformList<AzurermPrivateDnsZoneSoaRecordBlock>>("soa_record");
        set => SetArgument("soa_record", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPrivateDnsZoneTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPrivateDnsZoneTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
