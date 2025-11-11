using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_contact_channel.
/// </summary>
public partial class AwsSsmcontactsContactChannelDataSource : TerraformDataSource
{
    public AwsSsmcontactsContactChannelDataSource(string name) : base("aws_ssmcontacts_contact_channel", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Arn { get; set; }

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
    /// The activation_status attribute.
    /// </summary>
    [TerraformProperty("activation_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ActivationStatus { get; }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [TerraformProperty("contact_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ContactId { get; }

    /// <summary>
    /// The delivery_address attribute.
    /// </summary>
    [TerraformProperty("delivery_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> DeliveryAddress { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Name { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}
