using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEipDataSourceFilterBlock : TerraformBlock
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
public class AwsEipDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a aws_eip.
/// </summary>
public class AwsEipDataSource : TerraformDataSource
{
    public AwsEipDataSource(string name) : base("aws_eip", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("association_id");
        this.WithOutput("carrier_ip");
        this.WithOutput("customer_owned_ip");
        this.WithOutput("customer_owned_ipv4_pool");
        this.WithOutput("domain");
        this.WithOutput("instance_id");
        this.WithOutput("ipam_pool_id");
        this.WithOutput("network_interface_id");
        this.WithOutput("network_interface_owner_id");
        this.WithOutput("private_dns");
        this.WithOutput("private_ip");
        this.WithOutput("ptr_record");
        this.WithOutput("public_dns");
        this.WithOutput("public_ipv4_pool");
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
    /// The public_ip attribute.
    /// </summary>
    public TerraformProperty<string>? PublicIp
    {
        get => GetProperty<TerraformProperty<string>>("public_ip");
        set => this.WithProperty("public_ip", value);
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
    public HashSet<AwsEipDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEipDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEipDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEipDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

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
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformExpression CustomerOwnedIpv4Pool => this["customer_owned_ipv4_pool"];

    /// <summary>
    /// The domain attribute.
    /// </summary>
    public TerraformExpression Domain => this["domain"];

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    public TerraformExpression InstanceId => this["instance_id"];

    /// <summary>
    /// The ipam_pool_id attribute.
    /// </summary>
    public TerraformExpression IpamPoolId => this["ipam_pool_id"];

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceId => this["network_interface_id"];

    /// <summary>
    /// The network_interface_owner_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceOwnerId => this["network_interface_owner_id"];

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
    /// The public_ipv4_pool attribute.
    /// </summary>
    public TerraformExpression PublicIpv4Pool => this["public_ipv4_pool"];

}
