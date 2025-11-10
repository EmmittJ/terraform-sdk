using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for off_peak_window_options in .
/// Nesting mode: list
/// </summary>
public class AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => WithProperty("enabled", value);
    }

    /// <summary>
    /// The off_peak_window attribute.
    /// </summary>
    public List<TerraformProperty<object>>? OffPeakWindow
    {
        get => GetProperty<List<TerraformProperty<object>>>("off_peak_window");
        set => WithProperty("off_peak_window", value);
    }

}

/// <summary>
/// Retrieves information about a aws_opensearch_domain.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsOpensearchDomainDataSource : TerraformDataSource
{
    public AwsOpensearchDomainDataSource(string name) : base("aws_opensearch_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("access_policies");
        this.DeclareOutput("advanced_options");
        this.DeclareOutput("advanced_security_options");
        this.DeclareOutput("arn");
        this.DeclareOutput("auto_tune_options");
        this.DeclareOutput("cluster_config");
        this.DeclareOutput("cognito_options");
        this.DeclareOutput("created");
        this.DeclareOutput("dashboard_endpoint");
        this.DeclareOutput("dashboard_endpoint_v2");
        this.DeclareOutput("deleted");
        this.DeclareOutput("domain_endpoint_v2_hosted_zone_id");
        this.DeclareOutput("domain_id");
        this.DeclareOutput("ebs_options");
        this.DeclareOutput("encryption_at_rest");
        this.DeclareOutput("endpoint");
        this.DeclareOutput("endpoint_v2");
        this.DeclareOutput("engine_version");
        this.DeclareOutput("ip_address_type");
        this.DeclareOutput("log_publishing_options");
        this.DeclareOutput("node_to_node_encryption");
        this.DeclareOutput("processing");
        this.DeclareOutput("snapshot_options");
        this.DeclareOutput("software_update_options");
        this.DeclareOutput("vpc_options");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformProperty<string> DomainName
    {
        get => GetProperty<TerraformProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for off_peak_window_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OffPeakWindowOptions block(s) allowed")]
    public List<AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock>? OffPeakWindowOptions
    {
        get => GetProperty<List<AwsOpensearchDomainDataSourceOffPeakWindowOptionsBlock>>("off_peak_window_options");
        set => this.WithProperty("off_peak_window_options", value);
    }

    /// <summary>
    /// The access_policies attribute.
    /// </summary>
    public TerraformExpression AccessPolicies => this["access_policies"];

    /// <summary>
    /// The advanced_options attribute.
    /// </summary>
    public TerraformExpression AdvancedOptions => this["advanced_options"];

    /// <summary>
    /// The advanced_security_options attribute.
    /// </summary>
    public TerraformExpression AdvancedSecurityOptions => this["advanced_security_options"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The auto_tune_options attribute.
    /// </summary>
    public TerraformExpression AutoTuneOptions => this["auto_tune_options"];

    /// <summary>
    /// The cluster_config attribute.
    /// </summary>
    public TerraformExpression ClusterConfig => this["cluster_config"];

    /// <summary>
    /// The cognito_options attribute.
    /// </summary>
    public TerraformExpression CognitoOptions => this["cognito_options"];

    /// <summary>
    /// The created attribute.
    /// </summary>
    public TerraformExpression Created => this["created"];

    /// <summary>
    /// The dashboard_endpoint attribute.
    /// </summary>
    public TerraformExpression DashboardEndpoint => this["dashboard_endpoint"];

    /// <summary>
    /// The dashboard_endpoint_v2 attribute.
    /// </summary>
    public TerraformExpression DashboardEndpointV2 => this["dashboard_endpoint_v2"];

    /// <summary>
    /// The deleted attribute.
    /// </summary>
    public TerraformExpression Deleted => this["deleted"];

    /// <summary>
    /// The domain_endpoint_v2_hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression DomainEndpointV2HostedZoneId => this["domain_endpoint_v2_hosted_zone_id"];

    /// <summary>
    /// The domain_id attribute.
    /// </summary>
    public TerraformExpression DomainId => this["domain_id"];

    /// <summary>
    /// The ebs_options attribute.
    /// </summary>
    public TerraformExpression EbsOptions => this["ebs_options"];

    /// <summary>
    /// The encryption_at_rest attribute.
    /// </summary>
    public TerraformExpression EncryptionAtRest => this["encryption_at_rest"];

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The endpoint_v2 attribute.
    /// </summary>
    public TerraformExpression EndpointV2 => this["endpoint_v2"];

    /// <summary>
    /// The engine_version attribute.
    /// </summary>
    public TerraformExpression EngineVersion => this["engine_version"];

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformExpression IpAddressType => this["ip_address_type"];

    /// <summary>
    /// The log_publishing_options attribute.
    /// </summary>
    public TerraformExpression LogPublishingOptions => this["log_publishing_options"];

    /// <summary>
    /// The node_to_node_encryption attribute.
    /// </summary>
    public TerraformExpression NodeToNodeEncryption => this["node_to_node_encryption"];

    /// <summary>
    /// The processing attribute.
    /// </summary>
    public TerraformExpression Processing => this["processing"];

    /// <summary>
    /// The snapshot_options attribute.
    /// </summary>
    public TerraformExpression SnapshotOptions => this["snapshot_options"];

    /// <summary>
    /// The software_update_options attribute.
    /// </summary>
    public TerraformExpression SoftwareUpdateOptions => this["software_update_options"];

    /// <summary>
    /// The vpc_options attribute.
    /// </summary>
    public TerraformExpression VpcOptions => this["vpc_options"];

}
