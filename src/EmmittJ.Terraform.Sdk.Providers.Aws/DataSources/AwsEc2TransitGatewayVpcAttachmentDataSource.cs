using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_vpc_attachment.
/// </summary>
public class AwsEc2TransitGatewayVpcAttachmentDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayVpcAttachmentDataSource(string name) : base("aws_ec2_transit_gateway_vpc_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("appliance_mode_support");
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_support");
        this.DeclareOutput("ipv6_support");
        this.DeclareOutput("security_group_referencing_support");
        this.DeclareOutput("subnet_ids");
        this.DeclareOutput("transit_gateway_id");
        this.DeclareOutput("vpc_id");
        this.DeclareOutput("vpc_owner_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public TerraformExpression ApplianceModeSupport => this["appliance_mode_support"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformExpression DnsSupport => this["dns_support"];

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformExpression Ipv6Support => this["ipv6_support"];

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformExpression SecurityGroupReferencingSupport => this["security_group_referencing_support"];

    /// <summary>
    /// The subnet_ids attribute.
    /// </summary>
    public TerraformExpression SubnetIds => this["subnet_ids"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

    /// <summary>
    /// The vpc_owner_id attribute.
    /// </summary>
    public TerraformExpression VpcOwnerId => this["vpc_owner_id"];

}
