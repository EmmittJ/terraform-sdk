using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_nat_gateway resource.
/// </summary>
public class AwsNatGateway : TerraformResource
{
    public AwsNatGateway(string name) : base("aws_nat_gateway", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("association_id");
        this.DeclareOutput("network_interface_id");
        this.DeclareOutput("public_ip");
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationId
    {
        get => GetProperty<TerraformProperty<string>>("allocation_id");
        set => this.WithProperty("allocation_id", value);
    }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectivityType
    {
        get => GetProperty<TerraformProperty<string>>("connectivity_type");
        set => this.WithProperty("connectivity_type", value);
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
    /// The private_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateIp
    {
        get => GetProperty<TerraformProperty<string>>("private_ip");
        set => this.WithProperty("private_ip", value);
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
    /// The secondary_allocation_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecondaryAllocationIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("secondary_allocation_ids");
        set => this.WithProperty("secondary_allocation_ids", value);
    }

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    public TerraformProperty<double>? SecondaryPrivateIpAddressCount
    {
        get => GetProperty<TerraformProperty<double>>("secondary_private_ip_address_count");
        set => this.WithProperty("secondary_private_ip_address_count", value);
    }

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecondaryPrivateIpAddresses
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("secondary_private_ip_addresses");
        set => this.WithProperty("secondary_private_ip_addresses", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceId => this["network_interface_id"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

}
