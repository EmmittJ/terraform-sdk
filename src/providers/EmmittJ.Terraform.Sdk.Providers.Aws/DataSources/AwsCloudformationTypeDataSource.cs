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
        this.WithOutput("default_version_id");
        this.WithOutput("deprecated_status");
        this.WithOutput("description");
        this.WithOutput("documentation_url");
        this.WithOutput("execution_role_arn");
        this.WithOutput("is_default_version");
        this.WithOutput("logging_config");
        this.WithOutput("provisioning_type");
        this.WithOutput("schema");
        this.WithOutput("source_url");
        this.WithOutput("type_arn");
        this.WithOutput("visibility");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string>? Arn
    {
        get => GetProperty<TerraformProperty<string>>("arn");
        set => this.WithProperty("arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformProperty<string>? TypeName
    {
        get => GetProperty<TerraformProperty<string>>("type_name");
        set => this.WithProperty("type_name", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformProperty<string>? VersionId
    {
        get => GetProperty<TerraformProperty<string>>("version_id");
        set => this.WithProperty("version_id", value);
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
