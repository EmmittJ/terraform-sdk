using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_cloudformation_type.
/// </summary>
public class AwsCloudformationTypeDataSource : TerraformDataSource
{
    public AwsCloudformationTypeDataSource(string name) : base("aws_cloudformation_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("default_version_id");
        SetOutput("deprecated_status");
        SetOutput("description");
        SetOutput("documentation_url");
        SetOutput("execution_role_arn");
        SetOutput("is_default_version");
        SetOutput("logging_config");
        SetOutput("provisioning_type");
        SetOutput("schema");
        SetOutput("source_url");
        SetOutput("type_arn");
        SetOutput("visibility");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("type");
        SetOutput("type_name");
        SetOutput("version_id");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformProperty<string> TypeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type_name");
        set => SetProperty("type_name", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string> VersionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version_id");
        set => SetProperty("version_id", value);
    }

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    public TerraformExpression DefaultVersionId => this["default_version_id"];

    /// <summary>
    /// The deprecated_status attribute.
    /// </summary>
    public TerraformExpression DeprecatedStatus => this["deprecated_status"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    public TerraformExpression DocumentationUrl => this["documentation_url"];

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformExpression ExecutionRoleArn => this["execution_role_arn"];

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    public TerraformExpression IsDefaultVersion => this["is_default_version"];

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    public TerraformExpression LoggingConfig => this["logging_config"];

    /// <summary>
    /// The provisioning_type attribute.
    /// </summary>
    public TerraformExpression ProvisioningType => this["provisioning_type"];

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformExpression Schema => this["schema"];

    /// <summary>
    /// The source_url attribute.
    /// </summary>
    public TerraformExpression SourceUrl => this["source_url"];

    /// <summary>
    /// The type_arn attribute.
    /// </summary>
    public TerraformExpression TypeArn => this["type_arn"];

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformExpression Visibility => this["visibility"];

}
