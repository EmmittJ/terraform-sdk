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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
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
        get => new TerraformReference<string>(this, "consumer_arn");
        set => SetArgument("consumer_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tracker_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TrackerName is required")]
    public required TerraformValue<string> TrackerName
    {
        get => new TerraformReference<string>(this, "tracker_name");
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
