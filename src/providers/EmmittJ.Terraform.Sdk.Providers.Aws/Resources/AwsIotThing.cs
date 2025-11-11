using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iot_thing resource.
/// </summary>
public partial class AwsIotThing : TerraformResource
{
    public AwsIotThing(string name) : base("aws_iot_thing", name)
    {
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    [TerraformProperty("attributes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Attributes { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The thing_type_name attribute.
    /// </summary>
    [TerraformProperty("thing_type_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ThingTypeName { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The default_client_id attribute.
    /// </summary>
    [TerraformProperty("default_client_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultClientId { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> Version { get; }

}
