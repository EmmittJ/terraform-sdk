using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_recovery_setting in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolAccountRecoverySettingBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for admin_create_user_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolAdminCreateUserConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The allow_admin_create_user_only attribute.
    /// </summary>
    [TerraformProperty("allow_admin_create_user_only")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AllowAdminCreateUserOnly { get; set; }

}

/// <summary>
/// Block type for device_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolDeviceConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The challenge_required_on_new_device attribute.
    /// </summary>
    [TerraformProperty("challenge_required_on_new_device")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? ChallengeRequiredOnNewDevice { get; set; }

    /// <summary>
    /// The device_only_remembered_on_user_prompt attribute.
    /// </summary>
    [TerraformProperty("device_only_remembered_on_user_prompt")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeviceOnlyRememberedOnUserPrompt { get; set; }

}

/// <summary>
/// Block type for email_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolEmailConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    [TerraformProperty("configuration_set")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConfigurationSet { get; set; }

    /// <summary>
    /// The email_sending_account attribute.
    /// </summary>
    [TerraformProperty("email_sending_account")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EmailSendingAccount { get; set; }

    /// <summary>
    /// The from_email_address attribute.
    /// </summary>
    [TerraformProperty("from_email_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? FromEmailAddress { get; set; }

    /// <summary>
    /// The reply_to_email_address attribute.
    /// </summary>
    [TerraformProperty("reply_to_email_address")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ReplyToEmailAddress { get; set; }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformProperty("source_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceArn { get; set; }

}

/// <summary>
/// Block type for email_mfa_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolEmailMfaConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformProperty("message")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformProperty("subject")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Subject { get; set; }

}

/// <summary>
/// Block type for lambda_config in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolLambdaConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The create_auth_challenge attribute.
    /// </summary>
    [TerraformProperty("create_auth_challenge")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CreateAuthChallenge { get; set; }

    /// <summary>
    /// The custom_message attribute.
    /// </summary>
    [TerraformProperty("custom_message")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CustomMessage { get; set; }

    /// <summary>
    /// The define_auth_challenge attribute.
    /// </summary>
    [TerraformProperty("define_auth_challenge")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefineAuthChallenge { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformProperty("kms_key_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The post_authentication attribute.
    /// </summary>
    [TerraformProperty("post_authentication")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PostAuthentication { get; set; }

    /// <summary>
    /// The post_confirmation attribute.
    /// </summary>
    [TerraformProperty("post_confirmation")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PostConfirmation { get; set; }

    /// <summary>
    /// The pre_authentication attribute.
    /// </summary>
    [TerraformProperty("pre_authentication")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PreAuthentication { get; set; }

    /// <summary>
    /// The pre_sign_up attribute.
    /// </summary>
    [TerraformProperty("pre_sign_up")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PreSignUp { get; set; }

    /// <summary>
    /// The pre_token_generation attribute.
    /// </summary>
    [TerraformProperty("pre_token_generation")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> PreTokenGeneration { get; set; }

    /// <summary>
    /// The user_migration attribute.
    /// </summary>
    [TerraformProperty("user_migration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserMigration { get; set; }

    /// <summary>
    /// The verify_auth_challenge_response attribute.
    /// </summary>
    [TerraformProperty("verify_auth_challenge_response")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? VerifyAuthChallengeResponse { get; set; }

}

/// <summary>
/// Block type for password_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolPasswordPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The minimum_length attribute.
    /// </summary>
    [TerraformProperty("minimum_length")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? MinimumLength { get; set; }

    /// <summary>
    /// The password_history_size attribute.
    /// </summary>
    [TerraformProperty("password_history_size")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? PasswordHistorySize { get; set; }

    /// <summary>
    /// The require_lowercase attribute.
    /// </summary>
    [TerraformProperty("require_lowercase")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireLowercase { get; set; }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    [TerraformProperty("require_numbers")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireNumbers { get; set; }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    [TerraformProperty("require_symbols")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireSymbols { get; set; }

    /// <summary>
    /// The require_uppercase attribute.
    /// </summary>
    [TerraformProperty("require_uppercase")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? RequireUppercase { get; set; }

    /// <summary>
    /// The temporary_password_validity_days attribute.
    /// </summary>
    [TerraformProperty("temporary_password_validity_days")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<double> TemporaryPasswordValidityDays { get; set; }

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: set
/// </summary>
public partial class AwsCognitoUserPoolSchemaBlock : TerraformBlockBase
{
    /// <summary>
    /// The attribute_data_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeDataType is required")]
    [TerraformProperty("attribute_data_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AttributeDataType { get; set; }

    /// <summary>
    /// The developer_only_attribute attribute.
    /// </summary>
    [TerraformProperty("developer_only_attribute")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? DeveloperOnlyAttribute { get; set; }

    /// <summary>
    /// The mutable attribute.
    /// </summary>
    [TerraformProperty("mutable")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Mutable { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [TerraformProperty("required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Required { get; set; }

}

/// <summary>
/// Block type for sign_in_policy in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolSignInPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The allowed_first_auth_factors attribute.
    /// </summary>
    [TerraformProperty("allowed_first_auth_factors")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AllowedFirstAuthFactors { get; set; }

}

/// <summary>
/// Block type for sms_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolSmsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    [TerraformProperty("external_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ExternalId { get; set; }

    /// <summary>
    /// The sns_caller_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsCallerArn is required")]
    [TerraformProperty("sns_caller_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SnsCallerArn { get; set; }

    /// <summary>
    /// The sns_region attribute.
    /// </summary>
    [TerraformProperty("sns_region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SnsRegion { get; set; }

}

/// <summary>
/// Block type for software_token_mfa_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for user_attribute_update_settings in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolUserAttributeUpdateSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The attributes_require_verification_before_update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributesRequireVerificationBeforeUpdate is required")]
    [TerraformProperty("attributes_require_verification_before_update")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> AttributesRequireVerificationBeforeUpdate { get; set; }

}

/// <summary>
/// Block type for user_pool_add_ons in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolUserPoolAddOnsBlock : TerraformBlockBase
{
    /// <summary>
    /// The advanced_security_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvancedSecurityMode is required")]
    [TerraformProperty("advanced_security_mode")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AdvancedSecurityMode { get; set; }

}

/// <summary>
/// Block type for username_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolUsernameConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    [TerraformProperty("case_sensitive")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<bool> CaseSensitive { get; set; }

}

/// <summary>
/// Block type for verification_message_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolVerificationMessageTemplateBlock : TerraformBlockBase
{
    /// <summary>
    /// The default_email_option attribute.
    /// </summary>
    [TerraformProperty("default_email_option")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultEmailOption { get; set; }

    /// <summary>
    /// The email_message attribute.
    /// </summary>
    [TerraformProperty("email_message")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EmailMessage { get; set; }

    /// <summary>
    /// The email_message_by_link attribute.
    /// </summary>
    [TerraformProperty("email_message_by_link")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EmailMessageByLink { get; set; }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [TerraformProperty("email_subject")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EmailSubject { get; set; }

    /// <summary>
    /// The email_subject_by_link attribute.
    /// </summary>
    [TerraformProperty("email_subject_by_link")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EmailSubjectByLink { get; set; }

    /// <summary>
    /// The sms_message attribute.
    /// </summary>
    [TerraformProperty("sms_message")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SmsMessage { get; set; }

}

/// <summary>
/// Block type for web_authn_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AwsCognitoUserPoolWebAuthnConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The relying_party_id attribute.
    /// </summary>
    [TerraformProperty("relying_party_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? RelyingPartyId { get; set; }

    /// <summary>
    /// The user_verification attribute.
    /// </summary>
    [TerraformProperty("user_verification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserVerification { get; set; }

}

/// <summary>
/// Manages a aws_cognito_user_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsCognitoUserPool : TerraformResource
{
    public AwsCognitoUserPool(string name) : base("aws_cognito_user_pool", name)
    {
    }

    /// <summary>
    /// The alias_attributes attribute.
    /// </summary>
    [TerraformProperty("alias_attributes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AliasAttributes { get; set; }

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    [TerraformProperty("auto_verified_attributes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformProperty("deletion_protection")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DeletionProtection { get; set; }

    /// <summary>
    /// The email_verification_message attribute.
    /// </summary>
    [TerraformProperty("email_verification_message")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EmailVerificationMessage { get; set; }

    /// <summary>
    /// The email_verification_subject attribute.
    /// </summary>
    [TerraformProperty("email_verification_subject")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> EmailVerificationSubject { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    [TerraformProperty("mfa_configuration")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? MfaConfiguration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    [TerraformProperty("sms_authentication_message")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SmsAuthenticationMessage { get; set; }

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    [TerraformProperty("sms_verification_message")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> SmsVerificationMessage { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The user_pool_tier attribute.
    /// </summary>
    [TerraformProperty("user_pool_tier")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> UserPoolTier { get; set; }

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    [TerraformProperty("username_attributes")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? UsernameAttributes { get; set; }

    /// <summary>
    /// Block for account_recovery_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountRecoverySetting block(s) allowed")]
    [TerraformProperty("account_recovery_setting")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolAccountRecoverySettingBlock>>? AccountRecoverySetting { get; set; }

    /// <summary>
    /// Block for admin_create_user_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminCreateUserConfig block(s) allowed")]
    [TerraformProperty("admin_create_user_config")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolAdminCreateUserConfigBlock>>? AdminCreateUserConfig { get; set; }

    /// <summary>
    /// Block for device_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceConfiguration block(s) allowed")]
    [TerraformProperty("device_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolDeviceConfigurationBlock>>? DeviceConfiguration { get; set; }

    /// <summary>
    /// Block for email_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailConfiguration block(s) allowed")]
    [TerraformProperty("email_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolEmailConfigurationBlock>>? EmailConfiguration { get; set; }

    /// <summary>
    /// Block for email_mfa_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailMfaConfiguration block(s) allowed")]
    [TerraformProperty("email_mfa_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolEmailMfaConfigurationBlock>>? EmailMfaConfiguration { get; set; }

    /// <summary>
    /// Block for lambda_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    [TerraformProperty("lambda_config")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolLambdaConfigBlock>>? LambdaConfig { get; set; }

    /// <summary>
    /// Block for password_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    [TerraformProperty("password_policy")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolPasswordPolicyBlock>>? PasswordPolicy { get; set; }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Schema block(s) allowed")]
    [TerraformProperty("schema")]
    public TerraformSet<TerraformBlock<AwsCognitoUserPoolSchemaBlock>>? Schema { get; set; }

    /// <summary>
    /// Block for sign_in_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignInPolicy block(s) allowed")]
    [TerraformProperty("sign_in_policy")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolSignInPolicyBlock>>? SignInPolicy { get; set; }

    /// <summary>
    /// Block for sms_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsConfiguration block(s) allowed")]
    [TerraformProperty("sms_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolSmsConfigurationBlock>>? SmsConfiguration { get; set; }

    /// <summary>
    /// Block for software_token_mfa_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareTokenMfaConfiguration block(s) allowed")]
    [TerraformProperty("software_token_mfa_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock>>? SoftwareTokenMfaConfiguration { get; set; }

    /// <summary>
    /// Block for user_attribute_update_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserAttributeUpdateSettings block(s) allowed")]
    [TerraformProperty("user_attribute_update_settings")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolUserAttributeUpdateSettingsBlock>>? UserAttributeUpdateSettings { get; set; }

    /// <summary>
    /// Block for user_pool_add_ons.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolAddOns block(s) allowed")]
    [TerraformProperty("user_pool_add_ons")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolUserPoolAddOnsBlock>>? UserPoolAddOns { get; set; }

    /// <summary>
    /// Block for username_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UsernameConfiguration block(s) allowed")]
    [TerraformProperty("username_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolUsernameConfigurationBlock>>? UsernameConfiguration { get; set; }

    /// <summary>
    /// Block for verification_message_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerificationMessageTemplate block(s) allowed")]
    [TerraformProperty("verification_message_template")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolVerificationMessageTemplateBlock>>? VerificationMessageTemplate { get; set; }

    /// <summary>
    /// Block for web_authn_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAuthnConfiguration block(s) allowed")]
    [TerraformProperty("web_authn_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolWebAuthnConfigurationBlock>>? WebAuthnConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

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
    /// The domain attribute.
    /// </summary>
    [TerraformProperty("domain")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Domain { get; }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformProperty("endpoint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Endpoint { get; }

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    [TerraformProperty("estimated_number_of_users")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> EstimatedNumberOfUsers { get; }

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformProperty("last_modified_date")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> LastModifiedDate { get; }

}
