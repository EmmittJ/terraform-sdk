using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for soa_record in AzurermDnsZone.
/// Nesting mode: list
/// </summary>
public class AzurermDnsZoneSoaRecordBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    public TerraformValue<double>? ExpireTime
    {
        get => new TerraformReference<double>(this, "expire_time");
        set => SetArgument("expire_time", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    public TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
    }

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    public TerraformValue<double>? MinimumTtl
    {
        get => new TerraformReference<double>(this, "minimum_ttl");
        set => SetArgument("minimum_ttl", value);
    }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    public TerraformValue<double>? RefreshTime
    {
        get => new TerraformReference<double>(this, "refresh_time");
        set => SetArgument("refresh_time", value);
    }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    public TerraformValue<double>? RetryTime
    {
        get => new TerraformReference<double>(this, "retry_time");
        set => SetArgument("retry_time", value);
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformValue<double>? SerialNumber
    {
        get => new TerraformReference<double>(this, "serial_number");
        set => SetArgument("serial_number", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double>? Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
        set => SetArgument("ttl", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDnsZone.
/// Nesting mode: single
/// </summary>
public class AzurermDnsZoneTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_dns_zone Terraform resource.
/// Manages a azurerm_dns_zone resource.
/// </summary>
public partial class AzurermDnsZone(string name) : TerraformResource("azurerm_dns_zone", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
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
    /// SoaRecord block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoaRecord block(s) allowed")]
    public TerraformList<AzurermDnsZoneSoaRecordBlock>? SoaRecord
    {
        get => GetArgument<TerraformList<AzurermDnsZoneSoaRecordBlock>>("soa_record");
        set => SetArgument("soa_record", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDnsZoneTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDnsZoneTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
