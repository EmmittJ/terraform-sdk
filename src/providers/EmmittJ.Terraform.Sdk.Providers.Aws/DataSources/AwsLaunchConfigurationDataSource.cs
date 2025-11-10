using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_launch_configuration.
/// </summary>
public class AwsLaunchConfigurationDataSource : TerraformDataSource
{
    public AwsLaunchConfigurationDataSource(string name) : base("aws_launch_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("arn");
        this.WithOutput("associate_public_ip_address");
        this.WithOutput("ebs_block_device");
        this.WithOutput("ebs_optimized");
        this.WithOutput("enable_monitoring");
        this.WithOutput("ephemeral_block_device");
        this.WithOutput("iam_instance_profile");
        this.WithOutput("image_id");
        this.WithOutput("instance_type");
        this.WithOutput("key_name");
        this.WithOutput("metadata_options");
        this.WithOutput("placement_tenancy");
        this.WithOutput("root_block_device");
        this.WithOutput("security_groups");
        this.WithOutput("spot_price");
        this.WithOutput("user_data");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformExpression AssociatePublicIpAddress => this["associate_public_ip_address"];

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    public TerraformExpression EbsBlockDevice => this["ebs_block_device"];

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformExpression EbsOptimized => this["ebs_optimized"];

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    public TerraformExpression EnableMonitoring => this["enable_monitoring"];

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    public TerraformExpression EphemeralBlockDevice => this["ephemeral_block_device"];

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformExpression IamInstanceProfile => this["iam_instance_profile"];

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformExpression ImageId => this["image_id"];

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformExpression KeyName => this["key_name"];

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformExpression MetadataOptions => this["metadata_options"];

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    public TerraformExpression PlacementTenancy => this["placement_tenancy"];

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    public TerraformExpression RootBlockDevice => this["root_block_device"];

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformExpression SecurityGroups => this["security_groups"];

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformExpression SpotPrice => this["spot_price"];

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformExpression UserData => this["user_data"];

}
