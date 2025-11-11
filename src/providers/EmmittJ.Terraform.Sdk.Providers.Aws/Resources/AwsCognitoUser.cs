using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user resource.
/// </summary>
public partial class AwsCognitoUser : TerraformResource
{
    public AwsCognitoUser(string name) : base("aws_cognito_user", name)
    {
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformProperty("attributes")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Attributes { get; set; }

    /// <summary>
    /// The client_metadata attribute.
    /// </summary>
    [TerraformProperty("client_metadata")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ClientMetadata { get; set; }

    /// <summary>
    /// The desired_delivery_mediums attribute.
    /// </summary>
    [TerraformProperty("desired_delivery_mediums")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? DesiredDeliveryMediums { get; set; }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The force_alias_creation attribute.
    /// </summary>
    [TerraformProperty("force_alias_creation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ForceAliasCreation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The message_action attribute.
    /// </summary>
    [TerraformProperty("message_action")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MessageAction { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The temporary_password attribute.
    /// </summary>
    [TerraformProperty("temporary_password")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TemporaryPassword { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    [TerraformProperty("username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Username { get; set; }

    /// <summary>
    /// The validation_data attribute.
    /// </summary>
    [TerraformProperty("validation_data")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? ValidationData { get; set; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformProperty("last_modified_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedDate { get; }

    /// <summary>
    /// The mfa_setting_list attribute.
    /// </summary>
    [TerraformProperty("mfa_setting_list")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> MfaSettingList { get; }

    /// <summary>
    /// The preferred_mfa_setting attribute.
    /// </summary>
    [TerraformProperty("preferred_mfa_setting")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> PreferredMfaSetting { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Status { get; }

    /// <summary>
    /// The sub attribute.
    /// </summary>
    [TerraformProperty("sub")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Sub { get; }

}
