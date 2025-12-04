using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_project_ancestry Terraform data source.
/// Retrieves information about a google_project_ancestry.
/// </summary>
public partial class GoogleProjectAncestryDataSource(string name) : TerraformDataSource("google_project_ancestry", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The ancestors attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ancestors
        => AsReference("ancestors");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformValue<string> OrgId
        => AsReference("org_id");

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformValue<string> ParentId
        => AsReference("parent_id");

    /// <summary>
    /// The parent_type attribute.
    /// </summary>
    public TerraformValue<string> ParentType
        => AsReference("parent_type");

}
