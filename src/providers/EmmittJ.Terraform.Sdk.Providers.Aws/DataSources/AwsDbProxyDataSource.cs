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
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The auth attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Auth
        => CreateReference("auth");

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    public TerraformValue<bool> DebugLogging
        => CreateReference("debug_logging");

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    public TerraformValue<string> DefaultAuthScheme
        => CreateReference("default_auth_scheme");

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
        => CreateReference("endpoint");

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    public TerraformValue<string> EngineFamily
        => CreateReference("engine_family");

    /// <summary>
    /// The idle_client_timeout attribute.
    /// </summary>
    public TerraformValue<double> IdleClientTimeout
        => CreateReference("idle_client_timeout");

    /// <summary>
    /// The require_tls attribute.
    /// </summary>
    public TerraformValue<bool> RequireTls
        => CreateReference("require_tls");

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string> RoleArn
        => CreateReference("role_arn");

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformValue<string> VpcId
        => CreateReference("vpc_id");

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
        => CreateReference("vpc_security_group_ids");

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSubnetIds
        => CreateReference("vpc_subnet_ids");

}
