using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auth in .
/// Nesting mode: set
/// </summary>
public class AwsDbProxyAuthBlock : TerraformBlock
{
    /// <summary>
    /// The auth_scheme attribute.
    /// </summary>
    public TerraformProperty<string>? AuthScheme
    {
        set => SetProperty("auth_scheme", value);
    }

    /// <summary>
    /// The client_password_auth_type attribute.
    /// </summary>
    public TerraformProperty<string>? ClientPasswordAuthType
    {
        set => SetProperty("client_password_auth_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The iam_auth attribute.
    /// </summary>
    public TerraformProperty<string>? IamAuth
    {
        set => SetProperty("iam_auth", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretArn
    {
        set => SetProperty("secret_arn", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbProxyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_db_proxy resource.
/// </summary>
public class AwsDbProxy : TerraformResource
{
    public AwsDbProxy(string name) : base("aws_db_proxy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("endpoint");
        SetOutput("debug_logging");
        SetOutput("default_auth_scheme");
        SetOutput("engine_family");
        SetOutput("id");
        SetOutput("idle_client_timeout");
        SetOutput("name");
        SetOutput("region");
        SetOutput("require_tls");
        SetOutput("role_arn");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_security_group_ids");
        SetOutput("vpc_subnet_ids");
    }

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    public TerraformProperty<bool> DebugLogging
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("debug_logging");
        set => SetProperty("debug_logging", value);
    }

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    public TerraformProperty<string> DefaultAuthScheme
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_auth_scheme");
        set => SetProperty("default_auth_scheme", value);
    }

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineFamily is required")]
    public required TerraformProperty<string> EngineFamily
    {
        get => GetRequiredOutput<TerraformProperty<string>>("engine_family");
        set => SetProperty("engine_family", value);
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
    /// The idle_client_timeout attribute.
    /// </summary>
    public TerraformProperty<double> IdleClientTimeout
    {
        get => GetRequiredOutput<TerraformProperty<double>>("idle_client_timeout");
        set => SetProperty("idle_client_timeout", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The require_tls attribute.
    /// </summary>
    public TerraformProperty<bool> RequireTls
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("require_tls");
        set => SetProperty("require_tls", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("role_arn");
        set => SetProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> VpcSecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => SetProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    public HashSet<TerraformProperty<string>> VpcSubnetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("vpc_subnet_ids");
        set => SetProperty("vpc_subnet_ids", value);
    }

    /// <summary>
    /// Block for auth.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDbProxyAuthBlock>? Auth
    {
        set => SetProperty("auth", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbProxyTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

}
