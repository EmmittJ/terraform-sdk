using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_config_conformance_pack resource.
/// </summary>
public class AwsConfigConformancePack : TerraformResource
{
    public AwsConfigConformancePack(string name) : base("aws_config_conformance_pack", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The delivery_s3_bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeliveryS3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_s3_bucket");
        set => this.WithProperty("delivery_s3_bucket", value);
    }

    /// <summary>
    /// The delivery_s3_key_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeliveryS3KeyPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_s3_key_prefix");
        set => this.WithProperty("delivery_s3_key_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The template_body attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_body");
        set => this.WithProperty("template_body", value);
    }

    /// <summary>
    /// The template_s3_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TemplateS3Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_s3_uri");
        set => this.WithProperty("template_s3_uri", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
