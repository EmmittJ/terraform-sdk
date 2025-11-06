using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_managed_application_definition resource.
/// </summary>
public class AzurermManagedApplicationDefinition : TerraformResource
{
    public AzurermManagedApplicationDefinition(string name) : base("azurerm_managed_application_definition", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The create_ui_definition attribute.
    /// </summary>
    public string? CreateUiDefinition
    {
        get => GetProperty<TerraformLiteralProperty<string>>("create_ui_definition")?.Value;
        set => this.WithProperty("create_ui_definition", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The lock_level attribute.
    /// </summary>
    public string? LockLevel
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lock_level")?.Value;
        set => this.WithProperty("lock_level", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The main_template attribute.
    /// </summary>
    public string? MainTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("main_template")?.Value;
        set => this.WithProperty("main_template", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The package_enabled attribute.
    /// </summary>
    public bool? PackageEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("package_enabled")?.Value;
        set => this.WithProperty("package_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The package_file_uri attribute.
    /// </summary>
    public string? PackageFileUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("package_file_uri")?.Value;
        set => this.WithProperty("package_file_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
