using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for attributes in .
/// Nesting mode: list
/// </summary>
public class AwsGlobalacceleratorAcceleratorAttributesBlock : TerraformBlock
{
    /// <summary>
    /// The flow_logs_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? FlowLogsEnabled
    {
        set => SetProperty("flow_logs_enabled", value);
    }

    /// <summary>
    /// The flow_logs_s3_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? FlowLogsS3Bucket
    {
        set => SetProperty("flow_logs_s3_bucket", value);
    }

    /// <summary>
    /// The flow_logs_s3_prefix attribute.
    /// </summary>
    public TerraformProperty<string>? FlowLogsS3Prefix
    {
        set => SetProperty("flow_logs_s3_prefix", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsGlobalacceleratorAcceleratorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_globalaccelerator_accelerator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsGlobalacceleratorAccelerator : TerraformResource
{
    public AwsGlobalacceleratorAccelerator(string name) : base("aws_globalaccelerator_accelerator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("dns_name");
        SetOutput("dual_stack_dns_name");
        SetOutput("hosted_zone_id");
        SetOutput("ip_sets");
        SetOutput("enabled");
        SetOutput("id");
        SetOutput("ip_address_type");
        SetOutput("ip_addresses");
        SetOutput("name");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformProperty<bool> Enabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enabled");
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformProperty<string> IpAddressType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address_type");
        set => SetProperty("ip_address_type", value);
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public List<TerraformProperty<string>> IpAddresses
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("ip_addresses");
        set => SetProperty("ip_addresses", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for attributes.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Attributes block(s) allowed")]
    public List<AwsGlobalacceleratorAcceleratorAttributesBlock>? Attributes
    {
        set => SetProperty("attributes", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsGlobalacceleratorAcceleratorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
    /// The dual_stack_dns_name attribute.
    /// </summary>
    public TerraformExpression DualStackDnsName => this["dual_stack_dns_name"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    public TerraformExpression IpSets => this["ip_sets"];

}
