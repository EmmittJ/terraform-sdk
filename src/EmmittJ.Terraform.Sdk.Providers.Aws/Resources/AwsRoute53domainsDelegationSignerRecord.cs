using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_route53domains_delegation_signer_record resource.
/// </summary>
public class AwsRoute53domainsDelegationSignerRecord : TerraformResource
{
    public AwsRoute53domainsDelegationSignerRecord(string name) : base("aws_route53domains_delegation_signer_record", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dnssec_key_id");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("domain_name");
        set => this.WithProperty("domain_name", value);
    }

    /// <summary>
    /// The dnssec_key_id attribute.
    /// </summary>
    public TerraformExpression DnssecKeyId => this["dnssec_key_id"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
