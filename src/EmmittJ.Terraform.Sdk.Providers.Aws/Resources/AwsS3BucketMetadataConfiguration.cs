using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metadata_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketMetadataConfigurationMetadataConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    public List<TerraformProperty<object>>? Destination
    {
        get => GetProperty<List<TerraformProperty<object>>>("destination");
        set => WithProperty("destination", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsS3BucketMetadataConfigurationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_s3_bucket_metadata_configuration resource.
/// </summary>
public class AwsS3BucketMetadataConfiguration : TerraformResource
{
    public AwsS3BucketMetadataConfiguration(string name) : base("aws_s3_bucket_metadata_configuration", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for metadata_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsS3BucketMetadataConfigurationMetadataConfigurationBlock>? MetadataConfiguration
    {
        get => GetProperty<List<AwsS3BucketMetadataConfigurationMetadataConfigurationBlock>>("metadata_configuration");
        set => this.WithProperty("metadata_configuration", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsS3BucketMetadataConfigurationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsS3BucketMetadataConfigurationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
