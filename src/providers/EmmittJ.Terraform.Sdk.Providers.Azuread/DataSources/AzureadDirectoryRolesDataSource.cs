using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadDirectoryRolesDataSource.
/// Nesting mode: single
/// </summary>
public class AzureadDirectoryRolesDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azuread_directory_roles Terraform data source.
/// Retrieves information about a azuread_directory_roles.
/// </summary>
public partial class AzureadDirectoryRolesDataSource(string name) : TerraformDataSource("azuread_directory_roles", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object IDs of the roles
    /// </summary>
    public TerraformList<string> ObjectIds
        => CreateReference("object_ids");

    /// <summary>
    /// A list of roles
    /// </summary>
    public TerraformList<TerraformMap<object>> Roles
        => CreateReference("roles");

    /// <summary>
    /// The template IDs of the roles
    /// </summary>
    public TerraformList<string> TemplateIds
        => CreateReference("template_ids");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadDirectoryRolesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadDirectoryRolesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
