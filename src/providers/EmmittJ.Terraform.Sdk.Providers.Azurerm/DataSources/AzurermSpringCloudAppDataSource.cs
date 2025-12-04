using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSpringCloudAppDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudAppDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_spring_cloud_app Terraform data source.
/// Retrieves information about a azurerm_spring_cloud_app.
/// </summary>
public partial class AzurermSpringCloudAppDataSource(string name) : TerraformDataSource("azurerm_spring_cloud_app", name)
{
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
    /// The service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceName is required")]
    public required TerraformValue<string> ServiceName
    {
        get => GetArgument<TerraformValue<string>>("service_name");
        set => SetArgument("service_name", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    public TerraformValue<string> Fqdn
        => AsReference("fqdn");

    /// <summary>
    /// The https_only attribute.
    /// </summary>
    public TerraformValue<bool> HttpsOnly
        => AsReference("https_only");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Identity
        => AsReference("identity");

    /// <summary>
    /// The is_public attribute.
    /// </summary>
    public TerraformValue<bool> IsPublic
        => AsReference("is_public");

    /// <summary>
    /// The persistent_disk attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PersistentDisk
        => AsReference("persistent_disk");

    /// <summary>
    /// The tls_enabled attribute.
    /// </summary>
    public TerraformValue<bool> TlsEnabled
        => AsReference("tls_enabled");

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string> Url
        => AsReference("url");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSpringCloudAppDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSpringCloudAppDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
