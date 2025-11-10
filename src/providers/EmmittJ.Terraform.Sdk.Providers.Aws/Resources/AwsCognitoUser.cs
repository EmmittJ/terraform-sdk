using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cognito_user resource.
/// </summary>
public class AwsCognitoUser : TerraformResource
{
    public AwsCognitoUser(string name) : base("aws_cognito_user", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_date");
        this.DeclareOutput("last_modified_date");
        this.DeclareOutput("mfa_setting_list");
        this.DeclareOutput("preferred_mfa_setting");
        this.DeclareOutput("status");
        this.DeclareOutput("sub");
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Attributes
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("attributes");
        set => this.WithProperty("attributes", value);
    }

    /// <summary>
    /// The client_metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ClientMetadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("client_metadata");
        set => this.WithProperty("client_metadata", value);
    }

    /// <summary>
    /// The desired_delivery_mediums attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? DesiredDeliveryMediums
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("desired_delivery_mediums");
        set => this.WithProperty("desired_delivery_mediums", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The force_alias_creation attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceAliasCreation
    {
        get => GetProperty<TerraformProperty<bool>>("force_alias_creation");
        set => this.WithProperty("force_alias_creation", value);
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
    /// The message_action attribute.
    /// </summary>
    public TerraformProperty<string>? MessageAction
    {
        get => GetProperty<TerraformProperty<string>>("message_action");
        set => this.WithProperty("message_action", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => this.WithProperty("password", value);
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
    /// The temporary_password attribute.
    /// </summary>
    public TerraformProperty<string>? TemporaryPassword
    {
        get => GetProperty<TerraformProperty<string>>("temporary_password");
        set => this.WithProperty("temporary_password", value);
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
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredProperty<TerraformProperty<string>>("username");
        set => this.WithProperty("username", value);
    }

    /// <summary>
    /// The validation_data attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ValidationData
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("validation_data");
        set => this.WithProperty("validation_data", value);
    }

    /// <summary>
    /// The creation_date attribute.
    /// </summary>
    public TerraformExpression CreationDate => this["creation_date"];

    /// <summary>
    /// The last_modified_date attribute.
    /// </summary>
    public TerraformExpression LastModifiedDate => this["last_modified_date"];

    /// <summary>
    /// The mfa_setting_list attribute.
    /// </summary>
    public TerraformExpression MfaSettingList => this["mfa_setting_list"];

    /// <summary>
    /// The preferred_mfa_setting attribute.
    /// </summary>
    public TerraformExpression PreferredMfaSetting => this["preferred_mfa_setting"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The sub attribute.
    /// </summary>
    public TerraformExpression Sub => this["sub"];

}
