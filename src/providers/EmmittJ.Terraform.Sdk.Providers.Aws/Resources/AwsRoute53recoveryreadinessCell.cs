using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsRoute53recoveryreadinessCellTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

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
        this.WithOutput("arn");
        this.WithOutput("parent_readiness_scopes");
    }

    /// <summary>
    /// The cell_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CellName is required")]
    public required TerraformProperty<string> CellName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("cell_name");
        set => this.WithProperty("cell_name", value);
    }

    /// <summary>
    /// The cells attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Cells
    {
        get => GetProperty<List<TerraformProperty<string>>>("cells");
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
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53recoveryreadinessCellTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsRoute53recoveryreadinessCellTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
