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
        get => new TerraformReference<string>(this, "read");
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
        get => new TerraformReference<string>(this, "arn");
        set => SetArgument("arn", value);
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
    /// The load_balancer_arn attribute.
    /// </summary>
    public TerraformValue<string> LoadBalancerArn
    {
        get => new TerraformReference<string>(this, "load_balancer_arn");
        set => SetArgument("load_balancer_arn", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The alpn_policy attribute.
    /// </summary>
    public TerraformValue<string> AlpnPolicy
    {
        get => new TerraformReference<string>(this, "alpn_policy");
    }

    /// <summary>
    /// The certificate_arn attribute.
    /// </summary>
    public TerraformValue<string> CertificateArn
    {
        get => new TerraformReference<string>(this, "certificate_arn");
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> DefaultAction
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "default_action").ResolveNodes(ctx));
    }

    /// <summary>
    /// The mutual_authentication attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MutualAuthentication
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "mutual_authentication").ResolveNodes(ctx));
    }

    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformValue<string> Protocol
    {
        get => new TerraformReference<string>(this, "protocol");
    }

    /// <summary>
    /// The ssl_policy attribute.
    /// </summary>
    public TerraformValue<string> SslPolicy
    {
        get => new TerraformReference<string>(this, "ssl_policy");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLbListenerDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLbListenerDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
