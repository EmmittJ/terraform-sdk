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
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The host_pool_id attribute.
    /// </summary>
    public string? HostPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_pool_id")?.Value;
        set => this.WithProperty("host_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The scaling_plan_id attribute.
    /// </summary>
    public string? ScalingPlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("scaling_plan_id")?.Value;
        set => this.WithProperty("scaling_plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
