using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadDirectoryRoleTemplatesDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

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
/// Represents a azuread_directory_role_templates Terraform data source.
/// Retrieves information about a azuread_directory_role_templates.
/// </summary>
public partial class AzureadDirectoryRoleTemplatesDataSource(string name) : TerraformDataSource("azuread_directory_role_templates", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object IDs of the role templates
    /// </summary>
    public TerraformList<string> ObjectIds
        => AsReference("object_ids");

    /// <summary>
    /// A list of role templates
    /// </summary>
    public TerraformList<TerraformMap<object>> RoleTemplates
        => AsReference("role_templates");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadDirectoryRoleTemplatesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
