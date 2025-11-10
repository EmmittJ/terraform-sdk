using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for public_access_block_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3AccessPointPublicAccessBlockConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    [TerraformPropertyName("block_public_acls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BlockPublicAcls { get; set; }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    [TerraformPropertyName("block_public_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? BlockPublicPolicy { get; set; }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    [TerraformPropertyName("ignore_public_acls")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnorePublicAcls { get; set; }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformPropertyName("restrict_public_buckets")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RestrictPublicBuckets { get; set; }

}

/// <summary>
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3AccessPointVpcConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformPropertyName("vpc_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> VpcId { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformPropertyName("bucket")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Bucket { get; set; }

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    [TerraformPropertyName("bucket_account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> BucketAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "bucket_account_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformPropertyName("policy")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Policy { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for public_access_block_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicAccessBlockConfiguration block(s) allowed")]
    [TerraformPropertyName("public_access_block_configuration")]
    public TerraformList<TerraformBlock<AwsS3AccessPointPublicAccessBlockConfigurationBlock>>? PublicAccessBlockConfiguration { get; set; } = new();

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    [TerraformPropertyName("vpc_configuration")]
    public TerraformList<TerraformBlock<AwsS3AccessPointVpcConfigurationBlock>>? VpcConfiguration { get; set; } = new();

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformPropertyName("alias")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Alias => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "alias");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name");

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformPropertyName("endpoints")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Endpoints => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "endpoints");

    /// <summary>
    /// The has_public_access_policy attribute.
    /// </summary>
    [TerraformPropertyName("has_public_access_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> HasPublicAccessPolicy => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "has_public_access_policy");

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    [TerraformPropertyName("network_origin")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> NetworkOrigin => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "network_origin");

}
