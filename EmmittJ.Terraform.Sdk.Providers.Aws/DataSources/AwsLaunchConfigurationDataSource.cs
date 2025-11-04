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
        this.DeclareOutput("arn");
        this.DeclareOutput("associate_public_ip_address");
        this.DeclareOutput("ebs_block_device");
        this.DeclareOutput("ebs_optimized");
        this.DeclareOutput("enable_monitoring");
        this.DeclareOutput("ephemeral_block_device");
        this.DeclareOutput("iam_instance_profile");
        this.DeclareOutput("image_id");
        this.DeclareOutput("instance_type");
        this.DeclareOutput("key_name");
        this.DeclareOutput("metadata_options");
        this.DeclareOutput("placement_tenancy");
        this.DeclareOutput("root_block_device");
        this.DeclareOutput("security_groups");
        this.DeclareOutput("spot_price");
        this.DeclareOutput("user_data");
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
