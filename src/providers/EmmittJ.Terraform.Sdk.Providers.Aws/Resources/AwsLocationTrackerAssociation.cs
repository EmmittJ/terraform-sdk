using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in AwsLocationTrackerAssociation.
/// Nesting mode: single
/// </summary>
public class AwsLocationTrackerAssociationTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_location_tracker_association Terraform resource.
/// Manages a aws_location_tracker_association resource.
/// </summary>
public partial class AwsLocationTrackerAssociation(string name) : TerraformResource("aws_location_tracker_association", name)
{
    /// <summary>
    /// The consumer_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerArn is required")]
    public required TerraformValue<string> ConsumerArn
    {
        get => GetArgument<TerraformValue<string>>("consumer_arn");
        set => SetArgument("consumer_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tracker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackerName is required")]
    public required TerraformValue<string> TrackerName
    {
        get => GetArgument<TerraformValue<string>>("tracker_name");
        set => SetArgument("tracker_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsLocationTrackerAssociationTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsLocationTrackerAssociationTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
