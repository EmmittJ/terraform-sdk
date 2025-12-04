using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for logging_config in AwsCloudformationType.
/// Nesting mode: list
/// </summary>
public class AwsCloudformationTypeLoggingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logging_config";

    /// <summary>
    /// The log_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogGroupName is required")]
    public required TerraformValue<string> LogGroupName
    {
        get => GetArgument<TerraformValue<string>>("log_group_name");
        set => SetArgument("log_group_name", value);
    }

    /// <summary>
    /// The log_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogRoleArn is required")]
    public required TerraformValue<string> LogRoleArn
    {
        get => GetArgument<TerraformValue<string>>("log_role_arn");
        set => SetArgument("log_role_arn", value);
    }

}


/// <summary>
/// Represents a aws_cloudformation_type Terraform resource.
/// Manages a aws_cloudformation_type resource.
/// </summary>
public partial class AwsCloudformationType(string name) : TerraformResource("aws_cloudformation_type", name)
{
    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ExecutionRoleArn
    {
        get => GetArgument<TerraformValue<string>>("execution_role_arn");
        set => SetArgument("execution_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The schema_handler_package attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaHandlerPackage is required")]
    public required TerraformValue<string> SchemaHandlerPackage
    {
        get => GetArgument<TerraformValue<string>>("schema_handler_package");
        set => SetArgument("schema_handler_package", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    public required TerraformValue<string> TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultVersionId
        => AsReference("default_version_id");

    /// <summary>
    /// The deprecated_status attribute.
    /// </summary>
    public TerraformValue<string> DeprecatedStatus
        => AsReference("deprecated_status");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    public TerraformValue<string> DocumentationUrl
        => AsReference("documentation_url");

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    public TerraformValue<bool> IsDefaultVersion
        => AsReference("is_default_version");

    /// <summary>
    /// The provisioning_type attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningType
        => AsReference("provisioning_type");

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformValue<string> Schema
        => AsReference("schema");

    /// <summary>
    /// The source_url attribute.
    /// </summary>
    public TerraformValue<string> SourceUrl
        => AsReference("source_url");

    /// <summary>
    /// The type_arn attribute.
    /// </summary>
    public TerraformValue<string> TypeArn
        => AsReference("type_arn");

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string> VersionId
        => AsReference("version_id");

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformValue<string> Visibility
        => AsReference("visibility");

    /// <summary>
    /// LoggingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LoggingConfig block(s) allowed")]
    public TerraformList<AwsCloudformationTypeLoggingConfigBlock>? LoggingConfig
    {
        get => GetArgument<TerraformList<AwsCloudformationTypeLoggingConfigBlock>>("logging_config");
        set => SetArgument("logging_config", value);
    }

}
