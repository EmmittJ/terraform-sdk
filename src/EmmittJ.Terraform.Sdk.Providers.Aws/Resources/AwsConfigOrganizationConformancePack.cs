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
    public TerraformProperty<string>? DeliveryS3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("delivery_s3_bucket");
        set => this.WithProperty("delivery_s3_bucket", value);
    }

    /// <summary>
    /// The delivery_s3_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? DeliveryS3KeyPrefix
    {
        get => GetProperty<TerraformProperty<string>>("delivery_s3_key_prefix");
        set => this.WithProperty("delivery_s3_key_prefix", value);
    }

    /// <summary>
    /// The excluded_accounts attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? ExcludedAccounts
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("excluded_accounts");
        set => this.WithProperty("excluded_accounts", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The template_body attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateBody
    {
        get => GetProperty<TerraformProperty<string>>("template_body");
        set => this.WithProperty("template_body", value);
    }

    /// <summary>
    /// The template_s3_uri attribute.
    /// </summary>
    public TerraformProperty<string>? TemplateS3Uri
    {
        get => GetProperty<TerraformProperty<string>>("template_s3_uri");
        set => this.WithProperty("template_s3_uri", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
