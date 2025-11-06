using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_config_organization_conformance_pack resource.
/// </summary>
public class AwsConfigOrganizationConformancePack : TerraformResource
{
    public AwsConfigOrganizationConformancePack(string name) : base("aws_config_organization_conformance_pack", name)
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
    public string? DeliveryS3Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_s3_bucket")?.Value;
        set => this.WithProperty("delivery_s3_bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delivery_s3_key_prefix attribute.
    /// </summary>
    public string? DeliveryS3KeyPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delivery_s3_key_prefix")?.Value;
        set => this.WithProperty("delivery_s3_key_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public HashSet<string>? ExcludedAccounts
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("excluded_accounts")?.Value;
        set => this.WithProperty("excluded_accounts", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The template_body attribute.
    /// </summary>
    public string? TemplateBody
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_body")?.Value;
        set => this.WithProperty("template_body", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The template_s3_uri attribute.
    /// </summary>
    public string? TemplateS3Uri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("template_s3_uri")?.Value;
        set => this.WithProperty("template_s3_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
