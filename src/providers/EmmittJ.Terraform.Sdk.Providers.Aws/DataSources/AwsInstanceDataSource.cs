using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsInstanceDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        set => SetProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsInstanceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_instance.
/// </summary>
public class AwsInstanceDataSource : TerraformDataSource
{
    public AwsInstanceDataSource(string name) : base("aws_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("ami");
        SetOutput("arn");
        SetOutput("associate_public_ip_address");
        SetOutput("availability_zone");
        SetOutput("credit_specification");
        SetOutput("disable_api_stop");
        SetOutput("disable_api_termination");
        SetOutput("ebs_block_device");
        SetOutput("ebs_optimized");
        SetOutput("enclave_options");
        SetOutput("ephemeral_block_device");
        SetOutput("host_id");
        SetOutput("host_resource_group_arn");
        SetOutput("iam_instance_profile");
        SetOutput("instance_state");
        SetOutput("instance_type");
        SetOutput("ipv6_addresses");
        SetOutput("key_name");
        SetOutput("launch_time");
        SetOutput("maintenance_options");
        SetOutput("metadata_options");
        SetOutput("monitoring");
        SetOutput("network_interface_id");
        SetOutput("outpost_arn");
        SetOutput("password_data");
        SetOutput("placement_group");
        SetOutput("placement_group_id");
        SetOutput("placement_partition_number");
        SetOutput("private_dns");
        SetOutput("private_dns_name_options");
        SetOutput("private_ip");
        SetOutput("public_dns");
        SetOutput("public_ip");
        SetOutput("root_block_device");
        SetOutput("secondary_private_ips");
        SetOutput("security_groups");
        SetOutput("source_dest_check");
        SetOutput("subnet_id");
        SetOutput("tenancy");
        SetOutput("user_data");
        SetOutput("user_data_base64");
        SetOutput("vpc_security_group_ids");
        SetOutput("get_password_data");
        SetOutput("get_user_data");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("instance_tags");
        SetOutput("region");
        SetOutput("tags");
    }

    /// <summary>
    /// The get_password_data attribute.
    /// </summary>
    public TerraformProperty<bool> GetPasswordData
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("get_password_data");
        set => SetProperty("get_password_data", value);
    }

    /// <summary>
    /// The get_user_data attribute.
    /// </summary>
    public TerraformProperty<bool> GetUserData
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("get_user_data");
        set => SetProperty("get_user_data", value);
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
    /// The instance_id attribute.
    /// </summary>
    public TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> InstanceTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("instance_tags");
        set => SetProperty("instance_tags", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsInstanceDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsInstanceDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The ami attribute.
    /// </summary>
    public TerraformExpression Ami => this["ami"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformExpression AssociatePublicIpAddress => this["associate_public_ip_address"];

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformExpression AvailabilityZone => this["availability_zone"];

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    public TerraformExpression CreditSpecification => this["credit_specification"];

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformExpression DisableApiStop => this["disable_api_stop"];

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformExpression DisableApiTermination => this["disable_api_termination"];

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    public TerraformExpression EbsBlockDevice => this["ebs_block_device"];

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformExpression EbsOptimized => this["ebs_optimized"];

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    public TerraformExpression EnclaveOptions => this["enclave_options"];

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    public TerraformExpression EphemeralBlockDevice => this["ephemeral_block_device"];

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformExpression HostId => this["host_id"];

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformExpression HostResourceGroupArn => this["host_resource_group_arn"];

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformExpression IamInstanceProfile => this["iam_instance_profile"];

    /// <summary>
    /// The instance_state attribute.
    /// </summary>
    public TerraformExpression InstanceState => this["instance_state"];

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformExpression Ipv6Addresses => this["ipv6_addresses"];

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformExpression KeyName => this["key_name"];

    /// <summary>
    /// The launch_time attribute.
    /// </summary>
    public TerraformExpression LaunchTime => this["launch_time"];

    /// <summary>
    /// The maintenance_options attribute.
    /// </summary>
    public TerraformExpression MaintenanceOptions => this["maintenance_options"];

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformExpression MetadataOptions => this["metadata_options"];

    /// <summary>
    /// The monitoring attribute.
    /// </summary>
    public TerraformExpression Monitoring => this["monitoring"];

    /// <summary>
    /// The network_interface_id attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaceId => this["network_interface_id"];

    /// <summary>
    /// The outpost_arn attribute.
    /// </summary>
    public TerraformExpression OutpostArn => this["outpost_arn"];

    /// <summary>
    /// The password_data attribute.
    /// </summary>
    public TerraformExpression PasswordData => this["password_data"];

    /// <summary>
    /// The placement_group attribute.
    /// </summary>
    public TerraformExpression PlacementGroup => this["placement_group"];

    /// <summary>
    /// The placement_group_id attribute.
    /// </summary>
    public TerraformExpression PlacementGroupId => this["placement_group_id"];

    /// <summary>
    /// The placement_partition_number attribute.
    /// </summary>
    public TerraformExpression PlacementPartitionNumber => this["placement_partition_number"];

    /// <summary>
    /// The private_dns attribute.
    /// </summary>
    public TerraformExpression PrivateDns => this["private_dns"];

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    public TerraformExpression PrivateDnsNameOptions => this["private_dns_name_options"];

    /// <summary>
    /// The private_ip attribute.
    /// </summary>
    public TerraformExpression PrivateIp => this["private_ip"];

    /// <summary>
    /// The public_dns attribute.
    /// </summary>
    public TerraformExpression PublicDns => this["public_dns"];

    /// <summary>
    /// The public_ip attribute.
    /// </summary>
    public TerraformExpression PublicIp => this["public_ip"];

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    public TerraformExpression RootBlockDevice => this["root_block_device"];

    /// <summary>
    /// The secondary_private_ips attribute.
    /// </summary>
    public TerraformExpression SecondaryPrivateIps => this["secondary_private_ips"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The source_dest_check attribute.
    /// </summary>
    public TerraformExpression SourceDestCheck => this["source_dest_check"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformExpression Tenancy => this["tenancy"];

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformExpression UserData => this["user_data"];

    /// <summary>
    /// The user_data_base64 attribute.
    /// </summary>
    public TerraformExpression UserDataBase64 => this["user_data_base64"];

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformExpression VpcSecurityGroupIds => this["vpc_security_group_ids"];

}
