using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public string? AwsRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_role_arn")?.Value;
        set => this.WithProperty("aws_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The destination_table attribute.
    /// </summary>
    public string? DestinationTable
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_table")?.Value;
        set => this.WithProperty("destination_table", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public string? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id")?.Value;
        set => this.WithProperty("log_analytics_workspace_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sqs_urls attribute.
    /// </summary>
    public List<string>? SqsUrls
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("sqs_urls")?.Value;
        set => this.WithProperty("sqs_urls", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

}
