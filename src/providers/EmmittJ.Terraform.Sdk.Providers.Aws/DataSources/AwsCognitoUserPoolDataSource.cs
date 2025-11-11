using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool.
/// </summary>
public partial class AwsCognitoUserPoolDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolDataSource(string name) : base("aws_cognito_user_pool", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformProperty("user_pool_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> UserPoolId { get; set; }

    /// <summary>
    /// The account_recovery_setting attribute.
    /// </summary>
    [TerraformProperty("account_recovery_setting")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AccountRecoverySetting { get; }

    /// <summary>
    /// The admin_create_user_config attribute.
    /// </summary>
    [TerraformProperty("admin_create_user_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AdminCreateUserConfig { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    [TerraformProperty("auto_verified_attributes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> AutoVerifiedAttributes { get; }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformProperty("creation_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationDate { get; }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    [TerraformProperty("custom_domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CustomDomain { get; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeletionProtection { get; }

    /// <summary>
    /// The device_configuration attribute.
    /// </summary>
    [TerraformProperty("device_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DeviceConfiguration { get; }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Domain { get; }

    /// <summary>
    /// The email_configuration attribute.
    /// </summary>
    [TerraformProperty("email_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EmailConfiguration { get; }

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    [TerraformProperty("estimated_number_of_users")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> EstimatedNumberOfUsers { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The lambda_config attribute.
    /// </summary>
    [TerraformProperty("lambda_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> LambdaConfig { get; }

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformProperty("last_modified_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedDate { get; }

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    [TerraformProperty("mfa_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> MfaConfiguration { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The schema_attributes attribute.
    /// </summary>
    [TerraformProperty("schema_attributes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SchemaAttributes { get; }

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    [TerraformProperty("sms_authentication_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SmsAuthenticationMessage { get; }

    /// <summary>
    /// The sms_configuration_failure attribute.
    /// </summary>
    [TerraformProperty("sms_configuration_failure")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SmsConfigurationFailure { get; }

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    [TerraformProperty("sms_verification_message")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SmsVerificationMessage { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The user_pool_add_ons attribute.
    /// </summary>
    [TerraformProperty("user_pool_add_ons")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> UserPoolAddOns { get; }

    /// <summary>
    /// The user_pool_tags attribute.
    /// </summary>
    [TerraformProperty("user_pool_tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> UserPoolTags { get; }

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    [TerraformProperty("username_attributes")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<string> UsernameAttributes { get; }

}
