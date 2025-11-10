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
        SetOutput("creation_date");
        SetOutput("last_modified_date");
        SetOutput("mfa_setting_list");
        SetOutput("preferred_mfa_setting");
        SetOutput("status");
        SetOutput("sub");
        SetOutput("attributes");
        SetOutput("client_metadata");
        SetOutput("desired_delivery_mediums");
        SetOutput("enabled");
        SetOutput("force_alias_creation");
        SetOutput("id");
        SetOutput("message_action");
        SetOutput("password");
        SetOutput("region");
        SetOutput("temporary_password");
        SetOutput("user_pool_id");
        SetOutput("username");
        SetOutput("validation_data");
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Attributes
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("attributes");
        set => SetProperty("attributes", value);
    }

    /// <summary>
    /// The client_metadata attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ClientMetadata
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("client_metadata");
        set => SetProperty("client_metadata", value);
    }

    /// <summary>
    /// The desired_delivery_mediums attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> DesiredDeliveryMediums
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("desired_delivery_mediums");
        set => SetProperty("desired_delivery_mediums", value);
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The force_alias_creation attribute.
    /// </summary>
    public TerraformProperty<bool> ForceAliasCreation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_alias_creation");
        set => SetProperty("force_alias_creation", value);
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
    /// The message_action attribute.
    /// </summary>
    public TerraformProperty<string> MessageAction
    {
        get => GetRequiredOutput<TerraformProperty<string>>("message_action");
        set => SetProperty("message_action", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string> Password
    {
        get => GetRequiredOutput<TerraformProperty<string>>("password");
        set => SetProperty("password", value);
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
    /// The temporary_password attribute.
    /// </summary>
    public TerraformProperty<string> TemporaryPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("temporary_password");
        set => SetProperty("temporary_password", value);
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserPoolId is required")]
    public required TerraformProperty<string> UserPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("user_pool_id");
        set => SetProperty("user_pool_id", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Username is required")]
    public required TerraformProperty<string> Username
    {
        get => GetRequiredOutput<TerraformProperty<string>>("username");
        set => SetProperty("username", value);
    }

    /// <summary>
    /// The validation_data attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ValidationData
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("validation_data");
        set => SetProperty("validation_data", value);
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
