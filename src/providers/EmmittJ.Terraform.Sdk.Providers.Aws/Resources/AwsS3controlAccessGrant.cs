using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_grants_location_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock : ITerraformBlock
{
    /// <summary>
    /// The s3_sub_prefix attribute.
    /// </summary>
    [TerraformPropertyName("s3_sub_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3SubPrefix { get; set; }

}

/// <summary>
/// Block type for grantee in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlAccessGrantGranteeBlock : ITerraformBlock
{
    /// <summary>
    /// The grantee_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeIdentifier is required")]
    [TerraformPropertyName("grantee_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GranteeIdentifier { get; set; }

    /// <summary>
    /// The grantee_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GranteeType is required")]
    [TerraformPropertyName("grantee_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GranteeType { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> AccessGrantsLocationId { get; set; }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The permission attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Permission is required")]
    [TerraformPropertyName("permission")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Permission { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The s3_prefix_type attribute.
    /// </summary>
    [TerraformPropertyName("s3_prefix_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? S3PrefixType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for access_grants_location_configuration.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("access_grants_location_configuration")]
    public TerraformList<TerraformBlock<AwsS3controlAccessGrantAccessGrantsLocationConfigurationBlock>>? AccessGrantsLocationConfiguration { get; set; } = new();

    /// <summary>
    /// Block for grantee.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("grantee")]
    public TerraformList<TerraformBlock<AwsS3controlAccessGrantGranteeBlock>>? Grantee { get; set; } = new();

    /// <summary>
    /// The access_grant_arn attribute.
    /// </summary>
    [TerraformPropertyName("access_grant_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessGrantArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_grant_arn");

    /// <summary>
    /// The access_grant_id attribute.
    /// </summary>
    [TerraformPropertyName("access_grant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessGrantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_grant_id");

    /// <summary>
    /// The grant_scope attribute.
    /// </summary>
    [TerraformPropertyName("grant_scope")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GrantScope => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "grant_scope");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
