using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for forms_input in .
/// Nesting mode: set
/// </summary>
public partial class AwsDatazoneAssetTypeFormsInputBlock : TerraformBlockBase
{
    /// <summary>
    /// The map_block_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MapBlockKey is required")]
    [TerraformProperty("map_block_key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> MapBlockKey { get; set; }

    /// <summary>
    /// The required attribute.
    /// </summary>
    [TerraformProperty("required")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Required { get; set; }

    /// <summary>
    /// The type_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeIdentifier is required")]
    [TerraformProperty("type_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TypeIdentifier { get; set; }

    /// <summary>
    /// The type_revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeRevision is required")]
    [TerraformProperty("type_revision")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TypeRevision { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDatazoneAssetTypeTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_datazone_asset_type resource.
/// </summary>
public partial class AwsDatazoneAssetType : TerraformResource
{
    public AwsDatazoneAssetType(string name) : base("aws_datazone_asset_type", name)
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
    /// Block for forms_input.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("forms_input")]
    public TerraformSet<TerraformBlock<AwsDatazoneAssetTypeFormsInputBlock>>? FormsInput { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsDatazoneAssetTypeTimeoutsBlock>? Timeouts { get; set; }

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
    /// The revision attribute.
    /// </summary>
    [TerraformProperty("revision")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Revision { get; }

}
