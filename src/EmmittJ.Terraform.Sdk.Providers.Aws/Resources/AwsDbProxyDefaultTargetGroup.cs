using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connection_pool_config in .
/// Nesting mode: list
/// </summary>
public class AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// The connection_borrow_timeout attribute.
    /// </summary>
    public TerraformProperty<double>? ConnectionBorrowTimeout
    {
        get => GetProperty<TerraformProperty<double>>("connection_borrow_timeout");
        set => WithProperty("connection_borrow_timeout", value);
    }

    /// <summary>
    /// The init_query attribute.
    /// </summary>
    public TerraformProperty<string>? InitQuery
    {
        get => GetProperty<TerraformProperty<string>>("init_query");
        set => WithProperty("init_query", value);
    }

    /// <summary>
    /// The max_connections_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConnectionsPercent
    {
        get => GetProperty<TerraformProperty<double>>("max_connections_percent");
        set => WithProperty("max_connections_percent", value);
    }

    /// <summary>
    /// The max_idle_connections_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxIdleConnectionsPercent
    {
        get => GetProperty<TerraformProperty<double>>("max_idle_connections_percent");
        set => WithProperty("max_idle_connections_percent", value);
    }

    /// <summary>
    /// The session_pinning_filters attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SessionPinningFilters
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("session_pinning_filters");
        set => WithProperty("session_pinning_filters", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDbProxyDefaultTargetGroupTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_db_proxy_default_target_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDbProxyDefaultTargetGroup : TerraformResource
{
    public AwsDbProxyDefaultTargetGroup(string name) : base("aws_db_proxy_default_target_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("name");
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    public required TerraformProperty<string> DbProxyName
    {
        get => GetProperty<TerraformProperty<string>>("db_proxy_name");
        set => this.WithProperty("db_proxy_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// Block for connection_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionPoolConfig block(s) allowed")]
    public List<AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock>? ConnectionPoolConfig
    {
        get => GetProperty<List<AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock>>("connection_pool_config");
        set => this.WithProperty("connection_pool_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbProxyDefaultTargetGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDbProxyDefaultTargetGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

}
