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
    public TerraformProperty<string>? AwsRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("aws_role_arn");
        set => this.WithProperty("aws_role_arn", value);
    }

    /// <summary>
    /// The destination_table attribute.
    /// </summary>
    public TerraformProperty<string>? DestinationTable
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
    public TerraformProperty<string>? LogAnalyticsWorkspaceId
    {
        get => GetProperty<TerraformProperty<string>>("log_analytics_workspace_id");
        set => this.WithProperty("log_analytics_workspace_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The sqs_urls attribute.
    /// </summary>
    public TerraformProperty<List<string>>? SqsUrls
    {
        get => GetProperty<TerraformProperty<List<string>>>("sqs_urls");
        set => this.WithProperty("sqs_urls", value);
    }

}
