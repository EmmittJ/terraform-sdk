using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsDatasyncAgent.
/// Nesting mode: single
/// </summary>
public class AwsDatasyncAgentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a aws_datasync_agent Terraform resource.
/// Manages a aws_datasync_agent resource.
/// </summary>
public partial class AwsDatasyncAgent(string name) : TerraformResource("aws_datasync_agent", name)
{
    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    public TerraformValue<string> ActivationKey
    {
        get => new TerraformReference<string>(this, "activation_key");
        set => SetArgument("activation_key", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => new TerraformReference<string>(this, "ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_link_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrivateLinkEndpoint
    {
        get => new TerraformReference<string>(this, "private_link_endpoint");
        set => SetArgument("private_link_endpoint", value);
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
    /// The security_group_arns attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_group_arns").ResolveNodes(ctx));
        set => SetArgument("security_group_arns", value);
    }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    public TerraformSet<string>? SubnetArns
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "subnet_arns").ResolveNodes(ctx));
        set => SetArgument("subnet_arns", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointId
    {
        get => new TerraformReference<string>(this, "vpc_endpoint_id");
        set => SetArgument("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatasyncAgentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatasyncAgentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
