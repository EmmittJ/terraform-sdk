using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermSecurityCenterSubscriptionPricingExtensionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "extension";

    /// <summary>
    /// The additional_extension_properties attribute.
    /// </summary>
    public TerraformMap<string>? AdditionalExtensionProperties
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "additional_extension_properties").ResolveNodes(ctx));
        set => SetArgument("additional_extension_properties", value);
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

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterSubscriptionPricingTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_security_center_subscription_pricing Terraform resource.
/// Manages a azurerm_security_center_subscription_pricing resource.
/// </summary>
public partial class AzurermSecurityCenterSubscriptionPricing(string name) : TerraformResource("azurerm_security_center_subscription_pricing", name)
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
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The subplan attribute.
    /// </summary>
    public TerraformValue<string>? Subplan
    {
        get => new TerraformReference<string>(this, "subplan");
        set => SetArgument("subplan", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => new TerraformReference<string>(this, "tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// Extension block (nesting mode: set).
    /// </summary>
    public AzurermSecurityCenterSubscriptionPricingExtensionBlock? Extension
    {
        get => GetArgument<AzurermSecurityCenterSubscriptionPricingExtensionBlock>("extension");
        set => SetArgument("extension", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSecurityCenterSubscriptionPricingTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSecurityCenterSubscriptionPricingTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
