using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsKendraDataSource.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// S3Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 S3Configuration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockS3ConfigurationBlock>? S3Configuration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockS3ConfigurationBlock>>("s3_configuration");
        set => SetArgument("s3_configuration", value);
    }

    /// <summary>
    /// TemplateConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TemplateConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockTemplateConfigurationBlock>? TemplateConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockTemplateConfigurationBlock>>("template_configuration");
        set => SetArgument("template_configuration", value);
    }

    /// <summary>
    /// WebCrawlerConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WebCrawlerConfiguration block(s) allowed")]
    [Obsolete("This block is deprecated.")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlock>? WebCrawlerConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlock>>("web_crawler_configuration");
        set => SetArgument("web_crawler_configuration", value);
    }

}

/// <summary>
/// Block type for s3_configuration in AwsKendraDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsKendraDataSourceConfigurationBlockS3ConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s3_configuration";

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BucketName is required")]
    public required TerraformValue<string> BucketName
    {
        get => GetArgument<TerraformValue<string>>("bucket_name");
        set => SetArgument("bucket_name", value);
    }

    /// <summary>
    /// The exclusion_patterns attribute.
    /// </summary>
    public TerraformSet<string>? ExclusionPatterns
    {
        get => GetArgument<TerraformSet<string>>("exclusion_patterns");
        set => SetArgument("exclusion_patterns", value);
    }

    /// <summary>
    /// The inclusion_patterns attribute.
    /// </summary>
    public TerraformSet<string>? InclusionPatterns
    {
        get => GetArgument<TerraformSet<string>>("inclusion_patterns");
        set => SetArgument("inclusion_patterns", value);
    }

    /// <summary>
    /// The inclusion_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? InclusionPrefixes
    {
        get => GetArgument<TerraformSet<string>>("inclusion_prefixes");
        set => SetArgument("inclusion_prefixes", value);
    }

    /// <summary>
    /// AccessControlListConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessControlListConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockS3ConfigurationBlockAccessControlListConfigurationBlock>? AccessControlListConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockS3ConfigurationBlockAccessControlListConfigurationBlock>>("access_control_list_configuration");
        set => SetArgument("access_control_list_configuration", value);
    }

    /// <summary>
    /// DocumentsMetadataConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DocumentsMetadataConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockS3ConfigurationBlockDocumentsMetadataConfigurationBlock>? DocumentsMetadataConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockS3ConfigurationBlockDocumentsMetadataConfigurationBlock>>("documents_metadata_configuration");
        set => SetArgument("documents_metadata_configuration", value);
    }

}

/// <summary>
/// Block type for access_control_list_configuration in AwsKendraDataSourceConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlockS3ConfigurationBlockAccessControlListConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "access_control_list_configuration";

    /// <summary>
    /// The key_path attribute.
    /// </summary>
    public TerraformValue<string>? KeyPath
    {
        get => GetArgument<TerraformValue<string>>("key_path");
        set => SetArgument("key_path", value);
    }

}

/// <summary>
/// Block type for documents_metadata_configuration in AwsKendraDataSourceConfigurationBlockS3ConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlockS3ConfigurationBlockDocumentsMetadataConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "documents_metadata_configuration";

    /// <summary>
    /// The s3_prefix attribute.
    /// </summary>
    public TerraformValue<string>? S3Prefix
    {
        get => GetArgument<TerraformValue<string>>("s3_prefix");
        set => SetArgument("s3_prefix", value);
    }

}

/// <summary>
/// Block type for template_configuration in AwsKendraDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlockTemplateConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "template_configuration";

    /// <summary>
    /// The template attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Template is required")]
    public required TerraformValue<string> Template
    {
        get => GetArgument<TerraformValue<string>>("template");
        set => SetArgument("template", value);
    }

}

/// <summary>
/// Block type for web_crawler_configuration in AwsKendraDataSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
[Obsolete("This block is deprecated.")]
public class AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "web_crawler_configuration";

    /// <summary>
    /// The crawl_depth attribute.
    /// </summary>
    public TerraformValue<double>? CrawlDepth
    {
        get => GetArgument<TerraformValue<double>>("crawl_depth");
        set => SetArgument("crawl_depth", value);
    }

    /// <summary>
    /// The max_content_size_per_page_in_mega_bytes attribute.
    /// </summary>
    public TerraformValue<double>? MaxContentSizePerPageInMegaBytes
    {
        get => GetArgument<TerraformValue<double>>("max_content_size_per_page_in_mega_bytes");
        set => SetArgument("max_content_size_per_page_in_mega_bytes", value);
    }

    /// <summary>
    /// The max_links_per_page attribute.
    /// </summary>
    public TerraformValue<double>? MaxLinksPerPage
    {
        get => GetArgument<TerraformValue<double>>("max_links_per_page");
        set => SetArgument("max_links_per_page", value);
    }

    /// <summary>
    /// The max_urls_per_minute_crawl_rate attribute.
    /// </summary>
    public TerraformValue<double>? MaxUrlsPerMinuteCrawlRate
    {
        get => GetArgument<TerraformValue<double>>("max_urls_per_minute_crawl_rate");
        set => SetArgument("max_urls_per_minute_crawl_rate", value);
    }

    /// <summary>
    /// The url_exclusion_patterns attribute.
    /// </summary>
    public TerraformSet<string>? UrlExclusionPatterns
    {
        get => GetArgument<TerraformSet<string>>("url_exclusion_patterns");
        set => SetArgument("url_exclusion_patterns", value);
    }

    /// <summary>
    /// The url_inclusion_patterns attribute.
    /// </summary>
    public TerraformSet<string>? UrlInclusionPatterns
    {
        get => GetArgument<TerraformSet<string>>("url_inclusion_patterns");
        set => SetArgument("url_inclusion_patterns", value);
    }

    /// <summary>
    /// AuthenticationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthenticationConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockAuthenticationConfigurationBlock>? AuthenticationConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockAuthenticationConfigurationBlock>>("authentication_configuration");
        set => SetArgument("authentication_configuration", value);
    }

    /// <summary>
    /// ProxyConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ProxyConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockProxyConfigurationBlock>? ProxyConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockProxyConfigurationBlock>>("proxy_configuration");
        set => SetArgument("proxy_configuration", value);
    }

    /// <summary>
    /// Urls block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Urls is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Urls block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Urls block(s) allowed")]
    public required TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlock> Urls
    {
        get => GetRequiredArgument<TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlock>>("urls");
        set => SetArgument("urls", value);
    }

}

/// <summary>
/// Block type for authentication_configuration in AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockAuthenticationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "authentication_configuration";

    /// <summary>
    /// BasicAuthentication block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 BasicAuthentication block(s) allowed")]
    public TerraformSet<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockAuthenticationConfigurationBlockBasicAuthenticationBlock>? BasicAuthentication
    {
        get => GetArgument<TerraformSet<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockAuthenticationConfigurationBlockBasicAuthenticationBlock>>("basic_authentication");
        set => SetArgument("basic_authentication", value);
    }

}

/// <summary>
/// Block type for basic_authentication in AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockAuthenticationConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockAuthenticationConfigurationBlockBasicAuthenticationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "basic_authentication";

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Credentials is required")]
    public required TerraformValue<string> Credentials
    {
        get => GetArgument<TerraformValue<string>>("credentials");
        set => SetArgument("credentials", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for proxy_configuration in AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockProxyConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "proxy_configuration";

    /// <summary>
    /// The credentials attribute.
    /// </summary>
    public TerraformValue<string>? Credentials
    {
        get => GetArgument<TerraformValue<string>>("credentials");
        set => SetArgument("credentials", value);
    }

    /// <summary>
    /// The host attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}

/// <summary>
/// Block type for urls in AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "urls";

    /// <summary>
    /// SeedUrlConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SeedUrlConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlockSeedUrlConfigurationBlock>? SeedUrlConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlockSeedUrlConfigurationBlock>>("seed_url_configuration");
        set => SetArgument("seed_url_configuration", value);
    }

    /// <summary>
    /// SiteMapsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SiteMapsConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlockSiteMapsConfigurationBlock>? SiteMapsConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlockSiteMapsConfigurationBlock>>("site_maps_configuration");
        set => SetArgument("site_maps_configuration", value);
    }

}

/// <summary>
/// Block type for seed_url_configuration in AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlockSeedUrlConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "seed_url_configuration";

    /// <summary>
    /// The seed_urls attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SeedUrls is required")]
    public required TerraformSet<string> SeedUrls
    {
        get => GetArgument<TerraformSet<string>>("seed_urls");
        set => SetArgument("seed_urls", value);
    }

    /// <summary>
    /// The web_crawler_mode attribute.
    /// </summary>
    public TerraformValue<string>? WebCrawlerMode
    {
        get => GetArgument<TerraformValue<string>>("web_crawler_mode");
        set => SetArgument("web_crawler_mode", value);
    }

}

/// <summary>
/// Block type for site_maps_configuration in AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceConfigurationBlockWebCrawlerConfigurationBlockUrlsBlockSiteMapsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "site_maps_configuration";

    /// <summary>
    /// The site_maps attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SiteMaps is required")]
    public required TerraformSet<string> SiteMaps
    {
        get => GetArgument<TerraformSet<string>>("site_maps");
        set => SetArgument("site_maps", value);
    }

}


/// <summary>
/// Block type for custom_document_enrichment_configuration in AwsKendraDataSource.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_document_enrichment_configuration";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// InlineConfigurations block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 InlineConfigurations block(s) allowed")]
    public TerraformSet<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlock>? InlineConfigurations
    {
        get => GetArgument<TerraformSet<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlock>>("inline_configurations");
        set => SetArgument("inline_configurations", value);
    }

    /// <summary>
    /// PostExtractionHookConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PostExtractionHookConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlock>? PostExtractionHookConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlock>>("post_extraction_hook_configuration");
        set => SetArgument("post_extraction_hook_configuration", value);
    }

    /// <summary>
    /// PreExtractionHookConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PreExtractionHookConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlock>? PreExtractionHookConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlock>>("pre_extraction_hook_configuration");
        set => SetArgument("pre_extraction_hook_configuration", value);
    }

}

/// <summary>
/// Block type for inline_configurations in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlock.
/// Nesting mode: set
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "inline_configurations";

    /// <summary>
    /// The document_content_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? DocumentContentDeletion
    {
        get => GetArgument<TerraformValue<bool>>("document_content_deletion");
        set => SetArgument("document_content_deletion", value);
    }

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// Target block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Target block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockTargetBlock>? Target
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockTargetBlock>>("target");
        set => SetArgument("target", value);
    }

}

/// <summary>
/// Block type for condition in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// The condition_document_attribute_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionDocumentAttributeKey is required")]
    public required TerraformValue<string> ConditionDocumentAttributeKey
    {
        get => GetArgument<TerraformValue<string>>("condition_document_attribute_key");
        set => SetArgument("condition_document_attribute_key", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// ConditionOnValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionOnValue block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockConditionBlockConditionOnValueBlock>? ConditionOnValue
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockConditionBlockConditionOnValueBlock>>("condition_on_value");
        set => SetArgument("condition_on_value", value);
    }

}

/// <summary>
/// Block type for condition_on_value in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockConditionBlockConditionOnValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_on_value";

    /// <summary>
    /// The date_value attribute.
    /// </summary>
    public TerraformValue<string>? DateValue
    {
        get => GetArgument<TerraformValue<string>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// The long_value attribute.
    /// </summary>
    public TerraformValue<double>? LongValue
    {
        get => GetArgument<TerraformValue<double>>("long_value");
        set => SetArgument("long_value", value);
    }

    /// <summary>
    /// The string_list_value attribute.
    /// </summary>
    public TerraformSet<string>? StringListValue
    {
        get => GetArgument<TerraformSet<string>>("string_list_value");
        set => SetArgument("string_list_value", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

}

/// <summary>
/// Block type for target in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockTargetBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target";

    /// <summary>
    /// The target_document_attribute_key attribute.
    /// </summary>
    public TerraformValue<string>? TargetDocumentAttributeKey
    {
        get => GetArgument<TerraformValue<string>>("target_document_attribute_key");
        set => SetArgument("target_document_attribute_key", value);
    }

    /// <summary>
    /// The target_document_attribute_value_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? TargetDocumentAttributeValueDeletion
    {
        get => GetArgument<TerraformValue<bool>>("target_document_attribute_value_deletion");
        set => SetArgument("target_document_attribute_value_deletion", value);
    }

    /// <summary>
    /// TargetDocumentAttributeValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetDocumentAttributeValue block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockTargetBlockTargetDocumentAttributeValueBlock>? TargetDocumentAttributeValue
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockTargetBlockTargetDocumentAttributeValueBlock>>("target_document_attribute_value");
        set => SetArgument("target_document_attribute_value", value);
    }

}

/// <summary>
/// Block type for target_document_attribute_value in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockTargetBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockInlineConfigurationsBlockTargetBlockTargetDocumentAttributeValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_document_attribute_value";

    /// <summary>
    /// The date_value attribute.
    /// </summary>
    public TerraformValue<string>? DateValue
    {
        get => GetArgument<TerraformValue<string>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// The long_value attribute.
    /// </summary>
    public TerraformValue<double>? LongValue
    {
        get => GetArgument<TerraformValue<double>>("long_value");
        set => SetArgument("long_value", value);
    }

    /// <summary>
    /// The string_list_value attribute.
    /// </summary>
    public TerraformSet<string>? StringListValue
    {
        get => GetArgument<TerraformSet<string>>("string_list_value");
        set => SetArgument("string_list_value", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

}

/// <summary>
/// Block type for post_extraction_hook_configuration in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "post_extraction_hook_configuration";

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// InvocationCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InvocationCondition block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlockInvocationConditionBlock>? InvocationCondition
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlockInvocationConditionBlock>>("invocation_condition");
        set => SetArgument("invocation_condition", value);
    }

}

/// <summary>
/// Block type for invocation_condition in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlockInvocationConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "invocation_condition";

    /// <summary>
    /// The condition_document_attribute_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionDocumentAttributeKey is required")]
    public required TerraformValue<string> ConditionDocumentAttributeKey
    {
        get => GetArgument<TerraformValue<string>>("condition_document_attribute_key");
        set => SetArgument("condition_document_attribute_key", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// ConditionOnValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionOnValue block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlockInvocationConditionBlockConditionOnValueBlock>? ConditionOnValue
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlockInvocationConditionBlockConditionOnValueBlock>>("condition_on_value");
        set => SetArgument("condition_on_value", value);
    }

}

/// <summary>
/// Block type for condition_on_value in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlockInvocationConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPostExtractionHookConfigurationBlockInvocationConditionBlockConditionOnValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_on_value";

    /// <summary>
    /// The date_value attribute.
    /// </summary>
    public TerraformValue<string>? DateValue
    {
        get => GetArgument<TerraformValue<string>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// The long_value attribute.
    /// </summary>
    public TerraformValue<double>? LongValue
    {
        get => GetArgument<TerraformValue<double>>("long_value");
        set => SetArgument("long_value", value);
    }

    /// <summary>
    /// The string_list_value attribute.
    /// </summary>
    public TerraformSet<string>? StringListValue
    {
        get => GetArgument<TerraformSet<string>>("string_list_value");
        set => SetArgument("string_list_value", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

}

/// <summary>
/// Block type for pre_extraction_hook_configuration in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pre_extraction_hook_configuration";

    /// <summary>
    /// The lambda_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LambdaArn is required")]
    public required TerraformValue<string> LambdaArn
    {
        get => GetArgument<TerraformValue<string>>("lambda_arn");
        set => SetArgument("lambda_arn", value);
    }

    /// <summary>
    /// The s3_bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "S3Bucket is required")]
    public required TerraformValue<string> S3Bucket
    {
        get => GetArgument<TerraformValue<string>>("s3_bucket");
        set => SetArgument("s3_bucket", value);
    }

    /// <summary>
    /// InvocationCondition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InvocationCondition block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlockInvocationConditionBlock>? InvocationCondition
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlockInvocationConditionBlock>>("invocation_condition");
        set => SetArgument("invocation_condition", value);
    }

}

/// <summary>
/// Block type for invocation_condition in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlockInvocationConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "invocation_condition";

    /// <summary>
    /// The condition_document_attribute_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConditionDocumentAttributeKey is required")]
    public required TerraformValue<string> ConditionDocumentAttributeKey
    {
        get => GetArgument<TerraformValue<string>>("condition_document_attribute_key");
        set => SetArgument("condition_document_attribute_key", value);
    }

    /// <summary>
    /// The operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OperatorAttribute is required")]
    public required TerraformValue<string> OperatorAttribute
    {
        get => GetArgument<TerraformValue<string>>("operator");
        set => SetArgument("operator", value);
    }

    /// <summary>
    /// ConditionOnValue block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConditionOnValue block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlockInvocationConditionBlockConditionOnValueBlock>? ConditionOnValue
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlockInvocationConditionBlockConditionOnValueBlock>>("condition_on_value");
        set => SetArgument("condition_on_value", value);
    }

}

/// <summary>
/// Block type for condition_on_value in AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlockInvocationConditionBlock.
/// Nesting mode: list
/// </summary>
public class AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlockPreExtractionHookConfigurationBlockInvocationConditionBlockConditionOnValueBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition_on_value";

    /// <summary>
    /// The date_value attribute.
    /// </summary>
    public TerraformValue<string>? DateValue
    {
        get => GetArgument<TerraformValue<string>>("date_value");
        set => SetArgument("date_value", value);
    }

    /// <summary>
    /// The long_value attribute.
    /// </summary>
    public TerraformValue<double>? LongValue
    {
        get => GetArgument<TerraformValue<double>>("long_value");
        set => SetArgument("long_value", value);
    }

    /// <summary>
    /// The string_list_value attribute.
    /// </summary>
    public TerraformSet<string>? StringListValue
    {
        get => GetArgument<TerraformSet<string>>("string_list_value");
        set => SetArgument("string_list_value", value);
    }

    /// <summary>
    /// The string_value attribute.
    /// </summary>
    public TerraformValue<string>? StringValue
    {
        get => GetArgument<TerraformValue<string>>("string_value");
        set => SetArgument("string_value", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsKendraDataSource.
/// Nesting mode: single
/// </summary>
public class AwsKendraDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a aws_kendra_data_source Terraform resource.
/// Manages a aws_kendra_data_source resource.
/// </summary>
public partial class AwsKendraDataSource(string name) : TerraformResource("aws_kendra_data_source", name)
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
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The index_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IndexId is required")]
    public required TerraformValue<string> IndexId
    {
        get => GetArgument<TerraformValue<string>>("index_id");
        set => SetArgument("index_id", value);
    }

    /// <summary>
    /// The language_code attribute.
    /// </summary>
    public TerraformValue<string>? LanguageCode
    {
        get => GetArgument<TerraformValue<string>>("language_code");
        set => SetArgument("language_code", value);
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
    /// The role_arn attribute.
    /// </summary>
    public TerraformValue<string>? RoleArn
    {
        get => GetArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

    /// <summary>
    /// The schedule attribute.
    /// </summary>
    public TerraformValue<string>? Schedule
    {
        get => GetArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
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
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

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
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformValue<string> CreatedAt
        => AsReference("created_at");

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformValue<string> DataSourceId
        => AsReference("data_source_id");

    /// <summary>
    /// The error_message attribute.
    /// </summary>
    public TerraformValue<string> ErrorMessage
        => AsReference("error_message");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The updated_at attribute.
    /// </summary>
    public TerraformValue<string> UpdatedAt
        => AsReference("updated_at");

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

    /// <summary>
    /// CustomDocumentEnrichmentConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomDocumentEnrichmentConfiguration block(s) allowed")]
    public TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlock>? CustomDocumentEnrichmentConfiguration
    {
        get => GetArgument<TerraformList<AwsKendraDataSourceCustomDocumentEnrichmentConfigurationBlock>>("custom_document_enrichment_configuration");
        set => SetArgument("custom_document_enrichment_configuration", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsKendraDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsKendraDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
