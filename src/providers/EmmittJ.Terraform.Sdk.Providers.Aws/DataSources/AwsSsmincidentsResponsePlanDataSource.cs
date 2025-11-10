using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmincidents_response_plan.
/// </summary>
public class AwsSsmincidentsResponsePlanDataSource : TerraformDataSource
{
    public AwsSsmincidentsResponsePlanDataSource(string name) : base("aws_ssmincidents_response_plan", name)
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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformPropertyName("action")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Action => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "action");

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    [TerraformPropertyName("chat_channel")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> ChatChannel => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "chat_channel");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    [TerraformPropertyName("engagements")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Engagements => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "engagements");

    /// <summary>
    /// The incident_template attribute.
    /// </summary>
    [TerraformPropertyName("incident_template")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> IncidentTemplate => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "incident_template");

    /// <summary>
    /// The integration attribute.
    /// </summary>
    [TerraformPropertyName("integration")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Integration => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "integration");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
