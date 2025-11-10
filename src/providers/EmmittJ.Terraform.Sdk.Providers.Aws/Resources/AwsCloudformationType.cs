using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in .
/// Nesting mode: list
/// </summary>
public class AwsCloudformationTypeLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformProperty<string> LogGroupName
    {
        set => SetProperty("log_group_name", value);
    }

    /// <summary>
    /// The log_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogRoleArn is required")]
    public required TerraformProperty<string> LogRoleArn
    {
        set => SetProperty("log_role_arn", value);
    }

}

/// <summary>
/// Manages a aws_cloudformation_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCloudformationType : TerraformResource
{
    public AwsCloudformationType(string name) : base("aws_cloudformation_type", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("default_version_id");
        SetOutput("deprecated_status");
        SetOutput("description");
        SetOutput("documentation_url");
        SetOutput("is_default_version");
        SetOutput("provisioning_type");
        SetOutput("schema");
        SetOutput("source_url");
        SetOutput("type_arn");
        SetOutput("version_id");
        SetOutput("visibility");
        SetOutput("execution_role_arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("schema_handler_package");
        SetOutput("type");
        SetOutput("type_name");
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_arn");
        set => SetProperty("execution_role_arn", value);
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
    /// The schema_handler_package attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaHandlerPackage is required")]
    public required TerraformProperty<string> SchemaHandlerPackage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("schema_handler_package");
        set => SetProperty("schema_handler_package", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    public required TerraformProperty<string> TypeName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type_name");
        set => SetProperty("type_name", value);
    }

    /// <summary>
    /// Block for logging_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public List<AwsCloudformationTypeLoggingConfigBlock>? LoggingConfig
    {
        set => SetProperty("logging_config", value);
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
