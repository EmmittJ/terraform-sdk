using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsAutoscalingGroupsDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public List<TerraformProperty<string>>? Values
    {
        get => GetProperty<List<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Retrieves information about a aws_autoscaling_groups.
/// </summary>
public class AwsAutoscalingGroupsDataSource : TerraformDataSource
{
    public AwsAutoscalingGroupsDataSource(string name) : base("aws_autoscaling_groups", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arns");
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
    /// The names attribute.
    /// </summary>
    public List<TerraformProperty<string>>? Names
    {
        get => GetProperty<List<TerraformProperty<string>>>("names");
        set => this.WithProperty("names", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsAutoscalingGroupsDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsAutoscalingGroupsDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The arns attribute.
    /// </summary>
    public TerraformExpression Arns => this["arns"];

}
