using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsLbListenerDataSource.
/// Nesting mode: single
/// </summary>
public class AwsLbListenerDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a aws_lb_listener Terraform data source.
/// Retrieves information about a aws_lb_listener.
/// </summary>
public partial class AwsLbListenerDataSource(string name) : TerraformDataSource("aws_lb_listener", name)
{
    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => GetArgument<TerraformValue<string>>("arn") ?? AsReference("arn");
        set => SetArgument("arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The load_balancer_arn attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancerArn
    {
        get => GetArgument<TerraformValue<string>>("load_balancer_arn") ?? AsReference("load_balancer_arn");
        set => SetArgument("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port") ?? AsReference("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    public TerraformValue<string> AlpnPolicy
        => AsReference("alpn_policy");

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
        => AsReference("certificate_arn");

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DefaultAction
        => AsReference("default_action");

    /// <summary>
    /// The mutual_authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MutualAuthentication
        => AsReference("mutual_authentication");

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
        => AsReference("protocol");

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformValue<string> SslPolicy
        => AsReference("ssl_policy");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbListenerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbListenerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
