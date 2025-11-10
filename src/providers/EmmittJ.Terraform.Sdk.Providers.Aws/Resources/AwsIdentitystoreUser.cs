using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for addresses in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserAddressesBlock : ITerraformBlock
{
    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformPropertyName("country")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Country { get; set; }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    [TerraformPropertyName("formatted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Formatted { get; set; }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    [TerraformPropertyName("locality")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Locality { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformPropertyName("postal_code")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PostalCode { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Primary { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Region { get; set; }

    /// <summary>
    /// The street_address attribute.
    /// </summary>
    [TerraformPropertyName("street_address")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? StreetAddress { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

}

/// <summary>
/// Block type for emails in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserEmailsBlock : ITerraformBlock
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Primary { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

}

/// <summary>
/// Block type for name in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserNameBlock : ITerraformBlock
{
    /// <summary>
    /// The family_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FamilyName is required")]
    [TerraformPropertyName("family_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FamilyName { get; set; }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    [TerraformPropertyName("formatted")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Formatted { get; set; }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GivenName is required")]
    [TerraformPropertyName("given_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GivenName { get; set; }

    /// <summary>
    /// The honorific_prefix attribute.
    /// </summary>
    [TerraformPropertyName("honorific_prefix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HonorificPrefix { get; set; }

    /// <summary>
    /// The honorific_suffix attribute.
    /// </summary>
    [TerraformPropertyName("honorific_suffix")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? HonorificSuffix { get; set; }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    [TerraformPropertyName("middle_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MiddleName { get; set; }

}

/// <summary>
/// Block type for phone_numbers in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserPhoneNumbersBlock : ITerraformBlock
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformPropertyName("primary")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Primary { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformPropertyName("value")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Value { get; set; }

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
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    [TerraformPropertyName("identity_store_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> IdentityStoreId { get; set; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Locale { get; set; }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    [TerraformPropertyName("nickname")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Nickname { get; set; }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PreferredLanguage { get; set; }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    [TerraformPropertyName("profile_url")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProfileUrl { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Timezone { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Title { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformPropertyName("user_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserName { get; set; }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserType { get; set; }

    /// <summary>
    /// Block for addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Addresses block(s) allowed")]
    [TerraformPropertyName("addresses")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserAddressesBlock>>? Addresses { get; set; } = new();

    /// <summary>
    /// Block for emails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Emails block(s) allowed")]
    [TerraformPropertyName("emails")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserEmailsBlock>>? Emails { get; set; } = new();

    /// <summary>
    /// Block for name.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Name block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Name block(s) allowed")]
    [TerraformPropertyName("name")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserNameBlock>>? Name { get; set; } = new();

    /// <summary>
    /// Block for phone_numbers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneNumbers block(s) allowed")]
    [TerraformPropertyName("phone_numbers")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserPhoneNumbersBlock>>? PhoneNumbers { get; set; } = new();

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    [TerraformPropertyName("external_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExternalIds => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "external_ids");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_id");

}
