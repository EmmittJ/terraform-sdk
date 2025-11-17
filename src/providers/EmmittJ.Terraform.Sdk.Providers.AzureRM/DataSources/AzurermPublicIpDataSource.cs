using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermPublicIpDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_public_ip Terraform data source.
/// Retrieves information about a azurerm_public_ip.
/// </summary>
public partial class AzurermPublicIpDataSource(string name) : TerraformDataSource("azurerm_public_ip", name)
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
    /// The allocation_method attribute.
    /// </summary>
    public TerraformValue<string> AllocationMethod
    {
        get => new TerraformReference<string>(this, "allocation_method");
    }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    public TerraformValue<string> DdosProtectionMode
    {
        get => new TerraformReference<string>(this, "ddos_protection_mode");
    }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    public TerraformValue<string> DdosProtectionPlanId
    {
        get => new TerraformReference<string>(this, "ddos_protection_plan_id");
    }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    public TerraformValue<string> DomainNameLabel
    {
        get => new TerraformReference<string>(this, "domain_name_label");
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double> IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
    }

    /// <summary>
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
    }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    public TerraformMap<string> IpTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "ip_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    public TerraformValue<string> IpVersion
    {
        get => new TerraformReference<string>(this, "ip_version");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The reverse_fqdn attribute.
    /// </summary>
    public TerraformValue<string> ReverseFqdn
    {
        get => new TerraformReference<string>(this, "reverse_fqdn");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
    {
        get => new TerraformReference<string>(this, "sku");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "zones").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPublicIpDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPublicIpDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
