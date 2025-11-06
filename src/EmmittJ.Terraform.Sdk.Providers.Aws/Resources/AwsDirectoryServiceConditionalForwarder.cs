using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_directory_service_conditional_forwarder resource.
/// </summary>
public class AwsDirectoryServiceConditionalForwarder : TerraformResource
{
    public AwsDirectoryServiceConditionalForwarder(string name) : base("aws_directory_service_conditional_forwarder", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The directory_id attribute.
    /// </summary>
    public string? DirectoryId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("directory_id")?.Value;
        set => this.WithProperty("directory_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dns_ips attribute.
    /// </summary>
    public List<string>? DnsIps
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("dns_ips")?.Value;
        set => this.WithProperty("dns_ips", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The remote_domain_name attribute.
    /// </summary>
    public string? RemoteDomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("remote_domain_name")?.Value;
        set => this.WithProperty("remote_domain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
