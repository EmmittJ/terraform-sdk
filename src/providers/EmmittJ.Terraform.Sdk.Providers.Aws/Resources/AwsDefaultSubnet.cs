using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDefaultSubnetTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a aws_default_subnet resource.
/// </summary>
public class AwsDefaultSubnet : TerraformResource
{
    public AwsDefaultSubnet(string name) : base("aws_default_subnet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("availability_zone_id");
        this.WithOutput("cidr_block");
        this.WithOutput("enable_lni_at_device_index");
        this.WithOutput("existing_default_subnet");
        this.WithOutput("ipv6_cidr_block_association_id");
        this.WithOutput("outpost_arn");
        this.WithOutput("owner_id");
        this.WithOutput("vpc_id");
    }

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    public TerraformProperty<bool>? AssignIpv6AddressOnCreation
    {
        get => GetProperty<TerraformProperty<bool>>("assign_ipv6_address_on_creation");
        set => this.WithProperty("assign_ipv6_address_on_creation", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The customer_owned_ipv4_pool attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerOwnedIpv4Pool
    {
        get => GetProperty<TerraformProperty<string>>("customer_owned_ipv4_pool");
        set => this.WithProperty("customer_owned_ipv4_pool", value);
    }

    /// <summary>
    /// The enable_dns64 attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableDns64
    {
        get => GetProperty<TerraformProperty<bool>>("enable_dns64");
        set => this.WithProperty("enable_dns64", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableResourceNameDnsARecordOnLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("enable_resource_name_dns_a_record_on_launch");
        set => this.WithProperty("enable_resource_name_dns_a_record_on_launch", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableResourceNameDnsAaaaRecordOnLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("enable_resource_name_dns_aaaa_record_on_launch");
        set => this.WithProperty("enable_resource_name_dns_aaaa_record_on_launch", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string>? Ipv6CidrBlock
    {
        get => GetProperty<TerraformProperty<string>>("ipv6_cidr_block");
        set => this.WithProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    public TerraformProperty<bool>? Ipv6Native
    {
        get => GetProperty<TerraformProperty<bool>>("ipv6_native");
        set => this.WithProperty("ipv6_native", value);
    }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? MapCustomerOwnedIpOnLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("map_customer_owned_ip_on_launch");
        set => this.WithProperty("map_customer_owned_ip_on_launch", value);
    }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool>? MapPublicIpOnLaunch
    {
        get => GetProperty<TerraformProperty<bool>>("map_public_ip_on_launch");
        set => this.WithProperty("map_public_ip_on_launch", value);
    }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateDnsHostnameTypeOnLaunch
    {
        get => GetProperty<TerraformProperty<string>>("private_dns_hostname_type_on_launch");
        set => this.WithProperty("private_dns_hostname_type_on_launch", value);
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
    public AwsDefaultSubnetTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDefaultSubnetTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The availability_zone_id attribute.
    /// </summary>
    public TerraformExpression AvailabilityZoneId => this["availability_zone_id"];

    /// <summary>
    /// The cidr_block attribute.
    /// </summary>
    public TerraformExpression CidrBlock => this["cidr_block"];

    /// <summary>
    /// The enable_lni_at_device_index attribute.
    /// </summary>
    public TerraformExpression EnableLniAtDeviceIndex => this["enable_lni_at_device_index"];

    /// <summary>
    /// The existing_default_subnet attribute.
    /// </summary>
    public TerraformExpression ExistingDefaultSubnet => this["existing_default_subnet"];

    /// <summary>
    /// The ipv6_cidr_block_association_id attribute.
    /// </summary>
    public TerraformExpression Ipv6CidrBlockAssociationId => this["ipv6_cidr_block_association_id"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformExpression VpcId => this["vpc_id"];

}
