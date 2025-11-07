using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The subplan attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Subplan
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subplan");
        set => this.WithProperty("subplan", value);
    }

    /// <summary>
    /// The tier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tier");
        set => this.WithProperty("tier", value);
    }

}
