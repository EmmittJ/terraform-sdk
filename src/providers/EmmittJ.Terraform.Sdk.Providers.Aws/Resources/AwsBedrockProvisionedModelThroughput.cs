using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsBedrockProvisionedModelThroughputTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_bedrock_provisioned_model_throughput resource.
/// </summary>
public class AwsBedrockProvisionedModelThroughput : TerraformResource
{
    public AwsBedrockProvisionedModelThroughput(string name) : base("aws_bedrock_provisioned_model_throughput", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("provisioned_model_arn");
        SetOutput("tags_all");
        SetOutput("commitment_duration");
        SetOutput("model_arn");
        SetOutput("model_units");
        SetOutput("provisioned_model_name");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The commitment_duration attribute.
    /// </summary>
    public TerraformProperty<string> CommitmentDuration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("commitment_duration");
        set => SetProperty("commitment_duration", value);
    }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelArn is required")]
    public required TerraformProperty<string> ModelArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("model_arn");
        set => SetProperty("model_arn", value);
    }

    /// <summary>
    /// The model_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelUnits is required")]
    public required TerraformProperty<double> ModelUnits
    {
        get => GetRequiredOutput<TerraformProperty<double>>("model_units");
        set => SetProperty("model_units", value);
    }

    /// <summary>
    /// The provisioned_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedModelName is required")]
    public required TerraformProperty<string> ProvisionedModelName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("provisioned_model_name");
        set => SetProperty("provisioned_model_name", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockProvisionedModelThroughputTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The provisioned_model_arn attribute.
    /// </summary>
    public TerraformExpression ProvisionedModelArn => this["provisioned_model_arn"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
