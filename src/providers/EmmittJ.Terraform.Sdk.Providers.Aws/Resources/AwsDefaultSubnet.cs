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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
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
        SetOutput("arn");
        SetOutput("availability_zone_id");
        SetOutput("cidr_block");
        SetOutput("enable_lni_at_device_index");
        SetOutput("existing_default_subnet");
        SetOutput("ipv6_cidr_block_association_id");
        SetOutput("outpost_arn");
        SetOutput("owner_id");
        SetOutput("vpc_id");
        SetOutput("assign_ipv6_address_on_creation");
        SetOutput("availability_zone");
        SetOutput("customer_owned_ipv4_pool");
        SetOutput("enable_dns64");
        SetOutput("enable_resource_name_dns_a_record_on_launch");
        SetOutput("enable_resource_name_dns_aaaa_record_on_launch");
        SetOutput("force_destroy");
        SetOutput("id");
        SetOutput("ipv6_cidr_block");
        SetOutput("ipv6_native");
        SetOutput("map_customer_owned_ip_on_launch");
        SetOutput("map_public_ip_on_launch");
        SetOutput("private_dns_hostname_type_on_launch");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The assign_ipv6_address_on_creation attribute.
    /// </summary>
    public TerraformProperty<bool> AssignIpv6AddressOnCreation
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("assign_ipv6_address_on_creation");
        set => SetProperty("assign_ipv6_address_on_creation", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AvailabilityZone is required")]
    public required TerraformProperty<string> AvailabilityZone
    {
        get => GetRequiredOutput<TerraformProperty<string>>("availability_zone");
        set => SetProperty("availability_zone", value);
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
    /// The enable_dns64 attribute.
    /// </summary>
    public TerraformProperty<bool> EnableDns64
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_dns64");
        set => SetProperty("enable_dns64", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_a_record_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool> EnableResourceNameDnsARecordOnLaunch
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_resource_name_dns_a_record_on_launch");
        set => SetProperty("enable_resource_name_dns_a_record_on_launch", value);
    }

    /// <summary>
    /// The enable_resource_name_dns_aaaa_record_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool> EnableResourceNameDnsAaaaRecordOnLaunch
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_resource_name_dns_aaaa_record_on_launch");
        set => SetProperty("enable_resource_name_dns_aaaa_record_on_launch", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformProperty<bool> ForceDestroy
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("force_destroy");
        set => SetProperty("force_destroy", value);
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
    /// The ipv6_cidr_block attribute.
    /// </summary>
    public TerraformProperty<string> Ipv6CidrBlock
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ipv6_cidr_block");
        set => SetProperty("ipv6_cidr_block", value);
    }

    /// <summary>
    /// The ipv6_native attribute.
    /// </summary>
    public TerraformProperty<bool> Ipv6Native
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("ipv6_native");
        set => SetProperty("ipv6_native", value);
    }

    /// <summary>
    /// The map_customer_owned_ip_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool> MapCustomerOwnedIpOnLaunch
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("map_customer_owned_ip_on_launch");
        set => SetProperty("map_customer_owned_ip_on_launch", value);
    }

    /// <summary>
    /// The map_public_ip_on_launch attribute.
    /// </summary>
    public TerraformProperty<bool> MapPublicIpOnLaunch
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("map_public_ip_on_launch");
        set => SetProperty("map_public_ip_on_launch", value);
    }

    /// <summary>
    /// The private_dns_hostname_type_on_launch attribute.
    /// </summary>
    public TerraformProperty<string> PrivateDnsHostnameTypeOnLaunch
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_dns_hostname_type_on_launch");
        set => SetProperty("private_dns_hostname_type_on_launch", value);
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
    public AwsDefaultSubnetTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
