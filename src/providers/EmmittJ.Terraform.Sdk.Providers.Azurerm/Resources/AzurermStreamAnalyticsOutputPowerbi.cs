using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStreamAnalyticsOutputPowerbi.
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputPowerbiTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_stream_analytics_output_powerbi Terraform resource.
/// Manages a azurerm_stream_analytics_output_powerbi resource.
/// </summary>
public partial class AzurermStreamAnalyticsOutputPowerbi(string name) : TerraformResource("azurerm_stream_analytics_output_powerbi", name)
{
    /// <summary>
    /// The dataset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformValue<string> Dataset
    {
        get => new TerraformReference<string>(this, "dataset");
        set => SetArgument("dataset", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformValue<string> GroupId
    {
        get => new TerraformReference<string>(this, "group_id");
        set => SetArgument("group_id", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformValue<string> GroupName
    {
        get => new TerraformReference<string>(this, "group_name");
        set => SetArgument("group_name", value);
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
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformValue<string> StreamAnalyticsJobId
    {
        get => new TerraformReference<string>(this, "stream_analytics_job_id");
        set => SetArgument("stream_analytics_job_id", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformValue<string> Table
    {
        get => new TerraformReference<string>(this, "table");
        set => SetArgument("table", value);
    }

    /// <summary>
    /// The token_user_display_name attribute.
    /// </summary>
    public TerraformValue<string>? TokenUserDisplayName
    {
        get => new TerraformReference<string>(this, "token_user_display_name");
        set => SetArgument("token_user_display_name", value);
    }

    /// <summary>
    /// The token_user_principal_name attribute.
    /// </summary>
    public TerraformValue<string>? TokenUserPrincipalName
    {
        get => new TerraformReference<string>(this, "token_user_principal_name");
        set => SetArgument("token_user_principal_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStreamAnalyticsOutputPowerbiTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStreamAnalyticsOutputPowerbiTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
