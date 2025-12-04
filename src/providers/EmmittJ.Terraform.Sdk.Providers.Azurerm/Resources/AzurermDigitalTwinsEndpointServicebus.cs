using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDigitalTwinsEndpointServicebus.
/// Nesting mode: single
/// </summary>
public class AzurermDigitalTwinsEndpointServicebusTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_digital_twins_endpoint_servicebus Terraform resource.
/// Manages a azurerm_digital_twins_endpoint_servicebus resource.
/// </summary>
public partial class AzurermDigitalTwinsEndpointServicebus(string name) : TerraformResource("azurerm_digital_twins_endpoint_servicebus", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The servicebus_primary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicebusPrimaryConnectionString is required")]
    public required TerraformValue<string> ServicebusPrimaryConnectionString
    {
        get => GetRequiredArgument<TerraformValue<string>>("servicebus_primary_connection_string");
        set => SetArgument("servicebus_primary_connection_string", value);
    }

    /// <summary>
    /// The servicebus_secondary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicebusSecondaryConnectionString is required")]
    public required TerraformValue<string> ServicebusSecondaryConnectionString
    {
        get => GetRequiredArgument<TerraformValue<string>>("servicebus_secondary_connection_string");
        set => SetArgument("servicebus_secondary_connection_string", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDigitalTwinsEndpointServicebusTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDigitalTwinsEndpointServicebusTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
