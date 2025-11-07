using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_spot_instance_request resource.
/// </summary>
public class AwsSpotInstanceRequest : TerraformResource
{
    public AwsSpotInstanceRequest(string name) : base("aws_spot_instance_request", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("instance_state");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("password_data");
        this.DeclareOutput("primary_network_interface");
        this.DeclareOutput("primary_network_interface_id");
        this.DeclareOutput("private_dns");
        this.DeclareOutput("public_dns");
        this.DeclareOutput("public_ip");
        this.DeclareOutput("spot_bid_status");
        this.DeclareOutput("spot_instance_id");
        this.DeclareOutput("spot_request_state");
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ami
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ami");
        set => this.WithProperty("ami", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? AssociatePublicIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("associate_public_ip_address");
        set => this.WithProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableApiStop
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_api_stop");
        set => this.WithProperty("disable_api_stop", value);
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? DisableApiTermination
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disable_api_termination");
        set => this.WithProperty("disable_api_termination", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EbsOptimized
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnablePrimaryIpv6
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_primary_ipv6");
        set => this.WithProperty("enable_primary_ipv6", value);
    }

    /// <summary>
    /// The force_destroy attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ForceDestroy
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("force_destroy");
        set => this.WithProperty("force_destroy", value);
    }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? GetPasswordData
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("get_password_data");
        set => this.WithProperty("get_password_data", value);
    }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Hibernation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("hibernation");
        set => this.WithProperty("hibernation", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_id");
        set => this.WithProperty("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HostResourceGroupArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("host_resource_group_arn");
        set => this.WithProperty("host_resource_group_arn", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamInstanceProfile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_instance_profile");
        set => this.WithProperty("iam_instance_profile", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceInitiatedShutdownBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_initiated_shutdown_behavior");
        set => this.WithProperty("instance_initiated_shutdown_behavior", value);
    }

    /// <summary>
    /// The instance_interruption_behavior attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceInterruptionBehavior
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_interruption_behavior");
        set => this.WithProperty("instance_interruption_behavior", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? Ipv6AddressCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("ipv6_address_count");
        set => this.WithProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Ipv6Addresses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ipv6_addresses");
        set => this.WithProperty("ipv6_addresses", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? KeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("key_name");
        set => this.WithProperty("key_name", value);
    }

    /// <summary>
    /// The launch_group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LaunchGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("launch_group");
        set => this.WithProperty("launch_group", value);
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? Monitoring
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("monitoring");
        set => this.WithProperty("monitoring", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlacementGroup
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_group");
        set => this.WithProperty("placement_group", value);
    }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("placement_group_id");
        set => this.WithProperty("placement_group_id", value);
    }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? PlacementPartitionNumber
    {
        get => GetProperty<TerraformLiteralProperty<double>>("placement_partition_number");
        set => this.WithProperty("placement_partition_number", value);
    }

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrivateIp
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip");
        set => this.WithProperty("private_ip", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecondaryPrivateIps
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("secondary_private_ips");
        set => this.WithProperty("secondary_private_ips", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SourceDestCheck
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("source_dest_check");
        set => this.WithProperty("source_dest_check", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpotPrice
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spot_price");
        set => this.WithProperty("spot_price", value);
    }

    /// <summary>
    /// The spot_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpotType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spot_type");
        set => this.WithProperty("spot_type", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Tenancy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("tenancy");
        set => this.WithProperty("tenancy", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserData
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserDataBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_data_base64");
        set => this.WithProperty("user_data_base64", value);
    }

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? UserDataReplaceOnChange
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("user_data_replace_on_change");
        set => this.WithProperty("user_data_replace_on_change", value);
    }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ValidFrom
    {
        get => GetProperty<TerraformLiteralProperty<string>>("valid_from");
        set => this.WithProperty("valid_from", value);
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ValidUntil
    {
        get => GetProperty<TerraformLiteralProperty<string>>("valid_until");
        set => this.WithProperty("valid_until", value);
    }

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? VolumeTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("volume_tags");
        set => this.WithProperty("volume_tags", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
    }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? WaitForFulfillment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_fulfillment");
        set => this.WithProperty("wait_for_fulfillment", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

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
    /// The primary_network_interface attribute.
    /// </summary>
    public TerraformExpression PrimaryNetworkInterface => this["primary_network_interface"];

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
    /// The spot_bid_status attribute.
    /// </summary>
    public TerraformExpression SpotBidStatus => this["spot_bid_status"];

    /// <summary>
    /// The spot_instance_id attribute.
    /// </summary>
    public TerraformExpression SpotInstanceId => this["spot_instance_id"];

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    public TerraformExpression SpotRequestState => this["spot_request_state"];

}
