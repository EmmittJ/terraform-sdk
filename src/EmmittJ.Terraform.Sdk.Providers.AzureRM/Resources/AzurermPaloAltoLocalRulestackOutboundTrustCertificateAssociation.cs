using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_outbound_trust_certificate_association resource.
/// </summary>
public class AzurermPaloAltoLocalRulestackOutboundTrustCertificateAssociation : TerraformResource
{
    public AzurermPaloAltoLocalRulestackOutboundTrustCertificateAssociation(string name) : base("azurerm_palo_alto_local_rulestack_outbound_trust_certificate_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? CertificateId
    {
        get => GetProperty<TerraformProperty<string>>("certificate_id");
        set => this.WithProperty("certificate_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
