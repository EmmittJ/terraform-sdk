using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSubscriptionTemplateDeploymentDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermSubscriptionTemplateDeploymentDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_subscription_template_deployment Terraform data source.
/// Retrieves information about a azurerm_subscription_template_deployment.
/// </summary>
public partial class AzurermSubscriptionTemplateDeploymentDataSource(string name) : TerraformDataSource("azurerm_subscription_template_deployment", name)
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
    /// The output_content attribute.
    /// </summary>
    public TerraformValue<string> OutputContent
        => AsReference("output_content");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSubscriptionTemplateDeploymentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSubscriptionTemplateDeploymentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
