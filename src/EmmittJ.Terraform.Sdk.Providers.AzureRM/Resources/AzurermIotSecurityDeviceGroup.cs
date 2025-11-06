using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iot_security_device_group resource.
/// </summary>
public class AzurermIotSecurityDeviceGroup : TerraformResource
{
    public AzurermIotSecurityDeviceGroup(string name) : base("azurerm_iot_security_device_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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

}
