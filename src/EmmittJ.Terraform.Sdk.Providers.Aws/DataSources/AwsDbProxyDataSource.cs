using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_db_proxy.
/// </summary>
public class AwsDbProxyDataSource : TerraformDataSource
{
    public AwsDbProxyDataSource(string name) : base("aws_db_proxy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("auth");
        this.DeclareOutput("debug_logging");
        this.DeclareOutput("default_auth_scheme");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("engine_family");
        this.DeclareOutput("idle_client_timeout");
        this.DeclareOutput("require_tls");
        this.DeclareOutput("role_arn");
        this.DeclareOutput("vpc_id");
        this.DeclareOutput("vpc_security_group_ids");
        this.DeclareOutput("vpc_subnet_ids");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auth attribute.
    /// </summary>
    public TerraformExpression Auth => this["auth"];

    /// <summary>
    /// The debug_logging attribute.
    /// </summary>
    public TerraformExpression DebugLogging => this["debug_logging"];

    /// <summary>
    /// The default_auth_scheme attribute.
    /// </summary>
    public TerraformExpression DefaultAuthScheme => this["default_auth_scheme"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The engine_family attribute.
    /// </summary>
    public TerraformExpression EngineFamily => this["engine_family"];

    /// <summary>
    /// The idle_client_timeout attribute.
    /// </summary>
    public TerraformExpression IdleClientTimeout => this["idle_client_timeout"];

    /// <summary>
    /// The require_tls attribute.
    /// </summary>
    public TerraformExpression RequireTls => this["require_tls"];

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformExpression RoleArn => this["role_arn"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformExpression VpcSecurityGroupIds => this["vpc_security_group_ids"];

    /// <summary>
    /// The vpc_subnet_ids attribute.
    /// </summary>
    public TerraformExpression VpcSubnetIds => this["vpc_subnet_ids"];

}
