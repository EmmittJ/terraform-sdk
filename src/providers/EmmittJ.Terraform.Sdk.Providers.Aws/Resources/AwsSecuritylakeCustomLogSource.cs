using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in AwsSecuritylakeCustomLogSource.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeCustomLogSourceConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "configuration";

    /// <summary>
    /// CrawlerConfiguration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeCustomLogSourceConfigurationBlockCrawlerConfigurationBlock>? CrawlerConfiguration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeCustomLogSourceConfigurationBlockCrawlerConfigurationBlock>>("crawler_configuration");
        set => SetArgument("crawler_configuration", value);
    }

    /// <summary>
    /// ProviderIdentity block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeCustomLogSourceConfigurationBlockProviderIdentityBlock>? ProviderIdentity
    {
        get => GetArgument<TerraformList<AwsSecuritylakeCustomLogSourceConfigurationBlockProviderIdentityBlock>>("provider_identity");
        set => SetArgument("provider_identity", value);
    }

}

/// <summary>
/// Block type for crawler_configuration in AwsSecuritylakeCustomLogSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeCustomLogSourceConfigurationBlockCrawlerConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "crawler_configuration";

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => new TerraformReference<string>(this, "role_arn");
        set => SetArgument("role_arn", value);
    }

}

/// <summary>
/// Block type for provider_identity in AwsSecuritylakeCustomLogSourceConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsSecuritylakeCustomLogSourceConfigurationBlockProviderIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "provider_identity";

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExternalId is required")]
    public required TerraformValue<string> ExternalId
    {
        get => new TerraformReference<string>(this, "external_id");
        set => SetArgument("external_id", value);
    }

    /// <summary>
    /// The principal attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Principal is required")]
    public required TerraformValue<string> Principal
    {
        get => new TerraformReference<string>(this, "principal");
        set => SetArgument("principal", value);
    }

}


/// <summary>
/// Represents a aws_securitylake_custom_log_source Terraform resource.
/// Manages a aws_securitylake_custom_log_source resource.
/// </summary>
public partial class AwsSecuritylakeCustomLogSource(string name) : TerraformResource("aws_securitylake_custom_log_source", name)
{
    /// <summary>
    /// The event_classes attribute.
    /// </summary>
    public TerraformSet<string>? EventClasses
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "event_classes").ResolveNodes(ctx));
        set => SetArgument("event_classes", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    public required TerraformValue<string> SourceName
    {
        get => new TerraformReference<string>(this, "source_name");
        set => SetArgument("source_name", value);
    }

    /// <summary>
    /// The source_version attribute.
    /// </summary>
    public TerraformValue<string> SourceVersion
    {
        get => new TerraformReference<string>(this, "source_version");
        set => SetArgument("source_version", value);
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Attributes
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "attributes").ResolveNodes(ctx));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The provider_details attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProviderDetails
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "provider_details").ResolveNodes(ctx));
    }

    /// <summary>
    /// Configuration block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsSecuritylakeCustomLogSourceConfigurationBlock>? Configuration
    {
        get => GetArgument<TerraformList<AwsSecuritylakeCustomLogSourceConfigurationBlock>>("configuration");
        set => SetArgument("configuration", value);
    }

}
