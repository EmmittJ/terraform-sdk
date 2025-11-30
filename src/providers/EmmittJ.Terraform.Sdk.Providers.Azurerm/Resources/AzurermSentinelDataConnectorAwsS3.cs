using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermSentinelDataConnectorAwsS3.
/// Nesting mode: single
/// </summary>
public class AzurermSentinelDataConnectorAwsS3TimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_sentinel_data_connector_aws_s3 Terraform resource.
/// Manages a azurerm_sentinel_data_connector_aws_s3 resource.
/// </summary>
public partial class AzurermSentinelDataConnectorAwsS3(string name) : TerraformResource("azurerm_sentinel_data_connector_aws_s3", name)
{
    /// <summary>
    /// The aws_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AwsRoleArn is required")]
    public required TerraformValue<string> AwsRoleArn
    {
        get => new TerraformReference<string>(this, "aws_role_arn");
        set => SetArgument("aws_role_arn", value);
    }

    /// <summary>
    /// The destination_table attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationTable is required")]
    public required TerraformValue<string> DestinationTable
    {
        get => new TerraformReference<string>(this, "destination_table");
        set => SetArgument("destination_table", value);
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
    /// The log_analytics_workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LogAnalyticsWorkspaceId is required")]
    public required TerraformValue<string> LogAnalyticsWorkspaceId
    {
        get => new TerraformReference<string>(this, "log_analytics_workspace_id");
        set => SetArgument("log_analytics_workspace_id", value);
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
    /// The sqs_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqsUrls is required")]
    public TerraformList<string>? SqsUrls
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "sqs_urls").ResolveNodes(ctx));
        set => SetArgument("sqs_urls", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSentinelDataConnectorAwsS3TimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSentinelDataConnectorAwsS3TimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
