using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for authorization in AzurermManagedApplicationDefinition.
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
    public required TerraformValue<string> RoleDefinitionId
    {
        get => GetArgument<TerraformValue<string>>("role_definition_id");
        set => SetArgument("role_definition_id", value);
    }

    /// <summary>
    /// The service_principal_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformValue<string> ServicePrincipalId
    {
        get => GetArgument<TerraformValue<string>>("service_principal_id");
        set => SetArgument("service_principal_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermManagedApplicationDefinition.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_managed_application_definition Terraform resource.
/// Manages a azurerm_managed_application_definition resource.
/// </summary>
public partial class AzurermManagedApplicationDefinition(string name) : TerraformResource("azurerm_managed_application_definition", name)
{
    /// <summary>
    /// The create_ui_definition attribute.
    /// </summary>
    public TerraformValue<string>? CreateUiDefinition
    {
        get => GetArgument<TerraformValue<string>>("create_ui_definition");
        set => SetArgument("create_ui_definition", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The lock_level attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LockLevel is required")]
    public required TerraformValue<string> LockLevel
    {
        get => GetArgument<TerraformValue<string>>("lock_level");
        set => SetArgument("lock_level", value);
    }

    /// <summary>
    /// The main_template attribute.
    /// </summary>
    public TerraformValue<string>? MainTemplate
    {
        get => GetArgument<TerraformValue<string>>("main_template");
        set => SetArgument("main_template", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The package_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PackageEnabled
    {
        get => GetArgument<TerraformValue<bool>>("package_enabled");
        set => SetArgument("package_enabled", value);
    }

    /// <summary>
    /// The package_file_uri attribute.
    /// </summary>
    public TerraformValue<string>? PackageFileUri
    {
        get => GetArgument<TerraformValue<string>>("package_file_uri");
        set => SetArgument("package_file_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Authorization block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermManagedApplicationDefinitionAuthorizationBlock>? Authorization
    {
        get => GetArgument<TerraformSet<AzurermManagedApplicationDefinitionAuthorizationBlock>>("authorization");
        set => SetArgument("authorization", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagedApplicationDefinitionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagedApplicationDefinitionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
