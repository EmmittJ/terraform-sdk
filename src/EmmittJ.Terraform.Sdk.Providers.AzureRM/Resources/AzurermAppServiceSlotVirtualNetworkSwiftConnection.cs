using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_slot_virtual_network_swift_connection resource.
/// </summary>
public class AzurermAppServiceSlotVirtualNetworkSwiftConnection : TerraformResource
{
    public AzurermAppServiceSlotVirtualNetworkSwiftConnection(string name) : base("azurerm_app_service_slot_virtual_network_swift_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The app_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AppServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_service_id");
        set => this.WithProperty("app_service_id", value);
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
    /// The slot_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SlotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("slot_name");
        set => this.WithProperty("slot_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

}
