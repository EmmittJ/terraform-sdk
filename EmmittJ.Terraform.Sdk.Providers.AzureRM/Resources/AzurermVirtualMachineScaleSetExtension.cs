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
    public bool? AutoUpgradeMinorVersion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("auto_upgrade_minor_version")?.Value;
        set => this.WithProperty("auto_upgrade_minor_version", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public bool? AutomaticUpgradeEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_upgrade_enabled")?.Value;
        set => this.WithProperty("automatic_upgrade_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    public bool? FailureSuppressionEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("failure_suppression_enabled")?.Value;
        set => this.WithProperty("failure_suppression_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public string? ForceUpdateTag
    {
        get => GetProperty<TerraformLiteralProperty<string>>("force_update_tag")?.Value;
        set => this.WithProperty("force_update_tag", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public string? ProtectedSettings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("protected_settings")?.Value;
        set => this.WithProperty("protected_settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public List<string>? ProvisionAfterExtensions
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("provision_after_extensions")?.Value;
        set => this.WithProperty("provision_after_extensions", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public string? Publisher
    {
        get => GetProperty<TerraformLiteralProperty<string>>("publisher")?.Value;
        set => this.WithProperty("publisher", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public string? Settings
    {
        get => GetProperty<TerraformLiteralProperty<string>>("settings")?.Value;
        set => this.WithProperty("settings", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    public string? TypeHandlerVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type_handler_version")?.Value;
        set => this.WithProperty("type_handler_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_machine_scale_set_id attribute.
    /// </summary>
    public string? VirtualMachineScaleSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_machine_scale_set_id")?.Value;
        set => this.WithProperty("virtual_machine_scale_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
