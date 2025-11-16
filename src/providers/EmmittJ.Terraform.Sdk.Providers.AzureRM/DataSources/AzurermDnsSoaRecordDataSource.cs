using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDnsSoaRecordDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_dns_soa_record Terraform data source.
/// Retrieves information about a azurerm_dns_soa_record.
/// </summary>
public partial class AzurermDnsSoaRecordDataSource(string name) : TerraformDataSource("azurerm_dns_soa_record", name)
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
    public TerraformValue<string>? Name
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
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    public required TerraformValue<string> ZoneName
    {
        get => new TerraformReference<string>(this, "zone_name");
        set => SetArgument("zone_name", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
    }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    public TerraformValue<double> ExpireTime
    {
        get => new TerraformReference<double>(this, "expire_time");
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
    public TerraformValue<double> MinimumTtl
    {
        get => new TerraformReference<double>(this, "minimum_ttl");
    }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    public TerraformValue<double> RefreshTime
    {
        get => new TerraformReference<double>(this, "refresh_time");
    }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    public TerraformValue<double> RetryTime
    {
        get => new TerraformReference<double>(this, "retry_time");
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    public TerraformValue<double> SerialNumber
    {
        get => new TerraformReference<double>(this, "serial_number");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<double> Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDnsSoaRecordDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDnsSoaRecordDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
