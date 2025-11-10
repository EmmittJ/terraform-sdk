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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    [TerraformPropertyName("user_pool_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UserPoolId { get; set; }

    /// <summary>
    /// The account_recovery_setting attribute.
    /// </summary>
    [TerraformPropertyName("account_recovery_setting")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AccountRecoverySetting => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "account_recovery_setting");

    /// <summary>
    /// The admin_create_user_config attribute.
    /// </summary>
    [TerraformPropertyName("admin_create_user_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AdminCreateUserConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "admin_create_user_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    [TerraformPropertyName("auto_verified_attributes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> AutoVerifiedAttributes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "auto_verified_attributes");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    [TerraformPropertyName("creation_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_date");

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    [TerraformPropertyName("custom_domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CustomDomain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "custom_domain");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeletionProtection => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deletion_protection");

    /// <summary>
    /// The device_configuration attribute.
    /// </summary>
    [TerraformPropertyName("device_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DeviceConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "device_configuration");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Domain => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain");

    /// <summary>
    /// The email_configuration attribute.
    /// </summary>
    [TerraformPropertyName("email_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EmailConfiguration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "email_configuration");

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    [TerraformPropertyName("estimated_number_of_users")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> EstimatedNumberOfUsers => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "estimated_number_of_users");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The lambda_config attribute.
    /// </summary>
    [TerraformPropertyName("lambda_config")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LambdaConfig => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "lambda_config");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModifiedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified_date");

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    [TerraformPropertyName("mfa_configuration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MfaConfiguration => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "mfa_configuration");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The schema_attributes attribute.
    /// </summary>
    [TerraformPropertyName("schema_attributes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SchemaAttributes => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "schema_attributes");

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    [TerraformPropertyName("sms_authentication_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SmsAuthenticationMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sms_authentication_message");

    /// <summary>
    /// The sms_configuration_failure attribute.
    /// </summary>
    [TerraformPropertyName("sms_configuration_failure")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SmsConfigurationFailure => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sms_configuration_failure");

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    [TerraformPropertyName("sms_verification_message")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SmsVerificationMessage => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sms_verification_message");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The user_pool_add_ons attribute.
    /// </summary>
    [TerraformPropertyName("user_pool_add_ons")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> UserPoolAddOns => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "user_pool_add_ons");

    /// <summary>
    /// The user_pool_tags attribute.
    /// </summary>
    [TerraformPropertyName("user_pool_tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> UserPoolTags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "user_pool_tags");

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    [TerraformPropertyName("username_attributes")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> UsernameAttributes => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "username_attributes");

}
