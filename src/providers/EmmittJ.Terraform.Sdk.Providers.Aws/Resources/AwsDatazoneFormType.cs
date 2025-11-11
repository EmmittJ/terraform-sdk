using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for model in .
/// Nesting mode: list
/// </summary>
public class AwsDatazoneFormTypeModelBlock
{
    /// <summary>
    /// The smithy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Smithy is required")]
    [TerraformPropertyName("smithy")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Smithy { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatazoneFormTypeTimeoutsBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_datazone_form_type resource.
/// </summary>
public class AwsDatazoneFormType : TerraformResource
{
    public AwsDatazoneFormType(string name) : base("aws_datazone_form_type", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    [TerraformPropertyName("domain_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DomainIdentifier { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The owning_project_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OwningProjectIdentifier is required")]
    [TerraformPropertyName("owning_project_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> OwningProjectIdentifier { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Status { get; set; } = default!;

    /// <summary>
    /// Block for model.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("model")]
    public TerraformList<TerraformBlock<AwsDatazoneFormTypeModelBlock>>? Model { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDatazoneFormTypeTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformPropertyName("created_by")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedBy => new TerraformReference(this, "created_by");

    /// <summary>
    /// The imports attribute.
    /// </summary>
    [TerraformPropertyName("imports")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Imports => new TerraformReference(this, "imports");

    /// <summary>
    /// The origin_domain_id attribute.
    /// </summary>
    [TerraformPropertyName("origin_domain_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OriginDomainId => new TerraformReference(this, "origin_domain_id");

    /// <summary>
    /// The origin_project_id attribute.
    /// </summary>
    [TerraformPropertyName("origin_project_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OriginProjectId => new TerraformReference(this, "origin_project_id");

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [TerraformPropertyName("revision")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Revision => new TerraformReference(this, "revision");

}
