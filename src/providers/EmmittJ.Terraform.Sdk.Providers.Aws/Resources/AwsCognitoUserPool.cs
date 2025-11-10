using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_recovery_setting in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolAccountRecoverySettingBlock : TerraformBlock
{
}

/// <summary>
/// Block type for admin_create_user_config in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolAdminCreateUserConfigBlock : TerraformBlock
{
    /// <summary>
    /// The allow_admin_create_user_only attribute.
    /// </summary>
    public TerraformProperty<bool>? AllowAdminCreateUserOnly
    {
        set => SetProperty("allow_admin_create_user_only", value);
    }

}

/// <summary>
/// Block type for device_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolDeviceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The challenge_required_on_new_device attribute.
    /// </summary>
    public TerraformProperty<bool>? ChallengeRequiredOnNewDevice
    {
        set => SetProperty("challenge_required_on_new_device", value);
    }

    /// <summary>
    /// The device_only_remembered_on_user_prompt attribute.
    /// </summary>
    public TerraformProperty<bool>? DeviceOnlyRememberedOnUserPrompt
    {
        set => SetProperty("device_only_remembered_on_user_prompt", value);
    }

}

/// <summary>
/// Block type for email_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolEmailConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    public TerraformProperty<string>? ConfigurationSet
    {
        set => SetProperty("configuration_set", value);
    }

    /// <summary>
    /// The email_sending_account attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSendingAccount
    {
        set => SetProperty("email_sending_account", value);
    }

    /// <summary>
    /// The from_email_address attribute.
    /// </summary>
    public TerraformProperty<string>? FromEmailAddress
    {
        set => SetProperty("from_email_address", value);
    }

    /// <summary>
    /// The reply_to_email_address attribute.
    /// </summary>
    public TerraformProperty<string>? ReplyToEmailAddress
    {
        set => SetProperty("reply_to_email_address", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceArn
    {
        set => SetProperty("source_arn", value);
    }

}

/// <summary>
/// Block type for email_mfa_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolEmailMfaConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformProperty<string>? Message
    {
        set => SetProperty("message", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        set => SetProperty("subject", value);
    }

}

/// <summary>
/// Block type for lambda_config in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolLambdaConfigBlock : TerraformBlock
{
    /// <summary>
    /// The create_auth_challenge attribute.
    /// </summary>
    public TerraformProperty<string>? CreateAuthChallenge
    {
        set => SetProperty("create_auth_challenge", value);
    }

    /// <summary>
    /// The custom_message attribute.
    /// </summary>
    public TerraformProperty<string>? CustomMessage
    {
        set => SetProperty("custom_message", value);
    }

    /// <summary>
    /// The define_auth_challenge attribute.
    /// </summary>
    public TerraformProperty<string>? DefineAuthChallenge
    {
        set => SetProperty("define_auth_challenge", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        set => SetProperty("kms_key_id", value);
    }

    /// <summary>
    /// The post_authentication attribute.
    /// </summary>
    public TerraformProperty<string>? PostAuthentication
    {
        set => SetProperty("post_authentication", value);
    }

    /// <summary>
    /// The post_confirmation attribute.
    /// </summary>
    public TerraformProperty<string>? PostConfirmation
    {
        set => SetProperty("post_confirmation", value);
    }

    /// <summary>
    /// The pre_authentication attribute.
    /// </summary>
    public TerraformProperty<string>? PreAuthentication
    {
        set => SetProperty("pre_authentication", value);
    }

    /// <summary>
    /// The pre_sign_up attribute.
    /// </summary>
    public TerraformProperty<string>? PreSignUp
    {
        set => SetProperty("pre_sign_up", value);
    }

    /// <summary>
    /// The pre_token_generation attribute.
    /// </summary>
    public TerraformProperty<string>? PreTokenGeneration
    {
        set => SetProperty("pre_token_generation", value);
    }

    /// <summary>
    /// The user_migration attribute.
    /// </summary>
    public TerraformProperty<string>? UserMigration
    {
        set => SetProperty("user_migration", value);
    }

    /// <summary>
    /// The verify_auth_challenge_response attribute.
    /// </summary>
    public TerraformProperty<string>? VerifyAuthChallengeResponse
    {
        set => SetProperty("verify_auth_challenge_response", value);
    }

}

/// <summary>
/// Block type for password_policy in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolPasswordPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The minimum_length attribute.
    /// </summary>
    public TerraformProperty<double>? MinimumLength
    {
        set => SetProperty("minimum_length", value);
    }

    /// <summary>
    /// The password_history_size attribute.
    /// </summary>
    public TerraformProperty<double>? PasswordHistorySize
    {
        set => SetProperty("password_history_size", value);
    }

    /// <summary>
    /// The require_lowercase attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireLowercase
    {
        set => SetProperty("require_lowercase", value);
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireNumbers
    {
        set => SetProperty("require_numbers", value);
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireSymbols
    {
        set => SetProperty("require_symbols", value);
    }

    /// <summary>
    /// The require_uppercase attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireUppercase
    {
        set => SetProperty("require_uppercase", value);
    }

    /// <summary>
    /// The temporary_password_validity_days attribute.
    /// </summary>
    public TerraformProperty<double>? TemporaryPasswordValidityDays
    {
        set => SetProperty("temporary_password_validity_days", value);
    }

}

/// <summary>
/// Block type for schema in .
/// Nesting mode: set
/// </summary>
public class AwsCognitoUserPoolSchemaBlock : TerraformBlock
{
    /// <summary>
    /// The attribute_data_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeDataType is required")]
    public required TerraformProperty<string> AttributeDataType
    {
        set => SetProperty("attribute_data_type", value);
    }

    /// <summary>
    /// The developer_only_attribute attribute.
    /// </summary>
    public TerraformProperty<bool>? DeveloperOnlyAttribute
    {
        set => SetProperty("developer_only_attribute", value);
    }

    /// <summary>
    /// The mutable attribute.
    /// </summary>
    public TerraformProperty<bool>? Mutable
    {
        set => SetProperty("mutable", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformProperty<bool>? Required
    {
        set => SetProperty("required", value);
    }

}

/// <summary>
/// Block type for sign_in_policy in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSignInPolicyBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_first_auth_factors attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedFirstAuthFactors
    {
        set => SetProperty("allowed_first_auth_factors", value);
    }

}

/// <summary>
/// Block type for sms_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSmsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    public required TerraformProperty<string> ExternalId
    {
        set => SetProperty("external_id", value);
    }

    /// <summary>
    /// The sns_caller_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsCallerArn is required")]
    public required TerraformProperty<string> SnsCallerArn
    {
        set => SetProperty("sns_caller_arn", value);
    }

    /// <summary>
    /// The sns_region attribute.
    /// </summary>
    public TerraformProperty<string>? SnsRegion
    {
        set => SetProperty("sns_region", value);
    }

}

/// <summary>
/// Block type for software_token_mfa_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

}

/// <summary>
/// Block type for user_attribute_update_settings in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUserAttributeUpdateSettingsBlock : TerraformBlock
{
    /// <summary>
    /// The attributes_require_verification_before_update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributesRequireVerificationBeforeUpdate is required")]
    public HashSet<TerraformProperty<string>>? AttributesRequireVerificationBeforeUpdate
    {
        set => SetProperty("attributes_require_verification_before_update", value);
    }

}

/// <summary>
/// Block type for user_pool_add_ons in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUserPoolAddOnsBlock : TerraformBlock
{
    /// <summary>
    /// The advanced_security_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvancedSecurityMode is required")]
    public required TerraformProperty<string> AdvancedSecurityMode
    {
        set => SetProperty("advanced_security_mode", value);
    }

}

/// <summary>
/// Block type for username_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUsernameConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    public TerraformProperty<bool>? CaseSensitive
    {
        set => SetProperty("case_sensitive", value);
    }

}

/// <summary>
/// Block type for verification_message_template in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolVerificationMessageTemplateBlock : TerraformBlock
{
    /// <summary>
    /// The default_email_option attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultEmailOption
    {
        set => SetProperty("default_email_option", value);
    }

    /// <summary>
    /// The email_message attribute.
    /// </summary>
    public TerraformProperty<string>? EmailMessage
    {
        set => SetProperty("email_message", value);
    }

    /// <summary>
    /// The email_message_by_link attribute.
    /// </summary>
    public TerraformProperty<string>? EmailMessageByLink
    {
        set => SetProperty("email_message_by_link", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSubject
    {
        set => SetProperty("email_subject", value);
    }

    /// <summary>
    /// The email_subject_by_link attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSubjectByLink
    {
        set => SetProperty("email_subject_by_link", value);
    }

    /// <summary>
    /// The sms_message attribute.
    /// </summary>
    public TerraformProperty<string>? SmsMessage
    {
        set => SetProperty("sms_message", value);
    }

}

/// <summary>
/// Block type for web_authn_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolWebAuthnConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The relying_party_id attribute.
    /// </summary>
    public TerraformProperty<string>? RelyingPartyId
    {
        set => SetProperty("relying_party_id", value);
    }

    /// <summary>
    /// The user_verification attribute.
    /// </summary>
    public TerraformProperty<string>? UserVerification
    {
        set => SetProperty("user_verification", value);
    }

}

/// <summary>
/// Manages a aws_cognito_user_pool resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCognitoUserPool : TerraformResource
{
    public AwsCognitoUserPool(string name) : base("aws_cognito_user_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("creation_date");
        SetOutput("custom_domain");
        SetOutput("domain");
        SetOutput("endpoint");
        SetOutput("estimated_number_of_users");
        SetOutput("last_modified_date");
        SetOutput("alias_attributes");
        SetOutput("auto_verified_attributes");
        SetOutput("deletion_protection");
        SetOutput("email_verification_message");
        SetOutput("email_verification_subject");
        SetOutput("id");
        SetOutput("mfa_configuration");
        SetOutput("name");
        SetOutput("region");
        SetOutput("sms_authentication_message");
        SetOutput("sms_verification_message");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("user_pool_tier");
        SetOutput("username_attributes");
    }

    /// <summary>
    /// The alias_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AliasAttributes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("alias_attributes");
        set => SetProperty("alias_attributes", value);
    }

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> AutoVerifiedAttributes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("auto_verified_attributes");
        set => SetProperty("auto_verified_attributes", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<string> DeletionProtection
    {
        get => GetRequiredOutput<TerraformProperty<string>>("deletion_protection");
        set => SetProperty("deletion_protection", value);
    }

    /// <summary>
    /// The email_verification_message attribute.
    /// </summary>
    public TerraformProperty<string> EmailVerificationMessage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_verification_message");
        set => SetProperty("email_verification_message", value);
    }

    /// <summary>
    /// The email_verification_subject attribute.
    /// </summary>
    public TerraformProperty<string> EmailVerificationSubject
    {
        get => GetRequiredOutput<TerraformProperty<string>>("email_verification_subject");
        set => SetProperty("email_verification_subject", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    public TerraformProperty<string> MfaConfiguration
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mfa_configuration");
        set => SetProperty("mfa_configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    public TerraformProperty<string> SmsAuthenticationMessage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sms_authentication_message");
        set => SetProperty("sms_authentication_message", value);
    }

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    public TerraformProperty<string> SmsVerificationMessage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sms_verification_message");
        set => SetProperty("sms_verification_message", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The user_pool_tier attribute.
    /// </summary>
    public TerraformProperty<string> UserPoolTier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_tier");
        set => SetProperty("user_pool_tier", value);
    }

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> UsernameAttributes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("username_attributes");
        set => SetProperty("username_attributes", value);
    }

    /// <summary>
    /// Block for account_recovery_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountRecoverySetting block(s) allowed")]
    public List<AwsCognitoUserPoolAccountRecoverySettingBlock>? AccountRecoverySetting
    {
        set => SetProperty("account_recovery_setting", value);
    }

    /// <summary>
    /// Block for admin_create_user_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminCreateUserConfig block(s) allowed")]
    public List<AwsCognitoUserPoolAdminCreateUserConfigBlock>? AdminCreateUserConfig
    {
        set => SetProperty("admin_create_user_config", value);
    }

    /// <summary>
    /// Block for device_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolDeviceConfigurationBlock>? DeviceConfiguration
    {
        set => SetProperty("device_configuration", value);
    }

    /// <summary>
    /// Block for email_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolEmailConfigurationBlock>? EmailConfiguration
    {
        set => SetProperty("email_configuration", value);
    }

    /// <summary>
    /// Block for email_mfa_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailMfaConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolEmailMfaConfigurationBlock>? EmailMfaConfiguration
    {
        set => SetProperty("email_mfa_configuration", value);
    }

    /// <summary>
    /// Block for lambda_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    public List<AwsCognitoUserPoolLambdaConfigBlock>? LambdaConfig
    {
        set => SetProperty("lambda_config", value);
    }

    /// <summary>
    /// Block for password_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    public List<AwsCognitoUserPoolPasswordPolicyBlock>? PasswordPolicy
    {
        set => SetProperty("password_policy", value);
    }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Schema block(s) allowed")]
    public HashSet<AwsCognitoUserPoolSchemaBlock>? Schema
    {
        set => SetProperty("schema", value);
    }

    /// <summary>
    /// Block for sign_in_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignInPolicy block(s) allowed")]
    public List<AwsCognitoUserPoolSignInPolicyBlock>? SignInPolicy
    {
        set => SetProperty("sign_in_policy", value);
    }

    /// <summary>
    /// Block for sms_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolSmsConfigurationBlock>? SmsConfiguration
    {
        set => SetProperty("sms_configuration", value);
    }

    /// <summary>
    /// Block for software_token_mfa_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareTokenMfaConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock>? SoftwareTokenMfaConfiguration
    {
        set => SetProperty("software_token_mfa_configuration", value);
    }

    /// <summary>
    /// Block for user_attribute_update_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserAttributeUpdateSettings block(s) allowed")]
    public List<AwsCognitoUserPoolUserAttributeUpdateSettingsBlock>? UserAttributeUpdateSettings
    {
        set => SetProperty("user_attribute_update_settings", value);
    }

    /// <summary>
    /// Block for user_pool_add_ons.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolAddOns block(s) allowed")]
    public List<AwsCognitoUserPoolUserPoolAddOnsBlock>? UserPoolAddOns
    {
        set => SetProperty("user_pool_add_ons", value);
    }

    /// <summary>
    /// Block for username_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UsernameConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolUsernameConfigurationBlock>? UsernameConfiguration
    {
        set => SetProperty("username_configuration", value);
    }

    /// <summary>
    /// Block for verification_message_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerificationMessageTemplate block(s) allowed")]
    public List<AwsCognitoUserPoolVerificationMessageTemplateBlock>? VerificationMessageTemplate
    {
        set => SetProperty("verification_message_template", value);
    }

    /// <summary>
    /// Block for web_authn_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAuthnConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolWebAuthnConfigurationBlock>? WebAuthnConfiguration
    {
        set => SetProperty("web_authn_configuration", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformExpression CustomDomain => this["custom_domain"];

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    public TerraformExpression EstimatedNumberOfUsers => this["estimated_number_of_users"];

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformExpression LastModifiedDate => this["last_modified_date"];

}
