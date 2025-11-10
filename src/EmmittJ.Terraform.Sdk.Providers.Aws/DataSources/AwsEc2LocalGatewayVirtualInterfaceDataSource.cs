using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
public class AwsEc2LocalGatewayVirtualInterfaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a aws_ec2_local_gateway_virtual_interface.
/// </summary>
public class AwsEc2LocalGatewayVirtualInterfaceDataSource : TerraformDataSource
{
    public AwsEc2LocalGatewayVirtualInterfaceDataSource(string name) : base("aws_ec2_local_gateway_virtual_interface", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("local_address");
        this.DeclareOutput("local_bgp_asn");
        this.DeclareOutput("local_gateway_id");
        this.DeclareOutput("local_gateway_virtual_interface_ids");
        this.DeclareOutput("peer_address");
        this.DeclareOutput("peer_bgp_asn");
        this.DeclareOutput("vlan");
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
    public HashSet<AwsEc2LocalGatewayVirtualInterfaceDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEc2LocalGatewayVirtualInterfaceDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2LocalGatewayVirtualInterfaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2LocalGatewayVirtualInterfaceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The local_address attribute.
    /// </summary>
    public TerraformExpression LocalAddress => this["local_address"];

    /// <summary>
    /// The local_bgp_asn attribute.
    /// </summary>
    public TerraformExpression LocalBgpAsn => this["local_bgp_asn"];

    /// <summary>
    /// The local_gateway_id attribute.
    /// </summary>
    public TerraformExpression LocalGatewayId => this["local_gateway_id"];

    /// <summary>
    /// The local_gateway_virtual_interface_ids attribute.
    /// </summary>
    public TerraformExpression LocalGatewayVirtualInterfaceIds => this["local_gateway_virtual_interface_ids"];

    /// <summary>
    /// The peer_address attribute.
    /// </summary>
    public TerraformExpression PeerAddress => this["peer_address"];

    /// <summary>
    /// The peer_bgp_asn attribute.
    /// </summary>
    public TerraformExpression PeerBgpAsn => this["peer_bgp_asn"];

    /// <summary>
    /// The vlan attribute.
    /// </summary>
    public TerraformExpression Vlan => this["vlan"];

}
