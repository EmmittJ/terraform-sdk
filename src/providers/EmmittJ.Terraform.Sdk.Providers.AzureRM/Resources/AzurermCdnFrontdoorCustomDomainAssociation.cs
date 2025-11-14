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
public class AzurermCdnFrontdoorCustomDomainAssociationTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_cdn_frontdoor_custom_domain_association resource.
/// </summary>
public class AzurermCdnFrontdoorCustomDomainAssociation : TerraformResource
{
    public AzurermCdnFrontdoorCustomDomainAssociation(string name) : base("azurerm_cdn_frontdoor_custom_domain_association", name)
    {
    }

    /// <summary>
    /// The cdn_frontdoor_custom_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorCustomDomainId is required")]
    [TerraformArgument("cdn_frontdoor_custom_domain_id")]
    public required TerraformValue<string> CdnFrontdoorCustomDomainId
    {
        get => new TerraformReference<string>(this, "cdn_frontdoor_custom_domain_id");
        set => SetArgument("cdn_frontdoor_custom_domain_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_route_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRouteIds is required")]
    [TerraformArgument("cdn_frontdoor_route_ids")]
    public TerraformList<string>? CdnFrontdoorRouteIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "cdn_frontdoor_route_ids").ResolveNodes(ctx));
        set => SetArgument("cdn_frontdoor_route_ids", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnFrontdoorCustomDomainAssociationTimeoutsBlock Timeouts { get; set; } = new();

}
