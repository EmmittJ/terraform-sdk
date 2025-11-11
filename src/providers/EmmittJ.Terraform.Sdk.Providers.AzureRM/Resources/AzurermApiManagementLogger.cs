using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for application_insights in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementLoggerApplicationInsightsBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionString { get; set; }

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    [TerraformProperty("instrumentation_key")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? InstrumentationKey { get; set; }

}

/// <summary>
/// Block type for eventhub in .
/// Nesting mode: list
/// </summary>
public partial class AzurermApiManagementLoggerEventhubBlock : TerraformBlockBase
{
    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformProperty("connection_string")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ConnectionString { get; set; }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [TerraformProperty("endpoint_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? EndpointUri { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The user_assigned_identity_client_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_client_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserAssignedIdentityClientId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermApiManagementLoggerTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_api_management_logger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermApiManagementLogger : TerraformResource
{
    public AzurermApiManagementLogger(string name) : base("azurerm_api_management_logger", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformProperty("api_management_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ApiManagementName { get; set; }

    /// <summary>
    /// The buffered attribute.
    /// </summary>
    [TerraformProperty("buffered")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Buffered { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResourceId { get; set; }

    /// <summary>
    /// Block for application_insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsights block(s) allowed")]
    [TerraformProperty("application_insights")]
    public TerraformList<TerraformBlock<AzurermApiManagementLoggerApplicationInsightsBlock>>? ApplicationInsights { get; set; }

    /// <summary>
    /// Block for eventhub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Eventhub block(s) allowed")]
    [TerraformProperty("eventhub")]
    public TerraformList<TerraformBlock<AzurermApiManagementLoggerEventhubBlock>>? Eventhub { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermApiManagementLoggerTimeoutsBlock>? Timeouts { get; set; }

}
