using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cognito_user_pool.
/// </summary>
public class AwsCognitoUserPoolDataSource : TerraformDataSource
{
    public AwsCognitoUserPoolDataSource(string name) : base("aws_cognito_user_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("account_recovery_setting");
        this.WithOutput("admin_create_user_config");
        this.WithOutput("arn");
        this.WithOutput("auto_verified_attributes");
        this.WithOutput("creation_date");
        this.WithOutput("custom_domain");
        this.WithOutput("deletion_protection");
        this.WithOutput("device_configuration");
        this.WithOutput("domain");
        this.WithOutput("email_configuration");
        this.WithOutput("estimated_number_of_users");
        this.WithOutput("id");
        this.WithOutput("lambda_config");
        this.WithOutput("last_modified_date");
        this.WithOutput("mfa_configuration");
        this.WithOutput("name");
        this.WithOutput("schema_attributes");
        this.WithOutput("sms_authentication_message");
        this.WithOutput("sms_configuration_failure");
        this.WithOutput("sms_verification_message");
        this.WithOutput("tags");
        this.WithOutput("user_pool_add_ons");
        this.WithOutput("user_pool_tags");
        this.WithOutput("username_attributes");
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
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("user_pool_id");
        set => this.WithProperty("user_pool_id", value);
    }

    /// <summary>
    /// The account_recovery_setting attribute.
    /// </summary>
    public TerraformExpression AccountRecoverySetting => this["account_recovery_setting"];

    /// <summary>
    /// The admin_create_user_config attribute.
    /// </summary>
    public TerraformExpression AdminCreateUserConfig => this["admin_create_user_config"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    public TerraformExpression AutoVerifiedAttributes => this["auto_verified_attributes"];

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The custom_domain attribute.
    /// </summary>
    public TerraformExpression CustomDomain => this["custom_domain"];

    /// <summary>
    /// The deletion_protection attribute.
    /// </summary>
    public TerraformExpression DeletionProtection => this["deletion_protection"];

    /// <summary>
    /// The device_configuration attribute.
    /// </summary>
    public TerraformExpression DeviceConfiguration => this["device_configuration"];

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The email_configuration attribute.
    /// </summary>
    public TerraformExpression EmailConfiguration => this["email_configuration"];

    /// <summary>
    /// The estimated_number_of_users attribute.
    /// </summary>
    public TerraformExpression EstimatedNumberOfUsers => this["estimated_number_of_users"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The lambda_config attribute.
    /// </summary>
    public TerraformExpression LambdaConfig => this["lambda_config"];

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformExpression LastModifiedDate => this["last_modified_date"];

    /// <summary>
    /// The mfa_configuration attribute.
    /// </summary>
    public TerraformExpression MfaConfiguration => this["mfa_configuration"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The schema_attributes attribute.
    /// </summary>
    public TerraformExpression SchemaAttributes => this["schema_attributes"];

    /// <summary>
    /// The sms_authentication_message attribute.
    /// </summary>
    public TerraformExpression SmsAuthenticationMessage => this["sms_authentication_message"];

    /// <summary>
    /// The sms_configuration_failure attribute.
    /// </summary>
    public TerraformExpression SmsConfigurationFailure => this["sms_configuration_failure"];

    /// <summary>
    /// The sms_verification_message attribute.
    /// </summary>
    public TerraformExpression SmsVerificationMessage => this["sms_verification_message"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The user_pool_add_ons attribute.
    /// </summary>
    public TerraformExpression UserPoolAddOns => this["user_pool_add_ons"];

    /// <summary>
    /// The user_pool_tags attribute.
    /// </summary>
    public TerraformExpression UserPoolTags => this["user_pool_tags"];

    /// <summary>
    /// The username_attributes attribute.
    /// </summary>
    public TerraformExpression UsernameAttributes => this["username_attributes"];

}
