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
public class AzurermNginxApiKeyDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_nginx_api_key.
/// </summary>
public class AzurermNginxApiKeyDataSource : TerraformDataSource
{
    public AzurermNginxApiKeyDataSource(string name) : base("azurerm_nginx_api_key", name)
    {
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
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    [TerraformArgument("nginx_deployment_id")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermNginxApiKeyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The end_date_time attribute.
    /// </summary>
    [TerraformArgument("end_date_time")]
    public TerraformValue<string> EndDateTime
    {
        get => new TerraformReference<string>(this, "end_date_time");
    }

    /// <summary>
    /// The hint attribute.
    /// </summary>
    [TerraformArgument("hint")]
    public TerraformValue<string> Hint
    {
        get => new TerraformReference<string>(this, "hint");
    }

}
