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
        get => GetArgument<TerraformValue<string>>("create");
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
        get => GetArgument<TerraformValue<string>>("activation_key") ?? AsReference("activation_key");
        set => SetArgument("activation_key", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformValue<string> IpAddress
    {
        get => GetArgument<TerraformValue<string>>("ip_address") ?? AsReference("ip_address");
        set => SetArgument("ip_address", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The private_link_endpoint attribute.
    /// </summary>
    public TerraformValue<string> PrivateLinkEndpoint
    {
        get => GetArgument<TerraformValue<string>>("private_link_endpoint") ?? AsReference("private_link_endpoint");
        set => SetArgument("private_link_endpoint", value);
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
    /// The security_group_arns attribute.
    /// </summary>
    public TerraformSet<string>? SecurityGroupArns
    {
        get => GetArgument<TerraformSet<string>>("security_group_arns");
        set => SetArgument("security_group_arns", value);
    }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    public TerraformSet<string>? SubnetArns
    {
        get => GetArgument<TerraformSet<string>>("subnet_arns");
        set => SetArgument("subnet_arns", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformValue<string>? VpcEndpointId
    {
        get => GetArgument<TerraformValue<string>>("vpc_endpoint_id");
        set => SetArgument("vpc_endpoint_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsDatasyncAgentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsDatasyncAgentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
