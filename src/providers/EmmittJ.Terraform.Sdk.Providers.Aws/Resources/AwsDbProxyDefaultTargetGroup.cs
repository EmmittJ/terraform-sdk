using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for connection_pool_config in AwsDbProxyDefaultTargetGroup.
/// Nesting mode: list
/// </summary>
public class AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connection_pool_config";

    /// <summary>
    /// The connection_borrow_timeout attribute.
    /// </summary>
    public TerraformValue<double>? ConnectionBorrowTimeout
    {
        get => GetArgument<TerraformValue<double>>("connection_borrow_timeout");
        set => SetArgument("connection_borrow_timeout", value);
    }

    /// <summary>
    /// The init_query attribute.
    /// </summary>
    public TerraformValue<string>? InitQuery
    {
        get => GetArgument<TerraformValue<string>>("init_query");
        set => SetArgument("init_query", value);
    }

    /// <summary>
    /// The max_connections_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxConnectionsPercent
    {
        get => GetArgument<TerraformValue<double>>("max_connections_percent");
        set => SetArgument("max_connections_percent", value);
    }

    /// <summary>
    /// The max_idle_connections_percent attribute.
    /// </summary>
    public TerraformValue<double>? MaxIdleConnectionsPercent
    {
        get => GetArgument<TerraformValue<double>>("max_idle_connections_percent");
        set => SetArgument("max_idle_connections_percent", value);
    }

    /// <summary>
    /// The session_pinning_filters attribute.
    /// </summary>
    public TerraformSet<string>? SessionPinningFilters
    {
        get => GetArgument<TerraformSet<string>>("session_pinning_filters");
        set => SetArgument("session_pinning_filters", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsDbProxyDefaultTargetGroup.
/// Nesting mode: single
/// </summary>
public class AwsDbProxyDefaultTargetGroupTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_db_proxy_default_target_group Terraform resource.
/// Manages a aws_db_proxy_default_target_group resource.
/// </summary>
public partial class AwsDbProxyDefaultTargetGroup(string name) : TerraformResource("aws_db_proxy_default_target_group", name)
{
    /// <summary>
    /// The db_proxy_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DbProxyName is required")]
    public required TerraformValue<string> DbProxyName
    {
        get => GetArgument<TerraformValue<string>>("db_proxy_name");
        set => SetArgument("db_proxy_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// ConnectionPoolConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConnectionPoolConfig block(s) allowed")]
    public TerraformList<AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock>? ConnectionPoolConfig
    {
        get => GetArgument<TerraformList<AwsDbProxyDefaultTargetGroupConnectionPoolConfigBlock>>("connection_pool_config");
        set => SetArgument("connection_pool_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDbProxyDefaultTargetGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDbProxyDefaultTargetGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
