using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for permissions in .
/// Nesting mode: set
/// </summary>
public class AzureadCustomDirectoryRolePermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Set of tasks that can be performed on a resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedResourceActions is required")]
    public HashSet<TerraformProperty<string>>? AllowedResourceActions
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_resource_actions");
        set => WithProperty("allowed_resource_actions", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadCustomDirectoryRoleTimeoutsBlock : TerraformBlock
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
/// Manages a azuread_custom_directory_role resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzureadCustomDirectoryRole : TerraformResource
{
    public AzureadCustomDirectoryRole(string name) : base("azuread_custom_directory_role", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("object_id");
    }

    /// <summary>
    /// The description of the custom directory role
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the custom directory role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// Indicates whether the role is enabled for assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// Custom template identifier that is typically used if one needs an identifier to be the same across different directories.
    /// </summary>
    public TerraformProperty<string>? TemplateId
    {
        get => GetProperty<TerraformProperty<string>>("template_id");
        set => this.WithProperty("template_id", value);
    }

    /// <summary>
    /// The version of the role definition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for permissions.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    public HashSet<AzureadCustomDirectoryRolePermissionsBlock>? Permissions
    {
        get => GetProperty<HashSet<AzureadCustomDirectoryRolePermissionsBlock>>("permissions");
        set => this.WithProperty("permissions", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadCustomDirectoryRoleTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadCustomDirectoryRoleTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public TerraformExpression ObjectId => this["object_id"];

}
