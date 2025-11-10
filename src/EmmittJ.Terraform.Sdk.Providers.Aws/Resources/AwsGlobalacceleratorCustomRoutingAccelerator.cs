using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public class AwsGlobalacceleratorCustomRoutingAcceleratorAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The flow_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FlowLogsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("flow_logs_enabled");
        set => WithProperty("flow_logs_enabled", value);
    }

    /// <summary>
    /// The flow_logs_s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? FlowLogsS3Bucket
    {
        get => GetProperty<TerraformProperty<string>>("flow_logs_s3_bucket");
        set => WithProperty("flow_logs_s3_bucket", value);
    }

    /// <summary>
    /// The flow_logs_s3_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? FlowLogsS3Prefix
    {
        get => GetProperty<TerraformProperty<string>>("flow_logs_s3_prefix");
        set => WithProperty("flow_logs_s3_prefix", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorCustomRoutingAcceleratorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_globalaccelerator_custom_routing_accelerator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlobalacceleratorCustomRoutingAccelerator : TerraformResource
{
    public AwsGlobalacceleratorCustomRoutingAccelerator(string name) : base("aws_globalaccelerator_custom_routing_accelerator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("ip_sets");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
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
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddressType
    {
        get => GetProperty<TerraformProperty<string>>("ip_address_type");
        set => this.WithProperty("ip_address_type", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>>? IpAddresses
    {
        get => GetProperty<List<TerraformProperty<string>>>("ip_addresses");
        set => this.WithProperty("ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attributes block(s) allowed")]
    public List<AwsGlobalacceleratorCustomRoutingAcceleratorAttributesBlock>? Attributes
    {
        get => GetProperty<List<AwsGlobalacceleratorCustomRoutingAcceleratorAttributesBlock>>("attributes");
        set => this.WithProperty("attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlobalacceleratorCustomRoutingAcceleratorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsGlobalacceleratorCustomRoutingAcceleratorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    public TerraformExpression IpSets => this["ip_sets"];

}
