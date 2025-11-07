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
    public TerraformProperty<string>? Ami
    {
        get => GetProperty<TerraformProperty<string>>("ami");
        set => this.WithProperty("ami", value);
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformProperty<bool>? AssociatePublicIpAddress
    {
        get => GetProperty<TerraformProperty<bool>>("associate_public_ip_address");
        set => this.WithProperty("associate_public_ip_address", value);
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableApiStop
    {
        get => GetProperty<TerraformProperty<bool>>("disable_api_stop");
        set => this.WithProperty("disable_api_stop", value);
    }

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformProperty<bool>? DisableApiTermination
    {
        get => GetProperty<TerraformProperty<bool>>("disable_api_termination");
        set => this.WithProperty("disable_api_termination", value);
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformProperty<bool>? EbsOptimized
    {
        get => GetProperty<TerraformProperty<bool>>("ebs_optimized");
        set => this.WithProperty("ebs_optimized", value);
    }

    /// <summary>
    /// The enable_primary_ipv6 attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePrimaryIpv6
    {
        get => GetProperty<TerraformProperty<bool>>("enable_primary_ipv6");
        set => this.WithProperty("enable_primary_ipv6", value);
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
    /// The get_password_data attribute.
    /// </summary>
    public TerraformProperty<bool>? GetPasswordData
    {
        get => GetProperty<TerraformProperty<bool>>("get_password_data");
        set => this.WithProperty("get_password_data", value);
    }

    /// <summary>
    /// The hibernation attribute.
    /// </summary>
    public TerraformProperty<bool>? Hibernation
    {
        get => GetProperty<TerraformProperty<bool>>("hibernation");
        set => this.WithProperty("hibernation", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostId
    {
        get => GetProperty<TerraformProperty<string>>("host_id");
        set => this.WithProperty("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HostResourceGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("host_resource_group_arn");
        set => this.WithProperty("host_resource_group_arn", value);
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformProperty<string>? IamInstanceProfile
    {
        get => GetProperty<TerraformProperty<string>>("iam_instance_profile");
        set => this.WithProperty("iam_instance_profile", value);
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
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceInitiatedShutdownBehavior
    {
        get => GetProperty<TerraformProperty<string>>("instance_initiated_shutdown_behavior");
        set => this.WithProperty("instance_initiated_shutdown_behavior", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
    }

    /// <summary>
    /// The ipv6_address_count attribute.
    /// </summary>
    public TerraformProperty<double>? Ipv6AddressCount
    {
        get => GetProperty<TerraformProperty<double>>("ipv6_address_count");
        set => this.WithProperty("ipv6_address_count", value);
    }

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Ipv6Addresses
    {
        get => GetProperty<TerraformProperty<List<string>>>("ipv6_addresses");
        set => this.WithProperty("ipv6_addresses", value);
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => this.WithProperty("key_name", value);
    }

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformProperty<bool>? Monitoring
    {
        get => GetProperty<TerraformProperty<bool>>("monitoring");
        set => this.WithProperty("monitoring", value);
    }

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroup
    {
        get => GetProperty<TerraformProperty<string>>("placement_group");
        set => this.WithProperty("placement_group", value);
    }

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? PlacementGroupId
    {
        get => GetProperty<TerraformProperty<string>>("placement_group_id");
        set => this.WithProperty("placement_group_id", value);
    }

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformProperty<double>? PlacementPartitionNumber
    {
        get => GetProperty<TerraformProperty<double>>("placement_partition_number");
        set => this.WithProperty("placement_partition_number", value);
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
    /// The secondary_private_ips attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecondaryPrivateIps
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("secondary_private_ips");
        set => this.WithProperty("secondary_private_ips", value);
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? SecurityGroups
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("security_groups");
        set => this.WithProperty("security_groups", value);
    }

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformProperty<bool>? SourceDestCheck
    {
        get => GetProperty<TerraformProperty<bool>>("source_dest_check");
        set => this.WithProperty("source_dest_check", value);
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
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? Tenancy
    {
        get => GetProperty<TerraformProperty<string>>("tenancy");
        set => this.WithProperty("tenancy", value);
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformProperty<string>? UserData
    {
        get => GetProperty<TerraformProperty<string>>("user_data");
        set => this.WithProperty("user_data", value);
    }

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? UserDataBase64
    {
        get => GetProperty<TerraformProperty<string>>("user_data_base64");
        set => this.WithProperty("user_data_base64", value);
    }

    /// <summary>
    /// The user_data_replace_on_change attribute.
    /// </summary>
    public TerraformProperty<bool>? UserDataReplaceOnChange
    {
        get => GetProperty<TerraformProperty<bool>>("user_data_replace_on_change");
        set => this.WithProperty("user_data_replace_on_change", value);
    }

    /// <summary>
    /// The volume_tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? VolumeTags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("volume_tags");
        set => this.WithProperty("volume_tags", value);
    }

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? VpcSecurityGroupIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("vpc_security_group_ids");
        set => this.WithProperty("vpc_security_group_ids", value);
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
