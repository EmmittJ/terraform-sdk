using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user resource.
/// </summary>
public class AwsCognitoUser : TerraformResource
{
    public AwsCognitoUser(string name) : base("aws_cognito_user", name)
    {
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformPropertyName("attributes")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Attributes { get; set; }

    /// <summary>
    /// The client_metadata attribute.
    /// </summary>
    [TerraformPropertyName("client_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ClientMetadata { get; set; }

    /// <summary>
    /// The desired_delivery_mediums attribute.
    /// </summary>
    [TerraformPropertyName("desired_delivery_mediums")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? DesiredDeliveryMediums { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The force_alias_creation attribute.
    /// </summary>
    [TerraformPropertyName("force_alias_creation")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ForceAliasCreation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The message_action attribute.
    /// </summary>
    [TerraformPropertyName("message_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MessageAction { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Password { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The temporary_password attribute.
    /// </summary>
    [TerraformPropertyName("temporary_password")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TemporaryPassword { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Username { get; set; }

    /// <summary>
    /// The validation_data attribute.
    /// </summary>
    [TerraformPropertyName("validation_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ValidationData { get; set; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_date");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_date");

    /// <summary>
    /// The mfa_setting_list attribute.
    /// </summary>
    [TerraformPropertyName("mfa_setting_list")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> MfaSettingList => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "mfa_setting_list");

    /// <summary>
    /// The preferred_mfa_setting attribute.
    /// </summary>
    [TerraformPropertyName("preferred_mfa_setting")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PreferredMfaSetting => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "preferred_mfa_setting");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The sub attribute.
    /// </summary>
    [TerraformPropertyName("sub")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sub => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sub");

}
