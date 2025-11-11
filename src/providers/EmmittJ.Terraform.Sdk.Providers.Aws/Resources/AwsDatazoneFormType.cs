using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for model in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatazoneFormTypeModelBlock : TerraformBlockBase
{
    /// <summary>
    /// The smithy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Smithy is required")]
    [TerraformProperty("smithy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Smithy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDatazoneFormTypeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_datazone_form_type resource.
/// </summary>
public partial class AwsDatazoneFormType : TerraformResource
{
    public AwsDatazoneFormType(string name) : base("aws_datazone_form_type", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    [TerraformProperty("domain_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DomainIdentifier { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owning_project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwningProjectIdentifier is required")]
    [TerraformProperty("owning_project_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> OwningProjectIdentifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Status { get; set; }

    /// <summary>
    /// Block for model.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("model")]
    public TerraformList<TerraformBlock<AwsDatazoneFormTypeModelBlock>>? Model { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDatazoneFormTypeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformProperty("created_by")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedBy { get; }

    /// <summary>
    /// The imports attribute.
    /// </summary>
    [TerraformProperty("imports")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Imports { get; }

    /// <summary>
    /// The origin_domain_id attribute.
    /// </summary>
    [TerraformProperty("origin_domain_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OriginDomainId { get; }

    /// <summary>
    /// The origin_project_id attribute.
    /// </summary>
    [TerraformProperty("origin_project_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> OriginProjectId { get; }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformProperty("revision")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Revision { get; }

}
