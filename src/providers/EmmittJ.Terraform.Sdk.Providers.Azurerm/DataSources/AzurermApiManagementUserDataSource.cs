using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermApiManagementUserDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementUserDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_user Terraform data source.
/// Retrieves information about a azurerm_api_management_user.
/// </summary>
public partial class AzurermApiManagementUserDataSource(string name) : TerraformDataSource("azurerm_api_management_user", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The user_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserId is required")]
    public required TerraformValue<string> UserId
    {
        get => GetArgument<TerraformValue<string>>("user_id");
        set => SetArgument("user_id", value);
    }

    /// <summary>
    /// The email attribute.
    /// </summary>
    public TerraformValue<string> Email
        => AsReference("email");

    /// <summary>
    /// The first_name attribute.
    /// </summary>
    public TerraformValue<string> FirstName
        => AsReference("first_name");

    /// <summary>
    /// The last_name attribute.
    /// </summary>
    public TerraformValue<string> LastName
        => AsReference("last_name");

    /// <summary>
    /// The note attribute.
    /// </summary>
    public TerraformValue<string> Note
        => AsReference("note");

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementUserDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementUserDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
