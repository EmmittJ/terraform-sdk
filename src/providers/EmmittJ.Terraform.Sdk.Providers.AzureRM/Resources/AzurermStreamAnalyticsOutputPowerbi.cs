using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStreamAnalyticsOutputPowerbiTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_stream_analytics_output_powerbi resource.
/// </summary>
public class AzurermStreamAnalyticsOutputPowerbi : TerraformResource
{
    public AzurermStreamAnalyticsOutputPowerbi(string name) : base("azurerm_stream_analytics_output_powerbi", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("dataset");
        SetOutput("group_id");
        SetOutput("group_name");
        SetOutput("id");
        SetOutput("name");
        SetOutput("stream_analytics_job_id");
        SetOutput("table");
        SetOutput("token_user_display_name");
        SetOutput("token_user_principal_name");
    }

    /// <summary>
    /// The dataset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Dataset is required")]
    public required TerraformProperty<string> Dataset
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataset");
        set => SetProperty("dataset", value);
    }

    /// <summary>
    /// The group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupId is required")]
    public required TerraformProperty<string> GroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_id");
        set => SetProperty("group_id", value);
    }

    /// <summary>
    /// The group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GroupName is required")]
    public required TerraformProperty<string> GroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("group_name");
        set => SetProperty("group_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The stream_analytics_job_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StreamAnalyticsJobId is required")]
    public required TerraformProperty<string> StreamAnalyticsJobId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stream_analytics_job_id");
        set => SetProperty("stream_analytics_job_id", value);
    }

    /// <summary>
    /// The table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Table is required")]
    public required TerraformProperty<string> Table
    {
        get => GetRequiredOutput<TerraformProperty<string>>("table");
        set => SetProperty("table", value);
    }

    /// <summary>
    /// The token_user_display_name attribute.
    /// </summary>
    public TerraformProperty<string> TokenUserDisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("token_user_display_name");
        set => SetProperty("token_user_display_name", value);
    }

    /// <summary>
    /// The token_user_principal_name attribute.
    /// </summary>
    public TerraformProperty<string> TokenUserPrincipalName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("token_user_principal_name");
        set => SetProperty("token_user_principal_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermStreamAnalyticsOutputPowerbiTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
