using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_policy_table_association resource.
/// </summary>
public class AwsEc2TransitGatewayPolicyTableAssociation : TerraformResource
{
    public AwsEc2TransitGatewayPolicyTableAssociation(string name) : base("aws_ec2_transit_gateway_policy_table_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("resource_id");
        this.DeclareOutput("resource_type");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_attachment_id");
        set => this.WithProperty("transit_gateway_attachment_id", value);
    }

    /// <summary>
    /// The transit_gateway_policy_table_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayPolicyTableId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_policy_table_id");
        set => this.WithProperty("transit_gateway_policy_table_id", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformExpression ResourceId => this["resource_id"];

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

}
