using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_scale_set_extension resource.
/// </summary>
public class AzurermVirtualMachineScaleSetExtension : TerraformResource
{
    public AzurermVirtualMachineScaleSetExtension(string name) : base("azurerm_virtual_machine_scale_set_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AutoUpgradeMinorVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_upgrade_minor_version");
        set => this.WithProperty("auto_upgrade_minor_version", value);
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
    /// The failure_suppression_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FailureSuppressionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("failure_suppression_enabled");
        set => this.WithProperty("failure_suppression_enabled", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ForceUpdateTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("force_update_tag");
        set => this.WithProperty("force_update_tag", value);
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
    /// The provision_after_extensions attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? ProvisionAfterExtensions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("provision_after_extensions");
        set => this.WithProperty("provision_after_extensions", value);
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

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VirtualMachineScaleSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_scale_set_id");
        set => this.WithProperty("virtual_machine_scale_set_id", value);
    }

}
