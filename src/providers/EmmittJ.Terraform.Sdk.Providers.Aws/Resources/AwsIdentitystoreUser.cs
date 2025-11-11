using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for addresses in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserAddressesBlock
{
    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformPropertyName("country")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Country { get; set; }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    [TerraformPropertyName("formatted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Formatted { get; set; }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    [TerraformPropertyName("locality")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Locality { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PostalCode { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Primary { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The street_address attribute.
    /// </summary>
    [TerraformPropertyName("street_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StreetAddress { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for emails in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserEmailsBlock
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Primary { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for name in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserNameBlock
{
    /// <summary>
    /// The family_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FamilyName is required")]
    [TerraformPropertyName("family_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> FamilyName { get; set; }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    [TerraformPropertyName("formatted")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Formatted { get; set; }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GivenName is required")]
    [TerraformPropertyName("given_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> GivenName { get; set; }

    /// <summary>
    /// The honorific_prefix attribute.
    /// </summary>
    [TerraformPropertyName("honorific_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HonorificPrefix { get; set; }

    /// <summary>
    /// The honorific_suffix attribute.
    /// </summary>
    [TerraformPropertyName("honorific_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? HonorificSuffix { get; set; }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    [TerraformPropertyName("middle_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MiddleName { get; set; }

}

/// <summary>
/// Block type for phone_numbers in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserPhoneNumbersBlock
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Primary { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Manages a aws_identitystore_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsIdentitystoreUser : TerraformResource
{
    public AwsIdentitystoreUser(string name) : base("aws_identitystore_user", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DisplayName { get; set; }

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
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Locale { get; set; }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    [TerraformPropertyName("nickname")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Nickname { get; set; }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreferredLanguage { get; set; }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    [TerraformPropertyName("profile_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ProfileUrl { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Timezone { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserType { get; set; }

    /// <summary>
    /// Block for addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Addresses block(s) allowed")]
    [TerraformPropertyName("addresses")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserAddressesBlock>>? Addresses { get; set; }

    /// <summary>
    /// Block for emails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Emails block(s) allowed")]
    [TerraformPropertyName("emails")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserEmailsBlock>>? Emails { get; set; }

    /// <summary>
    /// Block for name.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Name block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Name block(s) allowed")]
    [TerraformPropertyName("name")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserNameBlock>>? Name { get; set; }

    /// <summary>
    /// Block for phone_numbers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneNumbers block(s) allowed")]
    [TerraformPropertyName("phone_numbers")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserPhoneNumbersBlock>>? PhoneNumbers { get; set; }

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    [TerraformPropertyName("external_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ExternalIds => new TerraformReference(this, "external_ids");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> UserId => new TerraformReference(this, "user_id");

}
