using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_device_update_instance resource.
/// </summary>
public class AzurermIothubDeviceUpdateInstance : TerraformResource
{
    public AzurermIothubDeviceUpdateInstance(string name) : base("azurerm_iothub_device_update_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The device_update_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? DeviceUpdateAccountId
    {
        get => GetProperty<TerraformProperty<string>>("device_update_account_id");
        set => this.WithProperty("device_update_account_id", value);
    }

    /// <summary>
    /// The diagnostic_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DiagnosticEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("diagnostic_enabled");
        set => this.WithProperty("diagnostic_enabled", value);
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
    /// The iothub_id attribute.
    /// </summary>
    public TerraformProperty<string>? IothubId
    {
        get => GetProperty<TerraformProperty<string>>("iothub_id");
        set => this.WithProperty("iothub_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}
