using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciExtensionTimeoutsBlock : TerraformBlock
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
        SetOutput("arc_setting_id");
        SetOutput("auto_upgrade_minor_version_enabled");
        SetOutput("automatic_upgrade_enabled");
        SetOutput("id");
        SetOutput("name");
        SetOutput("protected_settings");
        SetOutput("publisher");
        SetOutput("settings");
        SetOutput("type");
        SetOutput("type_handler_version");
    }

    /// <summary>
    /// The arc_setting_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcSettingId is required")]
    public required TerraformProperty<string> ArcSettingId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arc_setting_id");
        set => SetProperty("arc_setting_id", value);
    }

    /// <summary>
    /// The auto_upgrade_minor_version_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutoUpgradeMinorVersionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_upgrade_minor_version_enabled");
        set => SetProperty("auto_upgrade_minor_version_enabled", value);
    }

    /// <summary>
    /// The automatic_upgrade_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> AutomaticUpgradeEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("automatic_upgrade_enabled");
        set => SetProperty("automatic_upgrade_enabled", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The protected_settings attribute.
    /// </summary>
    public TerraformProperty<string> ProtectedSettings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protected_settings");
        set => SetProperty("protected_settings", value);
    }

    /// <summary>
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
    {
        get => GetRequiredOutput<TerraformProperty<string>>("publisher");
        set => SetProperty("publisher", value);
    }

    /// <summary>
    /// The settings attribute.
    /// </summary>
    public TerraformProperty<string> Settings
    {
        get => GetRequiredOutput<TerraformProperty<string>>("settings");
        set => SetProperty("settings", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The type_handler_version attribute.
    /// </summary>
    public TerraformProperty<string> TypeHandlerVersion
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type_handler_version");
        set => SetProperty("type_handler_version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStackHciExtensionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
