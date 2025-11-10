using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEipTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a aws_eip resource.
/// </summary>
public class AwsEip : TerraformResource
{
    public AwsEip(string name) : base("aws_eip", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("allocation_id");
        SetOutput("arn");
        SetOutput("association_id");
        SetOutput("carrier_ip");
        SetOutput("customer_owned_ip");
        SetOutput("private_dns");
        SetOutput("private_ip");
        SetOutput("ptr_record");
        SetOutput("public_dns");
        SetOutput("public_ip");
        SetOutput("address");
        SetOutput("associate_with_private_ip");
        SetOutput("customer_owned_ipv4_pool");
        SetOutput("domain");
        SetOutput("id");
        SetOutput("instance");
        SetOutput("ipam_pool_id");
        SetOutput("network_border_group");
        SetOutput("network_interface");
        SetOutput("public_ipv4_pool");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The address attribute.
    /// </summary>
    public TerraformProperty<string> Address
    {
        get => GetRequiredOutput<TerraformProperty<string>>("address");
        set => SetProperty("address", value);
    }

    /// <summary>
    /// The associate_with_private_ip attribute.
    /// </summary>
    public TerraformProperty<string> AssociateWithPrivateIp
    {
        get => GetRequiredOutput<TerraformProperty<string>>("associate_with_private_ip");
        set => SetProperty("associate_with_private_ip", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformProperty<string> CustomerOwnedIpv4Pool
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_owned_ipv4_pool");
        set => SetProperty("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformProperty<string> Domain
    {
        get => GetRequiredOutput<TerraformProperty<string>>("domain");
        set => SetProperty("domain", value);
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
    /// The instance attribute.
    /// </summary>
    public TerraformProperty<string> Instance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance");
        set => SetProperty("instance", value);
    }

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformProperty<string> IpamPoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipam_pool_id");
        set => SetProperty("ipam_pool_id", value);
    }

    /// <summary>
    /// The network_border_group attribute.
    /// </summary>
    public TerraformProperty<string> NetworkBorderGroup
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_border_group");
        set => SetProperty("network_border_group", value);
    }

    /// <summary>
    /// The network_interface attribute.
    /// </summary>
    public TerraformProperty<string> NetworkInterface
    {
        get => GetRequiredOutput<TerraformProperty<string>>("network_interface");
        set => SetProperty("network_interface", value);
    }

    /// <summary>
    /// The public_ipv4_pool attribute.
    /// </summary>
    public TerraformProperty<string> PublicIpv4Pool
    {
        get => GetRequiredOutput<TerraformProperty<string>>("public_ipv4_pool");
        set => SetProperty("public_ipv4_pool", value);
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
    public AwsEipTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The allocation_id attribute.
    /// </summary>
    public TerraformExpression AllocationId => this["allocation_id"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    public TerraformExpression AssociationId => this["association_id"];

    /// <summary>
    /// The carrier_ip attribute.
    /// </summary>
    public TerraformExpression CarrierIp => this["carrier_ip"];

    /// <summary>
    /// The customer_owned_ip attribute.
    /// </summary>
    public TerraformExpression CustomerOwnedIp => this["customer_owned_ip"];

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformExpression PrivateDns => this["private_dns"];

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformExpression PrivateIp => this["private_ip"];

    /// <summary>
    /// The ptr_record attribute.
    /// </summary>
    public TerraformExpression PtrRecord => this["ptr_record"];

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformExpression PublicDns => this["public_dns"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

}
