using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public TerraformProperty<string>? EngineFamily
    {
        get => GetProperty<TerraformProperty<string>>("engine_family");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    public TerraformProperty<string>? RoleArn
    {
        get => GetProperty<TerraformProperty<string>>("role_arn");
        set => this.WithProperty("role_arn", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSubnetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_subnet_ids");
        set => this.WithProperty("vpc_subnet_ids", value);
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
