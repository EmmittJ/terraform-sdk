using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketObjectLockConfigurationRuleBlock : TerraformBlock
{
}

/// <summary>
/// Manages a aws_s3_bucket_object_lock_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3BucketObjectLockConfiguration : TerraformResource
{
    public AwsS3BucketObjectLockConfiguration(string name) : base("aws_s3_bucket_object_lock_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    public TerraformProperty<string>? ExpectedBucketOwner
    {
        get => GetProperty<TerraformProperty<string>>("expected_bucket_owner");
        set => this.WithProperty("expected_bucket_owner", value);
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
    public TerraformProperty<string>? ObjectLockEnabled
    {
        get => GetProperty<TerraformProperty<string>>("object_lock_enabled");
        set => this.WithProperty("object_lock_enabled", value);
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
    /// The token attribute.
    /// </summary>
    public TerraformProperty<string>? Token
    {
        get => GetProperty<TerraformProperty<string>>("token");
        set => this.WithProperty("token", value);
    }

    /// <summary>
    /// Block for rule.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Rule block(s) allowed")]
    public List<AwsS3BucketObjectLockConfigurationRuleBlock>? Rule
    {
        get => GetProperty<List<AwsS3BucketObjectLockConfigurationRuleBlock>>("rule");
        set => this.WithProperty("rule", value);
    }

}
