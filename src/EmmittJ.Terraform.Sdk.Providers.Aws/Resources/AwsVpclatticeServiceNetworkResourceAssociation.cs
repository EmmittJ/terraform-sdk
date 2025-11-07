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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_configuration_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceConfigurationIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_configuration_identifier");
        set => this.WithProperty("resource_configuration_identifier", value);
    }

    /// <summary>
    /// The service_network_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceNetworkIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_network_identifier");
        set => this.WithProperty("service_network_identifier", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
