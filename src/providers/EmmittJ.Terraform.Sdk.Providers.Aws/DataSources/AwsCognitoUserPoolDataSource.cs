using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cognito_user_pool Terraform data source.
/// Retrieves information about a aws_cognito_user_pool.
/// </summary>
public partial class AwsCognitoUserPoolDataSource(string name) : TerraformDataSource("aws_cognito_user_pool", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => GetRequiredArgument<TerraformValue<string>>("user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The account_recovery_setting attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccountRecoverySetting
        => AsReference("account_recovery_setting");

    /// <summary>
    /// The admin_create_user_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdminCreateUserConfig
        => AsReference("admin_create_user_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    public TerraformList<string> AutoVerifiedAttributes
        => AsReference("auto_verified_attributes");

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
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<string> DeletionProtection
        => AsReference("deletion_protection");

    /// <summary>
    /// The device_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeviceConfiguration
        => AsReference("device_configuration");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
        => AsReference("domain");

    /// <summary>
    /// The email_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EmailConfiguration
        => AsReference("email_configuration");

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    public TerraformValue<double> EstimatedNumberOfUsers
        => AsReference("estimated_number_of_users");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The lambda_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LambdaConfig
        => AsReference("lambda_config");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => AsReference("last_modified_date");

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    public TerraformValue<string> MfaConfiguration
        => AsReference("mfa_configuration");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The schema_attributes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SchemaAttributes
        => AsReference("schema_attributes");

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    public TerraformValue<string> SmsAuthenticationMessage
        => AsReference("sms_authentication_message");

    /// <summary>
    /// The sms_configuration_failure attribute.
    /// </summary>
    public TerraformValue<string> SmsConfigurationFailure
        => AsReference("sms_configuration_failure");

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    public TerraformValue<string> SmsVerificationMessage
        => AsReference("sms_verification_message");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The user_pool_add_ons attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserPoolAddOns
        => AsReference("user_pool_add_ons");

    /// <summary>
    /// The user_pool_tags attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformMap<string> UserPoolTags
        => AsReference("user_pool_tags");

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    public TerraformList<string> UsernameAttributes
        => AsReference("username_attributes");

}
