using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<HashSet<string>>? AliasAttributes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("alias_attributes");
        set => this.WithProperty("alias_attributes", value);
    }

    /// <summary>
    /// The auto_verified_attributes attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AutoVerifiedAttributes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("auto_verified_attributes");
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
    public TerraformProperty<string>? Name
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
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
    public TerraformProperty<HashSet<string>>? UsernameAttributes
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("username_attributes");
        set => this.WithProperty("username_attributes", value);
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
