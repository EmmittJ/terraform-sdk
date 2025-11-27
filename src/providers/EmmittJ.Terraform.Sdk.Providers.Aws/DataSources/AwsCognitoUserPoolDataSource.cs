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
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformValue<string> UserPoolId
    {
        get => new TerraformReference<string>(this, "user_pool_id");
        set => SetArgument("user_pool_id", value);
    }

    /// <summary>
    /// The account_recovery_setting attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AccountRecoverySetting
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "account_recovery_setting").ResolveNodes(ctx));
    }

    /// <summary>
    /// The admin_create_user_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdminCreateUserConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "admin_create_user_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    public TerraformList<string> AutoVerifiedAttributes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "auto_verified_attributes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformValue<string> CreationDate
    {
        get => new TerraformReference<string>(this, "creation_date");
    }

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformValue<string> CustomDomain
    {
        get => new TerraformReference<string>(this, "custom_domain");
    }

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformValue<string> DeletionProtection
    {
        get => new TerraformReference<string>(this, "deletion_protection");
    }

    /// <summary>
    /// The device_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DeviceConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "device_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformValue<string> Domain
    {
        get => new TerraformReference<string>(this, "domain");
    }

    /// <summary>
    /// The email_configuration attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EmailConfiguration
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "email_configuration").ResolveNodes(ctx));
    }

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    public TerraformValue<double> EstimatedNumberOfUsers
    {
        get => new TerraformReference<double>(this, "estimated_number_of_users");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The lambda_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LambdaConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "lambda_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformValue<string> LastModifiedDate
    {
        get => new TerraformReference<string>(this, "last_modified_date");
    }

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    public TerraformValue<string> MfaConfiguration
    {
        get => new TerraformReference<string>(this, "mfa_configuration");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The schema_attributes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SchemaAttributes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "schema_attributes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    public TerraformValue<string> SmsAuthenticationMessage
    {
        get => new TerraformReference<string>(this, "sms_authentication_message");
    }

    /// <summary>
    /// The sms_configuration_failure attribute.
    /// </summary>
    public TerraformValue<string> SmsConfigurationFailure
    {
        get => new TerraformReference<string>(this, "sms_configuration_failure");
    }

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    public TerraformValue<string> SmsVerificationMessage
    {
        get => new TerraformReference<string>(this, "sms_verification_message");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_pool_add_ons attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> UserPoolAddOns
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "user_pool_add_ons").ResolveNodes(ctx));
    }

    /// <summary>
    /// The user_pool_tags attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformMap<string> UserPoolTags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "user_pool_tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    public TerraformList<string> UsernameAttributes
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "username_attributes").ResolveNodes(ctx));
    }

}
