using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_nat_gateway.
/// </summary>
public class AwsNatGatewayDataSource : TerraformDataSource
{
    public AwsNatGatewayDataSource(string name) : base("aws_nat_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("allocation_id");
        this.DeclareOutput("association_id");
        this.DeclareOutput("connectivity_type");
        this.DeclareOutput("network_interface_id");
        this.DeclareOutput("private_ip");
        this.DeclareOutput("public_ip");
        this.DeclareOutput("secondary_allocation_ids");
        this.DeclareOutput("secondary_private_ip_address_count");
        this.DeclareOutput("secondary_private_ip_addresses");
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
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformExpression AllocationId => this["allocation_id"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    public TerraformExpression ConnectivityType => this["connectivity_type"];

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceId => this["network_interface_id"];

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformExpression PrivateIp => this["private_ip"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    public TerraformExpression SecondaryAllocationIds => this["secondary_allocation_ids"];

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    public TerraformExpression SecondaryPrivateIpAddressCount => this["secondary_private_ip_address_count"];

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    public TerraformExpression SecondaryPrivateIpAddresses => this["secondary_private_ip_addresses"];

}
