using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public partial class AwsFsxOntapStorageVirtualMachineDataSourceFilterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    [TerraformProperty("values")]
    // Required argument - source generator will implement get/set
    public partial TerraformList<string>? Values { get; set; }

}

/// <summary>
/// Retrieves information about a aws_fsx_ontap_storage_virtual_machine.
/// </summary>
public partial class AwsFsxOntapStorageVirtualMachineDataSource : TerraformDataSource
{
    public AwsFsxOntapStorageVirtualMachineDataSource(string name) : base("aws_fsx_ontap_storage_virtual_machine", name)
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
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("filter")]
    public partial TerraformSet<TerraformBlock<AwsFsxOntapStorageVirtualMachineDataSourceFilterBlock>>? Filter { get; set; }

    /// <summary>
    /// The active_directory_configuration attribute.
    /// </summary>
    [TerraformProperty("active_directory_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ActiveDirectoryConfiguration { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    [TerraformProperty("creation_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTime { get; }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformProperty("endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Endpoints { get; }

    /// <summary>
    /// The file_system_id attribute.
    /// </summary>
    [TerraformProperty("file_system_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> FileSystemId { get; }

    /// <summary>
    /// The lifecycle_status attribute.
    /// </summary>
    [TerraformProperty("lifecycle_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LifecycleStatus { get; }

    /// <summary>
    /// The lifecycle_transition_reason attribute.
    /// </summary>
    [TerraformProperty("lifecycle_transition_reason")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> LifecycleTransitionReason { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The subtype attribute.
    /// </summary>
    [TerraformProperty("subtype")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Subtype { get; }

    /// <summary>
    /// The uuid attribute.
    /// </summary>
    [TerraformProperty("uuid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Uuid { get; }

}
