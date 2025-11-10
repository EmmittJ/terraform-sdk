using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_contact_channel.
/// </summary>
public class AwsSsmcontactsContactChannelDataSource : TerraformDataSource
{
    public AwsSsmcontactsContactChannelDataSource(string name) : base("aws_ssmcontacts_contact_channel", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The activation_status attribute.
    /// </summary>
    [TerraformPropertyName("activation_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActivationStatus => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "activation_status");

    /// <summary>
    /// The contact_id attribute.
    /// </summary>
    [TerraformPropertyName("contact_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ContactId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "contact_id");

    /// <summary>
    /// The delivery_address attribute.
    /// </summary>
    [TerraformPropertyName("delivery_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DeliveryAddress => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "delivery_address");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}
