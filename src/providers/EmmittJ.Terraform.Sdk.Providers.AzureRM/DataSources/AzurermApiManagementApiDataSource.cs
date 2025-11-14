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
public class AzurermApiManagementApiDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_api_management_api.
/// </summary>
public class AzurermApiManagementApiDataSource : TerraformDataSource
{
    public AzurermApiManagementApiDataSource(string name) : base("azurerm_api_management_api", name)
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
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    [TerraformArgument("revision")]
    public required TerraformValue<string> Revision
    {
        get => new TerraformReference<string>(this, "revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermApiManagementApiDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    [TerraformArgument("is_current")]
    public TerraformValue<bool> IsCurrent
    {
        get => new TerraformReference<bool>(this, "is_current");
    }

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    [TerraformArgument("is_online")]
    public TerraformValue<bool> IsOnline
    {
        get => new TerraformReference<bool>(this, "is_online");
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    [TerraformArgument("path")]
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    [TerraformArgument("protocols")]
    public TerraformList<string> Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    [TerraformArgument("service_url")]
    public TerraformValue<string> ServiceUrl
    {
        get => new TerraformReference<string>(this, "service_url");
    }

    /// <summary>
    /// The soap_pass_through attribute.
    /// </summary>
    [TerraformArgument("soap_pass_through")]
    public TerraformValue<bool> SoapPassThrough
    {
        get => new TerraformReference<bool>(this, "soap_pass_through");
    }

    /// <summary>
    /// The subscription_key_parameter_names attribute.
    /// </summary>
    [TerraformArgument("subscription_key_parameter_names")]
    public TerraformList<object> SubscriptionKeyParameterNames
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "subscription_key_parameter_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    [TerraformArgument("subscription_required")]
    public TerraformValue<bool> SubscriptionRequired
    {
        get => new TerraformReference<bool>(this, "subscription_required");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    [TerraformArgument("version_set_id")]
    public TerraformValue<string> VersionSetId
    {
        get => new TerraformReference<string>(this, "version_set_id");
    }

}
