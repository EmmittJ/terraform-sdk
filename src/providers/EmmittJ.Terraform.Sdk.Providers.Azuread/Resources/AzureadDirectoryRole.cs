using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadDirectoryRole.
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azuread_directory_role Terraform resource.
/// Manages a azuread_directory_role resource.
/// </summary>
public partial class AzureadDirectoryRole(string name) : TerraformResource("azuread_directory_role", name)
{
    /// <summary>
    /// The display name of the directory role
    /// </summary>
    public TerraformValue<string>? DisplayName
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
    /// The object ID of the template associated with the directory role
    /// </summary>
    public TerraformValue<string>? TemplateId
    {
        get => GetArgument<TerraformValue<string>>("template_id");
        set => SetArgument("template_id", value);
    }

    /// <summary>
    /// The description of the directory role
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The object ID of the directory role
    /// </summary>
    public TerraformValue<string> ObjectId
        => AsReference("object_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadDirectoryRoleTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadDirectoryRoleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
