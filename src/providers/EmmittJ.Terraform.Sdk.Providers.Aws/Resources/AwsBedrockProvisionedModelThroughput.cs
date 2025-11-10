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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
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
        this.WithOutputd");
        this.WithOutputrovisioned_model_arn");
        this.WithOutputags_all");
    }

    /// <summary>
    /// The commitment_duration attribute.
    /// </summary>
    public TerraformProperty<string>? CommitmentDuration
    {
        get => GetProperty<TerraformProperty<string>>("commitment_duration");
        set => this.WithProperty("commitment_duration", value);
    }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelArn is required")]
    public required TerraformProperty<string> ModelArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("model_arn");
        set => this.WithProperty("model_arn", value);
    }

    /// <summary>
    /// The model_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelUnits is required")]
    public required TerraformProperty<double> ModelUnits
    {
        get => GetRequiredProperty<TerraformProperty<double>>("model_units");
        set => this.WithProperty("model_units", value);
    }

    /// <summary>
    /// The provisioned_model_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProvisionedModelName is required")]
    public required TerraformProperty<string> ProvisionedModelName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("provisioned_model_name");
        set => this.WithProperty("provisioned_model_name", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsBedrockProvisionedModelThroughputTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsBedrockProvisionedModelThroughputTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
