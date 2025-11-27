using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_launch_configuration Terraform data source.
/// Retrieves information about a aws_launch_configuration.
/// </summary>
public partial class AwsLaunchConfigurationDataSource(string name) : TerraformDataSource("aws_launch_configuration", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The associate_public_ip_address attribute.
    /// </summary>
    public TerraformValue<bool> AssociatePublicIpAddress
    {
        get => new TerraformReference<bool>(this, "associate_public_ip_address");
    }

    /// <summary>
    /// The ebs_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EbsBlockDevice
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "ebs_block_device").ResolveNodes(ctx));
    }

    /// <summary>
    /// The ebs_optimized attribute.
    /// </summary>
    public TerraformValue<bool> EbsOptimized
    {
        get => new TerraformReference<bool>(this, "ebs_optimized");
    }

    /// <summary>
    /// The enable_monitoring attribute.
    /// </summary>
    public TerraformValue<bool> EnableMonitoring
    {
        get => new TerraformReference<bool>(this, "enable_monitoring");
    }

    /// <summary>
    /// The ephemeral_block_device attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> EphemeralBlockDevice
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "ephemeral_block_device").ResolveNodes(ctx));
    }

    /// <summary>
    /// The iam_instance_profile attribute.
    /// </summary>
    public TerraformValue<string> IamInstanceProfile
    {
        get => new TerraformReference<string>(this, "iam_instance_profile");
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    public TerraformValue<string> ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
    }

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformValue<string> KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
    }

    /// <summary>
    /// The metadata_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> MetadataOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "metadata_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The placement_tenancy attribute.
    /// </summary>
    public TerraformValue<string> PlacementTenancy
    {
        get => new TerraformReference<string>(this, "placement_tenancy");
    }

    /// <summary>
    /// The root_block_device attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> RootBlockDevice
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "root_block_device").ResolveNodes(ctx));
    }

    /// <summary>
    /// The security_groups attribute.
    /// </summary>
    public TerraformSet<string> SecurityGroups
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "security_groups").ResolveNodes(ctx));
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformValue<string> SpotPrice
    {
        get => new TerraformReference<string>(this, "spot_price");
    }

    /// <summary>
    /// The user_data attribute.
    /// </summary>
    public TerraformValue<string> UserData
    {
        get => new TerraformReference<string>(this, "user_data");
    }

}
