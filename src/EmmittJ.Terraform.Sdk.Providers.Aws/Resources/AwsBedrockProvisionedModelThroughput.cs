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
    public TerraformProperty<string>? CommitmentDuration
    {
        get => GetProperty<TerraformProperty<string>>("commitment_duration");
        set => this.WithProperty("commitment_duration", value);
    }

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ModelArn
    {
        get => GetProperty<TerraformProperty<string>>("model_arn");
        set => this.WithProperty("model_arn", value);
    }

    /// <summary>
    /// The model_units attribute.
    /// </summary>
    public TerraformProperty<double>? ModelUnits
    {
        get => GetProperty<TerraformProperty<double>>("model_units");
        set => this.WithProperty("model_units", value);
    }

    /// <summary>
    /// The provisioned_model_name attribute.
    /// </summary>
    public TerraformProperty<string>? ProvisionedModelName
    {
        get => GetProperty<TerraformProperty<string>>("provisioned_model_name");
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
