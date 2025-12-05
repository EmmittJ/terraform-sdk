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
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
        => CreateReference("account_recovery_setting");

    /// <summary>
    /// The admin_create_user_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdminCreateUserConfig
        => CreateReference("admin_create_user_config");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    public TerraformList<string> AutoVerifiedAttributes
        => CreateReference("auto_verified_attributes");

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
        => CreateReference("creation_date");

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformValue<string> CustomDomain
        => CreateReference("custom_domain");

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<string> DeletionProtection
        => CreateReference("deletion_protection");

    /// <summary>
    /// The device_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeviceConfiguration
        => CreateReference("device_configuration");

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
        => CreateReference("domain");

    /// <summary>
    /// The email_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EmailConfiguration
        => CreateReference("email_configuration");

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    public TerraformValue<double> EstimatedNumberOfUsers
        => CreateReference("estimated_number_of_users");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => CreateReference("id");

    /// <summary>
    /// The lambda_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LambdaConfig
        => CreateReference("lambda_config");

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
        => CreateReference("last_modified_date");

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    public TerraformValue<string> MfaConfiguration
        => CreateReference("mfa_configuration");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// The schema_attributes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SchemaAttributes
        => CreateReference("schema_attributes");

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    public TerraformValue<string> SmsAuthenticationMessage
        => CreateReference("sms_authentication_message");

    /// <summary>
    /// The sms_configuration_failure attribute.
    /// </summary>
    public TerraformValue<string> SmsConfigurationFailure
        => CreateReference("sms_configuration_failure");

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    public TerraformValue<string> SmsVerificationMessage
        => CreateReference("sms_verification_message");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => CreateReference("tags");

    /// <summary>
    /// The user_pool_add_ons attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserPoolAddOns
        => CreateReference("user_pool_add_ons");

    /// <summary>
    /// The user_pool_tags attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformMap<string> UserPoolTags
        => CreateReference("user_pool_tags");

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    public TerraformList<string> UsernameAttributes
        => CreateReference("username_attributes");

}
