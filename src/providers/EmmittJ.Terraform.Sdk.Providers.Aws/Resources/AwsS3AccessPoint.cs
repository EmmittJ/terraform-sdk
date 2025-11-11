using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for public_access_block_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3AccessPointPublicAccessBlockConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The block_public_acls attribute.
    /// </summary>
    [TerraformProperty("block_public_acls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BlockPublicAcls { get; set; }

    /// <summary>
    /// The block_public_policy attribute.
    /// </summary>
    [TerraformProperty("block_public_policy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? BlockPublicPolicy { get; set; }

    /// <summary>
    /// The ignore_public_acls attribute.
    /// </summary>
    [TerraformProperty("ignore_public_acls")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? IgnorePublicAcls { get; set; }

    /// <summary>
    /// The restrict_public_buckets attribute.
    /// </summary>
    [TerraformProperty("restrict_public_buckets")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RestrictPublicBuckets { get; set; }

}

/// <summary>
/// Block type for vpc_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3AccessPointVpcConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcId is required")]
    [TerraformProperty("vpc_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> VpcId { get; set; }

}

/// <summary>
/// Manages a aws_s3_access_point resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsS3AccessPoint : TerraformResource
{
    public AwsS3AccessPoint(string name) : base("aws_s3_access_point", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [TerraformProperty("bucket")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Bucket { get; set; }

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    [TerraformProperty("bucket_account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> BucketAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [TerraformProperty("policy")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for public_access_block_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublicAccessBlockConfiguration block(s) allowed")]
    [TerraformProperty("public_access_block_configuration")]
    public partial TerraformList<TerraformBlock<AwsS3AccessPointPublicAccessBlockConfigurationBlock>>? PublicAccessBlockConfiguration { get; set; }

    /// <summary>
    /// Block for vpc_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VpcConfiguration block(s) allowed")]
    [TerraformProperty("vpc_configuration")]
    public partial TerraformList<TerraformBlock<AwsS3AccessPointVpcConfigurationBlock>>? VpcConfiguration { get; set; }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Alias { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainName { get; }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformProperty("endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Endpoints { get; }

    /// <summary>
    /// The has_public_access_policy attribute.
    /// </summary>
    [TerraformProperty("has_public_access_policy")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> HasPublicAccessPolicy { get; }

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    [TerraformProperty("network_origin")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> NetworkOrigin { get; }

}
