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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("association_id");
        SetOutput("network_interface_id");
        SetOutput("public_ip");
        SetOutput("allocation_id");
        SetOutput("connectivity_type");
        SetOutput("id");
        SetOutput("private_ip");
        SetOutput("region");
        SetOutput("secondary_allocation_ids");
        SetOutput("secondary_private_ip_address_count");
        SetOutput("secondary_private_ip_addresses");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformProperty<string> AllocationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("allocation_id");
        set => SetProperty("allocation_id", value);
    }

    /// <summary>
    /// The connectivity_type attribute.
    /// </summary>
    public TerraformProperty<string> ConnectivityType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connectivity_type");
        set => SetProperty("connectivity_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformProperty<string> PrivateIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_ip");
        set => SetProperty("private_ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The secondary_allocation_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecondaryAllocationIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("secondary_allocation_ids");
        set => SetProperty("secondary_allocation_ids", value);
    }

    /// <summary>
    /// The secondary_private_ip_address_count attribute.
    /// </summary>
    public TerraformProperty<double> SecondaryPrivateIpAddressCount
    {
        get => GetRequiredOutput<TerraformProperty<double>>("secondary_private_ip_address_count");
        set => SetProperty("secondary_private_ip_address_count", value);
    }

    /// <summary>
    /// The secondary_private_ip_addresses attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecondaryPrivateIpAddresses
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("secondary_private_ip_addresses");
        set => SetProperty("secondary_private_ip_addresses", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetId is required")]
    public required TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNatGatewayTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
