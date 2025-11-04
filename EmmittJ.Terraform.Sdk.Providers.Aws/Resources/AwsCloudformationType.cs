using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudformation_type resource.
/// </summary>
public class AwsCloudformationType : TerraformResource
{
    public AwsCloudformationType(string name) : base("aws_cloudformation_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_version_id");
        this.DeclareOutput("deprecated_status");
        this.DeclareOutput("description");
        this.DeclareOutput("documentation_url");
        this.DeclareOutput("is_default_version");
        this.DeclareOutput("provisioning_type");
        this.DeclareOutput("schema");
        this.DeclareOutput("source_url");
        this.DeclareOutput("type_arn");
        this.DeclareOutput("version_id");
        this.DeclareOutput("visibility");
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public string? ExecutionRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("execution_role_arn")?.Value;
        set => this.WithProperty("execution_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The schema_handler_package attribute.
    /// </summary>
    public string? SchemaHandlerPackage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("schema_handler_package")?.Value;
        set => this.WithProperty("schema_handler_package", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

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
    /// The is_default_version attribute.
    /// </summary>
    public TerraformExpression IsDefaultVersion => this["is_default_version"];

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
    /// The version_id attribute.
    /// </summary>
    public TerraformExpression VersionId => this["version_id"];

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformExpression Visibility => this["visibility"];

}
