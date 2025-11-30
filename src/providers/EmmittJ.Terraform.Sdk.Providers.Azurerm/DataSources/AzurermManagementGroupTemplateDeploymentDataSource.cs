using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermManagementGroupTemplateDeploymentDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermManagementGroupTemplateDeploymentDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_management_group_template_deployment Terraform data source.
/// Retrieves information about a azurerm_management_group_template_deployment.
/// </summary>
public partial class AzurermManagementGroupTemplateDeploymentDataSource(string name) : TerraformDataSource("azurerm_management_group_template_deployment", name)
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
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformValue<string> ManagementGroupId
    {
        get => new TerraformReference<string>(this, "management_group_id");
        set => SetArgument("management_group_id", value);
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
    /// The output_content attribute.
    /// </summary>
    public TerraformValue<string> OutputContent
    {
        get => new TerraformReference<string>(this, "output_content");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermManagementGroupTemplateDeploymentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermManagementGroupTemplateDeploymentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
