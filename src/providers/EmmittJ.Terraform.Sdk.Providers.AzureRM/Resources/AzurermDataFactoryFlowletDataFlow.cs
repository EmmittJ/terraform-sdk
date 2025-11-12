using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for sink in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryFlowletDataFlowSinkBlock() : TerraformBlock("sink")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryFlowletDataFlowSourceBlock() : TerraformBlock("source")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryFlowletDataFlowTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Block type for transformation in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryFlowletDataFlowTransformationBlock() : TerraformBlock("transformation")
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory_flowlet_data_flow resource.
/// </summary>
public partial class AzurermDataFactoryFlowletDataFlow : TerraformResource
{
    public AzurermDataFactoryFlowletDataFlow(string name) : base("azurerm_data_factory_flowlet_data_flow", name)
    {
    }

    /// <summary>
    /// The annotations attribute.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? Annotations { get; set; }

    /// <summary>
    /// The data_factory_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataFactoryId is required")]
    [TerraformProperty("data_factory_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DataFactoryId { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The folder attribute.
    /// </summary>
    [TerraformProperty("folder")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Folder { get; set; }

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
    /// The script attribute.
    /// </summary>
    [TerraformProperty("script")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Script { get; set; }

    /// <summary>
    /// The script_lines attribute.
    /// </summary>
    [TerraformProperty("script_lines")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? ScriptLines { get; set; }

    /// <summary>
    /// Block for sink.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("sink")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSinkBlock> Sink { get; set; } = new();

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("source")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowSourceBlock> Source { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDataFactoryFlowletDataFlowTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for transformation.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("transformation")]
    public TerraformList<AzurermDataFactoryFlowletDataFlowTransformationBlock> Transformation { get; set; } = new();

}
