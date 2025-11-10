using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSentinelDataConnectorAwsS3TimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_sentinel_data_connector_aws_s3 resource.
/// </summary>
public class AzurermSentinelDataConnectorAwsS3 : TerraformResource
{
    public AzurermSentinelDataConnectorAwsS3(string name) : base("azurerm_sentinel_data_connector_aws_s3", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("aws_role_arn");
        SetOutput("destination_table");
        SetOutput("id");
        SetOutput("log_analytics_workspace_id");
        SetOutput("name");
        SetOutput("sqs_urls");
    }

    /// <summary>
    /// The aws_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRoleArn is required")]
    public required TerraformProperty<string> AwsRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("aws_role_arn");
        set => SetProperty("aws_role_arn", value);
    }

    /// <summary>
    /// The destination_table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationTable is required")]
    public required TerraformProperty<string> DestinationTable
    {
        get => GetRequiredOutput<TerraformProperty<string>>("destination_table");
        set => SetProperty("destination_table", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_analytics_workspace_id");
        set => SetProperty("log_analytics_workspace_id", value);
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
    /// The sqs_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqsUrls is required")]
    public List<TerraformProperty<string>> SqsUrls
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("sqs_urls");
        set => SetProperty("sqs_urls", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelDataConnectorAwsS3TimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
