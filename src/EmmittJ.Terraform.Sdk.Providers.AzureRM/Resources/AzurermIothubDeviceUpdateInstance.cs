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
    public string? DeviceUpdateAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("device_update_account_id")?.Value;
        set => this.WithProperty("device_update_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The diagnostic_enabled attribute.
    /// </summary>
    public bool? DiagnosticEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("diagnostic_enabled")?.Value;
        set => this.WithProperty("diagnostic_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The iothub_id attribute.
    /// </summary>
    public string? IothubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_id")?.Value;
        set => this.WithProperty("iothub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

}
