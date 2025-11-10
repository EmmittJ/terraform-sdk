using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcMachineExtensionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_arc_machine_extension resource.
/// </summary>
public class AzurermArcMachineExtension : TerraformResource
{
    public AzurermArcMachineExtension(string name) : base("azurerm_arc_machine_extension", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The arc_machine_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ArcMachineId is required")]
    public required TerraformProperty<string> ArcMachineId
    {
        get => GetProperty<TerraformProperty<string>>("arc_machine_id");
        set => this.WithProperty("arc_machine_id", value);
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
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ForceUpdateTag
    {
        get => GetProperty<TerraformProperty<string>>("force_update_tag");
        set => this.WithProperty("force_update_tag", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    /// The publisher attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Publisher is required")]
    public required TerraformProperty<string> Publisher
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermArcMachineExtensionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermArcMachineExtensionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
