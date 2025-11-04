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
    /// The state attribute.
    /// </summary>
    public string? State
    {
        get => GetProperty<TerraformLiteralProperty<string>>("state")?.Value;
        set => this.WithProperty("state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
