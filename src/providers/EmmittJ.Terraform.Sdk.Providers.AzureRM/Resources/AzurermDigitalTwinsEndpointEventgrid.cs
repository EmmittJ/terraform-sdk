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
public class AzurermDigitalTwinsEndpointEventgridTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_digital_twins_endpoint_eventgrid resource.
/// </summary>
public class AzurermDigitalTwinsEndpointEventgrid : TerraformResource
{
    public AzurermDigitalTwinsEndpointEventgrid(string name) : base("azurerm_digital_twins_endpoint_eventgrid", name)
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
    /// The eventgrid_topic_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicEndpoint is required")]
    [TerraformArgument("eventgrid_topic_endpoint")]
    public required TerraformValue<string> EventgridTopicEndpoint
    {
        get => new TerraformReference<string>(this, "eventgrid_topic_endpoint");
        set => SetArgument("eventgrid_topic_endpoint", value);
    }

    /// <summary>
    /// The eventgrid_topic_primary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicPrimaryAccessKey is required")]
    [TerraformArgument("eventgrid_topic_primary_access_key")]
    public required TerraformValue<string> EventgridTopicPrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "eventgrid_topic_primary_access_key");
        set => SetArgument("eventgrid_topic_primary_access_key", value);
    }

    /// <summary>
    /// The eventgrid_topic_secondary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicSecondaryAccessKey is required")]
    [TerraformArgument("eventgrid_topic_secondary_access_key")]
    public required TerraformValue<string> EventgridTopicSecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "eventgrid_topic_secondary_access_key");
        set => SetArgument("eventgrid_topic_secondary_access_key", value);
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
    public AzurermDigitalTwinsEndpointEventgridTimeoutsBlock Timeouts { get; set; } = new();

}
