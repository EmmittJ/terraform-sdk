using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for portal_options in .
/// Nesting mode: list
/// </summary>
public class AwsSsoadminApplicationPortalOptionsBlock
{
    /// <summary>
    /// The visibility attribute.
    /// </summary>
    [TerraformPropertyName("visibility")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Visibility { get; set; } = default!;

}

/// <summary>
/// Manages a aws_ssoadmin_application resource.
/// </summary>
public class AwsSsoadminApplication : TerraformResource
{
    public AwsSsoadminApplication(string name) : base("aws_ssoadmin_application", name)
    {
    }

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationProviderArn is required")]
    [TerraformPropertyName("application_provider_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ApplicationProviderArn { get; set; }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    [TerraformPropertyName("client_token")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClientToken { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceArn is required")]
    [TerraformPropertyName("instance_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceArn { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for portal_options.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("portal_options")]
    public TerraformList<TerraformBlock<AwsSsoadminApplicationPortalOptionsBlock>>? PortalOptions { get; set; }

    /// <summary>
    /// The application_account attribute.
    /// </summary>
    [TerraformPropertyName("application_account")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplicationAccount => new TerraformReference(this, "application_account");

    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [TerraformPropertyName("application_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ApplicationArn => new TerraformReference(this, "application_arn");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> TagsAll => new TerraformReference(this, "tags_all");

}
