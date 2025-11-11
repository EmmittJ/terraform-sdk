using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for schedule in .
/// Nesting mode: list
/// </summary>
public partial class AwsQuicksightRefreshScheduleScheduleBlock : TerraformBlockBase
{
    /// <summary>
    /// The refresh_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RefreshType is required")]
    [TerraformProperty("refresh_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RefreshType { get; set; }

    /// <summary>
    /// The start_after_date_time attribute.
    /// </summary>
    [TerraformProperty("start_after_date_time")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> StartAfterDateTime { get; set; }

}

/// <summary>
/// Manages a aws_quicksight_refresh_schedule resource.
/// </summary>
public partial class AwsQuicksightRefreshSchedule : TerraformResource
{
    public AwsQuicksightRefreshSchedule(string name) : base("aws_quicksight_refresh_schedule", name)
    {
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    [TerraformProperty("aws_account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AwsAccountId { get; set; }

    /// <summary>
    /// The data_set_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSetId is required")]
    [TerraformProperty("data_set_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataSetId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The schedule_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleId is required")]
    [TerraformProperty("schedule_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ScheduleId { get; set; }

    /// <summary>
    /// Block for schedule.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("schedule")]
    public partial TerraformList<TerraformBlock<AwsQuicksightRefreshScheduleScheduleBlock>>? Schedule { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
