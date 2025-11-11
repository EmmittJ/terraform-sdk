using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_grants_location_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The s3_sub_prefix attribute.
    /// </summary>
    [TerraformProperty("s3_sub_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3SubPrefix { get; set; }

}

/// <summary>
/// Block type for grantee in .
/// Nesting mode: list
/// </summary>
public partial class AwsS3controlAccessGrantGranteeBlock : TerraformBlockBase
{
    /// <summary>
    /// The grantee_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeIdentifier is required")]
    [TerraformProperty("grantee_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GranteeIdentifier { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeType is required")]
    [TerraformProperty("grantee_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GranteeType { get; set; }

}

/// <summary>
/// Manages a aws_s3control_access_grant resource.
/// </summary>
public partial class AwsS3controlAccessGrant : TerraformResource
{
    public AwsS3controlAccessGrant(string name) : base("aws_s3control_access_grant", name)
    {
    }

    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessGrantsLocationId is required")]
    [TerraformProperty("access_grants_location_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccessGrantsLocationId { get; set; }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformProperty("permission")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Permission { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The s3_prefix_type attribute.
    /// </summary>
    [TerraformProperty("s3_prefix_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? S3PrefixType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for access_grants_location_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("access_grants_location_configuration")]
    public partial TerraformList<TerraformBlock<AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock>>? AccessGrantsLocationConfiguration { get; set; }

    /// <summary>
    /// Block for grantee.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("grantee")]
    public partial TerraformList<TerraformBlock<AwsS3controlAccessGrantGranteeBlock>>? Grantee { get; set; }

    /// <summary>
    /// The access_grant_arn attribute.
    /// </summary>
    [TerraformProperty("access_grant_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessGrantArn { get; }

    /// <summary>
    /// The access_grant_id attribute.
    /// </summary>
    [TerraformProperty("access_grant_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessGrantId { get; }

    /// <summary>
    /// The grant_scope attribute.
    /// </summary>
    [TerraformProperty("grant_scope")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> GrantScope { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
