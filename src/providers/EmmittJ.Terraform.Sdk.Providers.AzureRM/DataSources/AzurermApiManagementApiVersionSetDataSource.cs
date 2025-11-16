using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermApiManagementApiVersionSetDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_api_management_api_version_set Terraform data source.
/// Retrieves information about a azurerm_api_management_api_version_set.
/// </summary>
public partial class AzurermApiManagementApiVersionSetDataSource(string name) : TerraformDataSource("azurerm_api_management_api_version_set", name)
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
    /// The version_header_name attribute.
    /// </summary>
    public TerraformValue<string> VersionHeaderName
    {
        get => new TerraformReference<string>(this, "version_header_name");
    }

    /// <summary>
    /// The version_query_name attribute.
    /// </summary>
    public TerraformValue<string> VersionQueryName
    {
        get => new TerraformReference<string>(this, "version_query_name");
    }

    /// <summary>
    /// The versioning_scheme attribute.
    /// </summary>
    public TerraformValue<string> VersioningScheme
    {
        get => new TerraformReference<string>(this, "versioning_scheme");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermApiManagementApiVersionSetDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermApiManagementApiVersionSetDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
