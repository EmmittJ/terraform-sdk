using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsEc2TransitGatewayMulticastDomainAssociation.
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainAssociationTimeoutsBlock : TerraformBlock
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
/// Represents a aws_ec2_transit_gateway_multicast_domain_association Terraform resource.
/// Manages a aws_ec2_transit_gateway_multicast_domain_association resource.
/// </summary>
public partial class AwsEc2TransitGatewayMulticastDomainAssociation(string name) : TerraformResource("aws_ec2_transit_gateway_multicast_domain_association", name)
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
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformValue<string> SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformValue<string> TransitGatewayAttachmentId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayMulticastDomainId is required")]
    public required TerraformValue<string> TransitGatewayMulticastDomainId
    {
        get => GetArgument<TerraformValue<string>>("transit_gateway_multicast_domain_id");
        set => SetArgument("transit_gateway_multicast_domain_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsEc2TransitGatewayMulticastDomainAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsEc2TransitGatewayMulticastDomainAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
