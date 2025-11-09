using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_machine_extension resource.
/// </summary>
public class AzurermVirtualMachineExtension : TerraformResource
{
    public AzurermVirtualMachineExtension(string name) : base("azurerm_virtual_machine_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The auto_upgrade_minor_version attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoUpgradeMinorVersion
    {
        get => GetProperty<TerraformProperty<bool>>("auto_upgrade_minor_version");
        set => this.WithProperty("auto_upgrade_minor_version", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? AutomaticUpgradeEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("automatic_upgrade_enabled");
        set => this.WithProperty("automatic_upgrade_enabled", value);
    }

    /// <summary>
    /// The failure_suppression_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FailureSuppressionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("failure_suppression_enabled");
        set => this.WithProperty("failure_suppression_enabled", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformProperty<string>? ProtectedSettings
    {
        get => GetProperty<TerraformProperty<string>>("protected_settings");
        set => this.WithProperty("protected_settings", value);
    }

    /// <summary>
    /// The provision_after_extensions attribute.
    /// </summary>
    public TerraformProperty<List<string>>? ProvisionAfterExtensions
    {
        get => GetProperty<TerraformProperty<List<string>>>("provision_after_extensions");
        set => this.WithProperty("provision_after_extensions", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    public TerraformProperty<string>? Publisher
    {
        get => GetProperty<TerraformProperty<string>>("publisher");
        set => this.WithProperty("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string>? Settings
    {
        get => GetProperty<TerraformProperty<string>>("settings");
        set => this.WithProperty("settings", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    public TerraformProperty<string>? TypeHandlerVersion
    {
        get => GetProperty<TerraformProperty<string>>("type_handler_version");
        set => this.WithProperty("type_handler_version", value);
    }

    /// <summary>
    /// The virtual_machine_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualMachineId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_machine_id");
        set => this.WithProperty("virtual_machine_id", value);
    }

}
