using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for public_access_block_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3AccessPointPublicAccessBlockConfigurationBlock
{
    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    [TerraformPropertyName("block_public_acls")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BlockPublicAcls { get; set; }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    [TerraformPropertyName("block_public_policy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? BlockPublicPolicy { get; set; }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    [TerraformPropertyName("ignore_public_acls")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? IgnorePublicAcls { get; set; }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformPropertyName("restrict_public_buckets")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RestrictPublicBuckets { get; set; }

}

/// <summary>
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3AccessPointVpcConfigurationBlock
{
    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_s3_access_point resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3AccessPoint : TerraformResource
{
    public AwsS3AccessPoint(string name) : base("aws_s3_access_point", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccountId { get; set; } = default!;

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    [TerraformPropertyName("bucket_account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> BucketAccountId { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Policy { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for public_access_block_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicAccessBlockConfiguration block(s) allowed")]
    [TerraformPropertyName("public_access_block_configuration")]
    public TerraformList<TerraformBlock<AwsS3AccessPointPublicAccessBlockConfigurationBlock>>? PublicAccessBlockConfiguration { get; set; }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    [TerraformPropertyName("vpc_configuration")]
    public TerraformList<TerraformBlock<AwsS3AccessPointVpcConfigurationBlock>>? VpcConfiguration { get; set; }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Alias => new TerraformReference(this, "alias");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainName => new TerraformReference(this, "domain_name");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformPropertyName("endpoints")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Endpoints => new TerraformReference(this, "endpoints");

    /// <summary>
    /// The has_public_access_policy attribute.
    /// </summary>
    [TerraformPropertyName("has_public_access_policy")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> HasPublicAccessPolicy => new TerraformReference(this, "has_public_access_policy");

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    [TerraformPropertyName("network_origin")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> NetworkOrigin => new TerraformReference(this, "network_origin");

}
