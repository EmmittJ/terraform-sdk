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
/// Block type for soa_record in .
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
    [TerraformArgument("email")]
    public required TerraformValue<string> Email
    {
        get => new TerraformReference<string>(this, "email");
        set => SetArgument("email", value);
    }

    /// <summary>
    /// The expire_time attribute.
    /// </summary>
    [TerraformArgument("expire_time")]
    public TerraformValue<double>? ExpireTime
    {
        get => new TerraformReference<double>(this, "expire_time");
        set => SetArgument("expire_time", value);
    }



    /// <summary>
    /// The minimum_ttl attribute.
    /// </summary>
    [TerraformArgument("minimum_ttl")]
    public TerraformValue<double>? MinimumTtl
    {
        get => new TerraformReference<double>(this, "minimum_ttl");
        set => SetArgument("minimum_ttl", value);
    }

    /// <summary>
    /// The refresh_time attribute.
    /// </summary>
    [TerraformArgument("refresh_time")]
    public TerraformValue<double>? RefreshTime
    {
        get => new TerraformReference<double>(this, "refresh_time");
        set => SetArgument("refresh_time", value);
    }

    /// <summary>
    /// The retry_time attribute.
    /// </summary>
    [TerraformArgument("retry_time")]
    public TerraformValue<double>? RetryTime
    {
        get => new TerraformReference<double>(this, "retry_time");
        set => SetArgument("retry_time", value);
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
    /// The ttl attribute.
    /// </summary>
    [TerraformArgument("ttl")]
    public TerraformValue<double>? Ttl
    {
        get => new TerraformReference<double>(this, "ttl");
        set => SetArgument("ttl", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_private_dns_zone resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermPrivateDnsZone : TerraformResource
{
    public AzurermPrivateDnsZone(string name) : base("azurerm_private_dns_zone", name)
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
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
    /// Block for soa_record.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoaRecord block(s) allowed")]
    [TerraformArgument("soa_record")]
    public TerraformList<AzurermPrivateDnsZoneSoaRecordBlock> SoaRecord { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPrivateDnsZoneTimeoutsBlock Timeouts { get; set; } = new();

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
