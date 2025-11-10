using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_project_ancestry.
/// </summary>
public class GoogleProjectAncestryDataSource : TerraformDataSource
{
    public GoogleProjectAncestryDataSource(string name) : base("google_project_ancestry", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("ancestors");
        this.WithOutput("org_id");
        this.WithOutput("parent_id");
        this.WithOutput("parent_type");
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
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The ancestors attribute.
    /// </summary>
    public TerraformExpression Ancestors => this["ancestors"];

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    public TerraformExpression OrgId => this["org_id"];

    /// <summary>
    /// The parent_id attribute.
    /// </summary>
    public TerraformExpression ParentId => this["parent_id"];

    /// <summary>
    /// The parent_type attribute.
    /// </summary>
    public TerraformExpression ParentType => this["parent_type"];

}
