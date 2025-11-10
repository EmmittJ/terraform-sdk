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
        SetOutput("arn");
        SetOutput("description");
        SetOutput("kms_key_identifier");
        SetOutput("location_uri");
        SetOutput("name");
        SetOutput("retrieval_role_arn");
        SetOutput("type");
        SetOutput("validator");
        SetOutput("application_id");
        SetOutput("configuration_profile_id");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The application_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationId is required")]
    public required TerraformProperty<string> ApplicationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("application_id");
        set => SetProperty("application_id", value);
    }

    /// <summary>
    /// The configuration_profile_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationProfileId is required")]
    public required TerraformProperty<string> ConfigurationProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("configuration_profile_id");
        set => SetProperty("configuration_profile_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
