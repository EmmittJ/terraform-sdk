using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_desktop_scaling_plan_host_pool_association resource.
/// </summary>
public class AzurermVirtualDesktopScalingPlanHostPoolAssociation : TerraformResource
{
    public AzurermVirtualDesktopScalingPlanHostPoolAssociation(string name) : base("azurerm_virtual_desktop_scaling_plan_host_pool_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The host_pool_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_pool_id");
        set => this.WithProperty("host_pool_id", value);
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
    /// The scaling_plan_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ScalingPlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scaling_plan_id");
        set => this.WithProperty("scaling_plan_id", value);
    }

}
