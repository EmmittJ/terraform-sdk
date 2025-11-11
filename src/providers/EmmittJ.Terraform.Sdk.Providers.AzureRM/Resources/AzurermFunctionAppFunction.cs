using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for file in .
/// Nesting mode: list
/// </summary>
public partial class AzurermFunctionAppFunctionFileBlock : TerraformBlockBase
{
    /// <summary>
    /// The content of the file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformProperty("content")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Content { get; set; }

    /// <summary>
    /// The filename of the file to be uploaded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermFunctionAppFunctionTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_function_app_function resource.
/// </summary>
public partial class AzurermFunctionAppFunction : TerraformResource
{
    public AzurermFunctionAppFunction(string name) : base("azurerm_function_app_function", name)
    {
    }

    /// <summary>
    /// The config for this Function in JSON format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigJson is required")]
    [TerraformProperty("config_json")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ConfigJson { get; set; }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Enabled { get; set; }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    [TerraformProperty("function_app_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> FunctionAppId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The language the Function is written in.
    /// </summary>
    [TerraformProperty("language")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Language { get; set; }

    /// <summary>
    /// The name of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    [TerraformProperty("test_data")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TestData { get; set; }

    /// <summary>
    /// Block for file.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("file")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFunctionFileBlock>>? File { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermFunctionAppFunctionTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The URL of the configuration JSON.
    /// </summary>
    [TerraformProperty("config_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConfigUrl { get; }

    /// <summary>
    /// The invocation URL.
    /// </summary>
    [TerraformProperty("invocation_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InvocationUrl { get; }

    /// <summary>
    /// The Script root path URL.
    /// </summary>
    [TerraformProperty("script_root_path_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScriptRootPathUrl { get; }

    /// <summary>
    /// The script URL.
    /// </summary>
    [TerraformProperty("script_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ScriptUrl { get; }

    /// <summary>
    /// The URL for the Secrets File.
    /// </summary>
    [TerraformProperty("secrets_file_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SecretsFileUrl { get; }

    /// <summary>
    /// The Test data URL.
    /// </summary>
    [TerraformProperty("test_data_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TestDataUrl { get; }

    /// <summary>
    /// The function URL.
    /// </summary>
    [TerraformProperty("url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Url { get; }

}
