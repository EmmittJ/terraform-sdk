using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_globalaccelerator_accelerator resource.
/// </summary>
public class AwsGlobalacceleratorAccelerator : TerraformResource
{
    public AwsGlobalacceleratorAccelerator(string name) : base("aws_globalaccelerator_accelerator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_name");
        this.DeclareOutput("dual_stack_dns_name");
        this.DeclareOutput("hosted_zone_id");
        this.DeclareOutput("ip_sets");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public string? IpAddressType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_address_type")?.Value;
        set => this.WithProperty("ip_address_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ip_addresses attribute.
    /// </summary>
    public List<string>? IpAddresses
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("ip_addresses")?.Value;
        set => this.WithProperty("ip_addresses", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
