using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for file in .
/// Nesting mode: list
/// </summary>
public class AzurermFunctionAppFunctionFileBlock : ITerraformBlock
{
    /// <summary>
    /// The content of the file.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Content is required")]
    [TerraformPropertyName("content")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Content { get; set; }

    /// <summary>
    /// The filename of the file to be uploaded.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppFunctionTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_function_app_function resource.
/// </summary>
public class AzurermFunctionAppFunction : TerraformResource
{
    public AzurermFunctionAppFunction(string name) : base("azurerm_function_app_function", name)
    {
    }

    /// <summary>
    /// The config for this Function in JSON format.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConfigJson is required")]
    [TerraformPropertyName("config_json")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ConfigJson { get; set; }

    /// <summary>
    /// Should this function be enabled. Defaults to `true`.
    /// </summary>
    [TerraformPropertyName("enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enabled { get; set; }

    /// <summary>
    /// The ID of the Function App in which this function should reside.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    [TerraformPropertyName("function_app_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> FunctionAppId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The language the Function is written in.
    /// </summary>
    [TerraformPropertyName("language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Language { get; set; }

    /// <summary>
    /// The name of the function.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The test data for the function.
    /// </summary>
    [TerraformPropertyName("test_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TestData { get; set; }

    /// <summary>
    /// Block for file.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("file")]
    public TerraformList<TerraformBlock<AzurermFunctionAppFunctionFileBlock>>? File { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermFunctionAppFunctionTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The URL of the configuration JSON.
    /// </summary>
    [TerraformPropertyName("config_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "config_url");

    /// <summary>
    /// The invocation URL.
    /// </summary>
    [TerraformPropertyName("invocation_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InvocationUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "invocation_url");

    /// <summary>
    /// The Script root path URL.
    /// </summary>
    [TerraformPropertyName("script_root_path_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScriptRootPathUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "script_root_path_url");

    /// <summary>
    /// The script URL.
    /// </summary>
    [TerraformPropertyName("script_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ScriptUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "script_url");

    /// <summary>
    /// The URL for the Secrets File.
    /// </summary>
    [TerraformPropertyName("secrets_file_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SecretsFileUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "secrets_file_url");

    /// <summary>
    /// The Test data URL.
    /// </summary>
    [TerraformPropertyName("test_data_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TestDataUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "test_data_url");

    /// <summary>
    /// The function URL.
    /// </summary>
    [TerraformPropertyName("url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Url => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "url");

}
