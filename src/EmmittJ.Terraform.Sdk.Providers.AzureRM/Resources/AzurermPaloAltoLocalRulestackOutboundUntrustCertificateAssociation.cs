using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_palo_alto_local_rulestack_outbound_untrust_certificate_association resource.
/// </summary>
public class AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociation : TerraformResource
{
    public AzurermPaloAltoLocalRulestackOutboundUntrustCertificateAssociation(string name) : base("azurerm_palo_alto_local_rulestack_outbound_untrust_certificate_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The certificate_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CertificateId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("certificate_id");
        set => this.WithProperty("certificate_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
