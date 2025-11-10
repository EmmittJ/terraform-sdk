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
        get => GetProperty<TerraformProperty<bool>>("allow_admin_create_user_only");
        set => WithProperty("allow_admin_create_user_only", value);
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
        get => GetProperty<TerraformProperty<bool>>("challenge_required_on_new_device");
        set => WithProperty("challenge_required_on_new_device", value);
    }

    /// <summary>
    /// The device_only_remembered_on_user_prompt attribute.
    /// </summary>
    public TerraformProperty<bool>? DeviceOnlyRememberedOnUserPrompt
    {
        get => GetProperty<TerraformProperty<bool>>("device_only_remembered_on_user_prompt");
        set => WithProperty("device_only_remembered_on_user_prompt", value);
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
        get => GetProperty<TerraformProperty<string>>("configuration_set");
        set => WithProperty("configuration_set", value);
    }

    /// <summary>
    /// The email_sending_account attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSendingAccount
    {
        get => GetProperty<TerraformProperty<string>>("email_sending_account");
        set => WithProperty("email_sending_account", value);
    }

    /// <summary>
    /// The from_email_address attribute.
    /// </summary>
    public TerraformProperty<string>? FromEmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("from_email_address");
        set => WithProperty("from_email_address", value);
    }

    /// <summary>
    /// The reply_to_email_address attribute.
    /// </summary>
    public TerraformProperty<string>? ReplyToEmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("reply_to_email_address");
        set => WithProperty("reply_to_email_address", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SourceArn
    {
        get => GetProperty<TerraformProperty<string>>("source_arn");
        set => WithProperty("source_arn", value);
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
        get => GetProperty<TerraformProperty<string>>("message");
        set => WithProperty("message", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformProperty<string>? Subject
    {
        get => GetProperty<TerraformProperty<string>>("subject");
        set => WithProperty("subject", value);
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
        get => GetProperty<TerraformProperty<string>>("create_auth_challenge");
        set => WithProperty("create_auth_challenge", value);
    }

    /// <summary>
    /// The custom_message attribute.
    /// </summary>
    public TerraformProperty<string>? CustomMessage
    {
        get => GetProperty<TerraformProperty<string>>("custom_message");
        set => WithProperty("custom_message", value);
    }

    /// <summary>
    /// The define_auth_challenge attribute.
    /// </summary>
    public TerraformProperty<string>? DefineAuthChallenge
    {
        get => GetProperty<TerraformProperty<string>>("define_auth_challenge");
        set => WithProperty("define_auth_challenge", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? KmsKeyId
    {
        get => GetProperty<TerraformProperty<string>>("kms_key_id");
        set => WithProperty("kms_key_id", value);
    }

    /// <summary>
    /// The post_authentication attribute.
    /// </summary>
    public TerraformProperty<string>? PostAuthentication
    {
        get => GetProperty<TerraformProperty<string>>("post_authentication");
        set => WithProperty("post_authentication", value);
    }

    /// <summary>
    /// The post_confirmation attribute.
    /// </summary>
    public TerraformProperty<string>? PostConfirmation
    {
        get => GetProperty<TerraformProperty<string>>("post_confirmation");
        set => WithProperty("post_confirmation", value);
    }

    /// <summary>
    /// The pre_authentication attribute.
    /// </summary>
    public TerraformProperty<string>? PreAuthentication
    {
        get => GetProperty<TerraformProperty<string>>("pre_authentication");
        set => WithProperty("pre_authentication", value);
    }

    /// <summary>
    /// The pre_sign_up attribute.
    /// </summary>
    public TerraformProperty<string>? PreSignUp
    {
        get => GetProperty<TerraformProperty<string>>("pre_sign_up");
        set => WithProperty("pre_sign_up", value);
    }

    /// <summary>
    /// The pre_token_generation attribute.
    /// </summary>
    public TerraformProperty<string>? PreTokenGeneration
    {
        get => GetProperty<TerraformProperty<string>>("pre_token_generation");
        set => WithProperty("pre_token_generation", value);
    }

    /// <summary>
    /// The user_migration attribute.
    /// </summary>
    public TerraformProperty<string>? UserMigration
    {
        get => GetProperty<TerraformProperty<string>>("user_migration");
        set => WithProperty("user_migration", value);
    }

    /// <summary>
    /// The verify_auth_challenge_response attribute.
    /// </summary>
    public TerraformProperty<string>? VerifyAuthChallengeResponse
    {
        get => GetProperty<TerraformProperty<string>>("verify_auth_challenge_response");
        set => WithProperty("verify_auth_challenge_response", value);
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
        get => GetProperty<TerraformProperty<double>>("minimum_length");
        set => WithProperty("minimum_length", value);
    }

    /// <summary>
    /// The password_history_size attribute.
    /// </summary>
    public TerraformProperty<double>? PasswordHistorySize
    {
        get => GetProperty<TerraformProperty<double>>("password_history_size");
        set => WithProperty("password_history_size", value);
    }

    /// <summary>
    /// The require_lowercase attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireLowercase
    {
        get => GetProperty<TerraformProperty<bool>>("require_lowercase");
        set => WithProperty("require_lowercase", value);
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireNumbers
    {
        get => GetProperty<TerraformProperty<bool>>("require_numbers");
        set => WithProperty("require_numbers", value);
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireSymbols
    {
        get => GetProperty<TerraformProperty<bool>>("require_symbols");
        set => WithProperty("require_symbols", value);
    }

    /// <summary>
    /// The require_uppercase attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireUppercase
    {
        get => GetProperty<TerraformProperty<bool>>("require_uppercase");
        set => WithProperty("require_uppercase", value);
    }

    /// <summary>
    /// The temporary_password_validity_days attribute.
    /// </summary>
    public TerraformProperty<double>? TemporaryPasswordValidityDays
    {
        get => GetProperty<TerraformProperty<double>>("temporary_password_validity_days");
        set => WithProperty("temporary_password_validity_days", value);
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
        get => GetProperty<TerraformProperty<string>>("attribute_data_type");
        set => WithProperty("attribute_data_type", value);
    }

    /// <summary>
    /// The developer_only_attribute attribute.
    /// </summary>
    public TerraformProperty<bool>? DeveloperOnlyAttribute
    {
        get => GetProperty<TerraformProperty<bool>>("developer_only_attribute");
        set => WithProperty("developer_only_attribute", value);
    }

    /// <summary>
    /// The mutable attribute.
    /// </summary>
    public TerraformProperty<bool>? Mutable
    {
        get => GetProperty<TerraformProperty<bool>>("mutable");
        set => WithProperty("mutable", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformProperty<bool>? Required
    {
        get => GetProperty<TerraformProperty<bool>>("required");
        set => WithProperty("required", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_first_auth_factors");
        set => WithProperty("allowed_first_auth_factors", value);
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
        get => GetProperty<TerraformProperty<string>>("external_id");
        set => WithProperty("external_id", value);
    }

    /// <summary>
    /// The sns_caller_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsCallerArn is required")]
    public required TerraformProperty<string> SnsCallerArn
    {
        get => GetProperty<TerraformProperty<string>>("sns_caller_arn");
        set => WithProperty("sns_caller_arn", value);
    }

    /// <summary>
    /// The sns_region attribute.
    /// </summary>
    public TerraformProperty<string>? SnsRegion
    {
        get => GetProperty<TerraformProperty<string>>("sns_region");
        set => WithProperty("sns_region", value);
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
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("attributes_require_verification_before_update");
        set => WithProperty("attributes_require_verification_before_update", value);
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
        get => GetProperty<TerraformProperty<string>>("advanced_security_mode");
        set => WithProperty("advanced_security_mode", value);
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
        get => GetProperty<TerraformProperty<bool>>("case_sensitive");
        set => WithProperty("case_sensitive", value);
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
        get => GetProperty<TerraformProperty<string>>("default_email_option");
        set => WithProperty("default_email_option", value);
    }

    /// <summary>
    /// The email_message attribute.
    /// </summary>
    public TerraformProperty<string>? EmailMessage
    {
        get => GetProperty<TerraformProperty<string>>("email_message");
        set => WithProperty("email_message", value);
    }

    /// <summary>
    /// The email_message_by_link attribute.
    /// </summary>
    public TerraformProperty<string>? EmailMessageByLink
    {
        get => GetProperty<TerraformProperty<string>>("email_message_by_link");
        set => WithProperty("email_message_by_link", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSubject
    {
        get => GetProperty<TerraformProperty<string>>("email_subject");
        set => WithProperty("email_subject", value);
    }

    /// <summary>
    /// The email_subject_by_link attribute.
    /// </summary>
    public TerraformProperty<string>? EmailSubjectByLink
    {
        get => GetProperty<TerraformProperty<string>>("email_subject_by_link");
        set => WithProperty("email_subject_by_link", value);
    }

    /// <summary>
    /// The sms_message attribute.
    /// </summary>
    public TerraformProperty<string>? SmsMessage
    {
        get => GetProperty<TerraformProperty<string>>("sms_message");
        set => WithProperty("sms_message", value);
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
        get => GetProperty<TerraformProperty<string>>("relying_party_id");
        set => WithProperty("relying_party_id", value);
    }

    /// <summary>
    /// The user_verification attribute.
    /// </summary>
    public TerraformProperty<string>? UserVerification
    {
        get => GetProperty<TerraformProperty<string>>("user_verification");
        set => WithProperty("user_verification", value);
    }

}

/// <summary>
/// Manages a aws_cognito_user_pool resource.
/// </summary>
public class AwsCognitoUserPool : TerraformResource
{
    public AwsCognitoUserPool(string name) : base("aws_cognito_user_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("creation_date");
        this.DeclareOutput("custom_domain");
        this.DeclareOutput("domain");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("estimated_number_of_users");
        this.DeclareOutput("last_modified_date");
    }

    /// <summary>
    /// The alias_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AliasAttributes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("alias_attributes");
        set => this.WithProperty("alias_attributes", value);
    }

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AutoVerifiedAttributes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("auto_verified_attributes");
        set => this.WithProperty("auto_verified_attributes", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformProperty<string>? DeletionProtection
    {
        get => GetProperty<TerraformProperty<string>>("deletion_protection");
        set => this.WithProperty("deletion_protection", value);
    }

    /// <summary>
    /// The email_verification_message attribute.
    /// </summary>
    public TerraformProperty<string>? EmailVerificationMessage
    {
        get => GetProperty<TerraformProperty<string>>("email_verification_message");
        set => this.WithProperty("email_verification_message", value);
    }

    /// <summary>
    /// The email_verification_subject attribute.
    /// </summary>
    public TerraformProperty<string>? EmailVerificationSubject
    {
        get => GetProperty<TerraformProperty<string>>("email_verification_subject");
        set => this.WithProperty("email_verification_subject", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    public TerraformProperty<string>? MfaConfiguration
    {
        get => GetProperty<TerraformProperty<string>>("mfa_configuration");
        set => this.WithProperty("mfa_configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    public TerraformProperty<string>? SmsAuthenticationMessage
    {
        get => GetProperty<TerraformProperty<string>>("sms_authentication_message");
        set => this.WithProperty("sms_authentication_message", value);
    }

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    public TerraformProperty<string>? SmsVerificationMessage
    {
        get => GetProperty<TerraformProperty<string>>("sms_verification_message");
        set => this.WithProperty("sms_verification_message", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The user_pool_tier attribute.
    /// </summary>
    public TerraformProperty<string>? UserPoolTier
    {
        get => GetProperty<TerraformProperty<string>>("user_pool_tier");
        set => this.WithProperty("user_pool_tier", value);
    }

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? UsernameAttributes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("username_attributes");
        set => this.WithProperty("username_attributes", value);
    }

    /// <summary>
    /// Block for account_recovery_setting.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountRecoverySetting block(s) allowed")]
    public List<AwsCognitoUserPoolAccountRecoverySettingBlock>? AccountRecoverySetting
    {
        get => GetProperty<List<AwsCognitoUserPoolAccountRecoverySettingBlock>>("account_recovery_setting");
        set => this.WithProperty("account_recovery_setting", value);
    }

    /// <summary>
    /// Block for admin_create_user_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminCreateUserConfig block(s) allowed")]
    public List<AwsCognitoUserPoolAdminCreateUserConfigBlock>? AdminCreateUserConfig
    {
        get => GetProperty<List<AwsCognitoUserPoolAdminCreateUserConfigBlock>>("admin_create_user_config");
        set => this.WithProperty("admin_create_user_config", value);
    }

    /// <summary>
    /// Block for device_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolDeviceConfigurationBlock>? DeviceConfiguration
    {
        get => GetProperty<List<AwsCognitoUserPoolDeviceConfigurationBlock>>("device_configuration");
        set => this.WithProperty("device_configuration", value);
    }

    /// <summary>
    /// Block for email_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolEmailConfigurationBlock>? EmailConfiguration
    {
        get => GetProperty<List<AwsCognitoUserPoolEmailConfigurationBlock>>("email_configuration");
        set => this.WithProperty("email_configuration", value);
    }

    /// <summary>
    /// Block for email_mfa_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailMfaConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolEmailMfaConfigurationBlock>? EmailMfaConfiguration
    {
        get => GetProperty<List<AwsCognitoUserPoolEmailMfaConfigurationBlock>>("email_mfa_configuration");
        set => this.WithProperty("email_mfa_configuration", value);
    }

    /// <summary>
    /// Block for lambda_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    public List<AwsCognitoUserPoolLambdaConfigBlock>? LambdaConfig
    {
        get => GetProperty<List<AwsCognitoUserPoolLambdaConfigBlock>>("lambda_config");
        set => this.WithProperty("lambda_config", value);
    }

    /// <summary>
    /// Block for password_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    public List<AwsCognitoUserPoolPasswordPolicyBlock>? PasswordPolicy
    {
        get => GetProperty<List<AwsCognitoUserPoolPasswordPolicyBlock>>("password_policy");
        set => this.WithProperty("password_policy", value);
    }

    /// <summary>
    /// Block for schema.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Schema block(s) allowed")]
    public HashSet<AwsCognitoUserPoolSchemaBlock>? Schema
    {
        get => GetProperty<HashSet<AwsCognitoUserPoolSchemaBlock>>("schema");
        set => this.WithProperty("schema", value);
    }

    /// <summary>
    /// Block for sign_in_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignInPolicy block(s) allowed")]
    public List<AwsCognitoUserPoolSignInPolicyBlock>? SignInPolicy
    {
        get => GetProperty<List<AwsCognitoUserPoolSignInPolicyBlock>>("sign_in_policy");
        set => this.WithProperty("sign_in_policy", value);
    }

    /// <summary>
    /// Block for sms_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolSmsConfigurationBlock>? SmsConfiguration
    {
        get => GetProperty<List<AwsCognitoUserPoolSmsConfigurationBlock>>("sms_configuration");
        set => this.WithProperty("sms_configuration", value);
    }

    /// <summary>
    /// Block for software_token_mfa_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareTokenMfaConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock>? SoftwareTokenMfaConfiguration
    {
        get => GetProperty<List<AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock>>("software_token_mfa_configuration");
        set => this.WithProperty("software_token_mfa_configuration", value);
    }

    /// <summary>
    /// Block for user_attribute_update_settings.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserAttributeUpdateSettings block(s) allowed")]
    public List<AwsCognitoUserPoolUserAttributeUpdateSettingsBlock>? UserAttributeUpdateSettings
    {
        get => GetProperty<List<AwsCognitoUserPoolUserAttributeUpdateSettingsBlock>>("user_attribute_update_settings");
        set => this.WithProperty("user_attribute_update_settings", value);
    }

    /// <summary>
    /// Block for user_pool_add_ons.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolAddOns block(s) allowed")]
    public List<AwsCognitoUserPoolUserPoolAddOnsBlock>? UserPoolAddOns
    {
        get => GetProperty<List<AwsCognitoUserPoolUserPoolAddOnsBlock>>("user_pool_add_ons");
        set => this.WithProperty("user_pool_add_ons", value);
    }

    /// <summary>
    /// Block for username_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UsernameConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolUsernameConfigurationBlock>? UsernameConfiguration
    {
        get => GetProperty<List<AwsCognitoUserPoolUsernameConfigurationBlock>>("username_configuration");
        set => this.WithProperty("username_configuration", value);
    }

    /// <summary>
    /// Block for verification_message_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerificationMessageTemplate block(s) allowed")]
    public List<AwsCognitoUserPoolVerificationMessageTemplateBlock>? VerificationMessageTemplate
    {
        get => GetProperty<List<AwsCognitoUserPoolVerificationMessageTemplateBlock>>("verification_message_template");
        set => this.WithProperty("verification_message_template", value);
    }

    /// <summary>
    /// Block for web_authn_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAuthnConfiguration block(s) allowed")]
    public List<AwsCognitoUserPoolWebAuthnConfigurationBlock>? WebAuthnConfiguration
    {
        get => GetProperty<List<AwsCognitoUserPoolWebAuthnConfigurationBlock>>("web_authn_configuration");
        set => this.WithProperty("web_authn_configuration", value);
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
