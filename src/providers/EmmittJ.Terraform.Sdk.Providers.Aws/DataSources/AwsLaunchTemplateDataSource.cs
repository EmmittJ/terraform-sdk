using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsLaunchTemplateDataSourceFilterBlock : TerraformBlock
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
public class AwsLaunchTemplateDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a aws_launch_template.
/// </summary>
public class AwsLaunchTemplateDataSource : TerraformDataSource
{
    public AwsLaunchTemplateDataSource(string name) : base("aws_launch_template", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("block_device_mappings");
        SetOutput("capacity_reservation_specification");
        SetOutput("cpu_options");
        SetOutput("credit_specification");
        SetOutput("default_version");
        SetOutput("description");
        SetOutput("disable_api_stop");
        SetOutput("disable_api_termination");
        SetOutput("ebs_optimized");
        SetOutput("enclave_options");
        SetOutput("hibernation_options");
        SetOutput("iam_instance_profile");
        SetOutput("image_id");
        SetOutput("instance_initiated_shutdown_behavior");
        SetOutput("instance_market_options");
        SetOutput("instance_requirements");
        SetOutput("instance_type");
        SetOutput("kernel_id");
        SetOutput("key_name");
        SetOutput("latest_version");
        SetOutput("license_specification");
        SetOutput("maintenance_options");
        SetOutput("metadata_options");
        SetOutput("monitoring");
        SetOutput("network_interfaces");
        SetOutput("placement");
        SetOutput("private_dns_name_options");
        SetOutput("ram_disk_id");
        SetOutput("security_group_names");
        SetOutput("tag_specifications");
        SetOutput("user_data");
        SetOutput("vpc_security_group_ids");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("tags");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    public HashSet<AwsLaunchTemplateDataSourceFilterBlock>? Filter
    {
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsLaunchTemplateDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The block_device_mappings attribute.
    /// </summary>
    public TerraformExpression BlockDeviceMappings => this["block_device_mappings"];

    /// <summary>
    /// The capacity_reservation_specification attribute.
    /// </summary>
    public TerraformExpression CapacityReservationSpecification => this["capacity_reservation_specification"];

    /// <summary>
    /// The cpu_options attribute.
    /// </summary>
    public TerraformExpression CpuOptions => this["cpu_options"];

    /// <summary>
    /// The credit_specification attribute.
    /// </summary>
    public TerraformExpression CreditSpecification => this["credit_specification"];

    /// <summary>
    /// The default_version attribute.
    /// </summary>
    public TerraformExpression DefaultVersion => this["default_version"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The disable_api_stop attribute.
    /// </summary>
    public TerraformExpression DisableApiStop => this["disable_api_stop"];

    /// <summary>
    /// The disable_api_termination attribute.
    /// </summary>
    public TerraformExpression DisableApiTermination => this["disable_api_termination"];

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformExpression EbsOptimized => this["ebs_optimized"];

    /// <summary>
    /// The enclave_options attribute.
    /// </summary>
    public TerraformExpression EnclaveOptions => this["enclave_options"];

    /// <summary>
    /// The hibernation_options attribute.
    /// </summary>
    public TerraformExpression HibernationOptions => this["hibernation_options"];

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformExpression IamInstanceProfile => this["iam_instance_profile"];

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformExpression ImageId => this["image_id"];

    /// <summary>
    /// The instance_initiated_shutdown_behavior attribute.
    /// </summary>
    public TerraformExpression InstanceInitiatedShutdownBehavior => this["instance_initiated_shutdown_behavior"];

    /// <summary>
    /// The instance_market_options attribute.
    /// </summary>
    public TerraformExpression InstanceMarketOptions => this["instance_market_options"];

    /// <summary>
    /// The instance_requirements attribute.
    /// </summary>
    public TerraformExpression InstanceRequirements => this["instance_requirements"];

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The kernel_id attribute.
    /// </summary>
    public TerraformExpression KernelId => this["kernel_id"];

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformExpression KeyName => this["key_name"];

    /// <summary>
    /// The latest_version attribute.
    /// </summary>
    public TerraformExpression LatestVersion => this["latest_version"];

    /// <summary>
    /// The license_specification attribute.
    /// </summary>
    public TerraformExpression LicenseSpecification => this["license_specification"];

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
    /// The network_interfaces attribute.
    /// </summary>
    public TerraformExpression NetworkInterfaces => this["network_interfaces"];

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformExpression Placement => this["placement"];

    /// <summary>
    /// The private_dns_name_options attribute.
    /// </summary>
    public TerraformExpression PrivateDnsNameOptions => this["private_dns_name_options"];

    /// <summary>
    /// The ram_disk_id attribute.
    /// </summary>
    public TerraformExpression RamDiskId => this["ram_disk_id"];

    /// <summary>
    /// The security_group_names attribute.
    /// </summary>
    public TerraformExpression SecurityGroupNames => this["security_group_names"];

    /// <summary>
    /// The tag_specifications attribute.
    /// </summary>
    public TerraformExpression TagSpecifications => this["tag_specifications"];

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformExpression UserData => this["user_data"];

    /// <summary>
    /// The vpc_security_group_ids attribute.
    /// </summary>
    public TerraformExpression VpcSecurityGroupIds => this["vpc_security_group_ids"];

}
