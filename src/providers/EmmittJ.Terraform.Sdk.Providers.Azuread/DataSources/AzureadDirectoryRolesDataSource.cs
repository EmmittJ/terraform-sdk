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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The object IDs of the roles
    /// </summary>
    public TerraformList<string> ObjectIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "object_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// A list of roles
    /// </summary>
    public TerraformList<TerraformMap<object>> Roles
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "roles").ResolveNodes(ctx));
    }

    /// <summary>
    /// The template IDs of the roles
    /// </summary>
    public TerraformList<string> TemplateIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "template_ids").ResolveNodes(ctx));
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadDirectoryRolesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadDirectoryRolesDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
