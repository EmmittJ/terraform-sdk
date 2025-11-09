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
    public TerraformProperty<string>? AccelerationStatus
    {
        get => GetProperty<TerraformProperty<string>>("acceleration_status");
        set => this.WithProperty("acceleration_status", value);
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Acl
    {
        get => GetProperty<TerraformProperty<string>>("acl");
        set => this.WithProperty("acl", value);
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformProperty<string>? Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? BucketPrefix
    {
        get => GetProperty<TerraformProperty<string>>("bucket_prefix");
        set => this.WithProperty("bucket_prefix", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The object_lock_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ObjectLockEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("object_lock_enabled");
        set => this.WithProperty("object_lock_enabled", value);
    }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? Policy
    {
        get => GetProperty<TerraformProperty<string>>("policy");
        set => this.WithProperty("policy", value);
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
    /// The request_payer attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? RequestPayer
    {
        get => GetProperty<TerraformProperty<string>>("request_payer");
        set => this.WithProperty("request_payer", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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
