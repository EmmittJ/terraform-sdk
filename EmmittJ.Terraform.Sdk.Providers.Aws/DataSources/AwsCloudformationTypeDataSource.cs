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
        this.DeclareOutput("default_version_id");
        this.DeclareOutput("deprecated_status");
        this.DeclareOutput("description");
        this.DeclareOutput("documentation_url");
        this.DeclareOutput("execution_role_arn");
        this.DeclareOutput("is_default_version");
        this.DeclareOutput("logging_config");
        this.DeclareOutput("provisioning_type");
        this.DeclareOutput("schema");
        this.DeclareOutput("source_url");
        this.DeclareOutput("type_arn");
        this.DeclareOutput("visibility");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public string? TypeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type_name")?.Value;
        set => this.WithProperty("type_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public string? VersionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_id")?.Value;
        set => this.WithProperty("version_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
