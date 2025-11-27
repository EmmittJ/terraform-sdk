using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloud9_environment_ec2 Terraform resource.
/// Manages a aws_cloud9_environment_ec2 resource.
/// </summary>
public partial class AwsCloud9EnvironmentEc2(string name) : TerraformResource("aws_cloud9_environment_ec2", name)
{
    /// <summary>
    /// The automatic_stop_time_minutes attribute.
    /// </summary>
    public TerraformValue<double>? AutomaticStopTimeMinutes
    {
        get => new TerraformReference<double>(this, "automatic_stop_time_minutes");
        set => SetArgument("automatic_stop_time_minutes", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionType
    {
        get => new TerraformReference<string>(this, "connection_type");
        set => SetArgument("connection_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    public required TerraformValue<string> ImageId
    {
        get => new TerraformReference<string>(this, "image_id");
        set => SetArgument("image_id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
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
    /// The owner_arn attribute.
    /// </summary>
    public TerraformValue<string> OwnerArn
    {
        get => new TerraformReference<string>(this, "owner_arn");
        set => SetArgument("owner_arn", value);
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
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => new TerraformReference<string>(this, "subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
    }

}
