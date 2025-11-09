using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("arn");
        this.DeclareOutput("block_device_mappings");
        this.DeclareOutput("capacity_reservation_specification");
        this.DeclareOutput("cpu_options");
        this.DeclareOutput("credit_specification");
        this.DeclareOutput("default_version");
        this.DeclareOutput("description");
        this.DeclareOutput("disable_api_stop");
        this.DeclareOutput("disable_api_termination");
        this.DeclareOutput("ebs_optimized");
        this.DeclareOutput("enclave_options");
        this.DeclareOutput("hibernation_options");
        this.DeclareOutput("iam_instance_profile");
        this.DeclareOutput("image_id");
        this.DeclareOutput("instance_initiated_shutdown_behavior");
        this.DeclareOutput("instance_market_options");
        this.DeclareOutput("instance_requirements");
        this.DeclareOutput("instance_type");
        this.DeclareOutput("kernel_id");
        this.DeclareOutput("key_name");
        this.DeclareOutput("latest_version");
        this.DeclareOutput("license_specification");
        this.DeclareOutput("maintenance_options");
        this.DeclareOutput("metadata_options");
        this.DeclareOutput("monitoring");
        this.DeclareOutput("network_interfaces");
        this.DeclareOutput("placement");
        this.DeclareOutput("private_dns_name_options");
        this.DeclareOutput("ram_disk_id");
        this.DeclareOutput("security_group_names");
        this.DeclareOutput("tag_specifications");
        this.DeclareOutput("user_data");
        this.DeclareOutput("vpc_security_group_ids");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
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
