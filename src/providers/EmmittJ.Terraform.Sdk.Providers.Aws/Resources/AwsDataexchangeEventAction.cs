using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public partial class AwsDataexchangeEventActionActionBlock() : TerraformBlock("action")
{
}

/// <summary>
/// Block type for event in .
/// Nesting mode: list
/// </summary>
public partial class AwsDataexchangeEventActionEventBlock() : TerraformBlock("event")
{
}

/// <summary>
/// Manages a aws_dataexchange_event_action resource.
/// </summary>
public partial class AwsDataexchangeEventAction : TerraformResource
{
    public AwsDataexchangeEventAction(string name) : base("aws_dataexchange_event_action", name)
    {
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("action")]
    public TerraformList<AwsDataexchangeEventActionActionBlock> Action { get; set; } = new();

    /// <summary>
    /// Block for event.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("event")]
    public TerraformList<AwsDataexchangeEventActionEventBlock> Event { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    [TerraformProperty("updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdatedAt { get; }

}
