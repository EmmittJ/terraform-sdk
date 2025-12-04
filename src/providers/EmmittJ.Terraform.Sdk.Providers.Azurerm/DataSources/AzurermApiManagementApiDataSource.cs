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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("api_management_name");
        set => SetArgument("api_management_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Revision is required")]
    public required TerraformValue<string> Revision
    {
        get => GetArgument<TerraformValue<string>>("revision");
        set => SetArgument("revision", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    public TerraformValue<bool> IsCurrent
        => AsReference("is_current");

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    public TerraformValue<bool> IsOnline
        => AsReference("is_online");

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformValue<string> Path
        => AsReference("path");

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformList<string> Protocols
        => AsReference("protocols");

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformValue<string> ServiceUrl
        => AsReference("service_url");

    /// <summary>
    /// The soap_pass_through attribute.
    /// </summary>
    public TerraformValue<bool> SoapPassThrough
        => AsReference("soap_pass_through");

    /// <summary>
    /// The subscription_key_parameter_names attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SubscriptionKeyParameterNames
        => AsReference("subscription_key_parameter_names");

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformValue<bool> SubscriptionRequired
        => AsReference("subscription_required");

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<string> Version
        => AsReference("version");

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public TerraformValue<string> VersionSetId
        => AsReference("version_set_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementApiDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementApiDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
