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
    public string? AppServiceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_name")?.Value;
        set => this.WithProperty("app_service_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The app_service_slot_name attribute.
    /// </summary>
    public string? AppServiceSlotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_slot_name")?.Value;
        set => this.WithProperty("app_service_slot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
