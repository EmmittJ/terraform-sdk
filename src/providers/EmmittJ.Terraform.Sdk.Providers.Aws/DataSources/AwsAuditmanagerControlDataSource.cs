using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_auditmanager_control.
/// </summary>
public class AwsAuditmanagerControlDataSource : TerraformDataSource
{
    public AwsAuditmanagerControlDataSource(string name) : base("aws_auditmanager_control", name)
    {
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

    /// <summary>
    /// The action_plan_instructions attribute.
    /// </summary>
    [TerraformPropertyName("action_plan_instructions")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActionPlanInstructions => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "action_plan_instructions");

    /// <summary>
    /// The action_plan_title attribute.
    /// </summary>
    [TerraformPropertyName("action_plan_title")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActionPlanTitle => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "action_plan_title");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The control_mapping_sources attribute.
    /// </summary>
    [TerraformPropertyName("control_mapping_sources")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ControlMappingSources => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "control_mapping_sources");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The testing_information attribute.
    /// </summary>
    [TerraformPropertyName("testing_information")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TestingInformation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "testing_information");

}
