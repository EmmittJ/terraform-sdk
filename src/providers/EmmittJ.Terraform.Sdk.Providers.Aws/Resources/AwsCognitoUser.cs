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
    public TerraformMap<string>? Attributes { get; set; }

    /// <summary>
    /// The client_metadata attribute.
    /// </summary>
    [TerraformPropertyName("client_metadata")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ClientMetadata { get; set; }

    /// <summary>
    /// The desired_delivery_mediums attribute.
    /// </summary>
    [TerraformPropertyName("desired_delivery_mediums")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? DesiredDeliveryMediums { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The force_alias_creation attribute.
    /// </summary>
    [TerraformPropertyName("force_alias_creation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ForceAliasCreation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The message_action attribute.
    /// </summary>
    [TerraformPropertyName("message_action")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MessageAction { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformPropertyName("password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The temporary_password attribute.
    /// </summary>
    [TerraformPropertyName("temporary_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TemporaryPassword { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformPropertyName("username")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Username { get; set; }

    /// <summary>
    /// The validation_data attribute.
    /// </summary>
    [TerraformPropertyName("validation_data")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? ValidationData { get; set; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDate => new TerraformReference(this, "creation_date");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedDate => new TerraformReference(this, "last_modified_date");

    /// <summary>
    /// The mfa_setting_list attribute.
    /// </summary>
    [TerraformPropertyName("mfa_setting_list")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> MfaSettingList => new TerraformReference(this, "mfa_setting_list");

    /// <summary>
    /// The preferred_mfa_setting attribute.
    /// </summary>
    [TerraformPropertyName("preferred_mfa_setting")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PreferredMfaSetting => new TerraformReference(this, "preferred_mfa_setting");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The sub attribute.
    /// </summary>
    [TerraformPropertyName("sub")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sub => new TerraformReference(this, "sub");

}
