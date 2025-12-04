using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for extension in AzurermSecurityCenterSubscriptionPricing.
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
        get => GetArgument<TerraformMap<string>>("additional_extension_properties");
        set => SetArgument("additional_extension_properties", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermSecurityCenterSubscriptionPricing.
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
/// Represents a azurerm_security_center_subscription_pricing Terraform resource.
/// Manages a azurerm_security_center_subscription_pricing resource.
/// </summary>
public partial class AzurermSecurityCenterSubscriptionPricing(string name) : TerraformResource("azurerm_security_center_subscription_pricing", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string>? ResourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("resource_type");
        set => SetArgument("resource_type", value);
    }

    /// <summary>
    /// The subplan attribute.
    /// </summary>
    public TerraformValue<string>? Subplan
    {
        get => GetArgument<TerraformValue<string>>("subplan");
        set => SetArgument("subplan", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// Extension block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermSecurityCenterSubscriptionPricingExtensionBlock>? Extension
    {
        get => GetArgument<TerraformSet<AzurermSecurityCenterSubscriptionPricingExtensionBlock>>("extension");
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
