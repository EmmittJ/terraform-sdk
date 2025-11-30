using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermNginxApiKey.
/// Nesting mode: single
/// </summary>
public class AzurermNginxApiKeyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_nginx_api_key Terraform resource.
/// Manages a azurerm_nginx_api_key resource.
/// </summary>
public partial class AzurermNginxApiKey(string name) : TerraformResource("azurerm_nginx_api_key", name)
{
    /// <summary>
    /// The end_date_time attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndDateTime is required")]
    public required TerraformValue<string> EndDateTime
    {
        get => new TerraformReference<string>(this, "end_date_time");
        set => SetArgument("end_date_time", value);
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
    /// The nginx_deployment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NginxDeploymentId is required")]
    public required TerraformValue<string> NginxDeploymentId
    {
        get => new TerraformReference<string>(this, "nginx_deployment_id");
        set => SetArgument("nginx_deployment_id", value);
    }

    /// <summary>
    /// The secret_text attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecretText is required")]
    public required TerraformValue<string> SecretText
    {
        get => new TerraformReference<string>(this, "secret_text");
        set => SetArgument("secret_text", value);
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
    public AzurermNginxApiKeyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermNginxApiKeyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
