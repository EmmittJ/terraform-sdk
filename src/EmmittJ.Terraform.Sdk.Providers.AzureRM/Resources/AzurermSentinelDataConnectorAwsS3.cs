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
    public TerraformLiteralProperty<string>? AwsRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("aws_role_arn");
        set => this.WithProperty("aws_role_arn", value);
    }

    /// <summary>
    /// The destination_table attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DestinationTable
    {
        get => GetProperty<TerraformLiteralProperty<string>>("destination_table");
        set => this.WithProperty("destination_table", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sqs_urls attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? SqsUrls
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("sqs_urls");
        set => this.WithProperty("sqs_urls", value);
    }

}
