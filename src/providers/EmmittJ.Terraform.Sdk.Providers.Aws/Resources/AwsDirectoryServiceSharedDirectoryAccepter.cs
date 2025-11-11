using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock
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

}

/// <summary>
/// Manages a aws_directory_service_shared_directory_accepter resource.
/// </summary>
public class AwsDirectoryServiceSharedDirectoryAccepter : TerraformResource
{
    public AwsDirectoryServiceSharedDirectoryAccepter(string name) : base("aws_directory_service_shared_directory_accepter", name)
    {
    }

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
    /// The shared_directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedDirectoryId is required")]
    [TerraformPropertyName("shared_directory_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SharedDirectoryId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The method attribute.
    /// </summary>
    [TerraformPropertyName("method")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Method => new TerraformReference(this, "method");

    /// <summary>
    /// The notes attribute.
    /// </summary>
    [TerraformPropertyName("notes")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Notes => new TerraformReference(this, "notes");

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_account_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerAccountId => new TerraformReference(this, "owner_account_id");

    /// <summary>
    /// The owner_directory_id attribute.
    /// </summary>
    [TerraformPropertyName("owner_directory_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OwnerDirectoryId => new TerraformReference(this, "owner_directory_id");

}
