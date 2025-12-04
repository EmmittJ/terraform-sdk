using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_recovery_setting in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolAccountRecoverySettingBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "account_recovery_setting";

    /// <summary>
    /// RecoveryMechanism block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(2, ErrorMessage = "Maximum 2 RecoveryMechanism block(s) allowed")]
    public TerraformSet<AwsCognitoUserPoolAccountRecoverySettingBlockRecoveryMechanismBlock>? RecoveryMechanism
    {
        get => GetArgument<TerraformSet<AwsCognitoUserPoolAccountRecoverySettingBlockRecoveryMechanismBlock>>("recovery_mechanism");
        set => SetArgument("recovery_mechanism", value);
    }

}

/// <summary>
/// Block type for recovery_mechanism in AwsCognitoUserPoolAccountRecoverySettingBlock.
/// Nesting mode: set
/// </summary>
public class AwsCognitoUserPoolAccountRecoverySettingBlockRecoveryMechanismBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "recovery_mechanism";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The priority attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Priority is required")]
    public required TerraformValue<double> Priority
    {
        get => GetArgument<TerraformValue<double>>("priority");
        set => SetArgument("priority", value);
    }

}


/// <summary>
/// Block type for admin_create_user_config in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolAdminCreateUserConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "admin_create_user_config";

    /// <summary>
    /// The allow_admin_create_user_only attribute.
    /// </summary>
    public TerraformValue<bool>? AllowAdminCreateUserOnly
    {
        get => GetArgument<TerraformValue<bool>>("allow_admin_create_user_only");
        set => SetArgument("allow_admin_create_user_only", value);
    }

    /// <summary>
    /// InviteMessageTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InviteMessageTemplate block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolAdminCreateUserConfigBlockInviteMessageTemplateBlock>? InviteMessageTemplate
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolAdminCreateUserConfigBlockInviteMessageTemplateBlock>>("invite_message_template");
        set => SetArgument("invite_message_template", value);
    }

}

/// <summary>
/// Block type for invite_message_template in AwsCognitoUserPoolAdminCreateUserConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolAdminCreateUserConfigBlockInviteMessageTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "invite_message_template";

    /// <summary>
    /// The email_message attribute.
    /// </summary>
    public TerraformValue<string>? EmailMessage
    {
        get => GetArgument<TerraformValue<string>>("email_message");
        set => SetArgument("email_message", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformValue<string>? EmailSubject
    {
        get => GetArgument<TerraformValue<string>>("email_subject");
        set => SetArgument("email_subject", value);
    }

    /// <summary>
    /// The sms_message attribute.
    /// </summary>
    public TerraformValue<string>? SmsMessage
    {
        get => GetArgument<TerraformValue<string>>("sms_message");
        set => SetArgument("sms_message", value);
    }

}


/// <summary>
/// Block type for device_configuration in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolDeviceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "device_configuration";

    /// <summary>
    /// The challenge_required_on_new_device attribute.
    /// </summary>
    public TerraformValue<bool>? ChallengeRequiredOnNewDevice
    {
        get => GetArgument<TerraformValue<bool>>("challenge_required_on_new_device");
        set => SetArgument("challenge_required_on_new_device", value);
    }

    /// <summary>
    /// The device_only_remembered_on_user_prompt attribute.
    /// </summary>
    public TerraformValue<bool>? DeviceOnlyRememberedOnUserPrompt
    {
        get => GetArgument<TerraformValue<bool>>("device_only_remembered_on_user_prompt");
        set => SetArgument("device_only_remembered_on_user_prompt", value);
    }

}


/// <summary>
/// Block type for email_configuration in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolEmailConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "email_configuration";

    /// <summary>
    /// The configuration_set attribute.
    /// </summary>
    public TerraformValue<string>? ConfigurationSet
    {
        get => GetArgument<TerraformValue<string>>("configuration_set");
        set => SetArgument("configuration_set", value);
    }

    /// <summary>
    /// The email_sending_account attribute.
    /// </summary>
    public TerraformValue<string>? EmailSendingAccount
    {
        get => GetArgument<TerraformValue<string>>("email_sending_account");
        set => SetArgument("email_sending_account", value);
    }

    /// <summary>
    /// The from_email_address attribute.
    /// </summary>
    public TerraformValue<string>? FromEmailAddress
    {
        get => GetArgument<TerraformValue<string>>("from_email_address");
        set => SetArgument("from_email_address", value);
    }

    /// <summary>
    /// The reply_to_email_address attribute.
    /// </summary>
    public TerraformValue<string>? ReplyToEmailAddress
    {
        get => GetArgument<TerraformValue<string>>("reply_to_email_address");
        set => SetArgument("reply_to_email_address", value);
    }

    /// <summary>
    /// The source_arn attribute.
    /// </summary>
    public TerraformValue<string>? SourceArn
    {
        get => GetArgument<TerraformValue<string>>("source_arn");
        set => SetArgument("source_arn", value);
    }

}


/// <summary>
/// Block type for email_mfa_configuration in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolEmailMfaConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "email_mfa_configuration";

    /// <summary>
    /// The message attribute.
    /// </summary>
    public TerraformValue<string>? Message
    {
        get => GetArgument<TerraformValue<string>>("message");
        set => SetArgument("message", value);
    }

    /// <summary>
    /// The subject attribute.
    /// </summary>
    public TerraformValue<string>? Subject
    {
        get => GetArgument<TerraformValue<string>>("subject");
        set => SetArgument("subject", value);
    }

}


/// <summary>
/// Block type for lambda_config in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolLambdaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lambda_config";

    /// <summary>
    /// The create_auth_challenge attribute.
    /// </summary>
    public TerraformValue<string>? CreateAuthChallenge
    {
        get => GetArgument<TerraformValue<string>>("create_auth_challenge");
        set => SetArgument("create_auth_challenge", value);
    }

    /// <summary>
    /// The custom_message attribute.
    /// </summary>
    public TerraformValue<string>? CustomMessage
    {
        get => GetArgument<TerraformValue<string>>("custom_message");
        set => SetArgument("custom_message", value);
    }

    /// <summary>
    /// The define_auth_challenge attribute.
    /// </summary>
    public TerraformValue<string>? DefineAuthChallenge
    {
        get => GetArgument<TerraformValue<string>>("define_auth_challenge");
        set => SetArgument("define_auth_challenge", value);
    }

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyId
    {
        get => GetArgument<TerraformValue<string>>("kms_key_id");
        set => SetArgument("kms_key_id", value);
    }

    /// <summary>
    /// The post_authentication attribute.
    /// </summary>
    public TerraformValue<string>? PostAuthentication
    {
        get => GetArgument<TerraformValue<string>>("post_authentication");
        set => SetArgument("post_authentication", value);
    }

    /// <summary>
    /// The post_confirmation attribute.
    /// </summary>
    public TerraformValue<string>? PostConfirmation
    {
        get => GetArgument<TerraformValue<string>>("post_confirmation");
        set => SetArgument("post_confirmation", value);
    }

    /// <summary>
    /// The pre_authentication attribute.
    /// </summary>
    public TerraformValue<string>? PreAuthentication
    {
        get => GetArgument<TerraformValue<string>>("pre_authentication");
        set => SetArgument("pre_authentication", value);
    }

    /// <summary>
    /// The pre_sign_up attribute.
    /// </summary>
    public TerraformValue<string>? PreSignUp
    {
        get => GetArgument<TerraformValue<string>>("pre_sign_up");
        set => SetArgument("pre_sign_up", value);
    }

    /// <summary>
    /// The pre_token_generation attribute.
    /// </summary>
    public TerraformValue<string>? PreTokenGeneration
    {
        get => GetArgument<TerraformValue<string>>("pre_token_generation");
        set => SetArgument("pre_token_generation", value);
    }

    /// <summary>
    /// The user_migration attribute.
    /// </summary>
    public TerraformValue<string>? UserMigration
    {
        get => GetArgument<TerraformValue<string>>("user_migration");
        set => SetArgument("user_migration", value);
    }

    /// <summary>
    /// The verify_auth_challenge_response attribute.
    /// </summary>
    public TerraformValue<string>? VerifyAuthChallengeResponse
    {
        get => GetArgument<TerraformValue<string>>("verify_auth_challenge_response");
        set => SetArgument("verify_auth_challenge_response", value);
    }

    /// <summary>
    /// CustomEmailSender block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomEmailSender block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolLambdaConfigBlockCustomEmailSenderBlock>? CustomEmailSender
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolLambdaConfigBlockCustomEmailSenderBlock>>("custom_email_sender");
        set => SetArgument("custom_email_sender", value);
    }

    /// <summary>
    /// CustomSmsSender block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomSmsSender block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolLambdaConfigBlockCustomSmsSenderBlock>? CustomSmsSender
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolLambdaConfigBlockCustomSmsSenderBlock>>("custom_sms_sender");
        set => SetArgument("custom_sms_sender", value);
    }

    /// <summary>
    /// PreTokenGenerationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreTokenGenerationConfig block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolLambdaConfigBlockPreTokenGenerationConfigBlock>? PreTokenGenerationConfig
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolLambdaConfigBlockPreTokenGenerationConfigBlock>>("pre_token_generation_config");
        set => SetArgument("pre_token_generation_config", value);
    }

}

/// <summary>
/// Block type for custom_email_sender in AwsCognitoUserPoolLambdaConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolLambdaConfigBlockCustomEmailSenderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_email_sender";

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

    /// <summary>
    /// The lambda_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaVersion is required")]
    public required TerraformValue<string> LambdaVersion
    {
        get => GetArgument<TerraformValue<string>>("lambda_version");
        set => SetArgument("lambda_version", value);
    }

}

/// <summary>
/// Block type for custom_sms_sender in AwsCognitoUserPoolLambdaConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolLambdaConfigBlockCustomSmsSenderBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_sms_sender";

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

    /// <summary>
    /// The lambda_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaVersion is required")]
    public required TerraformValue<string> LambdaVersion
    {
        get => GetArgument<TerraformValue<string>>("lambda_version");
        set => SetArgument("lambda_version", value);
    }

}

/// <summary>
/// Block type for pre_token_generation_config in AwsCognitoUserPoolLambdaConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolLambdaConfigBlockPreTokenGenerationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_token_generation_config";

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

    /// <summary>
    /// The lambda_version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaVersion is required")]
    public required TerraformValue<string> LambdaVersion
    {
        get => GetArgument<TerraformValue<string>>("lambda_version");
        set => SetArgument("lambda_version", value);
    }

}


/// <summary>
/// Block type for password_policy in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolPasswordPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "password_policy";

    /// <summary>
    /// The minimum_length attribute.
    /// </summary>
    public TerraformValue<double>? MinimumLength
    {
        get => GetArgument<TerraformValue<double>>("minimum_length");
        set => SetArgument("minimum_length", value);
    }

    /// <summary>
    /// The password_history_size attribute.
    /// </summary>
    public TerraformValue<double>? PasswordHistorySize
    {
        get => GetArgument<TerraformValue<double>>("password_history_size");
        set => SetArgument("password_history_size", value);
    }

    /// <summary>
    /// The require_lowercase attribute.
    /// </summary>
    public TerraformValue<bool>? RequireLowercase
    {
        get => GetArgument<TerraformValue<bool>>("require_lowercase");
        set => SetArgument("require_lowercase", value);
    }

    /// <summary>
    /// The require_numbers attribute.
    /// </summary>
    public TerraformValue<bool>? RequireNumbers
    {
        get => GetArgument<TerraformValue<bool>>("require_numbers");
        set => SetArgument("require_numbers", value);
    }

    /// <summary>
    /// The require_symbols attribute.
    /// </summary>
    public TerraformValue<bool>? RequireSymbols
    {
        get => GetArgument<TerraformValue<bool>>("require_symbols");
        set => SetArgument("require_symbols", value);
    }

    /// <summary>
    /// The require_uppercase attribute.
    /// </summary>
    public TerraformValue<bool>? RequireUppercase
    {
        get => GetArgument<TerraformValue<bool>>("require_uppercase");
        set => SetArgument("require_uppercase", value);
    }

    /// <summary>
    /// The temporary_password_validity_days attribute.
    /// </summary>
    public TerraformValue<double>? TemporaryPasswordValidityDays
    {
        get => GetArgument<TerraformValue<double>>("temporary_password_validity_days");
        set => SetArgument("temporary_password_validity_days", value);
    }

}


/// <summary>
/// Block type for schema in AwsCognitoUserPool.
/// Nesting mode: set
/// </summary>
public class AwsCognitoUserPoolSchemaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema";

    /// <summary>
    /// The attribute_data_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributeDataType is required")]
    public required TerraformValue<string> AttributeDataType
    {
        get => GetArgument<TerraformValue<string>>("attribute_data_type");
        set => SetArgument("attribute_data_type", value);
    }

    /// <summary>
    /// The developer_only_attribute attribute.
    /// </summary>
    public TerraformValue<bool>? DeveloperOnlyAttribute
    {
        get => GetArgument<TerraformValue<bool>>("developer_only_attribute");
        set => SetArgument("developer_only_attribute", value);
    }

    /// <summary>
    /// The mutable attribute.
    /// </summary>
    public TerraformValue<bool>? Mutable
    {
        get => GetArgument<TerraformValue<bool>>("mutable");
        set => SetArgument("mutable", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The required attribute.
    /// </summary>
    public TerraformValue<bool>? Required
    {
        get => GetArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// NumberAttributeConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NumberAttributeConstraints block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolSchemaBlockNumberAttributeConstraintsBlock>? NumberAttributeConstraints
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolSchemaBlockNumberAttributeConstraintsBlock>>("number_attribute_constraints");
        set => SetArgument("number_attribute_constraints", value);
    }

    /// <summary>
    /// StringAttributeConstraints block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StringAttributeConstraints block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolSchemaBlockStringAttributeConstraintsBlock>? StringAttributeConstraints
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolSchemaBlockStringAttributeConstraintsBlock>>("string_attribute_constraints");
        set => SetArgument("string_attribute_constraints", value);
    }

}

/// <summary>
/// Block type for number_attribute_constraints in AwsCognitoUserPoolSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSchemaBlockNumberAttributeConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "number_attribute_constraints";

    /// <summary>
    /// The max_value attribute.
    /// </summary>
    public TerraformValue<string>? MaxValue
    {
        get => GetArgument<TerraformValue<string>>("max_value");
        set => SetArgument("max_value", value);
    }

    /// <summary>
    /// The min_value attribute.
    /// </summary>
    public TerraformValue<string>? MinValue
    {
        get => GetArgument<TerraformValue<string>>("min_value");
        set => SetArgument("min_value", value);
    }

}

/// <summary>
/// Block type for string_attribute_constraints in AwsCognitoUserPoolSchemaBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSchemaBlockStringAttributeConstraintsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "string_attribute_constraints";

    /// <summary>
    /// The max_length attribute.
    /// </summary>
    public TerraformValue<string>? MaxLength
    {
        get => GetArgument<TerraformValue<string>>("max_length");
        set => SetArgument("max_length", value);
    }

    /// <summary>
    /// The min_length attribute.
    /// </summary>
    public TerraformValue<string>? MinLength
    {
        get => GetArgument<TerraformValue<string>>("min_length");
        set => SetArgument("min_length", value);
    }

}


/// <summary>
/// Block type for sign_in_policy in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSignInPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sign_in_policy";

    /// <summary>
    /// The allowed_first_auth_factors attribute.
    /// </summary>
    public TerraformSet<string>? AllowedFirstAuthFactors
    {
        get => GetArgument<TerraformSet<string>>("allowed_first_auth_factors");
        set => SetArgument("allowed_first_auth_factors", value);
    }

}


/// <summary>
/// Block type for sms_configuration in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSmsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sms_configuration";

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    public required TerraformValue<string> ExternalId
    {
        get => GetArgument<TerraformValue<string>>("external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// The sns_caller_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SnsCallerArn is required")]
    public required TerraformValue<string> SnsCallerArn
    {
        get => GetArgument<TerraformValue<string>>("sns_caller_arn");
        set => SetArgument("sns_caller_arn", value);
    }

    /// <summary>
    /// The sns_region attribute.
    /// </summary>
    public TerraformValue<string>? SnsRegion
    {
        get => GetArgument<TerraformValue<string>>("sns_region");
        set => SetArgument("sns_region", value);
    }

}


/// <summary>
/// Block type for software_token_mfa_configuration in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "software_token_mfa_configuration";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

}


/// <summary>
/// Block type for user_attribute_update_settings in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUserAttributeUpdateSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_attribute_update_settings";

    /// <summary>
    /// The attributes_require_verification_before_update attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttributesRequireVerificationBeforeUpdate is required")]
    public required TerraformSet<string> AttributesRequireVerificationBeforeUpdate
    {
        get => GetArgument<TerraformSet<string>>("attributes_require_verification_before_update");
        set => SetArgument("attributes_require_verification_before_update", value);
    }

}


/// <summary>
/// Block type for user_pool_add_ons in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUserPoolAddOnsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_pool_add_ons";

    /// <summary>
    /// The advanced_security_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdvancedSecurityMode is required")]
    public required TerraformValue<string> AdvancedSecurityMode
    {
        get => GetArgument<TerraformValue<string>>("advanced_security_mode");
        set => SetArgument("advanced_security_mode", value);
    }

    /// <summary>
    /// AdvancedSecurityAdditionalFlows block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdvancedSecurityAdditionalFlows block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolUserPoolAddOnsBlockAdvancedSecurityAdditionalFlowsBlock>? AdvancedSecurityAdditionalFlows
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolUserPoolAddOnsBlockAdvancedSecurityAdditionalFlowsBlock>>("advanced_security_additional_flows");
        set => SetArgument("advanced_security_additional_flows", value);
    }

}

/// <summary>
/// Block type for advanced_security_additional_flows in AwsCognitoUserPoolUserPoolAddOnsBlock.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUserPoolAddOnsBlockAdvancedSecurityAdditionalFlowsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "advanced_security_additional_flows";

    /// <summary>
    /// The custom_auth_mode attribute.
    /// </summary>
    public TerraformValue<string>? CustomAuthMode
    {
        get => GetArgument<TerraformValue<string>>("custom_auth_mode");
        set => SetArgument("custom_auth_mode", value);
    }

}


/// <summary>
/// Block type for username_configuration in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolUsernameConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "username_configuration";

    /// <summary>
    /// The case_sensitive attribute.
    /// </summary>
    public TerraformValue<bool>? CaseSensitive
    {
        get => GetArgument<TerraformValue<bool>>("case_sensitive");
        set => SetArgument("case_sensitive", value);
    }

}


/// <summary>
/// Block type for verification_message_template in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolVerificationMessageTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "verification_message_template";

    /// <summary>
    /// The default_email_option attribute.
    /// </summary>
    public TerraformValue<string>? DefaultEmailOption
    {
        get => GetArgument<TerraformValue<string>>("default_email_option");
        set => SetArgument("default_email_option", value);
    }

    /// <summary>
    /// The email_message attribute.
    /// </summary>
    public TerraformValue<string>? EmailMessage
    {
        get => GetArgument<TerraformValue<string>>("email_message");
        set => SetArgument("email_message", value);
    }

    /// <summary>
    /// The email_message_by_link attribute.
    /// </summary>
    public TerraformValue<string>? EmailMessageByLink
    {
        get => GetArgument<TerraformValue<string>>("email_message_by_link");
        set => SetArgument("email_message_by_link", value);
    }

    /// <summary>
    /// The email_subject attribute.
    /// </summary>
    public TerraformValue<string>? EmailSubject
    {
        get => GetArgument<TerraformValue<string>>("email_subject");
        set => SetArgument("email_subject", value);
    }

    /// <summary>
    /// The email_subject_by_link attribute.
    /// </summary>
    public TerraformValue<string>? EmailSubjectByLink
    {
        get => GetArgument<TerraformValue<string>>("email_subject_by_link");
        set => SetArgument("email_subject_by_link", value);
    }

    /// <summary>
    /// The sms_message attribute.
    /// </summary>
    public TerraformValue<string>? SmsMessage
    {
        get => GetArgument<TerraformValue<string>>("sms_message");
        set => SetArgument("sms_message", value);
    }

}


/// <summary>
/// Block type for web_authn_configuration in AwsCognitoUserPool.
/// Nesting mode: list
/// </summary>
public class AwsCognitoUserPoolWebAuthnConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_authn_configuration";

    /// <summary>
    /// The relying_party_id attribute.
    /// </summary>
    public TerraformValue<string>? RelyingPartyId
    {
        get => GetArgument<TerraformValue<string>>("relying_party_id");
        set => SetArgument("relying_party_id", value);
    }

    /// <summary>
    /// The user_verification attribute.
    /// </summary>
    public TerraformValue<string>? UserVerification
    {
        get => GetArgument<TerraformValue<string>>("user_verification");
        set => SetArgument("user_verification", value);
    }

}


/// <summary>
/// Represents a aws_cognito_user_pool Terraform resource.
/// Manages a aws_cognito_user_pool resource.
/// </summary>
public partial class AwsCognitoUserPool(string name) : TerraformResource("aws_cognito_user_pool", name)
{
    /// <summary>
    /// The alias_attributes attribute.
    /// </summary>
    public TerraformSet<string>? AliasAttributes
    {
        get => GetArgument<TerraformSet<string>>("alias_attributes");
        set => SetArgument("alias_attributes", value);
    }

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    public TerraformSet<string>? AutoVerifiedAttributes
    {
        get => GetArgument<TerraformSet<string>>("auto_verified_attributes");
        set => SetArgument("auto_verified_attributes", value);
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<string>? DeletionProtection
    {
        get => GetArgument<TerraformValue<string>>("deletion_protection");
        set => SetArgument("deletion_protection", value);
    }

    /// <summary>
    /// The email_verification_message attribute.
    /// </summary>
    public TerraformValue<string>? EmailVerificationMessage
    {
        get => GetArgument<TerraformValue<string>>("email_verification_message");
        set => SetArgument("email_verification_message", value);
    }

    /// <summary>
    /// The email_verification_subject attribute.
    /// </summary>
    public TerraformValue<string>? EmailVerificationSubject
    {
        get => GetArgument<TerraformValue<string>>("email_verification_subject");
        set => SetArgument("email_verification_subject", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    public TerraformValue<string>? MfaConfiguration
    {
        get => GetArgument<TerraformValue<string>>("mfa_configuration");
        set => SetArgument("mfa_configuration", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    public TerraformValue<string>? SmsAuthenticationMessage
    {
        get => GetArgument<TerraformValue<string>>("sms_authentication_message");
        set => SetArgument("sms_authentication_message", value);
    }

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    public TerraformValue<string>? SmsVerificationMessage
    {
        get => GetArgument<TerraformValue<string>>("sms_verification_message");
        set => SetArgument("sms_verification_message", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The user_pool_tier attribute.
    /// </summary>
    public TerraformValue<string>? UserPoolTier
    {
        get => GetArgument<TerraformValue<string>>("user_pool_tier");
        set => SetArgument("user_pool_tier", value);
    }

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    public TerraformSet<string>? UsernameAttributes
    {
        get => GetArgument<TerraformSet<string>>("username_attributes");
        set => SetArgument("username_attributes", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => AsReference("creation_date");

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformValue<string> CustomDomain
        => AsReference("custom_domain");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
        => AsReference("domain");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    public TerraformValue<double> EstimatedNumberOfUsers
        => AsReference("estimated_number_of_users");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => AsReference("last_modified_date");

    /// <summary>
    /// AccountRecoverySetting block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountRecoverySetting block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolAccountRecoverySettingBlock>? AccountRecoverySetting
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolAccountRecoverySettingBlock>>("account_recovery_setting");
        set => SetArgument("account_recovery_setting", value);
    }

    /// <summary>
    /// AdminCreateUserConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AdminCreateUserConfig block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolAdminCreateUserConfigBlock>? AdminCreateUserConfig
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolAdminCreateUserConfigBlock>>("admin_create_user_config");
        set => SetArgument("admin_create_user_config", value);
    }

    /// <summary>
    /// DeviceConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeviceConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolDeviceConfigurationBlock>? DeviceConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolDeviceConfigurationBlock>>("device_configuration");
        set => SetArgument("device_configuration", value);
    }

    /// <summary>
    /// EmailConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolEmailConfigurationBlock>? EmailConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolEmailConfigurationBlock>>("email_configuration");
        set => SetArgument("email_configuration", value);
    }

    /// <summary>
    /// EmailMfaConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EmailMfaConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolEmailMfaConfigurationBlock>? EmailMfaConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolEmailMfaConfigurationBlock>>("email_mfa_configuration");
        set => SetArgument("email_mfa_configuration", value);
    }

    /// <summary>
    /// LambdaConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LambdaConfig block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolLambdaConfigBlock>? LambdaConfig
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolLambdaConfigBlock>>("lambda_config");
        set => SetArgument("lambda_config", value);
    }

    /// <summary>
    /// PasswordPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PasswordPolicy block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolPasswordPolicyBlock>? PasswordPolicy
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolPasswordPolicyBlock>>("password_policy");
        set => SetArgument("password_policy", value);
    }

    /// <summary>
    /// Schema block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 Schema block(s) allowed")]
    public TerraformSet<AwsCognitoUserPoolSchemaBlock>? Schema
    {
        get => GetArgument<TerraformSet<AwsCognitoUserPoolSchemaBlock>>("schema");
        set => SetArgument("schema", value);
    }

    /// <summary>
    /// SignInPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SignInPolicy block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolSignInPolicyBlock>? SignInPolicy
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolSignInPolicyBlock>>("sign_in_policy");
        set => SetArgument("sign_in_policy", value);
    }

    /// <summary>
    /// SmsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SmsConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolSmsConfigurationBlock>? SmsConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolSmsConfigurationBlock>>("sms_configuration");
        set => SetArgument("sms_configuration", value);
    }

    /// <summary>
    /// SoftwareTokenMfaConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SoftwareTokenMfaConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock>? SoftwareTokenMfaConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolSoftwareTokenMfaConfigurationBlock>>("software_token_mfa_configuration");
        set => SetArgument("software_token_mfa_configuration", value);
    }

    /// <summary>
    /// UserAttributeUpdateSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserAttributeUpdateSettings block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolUserAttributeUpdateSettingsBlock>? UserAttributeUpdateSettings
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolUserAttributeUpdateSettingsBlock>>("user_attribute_update_settings");
        set => SetArgument("user_attribute_update_settings", value);
    }

    /// <summary>
    /// UserPoolAddOns block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserPoolAddOns block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolUserPoolAddOnsBlock>? UserPoolAddOns
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolUserPoolAddOnsBlock>>("user_pool_add_ons");
        set => SetArgument("user_pool_add_ons", value);
    }

    /// <summary>
    /// UsernameConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UsernameConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolUsernameConfigurationBlock>? UsernameConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolUsernameConfigurationBlock>>("username_configuration");
        set => SetArgument("username_configuration", value);
    }

    /// <summary>
    /// VerificationMessageTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VerificationMessageTemplate block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolVerificationMessageTemplateBlock>? VerificationMessageTemplate
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolVerificationMessageTemplateBlock>>("verification_message_template");
        set => SetArgument("verification_message_template", value);
    }

    /// <summary>
    /// WebAuthnConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebAuthnConfiguration block(s) allowed")]
    public TerraformList<AwsCognitoUserPoolWebAuthnConfigurationBlock>? WebAuthnConfiguration
    {
        get => GetArgument<TerraformList<AwsCognitoUserPoolWebAuthnConfigurationBlock>>("web_authn_configuration");
        set => SetArgument("web_authn_configuration", value);
    }

}
