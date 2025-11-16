using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermPublicIpTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_public_ip Terraform resource.
/// Manages a azurerm_public_ip resource.
/// </summary>
public partial class AzurermPublicIp(string name) : TerraformResource("azurerm_public_ip", name)
{
    /// <summary>
    /// The allocation_method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllocationMethod is required")]
    public required TerraformValue<string> AllocationMethod
    {
        get => new TerraformReference<string>(this, "allocation_method");
        set => SetArgument("allocation_method", value);
    }

    /// <summary>
    /// The ddos_protection_mode attribute.
    /// </summary>
    public TerraformValue<string>? DdosProtectionMode
    {
        get => new TerraformReference<string>(this, "ddos_protection_mode");
        set => SetArgument("ddos_protection_mode", value);
    }

    /// <summary>
    /// The ddos_protection_plan_id attribute.
    /// </summary>
    public TerraformValue<string>? DdosProtectionPlanId
    {
        get => new TerraformReference<string>(this, "ddos_protection_plan_id");
        set => SetArgument("ddos_protection_plan_id", value);
    }

    /// <summary>
    /// The domain_name_label attribute.
    /// </summary>
    public TerraformValue<string>? DomainNameLabel
    {
        get => new TerraformReference<string>(this, "domain_name_label");
        set => SetArgument("domain_name_label", value);
    }

    /// <summary>
    /// The domain_name_label_scope attribute.
    /// </summary>
    public TerraformValue<string>? DomainNameLabelScope
    {
        get => new TerraformReference<string>(this, "domain_name_label_scope");
        set => SetArgument("domain_name_label_scope", value);
    }

    /// <summary>
    /// The edge_zone attribute.
    /// </summary>
    public TerraformValue<string>? EdgeZone
    {
        get => new TerraformReference<string>(this, "edge_zone");
        set => SetArgument("edge_zone", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The idle_timeout_in_minutes attribute.
    /// </summary>
    public TerraformValue<double>? IdleTimeoutInMinutes
    {
        get => new TerraformReference<double>(this, "idle_timeout_in_minutes");
        set => SetArgument("idle_timeout_in_minutes", value);
    }

    /// <summary>
    /// The ip_tags attribute.
    /// </summary>
    public TerraformMap<string>? IpTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "ip_tags").ResolveNodes(ctx));
        set => SetArgument("ip_tags", value);
    }

    /// <summary>
    /// The ip_version attribute.
    /// </summary>
    public TerraformValue<string>? IpVersion
    {
        get => new TerraformReference<string>(this, "ip_version");
        set => SetArgument("ip_version", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The public_ip_prefix_id attribute.
    /// </summary>
    public TerraformValue<string>? PublicIpPrefixId
    {
        get => new TerraformReference<string>(this, "public_ip_prefix_id");
        set => SetArgument("public_ip_prefix_id", value);
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
    /// The reverse_fqdn attribute.
    /// </summary>
    public TerraformValue<string>? ReverseFqdn
    {
        get => new TerraformReference<string>(this, "reverse_fqdn");
        set => SetArgument("reverse_fqdn", value);
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string>? Sku
    {
        get => new TerraformReference<string>(this, "sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    public TerraformValue<string>? SkuTier
    {
        get => new TerraformReference<string>(this, "sku_tier");
        set => SetArgument("sku_tier", value);
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
    /// The zones attribute.
    /// </summary>
    public TerraformSet<string>? Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermPublicIpTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermPublicIpTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
