using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter_criteria in .
/// Nesting mode: list
/// </summary>
public class AwsInspector2FilterFilterCriteriaBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_inspector2_filter resource.
/// </summary>
public class AwsInspector2Filter : TerraformResource
{
    public AwsInspector2Filter(string name) : base("aws_inspector2_filter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("tags_all");
        SetOutput("action");
        SetOutput("description");
        SetOutput("name");
        SetOutput("reason");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Action is required")]
    public required TerraformProperty<string> Action
    {
        get => GetRequiredOutput<TerraformProperty<string>>("action");
        set => SetProperty("action", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The reason attribute.
    /// </summary>
    public TerraformProperty<string> Reason
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reason");
        set => SetProperty("reason", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
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
    /// Block for filter_criteria.
    /// Nesting mode: list
    /// </summary>
    public List<AwsInspector2FilterFilterCriteriaBlock>? FilterCriteria
    {
        set => SetProperty("filter_criteria", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
