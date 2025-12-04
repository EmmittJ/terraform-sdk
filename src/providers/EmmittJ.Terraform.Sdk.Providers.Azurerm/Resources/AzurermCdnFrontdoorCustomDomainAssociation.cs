using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermCdnFrontdoorCustomDomainAssociation.
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
/// Represents a azurerm_cdn_frontdoor_custom_domain_association Terraform resource.
/// Manages a azurerm_cdn_frontdoor_custom_domain_association resource.
/// </summary>
public partial class AzurermCdnFrontdoorCustomDomainAssociation(string name) : TerraformResource("azurerm_cdn_frontdoor_custom_domain_association", name)
{
    /// <summary>
    /// The cdn_frontdoor_custom_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorCustomDomainId is required")]
    public required TerraformValue<string> CdnFrontdoorCustomDomainId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cdn_frontdoor_custom_domain_id");
        set => SetArgument("cdn_frontdoor_custom_domain_id", value);
    }

    /// <summary>
    /// The cdn_frontdoor_route_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnFrontdoorRouteIds is required")]
    public TerraformList<string>? CdnFrontdoorRouteIds
    {
        get => GetArgument<TerraformList<string>>("cdn_frontdoor_route_ids");
        set => SetArgument("cdn_frontdoor_route_ids", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnFrontdoorCustomDomainAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnFrontdoorCustomDomainAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
