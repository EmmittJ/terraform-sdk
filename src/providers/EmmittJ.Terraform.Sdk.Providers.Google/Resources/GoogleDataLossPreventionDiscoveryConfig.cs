using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions in GoogleDataLossPreventionDiscoveryConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// ExportData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExportData block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockExportDataBlock>? ExportData
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockExportDataBlock>>("export_data");
        set => SetArgument("export_data", value);
    }

    /// <summary>
    /// PubSubNotification block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubSubNotification block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlock>? PubSubNotification
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlock>>("pub_sub_notification");
        set => SetArgument("pub_sub_notification", value);
    }

    /// <summary>
    /// PublishToDataplexCatalog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PublishToDataplexCatalog block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPublishToDataplexCatalogBlock>? PublishToDataplexCatalog
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPublishToDataplexCatalogBlock>>("publish_to_dataplex_catalog");
        set => SetArgument("publish_to_dataplex_catalog", value);
    }

    /// <summary>
    /// TagResources block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TagResources block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlock>? TagResources
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlock>>("tag_resources");
        set => SetArgument("tag_resources", value);
    }

}

/// <summary>
/// Block type for export_data in GoogleDataLossPreventionDiscoveryConfigActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockExportDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "export_data";

    /// <summary>
    /// ProfileTable block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProfileTable block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockExportDataBlockProfileTableBlock>? ProfileTable
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockExportDataBlockProfileTableBlock>>("profile_table");
        set => SetArgument("profile_table", value);
    }

}

/// <summary>
/// Block type for profile_table in GoogleDataLossPreventionDiscoveryConfigActionsBlockExportDataBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockExportDataBlockProfileTableBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "profile_table";

    /// <summary>
    /// Dataset Id of the table
    /// </summary>
    public TerraformValue<string>? DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// The Google Cloud Platform project ID of the project containing the table. If omitted, the project ID is inferred from the API call.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Name of the table
    /// </summary>
    public TerraformValue<string>? TableId
    {
        get => GetArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for pub_sub_notification in GoogleDataLossPreventionDiscoveryConfigActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pub_sub_notification";

    /// <summary>
    /// How much data to include in the pub/sub message. Possible values: [&amp;quot;TABLE_PROFILE&amp;quot;, &amp;quot;RESOURCE_NAME&amp;quot;]
    /// </summary>
    public TerraformValue<string>? DetailOfMessage
    {
        get => GetArgument<TerraformValue<string>>("detail_of_message");
        set => SetArgument("detail_of_message", value);
    }

    /// <summary>
    /// The type of event that triggers a Pub/Sub. At most one PubSubNotification per EventType is permitted. Possible values: [&amp;quot;NEW_PROFILE&amp;quot;, &amp;quot;CHANGED_PROFILE&amp;quot;, &amp;quot;SCORE_INCREASED&amp;quot;, &amp;quot;ERROR_CHANGED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? EventAttribute
    {
        get => GetArgument<TerraformValue<string>>("event");
        set => SetArgument("event", value);
    }

    /// <summary>
    /// Cloud Pub/Sub topic to send notifications to. Format is projects/{project}/topics/{topic}.
    /// </summary>
    public TerraformValue<string>? Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

    /// <summary>
    /// PubsubCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubCondition block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlock>? PubsubCondition
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlock>>("pubsub_condition");
        set => SetArgument("pubsub_condition", value);
    }

}

/// <summary>
/// Block type for pubsub_condition in GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub_condition";

    /// <summary>
    /// Expressions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Expressions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlockExpressionsBlock>? Expressions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlockExpressionsBlock>>("expressions");
        set => SetArgument("expressions", value);
    }

}

/// <summary>
/// Block type for expressions in GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlockExpressionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "expressions";

    /// <summary>
    /// The operator to apply to the collection of conditions Possible values: [&amp;quot;OR&amp;quot;, &amp;quot;AND&amp;quot;]
    /// </summary>
    public TerraformValue<string>? LogicalOperator
    {
        get => GetArgument<TerraformValue<string>>("logical_operator");
        set => SetArgument("logical_operator", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlockExpressionsBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlockExpressionsBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlockExpressionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockPubSubNotificationBlockPubsubConditionBlockExpressionsBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// The minimum data risk score that triggers the condition. Possible values: [&amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM_OR_HIGH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MinimumRiskScore
    {
        get => GetArgument<TerraformValue<string>>("minimum_risk_score");
        set => SetArgument("minimum_risk_score", value);
    }

    /// <summary>
    /// The minimum sensitivity level that triggers the condition. Possible values: [&amp;quot;HIGH&amp;quot;, &amp;quot;MEDIUM_OR_HIGH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? MinimumSensitivityScore
    {
        get => GetArgument<TerraformValue<string>>("minimum_sensitivity_score");
        set => SetArgument("minimum_sensitivity_score", value);
    }

}

/// <summary>
/// Block type for publish_to_dataplex_catalog in GoogleDataLossPreventionDiscoveryConfigActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockPublishToDataplexCatalogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "publish_to_dataplex_catalog";

}

/// <summary>
/// Block type for tag_resources in GoogleDataLossPreventionDiscoveryConfigActionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_resources";

    /// <summary>
    /// Whether applying a tag to a resource should lower the risk of the profile for that resource. For example, in conjunction with an [IAM deny policy](https://cloud.google.com/iam/docs/deny-overview), you can deny all principals a permission if a tag value is present, mitigating the risk of the resource. This also lowers the data risk of resources at the lower levels of the resource hierarchy. For example, reducing the data risk of a table data profile also reduces the data risk of the constituent column data profiles.
    /// </summary>
    public TerraformValue<bool>? LowerDataRiskToLow
    {
        get => GetArgument<TerraformValue<bool>>("lower_data_risk_to_low");
        set => SetArgument("lower_data_risk_to_low", value);
    }

    /// <summary>
    /// The profile generations for which the tag should be attached to resources. If you attach a tag to only new profiles, then if the sensitivity score of a profile subsequently changes, its tag doesn&#39;t change. By default, this field includes only new profiles. To include both new and updated profiles for tagging, this field should explicitly include both &#39;PROFILE_GENERATION_NEW&#39; and &#39;PROFILE_GENERATION_UPDATE&#39;. Possible values: [&amp;quot;PROFILE_GENERATION_NEW&amp;quot;, &amp;quot;PROFILE_GENERATION_UPDATE&amp;quot;]
    /// </summary>
    public TerraformList<string>? ProfileGenerationsToTag
    {
        get => GetArgument<TerraformList<string>>("profile_generations_to_tag");
        set => SetArgument("profile_generations_to_tag", value);
    }

    /// <summary>
    /// TagConditions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlock>? TagConditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlock>>("tag_conditions");
        set => SetArgument("tag_conditions", value);
    }

}

/// <summary>
/// Block type for tag_conditions in GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag_conditions";

    /// <summary>
    /// SensitivityScore block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SensitivityScore block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlockSensitivityScoreBlock>? SensitivityScore
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlockSensitivityScoreBlock>>("sensitivity_score");
        set => SetArgument("sensitivity_score", value);
    }

    /// <summary>
    /// Tag block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tag block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlockTagBlock>? Tag
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlockTagBlock>>("tag");
        set => SetArgument("tag", value);
    }

}

/// <summary>
/// Block type for sensitivity_score in GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlockSensitivityScoreBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sensitivity_score";

    /// <summary>
    /// The sensitivity score applied to the resource. Possible values: [&amp;quot;SENSITIVITY_LOW&amp;quot;, &amp;quot;SENSITIVITY_MODERATE&amp;quot;, &amp;quot;SENSITIVITY_HIGH&amp;quot;, &amp;quot;SENSITIVITY_UNKNOWN&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Score is required")]
    public required TerraformValue<string> Score
    {
        get => GetRequiredArgument<TerraformValue<string>>("score");
        set => SetArgument("score", value);
    }

}

/// <summary>
/// Block type for tag in GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigActionsBlockTagResourcesBlockTagConditionsBlockTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tag";

    /// <summary>
    /// The namespaced name for the tag value to attach to resources. Must be in the format &#39;{parent_id}/{tag_key_short_name}/{short_name}&#39;, for example, &amp;quot;123456/environment/prod&amp;quot;.
    /// </summary>
    public TerraformValue<string>? NamespacedValue
    {
        get => GetArgument<TerraformValue<string>>("namespaced_value");
        set => SetArgument("namespaced_value", value);
    }

}


/// <summary>
/// Block type for org_config in GoogleDataLossPreventionDiscoveryConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "org_config";

    /// <summary>
    /// The project that will run the scan. The DLP service account that exists within this project must have access to all resources that are profiled, and the cloud DLP API must be enabled.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

    /// <summary>
    /// Location block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Location block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigOrgConfigBlockLocationBlock>? Location
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigOrgConfigBlockLocationBlock>>("location");
        set => SetArgument("location", value);
    }

}

/// <summary>
/// Block type for location in GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOrgConfigBlockLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "location";

    /// <summary>
    /// The ID for the folder within an organization to scan
    /// </summary>
    public TerraformValue<string>? FolderId
    {
        get => GetArgument<TerraformValue<string>>("folder_id");
        set => SetArgument("folder_id", value);
    }

    /// <summary>
    /// The ID of an organization to scan
    /// </summary>
    public TerraformValue<string>? OrganizationId
    {
        get => GetArgument<TerraformValue<string>>("organization_id");
        set => SetArgument("organization_id", value);
    }

}


/// <summary>
/// Block type for other_cloud_starting_location in GoogleDataLossPreventionDiscoveryConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "other_cloud_starting_location";

    /// <summary>
    /// AwsLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsLocation block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlockAwsLocationBlock>? AwsLocation
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlockAwsLocationBlock>>("aws_location");
        set => SetArgument("aws_location", value);
    }

}

/// <summary>
/// Block type for aws_location in GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlockAwsLocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_location";

    /// <summary>
    /// The AWS account ID that this discovery config applies to. Within an organization, you can find the AWS account ID inside an AWS account ARN. Example: arn:&amp;lt;partition&amp;gt;:organizations::&amp;lt;management-account-id&amp;gt;:account/&amp;lt;organization-id&amp;gt;/&amp;lt;account-id&amp;gt;
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

    /// <summary>
    /// All AWS assets stored in Asset Inventory that didn&#39;t match other AWS discovery configs.
    /// </summary>
    public TerraformValue<bool>? AllAssetInventoryAssets
    {
        get => GetArgument<TerraformValue<bool>>("all_asset_inventory_assets");
        set => SetArgument("all_asset_inventory_assets", value);
    }

}


/// <summary>
/// Block type for targets in GoogleDataLossPreventionDiscoveryConfig.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "targets";

    /// <summary>
    /// BigQueryTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BigQueryTarget block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlock>? BigQueryTarget
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlock>>("big_query_target");
        set => SetArgument("big_query_target", value);
    }

    /// <summary>
    /// CloudSqlTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudSqlTarget block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlock>? CloudSqlTarget
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlock>>("cloud_sql_target");
        set => SetArgument("cloud_sql_target", value);
    }

    /// <summary>
    /// CloudStorageTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorageTarget block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlock>? CloudStorageTarget
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlock>>("cloud_storage_target");
        set => SetArgument("cloud_storage_target", value);
    }

    /// <summary>
    /// OtherCloudTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OtherCloudTarget block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlock>? OtherCloudTarget
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlock>>("other_cloud_target");
        set => SetArgument("other_cloud_target", value);
    }

    /// <summary>
    /// SecretsTarget block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecretsTarget block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockSecretsTargetBlock>? SecretsTarget
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockSecretsTargetBlock>>("secrets_target");
        set => SetArgument("secrets_target", value);
    }

}

/// <summary>
/// Block type for big_query_target in GoogleDataLossPreventionDiscoveryConfigTargetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "big_query_target";

    /// <summary>
    /// Cadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Cadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlock>? Cadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlock>>("cadence");
        set => SetArgument("cadence", value);
    }

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

    /// <summary>
    /// Disabled block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Disabled block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockDisabledBlock>? Disabled
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockDisabledBlock>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cadence";

    /// <summary>
    /// InspectTemplateModifiedCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectTemplateModifiedCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockInspectTemplateModifiedCadenceBlock>? InspectTemplateModifiedCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockInspectTemplateModifiedCadenceBlock>>("inspect_template_modified_cadence");
        set => SetArgument("inspect_template_modified_cadence", value);
    }

    /// <summary>
    /// SchemaModifiedCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaModifiedCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockSchemaModifiedCadenceBlock>? SchemaModifiedCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockSchemaModifiedCadenceBlock>>("schema_modified_cadence");
        set => SetArgument("schema_modified_cadence", value);
    }

    /// <summary>
    /// TableModifiedCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableModifiedCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockTableModifiedCadenceBlock>? TableModifiedCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockTableModifiedCadenceBlock>>("table_modified_cadence");
        set => SetArgument("table_modified_cadence", value);
    }

}

/// <summary>
/// Block type for inspect_template_modified_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockInspectTemplateModifiedCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inspect_template_modified_cadence";

    /// <summary>
    /// How frequently data profiles can be updated when the template is modified. Defaults to never. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

}

/// <summary>
/// Block type for schema_modified_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockSchemaModifiedCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_modified_cadence";

    /// <summary>
    /// How frequently profiles may be updated when schemas are modified. Default to monthly Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The type of events to consider when deciding if the table&#39;s schema has been modified and should have the profile updated. Defaults to NEW_COLUMN. Possible values: [&amp;quot;SCHEMA_NEW_COLUMNS&amp;quot;, &amp;quot;SCHEMA_REMOVED_COLUMNS&amp;quot;]
    /// </summary>
    public TerraformList<string>? Types
    {
        get => GetArgument<TerraformList<string>>("types");
        set => SetArgument("types", value);
    }

}

/// <summary>
/// Block type for table_modified_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockCadenceBlockTableModifiedCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_modified_cadence";

    /// <summary>
    /// How frequently data profiles can be updated when tables are modified. Defaults to never. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The type of events to consider when deciding if the table has been modified and should have the profile updated. Defaults to MODIFIED_TIMESTAMP Possible values: [&amp;quot;TABLE_MODIFIED_TIMESTAMP&amp;quot;]
    /// </summary>
    public TerraformList<string>? Types
    {
        get => GetArgument<TerraformList<string>>("types");
        set => SetArgument("types", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format with nanosecond resolution and upto nine fractional digits.
    /// </summary>
    public TerraformValue<string>? CreatedAfter
    {
        get => GetArgument<TerraformValue<string>>("created_after");
        set => SetArgument("created_after", value);
    }

    /// <summary>
    /// Restrict discovery to categories of table types. Currently view, materialized view, snapshot and non-biglake external tables are supported. Possible values: [&amp;quot;BIG_QUERY_COLLECTION_ALL_TYPES&amp;quot;, &amp;quot;BIG_QUERY_COLLECTION_ONLY_SUPPORTED_TYPES&amp;quot;]
    /// </summary>
    public TerraformValue<string>? TypeCollection
    {
        get => GetArgument<TerraformValue<string>>("type_collection");
        set => SetArgument("type_collection", value);
    }

    /// <summary>
    /// OrConditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrConditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlockOrConditionsBlock>? OrConditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlockOrConditionsBlock>>("or_conditions");
        set => SetArgument("or_conditions", value);
    }

    /// <summary>
    /// Types block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Types block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlockTypesBlock>? Types
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlockTypesBlock>>("types");
        set => SetArgument("types", value);
    }

}

/// <summary>
/// Block type for or_conditions in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlockOrConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "or_conditions";

    /// <summary>
    /// Duration format. The minimum age a table must have before Cloud DLP can profile it. Value greater than 1.
    /// </summary>
    public TerraformValue<string>? MinAge
    {
        get => GetArgument<TerraformValue<string>>("min_age");
        set => SetArgument("min_age", value);
    }

    /// <summary>
    /// Minimum number of rows that should be present before Cloud DLP profiles as a table.
    /// </summary>
    public TerraformValue<double>? MinRowCount
    {
        get => GetArgument<TerraformValue<double>>("min_row_count");
        set => SetArgument("min_row_count", value);
    }

}

/// <summary>
/// Block type for types in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockConditionsBlockTypesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "types";

    /// <summary>
    /// A set of BiqQuery table types Possible values: [&amp;quot;BIG_QUERY_TABLE_TYPE_TABLE&amp;quot;, &amp;quot;BIG_QUERY_TABLE_TYPE_EXTERNAL_BIG_LAKE&amp;quot;]
    /// </summary>
    public TerraformList<string>? Types
    {
        get => GetArgument<TerraformList<string>>("types");
        set => SetArgument("types", value);
    }

}

/// <summary>
/// Block type for disabled in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockDisabledBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disabled";

}

/// <summary>
/// Block type for filter in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// OtherTables block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OtherTables block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockOtherTablesBlock>? OtherTables
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockOtherTablesBlock>>("other_tables");
        set => SetArgument("other_tables", value);
    }

    /// <summary>
    /// TableReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TableReference block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTableReferenceBlock>? TableReference
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTableReferenceBlock>>("table_reference");
        set => SetArgument("table_reference", value);
    }

    /// <summary>
    /// Tables block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Tables block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlock>? Tables
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlock>>("tables");
        set => SetArgument("tables", value);
    }

}

/// <summary>
/// Block type for other_tables in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockOtherTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "other_tables";

}

/// <summary>
/// Block type for table_reference in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTableReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "table_reference";

    /// <summary>
    /// Dataset ID of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetRequiredArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
    }

    /// <summary>
    /// Name of the table.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableId is required")]
    public required TerraformValue<string> TableId
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_id");
        set => SetArgument("table_id", value);
    }

}

/// <summary>
/// Block type for tables in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "tables";

    /// <summary>
    /// IncludeRegexes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeRegexes block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlockIncludeRegexesBlock>? IncludeRegexes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlockIncludeRegexesBlock>>("include_regexes");
        set => SetArgument("include_regexes", value);
    }

}

/// <summary>
/// Block type for include_regexes in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlockIncludeRegexesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_regexes";

    /// <summary>
    /// Patterns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlockIncludeRegexesBlockPatternsBlock>? Patterns
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlockIncludeRegexesBlockPatternsBlock>>("patterns");
        set => SetArgument("patterns", value);
    }

}

/// <summary>
/// Block type for patterns in GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlockIncludeRegexesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockBigQueryTargetBlockFilterBlockTablesBlockIncludeRegexesBlockPatternsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "patterns";

    /// <summary>
    /// if unset, this property matches all datasets
    /// </summary>
    public TerraformValue<string>? DatasetIdRegex
    {
        get => GetArgument<TerraformValue<string>>("dataset_id_regex");
        set => SetArgument("dataset_id_regex", value);
    }

    /// <summary>
    /// For organizations, if unset, will match all projects. Has no effect for data profile configurations created within a project.
    /// </summary>
    public TerraformValue<string>? ProjectIdRegex
    {
        get => GetArgument<TerraformValue<string>>("project_id_regex");
        set => SetArgument("project_id_regex", value);
    }

    /// <summary>
    /// if unset, this property matches all tables
    /// </summary>
    public TerraformValue<string>? TableIdRegex
    {
        get => GetArgument<TerraformValue<string>>("table_id_regex");
        set => SetArgument("table_id_regex", value);
    }

}

/// <summary>
/// Block type for cloud_sql_target in GoogleDataLossPreventionDiscoveryConfigTargetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_sql_target";

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

    /// <summary>
    /// Disabled block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Disabled block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockDisabledBlock>? Disabled
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockDisabledBlock>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlock> Filter
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// GenerationCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerationCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlock>? GenerationCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlock>>("generation_cadence");
        set => SetArgument("generation_cadence", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// Database engines that should be profiled. Optional. Defaults to ALL_SUPPORTED_DATABASE_ENGINES if unspecified. Possible values: [&amp;quot;ALL_SUPPORTED_DATABASE_ENGINES&amp;quot;, &amp;quot;MYSQL&amp;quot;, &amp;quot;POSTGRES&amp;quot;]
    /// </summary>
    public TerraformList<string>? DatabaseEngines
    {
        get => GetArgument<TerraformList<string>>("database_engines");
        set => SetArgument("database_engines", value);
    }

    /// <summary>
    /// Data profiles will only be generated for the database resource types specified in this field. If not specified, defaults to [DATABASE_RESOURCE_TYPE_ALL_SUPPORTED_TYPES]. Possible values: [&amp;quot;DATABASE_RESOURCE_TYPE_ALL_SUPPORTED_TYPES&amp;quot;, &amp;quot;DATABASE_RESOURCE_TYPE_TABLE&amp;quot;]
    /// </summary>
    public TerraformList<string>? Types
    {
        get => GetArgument<TerraformList<string>>("types");
        set => SetArgument("types", value);
    }

}

/// <summary>
/// Block type for disabled in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockDisabledBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disabled";

}

/// <summary>
/// Block type for filter in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// Collection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Collection block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlock>? Collection
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlock>>("collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// DatabaseResourceReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DatabaseResourceReference block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockDatabaseResourceReferenceBlock>? DatabaseResourceReference
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockDatabaseResourceReferenceBlock>>("database_resource_reference");
        set => SetArgument("database_resource_reference", value);
    }

    /// <summary>
    /// Others block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Others block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockOthersBlock>? Others
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockOthersBlock>>("others");
        set => SetArgument("others", value);
    }

}

/// <summary>
/// Block type for collection in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collection";

    /// <summary>
    /// IncludeRegexes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeRegexes block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock>? IncludeRegexes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock>>("include_regexes");
        set => SetArgument("include_regexes", value);
    }

}

/// <summary>
/// Block type for include_regexes in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_regexes";

    /// <summary>
    /// Patterns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock>? Patterns
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock>>("patterns");
        set => SetArgument("patterns", value);
    }

}

/// <summary>
/// Block type for patterns in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "patterns";

    /// <summary>
    /// Regex to test the database name against. If empty, all databases match.
    /// </summary>
    public TerraformValue<string>? DatabaseRegex
    {
        get => GetArgument<TerraformValue<string>>("database_regex");
        set => SetArgument("database_regex", value);
    }

    /// <summary>
    /// Regex to test the database resource&#39;s name against. An example of a database resource name is a table&#39;s name. Other database resource names like view names could be included in the future. If empty, all database resources match.&#39;
    /// </summary>
    public TerraformValue<string>? DatabaseResourceNameRegex
    {
        get => GetArgument<TerraformValue<string>>("database_resource_name_regex");
        set => SetArgument("database_resource_name_regex", value);
    }

    /// <summary>
    /// Regex to test the instance name against. If empty, all instances match.
    /// </summary>
    public TerraformValue<string>? InstanceRegex
    {
        get => GetArgument<TerraformValue<string>>("instance_regex");
        set => SetArgument("instance_regex", value);
    }

    /// <summary>
    /// For organizations, if unset, will match all projects. Has no effect for data profile configurations created within a project.
    /// </summary>
    public TerraformValue<string>? ProjectIdRegex
    {
        get => GetArgument<TerraformValue<string>>("project_id_regex");
        set => SetArgument("project_id_regex", value);
    }

}

/// <summary>
/// Block type for database_resource_reference in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockDatabaseResourceReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "database_resource_reference";

    /// <summary>
    /// Required. Name of a database within the instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Database is required")]
    public required TerraformValue<string> Database
    {
        get => GetRequiredArgument<TerraformValue<string>>("database");
        set => SetArgument("database", value);
    }

    /// <summary>
    /// Required. Name of a database resource, for example, a table within the database.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseResource is required")]
    public required TerraformValue<string> DatabaseResource
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_resource");
        set => SetArgument("database_resource", value);
    }

    /// <summary>
    /// Required. The instance where this resource is located. For example: Cloud SQL instance ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    public required TerraformValue<string> Instance
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance");
        set => SetArgument("instance", value);
    }

    /// <summary>
    /// Required. If within a project-level config, then this must match the config&#39;s project ID.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectId is required")]
    public required TerraformValue<string> ProjectId
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}

/// <summary>
/// Block type for others in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockFilterBlockOthersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "others";

}

/// <summary>
/// Block type for generation_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generation_cadence";

    /// <summary>
    /// Data changes (non-schema changes) in Cloud SQL tables can&#39;t trigger reprofiling. If you set this field, profiles are refreshed at this frequency regardless of whether the underlying tables have changes. Defaults to never. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RefreshFrequency
    {
        get => GetArgument<TerraformValue<string>>("refresh_frequency");
        set => SetArgument("refresh_frequency", value);
    }

    /// <summary>
    /// InspectTemplateModifiedCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectTemplateModifiedCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock>? InspectTemplateModifiedCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock>>("inspect_template_modified_cadence");
        set => SetArgument("inspect_template_modified_cadence", value);
    }

    /// <summary>
    /// SchemaModifiedCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SchemaModifiedCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlockSchemaModifiedCadenceBlock>? SchemaModifiedCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlockSchemaModifiedCadenceBlock>>("schema_modified_cadence");
        set => SetArgument("schema_modified_cadence", value);
    }

}

/// <summary>
/// Block type for inspect_template_modified_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inspect_template_modified_cadence";

    /// <summary>
    /// How frequently data profiles can be updated when the template is modified. Defaults to never. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Frequency is required")]
    public required TerraformValue<string> Frequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

}

/// <summary>
/// Block type for schema_modified_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudSqlTargetBlockGenerationCadenceBlockSchemaModifiedCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "schema_modified_cadence";

    /// <summary>
    /// Frequency to regenerate data profiles when the schema is modified. Defaults to monthly. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

    /// <summary>
    /// The types of schema modifications to consider. Defaults to NEW_COLUMNS. Possible values: [&amp;quot;NEW_COLUMNS&amp;quot;, &amp;quot;REMOVED_COLUMNS&amp;quot;]
    /// </summary>
    public TerraformList<string>? Types
    {
        get => GetArgument<TerraformList<string>>("types");
        set => SetArgument("types", value);
    }

}

/// <summary>
/// Block type for cloud_storage_target in GoogleDataLossPreventionDiscoveryConfigTargetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_target";

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

    /// <summary>
    /// Disabled block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Disabled block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockDisabledBlock>? Disabled
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockDisabledBlock>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlock> Filter
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// GenerationCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerationCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockGenerationCadenceBlock>? GenerationCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockGenerationCadenceBlock>>("generation_cadence");
        set => SetArgument("generation_cadence", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// File store must have been created after this date. Used to avoid backfilling. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format with nanosecond resolution and upto nine fractional digits.
    /// </summary>
    public TerraformValue<string>? CreatedAfter
    {
        get => GetArgument<TerraformValue<string>>("created_after");
        set => SetArgument("created_after", value);
    }

    /// <summary>
    /// Duration format. Minimum age a file store must have. If set, the value must be 1 hour or greater.
    /// </summary>
    public TerraformValue<string>? MinAge
    {
        get => GetArgument<TerraformValue<string>>("min_age");
        set => SetArgument("min_age", value);
    }

    /// <summary>
    /// CloudStorageConditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorageConditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockConditionsBlockCloudStorageConditionsBlock>? CloudStorageConditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockConditionsBlockCloudStorageConditionsBlock>>("cloud_storage_conditions");
        set => SetArgument("cloud_storage_conditions", value);
    }

}

/// <summary>
/// Block type for cloud_storage_conditions in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockConditionsBlockCloudStorageConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_conditions";

    /// <summary>
    /// Only objects with the specified attributes will be scanned. Defaults to [ALL_SUPPORTED_BUCKETS] if unset. Possible values: [&amp;quot;ALL_SUPPORTED_BUCKETS&amp;quot;, &amp;quot;AUTOCLASS_DISABLED&amp;quot;, &amp;quot;AUTOCLASS_ENABLED&amp;quot;]
    /// </summary>
    public TerraformList<string>? IncludedBucketAttributes
    {
        get => GetArgument<TerraformList<string>>("included_bucket_attributes");
        set => SetArgument("included_bucket_attributes", value);
    }

    /// <summary>
    /// Only objects with the specified attributes will be scanned. If an object has one of the specified attributes but is inside an excluded bucket, it will not be scanned. Defaults to [ALL_SUPPORTED_OBJECTS]. A profile will be created even if no objects match the included_object_attributes. Possible values: [&amp;quot;ALL_SUPPORTED_OBJECTS&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;NEARLINE&amp;quot;, &amp;quot;COLDLINE&amp;quot;, &amp;quot;ARCHIVE&amp;quot;, &amp;quot;REGIONAL&amp;quot;, &amp;quot;MULTI_REGIONAL&amp;quot;, &amp;quot;DURABLE_REDUCED_AVAILABILITY&amp;quot;]
    /// </summary>
    public TerraformList<string>? IncludedObjectAttributes
    {
        get => GetArgument<TerraformList<string>>("included_object_attributes");
        set => SetArgument("included_object_attributes", value);
    }

}

/// <summary>
/// Block type for disabled in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockDisabledBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disabled";

}

/// <summary>
/// Block type for filter in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// CloudStorageResourceReference block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorageResourceReference block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCloudStorageResourceReferenceBlock>? CloudStorageResourceReference
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCloudStorageResourceReferenceBlock>>("cloud_storage_resource_reference");
        set => SetArgument("cloud_storage_resource_reference", value);
    }

    /// <summary>
    /// Collection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Collection block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlock>? Collection
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlock>>("collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// Others block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Others block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockOthersBlock>? Others
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockOthersBlock>>("others");
        set => SetArgument("others", value);
    }

}

/// <summary>
/// Block type for cloud_storage_resource_reference in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCloudStorageResourceReferenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_resource_reference";

    /// <summary>
    /// The bucket to scan.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// If within a project-level config, then this must match the config&#39;s project id.
    /// </summary>
    public TerraformValue<string>? ProjectId
    {
        get => GetArgument<TerraformValue<string>>("project_id");
        set => SetArgument("project_id", value);
    }

}

/// <summary>
/// Block type for collection in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collection";

    /// <summary>
    /// IncludeRegexes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeRegexes block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock>? IncludeRegexes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock>>("include_regexes");
        set => SetArgument("include_regexes", value);
    }

}

/// <summary>
/// Block type for include_regexes in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_regexes";

    /// <summary>
    /// Patterns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock>? Patterns
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock>>("patterns");
        set => SetArgument("patterns", value);
    }

}

/// <summary>
/// Block type for patterns in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "patterns";

    /// <summary>
    /// CloudStorageRegex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CloudStorageRegex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockCloudStorageRegexBlock>? CloudStorageRegex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockCloudStorageRegexBlock>>("cloud_storage_regex");
        set => SetArgument("cloud_storage_regex", value);
    }

}

/// <summary>
/// Block type for cloud_storage_regex in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockCloudStorageRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cloud_storage_regex";

    /// <summary>
    /// Regex to test the bucket name against. If empty, all buckets match. Example: &amp;quot;marketing2021&amp;quot; or &amp;quot;(marketing)\d{4}&amp;quot; will both match the bucket gs://marketing2021
    /// </summary>
    public TerraformValue<string>? BucketNameRegex
    {
        get => GetArgument<TerraformValue<string>>("bucket_name_regex");
        set => SetArgument("bucket_name_regex", value);
    }

    /// <summary>
    /// For organizations, if unset, will match all projects.
    /// </summary>
    public TerraformValue<string>? ProjectIdRegex
    {
        get => GetArgument<TerraformValue<string>>("project_id_regex");
        set => SetArgument("project_id_regex", value);
    }

}

/// <summary>
/// Block type for others in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockFilterBlockOthersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "others";

}

/// <summary>
/// Block type for generation_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockGenerationCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generation_cadence";

    /// <summary>
    /// Data changes in Cloud Storage can&#39;t trigger reprofiling. If you set this field, profiles are refreshed at this frequency regardless of whether the underlying buckets have changes. Defaults to never. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RefreshFrequency
    {
        get => GetArgument<TerraformValue<string>>("refresh_frequency");
        set => SetArgument("refresh_frequency", value);
    }

    /// <summary>
    /// InspectTemplateModifiedCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectTemplateModifiedCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock>? InspectTemplateModifiedCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock>>("inspect_template_modified_cadence");
        set => SetArgument("inspect_template_modified_cadence", value);
    }

}

/// <summary>
/// Block type for inspect_template_modified_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockGenerationCadenceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockCloudStorageTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inspect_template_modified_cadence";

    /// <summary>
    /// How frequently data profiles can be updated when the template is modified. Defaults to never. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

}

/// <summary>
/// Block type for other_cloud_target in GoogleDataLossPreventionDiscoveryConfigTargetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "other_cloud_target";

    /// <summary>
    /// Conditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Conditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockConditionsBlock>? Conditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockConditionsBlock>>("conditions");
        set => SetArgument("conditions", value);
    }

    /// <summary>
    /// DataSourceTypeAttribute block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DataSourceTypeAttribute block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockDataSourceTypeAttributeBlock>? DataSourceTypeAttribute
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockDataSourceTypeAttributeBlock>>("data_source_type");
        set => SetArgument("data_source_type", value);
    }

    /// <summary>
    /// Disabled block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Disabled block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockDisabledBlock>? Disabled
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockDisabledBlock>>("disabled");
        set => SetArgument("disabled", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filter block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public required TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlock> Filter
    {
        get => GetRequiredArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// GenerationCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GenerationCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockGenerationCadenceBlock>? GenerationCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockGenerationCadenceBlock>>("generation_cadence");
        set => SetArgument("generation_cadence", value);
    }

}

/// <summary>
/// Block type for conditions in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "conditions";

    /// <summary>
    /// Duration format.  Minimum age a resource must be before a profile can be generated. Value must be 1 hour or greater. Minimum age is not supported for Azure Blob Storage containers.
    /// </summary>
    public TerraformValue<string>? MinAge
    {
        get => GetArgument<TerraformValue<string>>("min_age");
        set => SetArgument("min_age", value);
    }

    /// <summary>
    /// AmazonS3BucketConditions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonS3BucketConditions block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockConditionsBlockAmazonS3BucketConditionsBlock>? AmazonS3BucketConditions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockConditionsBlockAmazonS3BucketConditionsBlock>>("amazon_s3_bucket_conditions");
        set => SetArgument("amazon_s3_bucket_conditions", value);
    }

}

/// <summary>
/// Block type for amazon_s3_bucket_conditions in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockConditionsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockConditionsBlockAmazonS3BucketConditionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_s3_bucket_conditions";

    /// <summary>
    /// Bucket types that should be profiled. Optional. Defaults to TYPE_ALL_SUPPORTED if unspecified. Possible values: [&amp;quot;TYPE_ALL_SUPPORTED&amp;quot;, &amp;quot;TYPE_GENERAL_PURPOSE&amp;quot;]
    /// </summary>
    public TerraformList<string>? BucketTypes
    {
        get => GetArgument<TerraformList<string>>("bucket_types");
        set => SetArgument("bucket_types", value);
    }

    /// <summary>
    /// Object classes that should be profiled. Optional. Defaults to ALL_SUPPORTED_CLASSES if unspecified. Possible values: [&amp;quot;ALL_SUPPORTED_CLASSES&amp;quot;, &amp;quot;STANDARD&amp;quot;, &amp;quot;STANDARD_INFREQUENT_ACCESS&amp;quot;, &amp;quot;GLACIER_INSTANT_RETRIEVAL&amp;quot;, &amp;quot;INTELLIGENT_TIERING&amp;quot;]
    /// </summary>
    public TerraformList<string>? ObjectStorageClasses
    {
        get => GetArgument<TerraformList<string>>("object_storage_classes");
        set => SetArgument("object_storage_classes", value);
    }

}

/// <summary>
/// Block type for data_source_type in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockDataSourceTypeAttributeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_source_type";

    /// <summary>
    /// The data_source attribute.
    /// </summary>
    public TerraformValue<string>? DataSource
    {
        get => GetArgument<TerraformValue<string>>("data_source");
        set => SetArgument("data_source", value);
    }

}

/// <summary>
/// Block type for disabled in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockDisabledBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "disabled";

}

/// <summary>
/// Block type for filter in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// Collection block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Collection block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlock>? Collection
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlock>>("collection");
        set => SetArgument("collection", value);
    }

    /// <summary>
    /// Others block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Others block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockOthersBlock>? Others
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockOthersBlock>>("others");
        set => SetArgument("others", value);
    }

    /// <summary>
    /// SingleResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SingleResource block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlock>? SingleResource
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlock>>("single_resource");
        set => SetArgument("single_resource", value);
    }

}

/// <summary>
/// Block type for collection in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "collection";

    /// <summary>
    /// IncludeRegexes block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeRegexes block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock>? IncludeRegexes
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock>>("include_regexes");
        set => SetArgument("include_regexes", value);
    }

}

/// <summary>
/// Block type for include_regexes in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "include_regexes";

    /// <summary>
    /// Patterns block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock>? Patterns
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock>>("patterns");
        set => SetArgument("patterns", value);
    }

}

/// <summary>
/// Block type for patterns in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "patterns";

    /// <summary>
    /// AmazonS3BucketRegex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonS3BucketRegex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockAmazonS3BucketRegexBlock>? AmazonS3BucketRegex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockAmazonS3BucketRegexBlock>>("amazon_s3_bucket_regex");
        set => SetArgument("amazon_s3_bucket_regex", value);
    }

}

/// <summary>
/// Block type for amazon_s3_bucket_regex in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockAmazonS3BucketRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_s3_bucket_regex";

    /// <summary>
    /// Regex to test the bucket name against. If empty, all buckets match.
    /// </summary>
    public TerraformValue<string>? BucketNameRegex
    {
        get => GetArgument<TerraformValue<string>>("bucket_name_regex");
        set => SetArgument("bucket_name_regex", value);
    }

    /// <summary>
    /// AwsAccountRegex block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsAccountRegex block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockAmazonS3BucketRegexBlockAwsAccountRegexBlock>? AwsAccountRegex
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockAmazonS3BucketRegexBlockAwsAccountRegexBlock>>("aws_account_regex");
        set => SetArgument("aws_account_regex", value);
    }

}

/// <summary>
/// Block type for aws_account_regex in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockAmazonS3BucketRegexBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockCollectionBlockIncludeRegexesBlockPatternsBlockAmazonS3BucketRegexBlockAwsAccountRegexBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_account_regex";

    /// <summary>
    /// Regex to test the AWS account ID against. If empty, all accounts match. Example: arn:aws:organizations::123:account/o-b2c3d4/345
    /// </summary>
    public TerraformValue<string>? AccountIdRegex
    {
        get => GetArgument<TerraformValue<string>>("account_id_regex");
        set => SetArgument("account_id_regex", value);
    }

}

/// <summary>
/// Block type for others in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockOthersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "others";

}

/// <summary>
/// Block type for single_resource in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "single_resource";

    /// <summary>
    /// AmazonS3Bucket block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AmazonS3Bucket block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlockAmazonS3BucketBlock>? AmazonS3Bucket
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlockAmazonS3BucketBlock>>("amazon_s3_bucket");
        set => SetArgument("amazon_s3_bucket", value);
    }

}

/// <summary>
/// Block type for amazon_s3_bucket in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlockAmazonS3BucketBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amazon_s3_bucket";

    /// <summary>
    /// The bucket name.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// AwsAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AwsAccount block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlockAmazonS3BucketBlockAwsAccountBlock>? AwsAccount
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlockAmazonS3BucketBlockAwsAccountBlock>>("aws_account");
        set => SetArgument("aws_account", value);
    }

}

/// <summary>
/// Block type for aws_account in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlockAmazonS3BucketBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockFilterBlockSingleResourceBlockAmazonS3BucketBlockAwsAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aws_account";

    /// <summary>
    /// AWS account ID.
    /// </summary>
    public TerraformValue<string>? AccountId
    {
        get => GetArgument<TerraformValue<string>>("account_id");
        set => SetArgument("account_id", value);
    }

}

/// <summary>
/// Block type for generation_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockGenerationCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "generation_cadence";

    /// <summary>
    /// Frequency to update profiles regardless of whether the underlying resource has changes. Defaults to never. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? RefreshFrequency
    {
        get => GetArgument<TerraformValue<string>>("refresh_frequency");
        set => SetArgument("refresh_frequency", value);
    }

    /// <summary>
    /// InspectTemplateModifiedCadence block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InspectTemplateModifiedCadence block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock>? InspectTemplateModifiedCadence
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock>>("inspect_template_modified_cadence");
        set => SetArgument("inspect_template_modified_cadence", value);
    }

}

/// <summary>
/// Block type for inspect_template_modified_cadence in GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockGenerationCadenceBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockOtherCloudTargetBlockGenerationCadenceBlockInspectTemplateModifiedCadenceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inspect_template_modified_cadence";

    /// <summary>
    /// How frequently data profiles can be updated when the template is modified. Defaults to never. Possible values: [&amp;quot;UPDATE_FREQUENCY_NEVER&amp;quot;, &amp;quot;UPDATE_FREQUENCY_DAILY&amp;quot;, &amp;quot;UPDATE_FREQUENCY_MONTHLY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Frequency
    {
        get => GetArgument<TerraformValue<string>>("frequency");
        set => SetArgument("frequency", value);
    }

}

/// <summary>
/// Block type for secrets_target in GoogleDataLossPreventionDiscoveryConfigTargetsBlock.
/// Nesting mode: list
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTargetsBlockSecretsTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "secrets_target";

}


/// <summary>
/// Block type for timeouts in GoogleDataLossPreventionDiscoveryConfig.
/// Nesting mode: single
/// </summary>
public class GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock : TerraformBlock
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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_data_loss_prevention_discovery_config Terraform resource.
/// Manages a google_data_loss_prevention_discovery_config resource.
/// </summary>
public partial class GoogleDataLossPreventionDiscoveryConfig(string name) : TerraformResource("google_data_loss_prevention_discovery_config", name)
{
    /// <summary>
    /// Display Name (max 1000 Chars)
    /// </summary>
    public TerraformValue<string>? DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Detection logic for profile generation
    /// </summary>
    public TerraformList<string>? InspectTemplates
    {
        get => GetArgument<TerraformList<string>>("inspect_templates");
        set => SetArgument("inspect_templates", value);
    }

    /// <summary>
    /// Location to create the discovery config in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The parent of the discovery config in any of the following formats:
    /// 
    /// * &#39;projects/{{project}}/locations/{{location}}&#39;
    /// * &#39;organizations/{{organization_id}}/locations/{{location}}&#39;
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// Required. A status for this configuration Possible values: [&amp;quot;RUNNING&amp;quot;, &amp;quot;PAUSED&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// Output only. The creation timestamp of a DiscoveryConfig.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Output only. A stream of errors encountered when the config was activated. Repeated errors may result in the config automatically being paused. Output only field. Will return the last 100 errors. Whenever the config is modified this list will be cleared.
    /// </summary>
    public TerraformList<TerraformMap<object>> Errors
        => AsReference("errors");

    /// <summary>
    /// Output only. The timestamp of the last time this config was executed
    /// </summary>
    public TerraformValue<string> LastRunTime
        => AsReference("last_run_time");

    /// <summary>
    /// Unique resource name for the DiscoveryConfig, assigned by the service when the DiscoveryConfig is created.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Output only. The last update timestamp of a DiscoveryConfig.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// Actions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlock>? Actions
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// OrgConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrgConfig block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock>? OrgConfig
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigOrgConfigBlock>>("org_config");
        set => SetArgument("org_config", value);
    }

    /// <summary>
    /// OtherCloudStartingLocation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OtherCloudStartingLocation block(s) allowed")]
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock>? OtherCloudStartingLocation
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigOtherCloudStartingLocationBlock>>("other_cloud_starting_location");
        set => SetArgument("other_cloud_starting_location", value);
    }

    /// <summary>
    /// Targets block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlock>? Targets
    {
        get => GetArgument<TerraformList<GoogleDataLossPreventionDiscoveryConfigTargetsBlock>>("targets");
        set => SetArgument("targets", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleDataLossPreventionDiscoveryConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
