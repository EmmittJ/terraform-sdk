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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
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
    }

    /// <summary>
    /// The aws_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRoleArn is required")]
    public required TerraformProperty<string> AwsRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("aws_role_arn");
        set => this.WithProperty("aws_role_arn", value);
    }

    /// <summary>
    /// The destination_table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationTable is required")]
    public required TerraformProperty<string> DestinationTable
    {
        get => GetProperty<TerraformProperty<string>>("destination_table");
        set => this.WithProperty("destination_table", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformProperty<string> LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sqs_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqsUrls is required")]
    public List<TerraformProperty<string>>? SqsUrls
    {
        get => GetProperty<List<TerraformProperty<string>>>("sqs_urls");
        set => this.WithProperty("sqs_urls", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSentinelDataConnectorAwsS3TimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSentinelDataConnectorAwsS3TimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
