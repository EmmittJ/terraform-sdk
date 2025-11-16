using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "dead_letter_storage_secret");
        set => SetArgument("dead_letter_storage_secret", value);
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    public required TerraformValue<string> DigitalTwinsId
    {
        get => new TerraformReference<string>(this, "digital_twins_id");
        set => SetArgument("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_primary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubPrimaryConnectionString is required")]
    public required TerraformValue<string> EventhubPrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "eventhub_primary_connection_string");
        set => SetArgument("eventhub_primary_connection_string", value);
    }

    /// <summary>
    /// The eventhub_secondary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubSecondaryConnectionString is required")]
    public required TerraformValue<string> EventhubSecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "eventhub_secondary_connection_string");
        set => SetArgument("eventhub_secondary_connection_string", value);
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
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDigitalTwinsEndpointEventhubTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDigitalTwinsEndpointEventhubTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
