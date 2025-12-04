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
        get => GetArgument<TerraformValue<double>>("automatic_stop_time_minutes");
        set => SetArgument("automatic_stop_time_minutes", value);
    }

    /// <summary>
    /// The connection_type attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionType
    {
        get => GetArgument<TerraformValue<string>>("connection_type");
        set => SetArgument("connection_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageId is required")]
    public required TerraformValue<string> ImageId
    {
        get => GetArgument<TerraformValue<string>>("image_id");
        set => SetArgument("image_id", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => GetArgument<TerraformValue<string>>("instance_type");
        set => SetArgument("instance_type", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The owner_arn attribute.
    /// </summary>
    public TerraformValue<string>? OwnerArn
    {
        get => GetArgument<TerraformValue<string>>("owner_arn");
        set => SetArgument("owner_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? SubnetId
    {
        get => GetArgument<TerraformValue<string>>("subnet_id");
        set => SetArgument("subnet_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformValue<string> Type
        => AsReference("type");

}
