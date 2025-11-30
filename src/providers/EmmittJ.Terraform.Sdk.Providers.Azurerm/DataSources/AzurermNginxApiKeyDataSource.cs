using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNginxApiKeyDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermNginxApiKeyDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_nginx_api_key Terraform data source.
/// Retrieves information about a azurerm_nginx_api_key.
/// </summary>
public partial class AzurermNginxApiKeyDataSource(string name) : TerraformDataSource("azurerm_nginx_api_key", name)
{
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
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// The end_date_time attribute.
    /// </summary>
    public TerraformValue<string> EndDateTime
    {
        get => new TerraformReference<string>(this, "end_date_time");
    }

    /// <summary>
    /// The hint attribute.
    /// </summary>
    public TerraformValue<string> Hint
    {
        get => new TerraformReference<string>(this, "hint");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermNginxApiKeyDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxApiKeyDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
