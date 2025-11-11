using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alternate_identifier in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserDataSourceAlternateIdentifierBlock
{
}

/// <summary>
/// Retrieves information about a aws_identitystore_user.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIdentitystoreUserDataSource : TerraformDataSource
{
    public AwsIdentitystoreUserDataSource(string name) : base("aws_identitystore_user", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    [TerraformPropertyName("identity_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> IdentityStoreId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UserId { get; set; } = default!;

    /// <summary>
    /// Block for alternate_identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternateIdentifier block(s) allowed")]
    [TerraformPropertyName("alternate_identifier")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserDataSourceAlternateIdentifierBlock>>? AlternateIdentifier { get; set; }

    /// <summary>
    /// The addresses attribute.
    /// </summary>
    [TerraformPropertyName("addresses")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Addresses => new TerraformReference(this, "addresses");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The emails attribute.
    /// </summary>
    [TerraformPropertyName("emails")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Emails => new TerraformReference(this, "emails");

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    [TerraformPropertyName("external_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExternalIds => new TerraformReference(this, "external_ids");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Locale => new TerraformReference(this, "locale");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    [TerraformPropertyName("nickname")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Nickname => new TerraformReference(this, "nickname");

    /// <summary>
    /// The phone_numbers attribute.
    /// </summary>
    [TerraformPropertyName("phone_numbers")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PhoneNumbers => new TerraformReference(this, "phone_numbers");

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredLanguage => new TerraformReference(this, "preferred_language");

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    [TerraformPropertyName("profile_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProfileUrl => new TerraformReference(this, "profile_url");

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Timezone => new TerraformReference(this, "timezone");

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Title => new TerraformReference(this, "title");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformPropertyName("user_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserName => new TerraformReference(this, "user_name");

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserType => new TerraformReference(this, "user_type");

}
