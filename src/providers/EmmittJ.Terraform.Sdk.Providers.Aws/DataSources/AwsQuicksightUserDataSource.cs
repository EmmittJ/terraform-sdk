using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_quicksight_user.
/// </summary>
public class AwsQuicksightUserDataSource : TerraformDataSource
{
    public AwsQuicksightUserDataSource(string name) : base("aws_quicksight_user", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformPropertyName("aws_account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AwsAccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "aws_account_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [TerraformPropertyName("namespace")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserName { get; set; }

    /// <summary>
    /// The active attribute.
    /// </summary>
    [TerraformPropertyName("active")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Active => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "active");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The custom_permissions_name attribute.
    /// </summary>
    [TerraformPropertyName("custom_permissions_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomPermissionsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_permissions_name");

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformPropertyName("email")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Email => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email");

    /// <summary>
    /// The identity_type attribute.
    /// </summary>
    [TerraformPropertyName("identity_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IdentityType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identity_type");

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    [TerraformPropertyName("principal_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrincipalId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "principal_id");

    /// <summary>
    /// The user_role attribute.
    /// </summary>
    [TerraformPropertyName("user_role")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserRole => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_role");

}
