using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth in AwsDbProxy.
/// Nesting mode: set
/// </summary>
public class AwsDbProxyAuthBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth";

    /// <summary>
    /// The auth_scheme attribute.
    /// </summary>
    public TerraformValue<string>? AuthScheme
    {
        get => new TerraformReference<string>(this, "auth_scheme");
        set => SetArgument("auth_scheme", value);
    }

    /// <summary>
    /// The client_password_auth_type attribute.
    /// </summary>
    public TerraformValue<string> ClientPasswordAuthType
    {
        get => new TerraformReference<string>(this, "client_password_auth_type");
        set => SetArgument("client_password_auth_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The iam_auth attribute.
    /// </summary>
    public TerraformValue<string>? IamAuth
    {
        get => new TerraformReference<string>(this, "iam_auth");
        set => SetArgument("iam_auth", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformValue<string>? SecretArn
    {
        get => new TerraformReference<string>(this, "secret_arn");
        set => SetArgument("secret_arn", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformValue<string>? Username
    {
        get => new TerraformReference<string>(this, "username");
        set => SetArgument("username", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDbProxy.
/// Nesting mode: single
/// </summary>
public class AwsDbProxyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_db_proxy Terraform resource.
/// Manages a aws_db_proxy resource.
/// </summary>
public partial class AwsDbProxy(string name) : TerraformResource("aws_db_proxy", name)
{
    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    public TerraformValue<bool>? DebugLogging
    {
        get => new TerraformReference<bool>(this, "debug_logging");
        set => SetArgument("debug_logging", value);
    }

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    public TerraformValue<string> DefaultAuthScheme
    {
        get => new TerraformReference<string>(this, "default_auth_scheme");
        set => SetArgument("default_auth_scheme", value);
    }

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineFamily is required")]
    public required TerraformValue<string> EngineFamily
    {
        get => new TerraformReference<string>(this, "engine_family");
        set => SetArgument("engine_family", value);
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
    /// The idle_client_timeout attribute.
    /// </summary>
    public TerraformValue<double> IdleClientTimeout
    {
        get => new TerraformReference<double>(this, "idle_client_timeout");
        set => SetArgument("idle_client_timeout", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
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
    /// The require_tls attribute.
    /// </summary>
    public TerraformValue<bool>? RequireTls
    {
        get => new TerraformReference<bool>(this, "require_tls");
        set => SetArgument("require_tls", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformSet<string> VpcSecurityGroupIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_security_group_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    public required TerraformSet<string> VpcSubnetIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "vpc_subnet_ids").ResolveNodes(ctx));
        set => SetArgument("vpc_subnet_ids", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// Auth block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsDbProxyAuthBlock>? Auth
    {
        get => GetArgument<TerraformSet<AwsDbProxyAuthBlock>>("auth");
        set => SetArgument("auth", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDbProxyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDbProxyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
