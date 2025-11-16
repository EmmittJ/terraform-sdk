using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The instrumentation_key attribute.
    /// </summary>
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
    public TerraformValue<string>? ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformValue<string>? EndpointUri
    {
        get => new TerraformReference<string>(this, "endpoint_uri");
        set => SetArgument("endpoint_uri", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The user_assigned_identity_client_id attribute.
    /// </summary>
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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Represents a azurerm_api_management_logger Terraform resource.
/// Manages a azurerm_api_management_logger resource.
/// </summary>
public partial class AzurermApiManagementLogger(string name) : TerraformResource("azurerm_api_management_logger", name)
{
    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApiManagementName is required")]
    public required TerraformValue<string> ApiManagementName
    {
        get => new TerraformReference<string>(this, "api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The buffered attribute.
    /// </summary>
    public TerraformValue<bool>? Buffered
    {
        get => new TerraformReference<bool>(this, "buffered");
        set => SetArgument("buffered", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    public TerraformValue<string>? ResourceId
    {
        get => new TerraformReference<string>(this, "resource_id");
        set => SetArgument("resource_id", value);
    }

    /// <summary>
    /// ApplicationInsights block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ApplicationInsights block(s) allowed")]
    public TerraformList<AzurermApiManagementLoggerApplicationInsightsBlock>? ApplicationInsights
    {
        get => GetArgument<TerraformList<AzurermApiManagementLoggerApplicationInsightsBlock>>("application_insights");
        set => SetArgument("application_insights", value);
    }

    /// <summary>
    /// Eventhub block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Eventhub block(s) allowed")]
    public TerraformList<AzurermApiManagementLoggerEventhubBlock>? Eventhub
    {
        get => GetArgument<TerraformList<AzurermApiManagementLoggerEventhubBlock>>("eventhub");
        set => SetArgument("eventhub", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementLoggerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementLoggerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
