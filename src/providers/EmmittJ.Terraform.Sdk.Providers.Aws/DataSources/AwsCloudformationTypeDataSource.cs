using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudformation_type Terraform data source.
/// Retrieves information about a aws_cloudformation_type.
/// </summary>
public partial class AwsCloudformationTypeDataSource(string name) : TerraformDataSource("aws_cloudformation_type", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
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
    public TerraformValue<string>? TypeName
    {
        get => GetArgument<TerraformValue<string>>("type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string>? VersionId
    {
        get => GetArgument<TerraformValue<string>>("version_id");
        set => SetArgument("version_id", value);
    }

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
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionRoleArn
        => AsReference("execution_role_arn");

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    public TerraformValue<bool> IsDefaultVersion
        => AsReference("is_default_version");

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LoggingConfig
        => AsReference("logging_config");

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
    /// The visibility attribute.
    /// </summary>
    public TerraformValue<string> Visibility
        => AsReference("visibility");

}
