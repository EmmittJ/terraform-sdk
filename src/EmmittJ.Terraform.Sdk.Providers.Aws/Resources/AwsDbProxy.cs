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
        get => GetProperty<TerraformProperty<string>>("auth_scheme");
        set => WithProperty("auth_scheme", value);
    }

    /// <summary>
    /// The client_password_auth_type attribute.
    /// </summary>
    public TerraformProperty<string>? ClientPasswordAuthType
    {
        get => GetProperty<TerraformProperty<string>>("client_password_auth_type");
        set => WithProperty("client_password_auth_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The iam_auth attribute.
    /// </summary>
    public TerraformProperty<string>? IamAuth
    {
        get => GetProperty<TerraformProperty<string>>("iam_auth");
        set => WithProperty("iam_auth", value);
    }

    /// <summary>
    /// The secret_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SecretArn
    {
        get => GetProperty<TerraformProperty<string>>("secret_arn");
        set => WithProperty("secret_arn", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("endpoint");
    }

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    public TerraformProperty<bool>? DebugLogging
    {
        get => GetProperty<TerraformProperty<bool>>("debug_logging");
        set => this.WithProperty("debug_logging", value);
    }

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultAuthScheme
    {
        get => GetProperty<TerraformProperty<string>>("default_auth_scheme");
        set => this.WithProperty("default_auth_scheme", value);
    }

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EngineFamily is required")]
    public required TerraformProperty<string> EngineFamily
    {
        get => GetRequiredProperty<TerraformProperty<string>>("engine_family");
        set => this.WithProperty("engine_family", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The idle_client_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? IdleClientTimeout
    {
        get => GetProperty<TerraformProperty<double>>("idle_client_timeout");
        set => this.WithProperty("idle_client_timeout", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The require_tls attribute.
    /// </summary>
    public TerraformProperty<bool>? RequireTls
    {
        get => GetProperty<TerraformProperty<bool>>("require_tls");
        set => this.WithProperty("require_tls", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformProperty<string> RoleArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcSubnetIds is required")]
    public HashSet<TerraformProperty<string>>? VpcSubnetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("vpc_subnet_ids");
        set => this.WithProperty("vpc_subnet_ids", value);
    }

    /// <summary>
    /// Block for auth.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsDbProxyAuthBlock>? Auth
    {
        get => GetProperty<HashSet<AwsDbProxyAuthBlock>>("auth");
        set => this.WithProperty("auth", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbProxyTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDbProxyTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
