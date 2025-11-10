using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_service.
/// </summary>
public class AwsServiceDataSource : TerraformDataSource
{
    public AwsServiceDataSource(string name) : base("aws_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("partition");
        SetOutput("supported");
        SetOutput("dns_name");
        SetOutput("id");
        SetOutput("region");
        SetOutput("reverse_dns_name");
        SetOutput("reverse_dns_prefix");
        SetOutput("service_id");
    }

    /// <summary>
    /// The dns_name attribute.
    /// </summary>
    public TerraformProperty<string> DnsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dns_name");
        set => SetProperty("dns_name", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The reverse_dns_name attribute.
    /// </summary>
    public TerraformProperty<string> ReverseDnsName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reverse_dns_name");
        set => SetProperty("reverse_dns_name", value);
    }

    /// <summary>
    /// The reverse_dns_prefix attribute.
    /// </summary>
    public TerraformProperty<string> ReverseDnsPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("reverse_dns_prefix");
        set => SetProperty("reverse_dns_prefix", value);
    }

    /// <summary>
    /// The service_id attribute.
    /// </summary>
    public TerraformProperty<string> ServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_id");
        set => SetProperty("service_id", value);
    }

    /// <summary>
    /// The partition attribute.
    /// </summary>
    public TerraformExpression Partition => this["partition"];

    /// <summary>
    /// The supported attribute.
    /// </summary>
    public TerraformExpression Supported => this["supported"];

}
