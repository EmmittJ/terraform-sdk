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
    public string? AwsKmsKeyArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_kms_key_arn")?.Value;
        set => this.WithProperty("aws_kms_key_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The input_bucket attribute.
    /// </summary>
    public string? InputBucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("input_bucket")?.Value;
        set => this.WithProperty("input_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The output_bucket attribute.
    /// </summary>
    public string? OutputBucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("output_bucket")?.Value;
        set => this.WithProperty("output_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The role attribute.
    /// </summary>
    public string? Role
    {
        get => GetProperty<TerraformLiteralProperty<string>>("role")?.Value;
        set => this.WithProperty("role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
