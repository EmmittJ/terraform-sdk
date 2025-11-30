using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementApiDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_api_management_api Terraform data source.
/// Retrieves information about a azurerm_api_management_api.
/// </summary>
public partial class AzurermApiManagementApiDataSource(string name) : TerraformDataSource("azurerm_api_management_api", name)
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
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformValue<string> Revision
    {
        get => new TerraformReference<string>(this, "revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    public TerraformValue<bool> IsCurrent
    {
        get => new TerraformReference<bool>(this, "is_current");
    }

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    public TerraformValue<bool> IsOnline
    {
        get => new TerraformReference<bool>(this, "is_online");
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
    {
        get => new TerraformReference<string>(this, "path");
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformList<string> Protocols
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "protocols").ResolveNodes(ctx));
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceUrl
    {
        get => new TerraformReference<string>(this, "service_url");
    }

    /// <summary>
    /// The soap_pass_through attribute.
    /// </summary>
    public TerraformValue<bool> SoapPassThrough
    {
        get => new TerraformReference<bool>(this, "soap_pass_through");
    }

    /// <summary>
    /// The subscription_key_parameter_names attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SubscriptionKeyParameterNames
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "subscription_key_parameter_names").ResolveNodes(ctx));
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformValue<bool> SubscriptionRequired
    {
        get => new TerraformReference<bool>(this, "subscription_required");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public TerraformValue<string> VersionSetId
    {
        get => new TerraformReference<string>(this, "version_set_id");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementApiDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementApiDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
