using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53recoveryreadiness_cell resource.
/// </summary>
public class AwsRoute53recoveryreadinessCell : TerraformResource
{
    public AwsRoute53recoveryreadinessCell(string name) : base("aws_route53recoveryreadiness_cell", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("parent_readiness_scopes");
    }

    /// <summary>
    /// The cell_name attribute.
    /// </summary>
    public TerraformProperty<string>? CellName
    {
        get => GetProperty<TerraformProperty<string>>("cell_name");
        set => this.WithProperty("cell_name", value);
    }

    /// <summary>
    /// The cells attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Cells
    {
        get => GetProperty<TerraformProperty<List<string>>>("cells");
        set => this.WithProperty("cells", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The parent_readiness_scopes attribute.
    /// </summary>
    public TerraformExpression ParentReadinessScopes => this["parent_readiness_scopes"];

}
