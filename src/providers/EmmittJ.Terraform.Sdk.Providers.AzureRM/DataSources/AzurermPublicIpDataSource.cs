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
public class AzurermPublicIpDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_public_ip.
/// </summary>
public class AzurermPublicIpDataSource : TerraformDataSource
{
    public AzurermPublicIpDataSource(string name) : base("azurerm_public_ip", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermPublicIpDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [TerraformArgument("allocation_method")]
    public TerraformValue<string> AllocationMethod
    {
        get => new TerraformReference<string>(this, "allocation_method");
    }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    [TerraformArgument("ddos_protection_mode")]
    public TerraformValue<string> DdosProtectionMode
    {
        get => new TerraformReference<string>(this, "ddos_protection_mode");
    }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    [TerraformArgument("ddos_protection_plan_id")]
    public TerraformValue<string> DdosProtectionPlanId
    {
        get => new TerraformReference<string>(this, "ddos_protection_plan_id");
    }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    [TerraformArgument("domain_name_label")]
    public TerraformValue<string> DomainNameLabel
    {
        get => new TerraformReference<string>(this, "domain_name_label");
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
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    [TerraformArgument("idle_timeout_in_minutes")]
    public TerraformValue<double> IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    [TerraformArgument("ip_address")]
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    [TerraformArgument("ip_tags")]
    public TerraformMap<string> IpTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "ip_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    [TerraformArgument("ip_version")]
    public TerraformValue<string> IpVersion
    {
        get => new TerraformReference<string>(this, "ip_version");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    [TerraformArgument("reverse_fqdn")]
    public TerraformValue<string> ReverseFqdn
    {
        get => new TerraformReference<string>(this, "reverse_fqdn");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
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
    /// The zones attribute.
    /// </summary>
    [TerraformArgument("zones")]
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

}
