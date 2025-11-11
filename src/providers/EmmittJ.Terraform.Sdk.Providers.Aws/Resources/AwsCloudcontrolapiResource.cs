using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCloudcontrolapiResourceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_cloudcontrolapi_resource resource.
/// </summary>
public class AwsCloudcontrolapiResource : TerraformResource
{
    public AwsCloudcontrolapiResource(string name) : base("aws_cloudcontrolapi_resource", name)
    {
    }

    /// <summary>
    /// The desired_state attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DesiredState is required")]
    [TerraformPropertyName("desired_state")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DesiredState { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [TerraformPropertyName("role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? RoleArn { get; set; }

    /// <summary>
    /// The schema attribute.
    /// </summary>
    [TerraformPropertyName("schema")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Schema { get; set; } = default!;

    /// <summary>
    /// The type_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TypeName is required")]
    [TerraformPropertyName("type_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> TypeName { get; set; }

    /// <summary>
    /// The type_version_id attribute.
    /// </summary>
    [TerraformPropertyName("type_version_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? TypeVersionId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsCloudcontrolapiResourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The properties attribute.
    /// </summary>
    [TerraformPropertyName("properties")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Properties => new TerraformReference(this, "properties");

}
