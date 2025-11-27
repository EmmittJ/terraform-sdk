using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_transit_gateway_policy_table_association Terraform resource.
/// Manages a aws_ec2_transit_gateway_policy_table_association resource.
/// </summary>
public partial class AwsEc2TransitGatewayPolicyTableAssociation(string name) : TerraformResource("aws_ec2_transit_gateway_policy_table_association", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
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
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayAttachmentId is required")]
    public required TerraformValue<string> TransitGatewayAttachmentId
    {
        get => new TerraformReference<string>(this, "transit_gateway_attachment_id");
        set => SetArgument("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_policy_table_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransitGatewayPolicyTableId is required")]
    public required TerraformValue<string> TransitGatewayPolicyTableId
    {
        get => new TerraformReference<string>(this, "transit_gateway_policy_table_id");
        set => SetArgument("transit_gateway_policy_table_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformValue<string> ResourceTypeAttribute
    {
        get => new TerraformReference<string>(this, "resource_type");
    }

}
