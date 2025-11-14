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
/// Manages a azurerm_digital_twins_endpoint_eventhub resource.
/// </summary>
public class AzurermDigitalTwinsEndpointEventhub : TerraformResource
{
    public AzurermDigitalTwinsEndpointEventhub(string name) : base("azurerm_digital_twins_endpoint_eventhub", name)
    {
    }

    /// <summary>
    /// The dead_letter_storage_secret attribute.
    /// </summary>
    [TerraformArgument("dead_letter_storage_secret")]
    public TerraformValue<string>? DeadLetterStorageSecret
    {
        get => new TerraformReference<string>(this, "dead_letter_storage_secret");
        set => SetArgument("dead_letter_storage_secret", value);
    }

    /// <summary>
    /// The digital_twins_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DigitalTwinsId is required")]
    [TerraformArgument("digital_twins_id")]
    public required TerraformValue<string> DigitalTwinsId
    {
        get => new TerraformReference<string>(this, "digital_twins_id");
        set => SetArgument("digital_twins_id", value);
    }

    /// <summary>
    /// The eventhub_primary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubPrimaryConnectionString is required")]
    [TerraformArgument("eventhub_primary_connection_string")]
    public required TerraformValue<string> EventhubPrimaryConnectionString
    {
        get => new TerraformReference<string>(this, "eventhub_primary_connection_string");
        set => SetArgument("eventhub_primary_connection_string", value);
    }

    /// <summary>
    /// The eventhub_secondary_connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventhubSecondaryConnectionString is required")]
    [TerraformArgument("eventhub_secondary_connection_string")]
    public required TerraformValue<string> EventhubSecondaryConnectionString
    {
        get => new TerraformReference<string>(this, "eventhub_secondary_connection_string");
        set => SetArgument("eventhub_secondary_connection_string", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDigitalTwinsEndpointEventhubTimeoutsBlock Timeouts { get; set; } = new();

}
