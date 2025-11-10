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
        set => SetProperty("role_definition_id", value);
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        set => SetProperty("service_principal_id", value);
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
        SetOutput("create_ui_definition");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("lock_level");
        SetOutput("main_template");
        SetOutput("name");
        SetOutput("package_enabled");
        SetOutput("package_file_uri");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The create_ui_definition attribute.
    /// </summary>
    public TerraformProperty<string> CreateUiDefinition
    {
        get => GetRequiredOutput<TerraformProperty<string>>("create_ui_definition");
        set => SetProperty("create_ui_definition", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The lock_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LockLevel is required")]
    public required TerraformProperty<string> LockLevel
    {
        get => GetRequiredOutput<TerraformProperty<string>>("lock_level");
        set => SetProperty("lock_level", value);
    }

    /// <summary>
    /// The main_template attribute.
    /// </summary>
    public TerraformProperty<string> MainTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("main_template");
        set => SetProperty("main_template", value);
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
    /// The package_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PackageEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("package_enabled");
        set => SetProperty("package_enabled", value);
    }

    /// <summary>
    /// The package_file_uri attribute.
    /// </summary>
    public TerraformProperty<string> PackageFileUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("package_file_uri");
        set => SetProperty("package_file_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermManagedApplicationDefinitionAuthorizationBlock>? Authorization
    {
        set => SetProperty("authorization", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedApplicationDefinitionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
