using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_grants_location_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock
{
    /// <summary>
    /// The s3_sub_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_sub_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3SubPrefix { get; set; }

}

/// <summary>
/// Block type for grantee in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlAccessGrantGranteeBlock
{
    /// <summary>
    /// The grantee_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeIdentifier is required")]
    [TerraformPropertyName("grantee_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GranteeIdentifier { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeType is required")]
    [TerraformPropertyName("grantee_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GranteeType { get; set; }

}

/// <summary>
/// Manages a aws_s3control_access_grant resource.
/// </summary>
public class AwsS3controlAccessGrant : TerraformResource
{
    public AwsS3controlAccessGrant(string name) : base("aws_s3control_access_grant", name)
    {
    }

    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessGrantsLocationId is required")]
    [TerraformPropertyName("access_grants_location_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccessGrantsLocationId { get; set; }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> AccountId { get; set; } = default!;

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformPropertyName("permission")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Permission { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The s3_prefix_type attribute.
    /// </summary>
    [TerraformPropertyName("s3_prefix_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? S3PrefixType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for access_grants_location_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("access_grants_location_configuration")]
    public TerraformList<TerraformBlock<AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock>>? AccessGrantsLocationConfiguration { get; set; }

    /// <summary>
    /// Block for grantee.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("grantee")]
    public TerraformList<TerraformBlock<AwsS3controlAccessGrantGranteeBlock>>? Grantee { get; set; }

    /// <summary>
    /// The access_grant_arn attribute.
    /// </summary>
    [TerraformPropertyName("access_grant_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessGrantArn => new TerraformReference(this, "access_grant_arn");

    /// <summary>
    /// The access_grant_id attribute.
    /// </summary>
    [TerraformPropertyName("access_grant_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AccessGrantId => new TerraformReference(this, "access_grant_id");

    /// <summary>
    /// The grant_scope attribute.
    /// </summary>
    [TerraformPropertyName("grant_scope")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> GrantScope => new TerraformReference(this, "grant_scope");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
