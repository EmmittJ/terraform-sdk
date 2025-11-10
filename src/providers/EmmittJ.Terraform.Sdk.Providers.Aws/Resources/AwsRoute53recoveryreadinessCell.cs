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
        set => SetProperty("delete", value);
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
        SetOutput("arn");
        SetOutput("parent_readiness_scopes");
        SetOutput("cell_name");
        SetOutput("cells");
        SetOutput("id");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The cell_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CellName is required")]
    public required TerraformProperty<string> CellName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cell_name");
        set => SetProperty("cell_name", value);
    }

    /// <summary>
    /// The cells attribute.
    /// </summary>
    public List<TerraformProperty<string>> Cells
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("cells");
        set => SetProperty("cells", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsRoute53recoveryreadinessCellTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
