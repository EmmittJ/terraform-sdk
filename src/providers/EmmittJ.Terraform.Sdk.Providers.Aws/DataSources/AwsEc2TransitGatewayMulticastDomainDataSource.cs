using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in AwsEc2TransitGatewayMulticastDomainDataSource.
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValuesAttribute is required")]
    public required TerraformSet<string> ValuesAttribute
    {
        get => GetArgument<TerraformSet<string>>("values");
        set => SetArgument("values", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsEc2TransitGatewayMulticastDomainDataSource.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ec2_transit_gateway_multicast_domain Terraform data source.
/// Retrieves information about a aws_ec2_transit_gateway_multicast_domain.
/// </summary>
public partial class AwsEc2TransitGatewayMulticastDomainDataSource(string name) : TerraformDataSource("aws_ec2_transit_gateway_multicast_domain", name)
{
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    public TerraformValue<string>? TransitGatewayMulticastDomainId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_multicast_domain_id");
        set => SetArgument("transit_gateway_multicast_domain_id", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The associations attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Associations
        => AsReference("associations");

    /// <summary>
    /// The auto_accept_shared_associations attribute.
    /// </summary>
    public TerraformValue<string> AutoAcceptSharedAssociations
        => AsReference("auto_accept_shared_associations");

    /// <summary>
    /// The igmpv2_support attribute.
    /// </summary>
    public TerraformValue<string> Igmpv2Support
        => AsReference("igmpv2_support");

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Members
        => AsReference("members");

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformValue<string> OwnerId
        => AsReference("owner_id");

    /// <summary>
    /// The sources attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sources
        => AsReference("sources");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// The static_sources_support attribute.
    /// </summary>
    public TerraformValue<string> StaticSourcesSupport
        => AsReference("static_sources_support");

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayAttachmentId
        => AsReference("transit_gateway_attachment_id");

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformValue<string> TransitGatewayId
        => AsReference("transit_gateway_id");

    /// <summary>
    /// Filter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock>? Filter
    {
        get => GetArgument<TerraformSet<AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
