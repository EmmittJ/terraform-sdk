using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayVpcAttachmentDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayVpcAttachmentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
        this.WithOutput("appliance_mode_support");
        this.WithOutput("arn");
        this.WithOutput("dns_support");
        this.WithOutput("ipv6_support");
        this.WithOutput("security_group_referencing_support");
        this.WithOutput("subnet_ids");
        this.WithOutput("transit_gateway_id");
        this.WithOutput("vpc_id");
        this.WithOutput("vpc_owner_id");
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2TransitGatewayVpcAttachmentDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEc2TransitGatewayVpcAttachmentDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2TransitGatewayVpcAttachmentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2TransitGatewayVpcAttachmentDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
