using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for authorization in .
/// Nesting mode: set
/// </summary>
public class AzurermManagedApplicationDefinitionAuthorizationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authorization";

    /// <summary>
    /// The role_definition_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleDefinitionId is required")]
    [TerraformArgument("role_definition_id")]
    public required TerraformValue<string> RoleDefinitionId
    {
        get => new TerraformReference<string>(this, "role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    [TerraformArgument("service_principal_id")]
    public required TerraformValue<string> ServicePrincipalId
    {
        get => new TerraformReference<string>(this, "service_principal_id");
        set => SetArgument("service_principal_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedApplicationDefinitionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_managed_application_definition resource.
/// </summary>
public class AzurermManagedApplicationDefinition : TerraformResource
{
    public AzurermManagedApplicationDefinition(string name) : base("azurerm_managed_application_definition", name)
    {
    }

    /// <summary>
    /// The create_ui_definition attribute.
    /// </summary>
    [TerraformArgument("create_ui_definition")]
    public TerraformValue<string>? CreateUiDefinition
    {
        get => new TerraformReference<string>(this, "create_ui_definition");
        set => SetArgument("create_ui_definition", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The lock_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LockLevel is required")]
    [TerraformArgument("lock_level")]
    public required TerraformValue<string> LockLevel
    {
        get => new TerraformReference<string>(this, "lock_level");
        set => SetArgument("lock_level", value);
    }

    /// <summary>
    /// The main_template attribute.
    /// </summary>
    [TerraformArgument("main_template")]
    public TerraformValue<string>? MainTemplate
    {
        get => new TerraformReference<string>(this, "main_template");
        set => SetArgument("main_template", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The package_enabled attribute.
    /// </summary>
    [TerraformArgument("package_enabled")]
    public TerraformValue<bool>? PackageEnabled
    {
        get => new TerraformReference<bool>(this, "package_enabled");
        set => SetArgument("package_enabled", value);
    }

    /// <summary>
    /// The package_file_uri attribute.
    /// </summary>
    [TerraformArgument("package_file_uri")]
    public TerraformValue<string>? PackageFileUri
    {
        get => new TerraformReference<string>(this, "package_file_uri");
        set => SetArgument("package_file_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for authorization.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("authorization")]
    public TerraformSet<AzurermManagedApplicationDefinitionAuthorizationBlock> Authorization { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermManagedApplicationDefinitionTimeoutsBlock Timeouts { get; set; } = new();

}
