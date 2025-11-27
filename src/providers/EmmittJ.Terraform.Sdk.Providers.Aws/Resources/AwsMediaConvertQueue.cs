using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for reservation_plan_settings in AwsMediaConvertQueue.
/// Nesting mode: list
/// </summary>
public class AwsMediaConvertQueueReservationPlanSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "reservation_plan_settings";

    /// <summary>
    /// The commitment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Commitment is required")]
    public required TerraformValue<string> Commitment
    {
        get => new TerraformReference<string>(this, "commitment");
        set => SetArgument("commitment", value);
    }

    /// <summary>
    /// The renewal_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RenewalType is required")]
    public required TerraformValue<string> RenewalType
    {
        get => new TerraformReference<string>(this, "renewal_type");
        set => SetArgument("renewal_type", value);
    }

    /// <summary>
    /// The reserved_slots attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReservedSlots is required")]
    public required TerraformValue<double> ReservedSlots
    {
        get => new TerraformReference<double>(this, "reserved_slots");
        set => SetArgument("reserved_slots", value);
    }

}


/// <summary>
/// Represents a aws_media_convert_queue Terraform resource.
/// Manages a aws_media_convert_queue resource.
/// </summary>
public partial class AwsMediaConvertQueue(string name) : TerraformResource("aws_media_convert_queue", name)
{
    /// <summary>
    /// The concurrent_jobs attribute.
    /// </summary>
    public TerraformValue<double> ConcurrentJobs
    {
        get => new TerraformReference<double>(this, "concurrent_jobs");
        set => SetArgument("concurrent_jobs", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The pricing_plan attribute.
    /// </summary>
    public TerraformValue<string>? PricingPlan
    {
        get => new TerraformReference<string>(this, "pricing_plan");
        set => SetArgument("pricing_plan", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => new TerraformReference<string>(this, "status");
        set => SetArgument("status", value);
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
    /// ReservationPlanSettings block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReservationPlanSettings block(s) allowed")]
    public TerraformList<AwsMediaConvertQueueReservationPlanSettingsBlock>? ReservationPlanSettings
    {
        get => GetArgument<TerraformList<AwsMediaConvertQueueReservationPlanSettingsBlock>>("reservation_plan_settings");
        set => SetArgument("reservation_plan_settings", value);
    }

}
