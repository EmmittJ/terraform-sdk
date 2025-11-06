using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3_bucket resource.
/// </summary>
public class AwsS3Bucket : TerraformResource
{
    public AwsS3Bucket(string name) : base("aws_s3_bucket", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("bucket_domain_name");
        this.DeclareOutput("bucket_region");
        this.DeclareOutput("bucket_regional_domain_name");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("website_domain");
        this.DeclareOutput("website_endpoint");
    }

    /// <summary>
    /// The acceleration_status attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? AccelerationStatus
    {
        get => GetProperty<TerraformLiteralProperty<string>>("acceleration_status")?.Value;
        set => this.WithProperty("acceleration_status", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? Acl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("acl")?.Value;
        set => this.WithProperty("acl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public string? BucketPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_prefix")?.Value;
        set => this.WithProperty("bucket_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public bool? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy")?.Value;
        set => this.WithProperty("force_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The object_lock_enabled attribute.
    /// </summary>
    public bool? ObjectLockEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("object_lock_enabled")?.Value;
        set => this.WithProperty("object_lock_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? Policy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("policy")?.Value;
        set => this.WithProperty("policy", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The request_payer attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? RequestPayer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_payer")?.Value;
        set => this.WithProperty("request_payer", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bucket_domain_name attribute.
    /// </summary>
    public TerraformExpression BucketDomainName => this["bucket_domain_name"];

    /// <summary>
    /// The bucket_region attribute.
    /// </summary>
    public TerraformExpression BucketRegion => this["bucket_region"];

    /// <summary>
    /// The bucket_regional_domain_name attribute.
    /// </summary>
    public TerraformExpression BucketRegionalDomainName => this["bucket_regional_domain_name"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The website_domain attribute.
    /// </summary>
    public TerraformExpression WebsiteDomain => this["website_domain"];

    /// <summary>
    /// The website_endpoint attribute.
    /// </summary>
    public TerraformExpression WebsiteEndpoint => this["website_endpoint"];

}
