using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("ami");
        this.DeclareOutput("arn");
        this.DeclareOutput("associate_public_ip_address");
        this.DeclareOutput("availability_zone");
        this.DeclareOutput("credit_specification");
        this.DeclareOutput("disable_api_stop");
        this.DeclareOutput("disable_api_termination");
        this.DeclareOutput("ebs_block_device");
        this.DeclareOutput("ebs_optimized");
        this.DeclareOutput("enclave_options");
        this.DeclareOutput("ephemeral_block_device");
        this.DeclareOutput("host_id");
        this.DeclareOutput("host_resource_group_arn");
        this.DeclareOutput("iam_instance_profile");
        this.DeclareOutput("instance_state");
        this.DeclareOutput("instance_type");
        this.DeclareOutput("ipv6_addresses");
        this.DeclareOutput("key_name");
        this.DeclareOutput("launch_time");
        this.DeclareOutput("maintenance_options");
        this.DeclareOutput("metadata_options");
        this.DeclareOutput("monitoring");
        this.DeclareOutput("network_interface_id");
        this.DeclareOutput("outpost_arn");
        this.DeclareOutput("password_data");
        this.DeclareOutput("placement_group");
        this.DeclareOutput("placement_group_id");
        this.DeclareOutput("placement_partition_number");
        this.DeclareOutput("private_dns");
        this.DeclareOutput("private_dns_name_options");
        this.DeclareOutput("private_ip");
        this.DeclareOutput("public_dns");
        this.DeclareOutput("public_ip");
        this.DeclareOutput("root_block_device");
        this.DeclareOutput("secondary_private_ips");
        this.DeclareOutput("security_groups");
        this.DeclareOutput("source_dest_check");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("tenancy");
        this.DeclareOutput("user_data");
        this.DeclareOutput("user_data_base64");
        this.DeclareOutput("vpc_security_group_ids");
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
    /// The get_user_data attribute.
    /// </summary>
    public bool? GetUserData
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("get_user_data")?.Value;
        set => this.WithProperty("get_user_data", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The instance_id attribute.
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    public Dictionary<string, string>? InstanceTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("instance_tags")?.Value;
        set => this.WithProperty("instance_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
