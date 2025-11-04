using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("id");
        this.DeclareOutput("provisioned_model_arn");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The commitment_duration attribute.
    /// </summary>
    public string? CommitmentDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("commitment_duration")?.Value;
        set => this.WithProperty("commitment_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    public string? ModelArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("model_arn")?.Value;
        set => this.WithProperty("model_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The model_units attribute.
    /// </summary>
    public double? ModelUnits
    {
        get => GetProperty<TerraformLiteralProperty<double>>("model_units")?.Value;
        set => this.WithProperty("model_units", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The provisioned_model_name attribute.
    /// </summary>
    public string? ProvisionedModelName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("provisioned_model_name")?.Value;
        set => this.WithProperty("provisioned_model_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
