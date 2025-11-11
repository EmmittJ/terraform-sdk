using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_event_configurations resource.
/// </summary>
public partial class AwsIotEventConfigurations : TerraformResource
{
    public AwsIotEventConfigurations(string name) : base("aws_iot_event_configurations", name)
    {
    }

    /// <summary>
    /// The event_configurations attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventConfigurations is required")]
    [TerraformProperty("event_configurations")]
    // Required argument - source generator will implement get/set
    public required partial TerraformMap<bool> EventConfigurations { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

}
