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
    public Dictionary<string, string>? Attributes
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("attributes")?.Value;
        set => this.WithProperty("attributes", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The client_metadata attribute.
    /// </summary>
    public Dictionary<string, string>? ClientMetadata
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("client_metadata")?.Value;
        set => this.WithProperty("client_metadata", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The desired_delivery_mediums attribute.
    /// </summary>
    public HashSet<string>? DesiredDeliveryMediums
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("desired_delivery_mediums")?.Value;
        set => this.WithProperty("desired_delivery_mediums", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The force_alias_creation attribute.
    /// </summary>
    public bool? ForceAliasCreation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_alias_creation")?.Value;
        set => this.WithProperty("force_alias_creation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The message_action attribute.
    /// </summary>
    public string? MessageAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("message_action")?.Value;
        set => this.WithProperty("message_action", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public string? Password
    {
        get => GetProperty<TerraformLiteralProperty<string>>("password")?.Value;
        set => this.WithProperty("password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The temporary_password attribute.
    /// </summary>
    public string? TemporaryPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("temporary_password")?.Value;
        set => this.WithProperty("temporary_password", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_pool_id attribute.
    /// </summary>
    public string? UserPoolId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_pool_id")?.Value;
        set => this.WithProperty("user_pool_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public string? Username
    {
        get => GetProperty<TerraformLiteralProperty<string>>("username")?.Value;
        set => this.WithProperty("username", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The validation_data attribute.
    /// </summary>
    public Dictionary<string, string>? ValidationData
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("validation_data")?.Value;
        set => this.WithProperty("validation_data", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
