using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for application_insights in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementLoggerApplicationInsightsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "application_insights";

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformArgument("connection_string")]
    public TerraformValue<string>? ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
    [TerraformArgument("instrumentation_key")]
    public TerraformValue<string>? InstrumentationKey
    {
        get => new TerraformReference<string>(this, "instrumentation_key");
        set => SetArgument("instrumentation_key", value);
    }

}

/// <summary>
/// Block type for eventhub in .
/// Nesting mode: list
/// </summary>
public class AzurermApiManagementLoggerEventhubBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "eventhub";

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [TerraformArgument("connection_string")]
    public TerraformValue<string>? ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [TerraformArgument("endpoint_uri")]
    public TerraformValue<string>? EndpointUri
    {
        get => new TerraformReference<string>(this, "endpoint_uri");
        set => SetArgument("endpoint_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The user_assigned_identity_client_id attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity_client_id")]
    public TerraformValue<string>? UserAssignedIdentityClientId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_client_id");
        set => SetArgument("user_assigned_identity_client_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementLoggerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_api_management_logger resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermApiManagementLogger : TerraformResource
{
    public AzurermApiManagementLogger(string name) : base("azurerm_api_management_logger", name)
    {
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    [TerraformArgument("api_management_name")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The buffered attribute.
    /// </summary>
    [TerraformArgument("buffered")]
    public TerraformValue<bool>? Buffered
    {
        get => new TerraformReference<bool>(this, "buffered");
        set => SetArgument("buffered", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformArgument("resource_id")]
    public TerraformValue<string>? ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// Block for application_insights.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsights block(s) allowed")]
    [TerraformArgument("application_insights")]
    public TerraformList<AzurermApiManagementLoggerApplicationInsightsBlock> ApplicationInsights { get; set; } = new();

    /// <summary>
    /// Block for eventhub.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Eventhub block(s) allowed")]
    [TerraformArgument("eventhub")]
    public TerraformList<AzurermApiManagementLoggerEventhubBlock> Eventhub { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementLoggerTimeoutsBlock Timeouts { get; set; } = new();

}
