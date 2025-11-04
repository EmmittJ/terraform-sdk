using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public string? ArcMachineId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arc_machine_id")?.Value;
        set => this.WithProperty("arc_machine_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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

}
