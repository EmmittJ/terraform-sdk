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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
        => CreateReference("ancestors");

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformValue<string> OrgId
        => CreateReference("org_id");

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformValue<string> ParentId
        => CreateReference("parent_id");

    /// <summary>
    /// The parent_type attribute.
    /// </summary>
    public TerraformValue<string> ParentType
        => CreateReference("parent_type");

}
