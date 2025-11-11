using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool.
/// </summary>
public class AwsCognitoUserPoolDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolDataSource(string name) : base("aws_cognito_user_pool", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The account_recovery_setting attribute.
    /// </summary>
    [TerraformPropertyName("account_recovery_setting")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AccountRecoverySetting => new TerraformReference(this, "account_recovery_setting");

    /// <summary>
    /// The admin_create_user_config attribute.
    /// </summary>
    [TerraformPropertyName("admin_create_user_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AdminCreateUserConfig => new TerraformReference(this, "admin_create_user_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    [TerraformPropertyName("auto_verified_attributes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> AutoVerifiedAttributes => new TerraformReference(this, "auto_verified_attributes");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationDate => new TerraformReference(this, "creation_date");

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CustomDomain => new TerraformReference(this, "custom_domain");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeletionProtection => new TerraformReference(this, "deletion_protection");

    /// <summary>
    /// The device_configuration attribute.
    /// </summary>
    [TerraformPropertyName("device_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> DeviceConfiguration => new TerraformReference(this, "device_configuration");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Domain => new TerraformReference(this, "domain");

    /// <summary>
    /// The email_configuration attribute.
    /// </summary>
    [TerraformPropertyName("email_configuration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EmailConfiguration => new TerraformReference(this, "email_configuration");

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    [TerraformPropertyName("estimated_number_of_users")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EstimatedNumberOfUsers => new TerraformReference(this, "estimated_number_of_users");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The lambda_config attribute.
    /// </summary>
    [TerraformPropertyName("lambda_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LambdaConfig => new TerraformReference(this, "lambda_config");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedDate => new TerraformReference(this, "last_modified_date");

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    [TerraformPropertyName("mfa_configuration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MfaConfiguration => new TerraformReference(this, "mfa_configuration");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The schema_attributes attribute.
    /// </summary>
    [TerraformPropertyName("schema_attributes")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SchemaAttributes => new TerraformReference(this, "schema_attributes");

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    [TerraformPropertyName("sms_authentication_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SmsAuthenticationMessage => new TerraformReference(this, "sms_authentication_message");

    /// <summary>
    /// The sms_configuration_failure attribute.
    /// </summary>
    [TerraformPropertyName("sms_configuration_failure")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SmsConfigurationFailure => new TerraformReference(this, "sms_configuration_failure");

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    [TerraformPropertyName("sms_verification_message")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SmsVerificationMessage => new TerraformReference(this, "sms_verification_message");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The user_pool_add_ons attribute.
    /// </summary>
    [TerraformPropertyName("user_pool_add_ons")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UserPoolAddOns => new TerraformReference(this, "user_pool_add_ons");

    /// <summary>
    /// The user_pool_tags attribute.
    /// </summary>
    [TerraformPropertyName("user_pool_tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> UserPoolTags => new TerraformReference(this, "user_pool_tags");

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    [TerraformPropertyName("username_attributes")]
    // Output-only attribute - read-only reference
    public TerraformList<string> UsernameAttributes => new TerraformReference(this, "username_attributes");

}
