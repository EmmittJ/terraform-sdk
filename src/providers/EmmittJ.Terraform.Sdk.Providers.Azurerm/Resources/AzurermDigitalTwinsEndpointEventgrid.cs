using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDigitalTwinsEndpointEventgrid.
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
/// Represents a azurerm_digital_twins_endpoint_eventgrid Terraform resource.
/// Manages a azurerm_digital_twins_endpoint_eventgrid resource.
/// </summary>
public partial class AzurermDigitalTwinsEndpointEventgrid(string name) : TerraformResource("azurerm_digital_twins_endpoint_eventgrid", name)
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
    /// The eventgrid_topic_endpoint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicEndpoint is required")]
    public required TerraformValue<string> EventgridTopicEndpoint
    {
        get => new TerraformReference<string>(this, "eventgrid_topic_endpoint");
        set => SetArgument("eventgrid_topic_endpoint", value);
    }

    /// <summary>
    /// The eventgrid_topic_primary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicPrimaryAccessKey is required")]
    public required TerraformValue<string> EventgridTopicPrimaryAccessKey
    {
        get => new TerraformReference<string>(this, "eventgrid_topic_primary_access_key");
        set => SetArgument("eventgrid_topic_primary_access_key", value);
    }

    /// <summary>
    /// The eventgrid_topic_secondary_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventgridTopicSecondaryAccessKey is required")]
    public required TerraformValue<string> EventgridTopicSecondaryAccessKey
    {
        get => new TerraformReference<string>(this, "eventgrid_topic_secondary_access_key");
        set => SetArgument("eventgrid_topic_secondary_access_key", value);
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
    public AzurermDigitalTwinsEndpointEventgridTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDigitalTwinsEndpointEventgridTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
