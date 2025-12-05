using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2TransitGatewayMulticastDomain.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainTimeoutsBlock : TerraformBlock
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
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_ec2_transit_gateway_multicast_domain Terraform resource.
/// Manages a aws_ec2_transit_gateway_multicast_domain resource.
/// </summary>
public partial class AwsEc2TransitGatewayMulticastDomain(string name) : TerraformResource("aws_ec2_transit_gateway_multicast_domain", name)
{
    /// <summary>
    /// The auto_accept_shared_associations attribute.
    /// </summary>
    public TerraformValue<string>? AutoAcceptSharedAssociations
    {
        get => GetArgument<TerraformValue<string>>("auto_accept_shared_associations");
        set => SetArgument("auto_accept_shared_associations", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The igmpv2_support attribute.
    /// </summary>
    public TerraformValue<string>? Igmpv2Support
    {
        get => GetArgument<TerraformValue<string>>("igmpv2_support");
        set => SetArgument("igmpv2_support", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The static_sources_support attribute.
    /// </summary>
    public TerraformValue<string>? StaticSourcesSupport
    {
        get => GetArgument<TerraformValue<string>>("static_sources_support");
        set => SetArgument("static_sources_support", value);
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
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayId is required")]
    public required TerraformValue<string> TransitGatewayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("transit_gateway_id");
        set => SetArgument("transit_gateway_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => CreateReference("owner_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayMulticastDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayMulticastDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
