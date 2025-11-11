using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for alternate_identifier in .
/// Nesting mode: list
/// </summary>
public partial class AwsIdentitystoreUserDataSourceAlternateIdentifierBlock : TerraformBlockBase
{
}

/// <summary>
/// Retrieves information about a aws_identitystore_user.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsIdentitystoreUserDataSource : TerraformDataSource
{
    public AwsIdentitystoreUserDataSource(string name) : base("aws_identitystore_user", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The identity_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityStoreId is required")]
    [TerraformProperty("identity_store_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> IdentityStoreId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformProperty("user_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> UserId { get; set; }

    /// <summary>
    /// Block for alternate_identifier.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AlternateIdentifier block(s) allowed")]
    [TerraformProperty("alternate_identifier")]
    public TerraformList<TerraformBlock<AwsIdentitystoreUserDataSourceAlternateIdentifierBlock>>? AlternateIdentifier { get; set; }

    /// <summary>
    /// The addresses attribute.
    /// </summary>
    [TerraformProperty("addresses")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Addresses { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The emails attribute.
    /// </summary>
    [TerraformProperty("emails")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Emails { get; }

    /// <summary>
    /// The external_ids attribute.
    /// </summary>
    [TerraformProperty("external_ids")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ExternalIds { get; }

    /// <summary>
    /// The locale attribute.
    /// </summary>
    [TerraformProperty("locale")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Locale { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Name { get; }

    /// <summary>
    /// The nickname attribute.
    /// </summary>
    [TerraformProperty("nickname")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Nickname { get; }

    /// <summary>
    /// The phone_numbers attribute.
    /// </summary>
    [TerraformProperty("phone_numbers")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PhoneNumbers { get; }

    /// <summary>
    /// The preferred_language attribute.
    /// </summary>
    [TerraformProperty("preferred_language")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredLanguage { get; }

    /// <summary>
    /// The profile_url attribute.
    /// </summary>
    [TerraformProperty("profile_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ProfileUrl { get; }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    [TerraformProperty("timezone")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Timezone { get; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [TerraformProperty("title")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Title { get; }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [TerraformProperty("user_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserName { get; }

    /// <summary>
    /// The user_type attribute.
    /// </summary>
    [TerraformProperty("user_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UserType { get; }

}
