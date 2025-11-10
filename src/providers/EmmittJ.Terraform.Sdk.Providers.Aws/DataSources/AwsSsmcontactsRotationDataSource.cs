using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_rotation.
/// </summary>
public class AwsSsmcontactsRotationDataSource : TerraformDataSource
{
    public AwsSsmcontactsRotationDataSource(string name) : base("aws_ssmcontacts_rotation", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The contact_ids attribute.
    /// </summary>
    [TerraformPropertyName("contact_ids")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<string>>> ContactIds => new TerraformReferenceProperty<List<TerraformProperty<string>>>(ResourceAddress, "contact_ids");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    [TerraformPropertyName("recurrence")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Recurrence => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "recurrence");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StartTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "start_time");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("time_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TimeZoneId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "time_zone_id");

}
