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
    public TerraformProperty<string>? CreateUiDefinition
    {
        get => GetProperty<TerraformProperty<string>>("create_ui_definition");
        set => this.WithProperty("create_ui_definition", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The lock_level attribute.
    /// </summary>
    public TerraformProperty<string>? LockLevel
    {
        get => GetProperty<TerraformProperty<string>>("lock_level");
        set => this.WithProperty("lock_level", value);
    }

    /// <summary>
    /// The main_template attribute.
    /// </summary>
    public TerraformProperty<string>? MainTemplate
    {
        get => GetProperty<TerraformProperty<string>>("main_template");
        set => this.WithProperty("main_template", value);
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
    /// The package_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PackageEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("package_enabled");
        set => this.WithProperty("package_enabled", value);
    }

    /// <summary>
    /// The package_file_uri attribute.
    /// </summary>
    public TerraformProperty<string>? PackageFileUri
    {
        get => GetProperty<TerraformProperty<string>>("package_file_uri");
        set => this.WithProperty("package_file_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}
