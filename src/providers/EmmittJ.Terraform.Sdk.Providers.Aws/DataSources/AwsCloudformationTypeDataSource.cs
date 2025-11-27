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
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    public TerraformValue<string> TypeName
    {
        get => new TerraformReference<string>(this, "type_name");
        set => SetArgument("type_name", value);
    }

    /// <summary>
    /// The version_id attribute.
    /// </summary>
    public TerraformValue<string>? VersionId
    {
        get => new TerraformReference<string>(this, "version_id");
        set => SetArgument("version_id", value);
    }

    /// <summary>
    /// The default_version_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultVersionId
    {
        get => new TerraformReference<string>(this, "default_version_id");
    }

    /// <summary>
    /// The deprecated_status attribute.
    /// </summary>
    public TerraformValue<string> DeprecatedStatus
    {
        get => new TerraformReference<string>(this, "deprecated_status");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The documentation_url attribute.
    /// </summary>
    public TerraformValue<string> DocumentationUrl
    {
        get => new TerraformReference<string>(this, "documentation_url");
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ExecutionRoleArn
    {
        get => new TerraformReference<string>(this, "execution_role_arn");
    }

    /// <summary>
    /// The is_default_version attribute.
    /// </summary>
    public TerraformValue<bool> IsDefaultVersion
    {
        get => new TerraformReference<bool>(this, "is_default_version");
    }

    /// <summary>
    /// The logging_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> LoggingConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "logging_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The provisioning_type attribute.
    /// </summary>
    public TerraformValue<string> ProvisioningType
    {
        get => new TerraformReference<string>(this, "provisioning_type");
    }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    public TerraformValue<string> Schema
    {
        get => new TerraformReference<string>(this, "schema");
    }

    /// <summary>
    /// The source_url attribute.
    /// </summary>
    public TerraformValue<string> SourceUrl
    {
        get => new TerraformReference<string>(this, "source_url");
    }

    /// <summary>
    /// The type_arn attribute.
    /// </summary>
    public TerraformValue<string> TypeArn
    {
        get => new TerraformReference<string>(this, "type_arn");
    }

    /// <summary>
    /// The visibility attribute.
    /// </summary>
    public TerraformValue<string> Visibility
    {
        get => new TerraformReference<string>(this, "visibility");
    }

}
