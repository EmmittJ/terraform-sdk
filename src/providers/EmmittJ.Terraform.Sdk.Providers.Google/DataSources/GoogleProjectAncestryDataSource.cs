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
        SetOutput("ancestors");
        SetOutput("org_id");
        SetOutput("parent_id");
        SetOutput("parent_type");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
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
