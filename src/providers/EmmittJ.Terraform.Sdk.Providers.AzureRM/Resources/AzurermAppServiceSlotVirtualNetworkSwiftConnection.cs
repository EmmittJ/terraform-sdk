using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSlotVirtualNetworkSwiftConnectionTimeoutsBlock : TerraformBlock
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
        SetOutput("app_service_id");
        SetOutput("id");
        SetOutput("slot_name");
        SetOutput("subnet_id");
    }

    /// <summary>
    /// The app_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceId is required")]
    public required TerraformProperty<string> AppServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_service_id");
        set => SetProperty("app_service_id", value);
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
    /// The slot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SlotName is required")]
    public required TerraformProperty<string> SlotName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("slot_name");
        set => SetProperty("slot_name", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceSlotVirtualNetworkSwiftConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
