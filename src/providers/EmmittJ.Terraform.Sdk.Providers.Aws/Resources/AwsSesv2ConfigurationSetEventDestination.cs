using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for event_destination in .
/// Nesting mode: list
/// </summary>
public partial class AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock : TerraformBlockBase
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The matching_event_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MatchingEventTypes is required")]
    [TerraformProperty("matching_event_types")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> MatchingEventTypes { get; set; }

}

/// <summary>
/// Manages a aws_sesv2_configuration_set_event_destination resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSesv2ConfigurationSetEventDestination : TerraformResource
{
    public AwsSesv2ConfigurationSetEventDestination(string name) : base("aws_sesv2_configuration_set_event_destination", name)
    {
    }

    /// <summary>
    /// The configuration_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigurationSetName is required")]
    [TerraformProperty("configuration_set_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConfigurationSetName { get; set; }

    /// <summary>
    /// The event_destination_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventDestinationName is required")]
    [TerraformProperty("event_destination_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> EventDestinationName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for event_destination.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventDestination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EventDestination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventDestination block(s) allowed")]
    [TerraformProperty("event_destination")]
    public TerraformList<TerraformBlock<AwsSesv2ConfigurationSetEventDestinationEventDestinationBlock>>? EventDestination { get; set; }

}
