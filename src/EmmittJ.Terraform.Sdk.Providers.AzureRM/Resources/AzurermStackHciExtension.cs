using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_stack_hci_extension resource.
/// </summary>
public class AzurermStackHciExtension : TerraformResource
{
    public AzurermStackHciExtension(string name) : base("azurerm_stack_hci_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arc_setting_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ArcSettingId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arc_setting_id");
        set => this.WithProperty("arc_setting_id", value);
    }

    /// <summary>
    /// The auto_upgrade_minor_version_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoUpgradeMinorVersionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_upgrade_minor_version_enabled");
        set => this.WithProperty("auto_upgrade_minor_version_enabled", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutomaticUpgradeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_upgrade_enabled");
        set => this.WithProperty("automatic_upgrade_enabled", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ProtectedSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protected_settings");
        set => this.WithProperty("protected_settings", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Publisher
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher");
        set => this.WithProperty("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Settings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("settings");
        set => this.WithProperty("settings", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TypeHandlerVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type_handler_version");
        set => this.WithProperty("type_handler_version", value);
    }

}
