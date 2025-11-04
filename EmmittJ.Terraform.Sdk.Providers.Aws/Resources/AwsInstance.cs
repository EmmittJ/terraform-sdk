using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_instance resource.
/// </summary>
public class AwsInstance : TerraformResource
{
    public AwsInstance(string name) : base("aws_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("instance_lifecycle");
        this.DeclareOutput("instance_state");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("password_data");
        this.DeclareOutput("primary_network_interface_id");
        this.DeclareOutput("private_dns");
        this.DeclareOutput("public_dns");
        this.DeclareOutput("public_ip");
        this.DeclareOutput("spot_instance_request_id");
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    public string? Ami
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ami")?.Value;
        set => this.WithProperty("ami", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public bool? AssociatePublicIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("associate_public_ip_address")?.Value;
        set => this.WithProperty("associate_public_ip_address", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public string? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone")?.Value;
        set => this.WithProperty("availability_zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public bool? DisableApiStop
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_api_stop")?.Value;
        set => this.WithProperty("disable_api_stop", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public bool? DisableApiTermination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_api_termination")?.Value;
        set => this.WithProperty("disable_api_termination", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public bool? EbsOptimized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ebs_optimized")?.Value;
        set => this.WithProperty("ebs_optimized", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public bool? EnablePrimaryIpv6
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_primary_ipv6")?.Value;
        set => this.WithProperty("enable_primary_ipv6", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public bool? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy")?.Value;
        set => this.WithProperty("force_destroy", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    public bool? GetPasswordData
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("get_password_data")?.Value;
        set => this.WithProperty("get_password_data", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    public bool? Hibernation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hibernation")?.Value;
        set => this.WithProperty("hibernation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public string? HostId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_id")?.Value;
        set => this.WithProperty("host_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public string? HostResourceGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_resource_group_arn")?.Value;
        set => this.WithProperty("host_resource_group_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public string? IamInstanceProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_instance_profile")?.Value;
        set => this.WithProperty("iam_instance_profile", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public string? InstanceInitiatedShutdownBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_initiated_shutdown_behavior")?.Value;
        set => this.WithProperty("instance_initiated_shutdown_behavior", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public string? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type")?.Value;
        set => this.WithProperty("instance_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public double? Ipv6AddressCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_address_count")?.Value;
        set => this.WithProperty("ipv6_address_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public List<string>? Ipv6Addresses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ipv6_addresses")?.Value;
        set => this.WithProperty("ipv6_addresses", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public string? KeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_name")?.Value;
        set => this.WithProperty("key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public bool? Monitoring
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("monitoring")?.Value;
        set => this.WithProperty("monitoring", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public string? PlacementGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_group")?.Value;
        set => this.WithProperty("placement_group", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public string? PlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_group_id")?.Value;
        set => this.WithProperty("placement_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public double? PlacementPartitionNumber
    {
        get => GetProperty<TerraformLiteralProperty<double>>("placement_partition_number")?.Value;
        set => this.WithProperty("placement_partition_number", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public string? PrivateIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip")?.Value;
        set => this.WithProperty("private_ip", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The secondary_private_ips attribute.
    /// </summary>
    public HashSet<string>? SecondaryPrivateIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("secondary_private_ips")?.Value;
        set => this.WithProperty("secondary_private_ips", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public HashSet<string>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups")?.Value;
        set => this.WithProperty("security_groups", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public bool? SourceDestCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("source_dest_check")?.Value;
        set => this.WithProperty("source_dest_check", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public string? Tenancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenancy")?.Value;
        set => this.WithProperty("tenancy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public string? UserData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data")?.Value;
        set => this.WithProperty("user_data", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public string? UserDataBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data_base64")?.Value;
        set => this.WithProperty("user_data_base64", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    public bool? UserDataReplaceOnChange
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("user_data_replace_on_change")?.Value;
        set => this.WithProperty("user_data_replace_on_change", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    public Dictionary<string, string>? VolumeTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("volume_tags")?.Value;
        set => this.WithProperty("volume_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public HashSet<string>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids")?.Value;
        set => this.WithProperty("vpc_security_group_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The instance_lifecycle attribute.
    /// </summary>
    public TerraformExpression InstanceLifecycle => this["instance_lifecycle"];

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    public TerraformExpression InstanceState => this["instance_state"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    public TerraformExpression PasswordData => this["password_data"];

    /// <summary>
    /// The primary_network_interface_id attribute.
    /// </summary>
    public TerraformExpression PrimaryNetworkInterfaceId => this["primary_network_interface_id"];

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformExpression PrivateDns => this["private_dns"];

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformExpression PublicDns => this["public_dns"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

    /// <summary>
    /// The spot_instance_request_id attribute.
    /// </summary>
    public TerraformExpression SpotInstanceRequestId => this["spot_instance_request_id"];

}
