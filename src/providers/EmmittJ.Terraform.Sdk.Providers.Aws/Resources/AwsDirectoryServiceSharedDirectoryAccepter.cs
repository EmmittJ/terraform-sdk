using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_directory_service_shared_directory_accepter resource.
/// </summary>
public partial class AwsDirectoryServiceSharedDirectoryAccepter : TerraformResource
{
    public AwsDirectoryServiceSharedDirectoryAccepter(string name) : base("aws_directory_service_shared_directory_accepter", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The shared_directory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SharedDirectoryId is required")]
    [TerraformProperty("shared_directory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SharedDirectoryId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AwsDirectoryServiceSharedDirectoryAccepterTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The method attribute.
    /// </summary>
    [TerraformProperty("method")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Method { get; }

    /// <summary>
    /// The notes attribute.
    /// </summary>
    [TerraformProperty("notes")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Notes { get; }

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    [TerraformProperty("owner_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerAccountId { get; }

    /// <summary>
    /// The owner_directory_id attribute.
    /// </summary>
    [TerraformProperty("owner_directory_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnerDirectoryId { get; }

}
