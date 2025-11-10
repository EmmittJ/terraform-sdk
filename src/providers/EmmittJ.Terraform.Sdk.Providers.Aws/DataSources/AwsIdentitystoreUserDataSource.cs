using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alternate_identifier in .
/// Nesting mode: list
/// </summary>
public class AwsIdentitystoreUserDataSourceAlternateIdentifierBlock : ITerraformBlock
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformPropertyName("user_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> UserId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_id");

    /// <summary>
    /// Block for alternate_identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternateIdentifier block(s) allowed")]
    [TerraformPropertyName("alternate_identifier")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserDataSourceAlternateIdentifierBlock>>? AlternateIdentifier { get; set; } = new();

    /// <summary>
    /// The addresses attribute.
    /// </summary>
    [TerraformPropertyName("addresses")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Addresses => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "addresses");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The emails attribute.
    /// </summary>
    [TerraformPropertyName("emails")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Emails => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "emails");

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    [TerraformPropertyName("external_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ExternalIds => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "external_ids");

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformPropertyName("locale")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Locale => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "locale");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Name => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "name");

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    [TerraformPropertyName("nickname")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Nickname => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "nickname");

    /// <summary>
    /// The phone_numbers attribute.
    /// </summary>
    [TerraformPropertyName("phone_numbers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PhoneNumbers => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "phone_numbers");

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    [TerraformPropertyName("preferred_language")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredLanguage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_language");

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    [TerraformPropertyName("profile_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ProfileUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "profile_url");

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformPropertyName("timezone")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Timezone => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "timezone");

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformPropertyName("title")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Title => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "title");

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformPropertyName("user_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_name");

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    [TerraformPropertyName("user_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UserType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "user_type");

}
