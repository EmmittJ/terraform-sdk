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
public class AwsInstanceDataSourceTimeoutsBlock : TerraformBlock
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
        this.WithOutput("ami");
        this.WithOutput("arn");
        this.WithOutput("associate_public_ip_address");
        this.WithOutput("availability_zone");
        this.WithOutput("credit_specification");
        this.WithOutput("disable_api_stop");
        this.WithOutput("disable_api_termination");
        this.WithOutput("ebs_block_device");
        this.WithOutput("ebs_optimized");
        this.WithOutput("enclave_options");
        this.WithOutput("ephemeral_block_device");
        this.WithOutput("host_id");
        this.WithOutput("host_resource_group_arn");
        this.WithOutput("iam_instance_profile");
        this.WithOutput("instance_state");
        this.WithOutput("instance_type");
        this.WithOutput("ipv6_addresses");
        this.WithOutput("key_name");
        this.WithOutput("launch_time");
        this.WithOutput("maintenance_options");
        this.WithOutput("metadata_options");
        this.WithOutput("monitoring");
        this.WithOutput("network_interface_id");
        this.WithOutput("outpost_arn");
        this.WithOutput("password_data");
        this.WithOutput("placement_group");
        this.WithOutput("placement_group_id");
        this.WithOutput("placement_partition_number");
        this.WithOutput("private_dns");
        this.WithOutput("private_dns_name_options");
        this.WithOutput("private_ip");
        this.WithOutput("public_dns");
        this.WithOutput("public_ip");
        this.WithOutput("root_block_device");
        this.WithOutput("secondary_private_ips");
        this.WithOutput("security_groups");
        this.WithOutput("source_dest_check");
        this.WithOutput("subnet_id");
        this.WithOutput("tenancy");
        this.WithOutput("user_data");
        this.WithOutput("user_data_base64");
        this.WithOutput("vpc_security_group_ids");
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
    /// The get_user_data attribute.
    /// </summary>
    public TerraformProperty<bool>? GetUserData
    {
        get => GetProperty<TerraformProperty<bool>>("get_user_data");
        set => this.WithProperty("get_user_data", value);
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
    /// The instance_id attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceId
    {
        get => GetProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
    }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? InstanceTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("instance_tags");
        set => this.WithProperty("instance_tags", value);
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
    public HashSet<AwsInstanceDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsInstanceDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsInstanceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsInstanceDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
