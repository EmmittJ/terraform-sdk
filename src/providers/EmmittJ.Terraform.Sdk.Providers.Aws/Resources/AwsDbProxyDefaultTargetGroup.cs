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
        set => SetProperty("connection_borrow_timeout", value);
    }

    /// <summary>
    /// The init_query attribute.
    /// </summary>
    public TerraformProperty<string>? InitQuery
    {
        set => SetProperty("init_query", value);
    }

    /// <summary>
    /// The max_connections_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxConnectionsPercent
    {
        set => SetProperty("max_connections_percent", value);
    }

    /// <summary>
    /// The max_idle_connections_percent attribute.
    /// </summary>
    public TerraformProperty<double>? MaxIdleConnectionsPercent
    {
        set => SetProperty("max_idle_connections_percent", value);
    }

    /// <summary>
    /// The session_pinning_filters attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SessionPinningFilters
    {
        set => SetProperty("session_pinning_filters", value);
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
        set => SetProperty("create", value);
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
        SetOutput("arn");
        SetOutput("name");
        SetOutput("db_proxy_name");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    public required TerraformProperty<string> DbProxyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("db_proxy_name");
        set => SetProperty("db_proxy_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for connection_pool_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionPoolConfig block(s) allowed")]
    public List<AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock>? ConnectionPoolConfig
    {
        set => SetProperty("connection_pool_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDbProxyDefaultTargetGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
