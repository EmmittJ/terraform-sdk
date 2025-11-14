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
public class AzurermIothubFileUploadTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_iothub_file_upload resource.
/// </summary>
public class AzurermIothubFileUpload : TerraformResource
{
    public AzurermIothubFileUpload(string name) : base("azurerm_iothub_file_upload", name)
    {
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    [TerraformArgument("authentication_type")]
    public TerraformValue<string>? AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectionString is required")]
    [TerraformArgument("connection_string")]
    public required TerraformValue<string> ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    [TerraformArgument("container_name")]
    public required TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    [TerraformArgument("default_ttl")]
    public TerraformValue<string>? DefaultTtl
    {
        get => new TerraformReference<string>(this, "default_ttl");
        set => SetArgument("default_ttl", value);
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
    /// The identity_id attribute.
    /// </summary>
    [TerraformArgument("identity_id")]
    public TerraformValue<string>? IdentityId
    {
        get => new TerraformReference<string>(this, "identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    [TerraformArgument("iothub_id")]
    public required TerraformValue<string> IothubId
    {
        get => new TerraformReference<string>(this, "iothub_id");
        set => SetArgument("iothub_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    [TerraformArgument("lock_duration")]
    public TerraformValue<string>? LockDuration
    {
        get => new TerraformReference<string>(this, "lock_duration");
        set => SetArgument("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    [TerraformArgument("max_delivery_count")]
    public TerraformValue<double>? MaxDeliveryCount
    {
        get => new TerraformReference<double>(this, "max_delivery_count");
        set => SetArgument("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    [TerraformArgument("notifications_enabled")]
    public TerraformValue<bool>? NotificationsEnabled
    {
        get => new TerraformReference<bool>(this, "notifications_enabled");
        set => SetArgument("notifications_enabled", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    [TerraformArgument("sas_ttl")]
    public TerraformValue<string>? SasTtl
    {
        get => new TerraformReference<string>(this, "sas_ttl");
        set => SetArgument("sas_ttl", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermIothubFileUploadTimeoutsBlock Timeouts { get; set; } = new();

}
