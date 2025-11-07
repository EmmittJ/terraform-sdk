using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_active_slot resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermAppServiceActiveSlot : TerraformResource
{
    public AzurermAppServiceActiveSlot(string name) : base("azurerm_app_service_active_slot", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public TerraformProperty<string>? AppServiceName
    {
        get => GetProperty<TerraformProperty<string>>("app_service_name");
        set => this.WithProperty("app_service_name", value);
    }

    /// <summary>
    /// The app_service_slot_name attribute.
    /// </summary>
    public TerraformProperty<string>? AppServiceSlotName
    {
        get => GetProperty<TerraformProperty<string>>("app_service_slot_name");
        set => this.WithProperty("app_service_slot_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}
