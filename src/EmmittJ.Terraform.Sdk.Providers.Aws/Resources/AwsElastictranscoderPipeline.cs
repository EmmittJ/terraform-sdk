using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_elastictranscoder_pipeline resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AwsElastictranscoderPipeline : TerraformResource
{
    public AwsElastictranscoderPipeline(string name) : base("aws_elastictranscoder_pipeline", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The aws_kms_key_arn attribute.
    /// </summary>
    public TerraformProperty<string>? AwsKmsKeyArn
    {
        get => GetProperty<TerraformProperty<string>>("aws_kms_key_arn");
        set => this.WithProperty("aws_kms_key_arn", value);
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
    /// The input_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? InputBucket
    {
        get => GetProperty<TerraformProperty<string>>("input_bucket");
        set => this.WithProperty("input_bucket", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The output_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? OutputBucket
    {
        get => GetProperty<TerraformProperty<string>>("output_bucket");
        set => this.WithProperty("output_bucket", value);
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
    /// The role attribute.
    /// </summary>
    public TerraformProperty<string>? Role
    {
        get => GetProperty<TerraformProperty<string>>("role");
        set => this.WithProperty("role", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
