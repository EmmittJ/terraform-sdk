using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermStorageMoverJobDefinitionTimeoutsBlock : TerraformBlockBase
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

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_storage_mover_job_definition resource.
/// </summary>
public partial class AzurermStorageMoverJobDefinition : TerraformResource
{
    public AzurermStorageMoverJobDefinition(string name) : base("azurerm_storage_mover_job_definition", name)
    {
    }

    /// <summary>
    /// The agent_name attribute.
    /// </summary>
    [TerraformProperty("agent_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? AgentName { get; set; }

    /// <summary>
    /// The copy_mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CopyMode is required")]
    [TerraformProperty("copy_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CopyMode { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    [TerraformProperty("source_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceName { get; set; }

    /// <summary>
    /// The source_sub_path attribute.
    /// </summary>
    [TerraformProperty("source_sub_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SourceSubPath { get; set; }

    /// <summary>
    /// The storage_mover_project_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageMoverProjectId is required")]
    [TerraformProperty("storage_mover_project_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageMoverProjectId { get; set; }

    /// <summary>
    /// The target_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetName is required")]
    [TerraformProperty("target_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TargetName { get; set; }

    /// <summary>
    /// The target_sub_path attribute.
    /// </summary>
    [TerraformProperty("target_sub_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetSubPath { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermStorageMoverJobDefinitionTimeoutsBlock>? Timeouts { get; set; }

}
