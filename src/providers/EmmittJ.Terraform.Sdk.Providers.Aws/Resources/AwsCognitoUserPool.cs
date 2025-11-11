using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_recovery_setting in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolAccountRecoverySettingBlock
{
}

/// <summary>
/// Block type for admin_create_user_config in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolAdminCreateUserConfigBlock
{
    /// <summary>
    /// The allow_admin_create_user_only attribute.
    /// </summary>
    [TerraformPropertyName("allow_admin_create_user_only")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowAdminCreateUserOnly { get; set; }

}

/// <summary>
/// Block type for device_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolDeviceConfigurationBlock
{
    /// <summary>
    /// The challenge_required_on_new_device attribute.
    /// </summary>
    [TerraformPropertyName("challenge_required_on_new_device")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ChallengeRequiredOnNewDevice { get; set; }

    /// <summary>
    /// The device_only_remembered_on_user_prompt attribute.
    /// </summary>
    [TerraformPropertyName("device_only_remembered_on_user_prompt")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeviceOnlyRememberedOnUserPrompt { get; set; }

}

/// <summary>
/// Block type for email_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolEmailConfigurationBlock
{
    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    [TerraformPropertyName("configuration_set")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ConfigurationSet { get; set; }

    /// <summary>
    /// The email_sending_account attribute.
    /// </summary>
    [TerraformPropertyName("email_sending_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? EmailSendingAccount { get; set; }

    /// <summary>
    /// The from_email_address attribute.
    /// </summary>
    [TerraformPropertyName("from_email_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? FromEmailAddress { get; set; }

    /// <summary>
    /// The reply_to_email_address attribute.
    /// </summary>
    [TerraformPropertyName("reply_to_email_address")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ReplyToEmailAddress { get; set; }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    [TerraformPropertyName("source_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SourceArn { get; set; }

}

/// <summary>
/// Block type for email_mfa_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolEmailMfaConfigurationBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    [TerraformPropertyName("message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Message { get; set; }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    [TerraformPropertyName("subject")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Subject { get; set; }

}

/// <summary>
/// Block type for lambda_config in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolLambdaConfigBlock
{
    /// <summary>
    /// The create_auth_challenge attribute.
    /// </summary>
    [TerraformPropertyName("create_auth_challenge")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CreateAuthChallenge { get; set; }

    /// <summary>
    /// The custom_message attribute.
    /// </summary>
    [TerraformPropertyName("custom_message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CustomMessage { get; set; }

    /// <summary>
    /// The define_auth_challenge attribute.
    /// </summary>
    [TerraformPropertyName("define_auth_challenge")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefineAuthChallenge { get; set; }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKeyId { get; set; }

    /// <summary>
    /// The post_authentication attribute.
    /// </summary>
    [TerraformPropertyName("post_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PostAuthentication { get; set; }

    /// <summary>
    /// The post_confirmation attribute.
    /// </summary>
    [TerraformPropertyName("post_confirmation")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PostConfirmation { get; set; }

    /// <summary>
    /// The pre_authentication attribute.
    /// </summary>
    [TerraformPropertyName("pre_authentication")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreAuthentication { get; set; }

    /// <summary>
    /// The pre_sign_up attribute.
    /// </summary>
    [TerraformPropertyName("pre_sign_up")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PreSignUp { get; set; }

    /// <summary>
    /// The pre_token_generation attribute.
    /// </summary>
    [TerraformPropertyName("pre_token_generation")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> PreTokenGeneration { get; set; } = default!;

    /// <summary>
    /// The user_migration attribute.
    /// </summary>
    [TerraformPropertyName("user_migration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserMigration { get; set; }

    /// <summary>
    /// The verify_auth_challenge_response attribute.
    /// </summary>
    [TerraformPropertyName("verify_auth_challenge_response")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? VerifyAuthChallengeResponse { get; set; }

}

/// <summary>
/// Block type for password_policy in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolPasswordPolicyBlock
{
    /// <summary>
    /// The minimum_length attribute.
    /// </summary>
    [TerraformPropertyName("minimum_length")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? MinimumLength { get; set; }

    /// <summary>
    /// The password_history_size attribute.
    /// </summary>
    [TerraformPropertyName("password_history_size")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? PasswordHistorySize { get; set; }

    /// <summary>
    /// The require_lowercase attribute.
    /// </summary>
    [TerraformPropertyName("require_lowercase")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireLowercase { get; set; }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    [TerraformPropertyName("require_numbers")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireNumbers { get; set; }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    [TerraformPropertyName("require_symbols")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireSymbols { get; set; }

    /// <summary>
    /// The require_uppercase attribute.
    /// </summary>
    [TerraformPropertyName("require_uppercase")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? RequireUppercase { get; set; }

    /// <summary>
    /// The temporary_password_validity_days attribute.
    /// </summary>
    [TerraformPropertyName("temporary_password_validity_days")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<double> TemporaryPasswordValidityDays { get; set; } = default!;

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoUserPoolSchemaBlock
{
    /// <summary>
    /// The attribute_data_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeDataType is required")]
    [TerraformPropertyName("attribute_data_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AttributeDataType { get; set; }

    /// <summary>
    /// The developer_only_attribute attribute.
    /// </summary>
    [TerraformPropertyName("developer_only_attribute")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeveloperOnlyAttribute { get; set; }

    /// <summary>
    /// The mutable attribute.
    /// </summary>
    [TerraformPropertyName("mutable")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Mutable { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [TerraformPropertyName("required")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Required { get; set; }

}

/// <summary>
/// Block type for sign_in_policy in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSignInPolicyBlock
{
    /// <summary>
    /// The allowed_first_auth_factors attribute.
    /// </summary>
    [TerraformPropertyName("allowed_first_auth_factors")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AllowedFirstAuthFactors { get; set; }

}

/// <summary>
/// Block type for sms_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSmsConfigurationBlock
{
    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    [TerraformPropertyName("external_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ExternalId { get; set; }

    /// <summary>
    /// The sns_caller_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsCallerArn is required")]
    [TerraformPropertyName("sns_caller_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SnsCallerArn { get; set; }

    /// <summary>
    /// The sns_region attribute.
    /// </summary>
    [TerraformPropertyName("sns_region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SnsRegion { get; set; } = default!;

}

/// <summary>
/// Block type for software_token_mfa_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

}

/// <summary>
/// Block type for user_attribute_update_settings in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUserAttributeUpdateSettingsBlock
{
    /// <summary>
    /// The attributes_require_verification_before_update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributesRequireVerificationBeforeUpdate is required")]
    [TerraformPropertyName("attributes_require_verification_before_update")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> AttributesRequireVerificationBeforeUpdate { get; set; }

}

/// <summary>
/// Block type for user_pool_add_ons in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUserPoolAddOnsBlock
{
    /// <summary>
    /// The advanced_security_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvancedSecurityMode is required")]
    [TerraformPropertyName("advanced_security_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdvancedSecurityMode { get; set; }

}

/// <summary>
/// Block type for username_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUsernameConfigurationBlock
{
    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    [TerraformPropertyName("case_sensitive")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<bool> CaseSensitive { get; set; } = default!;

}

/// <summary>
/// Block type for verification_message_template in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolVerificationMessageTemplateBlock
{
    /// <summary>
    /// The default_email_option attribute.
    /// </summary>
    [TerraformPropertyName("default_email_option")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultEmailOption { get; set; }

    /// <summary>
    /// The email_message attribute.
    /// </summary>
    [TerraformPropertyName("email_message")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmailMessage { get; set; } = default!;

    /// <summary>
    /// The email_message_by_link attribute.
    /// </summary>
    [TerraformPropertyName("email_message_by_link")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmailMessageByLink { get; set; } = default!;

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    [TerraformPropertyName("email_subject")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmailSubject { get; set; } = default!;

    /// <summary>
    /// The email_subject_by_link attribute.
    /// </summary>
    [TerraformPropertyName("email_subject_by_link")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmailSubjectByLink { get; set; } = default!;

    /// <summary>
    /// The sms_message attribute.
    /// </summary>
    [TerraformPropertyName("sms_message")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SmsMessage { get; set; } = default!;

}

/// <summary>
/// Block type for web_authn_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolWebAuthnConfigurationBlock
{
    /// <summary>
    /// The relying_party_id attribute.
    /// </summary>
    [TerraformPropertyName("relying_party_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RelyingPartyId { get; set; }

    /// <summary>
    /// The user_verification attribute.
    /// </summary>
    [TerraformPropertyName("user_verification")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserVerification { get; set; }

}

/// <summary>
/// Manages a aws_cognito_user_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCognitoUserPool : TerraformResource
{
    public AwsCognitoUserPool(string name) : base("aws_cognito_user_pool", name)
    {
    }

    /// <summary>
    /// The alias_attributes attribute.
    /// </summary>
    [TerraformPropertyName("alias_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AliasAttributes { get; set; }

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    [TerraformPropertyName("auto_verified_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? AutoVerifiedAttributes { get; set; }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    [TerraformPropertyName("deletion_protection")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DeletionProtection { get; set; }

    /// <summary>
    /// The email_verification_message attribute.
    /// </summary>
    [TerraformPropertyName("email_verification_message")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmailVerificationMessage { get; set; } = default!;

    /// <summary>
    /// The email_verification_subject attribute.
    /// </summary>
    [TerraformPropertyName("email_verification_subject")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> EmailVerificationSubject { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    [TerraformPropertyName("mfa_configuration")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? MfaConfiguration { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    [TerraformPropertyName("sms_authentication_message")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SmsAuthenticationMessage { get; set; }

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    [TerraformPropertyName("sms_verification_message")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> SmsVerificationMessage { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// The user_pool_tier attribute.
    /// </summary>
    [TerraformPropertyName("user_pool_tier")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> UserPoolTier { get; set; } = default!;

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    [TerraformPropertyName("username_attributes")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? UsernameAttributes { get; set; }

    /// <summary>
    /// Block for account_recovery_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountRecoverySetting block(s) allowed")]
    [TerraformPropertyName("account_recovery_setting")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolAccountRecoverySettingBlock>>? AccountRecoverySetting { get; set; }

    /// <summary>
    /// Block for admin_create_user_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminCreateUserConfig block(s) allowed")]
    [TerraformPropertyName("admin_create_user_config")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolAdminCreateUserConfigBlock>>? AdminCreateUserConfig { get; set; }

    /// <summary>
    /// Block for device_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceConfiguration block(s) allowed")]
    [TerraformPropertyName("device_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolDeviceConfigurationBlock>>? DeviceConfiguration { get; set; }

    /// <summary>
    /// Block for email_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailConfiguration block(s) allowed")]
    [TerraformPropertyName("email_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolEmailConfigurationBlock>>? EmailConfiguration { get; set; }

    /// <summary>
    /// Block for email_mfa_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailMfaConfiguration block(s) allowed")]
    [TerraformPropertyName("email_mfa_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolEmailMfaConfigurationBlock>>? EmailMfaConfiguration { get; set; }

    /// <summary>
    /// Block for lambda_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    [TerraformPropertyName("lambda_config")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolLambdaConfigBlock>>? LambdaConfig { get; set; }

    /// <summary>
    /// Block for password_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    [TerraformPropertyName("password_policy")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolPasswordPolicyBlock>>? PasswordPolicy { get; set; }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Schema block(s) allowed")]
    [TerraformPropertyName("schema")]
    public TerraformSet<TerraformBlock<AwsCognitoUserPoolSchemaBlock>>? Schema { get; set; }

    /// <summary>
    /// Block for sign_in_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignInPolicy block(s) allowed")]
    [TerraformPropertyName("sign_in_policy")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolSignInPolicyBlock>>? SignInPolicy { get; set; }

    /// <summary>
    /// Block for sms_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsConfiguration block(s) allowed")]
    [TerraformPropertyName("sms_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolSmsConfigurationBlock>>? SmsConfiguration { get; set; }

    /// <summary>
    /// Block for software_token_mfa_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareTokenMfaConfiguration block(s) allowed")]
    [TerraformPropertyName("software_token_mfa_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock>>? SoftwareTokenMfaConfiguration { get; set; }

    /// <summary>
    /// Block for user_attribute_update_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserAttributeUpdateSettings block(s) allowed")]
    [TerraformPropertyName("user_attribute_update_settings")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolUserAttributeUpdateSettingsBlock>>? UserAttributeUpdateSettings { get; set; }

    /// <summary>
    /// Block for user_pool_add_ons.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolAddOns block(s) allowed")]
    [TerraformPropertyName("user_pool_add_ons")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolUserPoolAddOnsBlock>>? UserPoolAddOns { get; set; }

    /// <summary>
    /// Block for username_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UsernameConfiguration block(s) allowed")]
    [TerraformPropertyName("username_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolUsernameConfigurationBlock>>? UsernameConfiguration { get; set; }

    /// <summary>
    /// Block for verification_message_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerificationMessageTemplate block(s) allowed")]
    [TerraformPropertyName("verification_message_template")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolVerificationMessageTemplateBlock>>? VerificationMessageTemplate { get; set; }

    /// <summary>
    /// Block for web_authn_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAuthnConfiguration block(s) allowed")]
    [TerraformPropertyName("web_authn_configuration")]
    public TerraformList<TerraformBlock<AwsCognitoUserPoolWebAuthnConfigurationBlock>>? WebAuthnConfiguration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

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
    /// The domain attribute.
    /// </summary>
    [TerraformPropertyName("domain")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Domain => new TerraformReference(this, "domain");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    [TerraformPropertyName("endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Endpoint => new TerraformReference(this, "endpoint");

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    [TerraformPropertyName("estimated_number_of_users")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> EstimatedNumberOfUsers => new TerraformReference(this, "estimated_number_of_users");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    [TerraformPropertyName("last_modified_date")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModifiedDate => new TerraformReference(this, "last_modified_date");

}
