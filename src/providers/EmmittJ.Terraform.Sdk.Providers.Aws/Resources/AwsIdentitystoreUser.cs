using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for addresses in .
/// Nesting mode: list
/// </summary>
public partial class AwsIdentitystoreUserAddressesBlock : TerraformBlockBase
{
    /// <summary>
    /// The country attribute.
    /// </summary>
    [TerraformProperty("country")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Country { get; set; }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    [TerraformProperty("formatted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Formatted { get; set; }

    /// <summary>
    /// The locality attribute.
    /// </summary>
    [TerraformProperty("locality")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Locality { get; set; }

    /// <summary>
    /// The postal_code attribute.
    /// </summary>
    [TerraformProperty("postal_code")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PostalCode { get; set; }

    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformProperty("primary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Primary { get; set; }

    /// <summary>
    /// The region attribute.
    /// </summary>
    [TerraformProperty("region")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Region { get; set; }

    /// <summary>
    /// The street_address attribute.
    /// </summary>
    [TerraformProperty("street_address")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StreetAddress { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

}

/// <summary>
/// Block type for emails in .
/// Nesting mode: list
/// </summary>
public partial class AwsIdentitystoreUserEmailsBlock : TerraformBlockBase
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformProperty("primary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Primary { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for name in .
/// Nesting mode: list
/// </summary>
public partial class AwsIdentitystoreUserNameBlock : TerraformBlockBase
{
    /// <summary>
    /// The family_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FamilyName is required")]
    [TerraformProperty("family_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> FamilyName { get; set; }

    /// <summary>
    /// The formatted attribute.
    /// </summary>
    [TerraformProperty("formatted")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Formatted { get; set; }

    /// <summary>
    /// The given_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GivenName is required")]
    [TerraformProperty("given_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GivenName { get; set; }

    /// <summary>
    /// The honorific_prefix attribute.
    /// </summary>
    [TerraformProperty("honorific_prefix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HonorificPrefix { get; set; }

    /// <summary>
    /// The honorific_suffix attribute.
    /// </summary>
    [TerraformProperty("honorific_suffix")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HonorificSuffix { get; set; }

    /// <summary>
    /// The middle_name attribute.
    /// </summary>
    [TerraformProperty("middle_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MiddleName { get; set; }

}

/// <summary>
/// Block type for phone_numbers in .
/// Nesting mode: list
/// </summary>
public partial class AwsIdentitystoreUserPhoneNumbersBlock : TerraformBlockBase
{
    /// <summary>
    /// The primary attribute.
    /// </summary>
    [TerraformProperty("primary")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Primary { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Manages a aws_identitystore_user resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIdentitystoreUser : TerraformResource
{
    public AwsIdentitystoreUser(string name) : base("aws_identitystore_user", name)
    {
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    [TerraformProperty("identity_store_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IdentityStoreId { get; set; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformProperty("locale")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Locale { get; set; }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    [TerraformProperty("nickname")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Nickname { get; set; }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    [TerraformProperty("preferred_language")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PreferredLanguage { get; set; }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    [TerraformProperty("profile_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ProfileUrl { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Timezone { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformProperty("title")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Title { get; set; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    [TerraformProperty("user_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UserName { get; set; }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    [TerraformProperty("user_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserType { get; set; }

    /// <summary>
    /// Block for addresses.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Addresses block(s) allowed")]
    [TerraformProperty("addresses")]
    public partial TerraformList<TerraformBlock<AwsIdentitystoreUserAddressesBlock>>? Addresses { get; set; }

    /// <summary>
    /// Block for emails.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Emails block(s) allowed")]
    [TerraformProperty("emails")]
    public partial TerraformList<TerraformBlock<AwsIdentitystoreUserEmailsBlock>>? Emails { get; set; }

    /// <summary>
    /// Block for name.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Name block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Name block(s) allowed")]
    [TerraformProperty("name")]
    public partial TerraformList<TerraformBlock<AwsIdentitystoreUserNameBlock>>? Name { get; set; }

    /// <summary>
    /// Block for phone_numbers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PhoneNumbers block(s) allowed")]
    [TerraformProperty("phone_numbers")]
    public partial TerraformList<TerraformBlock<AwsIdentitystoreUserPhoneNumbersBlock>>? PhoneNumbers { get; set; }

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    [TerraformProperty("external_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ExternalIds { get; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformProperty("user_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UserId { get; }

}
