using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_securitylake_subscriber resource.
/// </summary>
public class AwsSecuritylakeSubscriber : TerraformResource
{
    public AwsSecuritylakeSubscriber(string name) : base("aws_securitylake_subscriber", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("id");
        this.DeclareOutput("resource_share_arn");
        this.DeclareOutput("resource_share_name");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("s3_bucket_arn");
        this.DeclareOutput("subscriber_endpoint");
        this.DeclareOutput("subscriber_status");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The access_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccessType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_type");
        set => this.WithProperty("access_type", value);
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
    /// The subscriber_description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriberDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscriber_description");
        set => this.WithProperty("subscriber_description", value);
    }

    /// <summary>
    /// The subscriber_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriberName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscriber_name");
        set => this.WithProperty("subscriber_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The resource_share_arn attribute.
    /// </summary>
    public TerraformExpression ResourceShareArn => this["resource_share_arn"];

    /// <summary>
    /// The resource_share_name attribute.
    /// </summary>
    public TerraformExpression ResourceShareName => this["resource_share_name"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The s3_bucket_arn attribute.
    /// </summary>
    public TerraformExpression S3BucketArn => this["s3_bucket_arn"];

    /// <summary>
    /// The subscriber_endpoint attribute.
    /// </summary>
    public TerraformExpression SubscriberEndpoint => this["subscriber_endpoint"];

    /// <summary>
    /// The subscriber_status attribute.
    /// </summary>
    public TerraformExpression SubscriberStatus => this["subscriber_status"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
