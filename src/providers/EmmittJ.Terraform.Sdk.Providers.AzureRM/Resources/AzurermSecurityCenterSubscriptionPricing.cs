using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for extension in .
/// Nesting mode: set
/// </summary>
public class AzurermSecurityCenterSubscriptionPricingExtensionBlock : TerraformBlock
{
    /// <summary>
    /// The additional_extension_properties attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? AdditionalExtensionProperties
    {
        set => SetProperty("additional_extension_properties", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterSubscriptionPricingTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_security_center_subscription_pricing resource.
/// </summary>
public class AzurermSecurityCenterSubscriptionPricing : TerraformResource
{
    public AzurermSecurityCenterSubscriptionPricing(string name) : base("azurerm_security_center_subscription_pricing", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("resource_type");
        SetOutput("subplan");
        SetOutput("tier");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The subplan attribute.
    /// </summary>
    public TerraformProperty<string> Subplan
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subplan");
        set => SetProperty("subplan", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformProperty<string> Tier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("tier");
        set => SetProperty("tier", value);
    }

    /// <summary>
    /// Block for extension.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermSecurityCenterSubscriptionPricingExtensionBlock>? Extension
    {
        set => SetProperty("extension", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSecurityCenterSubscriptionPricingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
