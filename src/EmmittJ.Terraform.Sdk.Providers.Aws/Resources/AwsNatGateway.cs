using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNatGatewayTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public HashSet<TerraformProperty<string>>? SecondaryAllocationIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("secondary_allocation_ids");
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
    public HashSet<TerraformProperty<string>>? SecondaryPrivateIpAddresses
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("secondary_private_ip_addresses");
        set => this.WithProperty("secondary_private_ip_addresses", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNatGatewayTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNatGatewayTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
