using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for permissions in AzureadCustomDirectoryRole.
/// Nesting mode: set
/// </summary>
public class AzureadCustomDirectoryRolePermissionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "permissions";

    /// <summary>
    /// Set of tasks that can be performed on a resource
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedResourceActions is required")]
    public required TerraformSet<string> AllowedResourceActions
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "allowed_resource_actions").ResolveNodes(ctx));
        set => SetArgument("allowed_resource_actions", value);
    }

}


/// <summary>
/// Block type for timeouts in AzureadCustomDirectoryRole.
/// Nesting mode: single
/// </summary>
public class AzureadCustomDirectoryRoleTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azuread_custom_directory_role Terraform resource.
/// Manages a azuread_custom_directory_role resource.
/// </summary>
public partial class AzureadCustomDirectoryRole(string name) : TerraformResource("azuread_custom_directory_role", name)
{
    /// <summary>
    /// The description of the custom directory role
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the custom directory role
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Indicates whether the role is enabled for assignment
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Custom template identifier that is typically used if one needs an identifier to be the same across different directories.
    /// </summary>
    public TerraformValue<string> TemplateId
    {
        get => new TerraformReference<string>(this, "template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// The version of the role definition.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public TerraformValue<string> ObjectId
    {
        get => new TerraformReference<string>(this, "object_id");
    }

    /// <summary>
    /// Permissions block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permissions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Permissions block(s) required")]
    public required TerraformSet<AzureadCustomDirectoryRolePermissionsBlock> Permissions
    {
        get => GetRequiredArgument<TerraformSet<AzureadCustomDirectoryRolePermissionsBlock>>("permissions");
        set => SetArgument("permissions", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadCustomDirectoryRoleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadCustomDirectoryRoleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
