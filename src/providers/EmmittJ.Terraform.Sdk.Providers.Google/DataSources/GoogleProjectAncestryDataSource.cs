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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The ancestors attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ancestors
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ancestors").ResolveNodes(ctx));
    }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
    }

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformValue<string> ParentId
    {
        get => new TerraformReference<string>(this, "parent_id");
    }

    /// <summary>
    /// The parent_type attribute.
    /// </summary>
    public TerraformValue<string> ParentType
    {
        get => new TerraformReference<string>(this, "parent_type");
    }

}
