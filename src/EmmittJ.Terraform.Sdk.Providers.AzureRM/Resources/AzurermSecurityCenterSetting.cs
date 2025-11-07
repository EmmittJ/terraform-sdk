using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_security_center_setting resource.
/// </summary>
public class AzurermSecurityCenterSetting : TerraformResource
{
    public AzurermSecurityCenterSetting(string name) : base("azurerm_security_center_setting", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The setting_name attribute.
    /// </summary>
    public TerraformProperty<string>? SettingName
    {
        get => GetProperty<TerraformProperty<string>>("setting_name");
        set => this.WithProperty("setting_name", value);
    }

}
