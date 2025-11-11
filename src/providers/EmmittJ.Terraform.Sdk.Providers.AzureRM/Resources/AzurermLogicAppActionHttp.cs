using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for run_after in .
/// Nesting mode: set
/// </summary>
public partial class AzurermLogicAppActionHttpRunAfterBlock : TerraformBlockBase
{
    /// <summary>
    /// The action_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionName is required")]
    [TerraformProperty("action_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ActionName { get; set; }

    /// <summary>
    /// The action_result attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionResult is required")]
    [TerraformProperty("action_result")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ActionResult { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermLogicAppActionHttpTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_logic_app_action_http resource.
/// </summary>
public partial class AzurermLogicAppActionHttp : TerraformResource
{
    public AzurermLogicAppActionHttp(string name) : base("azurerm_logic_app_action_http", name)
    {
    }

    /// <summary>
    /// The body attribute.
    /// </summary>
    [TerraformProperty("body")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Body { get; set; }

    /// <summary>
    /// The headers attribute.
    /// </summary>
    [TerraformProperty("headers")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Headers { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The logic_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogicAppId is required")]
    [TerraformProperty("logic_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LogicAppId { get; set; }

    /// <summary>
    /// The method attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Method is required")]
    [TerraformProperty("method")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Method { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The queries attribute.
    /// </summary>
    [TerraformProperty("queries")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Queries { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Uri { get; set; }

    /// <summary>
    /// Block for run_after.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("run_after")]
    public TerraformSet<TerraformBlock<AzurermLogicAppActionHttpRunAfterBlock>>? RunAfter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermLogicAppActionHttpTimeoutsBlock>? Timeouts { get; set; }

}
