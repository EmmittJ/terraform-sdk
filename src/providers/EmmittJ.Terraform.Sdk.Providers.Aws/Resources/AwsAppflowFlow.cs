using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for destination_flow_config in AwsAppflowFlow.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_flow_config";

    /// <summary>
    /// The api_version attribute.
    /// </summary>
    public TerraformValue<string>? ApiVersion
    {
        get => GetArgument<TerraformValue<string>>("api_version");
        set => SetArgument("api_version", value);
    }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectorProfileName
    {
        get => GetArgument<TerraformValue<string>>("connector_profile_name");
        set => SetArgument("connector_profile_name", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformValue<string> ConnectorType
    {
        get => GetRequiredArgument<TerraformValue<string>>("connector_type");
        set => SetArgument("connector_type", value);
    }

    /// <summary>
    /// DestinationConnectorProperties block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationConnectorProperties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationConnectorProperties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DestinationConnectorProperties block(s) allowed")]
    public required TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock> DestinationConnectorProperties
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock>>("destination_connector_properties");
        set => SetArgument("destination_connector_properties", value);
    }

}

/// <summary>
/// Block type for destination_connector_properties in AwsAppflowFlowDestinationFlowConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination_connector_properties";

    /// <summary>
    /// CustomConnector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomConnector block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomConnectorBlock>? CustomConnector
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomConnectorBlock>>("custom_connector");
        set => SetArgument("custom_connector", value);
    }

    /// <summary>
    /// CustomerProfiles block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerProfiles block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomerProfilesBlock>? CustomerProfiles
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomerProfilesBlock>>("customer_profiles");
        set => SetArgument("customer_profiles", value);
    }

    /// <summary>
    /// EventBridge block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 EventBridge block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockEventBridgeBlock>? EventBridge
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockEventBridgeBlock>>("event_bridge");
        set => SetArgument("event_bridge", value);
    }

    /// <summary>
    /// Honeycode block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Honeycode block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockHoneycodeBlock>? Honeycode
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockHoneycodeBlock>>("honeycode");
        set => SetArgument("honeycode", value);
    }

    /// <summary>
    /// LookoutMetrics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LookoutMetrics block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockLookoutMetricsBlock>? LookoutMetrics
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockLookoutMetricsBlock>>("lookout_metrics");
        set => SetArgument("lookout_metrics", value);
    }

    /// <summary>
    /// Marketo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketo block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockMarketoBlock>? Marketo
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockMarketoBlock>>("marketo");
        set => SetArgument("marketo", value);
    }

    /// <summary>
    /// Redshift block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Redshift block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockRedshiftBlock>? Redshift
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockRedshiftBlock>>("redshift");
        set => SetArgument("redshift", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// Salesforce block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Salesforce block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSalesforceBlock>? Salesforce
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSalesforceBlock>>("salesforce");
        set => SetArgument("salesforce", value);
    }

    /// <summary>
    /// SapoData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SapoData block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlock>? SapoData
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlock>>("sapo_data");
        set => SetArgument("sapo_data", value);
    }

    /// <summary>
    /// Snowflake block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Snowflake block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSnowflakeBlock>? Snowflake
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSnowflakeBlock>>("snowflake");
        set => SetArgument("snowflake", value);
    }

    /// <summary>
    /// Upsolver block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Upsolver block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlock>? Upsolver
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlock>>("upsolver");
        set => SetArgument("upsolver", value);
    }

    /// <summary>
    /// Zendesk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zendesk block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockZendeskBlock>? Zendesk
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockZendeskBlock>>("zendesk");
        set => SetArgument("zendesk", value);
    }

}

/// <summary>
/// Block type for custom_connector in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_connector";

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    public TerraformMap<string>? CustomProperties
    {
        get => GetArgument<TerraformMap<string>>("custom_properties");
        set => SetArgument("custom_properties", value);
    }

    /// <summary>
    /// The entity_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityName is required")]
    public required TerraformValue<string> EntityName
    {
        get => GetRequiredArgument<TerraformValue<string>>("entity_name");
        set => SetArgument("entity_name", value);
    }

    /// <summary>
    /// The id_field_names attribute.
    /// </summary>
    public TerraformList<string>? IdFieldNames
    {
        get => GetArgument<TerraformList<string>>("id_field_names");
        set => SetArgument("id_field_names", value);
    }

    /// <summary>
    /// The write_operation_type attribute.
    /// </summary>
    public TerraformValue<string>? WriteOperationType
    {
        get => GetArgument<TerraformValue<string>>("write_operation_type");
        set => SetArgument("write_operation_type", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomConnectorBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomConnectorBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomConnectorBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomConnectorBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}

/// <summary>
/// Block type for customer_profiles in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockCustomerProfilesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_profiles";

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The object_type_name attribute.
    /// </summary>
    public TerraformValue<string>? ObjectTypeName
    {
        get => GetArgument<TerraformValue<string>>("object_type_name");
        set => SetArgument("object_type_name", value);
    }

}

/// <summary>
/// Block type for event_bridge in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockEventBridgeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "event_bridge";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockEventBridgeBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockEventBridgeBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockEventBridgeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockEventBridgeBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}

/// <summary>
/// Block type for honeycode in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockHoneycodeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "honeycode";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockHoneycodeBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockHoneycodeBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockHoneycodeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockHoneycodeBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}

/// <summary>
/// Block type for lookout_metrics in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockLookoutMetricsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "lookout_metrics";

}

/// <summary>
/// Block type for marketo in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockMarketoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "marketo";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockMarketoBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockMarketoBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockMarketoBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockMarketoBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}

/// <summary>
/// Block type for redshift in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockRedshiftBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "redshift";

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The intermediate_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntermediateBucketName is required")]
    public required TerraformValue<string> IntermediateBucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("intermediate_bucket_name");
        set => SetArgument("intermediate_bucket_name", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockRedshiftBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockRedshiftBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockRedshiftBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockRedshiftBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}

/// <summary>
/// Block type for s3 in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string> BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix") ?? AsReference("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// S3OutputFormatConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3OutputFormatConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlock>? S3OutputFormatConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlock>>("s3_output_format_config");
        set => SetArgument("s3_output_format_config", value);
    }

}

/// <summary>
/// Block type for s3_output_format_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3Block.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_output_format_config";

    /// <summary>
    /// The file_type attribute.
    /// </summary>
    public TerraformValue<string>? FileType
    {
        get => GetArgument<TerraformValue<string>>("file_type");
        set => SetArgument("file_type", value);
    }

    /// <summary>
    /// The preserve_source_data_typing attribute.
    /// </summary>
    public TerraformValue<bool> PreserveSourceDataTyping
    {
        get => GetArgument<TerraformValue<bool>>("preserve_source_data_typing") ?? AsReference("preserve_source_data_typing");
        set => SetArgument("preserve_source_data_typing", value);
    }

    /// <summary>
    /// AggregationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AggregationConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlockAggregationConfigBlock>? AggregationConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlockAggregationConfigBlock>>("aggregation_config");
        set => SetArgument("aggregation_config", value);
    }

    /// <summary>
    /// PrefixConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrefixConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlockPrefixConfigBlock>? PrefixConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlockPrefixConfigBlock>>("prefix_config");
        set => SetArgument("prefix_config", value);
    }

}

/// <summary>
/// Block type for aggregation_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlockAggregationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aggregation_config";

    /// <summary>
    /// The aggregation_type attribute.
    /// </summary>
    public TerraformValue<string> AggregationType
    {
        get => GetArgument<TerraformValue<string>>("aggregation_type") ?? AsReference("aggregation_type");
        set => SetArgument("aggregation_type", value);
    }

    /// <summary>
    /// The target_file_size attribute.
    /// </summary>
    public TerraformValue<double> TargetFileSize
    {
        get => GetArgument<TerraformValue<double>>("target_file_size") ?? AsReference("target_file_size");
        set => SetArgument("target_file_size", value);
    }

}

/// <summary>
/// Block type for prefix_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockS3BlockS3OutputFormatConfigBlockPrefixConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prefix_config";

    /// <summary>
    /// The prefix_format attribute.
    /// </summary>
    public TerraformValue<string>? PrefixFormat
    {
        get => GetArgument<TerraformValue<string>>("prefix_format");
        set => SetArgument("prefix_format", value);
    }

    /// <summary>
    /// The prefix_hierarchy attribute.
    /// </summary>
    public TerraformList<string> PrefixHierarchy
    {
        get => GetArgument<TerraformList<string>>("prefix_hierarchy") ?? AsReference("prefix_hierarchy");
        set => SetArgument("prefix_hierarchy", value);
    }

    /// <summary>
    /// The prefix_type attribute.
    /// </summary>
    public TerraformValue<string>? PrefixType
    {
        get => GetArgument<TerraformValue<string>>("prefix_type");
        set => SetArgument("prefix_type", value);
    }

}

/// <summary>
/// Block type for salesforce in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSalesforceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "salesforce";

    /// <summary>
    /// The data_transfer_api attribute.
    /// </summary>
    public TerraformValue<string>? DataTransferApi
    {
        get => GetArgument<TerraformValue<string>>("data_transfer_api");
        set => SetArgument("data_transfer_api", value);
    }

    /// <summary>
    /// The id_field_names attribute.
    /// </summary>
    public TerraformList<string>? IdFieldNames
    {
        get => GetArgument<TerraformList<string>>("id_field_names");
        set => SetArgument("id_field_names", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// The write_operation_type attribute.
    /// </summary>
    public TerraformValue<string>? WriteOperationType
    {
        get => GetArgument<TerraformValue<string>>("write_operation_type");
        set => SetArgument("write_operation_type", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSalesforceBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSalesforceBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSalesforceBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSalesforceBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}

/// <summary>
/// Block type for sapo_data in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sapo_data";

    /// <summary>
    /// The id_field_names attribute.
    /// </summary>
    public TerraformList<string>? IdFieldNames
    {
        get => GetArgument<TerraformList<string>>("id_field_names");
        set => SetArgument("id_field_names", value);
    }

    /// <summary>
    /// The object_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectPath is required")]
    public required TerraformValue<string> ObjectPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("object_path");
        set => SetArgument("object_path", value);
    }

    /// <summary>
    /// The write_operation_type attribute.
    /// </summary>
    public TerraformValue<string>? WriteOperationType
    {
        get => GetArgument<TerraformValue<string>>("write_operation_type");
        set => SetArgument("write_operation_type", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

    /// <summary>
    /// SuccessResponseHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SuccessResponseHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlockSuccessResponseHandlingConfigBlock>? SuccessResponseHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlockSuccessResponseHandlingConfigBlock>>("success_response_handling_config");
        set => SetArgument("success_response_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}

/// <summary>
/// Block type for success_response_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSapoDataBlockSuccessResponseHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "success_response_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

}

/// <summary>
/// Block type for snowflake in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSnowflakeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snowflake";

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The intermediate_bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IntermediateBucketName is required")]
    public required TerraformValue<string> IntermediateBucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("intermediate_bucket_name");
        set => SetArgument("intermediate_bucket_name", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSnowflakeBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSnowflakeBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSnowflakeBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockSnowflakeBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}

/// <summary>
/// Block type for upsolver in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "upsolver";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// S3OutputFormatConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3OutputFormatConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 S3OutputFormatConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3OutputFormatConfig block(s) allowed")]
    public required TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlock> S3OutputFormatConfig
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlock>>("s3_output_format_config");
        set => SetArgument("s3_output_format_config", value);
    }

}

/// <summary>
/// Block type for s3_output_format_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_output_format_config";

    /// <summary>
    /// The file_type attribute.
    /// </summary>
    public TerraformValue<string>? FileType
    {
        get => GetArgument<TerraformValue<string>>("file_type");
        set => SetArgument("file_type", value);
    }

    /// <summary>
    /// AggregationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AggregationConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlockAggregationConfigBlock>? AggregationConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlockAggregationConfigBlock>>("aggregation_config");
        set => SetArgument("aggregation_config", value);
    }

    /// <summary>
    /// PrefixConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PrefixConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PrefixConfig block(s) allowed")]
    public required TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlockPrefixConfigBlock> PrefixConfig
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlockPrefixConfigBlock>>("prefix_config");
        set => SetArgument("prefix_config", value);
    }

}

/// <summary>
/// Block type for aggregation_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlockAggregationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "aggregation_config";

    /// <summary>
    /// The aggregation_type attribute.
    /// </summary>
    public TerraformValue<string>? AggregationType
    {
        get => GetArgument<TerraformValue<string>>("aggregation_type");
        set => SetArgument("aggregation_type", value);
    }

}

/// <summary>
/// Block type for prefix_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockUpsolverBlockS3OutputFormatConfigBlockPrefixConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "prefix_config";

    /// <summary>
    /// The prefix_format attribute.
    /// </summary>
    public TerraformValue<string>? PrefixFormat
    {
        get => GetArgument<TerraformValue<string>>("prefix_format");
        set => SetArgument("prefix_format", value);
    }

    /// <summary>
    /// The prefix_hierarchy attribute.
    /// </summary>
    public TerraformList<string> PrefixHierarchy
    {
        get => GetArgument<TerraformList<string>>("prefix_hierarchy") ?? AsReference("prefix_hierarchy");
        set => SetArgument("prefix_hierarchy", value);
    }

    /// <summary>
    /// The prefix_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrefixType is required")]
    public required TerraformValue<string> PrefixType
    {
        get => GetRequiredArgument<TerraformValue<string>>("prefix_type");
        set => SetArgument("prefix_type", value);
    }

}

/// <summary>
/// Block type for zendesk in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockZendeskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zendesk";

    /// <summary>
    /// The id_field_names attribute.
    /// </summary>
    public TerraformList<string>? IdFieldNames
    {
        get => GetArgument<TerraformList<string>>("id_field_names");
        set => SetArgument("id_field_names", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

    /// <summary>
    /// The write_operation_type attribute.
    /// </summary>
    public TerraformValue<string>? WriteOperationType
    {
        get => GetArgument<TerraformValue<string>>("write_operation_type");
        set => SetArgument("write_operation_type", value);
    }

    /// <summary>
    /// ErrorHandlingConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ErrorHandlingConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockZendeskBlockErrorHandlingConfigBlock>? ErrorHandlingConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockZendeskBlockErrorHandlingConfigBlock>>("error_handling_config");
        set => SetArgument("error_handling_config", value);
    }

}

/// <summary>
/// Block type for error_handling_config in AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockZendeskBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowDestinationFlowConfigBlockDestinationConnectorPropertiesBlockZendeskBlockErrorHandlingConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "error_handling_config";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformValue<string>? BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    public TerraformValue<string>? BucketPrefix
    {
        get => GetArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// The fail_on_first_destination_error attribute.
    /// </summary>
    public TerraformValue<bool>? FailOnFirstDestinationError
    {
        get => GetArgument<TerraformValue<bool>>("fail_on_first_destination_error");
        set => SetArgument("fail_on_first_destination_error", value);
    }

}


/// <summary>
/// Block type for metadata_catalog_config in AwsAppflowFlow.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowMetadataCatalogConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "metadata_catalog_config";

    /// <summary>
    /// GlueDataCatalog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GlueDataCatalog block(s) allowed")]
    public TerraformList<AwsAppflowFlowMetadataCatalogConfigBlockGlueDataCatalogBlock>? GlueDataCatalog
    {
        get => GetArgument<TerraformList<AwsAppflowFlowMetadataCatalogConfigBlockGlueDataCatalogBlock>>("glue_data_catalog");
        set => SetArgument("glue_data_catalog", value);
    }

}

/// <summary>
/// Block type for glue_data_catalog in AwsAppflowFlowMetadataCatalogConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowMetadataCatalogConfigBlockGlueDataCatalogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "glue_data_catalog";

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformValue<string> DatabaseName
    {
        get => GetRequiredArgument<TerraformValue<string>>("database_name");
        set => SetArgument("database_name", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The table_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TablePrefix is required")]
    public required TerraformValue<string> TablePrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("table_prefix");
        set => SetArgument("table_prefix", value);
    }

}


/// <summary>
/// Block type for source_flow_config in AwsAppflowFlow.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_flow_config";

    /// <summary>
    /// The api_version attribute.
    /// </summary>
    public TerraformValue<string>? ApiVersion
    {
        get => GetArgument<TerraformValue<string>>("api_version");
        set => SetArgument("api_version", value);
    }

    /// <summary>
    /// The connector_profile_name attribute.
    /// </summary>
    public TerraformValue<string>? ConnectorProfileName
    {
        get => GetArgument<TerraformValue<string>>("connector_profile_name");
        set => SetArgument("connector_profile_name", value);
    }

    /// <summary>
    /// The connector_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConnectorType is required")]
    public required TerraformValue<string> ConnectorType
    {
        get => GetRequiredArgument<TerraformValue<string>>("connector_type");
        set => SetArgument("connector_type", value);
    }

    /// <summary>
    /// IncrementalPullConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncrementalPullConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockIncrementalPullConfigBlock>? IncrementalPullConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockIncrementalPullConfigBlock>>("incremental_pull_config");
        set => SetArgument("incremental_pull_config", value);
    }

    /// <summary>
    /// SourceConnectorProperties block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceConnectorProperties is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceConnectorProperties block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceConnectorProperties block(s) allowed")]
    public required TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock> SourceConnectorProperties
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock>>("source_connector_properties");
        set => SetArgument("source_connector_properties", value);
    }

}

/// <summary>
/// Block type for incremental_pull_config in AwsAppflowFlowSourceFlowConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockIncrementalPullConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "incremental_pull_config";

    /// <summary>
    /// The datetime_type_field_name attribute.
    /// </summary>
    public TerraformValue<string>? DatetimeTypeFieldName
    {
        get => GetArgument<TerraformValue<string>>("datetime_type_field_name");
        set => SetArgument("datetime_type_field_name", value);
    }

}

/// <summary>
/// Block type for source_connector_properties in AwsAppflowFlowSourceFlowConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_connector_properties";

    /// <summary>
    /// Amplitude block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Amplitude block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockAmplitudeBlock>? Amplitude
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockAmplitudeBlock>>("amplitude");
        set => SetArgument("amplitude", value);
    }

    /// <summary>
    /// CustomConnector block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomConnector block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockCustomConnectorBlock>? CustomConnector
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockCustomConnectorBlock>>("custom_connector");
        set => SetArgument("custom_connector", value);
    }

    /// <summary>
    /// Datadog block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Datadog block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockDatadogBlock>? Datadog
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockDatadogBlock>>("datadog");
        set => SetArgument("datadog", value);
    }

    /// <summary>
    /// Dynatrace block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Dynatrace block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockDynatraceBlock>? Dynatrace
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockDynatraceBlock>>("dynatrace");
        set => SetArgument("dynatrace", value);
    }

    /// <summary>
    /// GoogleAnalytics block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GoogleAnalytics block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockGoogleAnalyticsBlock>? GoogleAnalytics
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockGoogleAnalyticsBlock>>("google_analytics");
        set => SetArgument("google_analytics", value);
    }

    /// <summary>
    /// InforNexus block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InforNexus block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockInforNexusBlock>? InforNexus
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockInforNexusBlock>>("infor_nexus");
        set => SetArgument("infor_nexus", value);
    }

    /// <summary>
    /// Marketo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Marketo block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockMarketoBlock>? Marketo
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockMarketoBlock>>("marketo");
        set => SetArgument("marketo", value);
    }

    /// <summary>
    /// S3 block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3 block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockS3Block>? S3
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockS3Block>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// Salesforce block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Salesforce block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSalesforceBlock>? Salesforce
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSalesforceBlock>>("salesforce");
        set => SetArgument("salesforce", value);
    }

    /// <summary>
    /// SapoData block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SapoData block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlock>? SapoData
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlock>>("sapo_data");
        set => SetArgument("sapo_data", value);
    }

    /// <summary>
    /// ServiceNow block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceNow block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockServiceNowBlock>? ServiceNow
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockServiceNowBlock>>("service_now");
        set => SetArgument("service_now", value);
    }

    /// <summary>
    /// Singular block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Singular block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSingularBlock>? Singular
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSingularBlock>>("singular");
        set => SetArgument("singular", value);
    }

    /// <summary>
    /// Slack block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Slack block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSlackBlock>? Slack
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSlackBlock>>("slack");
        set => SetArgument("slack", value);
    }

    /// <summary>
    /// Trendmicro block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Trendmicro block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockTrendmicroBlock>? Trendmicro
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockTrendmicroBlock>>("trendmicro");
        set => SetArgument("trendmicro", value);
    }

    /// <summary>
    /// Veeva block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Veeva block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockVeevaBlock>? Veeva
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockVeevaBlock>>("veeva");
        set => SetArgument("veeva", value);
    }

    /// <summary>
    /// Zendesk block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Zendesk block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockZendeskBlock>? Zendesk
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockZendeskBlock>>("zendesk");
        set => SetArgument("zendesk", value);
    }

}

/// <summary>
/// Block type for amplitude in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockAmplitudeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "amplitude";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for custom_connector in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockCustomConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_connector";

    /// <summary>
    /// The custom_properties attribute.
    /// </summary>
    public TerraformMap<string>? CustomProperties
    {
        get => GetArgument<TerraformMap<string>>("custom_properties");
        set => SetArgument("custom_properties", value);
    }

    /// <summary>
    /// The entity_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EntityName is required")]
    public required TerraformValue<string> EntityName
    {
        get => GetRequiredArgument<TerraformValue<string>>("entity_name");
        set => SetArgument("entity_name", value);
    }

}

/// <summary>
/// Block type for datadog in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockDatadogBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "datadog";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for dynatrace in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockDynatraceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dynatrace";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for google_analytics in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockGoogleAnalyticsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "google_analytics";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for infor_nexus in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockInforNexusBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "infor_nexus";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for marketo in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockMarketoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "marketo";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for s3 in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockS3Block : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The bucket_prefix attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketPrefix is required")]
    public required TerraformValue<string> BucketPrefix
    {
        get => GetRequiredArgument<TerraformValue<string>>("bucket_prefix");
        set => SetArgument("bucket_prefix", value);
    }

    /// <summary>
    /// S3InputFormatConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3InputFormatConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockS3BlockS3InputFormatConfigBlock>? S3InputFormatConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockS3BlockS3InputFormatConfigBlock>>("s3_input_format_config");
        set => SetArgument("s3_input_format_config", value);
    }

}

/// <summary>
/// Block type for s3_input_format_config in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockS3Block.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockS3BlockS3InputFormatConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_input_format_config";

    /// <summary>
    /// The s3_input_file_type attribute.
    /// </summary>
    public TerraformValue<string>? S3InputFileType
    {
        get => GetArgument<TerraformValue<string>>("s3_input_file_type");
        set => SetArgument("s3_input_file_type", value);
    }

}

/// <summary>
/// Block type for salesforce in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSalesforceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "salesforce";

    /// <summary>
    /// The data_transfer_api attribute.
    /// </summary>
    public TerraformValue<string>? DataTransferApi
    {
        get => GetArgument<TerraformValue<string>>("data_transfer_api");
        set => SetArgument("data_transfer_api", value);
    }

    /// <summary>
    /// The enable_dynamic_field_update attribute.
    /// </summary>
    public TerraformValue<bool>? EnableDynamicFieldUpdate
    {
        get => GetArgument<TerraformValue<bool>>("enable_dynamic_field_update");
        set => SetArgument("enable_dynamic_field_update", value);
    }

    /// <summary>
    /// The include_deleted_records attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeDeletedRecords
    {
        get => GetArgument<TerraformValue<bool>>("include_deleted_records");
        set => SetArgument("include_deleted_records", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for sapo_data in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sapo_data";

    /// <summary>
    /// The object_path attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectPath is required")]
    public required TerraformValue<string> ObjectPath
    {
        get => GetRequiredArgument<TerraformValue<string>>("object_path");
        set => SetArgument("object_path", value);
    }

    /// <summary>
    /// PaginationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PaginationConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlockPaginationConfigBlock>? PaginationConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlockPaginationConfigBlock>>("pagination_config");
        set => SetArgument("pagination_config", value);
    }

    /// <summary>
    /// ParallelismConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ParallelismConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlockParallelismConfigBlock>? ParallelismConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlockParallelismConfigBlock>>("parallelism_config");
        set => SetArgument("parallelism_config", value);
    }

}

/// <summary>
/// Block type for pagination_config in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlockPaginationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pagination_config";

    /// <summary>
    /// The max_page_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPageSize is required")]
    public required TerraformValue<double> MaxPageSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_page_size");
        set => SetArgument("max_page_size", value);
    }

}

/// <summary>
/// Block type for parallelism_config in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSapoDataBlockParallelismConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parallelism_config";

    /// <summary>
    /// The max_page_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxPageSize is required")]
    public required TerraformValue<double> MaxPageSize
    {
        get => GetRequiredArgument<TerraformValue<double>>("max_page_size");
        set => SetArgument("max_page_size", value);
    }

}

/// <summary>
/// Block type for service_now in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockServiceNowBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_now";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for singular in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSingularBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "singular";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for slack in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockSlackBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "slack";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for trendmicro in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockTrendmicroBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trendmicro";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for veeva in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockVeevaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "veeva";

    /// <summary>
    /// The document_type attribute.
    /// </summary>
    public TerraformValue<string>? DocumentType
    {
        get => GetArgument<TerraformValue<string>>("document_type");
        set => SetArgument("document_type", value);
    }

    /// <summary>
    /// The include_all_versions attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeAllVersions
    {
        get => GetArgument<TerraformValue<bool>>("include_all_versions");
        set => SetArgument("include_all_versions", value);
    }

    /// <summary>
    /// The include_renditions attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeRenditions
    {
        get => GetArgument<TerraformValue<bool>>("include_renditions");
        set => SetArgument("include_renditions", value);
    }

    /// <summary>
    /// The include_source_files attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeSourceFiles
    {
        get => GetArgument<TerraformValue<bool>>("include_source_files");
        set => SetArgument("include_source_files", value);
    }

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}

/// <summary>
/// Block type for zendesk in AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowSourceFlowConfigBlockSourceConnectorPropertiesBlockZendeskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "zendesk";

    /// <summary>
    /// The object attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectAttribute is required")]
    public required TerraformValue<string> ObjectAttribute
    {
        get => GetRequiredArgument<TerraformValue<string>>("object");
        set => SetArgument("object", value);
    }

}


/// <summary>
/// Block type for task in AwsAppflowFlow.
/// Nesting mode: set
/// </summary>
public class AwsAppflowFlowTaskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "task";

    /// <summary>
    /// The destination_field attribute.
    /// </summary>
    public TerraformValue<string>? DestinationField
    {
        get => GetArgument<TerraformValue<string>>("destination_field");
        set => SetArgument("destination_field", value);
    }

    /// <summary>
    /// The source_fields attribute.
    /// </summary>
    public TerraformList<string> SourceFields
    {
        get => GetArgument<TerraformList<string>>("source_fields") ?? AsReference("source_fields");
        set => SetArgument("source_fields", value);
    }

    /// <summary>
    /// The task_properties attribute.
    /// </summary>
    public TerraformMap<string>? TaskProperties
    {
        get => GetArgument<TerraformMap<string>>("task_properties");
        set => SetArgument("task_properties", value);
    }

    /// <summary>
    /// The task_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TaskType is required")]
    public required TerraformValue<string> TaskType
    {
        get => GetRequiredArgument<TerraformValue<string>>("task_type");
        set => SetArgument("task_type", value);
    }

    /// <summary>
    /// ConnectorOperator block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAppflowFlowTaskBlockConnectorOperatorBlock>? ConnectorOperator
    {
        get => GetArgument<TerraformList<AwsAppflowFlowTaskBlockConnectorOperatorBlock>>("connector_operator");
        set => SetArgument("connector_operator", value);
    }

}

/// <summary>
/// Block type for connector_operator in AwsAppflowFlowTaskBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowTaskBlockConnectorOperatorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "connector_operator";

    /// <summary>
    /// The amplitude attribute.
    /// </summary>
    public TerraformValue<string>? Amplitude
    {
        get => GetArgument<TerraformValue<string>>("amplitude");
        set => SetArgument("amplitude", value);
    }

    /// <summary>
    /// The custom_connector attribute.
    /// </summary>
    public TerraformValue<string>? CustomConnector
    {
        get => GetArgument<TerraformValue<string>>("custom_connector");
        set => SetArgument("custom_connector", value);
    }

    /// <summary>
    /// The datadog attribute.
    /// </summary>
    public TerraformValue<string>? Datadog
    {
        get => GetArgument<TerraformValue<string>>("datadog");
        set => SetArgument("datadog", value);
    }

    /// <summary>
    /// The dynatrace attribute.
    /// </summary>
    public TerraformValue<string>? Dynatrace
    {
        get => GetArgument<TerraformValue<string>>("dynatrace");
        set => SetArgument("dynatrace", value);
    }

    /// <summary>
    /// The google_analytics attribute.
    /// </summary>
    public TerraformValue<string>? GoogleAnalytics
    {
        get => GetArgument<TerraformValue<string>>("google_analytics");
        set => SetArgument("google_analytics", value);
    }

    /// <summary>
    /// The infor_nexus attribute.
    /// </summary>
    public TerraformValue<string>? InforNexus
    {
        get => GetArgument<TerraformValue<string>>("infor_nexus");
        set => SetArgument("infor_nexus", value);
    }

    /// <summary>
    /// The marketo attribute.
    /// </summary>
    public TerraformValue<string>? Marketo
    {
        get => GetArgument<TerraformValue<string>>("marketo");
        set => SetArgument("marketo", value);
    }

    /// <summary>
    /// The s3 attribute.
    /// </summary>
    public TerraformValue<string>? S3
    {
        get => GetArgument<TerraformValue<string>>("s3");
        set => SetArgument("s3", value);
    }

    /// <summary>
    /// The salesforce attribute.
    /// </summary>
    public TerraformValue<string>? Salesforce
    {
        get => GetArgument<TerraformValue<string>>("salesforce");
        set => SetArgument("salesforce", value);
    }

    /// <summary>
    /// The sapo_data attribute.
    /// </summary>
    public TerraformValue<string>? SapoData
    {
        get => GetArgument<TerraformValue<string>>("sapo_data");
        set => SetArgument("sapo_data", value);
    }

    /// <summary>
    /// The service_now attribute.
    /// </summary>
    public TerraformValue<string>? ServiceNow
    {
        get => GetArgument<TerraformValue<string>>("service_now");
        set => SetArgument("service_now", value);
    }

    /// <summary>
    /// The singular attribute.
    /// </summary>
    public TerraformValue<string>? Singular
    {
        get => GetArgument<TerraformValue<string>>("singular");
        set => SetArgument("singular", value);
    }

    /// <summary>
    /// The slack attribute.
    /// </summary>
    public TerraformValue<string>? Slack
    {
        get => GetArgument<TerraformValue<string>>("slack");
        set => SetArgument("slack", value);
    }

    /// <summary>
    /// The trendmicro attribute.
    /// </summary>
    public TerraformValue<string>? Trendmicro
    {
        get => GetArgument<TerraformValue<string>>("trendmicro");
        set => SetArgument("trendmicro", value);
    }

    /// <summary>
    /// The veeva attribute.
    /// </summary>
    public TerraformValue<string>? Veeva
    {
        get => GetArgument<TerraformValue<string>>("veeva");
        set => SetArgument("veeva", value);
    }

    /// <summary>
    /// The zendesk attribute.
    /// </summary>
    public TerraformValue<string>? Zendesk
    {
        get => GetArgument<TerraformValue<string>>("zendesk");
        set => SetArgument("zendesk", value);
    }

}


/// <summary>
/// Block type for trigger_config in AwsAppflowFlow.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowTriggerConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_config";

    /// <summary>
    /// The trigger_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerType is required")]
    public required TerraformValue<string> TriggerType
    {
        get => GetRequiredArgument<TerraformValue<string>>("trigger_type");
        set => SetArgument("trigger_type", value);
    }

    /// <summary>
    /// TriggerProperties block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerProperties block(s) allowed")]
    public TerraformList<AwsAppflowFlowTriggerConfigBlockTriggerPropertiesBlock>? TriggerProperties
    {
        get => GetArgument<TerraformList<AwsAppflowFlowTriggerConfigBlockTriggerPropertiesBlock>>("trigger_properties");
        set => SetArgument("trigger_properties", value);
    }

}

/// <summary>
/// Block type for trigger_properties in AwsAppflowFlowTriggerConfigBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowTriggerConfigBlockTriggerPropertiesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "trigger_properties";

    /// <summary>
    /// Scheduled block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Scheduled block(s) allowed")]
    public TerraformList<AwsAppflowFlowTriggerConfigBlockTriggerPropertiesBlockScheduledBlock>? Scheduled
    {
        get => GetArgument<TerraformList<AwsAppflowFlowTriggerConfigBlockTriggerPropertiesBlockScheduledBlock>>("scheduled");
        set => SetArgument("scheduled", value);
    }

}

/// <summary>
/// Block type for scheduled in AwsAppflowFlowTriggerConfigBlockTriggerPropertiesBlock.
/// Nesting mode: list
/// </summary>
public class AwsAppflowFlowTriggerConfigBlockTriggerPropertiesBlockScheduledBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "scheduled";

    /// <summary>
    /// The data_pull_mode attribute.
    /// </summary>
    public TerraformValue<string>? DataPullMode
    {
        get => GetArgument<TerraformValue<string>>("data_pull_mode");
        set => SetArgument("data_pull_mode", value);
    }

    /// <summary>
    /// The first_execution_from attribute.
    /// </summary>
    public TerraformValue<string>? FirstExecutionFrom
    {
        get => GetArgument<TerraformValue<string>>("first_execution_from");
        set => SetArgument("first_execution_from", value);
    }

    /// <summary>
    /// The schedule_end_time attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleEndTime
    {
        get => GetArgument<TerraformValue<string>>("schedule_end_time");
        set => SetArgument("schedule_end_time", value);
    }

    /// <summary>
    /// The schedule_expression attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScheduleExpression is required")]
    public required TerraformValue<string> ScheduleExpression
    {
        get => GetRequiredArgument<TerraformValue<string>>("schedule_expression");
        set => SetArgument("schedule_expression", value);
    }

    /// <summary>
    /// The schedule_offset attribute.
    /// </summary>
    public TerraformValue<double>? ScheduleOffset
    {
        get => GetArgument<TerraformValue<double>>("schedule_offset");
        set => SetArgument("schedule_offset", value);
    }

    /// <summary>
    /// The schedule_start_time attribute.
    /// </summary>
    public TerraformValue<string>? ScheduleStartTime
    {
        get => GetArgument<TerraformValue<string>>("schedule_start_time");
        set => SetArgument("schedule_start_time", value);
    }

    /// <summary>
    /// The timezone attribute.
    /// </summary>
    public TerraformValue<string>? Timezone
    {
        get => GetArgument<TerraformValue<string>>("timezone");
        set => SetArgument("timezone", value);
    }

}


/// <summary>
/// Represents a aws_appflow_flow Terraform resource.
/// Manages a aws_appflow_flow resource.
/// </summary>
public partial class AwsAppflowFlow(string name) : TerraformResource("aws_appflow_flow", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// The kms_arn attribute.
    /// </summary>
    public TerraformValue<string> KmsArn
    {
        get => GetArgument<TerraformValue<string>>("kms_arn") ?? AsReference("kms_arn");
        set => SetArgument("kms_arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The flow_status attribute.
    /// </summary>
    public TerraformValue<string> FlowStatus
        => AsReference("flow_status");

    /// <summary>
    /// DestinationFlowConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 DestinationFlowConfig block(s) required")]
    public required TerraformList<AwsAppflowFlowDestinationFlowConfigBlock> DestinationFlowConfig
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowFlowDestinationFlowConfigBlock>>("destination_flow_config");
        set => SetArgument("destination_flow_config", value);
    }

    /// <summary>
    /// MetadataCatalogConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MetadataCatalogConfig block(s) allowed")]
    public TerraformList<AwsAppflowFlowMetadataCatalogConfigBlock>? MetadataCatalogConfig
    {
        get => GetArgument<TerraformList<AwsAppflowFlowMetadataCatalogConfigBlock>>("metadata_catalog_config");
        set => SetArgument("metadata_catalog_config", value);
    }

    /// <summary>
    /// SourceFlowConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceFlowConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SourceFlowConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SourceFlowConfig block(s) allowed")]
    public required TerraformList<AwsAppflowFlowSourceFlowConfigBlock> SourceFlowConfig
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowFlowSourceFlowConfigBlock>>("source_flow_config");
        set => SetArgument("source_flow_config", value);
    }

    /// <summary>
    /// Task block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Task is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Task block(s) required")]
    public required TerraformSet<AwsAppflowFlowTaskBlock> Task
    {
        get => GetRequiredArgument<TerraformSet<AwsAppflowFlowTaskBlock>>("task");
        set => SetArgument("task", value);
    }

    /// <summary>
    /// TriggerConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 TriggerConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TriggerConfig block(s) allowed")]
    public required TerraformList<AwsAppflowFlowTriggerConfigBlock> TriggerConfig
    {
        get => GetRequiredArgument<TerraformList<AwsAppflowFlowTriggerConfigBlock>>("trigger_config");
        set => SetArgument("trigger_config", value);
    }

}
