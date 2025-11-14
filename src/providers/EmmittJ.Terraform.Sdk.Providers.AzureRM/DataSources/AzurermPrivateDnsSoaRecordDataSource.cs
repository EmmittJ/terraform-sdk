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
public class AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_private_dns_soa_record.
/// </summary>
public class AzurermPrivateDnsSoaRecordDataSource : TerraformDataSource
{
    public AzurermPrivateDnsSoaRecordDataSource(string name) : base("azurerm_private_dns_soa_record", name)
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
    [TerraformArgument("name")]
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The zone_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ZoneName is required")]
    [TerraformArgument("zone_name")]
    public required TerraformValue<string> ZoneName
    {
        get => new TerraformReference<string>(this, "zone_name");
        set => SetArgument("zone_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPrivateDnsSoaRecordDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformArgument("email")]
    public TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
    }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformArgument("expire_time")]
    public TerraformValue<double> ExpireTime
    {
        get => new TerraformReference<double>(this, "expire_time");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [TerraformArgument("fqdn")]
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [TerraformArgument("host_name")]
    public TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
    }

    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformArgument("minimum_ttl")]
    public TerraformValue<double> MinimumTtl
    {
        get => new TerraformReference<double>(this, "minimum_ttl");
    }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformArgument("refresh_time")]
    public TerraformValue<double> RefreshTime
    {
        get => new TerraformReference<double>(this, "refresh_time");
    }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformArgument("retry_time")]
    public TerraformValue<double> RetryTime
    {
        get => new TerraformReference<double>(this, "retry_time");
    }

    /// <summary>
    /// The serial_number attribute.
    /// </summary>
    [TerraformArgument("serial_number")]
    public TerraformValue<double> SerialNumber
    {
        get => new TerraformReference<double>(this, "serial_number");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    [TerraformArgument("ttl")]
    public TerraformValue<double> Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
    }

}
