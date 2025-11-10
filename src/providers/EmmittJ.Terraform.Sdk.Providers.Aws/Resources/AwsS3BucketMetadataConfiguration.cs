using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for metadata_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3BucketMetadataConfigurationMetadataConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The destination attribute.
    /// </summary>
    [TerraformPropertyName("destination")]
    // Computed attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Destination => new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "destination");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsS3BucketMetadataConfigurationTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

}

/// <summary>
/// Manages a aws_s3_bucket_metadata_configuration resource.
/// </summary>
public class AwsS3BucketMetadataConfiguration : TerraformResource
{
    public AwsS3BucketMetadataConfiguration(string name) : base("aws_s3_bucket_metadata_configuration", name)
    {
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The expected_bucket_owner attribute.
    /// </summary>
    [TerraformPropertyName("expected_bucket_owner")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExpectedBucketOwner { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for metadata_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("metadata_configuration")]
    public TerraformList<TerraformBlock<AwsS3BucketMetadataConfigurationMetadataConfigurationBlock>>? MetadataConfiguration { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsS3BucketMetadataConfigurationTimeoutsBlock>? Timeouts { get; set; } = new();

}
