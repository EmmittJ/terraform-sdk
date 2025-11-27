using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for off_peak_window_options in AwsOpensearchDomainDataSource.
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "off_peak_window_options";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformValue<bool> Enabled
    {
        get => new TerraformReference<bool>(this, "enabled");
    }

    /// <summary>
    /// The off_peak_window attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> OffPeakWindow
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "off_peak_window").ResolveNodes(ctx));
    }

}


/// <summary>
/// Represents a aws_opensearch_domain Terraform data source.
/// Retrieves information about a aws_opensearch_domain.
/// </summary>
public partial class AwsOpensearchDomainDataSource(string name) : TerraformDataSource("aws_opensearch_domain", name)
{
    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => new TerraformReference<string>(this, "domain_name");
        set => SetArgument("domain_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public TerraformValue<string> AccessPolicies
    {
        get => new TerraformReference<string>(this, "access_policies");
    }

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public TerraformMap<string> AdvancedOptions
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "advanced_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The advanced_security_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AdvancedSecurityOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "advanced_security_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The auto_tune_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoTuneOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "auto_tune_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cluster_config attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ClusterConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cluster_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The cognito_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CognitoOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "cognito_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformValue<bool> Created
    {
        get => new TerraformReference<bool>(this, "created");
    }

    /// <summary>
    /// The dashboard_endpoint attribute.
    /// </summary>
    public TerraformValue<string> DashboardEndpoint
    {
        get => new TerraformReference<string>(this, "dashboard_endpoint");
    }

    /// <summary>
    /// The dashboard_endpoint_v2 attribute.
    /// </summary>
    public TerraformValue<string> DashboardEndpointV2
    {
        get => new TerraformReference<string>(this, "dashboard_endpoint_v2");
    }

    /// <summary>
    /// The deleted attribute.
    /// </summary>
    public TerraformValue<bool> Deleted
    {
        get => new TerraformReference<bool>(this, "deleted");
    }

    /// <summary>
    /// The domain_endpoint_v2_hosted_zone_id attribute.
    /// </summary>
    public TerraformValue<string> DomainEndpointV2HostedZoneId
    {
        get => new TerraformReference<string>(this, "domain_endpoint_v2_hosted_zone_id");
    }

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformValue<string> DomainId
    {
        get => new TerraformReference<string>(this, "domain_id");
    }

    /// <summary>
    /// The ebs_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EbsOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ebs_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The encryption_at_rest attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EncryptionAtRest
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "encryption_at_rest").ResolveNodes(ctx));
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformValue<string> Endpoint
    {
        get => new TerraformReference<string>(this, "endpoint");
    }

    /// <summary>
    /// The endpoint_v2 attribute.
    /// </summary>
    public TerraformValue<string> EndpointV2
    {
        get => new TerraformReference<string>(this, "endpoint_v2");
    }

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformValue<string> EngineVersion
    {
        get => new TerraformReference<string>(this, "engine_version");
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformValue<string> IpAddressType
    {
        get => new TerraformReference<string>(this, "ip_address_type");
    }

    /// <summary>
    /// The log_publishing_options attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> LogPublishingOptions
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "log_publishing_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The node_to_node_encryption attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> NodeToNodeEncryption
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "node_to_node_encryption").ResolveNodes(ctx));
    }

    /// <summary>
    /// The processing attribute.
    /// </summary>
    public TerraformValue<bool> Processing
    {
        get => new TerraformReference<bool>(this, "processing");
    }

    /// <summary>
    /// The snapshot_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SnapshotOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "snapshot_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The software_update_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SoftwareUpdateOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "software_update_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The vpc_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> VpcOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "vpc_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// OffPeakWindowOptions block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OffPeakWindowOptions block(s) allowed")]
    public TerraformList<AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock>? OffPeakWindowOptions
    {
        get => GetArgument<TerraformList<AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock>>("off_peak_window_options");
        set => SetArgument("off_peak_window_options", value);
    }

}
