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
public class AzurermApiManagementSubscriptionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_api_management_subscription resource.
/// </summary>
public class AzurermApiManagementSubscription : TerraformResource
{
    public AzurermApiManagementSubscription(string name) : base("azurerm_api_management_subscription", name)
    {
    }

    /// <summary>
    /// The allow_tracing attribute.
    /// </summary>
    [TerraformArgument("allow_tracing")]
    public TerraformValue<bool>? AllowTracing
    {
        get => new TerraformReference<bool>(this, "allow_tracing");
        set => SetArgument("allow_tracing", value);
    }

    /// <summary>
    /// The api_id attribute.
    /// </summary>
    [TerraformArgument("api_id")]
    public TerraformValue<string>? ApiId
    {
        get => new TerraformReference<string>(this, "api_id");
        set => SetArgument("api_id", value);
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
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformArgument("display_name")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The primary_key attribute.
    /// </summary>
    [TerraformArgument("primary_key")]
    public TerraformValue<string> PrimaryKey
    {
        get => new TerraformReference<string>(this, "primary_key");
        set => SetArgument("primary_key", value);
    }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformArgument("product_id")]
    public TerraformValue<string>? ProductId
    {
        get => new TerraformReference<string>(this, "product_id");
        set => SetArgument("product_id", value);
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
    /// The secondary_key attribute.
    /// </summary>
    [TerraformArgument("secondary_key")]
    public TerraformValue<string> SecondaryKey
    {
        get => new TerraformReference<string>(this, "secondary_key");
        set => SetArgument("secondary_key", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    [TerraformArgument("state")]
    public TerraformValue<string>? State
    {
        get => new TerraformReference<string>(this, "state");
        set => SetArgument("state", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    [TerraformArgument("subscription_id")]
    public TerraformValue<string> SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [TerraformArgument("user_id")]
    public TerraformValue<string>? UserId
    {
        get => new TerraformReference<string>(this, "user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementSubscriptionTimeoutsBlock Timeouts { get; set; } = new();

}
