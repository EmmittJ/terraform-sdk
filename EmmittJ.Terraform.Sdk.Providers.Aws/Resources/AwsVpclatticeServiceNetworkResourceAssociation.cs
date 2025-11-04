using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpclattice_service_network_resource_association resource.
/// </summary>
public class AwsVpclatticeServiceNetworkResourceAssociation : TerraformResource
{
    public AwsVpclatticeServiceNetworkResourceAssociation(string name) : base("aws_vpclattice_service_network_resource_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("dns_entry");
        this.DeclareOutput("id");
        this.DeclareOutput("tags_all");
    }

    /// <summary>
    /// The resource_configuration_identifier attribute.
    /// </summary>
    public string? ResourceConfigurationIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_configuration_identifier")?.Value;
        set => this.WithProperty("resource_configuration_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_network_identifier attribute.
    /// </summary>
    public string? ServiceNetworkIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_network_identifier")?.Value;
        set => this.WithProperty("service_network_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The dns_entry attribute.
    /// </summary>
    public TerraformExpression DnsEntry => this["dns_entry"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
