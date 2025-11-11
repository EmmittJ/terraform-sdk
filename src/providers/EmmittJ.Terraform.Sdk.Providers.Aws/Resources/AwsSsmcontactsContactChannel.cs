using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for delivery_address in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmcontactsContactChannelDeliveryAddressBlock : TerraformBlockBase
{
    /// <summary>
    /// The simple_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SimpleAddress is required")]
    [TerraformProperty("simple_address")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SimpleAddress { get; set; }

}

/// <summary>
/// Manages a aws_ssmcontacts_contact_channel resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsmcontactsContactChannel : TerraformResource
{
    public AwsSsmcontactsContactChannel(string name) : base("aws_ssmcontacts_contact_channel", name)
    {
    }

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContactId is required")]
    [TerraformProperty("contact_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ContactId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

    /// <summary>
    /// Block for delivery_address.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeliveryAddress is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DeliveryAddress block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DeliveryAddress block(s) allowed")]
    [TerraformProperty("delivery_address")]
    public TerraformList<TerraformBlock<AwsSsmcontactsContactChannelDeliveryAddressBlock>>? DeliveryAddress { get; set; }

    /// <summary>
    /// The activation_status attribute.
    /// </summary>
    [TerraformProperty("activation_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ActivationStatus { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}
