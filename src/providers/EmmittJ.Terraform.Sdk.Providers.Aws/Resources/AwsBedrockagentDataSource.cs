using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for data_source_configuration in AwsBedrockagentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "data_source_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// ConfluenceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlock>? ConfluenceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlock>>("confluence_configuration");
        set => SetArgument("confluence_configuration", value);
    }

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// SalesforceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlock>? SalesforceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlock>>("salesforce_configuration");
        set => SetArgument("salesforce_configuration", value);
    }

    /// <summary>
    /// SharePointConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlock>? SharePointConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlock>>("share_point_configuration");
        set => SetArgument("share_point_configuration", value);
    }

    /// <summary>
    /// WebConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlock>? WebConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlock>>("web_configuration");
        set => SetArgument("web_configuration", value);
    }

}

/// <summary>
/// Block type for confluence_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "confluence_configuration";

    /// <summary>
    /// CrawlerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlock>? CrawlerConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlock>>("crawler_configuration");
        set => SetArgument("crawler_configuration", value);
    }

    /// <summary>
    /// SourceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockSourceConfigurationBlock>? SourceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockSourceConfigurationBlock>>("source_configuration");
        set => SetArgument("source_configuration", value);
    }

}

/// <summary>
/// Block type for crawler_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crawler_configuration";

    /// <summary>
    /// FilterConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock>? FilterConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock>>("filter_configuration");
        set => SetArgument("filter_configuration", value);
    }

}

/// <summary>
/// Block type for filter_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// PatternObjectFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock>? PatternObjectFilter
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock>>("pattern_object_filter");
        set => SetArgument("pattern_object_filter", value);
    }

}

/// <summary>
/// Block type for pattern_object_filter in AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pattern_object_filter";

    /// <summary>
    /// Filters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock>? Filters
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

}

/// <summary>
/// Block type for filters in AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The exclusion_filters attribute.
    /// </summary>
    public TerraformSet<string>? ExclusionFilters
    {
        get => GetArgument<TerraformSet<string>>("exclusion_filters");
        set => SetArgument("exclusion_filters", value);
    }

    /// <summary>
    /// The inclusion_filters attribute.
    /// </summary>
    public TerraformSet<string>? InclusionFilters
    {
        get => GetArgument<TerraformSet<string>>("inclusion_filters");
        set => SetArgument("inclusion_filters", value);
    }

    /// <summary>
    /// The object_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectType is required")]
    public required TerraformValue<string> ObjectType
    {
        get => GetArgument<TerraformValue<string>>("object_type");
        set => SetArgument("object_type", value);
    }

}

/// <summary>
/// Block type for source_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockConfluenceConfigurationBlockSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_configuration";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// The credentials_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialsSecretArn is required")]
    public required TerraformValue<string> CredentialsSecretArn
    {
        get => GetArgument<TerraformValue<string>>("credentials_secret_arn");
        set => SetArgument("credentials_secret_arn", value);
    }

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostType is required")]
    public required TerraformValue<string> HostType
    {
        get => GetArgument<TerraformValue<string>>("host_type");
        set => SetArgument("host_type", value);
    }

    /// <summary>
    /// The host_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUrl is required")]
    public required TerraformValue<string> HostUrl
    {
        get => GetArgument<TerraformValue<string>>("host_url");
        set => SetArgument("host_url", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketArn is required")]
    public required TerraformValue<string> BucketArn
    {
        get => GetArgument<TerraformValue<string>>("bucket_arn");
        set => SetArgument("bucket_arn", value);
    }

    /// <summary>
    /// The bucket_owner_account_id attribute.
    /// </summary>
    public TerraformValue<string>? BucketOwnerAccountId
    {
        get => GetArgument<TerraformValue<string>>("bucket_owner_account_id");
        set => SetArgument("bucket_owner_account_id", value);
    }

    /// <summary>
    /// The inclusion_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? InclusionPrefixes
    {
        get => GetArgument<TerraformSet<string>>("inclusion_prefixes");
        set => SetArgument("inclusion_prefixes", value);
    }

}

/// <summary>
/// Block type for salesforce_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "salesforce_configuration";

    /// <summary>
    /// CrawlerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlock>? CrawlerConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlock>>("crawler_configuration");
        set => SetArgument("crawler_configuration", value);
    }

    /// <summary>
    /// SourceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockSourceConfigurationBlock>? SourceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockSourceConfigurationBlock>>("source_configuration");
        set => SetArgument("source_configuration", value);
    }

}

/// <summary>
/// Block type for crawler_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crawler_configuration";

    /// <summary>
    /// FilterConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock>? FilterConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock>>("filter_configuration");
        set => SetArgument("filter_configuration", value);
    }

}

/// <summary>
/// Block type for filter_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// PatternObjectFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock>? PatternObjectFilter
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock>>("pattern_object_filter");
        set => SetArgument("pattern_object_filter", value);
    }

}

/// <summary>
/// Block type for pattern_object_filter in AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pattern_object_filter";

    /// <summary>
    /// Filters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock>? Filters
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

}

/// <summary>
/// Block type for filters in AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The exclusion_filters attribute.
    /// </summary>
    public TerraformSet<string>? ExclusionFilters
    {
        get => GetArgument<TerraformSet<string>>("exclusion_filters");
        set => SetArgument("exclusion_filters", value);
    }

    /// <summary>
    /// The inclusion_filters attribute.
    /// </summary>
    public TerraformSet<string>? InclusionFilters
    {
        get => GetArgument<TerraformSet<string>>("inclusion_filters");
        set => SetArgument("inclusion_filters", value);
    }

    /// <summary>
    /// The object_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectType is required")]
    public required TerraformValue<string> ObjectType
    {
        get => GetArgument<TerraformValue<string>>("object_type");
        set => SetArgument("object_type", value);
    }

}

/// <summary>
/// Block type for source_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSalesforceConfigurationBlockSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_configuration";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// The credentials_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialsSecretArn is required")]
    public required TerraformValue<string> CredentialsSecretArn
    {
        get => GetArgument<TerraformValue<string>>("credentials_secret_arn");
        set => SetArgument("credentials_secret_arn", value);
    }

    /// <summary>
    /// The host_url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostUrl is required")]
    public required TerraformValue<string> HostUrl
    {
        get => GetArgument<TerraformValue<string>>("host_url");
        set => SetArgument("host_url", value);
    }

}

/// <summary>
/// Block type for share_point_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "share_point_configuration";

    /// <summary>
    /// CrawlerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlock>? CrawlerConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlock>>("crawler_configuration");
        set => SetArgument("crawler_configuration", value);
    }

    /// <summary>
    /// SourceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockSourceConfigurationBlock>? SourceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockSourceConfigurationBlock>>("source_configuration");
        set => SetArgument("source_configuration", value);
    }

}

/// <summary>
/// Block type for crawler_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crawler_configuration";

    /// <summary>
    /// FilterConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock>? FilterConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock>>("filter_configuration");
        set => SetArgument("filter_configuration", value);
    }

}

/// <summary>
/// Block type for filter_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter_configuration";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// PatternObjectFilter block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock>? PatternObjectFilter
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock>>("pattern_object_filter");
        set => SetArgument("pattern_object_filter", value);
    }

}

/// <summary>
/// Block type for pattern_object_filter in AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pattern_object_filter";

    /// <summary>
    /// Filters block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock>? Filters
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

}

/// <summary>
/// Block type for filters in AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockCrawlerConfigurationBlockFilterConfigurationBlockPatternObjectFilterBlockFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The exclusion_filters attribute.
    /// </summary>
    public TerraformSet<string>? ExclusionFilters
    {
        get => GetArgument<TerraformSet<string>>("exclusion_filters");
        set => SetArgument("exclusion_filters", value);
    }

    /// <summary>
    /// The inclusion_filters attribute.
    /// </summary>
    public TerraformSet<string>? InclusionFilters
    {
        get => GetArgument<TerraformSet<string>>("inclusion_filters");
        set => SetArgument("inclusion_filters", value);
    }

    /// <summary>
    /// The object_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectType is required")]
    public required TerraformValue<string> ObjectType
    {
        get => GetArgument<TerraformValue<string>>("object_type");
        set => SetArgument("object_type", value);
    }

}

/// <summary>
/// Block type for source_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockSharePointConfigurationBlockSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_configuration";

    /// <summary>
    /// The auth_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformValue<string> AuthType
    {
        get => GetArgument<TerraformValue<string>>("auth_type");
        set => SetArgument("auth_type", value);
    }

    /// <summary>
    /// The credentials_secret_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CredentialsSecretArn is required")]
    public required TerraformValue<string> CredentialsSecretArn
    {
        get => GetArgument<TerraformValue<string>>("credentials_secret_arn");
        set => SetArgument("credentials_secret_arn", value);
    }

    /// <summary>
    /// The domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Domain is required")]
    public required TerraformValue<string> Domain
    {
        get => GetArgument<TerraformValue<string>>("domain");
        set => SetArgument("domain", value);
    }

    /// <summary>
    /// The host_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostType is required")]
    public required TerraformValue<string> HostType
    {
        get => GetArgument<TerraformValue<string>>("host_type");
        set => SetArgument("host_type", value);
    }

    /// <summary>
    /// The site_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteUrls is required")]
    public required TerraformSet<string> SiteUrls
    {
        get => GetArgument<TerraformSet<string>>("site_urls");
        set => SetArgument("site_urls", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string>? TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for web_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_configuration";

    /// <summary>
    /// CrawlerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockCrawlerConfigurationBlock>? CrawlerConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockCrawlerConfigurationBlock>>("crawler_configuration");
        set => SetArgument("crawler_configuration", value);
    }

    /// <summary>
    /// SourceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlock>? SourceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlock>>("source_configuration");
        set => SetArgument("source_configuration", value);
    }

}

/// <summary>
/// Block type for crawler_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockCrawlerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crawler_configuration";

    /// <summary>
    /// The exclusion_filters attribute.
    /// </summary>
    public TerraformSet<string>? ExclusionFilters
    {
        get => GetArgument<TerraformSet<string>>("exclusion_filters");
        set => SetArgument("exclusion_filters", value);
    }

    /// <summary>
    /// The inclusion_filters attribute.
    /// </summary>
    public TerraformSet<string>? InclusionFilters
    {
        get => GetArgument<TerraformSet<string>>("inclusion_filters");
        set => SetArgument("inclusion_filters", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    public TerraformValue<string>? Scope
    {
        get => GetArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The user_agent attribute.
    /// </summary>
    public TerraformValue<string>? UserAgent
    {
        get => GetArgument<TerraformValue<string>>("user_agent");
        set => SetArgument("user_agent", value);
    }

    /// <summary>
    /// CrawlerLimits block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockCrawlerConfigurationBlockCrawlerLimitsBlock>? CrawlerLimits
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockCrawlerConfigurationBlockCrawlerLimitsBlock>>("crawler_limits");
        set => SetArgument("crawler_limits", value);
    }

}

/// <summary>
/// Block type for crawler_limits in AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockCrawlerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockCrawlerConfigurationBlockCrawlerLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crawler_limits";

    /// <summary>
    /// The max_pages attribute.
    /// </summary>
    public TerraformValue<double>? MaxPages
    {
        get => GetArgument<TerraformValue<double>>("max_pages");
        set => SetArgument("max_pages", value);
    }

    /// <summary>
    /// The rate_limit attribute.
    /// </summary>
    public TerraformValue<double>? RateLimit
    {
        get => GetArgument<TerraformValue<double>>("rate_limit");
        set => SetArgument("rate_limit", value);
    }

}

/// <summary>
/// Block type for source_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "source_configuration";

    /// <summary>
    /// UrlConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlockUrlConfigurationBlock>? UrlConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlockUrlConfigurationBlock>>("url_configuration");
        set => SetArgument("url_configuration", value);
    }

}

/// <summary>
/// Block type for url_configuration in AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlockUrlConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "url_configuration";

    /// <summary>
    /// SeedUrls block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlockUrlConfigurationBlockSeedUrlsBlock>? SeedUrls
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlockUrlConfigurationBlockSeedUrlsBlock>>("seed_urls");
        set => SetArgument("seed_urls", value);
    }

}

/// <summary>
/// Block type for seed_urls in AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlockUrlConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceDataSourceConfigurationBlockWebConfigurationBlockSourceConfigurationBlockUrlConfigurationBlockSeedUrlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "seed_urls";

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformValue<string>? Url
    {
        get => GetArgument<TerraformValue<string>>("url");
        set => SetArgument("url", value);
    }

}


/// <summary>
/// Block type for server_side_encryption_configuration in AwsBedrockagentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_side_encryption_configuration";

    /// <summary>
    /// The kms_key_arn attribute.
    /// </summary>
    public TerraformValue<string>? KmsKeyArn
    {
        get => GetArgument<TerraformValue<string>>("kms_key_arn");
        set => SetArgument("kms_key_arn", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsBedrockagentDataSource.
/// Nesting mode: single
/// </summary>
public class AwsBedrockagentDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Block type for vector_ingestion_configuration in AwsBedrockagentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vector_ingestion_configuration";

    /// <summary>
    /// ChunkingConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlock>? ChunkingConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlock>>("chunking_configuration");
        set => SetArgument("chunking_configuration", value);
    }

    /// <summary>
    /// CustomTransformationConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlock>? CustomTransformationConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlock>>("custom_transformation_configuration");
        set => SetArgument("custom_transformation_configuration", value);
    }

    /// <summary>
    /// ParsingConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlock>? ParsingConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlock>>("parsing_configuration");
        set => SetArgument("parsing_configuration", value);
    }

}

/// <summary>
/// Block type for chunking_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "chunking_configuration";

    /// <summary>
    /// The chunking_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ChunkingStrategy is required")]
    public required TerraformValue<string> ChunkingStrategy
    {
        get => GetArgument<TerraformValue<string>>("chunking_strategy");
        set => SetArgument("chunking_strategy", value);
    }

    /// <summary>
    /// FixedSizeChunkingConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockFixedSizeChunkingConfigurationBlock>? FixedSizeChunkingConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockFixedSizeChunkingConfigurationBlock>>("fixed_size_chunking_configuration");
        set => SetArgument("fixed_size_chunking_configuration", value);
    }

    /// <summary>
    /// HierarchicalChunkingConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockHierarchicalChunkingConfigurationBlock>? HierarchicalChunkingConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockHierarchicalChunkingConfigurationBlock>>("hierarchical_chunking_configuration");
        set => SetArgument("hierarchical_chunking_configuration", value);
    }

    /// <summary>
    /// SemanticChunkingConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockSemanticChunkingConfigurationBlock>? SemanticChunkingConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockSemanticChunkingConfigurationBlock>>("semantic_chunking_configuration");
        set => SetArgument("semantic_chunking_configuration", value);
    }

}

/// <summary>
/// Block type for fixed_size_chunking_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockFixedSizeChunkingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fixed_size_chunking_configuration";

    /// <summary>
    /// The max_tokens attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxTokens is required")]
    public required TerraformValue<double> MaxTokens
    {
        get => GetArgument<TerraformValue<double>>("max_tokens");
        set => SetArgument("max_tokens", value);
    }

    /// <summary>
    /// The overlap_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverlapPercentage is required")]
    public required TerraformValue<double> OverlapPercentage
    {
        get => GetArgument<TerraformValue<double>>("overlap_percentage");
        set => SetArgument("overlap_percentage", value);
    }

}

/// <summary>
/// Block type for hierarchical_chunking_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockHierarchicalChunkingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hierarchical_chunking_configuration";

    /// <summary>
    /// The overlap_tokens attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OverlapTokens is required")]
    public required TerraformValue<double> OverlapTokens
    {
        get => GetArgument<TerraformValue<double>>("overlap_tokens");
        set => SetArgument("overlap_tokens", value);
    }

    /// <summary>
    /// LevelConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockHierarchicalChunkingConfigurationBlockLevelConfigurationBlock>? LevelConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockHierarchicalChunkingConfigurationBlockLevelConfigurationBlock>>("level_configuration");
        set => SetArgument("level_configuration", value);
    }

}

/// <summary>
/// Block type for level_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockHierarchicalChunkingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockHierarchicalChunkingConfigurationBlockLevelConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "level_configuration";

    /// <summary>
    /// The max_tokens attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxTokens is required")]
    public required TerraformValue<double> MaxTokens
    {
        get => GetArgument<TerraformValue<double>>("max_tokens");
        set => SetArgument("max_tokens", value);
    }

}

/// <summary>
/// Block type for semantic_chunking_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockChunkingConfigurationBlockSemanticChunkingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "semantic_chunking_configuration";

    /// <summary>
    /// The breakpoint_percentile_threshold attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BreakpointPercentileThreshold is required")]
    public required TerraformValue<double> BreakpointPercentileThreshold
    {
        get => GetArgument<TerraformValue<double>>("breakpoint_percentile_threshold");
        set => SetArgument("breakpoint_percentile_threshold", value);
    }

    /// <summary>
    /// The buffer_size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BufferSize is required")]
    public required TerraformValue<double> BufferSize
    {
        get => GetArgument<TerraformValue<double>>("buffer_size");
        set => SetArgument("buffer_size", value);
    }

    /// <summary>
    /// The max_token attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxToken is required")]
    public required TerraformValue<double> MaxToken
    {
        get => GetArgument<TerraformValue<double>>("max_token");
        set => SetArgument("max_token", value);
    }

}

/// <summary>
/// Block type for custom_transformation_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_transformation_configuration";

    /// <summary>
    /// IntermediateStorage block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockIntermediateStorageBlock>? IntermediateStorage
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockIntermediateStorageBlock>>("intermediate_storage");
        set => SetArgument("intermediate_storage", value);
    }

    /// <summary>
    /// Transformation block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlock>? Transformation
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlock>>("transformation");
        set => SetArgument("transformation", value);
    }

}

/// <summary>
/// Block type for intermediate_storage in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockIntermediateStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "intermediate_storage";

    /// <summary>
    /// S3Location block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockIntermediateStorageBlockS3LocationBlock>? S3Location
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockIntermediateStorageBlockS3LocationBlock>>("s3_location");
        set => SetArgument("s3_location", value);
    }

}

/// <summary>
/// Block type for s3_location in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockIntermediateStorageBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockIntermediateStorageBlockS3LocationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_location";

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformValue<string> Uri
    {
        get => GetArgument<TerraformValue<string>>("uri");
        set => SetArgument("uri", value);
    }

}

/// <summary>
/// Block type for transformation in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation";

    /// <summary>
    /// The step_to_apply attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StepToApply is required")]
    public required TerraformValue<string> StepToApply
    {
        get => GetArgument<TerraformValue<string>>("step_to_apply");
        set => SetArgument("step_to_apply", value);
    }

    /// <summary>
    /// TransformationFunction block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlockTransformationFunctionBlock>? TransformationFunction
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlockTransformationFunctionBlock>>("transformation_function");
        set => SetArgument("transformation_function", value);
    }

}

/// <summary>
/// Block type for transformation_function in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlockTransformationFunctionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation_function";

    /// <summary>
    /// TransformationLambdaConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlockTransformationFunctionBlockTransformationLambdaConfigurationBlock>? TransformationLambdaConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlockTransformationFunctionBlockTransformationLambdaConfigurationBlock>>("transformation_lambda_configuration");
        set => SetArgument("transformation_lambda_configuration", value);
    }

}

/// <summary>
/// Block type for transformation_lambda_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlockTransformationFunctionBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockCustomTransformationConfigurationBlockTransformationBlockTransformationFunctionBlockTransformationLambdaConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "transformation_lambda_configuration";

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

}

/// <summary>
/// Block type for parsing_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parsing_configuration";

    /// <summary>
    /// The parsing_strategy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParsingStrategy is required")]
    public required TerraformValue<string> ParsingStrategy
    {
        get => GetArgument<TerraformValue<string>>("parsing_strategy");
        set => SetArgument("parsing_strategy", value);
    }

    /// <summary>
    /// BedrockFoundationModelConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlockBedrockFoundationModelConfigurationBlock>? BedrockFoundationModelConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlockBedrockFoundationModelConfigurationBlock>>("bedrock_foundation_model_configuration");
        set => SetArgument("bedrock_foundation_model_configuration", value);
    }

}

/// <summary>
/// Block type for bedrock_foundation_model_configuration in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlockBedrockFoundationModelConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "bedrock_foundation_model_configuration";

    /// <summary>
    /// The model_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ModelArn is required")]
    public required TerraformValue<string> ModelArn
    {
        get => GetArgument<TerraformValue<string>>("model_arn");
        set => SetArgument("model_arn", value);
    }

    /// <summary>
    /// ParsingPrompt block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlockBedrockFoundationModelConfigurationBlockParsingPromptBlock>? ParsingPrompt
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlockBedrockFoundationModelConfigurationBlockParsingPromptBlock>>("parsing_prompt");
        set => SetArgument("parsing_prompt", value);
    }

}

/// <summary>
/// Block type for parsing_prompt in AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlockBedrockFoundationModelConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsBedrockagentDataSourceVectorIngestionConfigurationBlockParsingConfigurationBlockBedrockFoundationModelConfigurationBlockParsingPromptBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "parsing_prompt";

    /// <summary>
    /// The parsing_prompt_string attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ParsingPromptString is required")]
    public required TerraformValue<string> ParsingPromptString
    {
        get => GetArgument<TerraformValue<string>>("parsing_prompt_string");
        set => SetArgument("parsing_prompt_string", value);
    }

}


/// <summary>
/// Represents a aws_bedrockagent_data_source Terraform resource.
/// Manages a aws_bedrockagent_data_source resource.
/// </summary>
public partial class AwsBedrockagentDataSource(string name) : TerraformResource("aws_bedrockagent_data_source", name)
{
    /// <summary>
    /// The data_deletion_policy attribute.
    /// </summary>
    public TerraformValue<string>? DataDeletionPolicy
    {
        get => GetArgument<TerraformValue<string>>("data_deletion_policy");
        set => SetArgument("data_deletion_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The knowledge_base_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KnowledgeBaseId is required")]
    public required TerraformValue<string> KnowledgeBaseId
    {
        get => GetArgument<TerraformValue<string>>("knowledge_base_id");
        set => SetArgument("knowledge_base_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformValue<string> DataSourceId
        => AsReference("data_source_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// DataSourceConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlock>? DataSourceConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceDataSourceConfigurationBlock>>("data_source_configuration");
        set => SetArgument("data_source_configuration", value);
    }

    /// <summary>
    /// ServerSideEncryptionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock>? ServerSideEncryptionConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceServerSideEncryptionConfigurationBlock>>("server_side_encryption_configuration");
        set => SetArgument("server_side_encryption_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsBedrockagentDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsBedrockagentDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VectorIngestionConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlock>? VectorIngestionConfiguration
    {
        get => GetArgument<TerraformList<AwsBedrockagentDataSourceVectorIngestionConfigurationBlock>>("vector_ingestion_configuration");
        set => SetArgument("vector_ingestion_configuration", value);
    }

}
