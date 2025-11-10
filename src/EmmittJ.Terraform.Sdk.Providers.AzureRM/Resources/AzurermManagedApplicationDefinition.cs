using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for authorization in .
/// Nesting mode: set
/// </summary>
public class AzurermManagedApplicationDefinitionAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    public required TerraformProperty<string> RoleDefinitionId
    {
        get => GetProperty<TerraformProperty<string>>("role_definition_id");
        set => WithProperty("role_definition_id", value);
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => WithProperty("service_principal_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedApplicationDefinitionTimeoutsBlock : TerraformBlock
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The lock_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LockLevel is required")]
    public required TerraformProperty<string> LockLevel
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    /// Block for authorization.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermManagedApplicationDefinitionAuthorizationBlock>? Authorization
    {
        get => GetProperty<HashSet<AzurermManagedApplicationDefinitionAuthorizationBlock>>("authorization");
        set => this.WithProperty("authorization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedApplicationDefinitionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagedApplicationDefinitionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
