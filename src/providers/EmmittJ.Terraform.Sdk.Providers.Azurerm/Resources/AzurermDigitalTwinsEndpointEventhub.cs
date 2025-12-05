using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDigitalTwinsEndpointEventhub.
/// Nesting mode: single
/// </summary>
public class AzurermDigitalTwinsEndpointEventhubTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_digital_twins_endpoint_eventhub Terraform resource.
/// Manages a azurerm_digital_twins_endpoint_eventhub resource.
/// </summary>
public partial class AzurermDigitalTwinsEndpointEventhub(string name) : TerraformResource("azurerm_digital_twins_endpoint_eventhub", name)
{
    /// <summary>
    /// The dead_letter_storage_secret attribute.
    /// </summary>
    public TerraformValue<string>? DeadLetterStorageSecret
    {
        get => GetArgument<TerraformValue<string>>("dead_letter_storage_secret");
        set => SetArgument("dead_letter_storage_secret", value);
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    public required TerraformValue<string> DigitalTwinsId
    {
        get => GetRequiredArgument<TerraformValue<string>>("digital_twins_id");
        set => SetArgument("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_primary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubPrimaryConnectionString is required")]
    public required TerraformValue<string> EventhubPrimaryConnectionString
    {
        get => GetRequiredArgument<TerraformValue<string>>("eventhub_primary_connection_string");
        set => SetArgument("eventhub_primary_connection_string", value);
    }

    /// <summary>
    /// The eventhub_secondary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubSecondaryConnectionString is required")]
    public required TerraformValue<string> EventhubSecondaryConnectionString
    {
        get => GetRequiredArgument<TerraformValue<string>>("eventhub_secondary_connection_string");
        set => SetArgument("eventhub_secondary_connection_string", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDigitalTwinsEndpointEventhubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDigitalTwinsEndpointEventhubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
