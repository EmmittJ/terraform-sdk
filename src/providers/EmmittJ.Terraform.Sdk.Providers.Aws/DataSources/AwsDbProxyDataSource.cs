using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_db_proxy Terraform data source.
/// Retrieves information about a aws_db_proxy.
/// </summary>
public partial class AwsDbProxyDataSource(string name) : TerraformDataSource("aws_db_proxy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The auth attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Auth
        => AsReference("auth");

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    public TerraformValue<bool> DebugLogging
        => AsReference("debug_logging");

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    public TerraformValue<string> DefaultAuthScheme
        => AsReference("default_auth_scheme");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => AsReference("endpoint");

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    public TerraformValue<string> EngineFamily
        => AsReference("engine_family");

    /// <summary>
    /// The idle_client_timeout attribute.
    /// </summary>
    public TerraformValue<double> IdleClientTimeout
        => AsReference("idle_client_timeout");

    /// <summary>
    /// The require_tls attribute.
    /// </summary>
    public TerraformValue<bool> RequireTls
        => AsReference("require_tls");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => AsReference("role_arn");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => AsReference("vpc_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
        => AsReference("vpc_security_group_ids");

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSubnetIds
        => AsReference("vpc_subnet_ids");

}
