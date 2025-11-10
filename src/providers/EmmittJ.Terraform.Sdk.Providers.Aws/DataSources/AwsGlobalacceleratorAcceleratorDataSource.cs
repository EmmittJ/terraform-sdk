using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_globalaccelerator_accelerator.
/// </summary>
public class AwsGlobalacceleratorAcceleratorDataSource : TerraformDataSource
{
    public AwsGlobalacceleratorAcceleratorDataSource(string name) : base("aws_globalaccelerator_accelerator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("attributes");
        SetOutput("dns_name");
        SetOutput("dual_stack_dns_name");
        SetOutput("enabled");
        SetOutput("hosted_zone_id");
        SetOutput("id");
        SetOutput("ip_address_type");
        SetOutput("ip_sets");
        SetOutput("tags");
        SetOutput("arn");
        SetOutput("name");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The attributes attribute.
    /// </summary>
    public TerraformExpression Attributes => this["attributes"];

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformExpression DnsName => this["dns_name"];

    /// <summary>
    /// The dual_stack_dns_name attribute.
    /// </summary>
    public TerraformExpression DualStackDnsName => this["dual_stack_dns_name"];

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    public TerraformExpression Enabled => this["enabled"];

    /// <summary>
    /// The hosted_zone_id attribute.
    /// </summary>
    public TerraformExpression HostedZoneId => this["hosted_zone_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The ip_address_type attribute.
    /// </summary>
    public TerraformExpression IpAddressType => this["ip_address_type"];

    /// <summary>
    /// The ip_sets attribute.
    /// </summary>
    public TerraformExpression IpSets => this["ip_sets"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
