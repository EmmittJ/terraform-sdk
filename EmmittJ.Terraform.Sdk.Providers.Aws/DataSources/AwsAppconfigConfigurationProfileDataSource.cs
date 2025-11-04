using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_appconfig_configuration_profile.
/// </summary>
public class AwsAppconfigConfigurationProfileDataSource : TerraformDataSource
{
    public AwsAppconfigConfigurationProfileDataSource(string name) : base("aws_appconfig_configuration_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("description");
        this.DeclareOutput("kms_key_identifier");
        this.DeclareOutput("location_uri");
        this.DeclareOutput("name");
        this.DeclareOutput("retrieval_role_arn");
        this.DeclareOutput("type");
        this.DeclareOutput("validator");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    public string? ApplicationId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("application_id")?.Value;
        set => this.WithProperty("application_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The configuration_profile_id attribute.
    /// </summary>
    public string? ConfigurationProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("configuration_profile_id")?.Value;
        set => this.WithProperty("configuration_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    public TerraformExpression KmsKeyIdentifier => this["kms_key_identifier"];

    /// <summary>
    /// The location_uri attribute.
    /// </summary>
    public TerraformExpression LocationUri => this["location_uri"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The retrieval_role_arn attribute.
    /// </summary>
    public TerraformExpression RetrievalRoleArn => this["retrieval_role_arn"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The validator attribute.
    /// </summary>
    public TerraformExpression Validator => this["validator"];

}
